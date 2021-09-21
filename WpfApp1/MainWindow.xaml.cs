using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        public async void ClickMe(object source, RoutedEventArgs args)
        {
            var client = DownloadAsync();
            MessageBox.Show("Sync");
            var content = await client;
        }

        public async Task<string> DownloadAsync()
        {
            var client = new WebClient();
            var html = await client.DownloadStringTaskAsync("https://www.google.com");

            var content = html.Substring(0, 100);
            MessageBox.Show(content);
            client.Dispose();
            return content;
        }
    }
}
