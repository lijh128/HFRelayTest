using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//上位机下位机关系表
		public partial class BllDEV_WORK_TO_SUB:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_WORK_TO_SUB));
   		     
		private readonly RelayTest.DAL.DalDEV_WORK_TO_SUB dal=new RelayTest.DAL.DalDEV_WORK_TO_SUB();
		public BllDEV_WORK_TO_SUB()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
		
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_WORKSTATION_ID,F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelDEV_WORK_TO_SUB model)
		{
		
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelDEV_WORK_TO_SUB model)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_WORKSTATION_ID,F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_WORKSTATION_ID,F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_WORKSTATION_ID,F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_WORKSTATION_ID,F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelDEV_WORK_TO_SUB GetModel(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_WORKSTATION_ID,F_SUBORDINATE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_WORK_TO_SUB> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_WORK_TO_SUB> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelDEV_WORK_TO_SUB> modelList = new List<RelayTest.Model.ModelDEV_WORK_TO_SUB>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelDEV_WORK_TO_SUB model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelDEV_WORK_TO_SUB();					
																	model.F_WORKSTATION_ID= dt.Rows[n]["FMasterId"].ToString();
																																model.F_WORKSTATION_NAME= dt.Rows[n]["F_MASTER_NAME"].ToString();
																																model.F_SUBORDINATE_ID= dt.Rows[n]["F_AFFILIATION_ID"].ToString();
																																model.F_SUBORDINATE_NAME= dt.Rows[n]["F_AFFILIATION_NAME"].ToString();
																																model.F_MEMO= dt.Rows[n]["F_MEMO"].ToString();
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
                Log.Error("BllDEV_WORK_TO_SUB->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_SUB->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_SUB->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_SUB->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_WORK_TO_SUB->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}