using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
using RelayTest.DAL;

namespace RelayTest.BLL
{
    //下位机基本信息
    public partial class BllDEV_SUBORDINATE_INFO : DBBllBase
    {

       //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_SUBORDINATE_INFO));
   		     
		private readonly RelayTest.DAL.DalDEV_SUBORDINATE_INFO dal=new RelayTest.DAL.DalDEV_SUBORDINATE_INFO();
		public BllDEV_SUBORDINATE_INFO()
		{}

        #region  Method
        /// <summary>
        /// 是否存在该记录fadfdasfasfas
        /// </summary>
        public bool Exists(string F_SUBORDINATE_ID)
        {

            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Exists(F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->Exists---finally");

            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_SUBORDINATE_INFO model)
        {

            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->Add---finally");
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Update(RelayTest.Model.ModelDEV_SUBORDINATE_INFO model)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->Update---finally");
            }

        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_SUBORDINATE_ID)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete(F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->Delete---finally");
            }

        }

        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_SUBORDINATE_ID)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Disabled(F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->Disabled---finally");
            }

        }

        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_SUBORDINATE_ID)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Enabled(F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->Enabled---finally");
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->DropWhere---finally");
            }


        }



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Drop(string F_SUBORDINATE_ID)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Drop(F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->Drop---finally");
            }


        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_SUBORDINATE_INFO GetModel(string F_SUBORDINATE_ID)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetModel(F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->GetModel---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList(Top, strWhere, filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->GetList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_SUBORDINATE_INFO> GetModelList(string strWhere)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet ds = dal.GetList(strWhere);
                return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->GetModelList---finally");
            }

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<RelayTest.Model.ModelDEV_SUBORDINATE_INFO> DataTableToList(DataTable dt)
        {

            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                List<RelayTest.Model.ModelDEV_SUBORDINATE_INFO> modelList = new List<RelayTest.Model.ModelDEV_SUBORDINATE_INFO>();
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    RelayTest.Model.ModelDEV_SUBORDINATE_INFO model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new RelayTest.Model.ModelDEV_SUBORDINATE_INFO();

                        //下位机编号
                        model.F_SUBORDINATE_ID = dt.Rows[n]["F_SUBORDINATE_ID"].ToString();

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

                        //下位机名称
                        model.F_SUBORDINATE_NAME = dt.Rows[n]["F_SUBORDINATE_NAME"].ToString();

                        //校准编号
                        model.F_SUBORDINATE_CALIBRATION = dt.Rows[n]["F_SUBORDINATE_CALIBRATION"].ToString();

                        //下位机地址
                        if (dt.Rows[n]["F_SUBORDINATE_ADDRESS"].ToString() != "")
                        {
                            model.F_SUBORDINATE_ADDRESS = decimal.Parse(dt.Rows[n]["F_SUBORDINATE_ADDRESS"].ToString());
                        }

                        //通信端口地址
                        model.F_COM_ADDRESS = dt.Rows[n]["F_COM_ADDRESS"].ToString();

                        //下位机状态
                        if (dt.Rows[n]["F_SUBORDINATE_STATUS"].ToString() != "")
                        {
                            model.F_SUBORDINATE_STATUS = decimal.Parse(dt.Rows[n]["F_SUBORDINATE_STATUS"].ToString());
                        }

                        //备注
                        model.F_SUBORDINATE_MEMO = dt.Rows[n]["F_SUBORDINATE_MEMO"].ToString();

                        //创建时间
                        if (dt.Rows[n]["F_CREATE_TIME"].ToString() != "")
                        {
                            model.F_CREATE_TIME = DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
                        }

                        //操作员
                        model.F_OPERATOR_ID = dt.Rows[n]["F_OPERATOR_ID"].ToString();


                        modelList.Add(model);
                    }
                }
                return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->DataTableToList---finally");
            }

        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->GetModelList---START");
                return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_SUBORDINATE_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->GetModelList---finally");
            }

        }
        #endregion


        #region Extension
        /// <summary>
        /// 判断下位机是否和其他设备有关系
        /// </summary>
        /// <param name="subordinateId">下位机id</param>
        /// <returns></returns>
        public bool HasRelation(string subordinateId)
        {
            try
            {
                Log.Info("BllDEV_SUBORDINATE_INFO->HasRelation---START");

                bool result = false;

                //声明一个变量
                DataSet dstemp = new DataSet();

                ConnectionOpen();

                //工作站和线圈电源关系
                DalDEV_LOAD_TO_SUB dalDevLoadToSub = new DalDEV_LOAD_TO_SUB();

                dalDevLoadToSub.SetDBAccess(GetDBAccess());


                dstemp = dalDevLoadToSub.GetList("F_SUBORDINATE_ID='" + subordinateId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }

               
                //工作站和下位机关系
                DalDEV_WORK_TO_SUB dalDevWorkToSub = new DalDEV_WORK_TO_SUB();

                dalDevWorkToSub.SetDBAccess(GetDBAccess());


                dstemp = dalDevWorkToSub.GetList("F_SUBORDINATE_ID='" + subordinateId + "'");

                if (dstemp != null && dstemp.Tables.Count > 0)
                {
                    result |= dstemp.Tables[0].Rows.Count > 0;
                }



                return result;

            }
            catch (Exception ex)
            {

                Log.Error("BllDEV_SUBORDINATE_INFO->HasRelation---FAILED", ex);
                throw ex;
            }
            finally
            {

                ConnectionClose();
                Log.Info("BllDEV_SUBORDINATE_INFO->HasRelation---finally");

            }
        }
        #endregion
    }
}