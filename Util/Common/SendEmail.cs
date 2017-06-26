using System;
using System.Configuration;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Configuration;

//using System.Net.Mail;

namespace RelayTest.Util.Common
{
    /// <summary>
    /// 邮件处理类
    /// 使用方案一：
    /// 如果要用此类要在web.config中配置
    ///  <system.net>
    ///     <mailSettings>
    ///         <smtp from="邮箱">
    ///             <network host="vhm02.vanceinfo.com" password="密码" userName="邮箱" />
    ///         </smtp>
    ///     </mailSettings>
    /// </summary>
    /// 
    /// 方案二： 点项目或网站-> asp.net配置 -> 应用程序 -> 配置 SMTP 电子邮件设置
    /// 方案三：数据库读取，创建本类对象，设置其属性，调用类函数ToEmail（）发送邮件
    /// 那个邮件，有两种使用方式，一是在web.config设置发送人信息，
    /// 使用时函数会自忆去查web.config中是否有设置，二是把发送人信息存到数据库中，
    /// 函数如果在web.config中查不到，就会读取属性，里的信息，如果你没有设置就会出错，
    /// 如何设置，就是在运行前，用对象去设置属性值=XXXX
    public class SendEmail
    {
        #region 属性
        /// <summary>
        /// 发送人
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 发送邮箱密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 获取或设置指示邮件正文是否为 Html 格式的值  默认：False
        /// </summary>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// 获取或设置用于邮件正文的编码。  默认：UTF8
        /// </summary>
        public Encoding BodyEncoding { get; set; }

        /// <summary>
        /// 获取或设置用于 SMTP 事务的主机的名称或 IP 地址
        /// </summary>
        public String Host { get; set; }

        /// <summary>
        /// 获取或设置用于 SMTP 事务的端口。 默认25
        /// </summary>
        public int Port { get; set; }

        #endregion


        public SendEmail()
        {
            //打开应用程序根目录下的web.config生成System.Configuration.Configuration对象实例   
            Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
            MailSettingsSectionGroup settings = (MailSettingsSectionGroup)config.GetSectionGroup("system.net/mailSettings");

            if (string.IsNullOrEmpty(this.Sender))
            {
                this.Sender = settings.Smtp.Network.UserName;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                this.Sender = settings.Smtp.Network.Password;
            }
            if (string.IsNullOrEmpty(this.Host))
            {
                this.Sender = settings.Smtp.Network.Host;
            }


            IsBodyHtml = false;

            BodyEncoding = System.Text.Encoding.UTF8;

            Port = 25;

        }


        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="Title">邮件标题</param>
        /// <param name="Body">邮件内容</param>
        /// <param name="Address">收件人，list集合</param>
        /// <returns></returns>
        public bool ToEmail(string Title, string Body, string Attendadress, string address)
        {
            MailMessage mm = new MailMessage();

            if (Attendadress != "")
            {
                Attachment objMailAttachment;
                // 创建一个附件对象
                objMailAttachment = new Attachment(Attendadress);//发送邮件的附件
                mm.Attachments.Add(objMailAttachment);//将附件附加到邮件消息对象中
            }
            mm.From = new MailAddress(this.Sender);
            mm.To.Add(new MailAddress(address)); //收件人邮箱地址可以是多个以实现群发
            //Address.ForEach(o => mm.To.Add(new MailAddress(o)));//群发邮件，传入的参数为List<string> Address
            mm.Subject = Title;     //邮件标题
            mm.Body = Body;      //邮件内容
            mm.IsBodyHtml = this.IsBodyHtml;  //是否为html
            mm.BodyEncoding = this.BodyEncoding;    //编码
            SmtpClient sc = new SmtpClient();
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.Host = this.Host;
            sc.Port = this.Port;
            sc.Credentials = new System.Net.NetworkCredential(mm.From.ToString(), this.Password);
            try
            {
                sc.Send(mm);
                //sc.SendAsync(mm, null);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    //    #region 发送邮件 带附件
    //    /// <summary>
    //    /// 发送邮件 带附件
    //    /// </summary>
    //    /// <param name="Title">邮件标题</param>
    //    /// <param name="Body">邮件内容</param>
    //    /// <param name="Address">收件人，list集合</param>
    //    /// <param name="att">附件，list集合  类型：Attachment 实例 ：var attach = new Attachment(@"D:\a.jpg", MediaTypeNames.Image.Jpeg);  var attach2 = new Attachment(@"D:\b.zip", "application/x-zip-compressed");</param>
    //    /// <returns></returns>
    //    public bool ToEmailAttach(string Title, string Body, List<string> Address, List<Attachment> att)
    //    {
    //        MailMessage mm = new MailMessage();
    //        mm.From = new MailAddress(this.Sender);
    //        Address.ForEach(o => mm.To.Add(new MailAddress(o)));
    //        mm.Subject = Title;     //邮件标题
    //        mm.Body = Body;      //邮件内容
    //        att.ForEach(o => mm.Attachments.Add(o));  //添加附件
    //        mm.IsBodyHtml = this.IsBodyHtml;  //是否为html
    //        mm.BodyEncoding = this.BodyEncoding;    //编码
    //        SmtpClient sc = new SmtpClient();
    //        sc.DeliveryMethod = SmtpDeliveryMethod.Network;
    //        sc.Host = this.Host;
    //        sc.Port = this.Port;
    //        sc.Credentials = new System.Net.NetworkCredential(mm.From.ToString(), this.Password);
    //        try
    //        {
    //            sc.Send(mm);
    //            return true;
    //        }
    //        catch (Exception)
    //        {
    //            return false;
    //        }
    //    }
    //    #endregion
  }
}
