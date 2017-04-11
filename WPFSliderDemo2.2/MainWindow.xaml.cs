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

namespace WPFSliderDemo2._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Animal elukka;
        public MainWindow()
        {
            InitializeComponent();
            // omat alustukset
            elukka = new Animal();
            elukka.Name = "Musti";
            elukka.Happiness = 10;
            MYProgressBar.DataContext = elukka;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // TODO lisätään olion Happiness-ominaisuutta
            elukka.Happiness++;
            textbox.Text = elukka.Happiness.ToString();
        }
    }
}
