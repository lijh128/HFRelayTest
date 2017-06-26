using System;

/********************************************************************************
** 作者    ：史
** 创始时间：2009-07-16
** 描述    ：与数据库相关的逻辑层类的根类

** 履历    ：No.         日期           修改人                 描述
*********************************************************************************/

namespace RelayTest.Util.DBUtility
{
    public abstract  class DBBllBase
    {

        private DBAccess _dbAccess;//DBAccess对象，用于使用连接及事务
        public DBBllBase()
        {
            if (this._dbAccess == null)
            {
                this._dbAccess = new DBAccess(PubConstant.ConnectionString);
            }

        }

        #region IDBObject 成员

        public DBAccess GetDBAccess()
        {
            return this._dbAccess;
        }

        /// <summary>
        /// 设置DBAccess对象方法
        /// DBAccess对象为BLL层提供数据库连接及事务等方法
        /// </summary>
        /// <param name="dbAccess">DBAccess对象</param>
        /// <returns></returns>
        public void  SetDBAccess(DBAccess pDbAccess)
        {
            if (pDbAccess == null )
                throw new Exception("DBBLLBase->SetDBAccess():DBAccess is null!");

            this._dbAccess = pDbAccess;
                
            
        }

        #endregion

        #region 封装DBAccess中的方法
        /// <summary>
        /// 开始事务
        /// </summary>
        protected  void BeginTransaction()
        {
            if (_dbAccess == null)
            {
                throw new Exception("DBBLLBase->BeginTransaction():DBAccess is null!");

            }
            else
            {
                this._dbAccess.BeginTransaction();
            }
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        protected void CommitTns()
        {
            if (_dbAccess == null)
            {
                throw new Exception("DBBLLBase->CommitTns():DBAccess is null!");
            }
            else
            {
                this._dbAccess.CommitTns();
            }
        }


        /// <summary>
        /// 回滚事务
        /// </summary>
        protected void RollBackTns()
        {
            if (_dbAccess == null)
            {
                throw new Exception("DBBLLBase->RollBackTns():DBAccess is null!");
            }
            else
            {
                this._dbAccess.RollBackTns();
            }
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        protected void ConnectionOpen()
        {
            if (_dbAccess == null)
            {
                throw new Exception("DBBLLBase->ConnectionOpen():DBAccess is null!");
            }
            else
            {
                this._dbAccess.ConnectionOpen();
            }
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        protected void ConnectionClose()
        {
            if (_dbAccess == null)
            {
                throw new Exception("DBBLLBase->ConnectionClose():DBAccess is null!");
            }
            else
            {
                this._dbAccess.ConnectionClose();
            }
        }

        #endregion
    }
}
