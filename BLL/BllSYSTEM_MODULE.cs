using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //模块功能表
    public partial class BllSYSTEM_MODULE : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllSYSTEM_MODULE));

        private readonly RelayTest.DAL.DalSYSTEM_MODULE dal = new RelayTest.DAL.DalSYSTEM_MODULE();
        public BllSYSTEM_MODULE()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_MODULE_ID)
        {

            try
            {
                Log.Info("BllSYSTEM_MODULE->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_MODULE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_MODULE model)
        {

            try
            {
                Log.Info("BllSYSTEM_MODULE->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelSYSTEM_MODULE model)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_MODULE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_MODULE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_MODULE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_MODULE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_MODULE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_MODULE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_MODULE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_MODULE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_MODULE GetModel(string F_MODULE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_MODULE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_MODULE> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_MODULE> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllSYSTEM_MODULE->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelSYSTEM_MODULE> modelList = new List<RelayTest.Model.ModelSYSTEM_MODULE>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelSYSTEM_MODULE model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelSYSTEM_MODULE();
                        model.F_MODULE_ID = dt.Rows[n]["F_MODULE_ID"].ToString();
                        if (dt.Rows[n]["F_CREATE_TIME"].ToString() != "")
                        {
                            model.F_CREATE_TIME = DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
                        }
                        model.F_OPERATOR_ID = dt.Rows[n]["F_OPERATOR_ID"].ToString();
                        if (dt.Rows[n]["F_OPERATIONTIME"].ToString() != "")
                        {
                            model.F_OPERATIONTIME = DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
                        }
                        if (dt.Rows[n]["F_DEL"].ToString() != "")
                        {
                            model.F_DEL = decimal.Parse(dt.Rows[n]["F_DEL"].ToString());
                        }
                        model.F_MODULE_NAME = dt.Rows[n]["F_MODULE_NAME"].ToString();
                        model.F_FULLNAME = dt.Rows[n]["F_FULLNAME"].ToString();
                        model.F_PARENT_MODULE_ID = dt.Rows[n]["F_PARENT_MODULE_ID"].ToString();
                        model.F_ACTION = dt.Rows[n]["F_ACTION"].ToString();
                        model.F_PATH = dt.Rows[n]["F_PATH"].ToString();
                        if (dt.Rows[n]["F_ORDNO"].ToString() != "")
                        {
                            model.F_ORDNO = decimal.Parse(dt.Rows[n]["F_ORDNO"].ToString());
                        }
                        model.F_DESC = dt.Rows[n]["F_DESC"].ToString();
                        model.F_ISADMINONLY = dt.Rows[n]["F_ISADMINONLY"].ToString();


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllSYSTEM_MODULE->GetModelList---finally");
            }

        }
        #endregion

        #region extension
        /// <summary>
        /// 按顺序获得全部记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllMoudle()
        {
            try
            {
                Log.Info("BllSYSTEM_MODULE->GetAllMoudle---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetAllMoudle();
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_MODULE->GetAllMoudle---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_MODULE->GetAllMoudle---finally");
            }


        }
        #endregion


    }
}