namespace Lab2_B3
{
    partial class FlightReserveDetails
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
            this.Main_label = new System.Windows.Forms.Label();
            this.ticktNumber_label = new System.Windows.Forms.Label();
            this.txtTicketNumber = new System.Windows.Forms.TextBox();
            this.passengerName_label = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.passportNumber_label = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.source_label = new System.Windows.Forms.Label();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.destination_label = new System.Windows.Forms.Label();
            this.lstDestination = new System.Windows.Forms.ListBox();
            this.flightDate_label = new System.Windows.Forms.Label();
            this.dateFlight = new System.Windows.Forms.DateTimePicker();
            this.class_label = new System.Windows.Forms.Label();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.services_label = new System.Windows.Forms.Label();
            this.cblServices = new System.Windows.Forms.CheckedListBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Main_label
            // 
            this.Main_label.AutoSize = true;
            this.Main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_label.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Main_label.Location = new System.Drawing.Point(60, 25);
            this.Main_label.Name = "Main_label";
            this.Main_label.Size = new System.Drawing.Size(351, 31);
            this.Main_label.TabIndex = 0;
            this.Main_label.Text = "Flight Reservation Details";
            this.Main_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ticktNumber_label
            // 
            this.ticktNumber_label.AutoSize = true;
            this.ticktNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticktNumber_label.Location = new System.Drawing.Point(40, 85);
            this.ticktNumber_label.Name = "ticktNumber_label";
            this.ticktNumber_label.Size = new System.Drawing.Size(115, 20);
            this.ticktNumber_label.TabIndex = 1;
            this.ticktNumber_label.Text = "Ticket number";
            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.Location = new System.Drawing.Point(208, 85);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(126, 22);
            this.txtTicketNumber.TabIndex = 2;
            // 
            // passengerName_label
            // 
            this.passengerName_label.AutoSize = true;
            this.passengerName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerName_label.Location = new System.Drawing.Point(40, 134);
            this.passengerName_label.Name = "passengerName_label";
            this.passengerName_label.Size = new System.Drawing.Size(138, 20);
            this.passengerName_label.TabIndex = 3;
            this.passengerName_label.Text = "Passenger Name";
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Location = new System.Drawing.Point(208, 134);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(217, 22);
            this.txtPassengerName.TabIndex = 4;
            // 
            // passportNumber_label
            // 
            this.passportNumber_label.AutoSize = true;
            this.passportNumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportNumber_label.Location = new System.Drawing.Point(40, 184);
            this.passportNumber_label.Name = "passportNumber_label";
            this.passportNumber_label.Size = new System.Drawing.Size(137, 20);
            this.passportNumber_label.TabIndex = 5;
            this.passportNumber_label.Text = "Passport number";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(208, 184);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(126, 22);
            this.txtPassportNumber.TabIndex = 6;
            // 
            // source_label
            // 
            this.source_label.AutoSize = true;
            this.source_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_label.Location = new System.Drawing.Point(40, 228);
            this.source_label.Name = "source_label";
            this.source_label.Size = new System.Drawing.Size(62, 20);
            this.source_label.TabIndex = 7;
            this.source_label.Text = "Source";
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 16;
            this.lstSource.Items.AddRange(new object[] {
            "Amsterdam",
            "Ha Noi",
            "Singapore",
            "Can Tho"});
            this.lstSource.Location = new System.Drawing.Point(208, 228);
            this.lstSource.Name = "lstSource";
            this.lstSource.Size = new System.Drawing.Size(126, 68);
            this.lstSource.TabIndex = 8;
            // 
            // destination_label
            // 
            this.destination_label.AutoSize = true;
            this.destination_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_label.Location = new System.Drawing.Point(40, 322);
            this.destination_label.Name = "destination_label";
            this.destination_label.Size = new System.Drawing.Size(94, 20);
            this.destination_label.TabIndex = 9;
            this.destination_label.Text = "Destination";
            // 
            // lstDestination
            // 
            this.lstDestination.FormattingEnabled = true;
            this.lstDestination.ItemHeight = 16;
            this.lstDestination.Items.AddRange(new object[] {
            "Amsterdam",
            "Ha Noi",
            "Singapore",
            "Can Tho"});
            this.lstDestination.Location = new System.Drawing.Point(208, 322);
            this.lstDestination.Name = "lstDestination";
            this.lstDestination.Size = new System.Drawing.Size(126, 68);
            this.lstDestination.TabIndex = 10;
            // 
            // flightDate_label
            // 
            this.flightDate_label.AutoSize = true;
            this.flightDate_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightDate_label.Location = new System.Drawing.Point(40, 417);
            this.flightDate_label.Name = "flightDate_label";
            this.flightDate_label.Size = new System.Drawing.Size(91, 20);
            this.flightDate_label.TabIndex = 11;
            this.flightDate_label.Text = "Flight Date";
            // 
            // dateFlight
            // 
            this.dateFlight.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFlight.Location = new System.Drawing.Point(208, 417);
            this.dateFlight.Name = "dateFlight";
            this.dateFlight.Size = new System.Drawing.Size(126, 22);
            this.dateFlight.TabIndex = 12;
            // 
            // class_label
            // 
            this.class_label.AutoSize = true;
            this.class_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_label.Location = new System.Drawing.Point(40, 466);
            this.class_label.Name = "class_label";
            this.class_label.Size = new System.Drawing.Size(52, 20);
            this.class_label.TabIndex = 13;
            this.class_label.Text = "Class";
            // 
            // lstClass
            // 
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 16;
            this.lstClass.Items.AddRange(new object[] {
            "First Class",
            "Business Class",
            "Premium Class",
            "Economy Class"});
            this.lstClass.Location = new System.Drawing.Point(208, 466);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(126, 20);
            this.lstClass.TabIndex = 14;
            // 
            // services_label
            // 
            this.services_label.AutoSize = true;
            this.services_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.services_label.Location = new System.Drawing.Point(40, 513);
            this.services_label.Name = "services_label";
            this.services_label.Size = new System.Drawing.Size(74, 20);
            this.services_label.TabIndex = 15;
            this.services_label.Text = "Services";
            // 
            // cblServices
            // 
            this.cblServices.FormattingEnabled = true;
            this.cblServices.Items.AddRange(new object[] {
            "Child Care",
            "Nurse"});
            this.cblServices.Location = new System.Drawing.Point(208, 513);
            this.cblServices.Name = "cblServices";
            this.cblServices.Size = new System.Drawing.Size(126, 38);
            this.cblServices.TabIndex = 16;
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(113, 579);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(111, 37);
            this.btnVerify.TabIndex = 17;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(255, 579);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 37);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FlightReserveDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 654);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.cblServices);
            this.Controls.Add(this.services_label);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.class_label);
            this.Controls.Add(this.dateFlight);
            this.Controls.Add(this.flightDate_label);
            this.Controls.Add(this.lstDestination);
            this.Controls.Add(this.destination_label);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.source_label);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.passportNumber_label);
            this.Controls.Add(this.txtPassengerName);
            this.Controls.Add(this.passengerName_label);
            this.Controls.Add(this.txtTicketNumber);
            this.Controls.Add(this.ticktNumber_label);
            this.Controls.Add(this.Main_label);
            this.Name = "FlightReserveDetails";
            this.Text = "Flight Reservation Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Main_label;
        private System.Windows.Forms.Label ticktNumber_label;
        private System.Windows.Forms.TextBox txtTicketNumber;
        private System.Windows.Forms.Label passengerName_label;
        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.Label passportNumber_label;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label source_label;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.Label destination_label;
        private System.Windows.Forms.ListBox lstDestination;
        private System.Windows.Forms.Label flightDate_label;
        private System.Windows.Forms.DateTimePicker dateFlight;
        private System.Windows.Forms.Label class_label;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.Label services_label;
        private System.Windows.Forms.CheckedListBox cblServices;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnClear;
    }
}

