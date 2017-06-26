using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.DAL;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //角色功能对应关系
    public partial class BllSYSTEM_ROLE_AUTH : DBBllBase
    {

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllSYSTEM_ROLE_AUTH));

        private readonly RelayTest.DAL.DalSYSTEM_ROLE_AUTH dal = new RelayTest.DAL.DalSYSTEM_ROLE_AUTH();
        public BllSYSTEM_ROLE_AUTH()
        { }

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_MODULE_ID, string F_ROLE_ID)
        {

            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_MODULE_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_ROLE_AUTH model)
        {

            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelSYSTEM_ROLE_AUTH model)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_MODULE_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_MODULE_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_MODULE_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_MODULE_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_MODULE_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_MODULE_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_MODULE_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_MODULE_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_ROLE_AUTH GetModel(string F_MODULE_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_MODULE_ID, F_ROLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_ROLE_AUTH> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelSYSTEM_ROLE_AUTH> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelSYSTEM_ROLE_AUTH> modelList = new List<RelayTest.Model.ModelSYSTEM_ROLE_AUTH>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelSYSTEM_ROLE_AUTH model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelSYSTEM_ROLE_AUTH();
                        model.F_MODULE_ID = dt.Rows[n]["F_MODULE_ID"].ToString();
                        model.F_ROLE_ID = dt.Rows[n]["F_ROLE_ID"].ToString();
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


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModelList---finally");
            }

        }
        #endregion



        #region Extension
        /// <summary>
        /// 根据用户获得未授权模块信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public DataSet GetUsersOfRole(string roleId)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetUsersOfRole---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetUsersOfRole(roleId);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetUsersOfRole---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->GetUsersOfRole---finally");
            }

        }


        /// <summary>
        /// 获得一个角色下的功能列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public DataSet GetModulesOfRole(string roleId)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModulesOfRole---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModulesOfRole(roleId);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetModulesOfRole---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModulesOfRole---finally");
            }
        }


        /// <summary>
        /// 授权
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="modelSystemUserRoles">用户角色</param>
        /// <param name="modelSystemRoleAuths">角色功能</param>
        /// <returns></returns>
        public void Auth(string roleId,
            List<ModelSYSTEM_USER_ROLE> modelSystemUserRoles,
                        List<ModelSYSTEM_ROLE_AUTH> modelSystemRoleAuths)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->Auth---START");
                int insertedRowCount = 0;

                //用户角色操作
                DalSYSTEM_USER_ROLE dalSystemUserRole = new DalSYSTEM_USER_ROLE();


                ConnectionOpen();
                
                //连接数据库
                dal.SetDBAccess(GetDBAccess());
                dalSystemUserRole.SetDBAccess(GetDBAccess());

                BeginTransaction();

                //处理用户角色
                //删除以前的数据
                dalSystemUserRole.DropWhere("F_ROLE_ID = '" + roleId + "'");

                //逐条插入
                foreach (ModelSYSTEM_USER_ROLE model in modelSystemUserRoles)
                {
                    dalSystemUserRole.Add(model);
                }

                //处理角色功能
                dal.DropWhere("F_ROLE_ID = '" + roleId + "'");

                //逐条插入
                foreach (ModelSYSTEM_ROLE_AUTH model in modelSystemRoleAuths)
                {
                    dal.Add(model);
                }

                CommitTns();
            }
            catch (Exception ex)
            {
                RollBackTns();
                Log.Error("BllSYSTEM_ROLE_AUTH->AuthUser---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->AuthUser---finally");
            }
        }
        #endregion

        #region 自定义函数
        /// <summary>
        /// 根据用户名获得授权模块信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public DataSet GetModuleOfUser(string userId)
        {
            try
            {
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModuleOfUser---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModuleOfUser(userId);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_ROLE_AUTH->GetModuleOfUser---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_ROLE_AUTH->GetModuleOfUser---finally");
            }

        }


        #endregion

    }
}