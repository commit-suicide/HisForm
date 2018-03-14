using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.DrugStore {
	public partial class FrmDrugAllocatePass:CCSkinMain {
		public FrmDrugAllocatePass() {
			InitializeComponent();
		}

		private void FrmDrugAllocatePass_Load(object sender, EventArgs e) {

		}

		private void toolStripButton1_Click(object sender, EventArgs e) {
			new FrmDrugAllocatePassEdit().ShowDialog();
		}
	}
}
