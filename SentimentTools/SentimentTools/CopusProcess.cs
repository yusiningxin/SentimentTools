using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace SentimentTools
{
    public class CopusProcess
    {
       
        public static string getSentenceCopus(string str)
        {
            string ans = "";
            Process process = new Process();
            process.StartInfo.FileName = Global.path+"\\Debug\\SentenceCopus.bat";
          
            process.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动         
            process.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息          
            process.StartInfo.CreateNoWindow = true;//不显示程序窗口           
            process.StartInfo.Arguments = str; //传参数 
            process.Start();
            StreamReader reader = process.StandardOutput;//截取输出流
            reader.ReadLine();
            reader.ReadLine();
            ans = reader.ReadToEnd();         
            process.WaitForExit();//等待程序执行完退出进程 　　 　　
            return ans;
        }

        public static Boolean beginCopus()
        {
           
            Process process = new Process();
            process.StartInfo.FileName = Global.path + "\\Debug\\Copus.bat";

            process.StartInfo.UseShellExecute = false;    //是否使用操作系统shell启动         
            process.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息          
            process.StartInfo.CreateNoWindow = true;//不显示程序窗口           
            process.Start();
            process.WaitForExit();//等待程序执行完退出进程 　　 　　
            return true;
        }

    }
}
