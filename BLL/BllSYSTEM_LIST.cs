using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
		public partial class BllSYSTEM_LIST:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllSYSTEM_LIST));
   		     
		private readonly RelayTest.DAL.DalSYSTEM_LIST dal=new RelayTest.DAL.DalSYSTEM_LIST();
		public BllSYSTEM_LIST()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TYPE,decimal F_VALUE)
		{
		
			try
            {
                Log.Info("BllSYSTEM_LIST->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TYPE,F_VALUE);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelSYSTEM_LIST model)
		{
		
			try
            {
                Log.Info("BllSYSTEM_LIST->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelSYSTEM_LIST model)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TYPE,decimal F_VALUE)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TYPE,F_VALUE);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TYPE,decimal F_VALUE)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TYPE,F_VALUE);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TYPE,decimal F_VALUE)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TYPE,F_VALUE);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TYPE,decimal F_VALUE)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TYPE,F_VALUE);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelSYSTEM_LIST GetModel(string F_TYPE,decimal F_VALUE)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TYPE,F_VALUE);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelSYSTEM_LIST> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelSYSTEM_LIST> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllSYSTEM_LIST->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelSYSTEM_LIST> modelList = new List<RelayTest.Model.ModelSYSTEM_LIST>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelSYSTEM_LIST model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelSYSTEM_LIST();					
																	model.F_TYPE= dt.Rows[n]["F_TYPE"].ToString();
																												if(dt.Rows[n]["F_VALUE"].ToString()!="")
				{
					model.F_VALUE=decimal.Parse(dt.Rows[n]["F_VALUE"].ToString());
				}
																																				model.F_DISPLAY= dt.Rows[n]["F_DISPLAY"].ToString();
																						
				
					modelList.Add(model);
				}
			}
			return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllSYSTEM_LIST->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllSYSTEM_LIST->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllSYSTEM_LIST->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllSYSTEM_LIST->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}