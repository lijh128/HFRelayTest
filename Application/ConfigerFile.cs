using System;
using System.IO;

namespace RelayTest.Application
{
    internal class ConfigerFile
    {
        public static string ReadConfigure(string name)
        {

            try
            {
                StreamReader sr = new StreamReader(name);
                String line;
                if ((line = sr.ReadLine()) != null)
                {
                    return line;
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static bool WriteConfiguer(string name ,string line)
        {
            try
            {
                FileStream fs = new FileStream(name, FileMode.Create);
                //实例化一个StreamWriter-->与fs相关联
                StreamWriter sw = new StreamWriter(fs);
                //开始写入
                sw.Write(line);
                //清空缓冲区
                sw.Flush();
                //关闭流
                sw.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}