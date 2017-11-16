using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
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
using System.Xml;

namespace SentimentTools
{
    class Global
    {

        public const string TypeSentenceSentiment = "语句情感分析";
        public const string TypeSentenceCopus = "语句分词处理";
        public const string TypeFileCopus = "文件分词处理";

        public const string CopusTrainFile = "copus_train_text";
        public const string CopusStoplist = "copus_stoplist";       
        public const string CopusResultFile = "dict_onlyfor_copus";
        public const string CopusStatisticResultFile = "dict_onlyfor_copus_statistic";



        public const string logInfoPath = "/logs/logInfo.txt";
        public static string path;
        public static void conf()
        {
            string tmp = Directory.GetCurrentDirectory();
            path = tmp.Substring(0, tmp.LastIndexOf(@"\"));

            Console.WriteLine(path);
            if (Directory.Exists(path + "/default") == false)
            {
                Directory.CreateDirectory(path + "/default");
                MyLog.WriteDebug("Create Directionart default.");
            }
            if (Directory.Exists(path + "/usr") == false)
            {
                Directory.CreateDirectory(path + "/usr");
                MyLog.WriteDebug("Create Directionart usr");
            }
            string xmlpath = path + "/Debug/conf/AppConfig.xml";
            AppConfig.loadXmlFile(xmlpath);


        }
        
      
    }
}
