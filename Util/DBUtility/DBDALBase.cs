using System;

/********************************************************************************
** ����    ��ʷ
** ��ʼʱ�䣺2009-07-21
** ����    �������ݿ���ص����ݲ���ĸ���

** ����    ��No.         ����           �޸���                 ����
*********************************************************************************/

namespace RelayTest.Util.DBUtility
{
    public abstract class DBDALBase 
    {

        public DBAccess _dbAccess;//DBAccess��������ʹ�����Ӽ�����

        public DBDALBase()
        {
        }

        /// <summary>
        /// ����DBAccess���󷽷�
        /// DBAccess����ΪBLL���ṩ���ݿ����Ӽ�����ȷ���
        /// </summary>
        /// <param name="dbAccess">DBAccess����</param>
        /// <returns></returns>
        public DBAccess GetDBAccess()
        {
            if (_dbAccess == null)
                throw new Exception("DBDALBase->SetDBAccess():DBAccess is null!");

            return _dbAccess;
        }

        /// <summary>
        /// ����DBAccess���󷽷�
        /// DBAccess����ΪBLL���ṩ���ݿ����Ӽ�����ȷ���
        /// </summary>
        /// <param name="dbAccess">DBAccess����</param>
        /// <returns></returns>
        public void SetDBAccess(DBAccess pDbAccess)
        {
            if (pDbAccess == null)
                throw new Exception("DBDALBase->SetDBAccess():DBAccess is null!");
            this._dbAccess = pDbAccess;
        }

        /// <summary>
        /// ������
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
        /// �ر�����
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
