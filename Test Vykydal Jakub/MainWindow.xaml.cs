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

namespace Test_Vykydal_Jakub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Nakladak auto1;
        public int Naklad;

        public int MaxNosnost { get; }

        public MainWindow(int maxNosnost)
        {
            MaxNosnost=maxNosnost;
        }

        public MainWindow()
        {
            InitializeComponent();
            auto1 = new Nakladak();
            ShowVehicle(auto1, txt1);
        }
        

        public void ShowVehicle(Nakladak auto1, TextBox txt1)
        {
            txt1.Text = $"maxnaklad: {auto1.MaxNosnost}\n";
            txt1.Text += $"naklad: {auto1.Naklad}\n";
            txt1.Text += $"maxpalivo: {auto1.MaxPalivo}\n";
            txt1.Text += $"palivo: {auto1.Palivo}\n";
            txt1.Text += $"vzdalenost: {auto1.Vzdalenost}\n";
            txt1.Text += $"spotreba: {auto1.Spotreba}\n";
        }

        private void Nalozit_Click(object sender, RoutedEventArgs e)
        {
            auto1.Nalozit();
            ShowVehicle(auto1, txt1);
            
        }



        private void Vylozit_Click(object sender, RoutedEventArgs e)
        {
            auto1.Vylozit();
            ShowVehicle(auto1, txt1);
            
        }

        private void Jet_Click(object sender, RoutedEventArgs e)
        {
            auto1.Jizda();
            auto1.SpoTreba();
            ShowVehicle(auto1, txt1);
            
        }

        private void Tankovat_Click(object sender, RoutedEventArgs e)
        {
            auto1.Natankovat();
            ShowVehicle(auto1, txt1);
            
        }

    }
}    

