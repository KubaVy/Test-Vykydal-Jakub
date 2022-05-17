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
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Nalozit_Click(object sender, RoutedEventArgs e)
        {
            int naklad = +1000;
            if (maxNosnost == 3000)
            {
                naklad =+0;
            }
           
        }

        private void Vylozit_Click(object sender, RoutedEventArgs e)
        {
            int naklad = -1000;
            if (naklad == 0)
            {
                naklad =-0;
            }
        }

        private void Jet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Tankovat_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
