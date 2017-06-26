using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验开始命令程序参数信息
		public partial class BllPAR_COMMAND_SENDP:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllPAR_COMMAND_SENDP));
   		     
		private readonly RelayTest.DAL.DalPAR_COMMAND_SENDP dal=new RelayTest.DAL.DalPAR_COMMAND_SENDP();
		public BllPAR_COMMAND_SENDP()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelPAR_COMMAND_SENDP model)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_SENDP model)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_SENDP GetModel(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_SENDCOMMAND_PAR_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_SENDP> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelPAR_COMMAND_SENDP> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelPAR_COMMAND_SENDP> modelList = new List<RelayTest.Model.ModelPAR_COMMAND_SENDP>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelPAR_COMMAND_SENDP model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelPAR_COMMAND_SENDP();					
										
					//工作模式代码
												model.F_WORKTYPE_CODE= dt.Rows[n]["F_WORKTYPE_CODE"].ToString();
																									
					//工作模式名称
												model.F_WORKTYPE_NAME= dt.Rows[n]["F_WORKTYPE_NAME"].ToString();
																									
					//试验程序编码
												model.F_PROGRAMM_CODE= dt.Rows[n]["F_PROGRAMM_CODE"].ToString();
																									
					//命令参数id值
								if(dt.Rows[n]["F_SENDCOMMAND_PAR_ID"].ToString()!="")
				{
					model.F_SENDCOMMAND_PAR_ID=decimal.Parse(dt.Rows[n]["F_SENDCOMMAND_PAR_ID"].ToString());
				}
																													
					//试验参数项名称
												model.F_SENDPAR_NAME= dt.Rows[n]["F_SENDPAR_NAME"].ToString();
																									
					//排列顺序
								if(dt.Rows[n]["F_ORDER"].ToString()!="")
				{
					model.F_ORDER=decimal.Parse(dt.Rows[n]["F_ORDER"].ToString());
				}
																													
					//备注
												model.F_WORKTYPE_MEMO= dt.Rows[n]["F_WORKTYPE_MEMO"].ToString();
																									
					//创建时间
								if(dt.Rows[n]["F_CREATE_TIME"].ToString()!="")
				{
					model.F_CREATE_TIME=DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
				}
																													
					//操作员
												model.F_OPERATOR_ID= dt.Rows[n]["F_OPERATOR_ID"].ToString();
																									
					//操作时间
								if(dt.Rows[n]["F_OPERATIONTIME"].ToString()!="")
				{
					model.F_OPERATIONTIME=DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
				}
																													
					//是否删除
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
                Log.Error("BllPAR_COMMAND_SENDP->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllPAR_COMMAND_SENDP->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllPAR_COMMAND_SENDP->GetModelList---finally");
            }
			
		}
#endregion

        #region 自定义函数
        /// <summary>
        /// 用于试验任务分配窗口，获得试验样品数据列表
        /// </summary>
        public DataTable GetAndDisplayStartPar(DataTable detailTable, string strWhere)
        {
            try
            {
                Log.Info("BllPAR_COMMAND_SENDP->GetAndDisplayStartPar---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet dataSetStartPar = dal.GetListStartPar(strWhere);
                if (dataSetStartPar != null)
                {
                    if (dataSetStartPar.Tables[0].Rows.Count > 0)
                    {
                        int rowCount = 0;
                        for (int i = 0; i < dataSetStartPar.Tables[0].Rows.Count; i++)
                        {
                            DataRow dataRow = dataSetStartPar.Tables[0].Rows[i];
                            detailTable.Rows.Add();
                            detailTable.Rows[rowCount]["colId"] = (i + 1).ToString();
                            detailTable.Rows[rowCount]["F_SENDCOMMAND_PAR_ID"] = dataRow["F_SENDCOMMAND_PAR_ID"].ToString();
                            detailTable.Rows[rowCount]["F_ORDER"] = dataRow["F_SENDPAR_ORDER"].ToString();
                            if (dataRow["parSelect"].ToString().Equals("1"))
                                detailTable.Rows[rowCount]["parSelect"] = true;
                            else
                                detailTable.Rows[rowCount]["parSelect"] = false;
                            detailTable.Rows[rowCount]["F_SENDPAR_NAME"] = dataRow["F_SENDPAR_NAME"].ToString();
                            rowCount++;
                        }
                    }
                }
                return detailTable;
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->GetAndDisplayStartPar---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->GetAndDisplayStartPar---finally");
            }
        }

        /// <summary>
        /// 根据工作模式名称，程序代码，删除数据
        /// F_WORKTYPE_NAME：工作模式名称
        /// F_PROGRAMM_CODE:程序代码
        /// </summary>
        public bool Delete_by_WorkType(string F_WORKTYPE_NAME, string F_PROGRAMM_CODE)
        {
            try
            {
                Log.Info("BllPAR_COMMAND_SENDP->Delete_by_WorkType---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.Delete_by_WorkType(F_WORKTYPE_NAME, F_PROGRAMM_CODE);
            }
            catch (Exception ex)
            {
                Log.Error("BllPAR_COMMAND_SENDP->Delete_by_WorkType---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllPAR_COMMAND_SENDP->Delete_by_WorkType---finally");
            }

        }
        #endregion
	}
}