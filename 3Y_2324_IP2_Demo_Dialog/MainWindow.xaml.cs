using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
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

namespace _3Y_2324_IP2_Demo_Dialog
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

        private void btn_01_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is the regular messagebox");
        }

        private void btn_02_Click(object sender, RoutedEventArgs e)
        {
            // 1st - message in the message box (string)
            // 2nd - message box title (string)
            // 3rd - message box buttons (MessageBoxButton)
            // 4th - message box icon (MessageBoxImage)
            MessageBox.Show("This is the regular messagebox"
                ,"This is the title"
                , MessageBoxButton.OK
                , MessageBoxImage.Error);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult mbr = MessageBox.Show(
                "Are you sure you want to close the window?"
                , "I am just making sure..."
                , MessageBoxButton.YesNo
                , MessageBoxImage.Information);

            if(mbr == MessageBoxResult.Yes)
            {
                MessageBox.Show("Okay... Bye...");
            }
            else
            {
                MessageBox.Show("Yaay!");
                e.Cancel = true;
            }
        }

        private void btn_03_Click(object sender, RoutedEventArgs e)
        {
            string path = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "You looking for something?";
            ofd.DefaultExt = "csv";
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "CSV Files (*.csv)|*.csv";

            if ((bool)ofd.ShowDialog())
            {
                path = ofd.FileName;
                lblDisplayFilePath.Content = path;
                lblDisplayFileName.Content = path.Split('\\')[path.Split('\\').Count() - 1];
            }
        }
    }
}
