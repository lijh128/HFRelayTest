using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验任务参数类型表
		public partial class BllTESTTASK_PARTYPE:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTESTTASK_PARTYPE));
   		     
		private readonly RelayTest.DAL.DalTESTTASK_PARTYPE dal=new RelayTest.DAL.DalTESTTASK_PARTYPE();
		public BllTESTTASK_PARTYPE()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TYPE_CODE)
		{
		
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TYPE_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelTESTTASK_PARTYPE model)
		{
		
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTESTTASK_PARTYPE model)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TYPE_CODE)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TYPE_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TYPE_CODE)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TYPE_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TYPE_CODE)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TYPE_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TYPE_CODE)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TYPE_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTESTTASK_PARTYPE GetModel(string F_TYPE_CODE)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TYPE_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTESTTASK_PARTYPE> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTESTTASK_PARTYPE> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTESTTASK_PARTYPE> modelList = new List<RelayTest.Model.ModelTESTTASK_PARTYPE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTESTTASK_PARTYPE model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTESTTASK_PARTYPE();					
																	model.F_TYPE_CODE= dt.Rows[n]["F_TYPE_CODE"].ToString();
																																model.F_TYPE_NAME= dt.Rows[n]["F_TYPE_NAME"].ToString();
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
                Log.Error("BllTESTTASK_PARTYPE->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTESTTASK_PARTYPE->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTESTTASK_PARTYPE->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTESTTASK_PARTYPE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTESTTASK_PARTYPE->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}