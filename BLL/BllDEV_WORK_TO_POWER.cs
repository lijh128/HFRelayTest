using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//上位机供电柜设备关系表
		public partial class BllDEV_WORK_TO_POWER:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_WORK_TO_POWER));
   		     
		private readonly RelayTest.DAL.DalDEV_WORK_TO_POWER dal=new RelayTest.DAL.DalDEV_WORK_TO_POWER();
		public BllDEV_WORK_TO_POWER()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_WORKSTATION_ID,string F_POWER_ID)
		{
		
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_WORKSTATION_ID,F_POWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelDEV_WORK_TO_POWER model)
		{
		
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelDEV_WORK_TO_POWER model)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKSTATION_ID,string F_POWER_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_WORKSTATION_ID,F_POWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKSTATION_ID,string F_POWER_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_WORKSTATION_ID,F_POWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKSTATION_ID,string F_POWER_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_WORKSTATION_ID,F_POWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_WORKSTATION_ID,string F_POWER_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_WORKSTATION_ID,F_POWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelDEV_WORK_TO_POWER GetModel(string F_WORKSTATION_ID,string F_POWER_ID)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_WORKSTATION_ID,F_POWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_WORK_TO_POWER> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_WORK_TO_POWER> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelDEV_WORK_TO_POWER> modelList = new List<RelayTest.Model.ModelDEV_WORK_TO_POWER>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelDEV_WORK_TO_POWER model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelDEV_WORK_TO_POWER();					
																	model.F_WORKSTATION_ID= dt.Rows[n]["FMasterId"].ToString();
																																model.F_WORKSTATION_NAME= dt.Rows[n]["F_MASTER_NAME"].ToString();
																																model.F_POWER_ID= dt.Rows[n]["F_POWER_ID"].ToString();
																																model.F_POWER_NAME= dt.Rows[n]["F_POWER_NAME"].ToString();
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
                Log.Error("BllDEV_WORK_TO_POWER->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_WORK_TO_POWER->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllDEV_WORK_TO_POWER->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_WORK_TO_POWER->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_WORK_TO_POWER->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}