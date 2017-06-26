using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//工作模式试验程序信息表
		public partial class BllPAR_COMMAND_WORKTYPE:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllPAR_COMMAND_WORKTYPE));
   		     
		private readonly RelayTest.DAL.DalPAR_COMMAND_WORKTYPE dal=new RelayTest.DAL.DalPAR_COMMAND_WORKTYPE();
		public BllPAR_COMMAND_WORKTYPE()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(decimal F_ID)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelPAR_COMMAND_WORKTYPE model)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_WORKTYPE model)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(decimal F_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_WORKTYPE GetModel(decimal F_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_WORKTYPE> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_WORKTYPE> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelPAR_COMMAND_WORKTYPE> modelList = new List<RelayTest.Model.ModelPAR_COMMAND_WORKTYPE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelPAR_COMMAND_WORKTYPE model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelPAR_COMMAND_WORKTYPE();					
													if(dt.Rows[n]["F_ID"].ToString()!="")
				{
					model.F_ID=decimal.Parse(dt.Rows[n]["F_ID"].ToString());
				}
																																				model.F_WORKTYPE_NAME= dt.Rows[n]["F_WORKTYPE_NAME"].ToString();
																																model.F_WORKTYPE_CODE= dt.Rows[n]["F_WORKTYPE_CODE"].ToString();
																																model.F_PROGRAMM_CODE= dt.Rows[n]["F_PROGRAMM_CODE"].ToString();
																																model.F_PROGRAMM_DESC= dt.Rows[n]["F_PROGRAMM_DESC"].ToString();
																																model.F_WORKTYPE_MEMO= dt.Rows[n]["F_WORKTYPE_MEMO"].ToString();
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
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetModelList---finally");
            }
			
		}
#endregion

        #region 自定义函数

        /// <summary>
        /// 获得指定编号的记录数量
        /// tempId   工作模式id
        /// 返回值：指定编号的记录行
        /// </summary>
        public DataSet GetCount(String tempId)
        {
            try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetCount---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetCount(tempId);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->GetCount---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetCount---finally");
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_forTestManage(string strWhere)
        {
            try
            {
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetList_forTestManage---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList_forTestManage(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_WORKTYPE->GetList_forTestManage---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_WORKTYPE->GetList_forTestManage---finally");
            }
        }
        #endregion
	}
}