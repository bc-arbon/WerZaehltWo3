using BCA.WerZaehltWo3.Common.Eventing;
using BCA.WerZaehltWo3.Shared.Helpers;
using BCA.WerZaehltWo3.Shared.Logic;
using BCA.WerZaehltWo3.Shared.ObjectModel;
using PubSub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WerZaehltWo3.Wpf.Usercontrols
{
    /// <summary>
    /// Interaction logic for CourtSettingsControl.xaml
    /// </summary>
    public partial class CourtSettingsControl : UserControl
    {
        private readonly List<string> players = new List<string>();
        private readonly LimitedStack<string> backups = new LimitedStack<string>(100);
        private PlayerboardManager playerboardManager;
        private Hub hub;
        private Court court = new Court();

        public CourtSettingsControl()
        {
            this.InitializeComponent();            
        }

        public void SetData(Hub hub, PlayerboardManager manager, Court courtData, List<Player> playerlist)
        {
            if (this.hub != null)
            {
                this.hub.Unsubscribe<PlayerBaseChangedEvent>();
            }

            this.hub = hub;
            this.hub.Subscribe<PlayerBaseChangedEvent>(this.PlayerBaseChanged);

            this.playerboardManager = manager;

            this.court = courtData;
            this.LblCourtNumber.Text = courtData.Number.ToString();

            if (courtData.PlayersReady.Player1 != null)
            {
                this.CbxReady1.Text = courtData.PlayersReady.Player1.Name;
            }

            if (courtData.PlayersReady.Player1 != null)
            {
                this.CbxReady2.Text = courtData.PlayersReady.Player2.Name;
            }

            if (courtData.PlayersCount.Player1 != null)
            {
                this.CbxCount1.Text = courtData.PlayersCount.Player1.Name;
            }

            if (courtData.PlayersCount.Player2 != null)
            {
                this.CbxCount2.Text = courtData.PlayersCount.Player2.Name;
            }

            if (courtData.PlayersPlay.Player1 != null)
            {
                this.CbxPlay1.Text = courtData.PlayersPlay.Player1.Name;
            }

            if (courtData.PlayersPlay.Player2 != null)
            {
                this.CbxPlay2.Text = courtData.PlayersPlay.Player2.Name;
            }

            var players = playerlist.Select(player => player.Name).ToList();
            this.SetAutocompletionData(players);

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
            tempCourt.PlayersReady.Player1 = new Player(this.CbxReady1.Text);
            tempCourt.PlayersReady.Player2 = new Player(this.CbxReady2.Text);
            tempCourt.PlayersCount.Player1 = new Player(this.CbxCount1.Text);
            tempCourt.PlayersCount.Player2 = new Player(this.CbxCount2.Text);
            tempCourt.PlayersPlay.Player1 = new Player(this.CbxPlay1.Text);
            tempCourt.PlayersPlay.Player2 = new Player(this.CbxPlay2.Text);
            this.backups.Push(JsonHelper.Save(tempCourt));
            this.BtnUndo.IsEnabled = this.backups.Count > 0;
        }

        private void BtnUndo_Click(object sender, RoutedEventArgs e)
        {
            var tempCourt = (Court)JsonHelper.Load(this.backups.Pop(), typeof(Court));
            this.CbxReady1.Text = tempCourt.PlayersReady.Player1.Name;
            this.CbxReady2.Text = tempCourt.PlayersReady.Player2.Name;
            this.CbxCount1.Text = tempCourt.PlayersCount.Player1.Name;
            this.CbxCount2.Text = tempCourt.PlayersCount.Player2.Name;
            this.CbxPlay1.Text = tempCourt.PlayersPlay.Player1.Name;
            this.CbxPlay2.Text = tempCourt.PlayersPlay.Player2.Name;

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

            this.court.PlayersReady.Player1 = this.playerboardManager.GetPlayer(this.CbxReady1.Text);
            this.court.PlayersReady.Player2 = this.playerboardManager.GetPlayer(this.CbxReady2.Text);
            this.court.PlayersCount.Player1 = this.playerboardManager.GetPlayer(this.CbxCount1.Text);
            this.court.PlayersCount.Player2 = this.playerboardManager.GetPlayer(this.CbxCount2.Text);
            this.court.PlayersPlay.Player1 = this.playerboardManager.GetPlayer(this.CbxPlay1.Text);
            this.court.PlayersPlay.Player2 = this.playerboardManager.GetPlayer(this.CbxPlay2.Text);

            this.hub.Publish<CourtUpdateEvent>(new CourtUpdateEvent(this.court ));
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
