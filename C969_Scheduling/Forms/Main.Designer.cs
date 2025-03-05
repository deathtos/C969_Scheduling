namespace C969_Scheduling.Forms
{
    partial class Main
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
            dgvAppointments = new DataGridView();
            dgvCustomers = new DataGridView();
            lblCustomers = new Label();
            lblAppointmnets = new Label();
            monthCalendar1 = new MonthCalendar();
            btnAddCustomer = new Button();
            btnEditCustomer = new Button();
            btnDeleteCustomer = new Button();
            btnAddAppointment = new Button();
            btnEditAppointment = new Button();
            btnDeleteAppointment = new Button();
            cbReport = new CheckBox();
            btnReportSubmit = new Button();
            cbReport1 = new CheckBox();
            cbReport2 = new CheckBox();
            lblReports = new Label();
            btnShowAllAppointments = new Button();
            lblWelcome = new Label();
            lblLocation = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Location = new Point(405, 111);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 62;
            dgvAppointments.Size = new Size(1164, 391);
            dgvAppointments.TabIndex = 0;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(405, 591);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 62;
            dgvCustomers.Size = new Size(1164, 370);
            dgvCustomers.TabIndex = 1;
            // 
            // lblCustomers
            // 
            lblCustomers.AutoSize = true;
            lblCustomers.Location = new Point(405, 563);
            lblCustomers.Name = "lblCustomers";
            lblCustomers.Size = new Size(97, 25);
            lblCustomers.TabIndex = 2;
            lblCustomers.Text = "Customers";
            // 
            // lblAppointmnets
            // 
            lblAppointmnets.AutoSize = true;
            lblAppointmnets.Location = new Point(405, 83);
            lblAppointmnets.Name = "lblAppointmnets";
            lblAppointmnets.Size = new Size(126, 25);
            lblAppointmnets.TabIndex = 3;
            lblAppointmnets.Text = "Appointments";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(43, 177);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(405, 967);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(112, 34);
            btnAddCustomer.TabIndex = 5;
            btnAddCustomer.Text = Properties.Resources.btnAdd;
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(523, 967);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(112, 34);
            btnEditCustomer.TabIndex = 6;
            btnEditCustomer.Text = Properties.Resources.btnEdit;
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += btnEditCustomer_Click;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(641, 967);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(112, 34);
            btnDeleteCustomer.TabIndex = 7;
            btnDeleteCustomer.Text = Properties.Resources.btnDelete;
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.Location = new Point(405, 511);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Size = new Size(112, 34);
            btnAddAppointment.TabIndex = 8;
            btnAddAppointment.Text = Properties.Resources.btnAdd;
            btnAddAppointment.UseVisualStyleBackColor = true;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // btnEditAppointment
            // 
            btnEditAppointment.Location = new Point(523, 511);
            btnEditAppointment.Name = "btnEditAppointment";
            btnEditAppointment.Size = new Size(112, 34);
            btnEditAppointment.TabIndex = 9;
            btnEditAppointment.Text = Properties.Resources.btnEdit;
            btnEditAppointment.UseVisualStyleBackColor = true;
            btnEditAppointment.Click += btnEditAppointment_Click;
            // 
            // btnDeleteAppointment
            // 
            btnDeleteAppointment.Location = new Point(641, 511);
            btnDeleteAppointment.Name = "btnDeleteAppointment";
            btnDeleteAppointment.Size = new Size(112, 34);
            btnDeleteAppointment.TabIndex = 10;
            btnDeleteAppointment.Text = Properties.Resources.btnDelete;
            btnDeleteAppointment.UseVisualStyleBackColor = true;
            btnDeleteAppointment.Click += btnDeleteAppointment_Click;
            // 
            // cbReport
            // 
            cbReport.AutoSize = true;
            cbReport.Location = new Point(18, 755);
            cbReport.Name = "cbReport";
            cbReport.Size = new Size(364, 29);
            cbReport.TabIndex = 11;
            cbReport.Text = Properties.Resources.cbReport;
            cbReport.UseVisualStyleBackColor = true;
            // 
            // btnReportSubmit
            // 
            btnReportSubmit.Location = new Point(89, 875);
            btnReportSubmit.Name = "btnReportSubmit";
            btnReportSubmit.Size = new Size(112, 34);
            btnReportSubmit.TabIndex = 12;
            btnReportSubmit.Text = Properties.Resources.btnSubmit;
            btnReportSubmit.UseVisualStyleBackColor = true;
            btnReportSubmit.Click += btnReportSubmit_Click;
            // 
            // cbReport1
            // 
            cbReport1.AutoSize = true;
            cbReport1.Location = new Point(18, 790);
            cbReport1.Name = "cbReport1";
            cbReport1.Size = new Size(216, 29);
            cbReport1.TabIndex = 13;
            cbReport1.Text = Properties.Resources.cbReport1;
            cbReport1.UseVisualStyleBackColor = true;
            // 
            // cbReport2
            // 
            cbReport2.AutoSize = true;
            cbReport2.Location = new Point(18, 825);
            cbReport2.Name = "cbReport2";
            cbReport2.Size = new Size(256, 29);
            cbReport2.TabIndex = 14;
            cbReport2.Text = Properties.Resources.cbReport2;
            cbReport2.UseVisualStyleBackColor = true;
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Location = new Point(75, 707);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(148, 25);
            lblReports.TabIndex = 15;
            lblReports.Text = "Generate Reports";
            // 
            // btnShowAllAppointments
            // 
            btnShowAllAppointments.Location = new Point(89, 442);
            btnShowAllAppointments.Name = "btnShowAllAppointments";
            btnShowAllAppointments.Size = new Size(112, 34);
            btnShowAllAppointments.TabIndex = 16;
            btnShowAllAppointments.Text = "Show All";
            btnShowAllAppointments.UseVisualStyleBackColor = true;
            btnShowAllAppointments.Click += btnShowAllAppointments_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(43, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(94, 25);
            lblWelcome.TabIndex = 17;
            lblWelcome.Text = "Welcome, ";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(43, 97);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(151, 25);
            lblLocation.TabIndex = 18;
            lblLocation.Text = "Current Location: ";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1659, 1023);
            Controls.Add(lblLocation);
            Controls.Add(lblWelcome);
            Controls.Add(btnShowAllAppointments);
            Controls.Add(lblReports);
            Controls.Add(cbReport2);
            Controls.Add(cbReport1);
            Controls.Add(btnReportSubmit);
            Controls.Add(cbReport);
            Controls.Add(btnDeleteAppointment);
            Controls.Add(btnEditAppointment);
            Controls.Add(btnAddAppointment);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(monthCalendar1);
            Controls.Add(lblAppointmnets);
            Controls.Add(lblCustomers);
            Controls.Add(dgvCustomers);
            Controls.Add(dgvAppointments);
            Name = "Main";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAppointments;
        private DataGridView dgvCustomers;
        private Label lblCustomers;
        private Label lblAppointmnets;
        private MonthCalendar monthCalendar1;
        private Button btnAddCustomer;
        private Button btnEditCustomer;
        private Button btnDeleteCustomer;
        private Button btnAddAppointment;
        private Button btnEditAppointment;
        private Button btnDeleteAppointment;
        private CheckBox cbReport;
        private Button btnReportSubmit;
        private CheckBox cbReport1;
        private CheckBox cbReport2;
        private Label lblReports;
        private Button btnShowAllAppointments;
        private Label lblWelcome;
        private Label lblLocation;
    }
}