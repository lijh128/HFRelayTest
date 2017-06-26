using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RelayTest.Util.Common
{
    public static  class SecurityUtil
    {
        /// <summary> 
        /// MD5加密 
        /// </summary> 
        /// <param name="str"></param> 
        /// <returns></returns> 
        public static string Md5(string str)
        {
            MD5 m = new MD5CryptoServiceProvider();
            byte[] s = m.ComputeHash(Encoding.UTF8.GetBytes(str));
            //return BitConverter.ToString(s);
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string. 
            string data="";
            for (int i = 0; i < s.Length; i++)
                data += s[i].ToString("x").PadLeft(2, '0');

            // Return the hexadecimal string. 
            return data;
        }


       /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Encrypt(string Text) 
        {
            return Encrypt(Text,"shishenli");
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text,string sKey) 
        {
            try
            {
                if (Text == null)
                {
                    return "";
                }
                if (Text.Length == 0)
                {
                    return "";
                }
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray;
                inputByteArray = Encoding.Default.GetBytes(Text);
                des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                StringBuilder ret = new StringBuilder();
                foreach (byte b in ms.ToArray())
                {
                    ret.AppendFormat("{0:X2}", b);
                }
                return ret.ToString(); 
            }
            catch (Exception)
            {
                MessageBox.Show("在进行加密运算过程中出现错误，密文被设置成空，请重新操作此过程！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return "";
            }
            
        } 

        
   
 
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Decrypt(string Text) 
        {
            return Decrypt(Text,"shishenl");
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text,string sKey) 
        {
            try
            {
                if (Text == null)
                {
                    return "";
                }
                if (Text.Length == 0)
                {
                    return "";
                }

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                int len;
                len = Text.Length / 2;
                byte[] inputByteArray = new byte[len];
                int x, i;
                for (x = 0; x < len; x++)
                {
                    i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                    inputByteArray[x] = (byte)i;
                }
                des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Encoding.Default.GetString(ms.ToArray()); 
            }
            catch (Exception)
            {
                MessageBox.Show("在进行解密运算过程中出现错误，明文无法显示，请重复此操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return "";
            }
           
        } 
 
  
    }
}
