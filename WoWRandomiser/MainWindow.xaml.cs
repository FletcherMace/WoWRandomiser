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
using WoWRandomiser.WowClasses;

namespace WoWRandomiser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();

        Player player1;
        Player player2;
        Player player3;
        Player player4;
        Player player5;

        List<Player> lst_players = new List<Player>();
        public List<String> lst_Factions = new List<string>(new string[] { "Alliance", "Horde" });

        public int counter = 0;

        public string rFaction = "";

        public bool allowAllied = false;
        public MainWindow()
        {
            InitializeComponent();
            CreatePlayers();
        }

        private void SetPlayerList()
        {
            lst_players.Add(player1);
            lst_players.Add(player2);
            lst_players.Add(player3);
            lst_players.Add(player4);
            lst_players.Add(player5);
        }

        private void GetAllied()
        {
            if(cbx_allied.IsChecked == true)
            {
                allowAllied = true;
            }
            else
            {
                allowAllied = false;
            }
        }
        private void GetFaction()
        {
            if (cbx_alliance.IsChecked == true && cbx_horde.IsChecked == true)
            {
                rFaction = lst_Factions[rnd.Next(lst_Factions.Count)];
            }
            else if (cbx_alliance.IsChecked == true)
            {
                rFaction = lst_Factions[0];
            }
            else if (cbx_horde.IsChecked == true)
            {
                rFaction = lst_Factions[1];
            }
            else
            {
                throw new Exception("No Faction Selected");
            }
            lbl_rfaction.Content = rFaction;
        }

        public void CreatePlayers()
        {
            player1 = new Player(rFaction, allowAllied);
            player2 = new Player(rFaction, allowAllied);
            player3 = new Player(rFaction, allowAllied);
            player4 = new Player(rFaction, allowAllied);
            player5 = new Player(rFaction, allowAllied);
        }

        public void NewPlayers()
        {
            player1.ResetPlayer(rFaction, allowAllied);
            player2.ResetPlayer(rFaction, allowAllied);
            player3.ResetPlayer(rFaction, allowAllied);
            player4.ResetPlayer(rFaction, allowAllied);
            player5.ResetPlayer(rFaction, allowAllied);
        }

        public void SetLabels()
        {
            //Label label = (Label)windowgrid.FindName();
            //label.Content = 
            for(int i = 0; i < 5; i++)
            {
                Player player = lst_players[i];
                Label classLabel = (Label)windowgrid.FindName("lbl_class" + i);
                classLabel.Content = player.Class.ClassName;

                Label raceLabel = (Label)windowgrid.FindName("lbl_race" + i);
                raceLabel.Content = player.Class.Race;

                Label specLabel = (Label)windowgrid.FindName("lbl_spec" + i);
                specLabel.Content = player.Class.Spec;

                Rectangle playerRectangle = (Rectangle)windowgrid.FindName("rec_player" + i);
                playerRectangle.Fill = player.Class.ClassColour;
            }
        }
        private void HideRectangle(Rectangle rectangle)
        {
            rectangle.Visibility = Visibility.Collapsed;
        }

        private void ShowRectangle(Rectangle rectangle)
        {
            rectangle.Visibility = Visibility.Visible;
        }
        private void btn_randomise_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                GetAllied();
                GetFaction();
                NewPlayers();
                SetPlayerList();
                SetLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            
        }

        private void btn_showClass_Click(object sender, RoutedEventArgs e)
        {
            HideRectangle((Rectangle)windowgrid.FindName("rec_front" + counter.ToString()));
            counter++;
        }

        private void btn_resetGrid(object sender, RoutedEventArgs e)
        {
            counter = 0;
            for (int i = 0; i < 5; i++)
            {
                ShowRectangle((Rectangle)windowgrid.FindName("rec_front" + i));
            }
        }
    }
}
