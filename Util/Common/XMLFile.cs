using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace RelayTest.Util.Common
{
    public class XMLFile
    {
        public static void UpdateConfig(string appKey, string appValue)
        {
            var xDoc = new XmlDocument();
            //获取可执行文件的路径和名称 
            xDoc.Load(Application.ExecutablePath + ".config");
            XmlNode xNode = xDoc.SelectSingleNode("//appSettings");
            if (xNode != null)
            {
                var xElem1 = (XmlElement) xNode.SelectSingleNode("//add[@key='" + appKey + "']");
                if (xElem1 != null) xElem1.SetAttribute("value", appValue);
                else
                {
                    XmlElement xElem2 = xDoc.CreateElement("add");
                    xElem2.SetAttribute("key", appKey);
                    xElem2.SetAttribute("value", appValue);
                    xNode.AppendChild(xElem2);
                }
            }
            xDoc.Save(Application.ExecutablePath + ".config");
        }

        public static string GetConfigValue(string key)
        {
            return ConfigurationSettings.AppSettings[key];
        }
    }
}