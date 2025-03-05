namespace C969_Scheduling.Forms
{
    partial class DisplayReport
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
            dgvReport = new DataGridView();
            btnClose = new Button();
            lblReport = new Label();
            btnExport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // dgvReport
            // 
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(88, 103);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 62;
            dgvReport.Size = new Size(976, 825);
            dgvReport.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(952, 959);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 1;
            btnClose.Text = Properties.Resources.btnClose;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Location = new Point(506, 34);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(104, 25);
            lblReport.TabIndex = 2;
            lblReport.Text = "placeholder";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(814, 959);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(112, 34);
            btnExport.TabIndex = 3;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // DisplayReport
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 1015);
            Controls.Add(btnExport);
            Controls.Add(lblReport);
            Controls.Add(btnClose);
            Controls.Add(dgvReport);
            Name = "DisplayReport";
            Text = "Report Viewer";
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReport;
        private Button btnClose;
        private Label lblReport;
        private Button btnExport;
    }
}