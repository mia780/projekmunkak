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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> nevek { get; set; } = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void nevsorba_rendezz_Click(object sender, RoutedEventArgs e)
        {
            string be=bevitel.Text;
            List<string> list = be.Split(',').ToList(); 
            list.Sort((x, y) => x.CompareTo(y)); ///név szerint sorba rendez 
            nevsor.ItemsSource = list; 
        }

        private void szavakra_bontas_Click(object sender, RoutedEventArgs e)
        {
            string be = bevitel.Text;
            List<string> list = be.Split(',').ToList();
            listafelsorol.ItemsSource = list;
        }
    }
}
