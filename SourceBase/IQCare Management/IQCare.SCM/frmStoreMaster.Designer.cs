﻿namespace IQCare.SCM
{
    partial class frmStoreMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreMaster));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMaxPid = new System.Windows.Forms.Label();
            this.lblPID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgwStoreName = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPurchasingStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDispensingStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDispensing = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPurchasingStore = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.lblStoreID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.ddlPurchasingStore = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoreName)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(799, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 77;
            this.label1.Tag = "lblLabel";
            this.label1.Text = "Move";
            // 
            // btnDown
            // 
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.Location = new System.Drawing.Point(802, 296);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(26, 26);
            this.btnDown.TabIndex = 75;
            this.btnDown.Tag = "btnFlexible";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.Location = new System.Drawing.Point(802, 178);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(26, 26);
            this.btnUp.TabIndex = 74;
            this.btnUp.Tag = "btnFlexible";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMaxPid);
            this.panel2.Controls.Add(this.lblPID);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 47);
            this.panel2.TabIndex = 78;
            this.panel2.Tag = "pnlSubPanel";
            // 
            // lblMaxPid
            // 
            this.lblMaxPid.AutoSize = true;
            this.lblMaxPid.Location = new System.Drawing.Point(104, 47);
            this.lblMaxPid.Name = "lblMaxPid";
            this.lblMaxPid.Size = new System.Drawing.Size(13, 13);
            this.lblMaxPid.TabIndex = 47;
            this.lblMaxPid.Text = "0";
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(101, 50);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(13, 13);
            this.lblPID.TabIndex = 46;
            this.lblPID.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(692, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Tag = "btnSingleText";
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(771, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Tag = "btnSingleText";
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgwStoreName
            // 
            this.dgwStoreName.AllowUserToAddRows = false;
            this.dgwStoreName.AllowUserToDeleteRows = false;
            this.dgwStoreName.AllowUserToResizeColumns = false;
            this.dgwStoreName.AllowUserToResizeRows = false;
            this.dgwStoreName.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgwStoreName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStoreName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ColStoreID,
            this.ColStoreName,
            this.ColPurchasingStore,
            this.ColDispensingStore,
            this.ColStatus,
            this.SRNo});
            this.dgwStoreName.Location = new System.Drawing.Point(5, 92);
            this.dgwStoreName.Name = "dgwStoreName";
            this.dgwStoreName.Size = new System.Drawing.Size(767, 359);
            this.dgwStoreName.TabIndex = 73;
            this.dgwStoreName.Tag = "dgwDataGridView";
            this.dgwStoreName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStoreName_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // ColStoreID
            // 
            this.ColStoreID.HeaderText = "Store ID";
            this.ColStoreID.Name = "ColStoreID";
            this.ColStoreID.ReadOnly = true;
            // 
            // ColStoreName
            // 
            this.ColStoreName.HeaderText = "Store Name";
            this.ColStoreName.Name = "ColStoreName";
            this.ColStoreName.ReadOnly = true;
            this.ColStoreName.Width = 307;
            // 
            // ColPurchasingStore
            // 
            this.ColPurchasingStore.HeaderText = "Central Store";
            this.ColPurchasingStore.Name = "ColPurchasingStore";
            this.ColPurchasingStore.ReadOnly = true;
            // 
            // ColDispensingStore
            // 
            this.ColDispensingStore.HeaderText = "Dispensing Store";
            this.ColDispensingStore.Name = "ColDispensingStore";
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // SRNo
            // 
            this.SRNo.HeaderText = "SRNo";
            this.SRNo.Name = "SRNo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDispensing);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlStatus);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.lblPurchasingStore);
            this.groupBox1.Controls.Add(this.txtStoreName);
            this.groupBox1.Controls.Add(this.lblStoreName);
            this.groupBox1.Controls.Add(this.txtStoreID);
            this.groupBox1.Controls.Add(this.lblStoreID);
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.ddlPurchasingStore);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 83);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // cmbDispensing
            // 
            this.cmbDispensing.AutoCompleteCustomSource.AddRange(new string[] {
            "No",
            "Yes"});
            this.cmbDispensing.BackColor = System.Drawing.Color.White;
            this.cmbDispensing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDispensing.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbDispensing.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cmbDispensing.Location = new System.Drawing.Point(346, 49);
            this.cmbDispensing.Name = "cmbDispensing";
            this.cmbDispensing.Size = new System.Drawing.Size(129, 21);
            this.cmbDispensing.TabIndex = 4;
            this.cmbDispensing.Tag = "ddlDropDownList";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 69;
            this.label2.Tag = "lblLabelRequired";
            this.label2.Text = "Dispensing Store:";
            // 
            // ddlStatus
            // 
            this.ddlStatus.BackColor = System.Drawing.Color.White;
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ddlStatus.Location = new System.Drawing.Point(528, 49);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(129, 21);
            this.ddlStatus.TabIndex = 5;
            this.ddlStatus.Tag = "ddlDropDownList";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(678, 47);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Tag = "btnSingleText";
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPurchasingStore
            // 
            this.lblPurchasingStore.AutoSize = true;
            this.lblPurchasingStore.Location = new System.Drawing.Point(5, 52);
            this.lblPurchasingStore.Name = "lblPurchasingStore";
            this.lblPurchasingStore.Size = new System.Drawing.Size(91, 13);
            this.lblPurchasingStore.TabIndex = 45;
            this.lblPurchasingStore.Tag = "lblLabelRequired";
            this.lblPurchasingStore.Text = "Purchasing Store:";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(324, 16);
            this.txtStoreName.MaxLength = 200;
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(334, 20);
            this.txtStoreName.TabIndex = 2;
            this.txtStoreName.Tag = "txtTextBox";
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Location = new System.Drawing.Point(256, 21);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(66, 13);
            this.lblStoreName.TabIndex = 42;
            this.lblStoreName.Tag = "lblLabelRequired";
            this.lblStoreName.Text = "Store Name:";
            // 
            // txtStoreID
            // 
            this.txtStoreID.AcceptsReturn = true;
            this.txtStoreID.AcceptsTab = true;
            this.txtStoreID.HideSelection = false;
            this.txtStoreID.Location = new System.Drawing.Point(100, 18);
            this.txtStoreID.MaxLength = 50;
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(148, 20);
            this.txtStoreID.TabIndex = 1;
            this.txtStoreID.Tag = "txtTextBox";
            // 
            // lblStoreID
            // 
            this.lblStoreID.AutoSize = true;
            this.lblStoreID.Location = new System.Drawing.Point(48, 21);
            this.lblStoreID.Name = "lblStoreID";
            this.lblStoreID.Size = new System.Drawing.Size(49, 13);
            this.lblStoreID.TabIndex = 39;
            this.lblStoreID.Tag = "lblLabelRequired";
            this.lblStoreID.Text = "Store ID:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(485, 53);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Tag = "lblLabelRequired";
            this.lblStatus.Text = "Status:";
            // 
            // ddlPurchasingStore
            // 
            this.ddlPurchasingStore.BackColor = System.Drawing.Color.White;
            this.ddlPurchasingStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPurchasingStore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ddlPurchasingStore.Location = new System.Drawing.Point(100, 48);
            this.ddlPurchasingStore.Name = "ddlPurchasingStore";
            this.ddlPurchasingStore.Size = new System.Drawing.Size(148, 21);
            this.ddlPurchasingStore.TabIndex = 3;
            this.ddlPurchasingStore.Tag = "ddlDropDownList";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IDTemp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Store ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Store Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Central Store";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Dispensing Store";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "theColumnUserId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // frmStoreMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(852, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgwStoreName);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStoreMaster";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "frmForm";
            this.Text = "Store Master";
            this.Load += new System.EventHandler(this.frmStoreMaster_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStoreName)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgwStoreName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPurchasingStore;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Label lblStoreID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox ddlPurchasingStore;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.ComboBox cmbDispensing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblMaxPid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStoreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPurchasingStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDispensingStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRNo;
    }
}