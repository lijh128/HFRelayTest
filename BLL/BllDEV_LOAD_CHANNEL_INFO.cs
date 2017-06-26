using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //负载柜试验路数信息
    public partial class BllDEV_LOAD_CHANNEL_INFO : DBBllBase
    {

       //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_LOAD_CHANNEL_INFO));
   		     
		private readonly RelayTest.DAL.DalDEV_LOAD_CHANNEL_INFO dal=new RelayTest.DAL.DalDEV_LOAD_CHANNEL_INFO();
		public BllDEV_LOAD_CHANNEL_INFO()
		{}

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {

            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_LOAD_ID, F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO model)
        {

            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO model)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_LOAD_ID, F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_LOAD_ID, F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_LOAD_ID, F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_LOAD_ID, F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO GetModel(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_LOAD_ID, F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO> modelList = new List<RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO();

                        //负载柜编号
                        model.F_LOAD_ID = dt.Rows[n]["F_LOAD_ID"].ToString();

                        //通道序号
                        model.F_LOAD_CHANNEL_ID = dt.Rows[n]["F_LOAD_CHANNEL_ID"].ToString();

                        //通道名称
                        model.F_LOAD_CHANNEL_NAME = dt.Rows[n]["F_LOAD_CHANNEL_NAME"].ToString();

                        //校准编号
                        model.F_LOAD_CHANNEL_CALIBRATION = dt.Rows[n]["F_LOAD_CHANNEL_CALIBRATION"].ToString();

                        //通道可用状态
                        if (dt.Rows[n]["F_LOAD_CHANNEL_STATUS"].ToString() != "")
                        {
                            model.F_LOAD_CHANNEL_STATUS = decimal.Parse(dt.Rows[n]["F_LOAD_CHANNEL_STATUS"].ToString());
                        }

                        //创建时间
                        if (dt.Rows[n]["F_CREATE_TIME"].ToString() != "")
                        {
                            model.F_CREATE_TIME = DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
                        }

                        //操作员
                        model.F_OPERATOR_ID = dt.Rows[n]["F_OPERATOR_ID"].ToString();

                        //操作时间
                        if (dt.Rows[n]["F_OPERATIONTIME"].ToString() != "")
                        {
                            model.F_OPERATIONTIME = DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
                        }

                        //是否删除
                        if (dt.Rows[n]["F_DEL"].ToString() != "")
                        {
                            model.F_DEL = decimal.Parse(dt.Rows[n]["F_DEL"].ToString());
                        }


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOAD_CHANNEL_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_LOAD_CHANNEL_INFO->GetModelList---finally");
            }

        }
        #endregion
   
    }
}