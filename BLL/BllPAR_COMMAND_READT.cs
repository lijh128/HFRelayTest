using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验运行读取参数信息
		public partial class BllPAR_COMMAND_READT:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllPAR_COMMAND_READT));
   		     
		private readonly RelayTest.DAL.DalPAR_COMMAND_READT dal=new RelayTest.DAL.DalPAR_COMMAND_READT();
		public BllPAR_COMMAND_READT()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_READT->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_WORKTYPE_NAME,F_PROGRAMM_CODE,F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelPAR_COMMAND_READT model)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_READT->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_READT model)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_WORKTYPE_NAME,F_PROGRAMM_CODE,F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_WORKTYPE_NAME,F_PROGRAMM_CODE,F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_WORKTYPE_NAME,F_PROGRAMM_CODE,F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_WORKTYPE_NAME,F_PROGRAMM_CODE,F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_READT GetModel(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_WORKTYPE_NAME,F_PROGRAMM_CODE,F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_READT> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_READT> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_READT->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelPAR_COMMAND_READT> modelList = new List<RelayTest.Model.ModelPAR_COMMAND_READT>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelPAR_COMMAND_READT model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelPAR_COMMAND_READT();					
																	model.F_WORKTYPE_NAME= dt.Rows[n]["F_WORKTYPE_NAME"].ToString();
																																model.F_PROGRAMM_CODE= dt.Rows[n]["F_PROGRAMM_CODE"].ToString();
																												if(dt.Rows[n]["F_RECEIVECOMMAND_PAR_ID"].ToString()!="")
				{
					model.F_RECEIVECOMMAND_PAR_ID=decimal.Parse(dt.Rows[n]["F_RECEIVECOMMAND_PAR_ID"].ToString());
				}
																																				model.F_RECEIVEPAR_NAME= dt.Rows[n]["F_RECEIVEPAR_NAME"].ToString();
																												if(dt.Rows[n]["F_ORDER"].ToString()!="")
				{
					model.F_ORDER=decimal.Parse(dt.Rows[n]["F_ORDER"].ToString());
				}
																																				model.F_WORKTYPE_MEMO= dt.Rows[n]["F_WORKTYPE_MEMO"].ToString();
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
                Log.Error("BllPAR_COMMAND_READT->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_READT->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllPAR_COMMAND_READT->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_READT->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_READT->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}