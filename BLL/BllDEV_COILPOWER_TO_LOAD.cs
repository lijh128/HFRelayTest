using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//线圈电源与负载柜关系
		public partial class BllDEV_COILPOWER_TO_LOAD:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllDEV_COILPOWER_TO_LOAD));
   		     
		private readonly RelayTest.DAL.DalDEV_COILPOWER_TO_LOAD dal=new RelayTest.DAL.DalDEV_COILPOWER_TO_LOAD();
		public BllDEV_COILPOWER_TO_LOAD()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_COILPOWER_ID,string F_LOAD_ID)
		{
		
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_COILPOWER_ID,F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD model)
		{
		
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD model)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_COILPOWER_ID,string F_LOAD_ID)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_COILPOWER_ID,F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_COILPOWER_ID,string F_LOAD_ID)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_COILPOWER_ID,F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_COILPOWER_ID,string F_LOAD_ID)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_COILPOWER_ID,F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_COILPOWER_ID,string F_LOAD_ID)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_COILPOWER_ID,F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD GetModel(string F_COILPOWER_ID,string F_LOAD_ID)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_COILPOWER_ID,F_LOAD_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD> modelList = new List<RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelDEV_COILPOWER_TO_LOAD();					
																	model.F_COILPOWER_ID= dt.Rows[n]["F_COILPOWER_ID"].ToString();
																																model.F_COILPOWER_NAME= dt.Rows[n]["F_COILPOWER_NAME"].ToString();
																																model.F_LOAD_ID= dt.Rows[n]["F_LOAD_ID"].ToString();
																																model.F_LOAD_NAME= dt.Rows[n]["F_LOAD_NAME"].ToString();
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
                Log.Error("BllDEV_COILPOWER_TO_LOAD->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllDEV_COILPOWER_TO_LOAD->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllDEV_COILPOWER_TO_LOAD->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllDEV_COILPOWER_TO_LOAD->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}