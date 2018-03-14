using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.DrugHouse {
	public partial class FrmDrugSellRefundSearchEdit:CCSkinMain {
		public FrmDrugSellRefundSearchEdit() {
			InitializeComponent();
		}

		private void FrmDrugSellRefundSearchEdit_Load(object sender, EventArgs e) {
			skinTabControl1.SelectedIndex = 0;
			this.label1.Text = DateTime.Now.ToString();
		}

		private void skinButton1_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void skinDataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}
	}
}
