using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using RelayTest.Util.DBUtility;

namespace RelayTest.Util.Common
{

    public struct RecievedMessage
    {
        public string m_index;
        public string m_tag;
        public string m_telNumber;
        public string m_Content;
        public string m_dateTime;
    }


    public struct SendTarget
    {
        public string m_Name;
        public string m_TelNumber;
    }


    /// <summary>
    /// 发送短信需要的一些参数
    /// </summary>
    public class SMSetting
    {
        // COM端口号
     
    }

    public static class ShortMessageSender
    {

        //版权信息是不能修改的，动态库要进行验证。
        private const string COPYRIGHT = "//上海迅赛信息技术有限公司,网址www.xunsai.com//";



        public static uint COMPort { get; set; }

        //波特率
        public static uint BandRate { get; set; }

        // 发送者姓名，如果为“操作员”则读取当前的操作员名称，如果为其他设置内容，则读取设置内容进行发送
        public static string SenderName { get; set; }

        static ShortMessageSender()
        {
            COMPort = 3;
            BandRate = 9600;
            SenderName = "操作员";
            var dataSet = DbHelperSQL.Query("select F_VALUE FROM T_ZJLX_SMSetting where F_KEY='COMPort'");
            if (dataSet != null)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    COMPort = uint.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                }
            }

            dataSet = DbHelperSQL.Query("select F_VALUE FROM T_ZJLX_SMSetting where F_KEY='BandRate'");
            if (dataSet != null)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    BandRate = uint.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                }
            }

            dataSet = DbHelperSQL.Query("select F_VALUE FROM T_ZJLX_SMSetting where F_KEY='SenderName'");
            if (dataSet != null)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    SenderName = dataSet.Tables[0].Rows[0][0].ToString();
                }
            }
            
        }


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        /// 
        [STAThread]

        [DllImport("sms.dll", EntryPoint = "Sms_Connection")]
        public static extern uint Sms_Connection(string CopyRight, uint Com_Port, uint Com_BaudRate, out string Mobile_Type, out string CopyRightToCOM);

        [DllImport("sms.dll", EntryPoint = "Sms_Disconnection")]
        public static extern uint Sms_Disconnection();

        [DllImport("sms.dll", EntryPoint = "Sms_Send")]
        public static extern uint Sms_Send(string Sms_TelNum, string Sms_Text);

        [DllImport("sms.dll", EntryPoint = "Sms_Receive")]
        public static extern uint Sms_Receive(string Sms_Type, out string Sms_Text);

        [DllImport("sms.dll", EntryPoint = "Sms_Delete")]
        public static extern uint Sms_Delete(string Sms_Index);

        [DllImport("sms.dll", EntryPoint = "Sms_AutoFlag")]
        public static extern uint Sms_AutoFlag();

        [DllImport("sms.dll", EntryPoint = "Sms_NewFlag")]
        public static extern uint Sms_NewFlag();



        public static  bool Connection()
        {
            string Mobile_Type, CopyRightToCOM;
            return (Sms_Connection(COPYRIGHT, COMPort, BandRate, out Mobile_Type, out CopyRightToCOM) == 1);
        }



        public static bool Connection(string CopyRight, uint Com_Port, uint Com_BaudRate, out string Mobile_Type, out string CopyRightToCOM)
        {
            return (Sms_Connection(COPYRIGHT, Com_Port, Com_BaudRate, out Mobile_Type, out CopyRightToCOM) == 1); 
        }

        public static void Disconnection()
        {
            Sms_Disconnection();
        }
        public static bool Send(string telNumber, string SendContent)
        {
            return (Sms_Send(telNumber, SendContent) == 1);
        }
        public static bool Receive(string type, out string Text)
        {
            String ReceiveSmsStr = "";
            if (Sms_Receive("4", out ReceiveSmsStr) == 1)
            {
                Text = ReceiveSmsStr;
                return true;
            }
            else
            {
                Text = "读取短信失败";
                return false;
            }
        }


        public static List<RecievedMessage> DisposeRecievedMessage(string recievedMessageText)
        {
            string[] messageRows = recievedMessageText.Split('|');
            List<RecievedMessage> recievedMessages = new List<RecievedMessage>();
            for(int i=0;i<messageRows.Length;i++)
            {
                RecievedMessage recievedMessage = new RecievedMessage();
                if (messageRows[i].Length > 1)
                {
                    string[] oneMessageFields = messageRows[i].Split('#');
                    recievedMessage.m_index = oneMessageFields[0];
                    recievedMessage.m_tag = oneMessageFields[1];
                    recievedMessage.m_telNumber = oneMessageFields[2];
                    recievedMessage.m_Content = oneMessageFields[3];
                    recievedMessage.m_dateTime = oneMessageFields[4];
                    recievedMessages.Add(recievedMessage);
                }
            }
            return recievedMessages;
        }

    }
}
