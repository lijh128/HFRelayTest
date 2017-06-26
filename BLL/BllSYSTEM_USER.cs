using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //用户表
    public partial class BllSYSTEM_USER : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllSYSTEM_USER));

        private readonly RelayTest.DAL.DalSYSTEM_USER dal = new RelayTest.DAL.DalSYSTEM_USER();
        public BllSYSTEM_USER()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_USER_ID)
        {

            try
            {
                Log.Info("BllSYSTEM_USER->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_USER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_USER model)
        {

            try
            {
                Log.Info("BllSYSTEM_USER->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelSYSTEM_USER model)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_USER_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_USER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_USER_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_USER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_USER_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_USER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_USER_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_USER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_USER GetModel(string F_USER_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_USER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_USER> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_USER> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllSYSTEM_USER->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelSYSTEM_USER> modelList = new List<RelayTest.Model.ModelSYSTEM_USER>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelSYSTEM_USER model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelSYSTEM_USER();

                        //用户编号
                        model.F_USER_ID = dt.Rows[n]["F_USER_ID"].ToString();

                        //真实姓名
                        model.F_USER_NAME = dt.Rows[n]["F_USER_NAME"].ToString();

                        //密码
                        model.F_PASSWORD = dt.Rows[n]["F_PASSWORD"].ToString();

                        //联系电话
                        model.F_PHONE = dt.Rows[n]["F_PHONE"].ToString();

                        //是否是上位机用户
                        if (dt.Rows[n]["F_ISSWJ"].ToString() != "")
                        {
                            model.F_ISSWJ = decimal.Parse(dt.Rows[n]["F_ISSWJ"].ToString());
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
                Log.Error("BllSYSTEM_USER->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllSYSTEM_USER->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllSYSTEM_USER->GetModelList---finally");
            }

        }
        #endregion

        #region Extension
        public void ChagePassword(ModelSYSTEM_USER model)
        {
            try
            {
                Log.Info("BllSYSTEM_USER->ChagePassword---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.ChagePassword(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_USER->ChagePassword---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_USER->ChagePassword---finally");

            }

        }
        #endregion

    }
}