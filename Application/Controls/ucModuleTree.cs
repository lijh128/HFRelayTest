using System;
using System.Data;
using System.Windows.Forms;
using RelayTest.BLL;
using DevExpress.XtraTreeList;

namespace RelayTest.Application.Controls
{
    public delegate void NodeClickHander(object sender, EventArgs e);


    public partial class UcModuleTree : UserControl
    {
        private readonly ProxyBllSYSTEM_MODULE _bllXmodule = new ProxyBllSYSTEM_MODULE();

        /// <summary>
        /// 显示功能的数据集
        /// </summary>
        public DataSet DsModule = new DataSet();

        public UcModuleTree()
        {
            InitializeComponent();
        }

        public string SelectNodeKey
        {
            get
            {
                try
                {
                    if (tlModule.FocusedNode !=null)
                    {
                        return tlModule.FocusedNode["F_MODULEID"].ToString();
                    }
                    else
                    {
                        return "";
                    }
                }
                catch (Exception)
                {

                    return "";
                }
//                try
//                {
////                    if (tvModule.SelectedNode != null)
////                    {
////                        return Int32.Parse(tvModule.SelectedNode.Name);
////                    }
////                    return -1;
//                }
//                catch (Exception)
//                {
////                    return -1;
//                }
            }
        }

        public event NodeClickHander nodeClickHanderEvent;

//        public void BindTree(DataTable dtSource, TreeNode parentNode, string parentID)
//        {
//            DataRow[] rows = dtSource.Select(string.Format("F_ParentID={0}", parentID));
//
//
//            foreach (DataRow row in rows)
//            {
//                if (parentNode == null)
//                {
//                    TreeNode Node = tvModule.Nodes.Add(row["F_ID"].ToString(), row["F_NAME"].ToString());
//                    BindTree(dtSource, Node, row["F_ID"].ToString()); //再次递归 
//                }
//
//                else
//                {
//                    //添加当前节点的子节点 
//                    TreeNode Node = parentNode.Nodes.Add(row["F_ID"].ToString(), row["F_NAME"].ToString());
//                    BindTree(dtSource, Node, row["F_ID"].ToString()); //再次递归 
//                }
//            }
//        }


        /// <summary>
        /// 初始化
        /// </summary>
        public void InitTree()
        {
            //DsModule = _bllXmodule.GetAllMoudle();
            
            tlModule.DataSource = DsModule.Tables[0];
            tlModule.Refresh();
            
        }

        private void tvModule_AfterSelect(object sender, TreeViewEventArgs e)
        {
//            if (nodeClickHanderEvent != null)
//            {
//                nodeClickHanderEvent(this, e);
//            }
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if (nodeClickHanderEvent != null)
            {
                nodeClickHanderEvent(this, e);
            }
        }
    }
}