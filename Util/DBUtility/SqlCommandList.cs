using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;

namespace RelayTest.Util.DBUtility
{
    public class SqlCommandList
    {
        private string _cmdtext = string.Empty;
        private List<OracleParameter> _cmdparams = new List<OracleParameter>();

        public string cmdText
        {
            set { _cmdtext = value; }
            get { return _cmdtext; }
        }

        public OracleParameter[] cmdParamsAry
        {
            set { _cmdparams = value.ToList<OracleParameter>(); }
            get {
                OracleParameter[] ary;
                ary = new OracleParameter[_cmdparams.Count];

                _cmdparams.CopyTo(ary);
                return ary; 
            }
        }

        public List<OracleParameter> cmdParamsList
        {
            set { _cmdparams = value; }
            get { return _cmdparams; }
        }
    }
}
