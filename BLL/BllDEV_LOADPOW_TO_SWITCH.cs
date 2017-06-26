using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//负载电源与供电柜开关关系
		public partial class BllDEV_LOADPOW_TO_SWITCH:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_LOADPOW_TO_SWITCH));
   		     
		private readonly RelayTest.DAL.DalDEV_LOADPOW_TO_SWITCH dal=new RelayTest.DAL.DalDEV_LOADPOW_TO_SWITCH();
		public BllDEV_LOADPOW_TO_SWITCH()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_POWER_ID,string F_POWER_SWITCH_ID,string F_LOADPOWER_ID)
		{
		
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_POWER_ID,F_POWER_SWITCH_ID,F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH model)
		{
		
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH model)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_POWER_ID,string F_POWER_SWITCH_ID,string F_LOADPOWER_ID)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_POWER_ID,F_POWER_SWITCH_ID,F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_POWER_ID,string F_POWER_SWITCH_ID,string F_LOADPOWER_ID)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_POWER_ID,F_POWER_SWITCH_ID,F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_POWER_ID,string F_POWER_SWITCH_ID,string F_LOADPOWER_ID)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_POWER_ID,F_POWER_SWITCH_ID,F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_POWER_ID,string F_POWER_SWITCH_ID,string F_LOADPOWER_ID)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_POWER_ID,F_POWER_SWITCH_ID,F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH GetModel(string F_POWER_ID,string F_POWER_SWITCH_ID,string F_LOADPOWER_ID)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_POWER_ID,F_POWER_SWITCH_ID,F_LOADPOWER_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH> modelList = new List<RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelDEV_LOADPOW_TO_SWITCH();					
										
					//供电柜编号
												model.F_POWER_ID= dt.Rows[n]["F_POWER_ID"].ToString();
																									
					//开关序号
												model.F_POWER_SWITCH_ID= dt.Rows[n]["F_POWER_SWITCH_ID"].ToString();
																									
					//负载电源编号
												model.F_LOADPOWER_ID= dt.Rows[n]["F_LOADPOWER_ID"].ToString();
																									
					//负载电源名称
												model.F_LOADPOWER_NAME= dt.Rows[n]["F_LOADPOWER_NAME"].ToString();
																									
					//备注
												model.F_MEMO= dt.Rows[n]["F_MEMO"].ToString();
																									
					//创建时间
								if(dt.Rows[n]["F_CREATE_TIME"].ToString()!="")
				{
					model.F_CREATE_TIME=DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
				}
																													
					//操作员
												model.F_OPERATOR_ID= dt.Rows[n]["F_OPERATOR_ID"].ToString();
																									
					//操作时间
								if(dt.Rows[n]["F_OPERATIONTIME"].ToString()!="")
				{
					model.F_OPERATIONTIME=DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
				}
																													
					//是否删除
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
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_LOADPOW_TO_SWITCH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_LOADPOW_TO_SWITCH->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}