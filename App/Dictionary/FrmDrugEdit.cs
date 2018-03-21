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

namespace App.Dictionary {
	public partial class FrmDrugEdit:CCSkinMain {
		//**********************************
		//声明一个私有变量
		private int intId;
		public FrmDrugEdit(int intId = 0) {
			InitializeComponent();
			this.intId = intId;
		}

		private void FrmDrugEdit_Load(object sender, EventArgs e) {
			if (intId == 0) {
				this.Text = "添加" + this.Text;
				ParseCombobox.setUnit(skinComboBox1);//ddd单位
				ParseCombobox.setAntibiosisLevel(skinComboBox2);//抗菌药物级别
				ParseCombobox.setFactory(skinComboBox3);//制药厂
				ParseCombobox.setDrugType(skinComboBox4);//药品类型
				ParseCombobox.setUnit(skinComboBox5);//基本单位
				ParseCombobox.setInvoiceType(skinComboBox6);//发票大类
				ParseCombobox.setPack(skinComboBox10);//包装单位
				ParseCombobox.setConformation(skinComboBox8);//剂型
				ParseCombobox.setUnit(skinComboBox13);//次计量单位
				ParseCombobox.setToxic(skinComboBox12);//毒理
			} else {
				this.Text = "修改" + this.Text;

				DataRow dr = new ModDrug().setWhere("id > 0 ", true).getFind(intId);
				if (dr == null) {
					Function.showMessage("数据不存在！");
					this.Close();
				} else {
					skinTextBox8.Text = dr["drugName"].ToString();
					skinTextBox15.Text = dr["spell"].ToString();
					skinTextBox1.Text = dr["numberCode"].ToString();
					skinTextBox9.Text = dr["drugCode"].ToString();
					skinTextBox2.Text = dr["DDD"].ToString();
					skinTextBox3.Text = dr["barCode"].ToString();
					skinTextBox4.Text = dr["component"].ToString();
					skinTextBox5.Text = dr["effect"].ToString();
					skinTextBox7.Text = dr["approvalCode"].ToString(); 
					skinTextBox10.Text = dr["everyNumber"].ToString();
					skinTextBox11.Text = dr["brand"].ToString(); 
					skinTextBox12.Text = dr["taboo"].ToString();
					skinTextBox13.Text = dr["usage"].ToString();
					skinTextBox14.Text = dr["storage"].ToString();
					skinTextBox16.Text = dr["spec"].ToString();
					//下拉框
					ParseCombobox.setUnit(skinComboBox1, dr["dddUnitId"]);//ddd单位
					ParseCombobox.setAntibiosisLevel(skinComboBox2, dr["AntibiosisLevelId"]);//抗菌药物级别
					ParseCombobox.setFactory(skinComboBox3, dr["factoryId"]);//制药厂
					ParseCombobox.setDrugType(skinComboBox4, dr["drugTypeId"]);//药品类型
					ParseCombobox.setUnit(skinComboBox5, dr["unitId"]);//基本单位
					ParseCombobox.setInvoiceType(skinComboBox6, dr["invoiceTypeId"]);//发票大类
					ParseCombobox.setPack(skinComboBox10, dr["packId"]);//包装单位
					ParseCombobox.setConformation(skinComboBox8, dr["conformationId"]);//剂型
					ParseCombobox.setUnit(skinComboBox13, dr["everyUnit"]);//次计量单位
					ParseCombobox.setToxic(skinComboBox12, dr["toxicId"]);//毒理
				}
			}
		}
	}
}
