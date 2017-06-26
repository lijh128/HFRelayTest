using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//接收命令参数元数据表
		public partial class BllPAR_COMMAND_RECEIVE:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllPAR_COMMAND_RECEIVE));
   		     
		private readonly RelayTest.DAL.DalPAR_COMMAND_RECEIVE dal=new RelayTest.DAL.DalPAR_COMMAND_RECEIVE();
		public BllPAR_COMMAND_RECEIVE()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(decimal F_RECEIVECOMMAND_PAR_ID)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelPAR_COMMAND_RECEIVE model)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_RECEIVE model)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_RECEIVE GetModel(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_RECEIVECOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_RECEIVE> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_RECEIVE> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelPAR_COMMAND_RECEIVE> modelList = new List<RelayTest.Model.ModelPAR_COMMAND_RECEIVE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelPAR_COMMAND_RECEIVE model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelPAR_COMMAND_RECEIVE();					
													if(dt.Rows[n]["F_RECEIVECOMMAND_PAR_ID"].ToString()!="")
				{
					model.F_RECEIVECOMMAND_PAR_ID=decimal.Parse(dt.Rows[n]["F_RECEIVECOMMAND_PAR_ID"].ToString());
				}
																																				model.F_RECEIVEPAR_NAME= dt.Rows[n]["F_RECEIVEPAR_NAME"].ToString();
																												if(dt.Rows[n]["F_RECEIVEPAR_ORDER"].ToString()!="")
				{
					model.F_RECEIVEPAR_ORDER=decimal.Parse(dt.Rows[n]["F_RECEIVEPAR_ORDER"].ToString());
				}
																																				model.F_RECEIVEPAR_DATA_TYPE= dt.Rows[n]["F_RECEIVEPAR_DATA_TYPE"].ToString();
																												if(dt.Rows[n]["F_RECEIVEPAR_DATA_LENGTH"].ToString()!="")
				{
					model.F_RECEIVEPAR_DATA_LENGTH=decimal.Parse(dt.Rows[n]["F_RECEIVEPAR_DATA_LENGTH"].ToString());
				}
																																				model.F_RECEIVEPAR_DEFAULT_VALUE= dt.Rows[n]["F_RECEIVEPAR_DEFAULT_VALUE"].ToString();
																																model.F_RECEIVEPAR_UNIT= dt.Rows[n]["F_RECEIVEPAR_UNIT"].ToString();
																												if(dt.Rows[n]["F_RECEIVEPAR_DISPLAY"].ToString()!="")
				{
					model.F_RECEIVEPAR_DISPLAY=decimal.Parse(dt.Rows[n]["F_RECEIVEPAR_DISPLAY"].ToString());
				}
																																				model.F_RECEIVEPAR_MEMO= dt.Rows[n]["F_RECEIVEPAR_MEMO"].ToString();
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
                Log.Error("BllPAR_COMMAND_RECEIVE->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_RECEIVE->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetModelList---finally");
            }
			
		}
#endregion

        #region 自定义函数

        /// <summary>
        /// 获得指定参数编号的记录数量
        /// tempParId   参数编号
        /// 返回值：指定参数编号的记录行
        /// </summary>
        public DataSet GetParCount(String tempParId)
        {
            try
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetParCount---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetParCount(tempParId);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_RECEIVE->GetParCount---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_RECEIVE->GetParCount---finally");
            }
        }
        #endregion
	}
}