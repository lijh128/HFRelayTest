using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//温度传感器监测流水信息
		public partial class BllFLOW_SENSOR_DATA:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllFLOW_SENSOR_DATA));
   		     
		private readonly RelayTest.DAL.DalFLOW_SENSOR_DATA dal=new RelayTest.DAL.DalFLOW_SENSOR_DATA();
		public BllFLOW_SENSOR_DATA()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(decimal F__ID)
		{
		
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F__ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelFLOW_SENSOR_DATA model)
		{
		
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelFLOW_SENSOR_DATA model)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F__ID)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F__ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F__ID)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F__ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F__ID)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F__ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(decimal F__ID)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F__ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelFLOW_SENSOR_DATA GetModel(decimal F__ID)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F__ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelFLOW_SENSOR_DATA> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelFLOW_SENSOR_DATA> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelFLOW_SENSOR_DATA> modelList = new List<RelayTest.Model.ModelFLOW_SENSOR_DATA>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelFLOW_SENSOR_DATA model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelFLOW_SENSOR_DATA();					
													if(dt.Rows[n]["F__ID"].ToString()!="")
				{
					model.F__ID=decimal.Parse(dt.Rows[n]["F__ID"].ToString());
				}
																																				model.F_SENSOR_ID= dt.Rows[n]["F_SENSOR_ID"].ToString();
																												if(dt.Rows[n]["F_SENDOR_VALUE"].ToString()!="")
				{
					model.F_SENDOR_VALUE=decimal.Parse(dt.Rows[n]["F_SENDOR_VALUE"].ToString());
				}
																																if(dt.Rows[n]["F_SENSOR_VALUE_TIME"].ToString()!="")
				{
					model.F_SENSOR_VALUE_TIME=DateTime.Parse(dt.Rows[n]["F_SENSOR_VALUE_TIME"].ToString());
				}
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
                Log.Error("BllFLOW_SENSOR_DATA->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_SENSOR_DATA->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllFLOW_SENSOR_DATA->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_SENSOR_DATA->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllFLOW_SENSOR_DATA->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}