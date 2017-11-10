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

namespace SentimentTools
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void functionMenu_Initialized(object sender, EventArgs e)
        {
            this.functionMenu.ContextMenu = null;
        }


        private void functionMenu_Click(object sender, RoutedEventArgs e)
        {
            this.functionContextMenu.PlacementTarget = this.functionMenu;
            this.functionContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            this.functionContextMenu.IsOpen = true;
        }

        private void helpMenu_Initialized(object sender, EventArgs e)
        {
            this.functionMenu.ContextMenu = null;
        }


        private void helpMenu_Click(object sender, RoutedEventArgs e)
        {
            this.helpContextMenu.PlacementTarget = this.helpMenu;
            this.helpContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            this.helpContextMenu.IsOpen = true;
        }

        private void quitButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void tagButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sentimentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tagFunction_Click(object sender, RoutedEventArgs e)
        {
            TagWindow tagwindow = new TagWindow();
            tagwindow.Owner = this;
            tagwindow.Show();
        }
    }
}
