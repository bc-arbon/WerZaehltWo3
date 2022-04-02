using BCA.WerZaehltWo3.Shared.Eventing;
using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using PubSub;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WerZaehltWo3.Wpf.Usercontrols
{
    public partial class CourtSettingsControl : UserControl
    {
        private readonly List<string> players = new List<string>();
        private readonly LimitedStack<string> backups = new LimitedStack<string>(100);
        private Hub hub;
        private Court court = new Court();

        public CourtSettingsControl()
        {
            this.InitializeComponent();
        }

        public void SetData(Hub hub, Court courtData, List<string> playerlist)
        {
            if (this.hub != null)
            {
                this.hub.Unsubscribe<PlayerBaseChangedEvent>();
            }

            this.hub = hub;
            this.hub.Subscribe<PlayerBaseChangedEvent>(this.PlayerBaseChanged);

            this.court = courtData;
            this.LblCourtNumber.Text = courtData.Number.ToString();

            if (courtData.PlayerReady1 != null)
            {
                this.CbxReady1.Text = courtData.PlayerReady1;
            }

            if (courtData.PlayerReady2 != null)
            {
                this.CbxReady2.Text = courtData.PlayerReady2;
            }

            if (courtData.PlayerCount1 != null)
            {
                this.CbxCount1.Text = courtData.PlayerCount1;
            }

            if (courtData.PlayerCount2 != null)
            {
                this.CbxCount2.Text = courtData.PlayerCount2;
            }

            if (courtData.PlayerPlay1 != null)
            {
                this.CbxPlay1.Text = courtData.PlayerPlay1;
            }

            if (courtData.PlayerPlay2 != null)
            {
                this.CbxPlay2.Text = courtData.PlayerPlay2;
            }

            this.SetAutocompletionData(playerlist);

            this.SaveState();
        }

        public void SetAutocompletionData(List<string> players)
        {
            this.CbxReady1.ItemsSource = players;
            this.CbxReady2.ItemsSource = players;
            this.CbxCount1.ItemsSource = players;
            this.CbxCount2.ItemsSource = players;
            this.CbxPlay1.ItemsSource = players;
            this.CbxPlay2.ItemsSource = players;
        }

        private void SaveState()
        {
            var tempCourt = this.court.Clone();
            tempCourt.PlayerReady1 = this.CbxReady1.Text;
            tempCourt.PlayerReady2 = this.CbxReady2.Text;
            tempCourt.PlayerCount1 = this.CbxCount1.Text;
            tempCourt.PlayerCount2 = this.CbxCount2.Text;
            tempCourt.PlayerPlay1 = this.CbxPlay1.Text;
            tempCourt.PlayerPlay2 = this.CbxPlay2.Text;
            this.backups.Push(JsonHelper.Save(tempCourt));
            this.BtnUndo.IsEnabled = this.backups.Count > 0;
        }

        private void BtnUndo_Click(object sender, RoutedEventArgs e)
        {
            var tempCourt = (Court)JsonHelper.Load(this.backups.Pop(), typeof(Court));
            this.CbxReady1.Text = tempCourt.PlayerReady1;
            this.CbxReady2.Text = tempCourt.PlayerReady2;
            this.CbxCount1.Text = tempCourt.PlayerCount1;
            this.CbxCount2.Text = tempCourt.PlayerCount2;
            this.CbxPlay1.Text = tempCourt.PlayerPlay1;
            this.CbxPlay2.Text = tempCourt.PlayerPlay2;

            this.BtnUndo.IsEnabled = this.backups.Count > 0;
        }

        private void BtnMove_Click(object sender, RoutedEventArgs e)
        {
            this.CbxPlay1.Text = this.CbxCount1.Text;
            this.CbxPlay2.Text = this.CbxCount2.Text;
            this.CbxCount1.Text = this.CbxReady1.Text;
            this.CbxCount2.Text = this.CbxReady2.Text;
            this.CbxReady1.Text = null;
            this.CbxReady2.Text = null;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            this.SaveState();

            this.CbxReady1.Text = null;
            this.CbxReady2.Text = null;
            this.CbxCount1.Text = null;
            this.CbxCount2.Text = null;
            this.CbxPlay1.Text = null;
            this.CbxPlay2.Text = null;
        }

        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            this.SaveState();

            this.court.PlayerReady1 = this.CbxReady1.Text;
            this.court.PlayerReady2 = this.CbxReady2.Text;
            this.court.PlayerCount1 = this.CbxCount1.Text;
            this.court.PlayerCount2 = this.CbxCount2.Text;
            this.court.PlayerPlay1 = this.CbxPlay1.Text;
            this.court.PlayerPlay2 = this.CbxPlay2.Text;

            this.hub.Publish<CourtUpdateEvent>(new CourtUpdateEvent(this.court));
        }
        private void PlayerBaseChanged(PlayerBaseChangedEvent obj)
        {
            this.SetAutocompletionData(obj.Players);
        }

        private void Players_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //var filter = this.players.Where(p => p.Contains(e.Text)).ToList();
            var cbx = (ComboBox)sender;
            //if (filter.Count > 0)
            //{
            cbx.IsDropDownOpen = true;
            //    cbx.ItemsSource = filter;
            //}
            //else
            //{
            //    cbx.IsDropDownOpen = false;
            //    cbx.ItemsSource = null;
            //}
        }
    }
}
