using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//负载柜实验通道状态流水
		public partial class BllFLOW_LOAD_CANNEL:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllFLOW_LOAD_CANNEL));
   		     
		private readonly RelayTest.DAL.DalFLOW_LOAD_CANNEL dal=new RelayTest.DAL.DalFLOW_LOAD_CANNEL();
		public BllFLOW_LOAD_CANNEL()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(decimal F_ID,string F_LOAD_ID,string F_LOAD_CHANNEL_ID)
		{
		
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelFLOW_LOAD_CANNEL model)
		{
		
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelFLOW_LOAD_CANNEL model)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_ID,string F_LOAD_ID,string F_LOAD_CHANNEL_ID)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_ID,string F_LOAD_ID,string F_LOAD_CHANNEL_ID)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_ID,string F_LOAD_ID,string F_LOAD_CHANNEL_ID)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(decimal F_ID,string F_LOAD_ID,string F_LOAD_CHANNEL_ID)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelFLOW_LOAD_CANNEL GetModel(decimal F_ID,string F_LOAD_ID,string F_LOAD_CHANNEL_ID)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelFLOW_LOAD_CANNEL> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelFLOW_LOAD_CANNEL> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelFLOW_LOAD_CANNEL> modelList = new List<RelayTest.Model.ModelFLOW_LOAD_CANNEL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelFLOW_LOAD_CANNEL model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelFLOW_LOAD_CANNEL();					
													if(dt.Rows[n]["F_ID"].ToString()!="")
				{
					model.F_ID=decimal.Parse(dt.Rows[n]["F_ID"].ToString());
				}
																																				model.F_LOAD_ID= dt.Rows[n]["F_LOAD_ID"].ToString();
																																model.F_LOAD_CHANNEL_ID= dt.Rows[n]["F_LOAD_CHANNEL_ID"].ToString();
																												if(dt.Rows[n]["F_LOAD_CANNEL_STATUS"].ToString()!="")
				{
					model.F_LOAD_CANNEL_STATUS=decimal.Parse(dt.Rows[n]["F_LOAD_CANNEL_STATUS"].ToString());
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
                Log.Error("BllFLOW_LOAD_CANNEL->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllFLOW_LOAD_CANNEL->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllFLOW_LOAD_CANNEL->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllFLOW_LOAD_CANNEL->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllFLOW_LOAD_CANNEL->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}