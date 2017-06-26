using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//串口设置表
		public partial class BllCOM_SETTINGS:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllCOM_SETTINGS));
   		     
		private readonly RelayTest.DAL.DalCOM_SETTINGS dal=new RelayTest.DAL.DalCOM_SETTINGS();
		public BllCOM_SETTINGS()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_WORKSTATION_ID,string F_COM_CODE)
		{
		
			try
            {
                Log.Info("BllCOM_SETTINGS->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_WORKSTATION_ID,F_COM_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelCOM_SETTINGS model)
		{
		
			try
            {
                Log.Info("BllCOM_SETTINGS->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelCOM_SETTINGS model)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKSTATION_ID,string F_COM_CODE)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_WORKSTATION_ID,F_COM_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKSTATION_ID,string F_COM_CODE)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_WORKSTATION_ID,F_COM_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKSTATION_ID,string F_COM_CODE)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_WORKSTATION_ID,F_COM_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_WORKSTATION_ID,string F_COM_CODE)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_WORKSTATION_ID,F_COM_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelCOM_SETTINGS GetModel(string F_WORKSTATION_ID,string F_COM_CODE)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_WORKSTATION_ID,F_COM_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelCOM_SETTINGS> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelCOM_SETTINGS> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllCOM_SETTINGS->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelCOM_SETTINGS> modelList = new List<RelayTest.Model.ModelCOM_SETTINGS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelCOM_SETTINGS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelCOM_SETTINGS();					
																	model.F_WORKSTATION_ID= dt.Rows[n]["F_WORKSTATION_ID"].ToString();
																																model.F_COM_CODE= dt.Rows[n]["F_COM_CODE"].ToString();
																												if(dt.Rows[n]["F_BAUDRATE"].ToString()!="")
				{
					model.F_BAUDRATE=decimal.Parse(dt.Rows[n]["F_BAUDRATE"].ToString());
				}
																																if(dt.Rows[n]["F_DATABIT"].ToString()!="")
				{
					model.F_DATABIT=decimal.Parse(dt.Rows[n]["F_DATABIT"].ToString());
				}
																																if(dt.Rows[n]["F_ODDEVENCHECK"].ToString()!="")
				{
					model.F_ODDEVENCHECK=decimal.Parse(dt.Rows[n]["F_ODDEVENCHECK"].ToString());
				}
																																if(dt.Rows[n]["F_STOPBIT"].ToString()!="")
				{
					model.F_STOPBIT=decimal.Parse(dt.Rows[n]["F_STOPBIT"].ToString());
				}
																																				model.F_TYPE= dt.Rows[n]["F_TYPE"].ToString();
																												if(dt.Rows[n]["F_STREAMCONTROL"].ToString()!="")
				{
					model.F_STREAMCONTROL=decimal.Parse(dt.Rows[n]["F_STREAMCONTROL"].ToString());
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
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllCOM_SETTINGS->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllCOM_SETTINGS->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllCOM_SETTINGS->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllCOM_SETTINGS->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}