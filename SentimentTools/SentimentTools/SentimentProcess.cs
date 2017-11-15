using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace SentimentTools
{
    class SentimentProcess
    {
        public static string getSentenceSentiment(string str)
        {
            string ans = "";
            Process process = new Process();
            process.StartInfo.FileName = Global.path + "\\Debug\\SentenceAnalysis.bat";

            process.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动         
            process.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息          
            process.StartInfo.CreateNoWindow = true;//不显示程序窗口   
            //str += " 1";
            process.StartInfo.Arguments = str+" "+1; //传参数 
            process.Start();
            StreamReader reader = process.StandardOutput;//截取输出流
            while (!reader.EndOfStream)
            {
                ans = reader.ReadLine();
            }
            process.WaitForExit();//等待程序执行完退出进程 　　 　　
            return ans;
        }
    }
}
