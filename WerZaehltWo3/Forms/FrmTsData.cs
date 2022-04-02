using BCA.WerZaehltWo3.Shared.Adapters;
using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using BCA.WerZaehltWo3.Shared.TournamentSoftware;
using BCA.WerZaehltWo3.Usercontrols;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace BCA.WerZaehltWo3.Forms
{
    public partial class FrmTsData : Form
    {
        private readonly AppSettings appSettings;
        private RabbitAdapter rabbitAdapter;

        public FrmTsData()
        {
            this.InitializeComponent();
        }

        public FrmTsData(AppSettings appSettings) : this()
        {
            this.appSettings = appSettings;
        }

        public Playerboard Playerboard { get; set; }

        public void InitializeDisplayControls()
        {
            this.PnlControls.Controls.Clear();
            foreach (var court in this.Playerboard.Courts)
            {
                var settingsControl = new TsCourtControl();
                settingsControl.SetData(court.Number);
                this.PnlControls.Controls.Add(settingsControl);
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // Connect to rabbitmq
            try
            {
                this.rabbitAdapter = new RabbitAdapter(this.TxtRabbitServer.Text, this.TxtRabbitVhost.Text, this.TxtRabbitUser.Text, this.TxtRabbitPassword.Text);
                //this.LblStatusRabbit.Text = "Verbunden";
                //this.LblStatusRabbit.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verbindung zu RabbitMQ Server fehlgeschlagen:\r\n\r\n" + ex, "TsDataServer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var consumer = new EventingBasicConsumer(this.rabbitAdapter.Channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var json = Encoding.UTF8.GetString(body);
                var payload = JsonConvert.DeserializeObject<MatchesPayload>(json);
                Debug.WriteLine(payload.Timestamp);

                foreach (var match in payload.CurrentMatches)
                {
                    foreach (TsCourtControl control in this.PnlControls.Controls)
                    {
                        if (control.CourtNumber == match.Court)
                        {
                            this.Invoke((Action)(() => control.SetPlayerPlay(match.Team1.ToStringShort(), match.Team2.ToStringShort())));
                        }
                    }
                }

                //foreach (var match in payload.PlannedMatches)
                //{
                //    foreach (TsCourtControl control in this.PnlControls.Controls)
                //    {
                //        if (control.CourtNumber == match.Court)
                //        {
                //            control.SetPlayerPlay(match.Team1.ToStringShort(), match.Team2.ToStringShort());
                //        }
                //    }
                //}

                //this.Invoke(() => this.TxtConsume2.Text = message + Environment.NewLine + this.TxtConsume2.Text);
            };
            this.rabbitAdapter.Channel.BasicConsume(queue: RabbitAdapter.QueueName, autoAck: true, consumer: consumer);
        }

        private void FrmTsData_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.appSettings.RabbitServer = this.TxtRabbitServer.Text;
            this.appSettings.RabbitVhost = this.TxtRabbitVhost.Text;
            this.appSettings.RabbitUser = this.TxtRabbitUser.Text;
            this.appSettings.RabbitPassword = this.TxtRabbitPassword.Text;
            AppSettingsLogic.Save(this.appSettings);
        }

        private void FrmTsData_Load(object sender, EventArgs e)
        {
            this.TxtRabbitServer.Text = this.appSettings.RabbitServer;
            this.TxtRabbitVhost.Text = this.appSettings.RabbitVhost;
            this.TxtRabbitUser.Text = this.appSettings.RabbitUser;
            this.TxtRabbitPassword.Text = this.appSettings.RabbitPassword;
        }
    }
}
