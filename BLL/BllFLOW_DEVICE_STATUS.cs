using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验设备状态转换流水
		public partial class BllFLOW_DEVICE_STATUS:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllFLOW_DEVICE_STATUS));
   		     
		private readonly RelayTest.DAL.DalFLOW_DEVICE_STATUS dal=new RelayTest.DAL.DalFLOW_DEVICE_STATUS();
		public BllFLOW_DEVICE_STATUS()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(decimal F_ID)
		{
		
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelFLOW_DEVICE_STATUS model)
		{
		
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelFLOW_DEVICE_STATUS model)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_ID)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_ID)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_ID)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(decimal F_ID)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelFLOW_DEVICE_STATUS GetModel(decimal F_ID)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelFLOW_DEVICE_STATUS> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelFLOW_DEVICE_STATUS> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelFLOW_DEVICE_STATUS> modelList = new List<RelayTest.Model.ModelFLOW_DEVICE_STATUS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelFLOW_DEVICE_STATUS model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelFLOW_DEVICE_STATUS();					
													if(dt.Rows[n]["F_ID"].ToString()!="")
				{
					model.F_ID=decimal.Parse(dt.Rows[n]["F_ID"].ToString());
				}
																																if(dt.Rows[n]["F_DEV_TYPE"].ToString()!="")
				{
					model.F_DEV_TYPE=decimal.Parse(dt.Rows[n]["F_DEV_TYPE"].ToString());
				}
																																				model.F_DEV_CODE= dt.Rows[n]["F_DEV_CODE"].ToString();
																												if(dt.Rows[n]["F_DEV_STATUS"].ToString()!="")
				{
					model.F_DEV_STATUS=decimal.Parse(dt.Rows[n]["F_DEV_STATUS"].ToString());
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
                Log.Error("BllFLOW_DEVICE_STATUS->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_DEVICE_STATUS->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllFLOW_DEVICE_STATUS->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_DEVICE_STATUS->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllFLOW_DEVICE_STATUS->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}