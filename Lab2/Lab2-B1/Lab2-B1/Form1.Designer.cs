namespace Lab2_B1
{
    partial class Form1
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
            this.StName_label = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.yob_label = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.class_standard_label = new System.Windows.Forms.Label();
            this.Division_label = new System.Windows.Forms.Label();
            this.Hobbies_label = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.cboDiv = new System.Windows.Forms.ComboBox();
            this.lstHob = new System.Windows.Forms.CheckedListBox();
            this.Detail_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StName_label
            // 
            this.StName_label.AutoSize = true;
            this.StName_label.Location = new System.Drawing.Point(57, 86);
            this.StName_label.Name = "StName_label";
            this.StName_label.Size = new System.Drawing.Size(92, 16);
            this.StName_label.TabIndex = 0;
            this.StName_label.Text = "Student Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // yob_label
            // 
            this.yob_label.AutoSize = true;
            this.yob_label.Location = new System.Drawing.Point(57, 132);
            this.yob_label.Name = "yob_label";
            this.yob_label.Size = new System.Drawing.Size(78, 16);
            this.yob_label.TabIndex = 2;
            this.yob_label.Text = "Year of birth";
            this.yob_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(182, 129);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(126, 22);
            this.txtYear.TabIndex = 3;
            // 
            // class_standard_label
            // 
            this.class_standard_label.AutoSize = true;
            this.class_standard_label.Location = new System.Drawing.Point(57, 176);
            this.class_standard_label.Name = "class_standard_label";
            this.class_standard_label.Size = new System.Drawing.Size(100, 16);
            this.class_standard_label.TabIndex = 4;
            this.class_standard_label.Text = "Standard/Class";
            this.class_standard_label.Click += new System.EventHandler(this.class_standard_label_Click);
            // 
            // Division_label
            // 
            this.Division_label.AutoSize = true;
            this.Division_label.Location = new System.Drawing.Point(57, 254);
            this.Division_label.Name = "Division_label";
            this.Division_label.Size = new System.Drawing.Size(55, 16);
            this.Division_label.TabIndex = 7;
            this.Division_label.Text = "Division";
            this.Division_label.Click += new System.EventHandler(this.Division_label_Click);
            // 
            // Hobbies_label
            // 
            this.Hobbies_label.AutoSize = true;
            this.Hobbies_label.Location = new System.Drawing.Point(57, 306);
            this.Hobbies_label.Name = "Hobbies_label";
            this.Hobbies_label.Size = new System.Drawing.Size(48, 16);
            this.Hobbies_label.TabIndex = 9;
            this.Hobbies_label.Text = "Hobby";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(84, 397);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(179, 34);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm Student Details";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(303, 397);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 34);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clear_Click);
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 16;
            this.lstClass.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI",
            "VII",
            "VIII",
            "IX",
            "X"});
            this.lstClass.Location = new System.Drawing.Point(182, 176);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(126, 52);
            this.lstClass.TabIndex = 6;
            // 
            // cboDiv
            // 
            this.cboDiv.FormattingEnabled = true;
            this.cboDiv.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboDiv.Location = new System.Drawing.Point(182, 254);
            this.cboDiv.Name = "cboDiv";
            this.cboDiv.Size = new System.Drawing.Size(126, 24);
            this.cboDiv.TabIndex = 14;
            // 
            // lstHob
            // 
            this.lstHob.FormattingEnabled = true;
            this.lstHob.Items.AddRange(new object[] {
            "Singing",
            "Dancing",
            "Swimming",
            "Reading",
            "Travelling"});
            this.lstHob.Location = new System.Drawing.Point(182, 306);
            this.lstHob.Name = "lstHob";
            this.lstHob.Size = new System.Drawing.Size(126, 55);
            this.lstHob.TabIndex = 15;
            // 
            // Detail_label
            // 
            this.Detail_label.AutoSize = true;
            this.Detail_label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Detail_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detail_label.Location = new System.Drawing.Point(90, 23);
            this.Detail_label.Name = "Detail_label";
            this.Detail_label.Size = new System.Drawing.Size(280, 29);
            this.Detail_label.TabIndex = 16;
            this.Detail_label.Text = "Student\'s Class Details";
            this.Detail_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Detail_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 495);
            this.Controls.Add(this.Detail_label);
            this.Controls.Add(this.lstHob);
            this.Controls.Add(this.cboDiv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.Hobbies_label);
            this.Controls.Add(this.Division_label);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.class_standard_label);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.yob_label);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.StName_label);
            this.Name = "Form1";
            this.Text = "StudentDetails";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StName_label;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label yob_label;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label class_standard_label;
        private System.Windows.Forms.Label Division_label;
        private System.Windows.Forms.Label Hobbies_label;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.ComboBox cboDiv;
        private System.Windows.Forms.CheckedListBox lstHob;
        private System.Windows.Forms.Label Detail_label;
    }
}

