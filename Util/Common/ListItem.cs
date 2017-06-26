using System.Collections;

namespace RelayTest.Util.Common
{
    public class ListItem
    {
        public Hashtable arr;

        public string colum;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aarr"></param>
        /// <param name="acolumn"></param>
        public ListItem(Hashtable aarr, string acolumn)
        {
            this.arr = aarr;
            this.colum = acolumn;
        }

        //重写tostring方法
        public override string ToString()
        {
            return arr[colum].ToString();
        }

        public object getValue(string col)
        {
            return arr[col];
        }
    }
}
