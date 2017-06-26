using System;

/********************************************************************************
** 作者    ：史
** 创始时间：2009-07-21
** 描述    ：与数据库相关的数据层类的根类

** 履历    ：No.         日期           修改人                 描述
*********************************************************************************/

namespace RelayTest.Util.DBUtility
{
    public abstract class DBDALBase 
    {

        public DBAccess _dbAccess;//DBAccess对象，用于使用连接及事务

        public DBDALBase()
        {
        }

        /// <summary>
        /// 设置DBAccess对象方法
        /// DBAccess对象为BLL层提供数据库连接及事务等方法
        /// </summary>
        /// <param name="dbAccess">DBAccess对象</param>
        /// <returns></returns>
        public DBAccess GetDBAccess()
        {
            if (_dbAccess == null)
                throw new Exception("DBDALBase->SetDBAccess():DBAccess is null!");

            return _dbAccess;
        }

        /// <summary>
        /// 设置DBAccess对象方法
        /// DBAccess对象为BLL层提供数据库连接及事务等方法
        /// </summary>
        /// <param name="dbAccess">DBAccess对象</param>
        /// <returns></returns>
        public void SetDBAccess(DBAccess pDbAccess)
        {
            if (pDbAccess == null)
                throw new Exception("DBDALBase->SetDBAccess():DBAccess is null!");
            this._dbAccess = pDbAccess;
        }

        /// <summary>
        /// 打开连接
        /// </summary>
        protected void ConnectionOpen()
        {
            if (_dbAccess == null)
            {
                throw new Exception("DBDALBase->ConnectionOpen():DBAccess is null!");
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
                throw new Exception("DBDALBase->ConnectionClose():DBAccess is null!");
            }
            else
            {
                this._dbAccess.ConnectionClose();
            }
        }
    }
}
