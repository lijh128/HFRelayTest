using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;

namespace RelayTest.Util.Common
{
    public class BaseXtraForm : XtraForm
    {

        

        public BaseXtraForm()
        {
            InitializeComponent();
            Appearance.Font = BaseFont.Font;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;
            Width = 1280;
            Height = 1024;

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseXtraForm
            // 
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Name = "BaseXtraForm";
            this.ResumeLayout(false);

        }


    }

    public class BaseLabelControl : LabelControl
    {
        public BaseLabelControl()
        {
            Appearance.Font = BaseFont.Font;
        }
    }
    public class BaseSimpleButton : SimpleButton
    {
        public BaseSimpleButton()
        {
            Appearance.Font = BaseFont.Font;
        }
    }
    public class BaseGridControl : GridControl
    {
        public BaseGridControl()
        {
            Font = BaseFont.Font;
        }
    }

    public class BaseTextEdit : TextEdit
    {
        public BaseTextEdit()
        {
            Font = BaseFont.Font;
        }
    }

    public class BaseTreeList : TreeList
    {
        public BaseTreeList()
        {
            Font = BaseFont.Font;
        }
    }

    public class BaseCheckEdit : CheckEdit
    {
        public BaseCheckEdit()
        {
            Font = BaseFont.Font;
        }
    }

    public class BaseFont
    {
        public static Font Font = BaseFont.Font;
    }

    public class BasePanelControl : PanelControl
    {
        public BasePanelControl()
        {
            Font = BaseFont.Font;
        }
    }

    public class BaseCheckedListBoxControl : CheckedListBoxControl
    {
        public BaseCheckedListBoxControl()
        {
            Font = BaseFont.Font;
        }
    }

    public class BaseMemoExEdit : MemoExEdit
    {
        public BaseMemoExEdit()
        {
            Font = BaseFont.Font;
        }
    }
}

