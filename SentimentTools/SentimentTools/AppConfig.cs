using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;


namespace SentimentTools
{
    class AppConfig
    {
        private static Dictionary<string, string> map = new Dictionary<string, string>();
        private static XmlDocument xml = new XmlDocument();
        private static string xmlpath;
        private static XmlNodeList NodeList;
        public static void loadXmlFile(string path)
        {
            xmlpath = path;
            xml.Load(path);
            NodeList = xml.SelectSingleNode("pamameters").ChildNodes; //获取turba节点的所有子节点
            foreach (XmlNode node in NodeList)
            {
                if (node.Name != "#comment")
                {
                    node.InnerText = node.InnerText.Replace("\\", "/");
                    map.Add(node.Name, node.InnerText);
                }
                //Console.WriteLine(node.Name + ":" + node.InnerText);
            }
            addDefaultPath();
        }

        private static void addDefaultPath()
        {

            map[Global.CopusStoplist] = Global.path.Replace("\\","/") + "/default/Copus/stoplist.txt";
        }

        public static void updateMap (string key,string value)
        {
            value = value.Replace("\\", "/");
            if (map.ContainsKey(key))
            {
                map[key] = value;
            }
            else
            {
                map.Add(key, value);
            }

        }

        public static string getPathValue(string key)
        {
            if (map.ContainsKey(key))
            {
                return map[key];
            }
            else
            {
                return "路径不存在";
            }

        }

        public static void updateXml ()
        {
            foreach (XmlNode node in NodeList)
            {
                if (map.ContainsKey(node.Name) && node.Name != map[node.Name])
                {
                    node.InnerText = map[node.Name];
                }
                // Console.WriteLine(node.Name + ":" + node.InnerText);
            }
            xml.Save(xmlpath);
        }

    }
}
