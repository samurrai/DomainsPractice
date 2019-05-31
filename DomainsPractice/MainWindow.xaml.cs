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

namespace DomainsPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void CountButtonClick(object sender, RoutedEventArgs e)
        {
            var countAppDomain = AppDomain.CreateDomain("CombinatoricsApp");
            var countAppPath = AppDomain.CurrentDomain.BaseDirectory + "CombinatoricsApp.exe";
            countAppDomain.ExecuteAssembly(countAppPath);
            AppDomain.Unload(countAppDomain);
        }

        private void LoadFileButtonClick(object sender, RoutedEventArgs e)
        {
            var loadAppDomain = AppDomain.CreateDomain("LoadFile");
            var loadAppPath = AppDomain.CurrentDomain.BaseDirectory + "LoadFile.exe";
            loadAppDomain.ExecuteAssembly(loadAppPath);
            AppDomain.Unload(loadAppDomain);
        }
    }
}
