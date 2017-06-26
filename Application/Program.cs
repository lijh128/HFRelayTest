using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace RelayTest.Application
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                //处理未捕获的异常   
                System.Windows.Forms.Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常   
                System.Windows.Forms.Application.ThreadException += Application_ThreadException;
                //处理非UI线程异常   
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                System.Windows.Forms.Application.EnableVisualStyles();
                System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.Skins.SkinManager.EnableFormSkins();


                //DevExpress.Utils.AppearanceObject.DefaultFont = new Font("宋体", 15);


                (new FrmMain()).ShowDialog();

            }
            catch (Exception ex)
            {
                string str = "";
                string strDateInfo = "出现非控制异常：" + DateTime.Now.ToString() + "\r\n";

                if (ex != null)
                {
                    str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n", ex.GetType().Name,
                                        ex.Message, ex.StackTrace);
                }
                else
                {
                    str = string.Format("应用程序线程错误:{0}", ex);
                }


                writeLog(str);
                MessageBox.Show("主程序中发生一个未知或不可预期错误，错误代码:" + ex.GetHashCode() + "!", "系统错误", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                //Application.Exit();
            }
        }

        /// <summary>
        ///  write error log to text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string str = "";
            string strDateInfo = "出现UI线程的异常：" + DateTime.Now.ToString() + "\r\n";
            Exception error = e.Exception;
            if (error != null)
            {
                str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n", error.GetType().Name,
                                    error.Message, error.StackTrace);
            }
            else
            {
                str = string.Format("应用程序线程错误:{0}", e);
            }

            writeLog(str);
            MessageBox.Show("发生一个未知或不可预期线程错误，错误代码:" + error.GetHashCode() + "!", "系统错误", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            //Application.Exit();
        }

        /// <summary>
        /// UnhandleException 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = "";
            var error = e.ExceptionObject as Exception;
            string strDateInfo = "出现非UI异常：" + DateTime.Now.ToString() + "\r\n";
            if (error != null)
            {
                str = string.Format(strDateInfo + "Application UnhandledException:{0};\n\r堆栈信息:{1}", error.Message,
                                    error.StackTrace);
            }
            else
            {
                str = string.Format("Application UnhandledError:{0}", e);
            }

            writeLog(str);
            MessageBox.Show("发生一个未知或不可预期非线程错误，错误代码:" + error.GetHashCode() + "!", "系统错误", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            //Application.Exit();
        }

        /// <summary>
        /// 写文件
        /// </summary>
        /// <param name="str"></param>
        private static void writeLog(string str)
        {
            if (!Directory.Exists("ErrLog"))
            {
                Directory.CreateDirectory("ErrLog");
            }

            using (var sw = new StreamWriter(@"ErrLog\ErrLog-" + DateTime.Now.ToString("yyyyMMdd") + ".txt", true))
            {
                sw.WriteLine(str);
                sw.WriteLine("---------------------------------------------------------");
                sw.Close();
            }
        }
    }
}