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
	public partial class FrmDrugSellRefundSearch:CCSkinMain {
		public FrmDrugSellRefundSearch() {
			InitializeComponent();
		}

		private void FrmDrugSellRefundSearch_Load(object sender, EventArgs e) {

		}

		private void btnUpdate_Click(object sender, EventArgs e) {
			new FrmDrugSellRefundSearchEdit().ShowDialog();
		}
	}
}
