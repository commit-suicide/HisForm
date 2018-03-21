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
    public partial class FrmExaminePriceEdit : CCSkinMain
    {
		//*****************************
		private int intId;
		public FrmExaminePriceEdit(int intId = 0)
        {
            InitializeComponent();
			this.intId = intId;
		}

        private void FrmExaminePriceEdit_Load(object sender, EventArgs e)
        {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
				
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModExaminePrice().setWhere("id > 0 ", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("数据不存在！");
					this.Close();
				} else {
					txtExamineName.Text = dr["examineName"].ToString();
					txtSpell.Text = dr["Spell"].ToString();
					ccbMedicineCodeId.Text = dr["ccbmedicineCode"].ToString();
					txtSpace.Text = dr["space"].ToString();
					txtPrice.Text = dr["price"].ToString();
					txtCost.Text = dr["cost"].ToString();

					ParseCombobox.setParty(cmbPartyId, dr["partyId"]);
					ParseCombobox.setUnit(cmbUnitId, dr["cmbUnitId"]);
					ParseCombobox.setFinanceType(cmbFinanceTypeId, dr["cmbFinancetypeId"]); 
					ParseCombobox.setInvoiceType(cmbInvoiceTypeId, dr["cmbInvoiceTypeId"]);

					chkIsPass.Checked = Convert.ToBoolean(dr["isPass"]);
				}
			}
		}

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
