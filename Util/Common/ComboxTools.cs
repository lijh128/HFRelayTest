using System.Collections;
using System.Data;

namespace RelayTest.Util.Common
{
    public class ComboxTools
    {
        public static void AddValue(DevExpress.XtraEditors.ComboBoxEdit cbo, DataTable dt, string col)
        {
            if (dt == null || dt.Rows == null)
            {
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                Hashtable hashTable = new Hashtable();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    hashTable.Add(dt.Columns[i].ToString(), dr[i].ToString());
                }
                ListItem lstItem = new ListItem(hashTable, col);
                cbo.Properties.Items.Add(lstItem);
            }
        }

        public static object GetValue(DevExpress.XtraEditors.ComboBoxEdit cbo, string col)
        {
            if (string.IsNullOrEmpty(cbo.Text))
            {
                return "";
            }
            else
            {
                if (cbo.EditValue is ListItem)
                {
                    ListItem lstItem = (ListItem)cbo.EditValue;
                    return lstItem.getValue(col);
                }
                else
                {
                    return cbo.EditValue;
                }
            }
        }

        public static void SelectValue(DevExpress.XtraEditors.ComboBoxEdit aComboBox, string asColumnName, object aoValue)
        {
            if (aComboBox == null)
            {
                return;
            }
            foreach (object oItem in aComboBox.Properties.Items)
            {
                if (oItem != null && !string.IsNullOrEmpty(oItem.ToString()))
                {
                    if (((ListItem)oItem).getValue(asColumnName).Equals(aoValue))
                    {
                        aComboBox.EditValue = oItem;
                        break;
                    }
                }
            }
        }
    }
}
