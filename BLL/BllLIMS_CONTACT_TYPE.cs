using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.DAL;
using log4net;

namespace RelayTest.BLL
{
    /// <summary>
    /// BllLIMS_CONTACT_TYPE
    /// </summary>
    public partial class BllLIMS_CONTACT_TYPE : DBBllBase
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_SAMPLE_INFO));

        private readonly RELAYTEST.DAL.DalLIMS_CONTACT_TYPE dal = new RELAYTEST.DAL.DalLIMS_CONTACT_TYPE();
        public BllLIMS_CONTACT_TYPE()
		{}

        /// <summary>
        /// 根据触点类型，返回相应触点类型的触点名称
        /// </summary>
        public DataSet GetLimsContactName(string contactType)
        {
            try
            {
                Log.Info("BllLIMS_CONTACT_TYPE->GetLimsContactName---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet dataContactName = dal.GetLimsContactName(contactType);
                return dataContactName;
            }
            catch (Exception ex)
            {
                Log.Error("BllLIMS_CONTACT_TYPE->GetLimsContactName---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllLIMS_CONTACT_TYPE->GetLimsContactName---finally");
            }
        }
    }
}
