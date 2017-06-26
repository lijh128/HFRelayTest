using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验准备情况附件
		public partial class BllTEST_PREPARE_ATTATCH:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_PREPARE_ATTATCH));
   		     
		private readonly RelayTest.DAL.DalTEST_PREPARE_ATTATCH dal=new RelayTest.DAL.DalTEST_PREPARE_ATTATCH();
		public BllTEST_PREPARE_ATTATCH()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TEST_TASK_ID)
		{
		
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelTEST_PREPARE_ATTATCH model)
		{
		
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTEST_PREPARE_ATTATCH model)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_PREPARE_ATTATCH GetModel(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_PREPARE_ATTATCH> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_PREPARE_ATTATCH> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTEST_PREPARE_ATTATCH> modelList = new List<RelayTest.Model.ModelTEST_PREPARE_ATTATCH>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTEST_PREPARE_ATTATCH model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTEST_PREPARE_ATTATCH();					
																	model.F_TEST_TASK_ID= dt.Rows[n]["F_TEST_TASK_ID"].ToString();
																																model.F_ATTATCHNAME= dt.Rows[n]["F_ATTATCHNAME"].ToString();
																																				if(dt.Rows[n]["F_ATTATCHMENT"].ToString()!="")
				{
					model.F_ATTATCHMENT= (byte[])dt.Rows[n]["F_ATTATCHMENT"];
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
                Log.Error("BllTEST_PREPARE_ATTATCH->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PREPARE_ATTATCH->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PREPARE_ATTATCH->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_PREPARE_ATTATCH->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}