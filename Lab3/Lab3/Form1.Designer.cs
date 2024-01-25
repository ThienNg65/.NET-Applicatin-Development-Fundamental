namespace Lab3
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSum = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.title_label = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.quantity_label = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.extendPrice_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Discount_label = new System.Windows.Forms.Label();
            this.lblEPrice = new System.Windows.Forms.TextBox();
            this.lblDis = new System.Windows.Forms.TextBox();
            this.label_NetDue = new System.Windows.Forms.Label();
            this.lblNetDue = new System.Windows.Forms.TextBox();
            this.chkDis = new System.Windows.Forms.CheckBox();
            this.chkDisStudent = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.mnuCal,
            this.mnuSum,
            this.exitToolStripMenuItem});
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabel1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // mnuCal
            // 
            this.mnuCal.Name = "mnuCal";
            this.mnuCal.Size = new System.Drawing.Size(224, 26);
            this.mnuCal.Text = "Calculate";
            this.mnuCal.Click += new System.EventHandler(this.mnuCal_Click);
            // 
            // mnuSum
            // 
            this.mnuSum.Name = "mnuSum";
            this.mnuSum.Size = new System.Drawing.Size(224, 26);
            this.mnuSum.Text = "Summary";
            this.mnuSum.Click += new System.EventHandler(this.mnuSum_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(88, 79);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(41, 20);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(184, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(300, 22);
            this.txtTitle.TabIndex = 2;
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.Location = new System.Drawing.Point(88, 137);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(71, 20);
            this.quantity_label.TabIndex = 3;
            this.quantity_label.Text = "Quantity";
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(184, 91);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(181, 22);
            this.txtQuan.TabIndex = 4;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.Location = new System.Drawing.Point(88, 196);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(48, 20);
            this.price_label.TabIndex = 5;
            this.price_label.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(184, 150);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(181, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // extendPrice_label
            // 
            this.extendPrice_label.AutoSize = true;
            this.extendPrice_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extendPrice_label.Location = new System.Drawing.Point(88, 257);
            this.extendPrice_label.Name = "extendPrice_label";
            this.extendPrice_label.Size = new System.Drawing.Size(122, 20);
            this.extendPrice_label.TabIndex = 7;
            this.extendPrice_label.Text = "Extended Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDisStudent);
            this.groupBox1.Controls.Add(this.chkDis);
            this.groupBox1.Controls.Add(this.lblNetDue);
            this.groupBox1.Controls.Add(this.label_NetDue);
            this.groupBox1.Controls.Add(this.lblDis);
            this.groupBox1.Controls.Add(this.Discount_label);
            this.groupBox1.Controls.Add(this.lblEPrice);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.txtQuan);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(40, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 395);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // Discount_label
            // 
            this.Discount_label.AutoSize = true;
            this.Discount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount_label.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Discount_label.Location = new System.Drawing.Point(48, 275);
            this.Discount_label.Name = "Discount_label";
            this.Discount_label.Size = new System.Drawing.Size(76, 20);
            this.Discount_label.TabIndex = 9;
            this.Discount_label.Text = "Discount";
            // 
            // lblEPrice
            // 
            this.lblEPrice.Location = new System.Drawing.Point(184, 211);
            this.lblEPrice.Name = "lblEPrice";
            this.lblEPrice.ReadOnly = true;
            this.lblEPrice.Size = new System.Drawing.Size(181, 22);
            this.lblEPrice.TabIndex = 6;
            // 
            // lblDis
            // 
            this.lblDis.Location = new System.Drawing.Point(184, 272);
            this.lblDis.Name = "lblDis";
            this.lblDis.ReadOnly = true;
            this.lblDis.Size = new System.Drawing.Size(181, 22);
            this.lblDis.TabIndex = 10;
            // 
            // label_NetDue
            // 
            this.label_NetDue.AutoSize = true;
            this.label_NetDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NetDue.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label_NetDue.Location = new System.Drawing.Point(48, 327);
            this.label_NetDue.Name = "label_NetDue";
            this.label_NetDue.Size = new System.Drawing.Size(71, 20);
            this.label_NetDue.TabIndex = 11;
            this.label_NetDue.Text = "Net Due";
            // 
            // lblNetDue
            // 
            this.lblNetDue.Location = new System.Drawing.Point(184, 327);
            this.lblNetDue.Name = "lblNetDue";
            this.lblNetDue.ReadOnly = true;
            this.lblNetDue.Size = new System.Drawing.Size(181, 22);
            this.lblNetDue.TabIndex = 12;
            // 
            // chkDis
            // 
            this.chkDis.AutoSize = true;
            this.chkDis.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chkDis.Location = new System.Drawing.Point(392, 242);
            this.chkDis.Name = "chkDis";
            this.chkDis.Size = new System.Drawing.Size(128, 20);
            this.chkDis.TabIndex = 13;
            this.chkDis.Text = "Normal Discount";
            this.chkDis.UseVisualStyleBackColor = true;
            // 
            // chkDisStudent
            // 
            this.chkDisStudent.AutoSize = true;
            this.chkDisStudent.ForeColor = System.Drawing.Color.Black;
            this.chkDisStudent.Location = new System.Drawing.Point(392, 288);
            this.chkDisStudent.Name = "chkDisStudent";
            this.chkDisStudent.Size = new System.Drawing.Size(120, 20);
            this.chkDisStudent.TabIndex = 15;
            this.chkDisStudent.Text = "Distinct Student";
            this.chkDisStudent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 478);
            this.Controls.Add(this.extendPrice_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label extendPrice_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCal;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSum;
        private System.Windows.Forms.Label Discount_label;
        private System.Windows.Forms.TextBox lblEPrice;
        private System.Windows.Forms.TextBox lblDis;
        private System.Windows.Forms.Label label_NetDue;
        private System.Windows.Forms.TextBox lblNetDue;
        private System.Windows.Forms.CheckBox chkDis;
        private System.Windows.Forms.CheckBox chkDisStudent;
    }
}

