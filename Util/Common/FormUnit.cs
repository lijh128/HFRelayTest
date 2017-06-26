using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RelayTest.Util.Common
{
    public static class FormUnit
    {
        /// <summary>
        /// 得到控件集合的内容
        /// </summary>
        /// <param name="listCtl">控件集合</param>
        /// <returns></returns>
        public static string GetControlsInfo(List<Control> listCtl)
        {
            if (listCtl.Count <= 0) return string.Empty;

            StringBuilder sb = new StringBuilder();

            foreach (Control ctl in listCtl)
            {
                sb.Append(ctl.Text);
                SearchChildren(ctl, sb);
            }

            return sb.ToString();
        }

        /// <summary>
        /// 得到页面的内容
        /// </summary>
        /// <param name="fmObject">dev页面</param>
        /// <returns></returns>
        public static string GetFormInfo(XtraForm fmObject)
        {
            return GetFormInfo(fmObject as Form);
        }

        /// <summary>
        /// 得到页面的内容
        /// </summary>
        /// <param name="fmObject">普通页面</param>
        /// <returns></returns>
        public static string GetFormInfo(Form fmObject)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Control ctl in fmObject.Controls)
            {
                if (!ctl.Visible) continue;

                sb.Append(ctl.Text);
                SearchChildren(ctl, sb);
            }

            return sb.ToString();
        }

        private static void SearchChildren(Control ctl, StringBuilder sb)
        {
            if ("DevExpress.XtraGrid.GridControl".Equals(ctl.GetType().ToString()) || 
                "RelayTest.Util.Common.BaseGridControl".Equals(ctl.GetType().ToString()))
            {
                DevExpress.XtraGrid.GridControl gridCtl = (DevExpress.XtraGrid.GridControl)ctl;
                DevExpress.XtraGrid.Views.Grid.GridView gridView = (DevExpress.XtraGrid.Views.Grid.GridView)gridCtl.FocusedView;

                for (int i = 0; i < gridView.RowCount; i++)
                {
                    foreach (DevExpress.XtraGrid.Columns.GridColumn gc in gridView.Columns)
                    {
                        sb.Append(gridView.GetRowCellDisplayText(i, gc).ToString());
                    }
                }
            }
            if ("DevExpress.XtraEditors.CheckEdit".Equals(ctl.GetType().ToString()) ||
                "RelayTest.Util.Common.BaseCheckEdit".Equals(ctl.GetType().ToString()))
            {
                DevExpress.XtraEditors.CheckEdit checkCtl = (DevExpress.XtraEditors.CheckEdit)ctl;
                sb.Append(checkCtl.Checked.ToString());
            }
            else
            {
                foreach (Control item in ctl.Controls)
                {
                    if (!item.Visible) continue;

                    sb.Append(item.Text);
                    SearchChildren(item, sb);
                }
            }
        }
    }
}
