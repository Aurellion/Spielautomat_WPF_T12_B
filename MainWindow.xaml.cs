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

namespace Spielautomat_WPF_T12_B
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_Spiel_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int einsatz, guthaben, gewinn;
            guthaben = Convert.ToInt32(TB_Guthaben.Text);
            einsatz = Convert.ToInt32(TBox_Einsatz.Text);
            int z1, z2, z3;
            if(einsatz <= 0)
            {
                MessageBox.Show("Der Einsatz muss größer als Null sein!",
                                "Falscher Einsatz");
            }
            else if(einsatz > guthaben)
            {
                MessageBox.Show("Der Einsatz darf nicht größer als das Guthaben sein!",
                                "Falscher Einsatz");
            }
            else
            {
                guthaben -= einsatz;
                TB_Guthaben.Text = guthaben.ToString();
                z1 = rnd.Next(1, 8);
                z2 = rnd.Next(1, 8);
                z3 = rnd.Next(1, 8);
                TB_Zahl1.Text = z1.ToString();
                TB_Zahl2.Text = z2.ToString();
                TB_Zahl3.Text = z3.ToString();
                if (z1 == z2 && z2 == z3)
                {
                    gewinn = 10 * einsatz;
                    guthaben += gewinn;
                    MessageBox.Show("Hauptgewinn! " + gewinn, "Gewonnen");
                }
                else if (z1==z2||z2==z3||z1==z3)
                {
                    gewinn = 3 * einsatz;
                    guthaben += gewinn;
                    MessageBox.Show("Gewinn! " + gewinn, "Gewonnen");
                }
                else
                {
                    MessageBox.Show("Leider kein Gewinn.", "Verloren");
                }
                TB_Guthaben.Text = guthaben.ToString();

                if (guthaben == 0)
                {
                    MessageBoxResult ergebnis;
                    ergebnis = MessageBox.Show("Neues Spiel?", "Spiel vorbei", MessageBoxButton.YesNo);

                    switch (ergebnis)
                    {
                        case MessageBoxResult.Yes:
                            guthaben = 5;
                            TB_Guthaben.Text = guthaben.ToString();
                            break;
                        case MessageBoxResult.No:
                            Application.Current.Shutdown();
                            break;
                    }
                }
            }
        }
    }
}
