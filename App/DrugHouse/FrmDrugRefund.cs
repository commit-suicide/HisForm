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
	public partial class FrmDrugRefund:CCSkinMain {
		public FrmDrugRefund() {
			InitializeComponent();
		}

		private void FrmDrugRefund_Load(object sender, EventArgs e) {

		}

		private void btnUpdate_Click(object sender, EventArgs e) {
			new FrmDrugRefundEdit().ShowDialog();
		}
	}
}
