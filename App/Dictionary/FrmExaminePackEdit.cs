﻿using App.Common;
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
    public partial class FrmExaminePackEdit : CCSkinMain
    {
		//*********************************
		private int intId;
		public FrmExaminePackEdit(int intId = 0)
        {
            InitializeComponent();
			this.intId = intId;
		}

        private void FrmExaminePackEdit_Load(object sender, EventArgs e)
        {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
				ParseCombobox.setUnit(cmbUnitId);
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModExaminePack().setWhere("id > 0 ", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("数据不存在！");
					this.Close();
				} else {
					txtPackName.Text = dr["txtPackName"].ToString();
					txtSpell.Text = dr["txtSpell"].ToString();
					ParseCombobox.setUnit(cmbUnitId,dr["cmbUnitId"]);
					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
				}
			}
		}

        private void skinGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
