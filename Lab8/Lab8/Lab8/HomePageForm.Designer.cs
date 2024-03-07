namespace Lab8
{
    partial class HomePageForm
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnUpdateScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(48, 41);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(695, 292);
            this.lstBox.TabIndex = 0;
            // 
            // btnUpdateScore
            // 
            this.btnUpdateScore.Location = new System.Drawing.Point(329, 366);
            this.btnUpdateScore.Name = "btnUpdateScore";
            this.btnUpdateScore.Size = new System.Drawing.Size(136, 42);
            this.btnUpdateScore.TabIndex = 1;
            this.btnUpdateScore.Text = "Update Score";
            this.btnUpdateScore.UseVisualStyleBackColor = true;
            this.btnUpdateScore.Click += new System.EventHandler(this.btnUpdateScore_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateScore);
            this.Controls.Add(this.lstBox);
            this.Name = "HomePageForm";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnUpdateScore;
    }
}