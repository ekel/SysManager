using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RenHeApp
{
    public partial class SubFormBase : Form
    {
        public SubFormBase()
        {
            InitializeComponent();
            OperType = OperateType.UnKnown;
        }

        protected void Init()
        {
            tabSub.Controls.Remove(tabPage2);
        }

        protected void SwitchAdministration()
        {
            switch (OperType)
            {
                case OperateType.Detail:
                    tabPage2.Text = "详细";
                    btnOK.Text = "返回";
                    break;
                case OperateType.Insert:
                    tabPage2.Text = "添加";
                    btnOK.Text = "添加";
                    break;
                case OperateType.Delete:
                    tabPage2.Text = "删除";
                    btnOK.Text = "删除";
                    break;
                case OperateType.Update:
                    tabPage2.Text = "修改";
                    btnOK.Text = "修改";
                    break;
                default:
                    break;
            }
            tabSub.Controls.Remove(tabPage1);
            tabSub.Controls.Add(tabPage2);
        }

        protected void SwitchOverview()
        {
            tabSub.Controls.Remove(tabPage2);
            tabSub.Controls.Add(tabPage1);
        }

        protected enum OperateType
        {
            Detail,
            Insert,
            Delete,
            Update,
            UnKnown
        }

        protected OperateType OperType
        {
            get { return _OperType; }
            set { _OperType = value; }
        }
        private OperateType _OperType;

    }
}
