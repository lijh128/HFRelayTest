using System;

/********************************************************************************
** ����    ��ʷ
** ��ʼʱ�䣺2009-07-16
** ����    �������ݿ���ص��߼�����ĸ���

** ����    ��No.         ����           �޸���                 ����
*********************************************************************************/

namespace RelayTest.Util.DBUtility
{
    public abstract  class DBBllBase
    {

        private DBAccess _dbAccess;//DBAccess��������ʹ�����Ӽ�����
        public DBBllBase()
        {
            if (this._dbAccess == null)
            {
                this._dbAccess = new DBAccess(PubConstant.ConnectionString);
            }

        }

        #region IDBObject ��Ա

        public DBAccess GetDBAccess()
        {
            return this._dbAccess;
        }

        /// <summary>
        /// ����DBAccess���󷽷�
        /// DBAccess����ΪBLL���ṩ���ݿ����Ӽ�����ȷ���
        /// </summary>
        /// <param name="dbAccess">DBAccess����</param>
        /// <returns></returns>
        public void  SetDBAccess(DBAccess pDbAccess)
        {
            if (pDbAccess == null )
                throw new Exception("DBBLLBase->SetDBAccess():DBAccess is null!");

            this._dbAccess = pDbAccess;
                
            
        }

        #endregion

        #region ��װDBAccess�еķ���
        /// <summary>
        /// ��ʼ����
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
        /// �ύ����
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
        /// �ع�����
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
        /// ������
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
        /// �ر�����
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
