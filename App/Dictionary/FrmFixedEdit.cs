using App.Common;
using App.Model;
using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.Dictionary
{
    public partial class FrmFixedEdit : CCSkinMain
    {
		private int intId;
		public FrmFixedEdit(int intId = 0)
        {
            InitializeComponent();
			this.intId = intId;
		}

        private void FrmFixedEdit_Load(object sender, EventArgs e)
        {
			if (intId == 0) {
				this.Text = "添加" + this.Text;

			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModFixed().setWhere("id > 0 ", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("数据不存在！");
					this.Close();
				} else {
					skinTextBox1.Text = dr["fixedCode"].ToString();
					skinTextBox3.Text = dr["fixedName"].ToString();
					skinTextBox4.Text = dr["spell"].ToString();

					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
				}
			}
		}
    }
}
