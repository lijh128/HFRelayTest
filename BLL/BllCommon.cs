using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using log4net;
using RelayTest.Util.DBUtility;

namespace RelayTest.BLL
{
    public partial class BllCommon : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllCommon));

        private readonly RelayTest.DAL.DalCommon dal = new RelayTest.DAL.DalCommon();

        public BllCommon()
        {
            
        }


        /// <summary>
        /// 导出到access
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="condition"></param>
        public void FillAccessTableFromOracle(string tablename, string condition,string strDbConn)
        {
            try
            {
                Log.Info("BllCommon->FillAccessTableFromOracle---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.FillAccessTableFromOracle(tablename, condition, strDbConn);
                ConnectionClose();
            }
            catch (Exception ex)
            {
                Log.Error("BllCommon->FillAccessTableFromOracle---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOIL_INFO->FillAccessTableFromOracle---finally");

            }
        }

        /// <summary>
        /// 获得填充下拉选择框内容的数据表
        /// </summary>
        /// <param name="tablename">表明</param>
        /// <param name="condition">条件</param>
        /// <returns></returns>
        public DataSet GetLookUpEditDataSet(string tablename,string condition)
        {
            try
            {
                Log.Info("BllCommon->GetLookUpEditDataSet---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetLookUpEditDataSet(tablename, condition);
            }
            catch (Exception ex)
            {
                Log.Error("BllCommon->GetLookUpEditDataSet---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOIL_INFO->Exists---finally");

            }
        }
    }
}
