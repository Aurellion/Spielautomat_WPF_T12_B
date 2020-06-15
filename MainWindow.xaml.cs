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

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            //Farbe ändern

            //if (Rechteck_1.Fill == Brushes.Cyan)
            //{
            //    Rechteck_1.Fill = Brushes.Magenta;
            //}
            //else
            //{
            //    Rechteck_1.Fill = Brushes.Cyan;
            //}
            Rechteck_1.Fill = (Rechteck_1.Fill == Brushes.Cyan) ? Brushes.Magenta : Brushes.Cyan;

            //Eingabe--Ausgabe

            //string eingabe;
            //eingabe = Eingabefeld.Text;
            //Ausgabefeld.Text = eingabe;
            Ausgabefeld.Text = Eingabefeld.Text;
        }

        private void BTN_Add_Click(object sender, RoutedEventArgs e)
        {
            int a, b, summe;
            a = Convert.ToInt32(TB_A.Text);
            b = Convert.ToInt32(TB_B.Text);
            summe = a + b;
            TB_AB.Text = summe.ToString();
            TB_A.Text = "";
            TB_B.Text = "";
        }
    }
}
