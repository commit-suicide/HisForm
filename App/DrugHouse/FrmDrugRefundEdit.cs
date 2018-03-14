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
	public partial class FrmDrugRefundEdit:CCSkinMain {
		public FrmDrugRefundEdit() {
			InitializeComponent();
		}

		private void FrmDrugRefundEdit_Load(object sender, EventArgs e) {
			skinTabControl1.SelectedIndex = 0;
		}
	}
}
