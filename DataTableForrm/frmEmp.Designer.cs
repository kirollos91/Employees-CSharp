namespace DataTableForrm
{
    partial class frmEmp
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.rdoGreaderThan = new System.Windows.Forms.RadioButton();
            this.rdoLessThan = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rdoAddress = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoNum = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightBlue;
            this.label1.Location = new System.Drawing.Point(400, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Form";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.rdoGreaderThan);
            this.panelSearch.Controls.Add(this.rdoLessThan);
            this.panelSearch.Controls.Add(this.label9);
            this.panelSearch.Controls.Add(this.lblResult);
            this.panelSearch.Controls.Add(this.rdoSalary);
            this.panelSearch.Controls.Add(this.dgvSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.label7);
            this.panelSearch.Controls.Add(this.rdoAddress);
            this.panelSearch.Controls.Add(this.rdoName);
            this.panelSearch.Controls.Add(this.rdoNum);
            this.panelSearch.Controls.Add(this.label6);
            this.panelSearch.Location = new System.Drawing.Point(516, 44);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(532, 396);
            this.panelSearch.TabIndex = 13;
            // 
            // rdoGreaderThan
            // 
            this.rdoGreaderThan.AutoSize = true;
            this.rdoGreaderThan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoGreaderThan.Location = new System.Drawing.Point(465, 62);
            this.rdoGreaderThan.Name = "rdoGreaderThan";
            this.rdoGreaderThan.Size = new System.Drawing.Size(36, 24);
            this.rdoGreaderThan.TabIndex = 20;
            this.rdoGreaderThan.TabStop = true;
            this.rdoGreaderThan.Text = ">";
            this.rdoGreaderThan.UseVisualStyleBackColor = true;
            this.rdoGreaderThan.Visible = false;
            // 
            // rdoLessThan
            // 
            this.rdoLessThan.AutoSize = true;
            this.rdoLessThan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoLessThan.Location = new System.Drawing.Point(420, 62);
            this.rdoLessThan.Name = "rdoLessThan";
            this.rdoLessThan.Size = new System.Drawing.Size(36, 24);
            this.rdoLessThan.TabIndex = 19;
            this.rdoLessThan.TabStop = true;
            this.rdoLessThan.Text = "<";
            this.rdoLessThan.UseVisualStyleBackColor = true;
            this.rdoLessThan.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Location = new System.Drawing.Point(213, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 26);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data Search";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblResult.Location = new System.Drawing.Point(29, 130);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(126, 20);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Result 0 Row(s):";
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoSalary.Location = new System.Drawing.Point(422, 35);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(71, 24);
            this.rdoSalary.TabIndex = 4;
            this.rdoSalary.TabStop = true;
            this.rdoSalary.Text = "Salary";
            this.rdoSalary.UseVisualStyleBackColor = true;
            this.rdoSalary.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AllowUserToDeleteRows = false;
            this.dgvSearch.AllowUserToOrderColumns = true;
            this.dgvSearch.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(10, 156);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.Size = new System.Drawing.Size(522, 235);
            this.dgvSearch.TabIndex = 15;
            this.dgvSearch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseClick);
            this.dgvSearch.SelectionChanged += new System.EventHandler(this.dgvSearch_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(412, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 34);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Blue;
            this.txtSearch.Location = new System.Drawing.Point(133, 96);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(273, 26);
            this.txtSearch.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Search Text :";
            // 
            // rdoAddress
            // 
            this.rdoAddress.AutoSize = true;
            this.rdoAddress.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoAddress.Location = new System.Drawing.Point(321, 35);
            this.rdoAddress.Name = "rdoAddress";
            this.rdoAddress.Size = new System.Drawing.Size(86, 24);
            this.rdoAddress.TabIndex = 3;
            this.rdoAddress.TabStop = true;
            this.rdoAddress.Text = "Address";
            this.rdoAddress.UseVisualStyleBackColor = true;
            this.rdoAddress.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Checked = true;
            this.rdoName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoName.Location = new System.Drawing.Point(238, 35);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(69, 24);
            this.rdoName.TabIndex = 2;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // rdoNum
            // 
            this.rdoNum.AutoSize = true;
            this.rdoNum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdoNum.Location = new System.Drawing.Point(144, 35);
            this.rdoNum.Name = "rdoNum";
            this.rdoNum.Size = new System.Drawing.Size(83, 24);
            this.rdoNum.TabIndex = 1;
            this.rdoNum.TabStop = true;
            this.rdoNum.Text = "Number";
            this.rdoNum.UseVisualStyleBackColor = true;
            this.rdoNum.CheckedChanged += new System.EventHandler(this.rdoSalary_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search By:";
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.btnNew);
            this.panelData.Controls.Add(this.label8);
            this.panelData.Controls.Add(this.btnFind);
            this.panelData.Controls.Add(this.btnDelete);
            this.panelData.Controls.Add(this.btnEdit);
            this.panelData.Controls.Add(this.btnAdd);
            this.panelData.Controls.Add(this.txtSalary);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.txtAddress);
            this.panelData.Controls.Add(this.label4);
            this.panelData.Controls.Add(this.txtEmpName);
            this.panelData.Controls.Add(this.label3);
            this.panelData.Controls.Add(this.txtEmpNum);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Location = new System.Drawing.Point(12, 44);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(498, 396);
            this.panelData.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNew.Location = new System.Drawing.Point(53, 200);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 37);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New*";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Location = new System.Drawing.Point(197, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data Input";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFind.Location = new System.Drawing.Point(368, 200);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(74, 37);
            this.btnFind.TabIndex = 24;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(288, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 37);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(208, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 37);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(128, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 37);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.ForeColor = System.Drawing.Color.Blue;
            this.txtSalary.Location = new System.Drawing.Point(183, 143);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(273, 26);
            this.txtSalary.TabIndex = 20;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Salary";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Blue;
            this.txtAddress.Location = new System.Drawing.Point(183, 111);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 26);
            this.txtAddress.TabIndex = 18;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Address";
            // 
            // txtEmpName
            // 
            this.txtEmpName.ForeColor = System.Drawing.Color.Blue;
            this.txtEmpName.Location = new System.Drawing.Point(183, 79);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(273, 26);
            this.txtEmpName.TabIndex = 16;
            this.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Employee Name";
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.ForeColor = System.Drawing.Color.Blue;
            this.txtEmpNum.Location = new System.Drawing.Point(183, 47);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.ReadOnly = true;
            this.txtEmpNum.Size = new System.Drawing.Size(273, 26);
            this.txtEmpNum.TabIndex = 14;
            this.txtEmpNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee Number";
            // 
            // frmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmp";
            this.Load += new System.EventHandler(this.frmEmp_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.RadioButton rdoAddress;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.RadioButton rdoGreaderThan;
        private System.Windows.Forms.RadioButton rdoLessThan;
    }
}

