using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.Copus;

namespace SentimentTools
{
    public class CopusProcess
    {
        public const string sdf = "语句情感分析";
        public static string getSentenceCopus(string str)
        {
            Copus CopusP = new Copus();
            string ans = CopusP.returnString();
            return ans;
        }
    }
}
