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
using System.IO;

namespace SentimentTools
{
    /// <summary>
    /// TagWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TagWindow : Window
    {
        public TagWindow()
        {
            InitializeComponent();
        }

        private void untagFilePathButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Txt Files (*.txt)|*.txt"
            };
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                String untagFilePath= openFileDialog.FileName;
                this.untagFilePathTextBox.Text = untagFilePath;
                this.tagDetailResultFilePathTextBox.Text = untagFilePath.Substring(0,untagFilePath.Length-4)+"_分词详细结果"+".txt";
                this.tagStatisicResultFilePathTextBox.Text = untagFilePath.Substring(0, untagFilePath.Length - 4) + "_分词统计结果" + ".txt";
            }
        }

        private void defaultStopListRadioButton1_Click(object sender, RoutedEventArgs e)
        {
            if(this.defaultStopListRadioButton1.IsChecked==true)
            {
                this.stopListFilePathTextBox.Visibility = Visibility.Hidden;
                this.stopListFilePathButton.Visibility = Visibility.Hidden;
            }
        }
        private void defaultStopListRadioButton2_Click(object sender, RoutedEventArgs e)
        {
            if (this.defaultStopListRadioButton2.IsChecked == true)
            {
                this.stopListFilePathTextBox.Visibility = Visibility.Visible;
                this.stopListFilePathTextBox.Text = "请输入停用词表文件路径";
                this.stopListFilePathButton.Visibility = Visibility.Visible;
            }
        }

        private void stopListFilePathButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog()
            {
                Filter = "Txt Files (*.txt)|*.txt"
            };
            var result = openFileDialog.ShowDialog();
            if (result == true)
            {
                this.stopListFilePathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void tagDetailResultFilePathButton_Click(object sender, RoutedEventArgs e)
        {
            String tagDetailResultFilePath = this.tagDetailResultFilePathTextBox.Text;
            
            if(File.Exists(@tagDetailResultFilePath))
            {
                System.Diagnostics.Process.Start(tagDetailResultFilePath);
            }
            else
            {
                //MessageBoxResult warning = MessageBox.Show("文件不存在！");
                FlieNotExistHintWindow hintwindow = new FlieNotExistHintWindow();
                hintwindow.Owner = this;
                hintwindow.ShowDialog();
            }
            
        }

        private void tagStatisicResultFilePathButton_Click(object sender, RoutedEventArgs e)
        {
            String tagStatisicResultFilePath = this.tagStatisicResultFilePathTextBox.Text;

            if (File.Exists(tagStatisicResultFilePath))
            {
                System.Diagnostics.Process.Start(tagStatisicResultFilePath);
            }
            else
            {
                FlieNotExistHintWindow hintwindow = new FlieNotExistHintWindow();
                hintwindow.Owner = this;
                hintwindow.ShowDialog();
            }
        }

        private void tagButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void qiutButton_Click(object sender, RoutedEventArgs e)
        {
            //this.Owner.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
