using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
    //下位机系统更新流水
    public partial class BllDEV_UPGRADERECORD : DBBllBase
    {

      //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_UPGRADERECORD));
   		     
		private readonly RelayTest.DAL.DalDEV_UPGRADERECORD dal=new RelayTest.DAL.DalDEV_UPGRADERECORD();
		public BllDEV_UPGRADERECORD()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(decimal F_DEV_TYPE,string F_DEV_ID,string F_HARDWARE_VERSION,string F_SOFTWARE_VERSION)
		{
		
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_DEV_TYPE,F_DEV_ID,F_HARDWARE_VERSION,F_SOFTWARE_VERSION);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelDEV_UPGRADERECORD model)
		{
		
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelDEV_UPGRADERECORD model)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_DEV_TYPE,string F_DEV_ID,string F_HARDWARE_VERSION,string F_SOFTWARE_VERSION)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_DEV_TYPE,F_DEV_ID,F_HARDWARE_VERSION,F_SOFTWARE_VERSION);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_DEV_TYPE,string F_DEV_ID,string F_HARDWARE_VERSION,string F_SOFTWARE_VERSION)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_DEV_TYPE,F_DEV_ID,F_HARDWARE_VERSION,F_SOFTWARE_VERSION);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_DEV_TYPE,string F_DEV_ID,string F_HARDWARE_VERSION,string F_SOFTWARE_VERSION)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_DEV_TYPE,F_DEV_ID,F_HARDWARE_VERSION,F_SOFTWARE_VERSION);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(decimal F_DEV_TYPE,string F_DEV_ID,string F_HARDWARE_VERSION,string F_SOFTWARE_VERSION)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_DEV_TYPE,F_DEV_ID,F_HARDWARE_VERSION,F_SOFTWARE_VERSION);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelDEV_UPGRADERECORD GetModel(decimal F_DEV_TYPE,string F_DEV_ID,string F_HARDWARE_VERSION,string F_SOFTWARE_VERSION)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_DEV_TYPE,F_DEV_ID,F_HARDWARE_VERSION,F_SOFTWARE_VERSION);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_UPGRADERECORD> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_UPGRADERECORD> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelDEV_UPGRADERECORD> modelList = new List<RelayTest.Model.ModelDEV_UPGRADERECORD>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelDEV_UPGRADERECORD model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelDEV_UPGRADERECORD();					
													if(dt.Rows[n]["F_DEV_TYPE"].ToString()!="")
				{
					model.F_DEV_TYPE=decimal.Parse(dt.Rows[n]["F_DEV_TYPE"].ToString());
				}
																																if(dt.Rows[n]["F_CREATE_TIME"].ToString()!="")
				{
					model.F_CREATE_TIME=DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
				}
																																				model.F_OPERATOR_ID= dt.Rows[n]["F_OPERATOR_ID"].ToString();
																												if(dt.Rows[n]["F_OPERATIONTIME"].ToString()!="")
				{
					model.F_OPERATIONTIME=DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
				}
																																if(dt.Rows[n]["F_DEL"].ToString()!="")
				{
					model.F_DEL=decimal.Parse(dt.Rows[n]["F_DEL"].ToString());
				}
																																				model.F_DEV_ID= dt.Rows[n]["F_DEV_ID"].ToString();
																																model.F_DEV_NAME= dt.Rows[n]["F_DEV_NAME"].ToString();
																																model.F_HARDWARE_VERSION= dt.Rows[n]["F_HARDWARE_VERSION"].ToString();
																																model.F_SOFTWARE_VERSION= dt.Rows[n]["F_SOFTWARE_VERSION"].ToString();
																												if(dt.Rows[n]["F_UPDATE_DATE"].ToString()!="")
				{
					model.F_UPDATE_DATE=DateTime.Parse(dt.Rows[n]["F_UPDATE_DATE"].ToString());
				}
																																if(dt.Rows[n]["F_USED_DATE"].ToString()!="")
				{
					model.F_USED_DATE=DateTime.Parse(dt.Rows[n]["F_USED_DATE"].ToString());
				}
																																								if(dt.Rows[n]["F_ATTATCHMENT"].ToString()!="")
				{
					model.F_ATTATCHMENT= (byte[])dt.Rows[n]["F_ATTATCHMENT"];
				}
																												model.F_MEMO= dt.Rows[n]["F_MEMO"].ToString();
																						
				
					modelList.Add(model);
				}
			}
			return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllDEV_UPGRADERECORD->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_UPGRADERECORD->GetModelList---finally");
            }
			
		}
#endregion


        #region Extension

        /// <summary>
        /// 判断是否有附件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool HasAttatch(ModelDEV_UPGRADERECORD model)
        {
            try
            {
                Log.Info("BllDEV_UPGRADERECORD->HasAttatch---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.HasAttatch(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->HasAttatch---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->HasAttatch---finally");
            }

        }

        /// <summary>
        /// 上传附件
        /// </summary>
        /// <param name="model">相应的数据实体</param>
        /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
        public bool Upload(RelayTest.Model.ModelDEV_UPGRADERECORD model)
        {
            try
            {
                Log.Info("BllDEV_UPGRADERECORD->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Upload(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Update---finally");
            }

        }

        /// <summary>
        /// 获得附件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataSet GetAttatch(ModelDEV_UPGRADERECORD model)
        {
            try
            {
                Log.Info("BllDEV_UPGRADERECORD->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetAttatch(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_UPGRADERECORD->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_UPGRADERECORD->Update---finally");
            }
        }

        #endregion
    }
}