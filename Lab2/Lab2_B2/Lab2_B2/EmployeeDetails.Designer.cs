namespace Lab2_B2
{
    partial class EmployeeDetails
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
            this.employeeName_label = new System.Windows.Forms.Label();
            this.txtEName = new System.Windows.Forms.TextBox();
            this.employeeAdd_label = new System.Windows.Forms.Label();
            this.txtEAddress = new System.Windows.Forms.RichTextBox();
            this.date_label = new System.Windows.Forms.Label();
            this.dateJoin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lstboxEducation = new System.Windows.Forms.ListBox();
            this.cbBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employeeName_label
            // 
            this.employeeName_label.AutoSize = true;
            this.employeeName_label.Location = new System.Drawing.Point(56, 85);
            this.employeeName_label.Name = "employeeName_label";
            this.employeeName_label.Size = new System.Drawing.Size(109, 16);
            this.employeeName_label.TabIndex = 1;
            this.employeeName_label.Text = "Employee Name";
            // 
            // txtEName
            // 
            this.txtEName.Location = new System.Drawing.Point(203, 82);
            this.txtEName.Name = "txtEName";
            this.txtEName.Size = new System.Drawing.Size(220, 22);
            this.txtEName.TabIndex = 2;
            // 
            // employeeAdd_label
            // 
            this.employeeAdd_label.AutoSize = true;
            this.employeeAdd_label.Location = new System.Drawing.Point(56, 143);
            this.employeeAdd_label.Name = "employeeAdd_label";
            this.employeeAdd_label.Size = new System.Drawing.Size(123, 16);
            this.employeeAdd_label.TabIndex = 3;
            this.employeeAdd_label.Text = "Employee Address";
            // 
            // txtEAddress
            // 
            this.txtEAddress.Location = new System.Drawing.Point(203, 143);
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.Size = new System.Drawing.Size(220, 71);
            this.txtEAddress.TabIndex = 5;
            this.txtEAddress.Text = "";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(56, 247);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(96, 16);
            this.date_label.TabIndex = 6;
            this.date_label.Text = "Date of Joining";
            // 
            // dateJoin
            // 
            this.dateJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJoin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateJoin.Location = new System.Drawing.Point(203, 247);
            this.dateJoin.Name = "dateJoin";
            this.dateJoin.Size = new System.Drawing.Size(137, 22);
            this.dateJoin.TabIndex = 7;
            this.dateJoin.Value = new System.DateTime(2024, 1, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Education";
            // 
            // lstboxEducation
            // 
            this.lstboxEducation.FormattingEnabled = true;
            this.lstboxEducation.ItemHeight = 16;
            this.lstboxEducation.Items.AddRange(new object[] {
            "UnderGraduate",
            "PostGraduate"});
            this.lstboxEducation.Location = new System.Drawing.Point(203, 297);
            this.lstboxEducation.Name = "lstboxEducation";
            this.lstboxEducation.Size = new System.Drawing.Size(137, 20);
            this.lstboxEducation.TabIndex = 9;
            // 
            // cbBoxDepartment
            // 
            this.cbBoxDepartment.FormattingEnabled = true;
            this.cbBoxDepartment.Items.AddRange(new object[] {
            "Human Resource",
            "Marketing",
            "R&D"});
            this.cbBoxDepartment.Location = new System.Drawing.Point(203, 346);
            this.cbBoxDepartment.Name = "cbBoxDepartment";
            this.cbBoxDepartment.Size = new System.Drawing.Size(137, 24);
            this.cbBoxDepartment.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Department";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 35);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 407);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 35);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 35);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 476);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBoxDepartment);
            this.Controls.Add(this.lstboxEducation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateJoin);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.txtEAddress);
            this.Controls.Add(this.employeeAdd_label);
            this.Controls.Add(this.txtEName);
            this.Controls.Add(this.employeeName_label);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label employeeName_label;
        private System.Windows.Forms.TextBox txtEName;
        private System.Windows.Forms.Label employeeAdd_label;
        private System.Windows.Forms.RichTextBox txtEAddress;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.DateTimePicker dateJoin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstboxEducation;
        private System.Windows.Forms.ComboBox cbBoxDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}