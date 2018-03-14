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
	public partial class FrmDrugSpill:CCSkinMain {
		public FrmDrugSpill() {
			InitializeComponent();
		}

		private void FrmDrugSpill_Load(object sender, EventArgs e) {
			skinComboBox1.SelectedIndex = 0;
		}

		private void btnInsert_Click(object sender, EventArgs e) {
			new FrmDrugSpillEdit().ShowDialog();
		}
	}
}
