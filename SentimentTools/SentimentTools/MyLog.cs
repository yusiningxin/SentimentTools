using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace SentimentTools
{
    public class MyLog
    {
        public static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void WriteLog(string type,string msg)
        {
            log.Info("【"+type+"】 "+ msg);
        }

    }
}
