﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验初始命令参数值表上位机
		public partial class BllTEST_PAR_VALUE_SWJ:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_PAR_VALUE_SWJ));
   		     
		private readonly RelayTest.DAL.DalTEST_PAR_VALUE_SWJ dal=new RelayTest.DAL.DalTEST_PAR_VALUE_SWJ();
		public BllTEST_PAR_VALUE_SWJ()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
		
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TASK_ID,F_PROGRAM_CODE,F_SENDPAR_NAME);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelTEST_PAR_VALUE_SWJ model)
		{
		
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTEST_PAR_VALUE_SWJ model)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TASK_ID,F_PROGRAM_CODE,F_SENDPAR_NAME);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TASK_ID,F_PROGRAM_CODE,F_SENDPAR_NAME);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TASK_ID,F_PROGRAM_CODE,F_SENDPAR_NAME);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TASK_ID,F_PROGRAM_CODE,F_SENDPAR_NAME);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_PAR_VALUE_SWJ GetModel(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TASK_ID,F_PROGRAM_CODE,F_SENDPAR_NAME);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_PAR_VALUE_SWJ> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_PAR_VALUE_SWJ> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTEST_PAR_VALUE_SWJ> modelList = new List<RelayTest.Model.ModelTEST_PAR_VALUE_SWJ>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTEST_PAR_VALUE_SWJ model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTEST_PAR_VALUE_SWJ();					
										
					//试验任务编号
												model.F_TASK_ID= dt.Rows[n]["F_TASK_ID"].ToString();
																									
					//工作模式名称
												model.F_WORKTYPE_NAME= dt.Rows[n]["F_WORKTYPE_NAME"].ToString();
																									
					//工作模式编码
												model.F_WORKTYPE_CODE= dt.Rows[n]["F_WORKTYPE_CODE"].ToString();
																									
					//程序代码
												model.F_PROGRAM_CODE= dt.Rows[n]["F_PROGRAM_CODE"].ToString();
																									
					//参数名称
												model.F_SENDPAR_NAME= dt.Rows[n]["F_SENDPAR_NAME"].ToString();
																									
					//参数值
												model.F_SENDPAR_VALUE= dt.Rows[n]["F_SENDPAR_VALUE"].ToString();
																									
					//排序序号
								if(dt.Rows[n]["F_SENDORDER"].ToString()!="")
				{
					model.F_SENDORDER=decimal.Parse(dt.Rows[n]["F_SENDORDER"].ToString());
				}
																													
					//备注
												model.F_SENDPAR_MEMO= dt.Rows[n]["F_SENDPAR_MEMO"].ToString();
																									
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
                Log.Error("BllTEST_PAR_VALUE_SWJ->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetModelList---finally");
            }
			
		}
#endregion

        #region 自定义函数
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DropByTaskId(string F_TASK_ID)
        {
            try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->DropByTaskId---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropByTaskId(F_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->DropByTaskId---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->DropByTaskId---finally");
            }

        }
        /// <summary>
        /// 根据任务编号获得试验命令参数数据列表
        /// </summary>
        public DataTable GetAndDisplayParValue(DataTable detailTable, string strTaskid)
        {
            try
            {
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetAndDisplayParValue---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet dataSetParInfo = dal.GetListforDis(strTaskid);
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
                            detailTable.Rows[i]["F_SENDPAR_VALUE"] = dataRow["F_SENDPAR_VALUE"].ToString();
                            detailTable.Rows[i]["F_SENDPAR_UNIT"] = dataRow["F_SENDPAR_UNIT"].ToString();
                            detailTable.Rows[i]["F_SENDPAR_DEFAULT_VALUE"] = dataRow["F_SENDPAR_DEFAULT_VALUE"].ToString();
                            detailTable.Rows[i]["colSENDORDER"] = dataRow["F_SENDORDER"].ToString();
                        }
                    }
                }
                return detailTable;
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_PAR_VALUE_SWJ->GetAndDisplayParValue---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_PAR_VALUE_SWJ->GetAndDisplayParValue---finally");
            }
        }
        #endregion
    }
}