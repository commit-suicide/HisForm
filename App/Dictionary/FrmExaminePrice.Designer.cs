﻿namespace App.Dictionary
{
    partial class FrmExaminePrice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExaminePrice));
			this.grd = new CCWin.SkinControl.SkinDataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.skinToolStrip1 = new CCWin.SkinControl.SkinToolStrip();
			this.btnInsert = new System.Windows.Forms.ToolStripButton();
			this.btnUpdate = new System.Windows.Forms.ToolStripButton();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.btnClose = new System.Windows.Forms.ToolStripButton();
			this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
			this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
			this.skinButton1 = new CCWin.SkinControl.SkinButton();
			((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
			this.skinToolStrip1.SuspendLayout();
			this.skinPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grd
			// 
			this.grd.AllowUserToAddRows = false;
			this.grd.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
			this.grd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grd.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grd.ColumnFont = null;
			this.grd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
			this.grd.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grd.DefaultCellStyle = dataGridViewCellStyle3;
			this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grd.EnableHeadersVisualStyles = false;
			this.grd.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.grd.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.grd.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
			this.grd.Location = new System.Drawing.Point(4, 116);
			this.grd.Name = "grd";
			this.grd.ReadOnly = true;
			this.grd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.grd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.grd.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.grd.RowTemplate.Height = 23;
			this.grd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grd.Size = new System.Drawing.Size(1192, 780);
			this.grd.TabIndex = 3;
			this.grd.TitleBack = null;
			this.grd.TitleBackColorBegin = System.Drawing.Color.White;
			this.grd.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "TXTEXAMINENAME";
			this.Column1.HeaderText = "名称";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "TXTSPELL";
			this.Column3.HeaderText = "拼音";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "CMBPARTYID";
			this.Column2.HeaderText = "部位";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 120;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "CCBMEDICINECODE";
			this.Column5.HeaderText = "医价编码";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "CMBUNITID";
			this.Column6.HeaderText = "单位";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "CMBFINANCETYPEID";
			this.Column4.HeaderText = "收费分类";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "TXTSPACE";
			this.Column7.HeaderText = "规格";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "缴费处";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "CMBINVOICETYPEID";
			this.Column9.HeaderText = "发票分类";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "CHKDEPARTMENTIDS";
			this.Column10.HeaderText = "执行科室";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			// 
			// Column11
			// 
			this.Column11.DataPropertyName = "TXTPRICE";
			this.Column11.HeaderText = "价格";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			// 
			// Column12
			// 
			this.Column12.DataPropertyName = "TXTCOST";
			this.Column12.HeaderText = "成本";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			// 
			// Column13
			// 
			this.Column13.DataPropertyName = "ISPASS";
			this.Column13.HeaderText = "是否启用";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			// 
			// skinToolStrip1
			// 
			this.skinToolStrip1.Arrow = System.Drawing.Color.Black;
			this.skinToolStrip1.Back = System.Drawing.Color.White;
			this.skinToolStrip1.BackRadius = 4;
			this.skinToolStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
			this.skinToolStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
			this.skinToolStrip1.BaseFore = System.Drawing.Color.Black;
			this.skinToolStrip1.BaseForeAnamorphosis = false;
			this.skinToolStrip1.BaseForeAnamorphosisBorder = 4;
			this.skinToolStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
			this.skinToolStrip1.BaseForeOffset = new System.Drawing.Point(0, 0);
			this.skinToolStrip1.BaseHoverFore = System.Drawing.Color.White;
			this.skinToolStrip1.BaseItemAnamorphosis = true;
			this.skinToolStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BaseItemBorderShow = true;
			this.skinToolStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemDown")));
			this.skinToolStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinToolStrip1.BaseItemMouse")));
			this.skinToolStrip1.BaseItemNorml = null;
			this.skinToolStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BaseItemRadius = 4;
			this.skinToolStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinToolStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.BindTabControl = null;
			this.skinToolStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
			this.skinToolStrip1.Fore = System.Drawing.Color.Black;
			this.skinToolStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
			this.skinToolStrip1.HoverFore = System.Drawing.Color.White;
			this.skinToolStrip1.ItemAnamorphosis = true;
			this.skinToolStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.ItemBorderShow = true;
			this.skinToolStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
			this.skinToolStrip1.ItemRadius = 4;
			this.skinToolStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInsert,
            this.btnUpdate,
            this.btnRefresh,
            this.btnClose});
			this.skinToolStrip1.Location = new System.Drawing.Point(4, 28);
			this.skinToolStrip1.Name = "skinToolStrip1";
			this.skinToolStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
			this.skinToolStrip1.Size = new System.Drawing.Size(1192, 40);
			this.skinToolStrip1.SkinAllColor = true;
			this.skinToolStrip1.TabIndex = 2;
			this.skinToolStrip1.Text = "skinToolStrip1";
			this.skinToolStrip1.TitleAnamorphosis = true;
			this.skinToolStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
			this.skinToolStrip1.TitleRadius = 4;
			this.skinToolStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
			// 
			// btnInsert
			// 
			this.btnInsert.Image = global::App.Properties.Resources.add;
			this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnInsert.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(48, 37);
			this.btnInsert.Text = "添加(&I)";
			this.btnInsert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Image = global::App.Properties.Resources.edit;
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(53, 37);
			this.btnUpdate.Text = "修改(&U)";
			this.btnUpdate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = global::App.Properties.Resources.refresh;
			this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(52, 37);
			this.btnRefresh.Text = "刷新(&R)";
			this.btnRefresh.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// btnClose
			// 
			this.btnClose.Image = global::App.Properties.Resources.exit;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(52, 37);
			this.btnClose.Text = "关闭(&C)";
			this.btnClose.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// skinPanel1
			// 
			this.skinPanel1.BackColor = System.Drawing.Color.White;
			this.skinPanel1.BorderColor = System.Drawing.Color.White;
			this.skinPanel1.Controls.Add(this.skinTextBox1);
			this.skinPanel1.Controls.Add(this.skinButton1);
			this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.skinPanel1.DownBack = null;
			this.skinPanel1.Location = new System.Drawing.Point(4, 68);
			this.skinPanel1.MouseBack = null;
			this.skinPanel1.Name = "skinPanel1";
			this.skinPanel1.NormlBack = null;
			this.skinPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.skinPanel1.Size = new System.Drawing.Size(1192, 48);
			this.skinPanel1.TabIndex = 6;
			// 
			// skinTextBox1
			// 
			this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
			this.skinTextBox1.DownBack = null;
			this.skinTextBox1.Icon = null;
			this.skinTextBox1.IconIsButton = false;
			this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox1.IsPasswordChat = '\0';
			this.skinTextBox1.IsSystemPasswordChar = false;
			this.skinTextBox1.Lines = new string[0];
			this.skinTextBox1.Location = new System.Drawing.Point(6, 10);
			this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
			this.skinTextBox1.MaxLength = 32767;
			this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
			this.skinTextBox1.MouseBack = null;
			this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
			this.skinTextBox1.Multiline = false;
			this.skinTextBox1.Name = "skinTextBox1";
			this.skinTextBox1.NormlBack = null;
			this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
			this.skinTextBox1.ReadOnly = false;
			this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.skinTextBox1.Size = new System.Drawing.Size(160, 28);
			// 
			// 
			// 
			this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
			this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
			this.skinTextBox1.SkinTxt.Name = "BaseText";
			this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(150, 18);
			this.skinTextBox1.SkinTxt.TabIndex = 0;
			this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox1.SkinTxt.WaterText = "名称/拼音";
			this.skinTextBox1.TabIndex = 7;
			this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
			this.skinTextBox1.WaterText = "名称/拼音";
			this.skinTextBox1.WordWrap = true;
			// 
			// skinButton1
			// 
			this.skinButton1.BackColor = System.Drawing.Color.Transparent;
			this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
			this.skinButton1.DownBack = null;
			this.skinButton1.Location = new System.Drawing.Point(171, 10);
			this.skinButton1.MouseBack = null;
			this.skinButton1.Name = "skinButton1";
			this.skinButton1.NormlBack = null;
			this.skinButton1.Size = new System.Drawing.Size(75, 28);
			this.skinButton1.TabIndex = 6;
			this.skinButton1.Text = "查询";
			this.skinButton1.UseVisualStyleBackColor = false;
			this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
			// 
			// FrmExaminePrice
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 900);
			this.Controls.Add(this.grd);
			this.Controls.Add(this.skinPanel1);
			this.Controls.Add(this.skinToolStrip1);
			this.Name = "FrmExaminePrice";
			this.ShowDrawIcon = false;
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "检查项目及价格管理";
			this.Load += new System.EventHandler(this.FrmExaminePrice_Load);
			((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
			this.skinToolStrip1.ResumeLayout(false);
			this.skinToolStrip1.PerformLayout();
			this.skinPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView grd;
        private CCWin.SkinControl.SkinToolStrip skinToolStrip1;
        private System.Windows.Forms.ToolStripButton btnInsert;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnClose;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}