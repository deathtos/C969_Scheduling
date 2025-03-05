namespace C969_Scheduling.Forms
{
    partial class AddCustomer
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
            lblName = new Label();
            lblAddress = new Label();
            lblAddress2 = new Label();
            lblPostalCode = new Label();
            lblCity = new Label();
            lblCountry = new Label();
            lblPhoneNumber = new Label();
            lblCustomerForm = new Label();
            btnSubmit = new Button();
            btnCancel = new Button();
            tbName = new TextBox();
            tbAddress = new TextBox();
            tbAddress2 = new TextBox();
            tbPostalCode = new TextBox();
            tbCity = new TextBox();
            tbCountry = new TextBox();
            tbPhone = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(25, 112);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 1;
            lblAddress.Text = "Address";
            // 
            // lblAddress2
            // 
            lblAddress2.AutoSize = true;
            lblAddress2.Location = new Point(25, 163);
            lblAddress2.Name = "lblAddress2";
            lblAddress2.Size = new Size(92, 25);
            lblAddress2.TabIndex = 2;
            lblAddress2.Text = "Address 2";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(25, 216);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(106, 25);
            lblPostalCode.TabIndex = 3;
            lblPostalCode.Text = "Postal Code";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(349, 213);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 25);
            lblCity.TabIndex = 4;
            lblCity.Text = "City";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(25, 275);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(75, 25);
            lblCountry.TabIndex = 5;
            lblCountry.Text = "Country";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(25, 327);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(132, 25);
            lblPhoneNumber.TabIndex = 6;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblCustomerForm
            // 
            lblCustomerForm.AutoSize = true;
            lblCustomerForm.Location = new Point(238, 18);
            lblCustomerForm.Name = "lblCustomerForm";
            lblCustomerForm.Size = new Size(163, 25);
            lblCustomerForm.TabIndex = 7;
            lblCustomerForm.Text = "Add Edit Customer";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(189, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = Properties.Resources.btnSubmit;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(449, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = Properties.Resources.btnCancel;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(189, 60);
            tbName.Name = "tbName";
            tbName.Size = new Size(372, 31);
            tbName.TabIndex = 10;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(189, 112);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(372, 31);
            tbAddress.TabIndex = 11;
            // 
            // tbAddress2
            // 
            tbAddress2.Location = new Point(189, 163);
            tbAddress2.Name = "tbAddress2";
            tbAddress2.Size = new Size(372, 31);
            tbAddress2.TabIndex = 12;
            // 
            // tbPostalCode
            // 
            tbPostalCode.Location = new Point(189, 213);
            tbPostalCode.Name = "tbPostalCode";
            tbPostalCode.Size = new Size(150, 31);
            tbPostalCode.TabIndex = 13;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(411, 213);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(150, 31);
            tbCity.TabIndex = 14;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(189, 272);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(372, 31);
            tbCountry.TabIndex = 15;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(189, 327);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(372, 31);
            tbPhone.TabIndex = 16;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 450);
            Controls.Add(tbPhone);
            Controls.Add(tbCountry);
            Controls.Add(tbCity);
            Controls.Add(tbPostalCode);
            Controls.Add(tbAddress2);
            Controls.Add(tbAddress);
            Controls.Add(tbName);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(lblCustomerForm);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCountry);
            Controls.Add(lblCity);
            Controls.Add(lblPostalCode);
            Controls.Add(lblAddress2);
            Controls.Add(lblAddress);
            Controls.Add(lblName);
            Name = "AddCustomer";
            Text = "Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblAddress;
        private Label lblAddress2;
        private Label lblPostalCode;
        private Label lblCity;
        private Label lblCountry;
        private Label lblPhoneNumber;
        private Label lblCustomerForm;
        private Button btnSubmit;
        private Button btnCancel;
        private TextBox tbName;
        private TextBox tbAddress;
        private TextBox tbAddress2;
        private TextBox tbPostalCode;
        private TextBox tbCity;
        private TextBox tbCountry;
        private TextBox tbPhone;
    }
}