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
	public partial class FrmDrugSellEdit:CCSkinMain {
		public FrmDrugSellEdit() {
			InitializeComponent();
		}


		private void FrmDrugSellEdit_Load(object sender, EventArgs e) {
			skinTabControl1.SelectedIndex = 0;
		}

		private void skinGroupBox1_Enter(object sender, EventArgs e) {

		}

		private void skinTabControl1_SelectedIndexChanged(object sender, EventArgs e) {

		}
	}
}
