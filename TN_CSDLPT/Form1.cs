using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class frmmain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void OpenForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if(frm.GetType()==typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        public frmmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(typeof(form.frmDangnhap));
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSv_Click(object sender, EventArgs e)
        { 
            form.frmDangnhap a = new form.frmDangnhap();
            a.MdiParent = this;
            a.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }
    }
}
