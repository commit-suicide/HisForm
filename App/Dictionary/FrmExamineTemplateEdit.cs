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
    public partial class FrmExamineTemplateEdit : CCSkinMain
    {
		//********************************
		private int intId;
		public FrmExamineTemplateEdit(int intId = 0)
        {
            InitializeComponent();
			this.intId = intId;
		}

        private void FrmExamineTemplateEdit_Load(object sender, EventArgs e)
        {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
				ParseCombobox.setFactory(skinComboBox1);
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModExamineTemplate().setWhere("id > 0 ", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("数据不存在！");
					this.Close();
				} else {
					txtTemplateCode.Text = dr["templateCode"].ToString();
					txtSpell.Text = dr["Spell"].ToString();
					txtTemplateName.Text = dr["templateName"].ToString();
					txtContent.Text = dr["content"].ToString();
					

					ParseCombobox.setFactory(skinComboBox1, dr["factoryId"]);

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
    }
}
