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

namespace WpfApp30._1
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
        Bankrekening Brekening;
        Figuur figuur;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Brekening = new Bankrekening();
            figuur = new Figuur();
        }

        private void btnBerekenIntrest_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Brekening.ToString());
        }

        private void btnBerekenOpp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(figuur.ToString());
        }
    }
}
