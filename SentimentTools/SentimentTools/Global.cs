using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SentimentTools
{
    class Global
    {
        public const string TypeSentenceSentiment = "语句情感分析";
        public const string TypeSentenceCopus = "语句分词处理";
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
            
        }
    }
}
