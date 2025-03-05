using System.Runtime.Versioning;
using System.Globalization;
using System.Threading;

namespace C969_Scheduling.Forms
{
    partial class AddAppointment
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
            btnSubmit = new Button();
            lblTitle = new Label();
            lblType = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            lblCustomer = new Label();
            lblDescription = new Label();
            tbTitle = new TextBox();
            tbType = new TextBox();
            tbDescription = new TextBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            cbCustomers = new ComboBox();
            lblAppointmentForm = new Label();
            btnCancel = new Button();
            tbUrl = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(153, 357);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = Properties.Resources.btnSubmit;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(45, 103);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(44, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(40, 149);
            lblType.Name = "lblType";
            lblType.Size = new Size(49, 25);
            lblType.TabIndex = 2;
            lblType.Text = "Type";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(40, 252);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(48, 25);
            lblStart.TabIndex = 3;
            lblStart.Text = "Start";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(40, 302);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(42, 25);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "End";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(348, 103);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(89, 25);
            lblCustomer.TabIndex = 5;
            lblCustomer.Text = "Customer";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(348, 149);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(102, 25);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(95, 100);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(211, 31);
            tbTitle.TabIndex = 7;
            // 
            // tbType
            // 
            tbType.Location = new Point(95, 149);
            tbType.Name = "tbType";
            tbType.Size = new Size(211, 31);
            tbType.TabIndex = 10;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(456, 149);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(225, 184);
            tbDescription.TabIndex = 12;
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Time;
            dtpStart.Location = new Point(95, 252);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(211, 31);
            dtpStart.TabIndex = 13;
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Time;
            dtpEnd.Location = new Point(95, 302);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(211, 31);
            dtpEnd.TabIndex = 14;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(456, 103);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(225, 33);
            cbCustomers.TabIndex = 15;
            // 
            // lblAppointmentForm
            // 
            lblAppointmentForm.AutoSize = true;
            lblAppointmentForm.Location = new Point(269, 33);
            lblAppointmentForm.Name = "lblAppointmentForm";
            lblAppointmentForm.Size = new Size(192, 25);
            lblAppointmentForm.TabIndex = 16;
            lblAppointmentForm.Text = "Add Edit Appointmnet";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(456, 357);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 17;
            btnCancel.Text = Properties.Resources.btnCancel;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbUrl
            // 
            tbUrl.Location = new Point(95, 199);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(211, 31);
            tbUrl.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 199);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 18;
            label1.Text = "Url";
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 435);
            Controls.Add(tbUrl);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(lblAppointmentForm);
            Controls.Add(cbCustomers);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(tbDescription);
            Controls.Add(tbType);
            Controls.Add(tbTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblCustomer);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(lblType);
            Controls.Add(lblTitle);
            Controls.Add(btnSubmit);
            Name = "AddAppointment";
            Text = "Appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblTitle;
        private Label lblType;
        private Label lblStart;
        private Label lblEnd;
        private Label lblCustomer;
        private Label lblDescription;
        private TextBox tbTitle;
        private TextBox tbType;
        private TextBox tbDescription;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private ComboBox cbCustomers;
        private Label lblAppointmentForm;
        private Button btnCancel;
        private TextBox tbUrl;
        private Label label1;
    }
}