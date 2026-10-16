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
using System.Windows.Shapes;

namespace Ranking
{
    /// <summary>
    /// Logika interakcji dla klasy OknoPoFormularzu.xaml
    /// </summary>
    public partial class OknoPoFormularzu : Window
    {
        public OknoPoFormularzu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            OknoPoFormularzu oknoPoFormularzu = this;
            oknoPoFormularzu.Close();
        }
    }
}
