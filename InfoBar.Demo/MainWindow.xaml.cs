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

namespace InfoBar.Demo
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

        string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.";
        private bool isDark = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage("Test short message", InfoBarStatus.CRITICAL, InfoBarPosition.TOP);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage("Test short message", InfoBarStatus.SUCCESS, InfoBarPosition.TOP);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage("Test short message", InfoBarStatus.CAUTION, InfoBarPosition.TOP);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage("Test short message", InfoBarStatus.ATTENTION, InfoBarPosition.TOP);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage(message, InfoBarStatus.CRITICAL, InfoBarPosition.TOP);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage(message, InfoBarStatus.SUCCESS, InfoBarPosition.TOP);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage(message, InfoBarStatus.CAUTION, InfoBarPosition.TOP);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage(message, InfoBarStatus.ATTENTION, InfoBarPosition.TOP);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            isDark = !isDark;
            ResourceDictionary newTheme = new ResourceDictionary();
            if (isDark == true)
            {
                newTheme.Source = new Uri("pack://application:,,,/InfoBar;component/Resources/Theme.Dark.xaml", UriKind.RelativeOrAbsolute);
            }
            else
            {
                newTheme.Source = new Uri("pack://application:,,,/InfoBar;component/Resources/Theme.Light.xaml", UriKind.RelativeOrAbsolute);
            }
            App.Current.Resources.MergedDictionaries.Add(newTheme);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            InfoBarBox.ShowMessage(message, InfoBarStatus.CRITICAL, InfoBarPosition.BOTTOM);
        }
    }
}
