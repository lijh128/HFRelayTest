using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//发送命令参数元数据表
		public partial class BllPAR_COMMAND_SEND:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllPAR_COMMAND_SEND));
   		     
		private readonly RelayTest.DAL.DalPAR_COMMAND_SEND dal=new RelayTest.DAL.DalPAR_COMMAND_SEND();
		public BllPAR_COMMAND_SEND()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(decimal F_SENDCOMMAND_PAR_ID)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelPAR_COMMAND_SEND model)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_SEND model)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_SEND GetModel(decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_SEND> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_SEND> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelPAR_COMMAND_SEND> modelList = new List<RelayTest.Model.ModelPAR_COMMAND_SEND>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelPAR_COMMAND_SEND model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelPAR_COMMAND_SEND();					
													if(dt.Rows[n]["F_SENDCOMMAND_PAR_ID"].ToString()!="")
				{
					model.F_SENDCOMMAND_PAR_ID=decimal.Parse(dt.Rows[n]["F_SENDCOMMAND_PAR_ID"].ToString());
				}
																																				model.F_SENDPAR_NAME= dt.Rows[n]["F_SENDPAR_NAME"].ToString();
																												if(dt.Rows[n]["F_SENDPAR_ORDER"].ToString()!="")
				{
					model.F_SENDPAR_ORDER=decimal.Parse(dt.Rows[n]["F_SENDPAR_ORDER"].ToString());
				}
																																				model.F_SENDPAR_DATA_TYPE= dt.Rows[n]["F_SENDPAR_DATA_TYPE"].ToString();
																												if(dt.Rows[n]["F_SENDPAR_DATA_LENGTH"].ToString()!="")
				{
					model.F_SENDPAR_DATA_LENGTH=decimal.Parse(dt.Rows[n]["F_SENDPAR_DATA_LENGTH"].ToString());
				}
																																				model.F_SENDPAR_DEFAULT_VALUE= dt.Rows[n]["F_SENDPAR_DEFAULT_VALUE"].ToString();
																																model.F_SENDPAR_UNIT= dt.Rows[n]["F_SENDPAR_UNIT"].ToString();
																												if(dt.Rows[n]["F_SENDPAR_SET"].ToString()!="")
				{
					model.F_SENDPAR_SET=decimal.Parse(dt.Rows[n]["F_SENDPAR_SET"].ToString());
				}
																																if(dt.Rows[n]["F_SENDPAR_DISPLAY"].ToString()!="")
				{
					model.F_SENDPAR_DISPLAY=decimal.Parse(dt.Rows[n]["F_SENDPAR_DISPLAY"].ToString());
				}
																																				model.F_SENDPAR_MEMO= dt.Rows[n]["F_SENDPAR_MEMO"].ToString();
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
                Log.Error("BllPAR_COMMAND_SEND->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SEND->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_SEND->GetModelList---finally");
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
                Log.Info("BllPAR_COMMAND_SEND->GetParCount---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetParCount(tempParId);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetParCount---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_SEND->GetParCount---finally");
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_forDis(string strWhere)
        {
            try
            {
                Log.Info("BllPAR_COMMAND_SEND->GetList_forDis---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList_forDis(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetList_forDis---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->GetList_forDis---finally");
            }

        }

        /// <summary>
        /// 获得满足strWhere的参数名，参数单位，默认值，并显示在detailTable表中
        /// </summary>
        public DataTable GetAndDisplayCommPar(DataTable detailTable,string strWhere)
        {
            try
            {
                Log.Info("BllPAR_COMMAND_SEND->GetAndDisplayCommPar---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet dataSetParInfo = dal.GetCommParForSet(strWhere);
                if (dataSetParInfo != null)
                {
                    if (dataSetParInfo.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < dataSetParInfo.Tables[0].Rows.Count; i++)
                        {
                            DataRow dataRow = dataSetParInfo.Tables[0].Rows[i];
                            detailTable.Rows.Add();
                            detailTable.Rows[i]["colId"] = (i + 1).ToString();
                            detailTable.Rows[i]["F_SENDPAR_NAME"] = dataRow["F_SENDPAR_NAME"].ToString();
                            detailTable.Rows[i]["F_SENDPAR_VALUE"] = "";
                            detailTable.Rows[i]["F_SENDPAR_DEFAULT_VALUE"] = dataRow["F_SENDPAR_DEFAULT_VALUE"].ToString();
                            detailTable.Rows[i]["F_SENDPAR_UNIT"] = dataRow["F_SENDPAR_UNIT"].ToString();
                            detailTable.Rows[i]["colSENDORDER"] = dataRow["F_SENDPAR_ORDER"].ToString();
                        }
                    }
                }
                return detailTable;
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SEND->GetAndDisplayCommPar---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SEND->GetAndDisplayCommPar---finally");
            }
        }
        #endregion

        
    }
}