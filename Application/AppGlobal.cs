using System;

namespace RelayTest.Application
{
    

    internal class AppGlobal
    {
        //登录用户编号，对应数据库中的F_OPERATOR_ID
        public static string GUserId = "未登录";
        //登录用简写名称，如czy
        public static string GLoginName = "未登录";
        //登录用户名称，如张三
        public static string GUserName = "未登录";
        //是否是管理员
        public static bool GIsAdmin = false;

    }
}
