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
        //public static readonly ILog log = LogManager.GetLogger("rizhi");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SentimentClassify(object sender, RoutedEventArgs e)
        {
            string strtxt = SentimentInput.Text.ToString();
            SentimentResult.Text = strtxt;
            MyLog.WriteLog(Global.TypeSentenceSentiment, strtxt);
        }


        private void SentenceCopus(object sender, RoutedEventArgs e)
        {
            string strtxt = CopusInput.Text.ToString();
            CopusResult.Text = CopusProcess.getSentenceCopus(strtxt);
            MyLog.WriteLog(Global.TypeSentenceSentiment, strtxt);

        }
    }
}
