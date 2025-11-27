namespace Day36
{
    partial class Form9
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
            label1 = new Label();
            empid = new Label();
            empname = new Label();
            empsalary = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtSalary = new TextBox();
            btnNext = new Button();
            btnNew = new Button();
            btnInsert = new Button();
            btnUpadte = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            empjob = new Label();
            txtJob = new TextBox();
            empstatus = new Label();
            checkStatus = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(102, 9);
            label1.Name = "label1";
            label1.Size = new Size(448, 38);
            label1.TabIndex = 0;
            label1.Text = "Employee Registration with ADO";
            // 
            // empid
            // 
            empid.AutoSize = true;
            empid.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empid.ForeColor = Color.Red;
            empid.Location = new Point(102, 93);
            empid.Name = "empid";
            empid.Size = new Size(134, 25);
            empid.TabIndex = 1;
            empid.Text = "Employee ID : ";
            // 
            // empname
            // 
            empname.AutoSize = true;
            empname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empname.ForeColor = Color.Red;
            empname.Location = new Point(99, 133);
            empname.Name = "empname";
            empname.Size = new Size(165, 25);
            empname.TabIndex = 2;
            empname.Text = "Employee Name : ";
            // 
            // empsalary
            // 
            empsalary.AutoSize = true;
            empsalary.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empsalary.ForeColor = Color.Red;
            empsalary.Location = new Point(99, 213);
            empsalary.Name = "empsalary";
            empsalary.Size = new Size(75, 25);
            empsalary.TabIndex = 3;
            empsalary.Text = "Salary :";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(352, 91);
            txtId.Name = "txtId";
            txtId.Size = new Size(209, 27);
            txtId.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(352, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 2;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(352, 214);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(209, 27);
            txtSalary.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(12, 302);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(160, 65);
            btnNext.TabIndex = 7;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(242, 302);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(160, 65);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(467, 302);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(160, 65);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpadte
            // 
            btnUpadte.Location = new Point(12, 379);
            btnUpadte.Name = "btnUpadte";
            btnUpadte.Size = new Size(160, 65);
            btnUpadte.TabIndex = 10;
            btnUpadte.Text = "Update";
            btnUpadte.UseVisualStyleBackColor = true;
            btnUpadte.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(242, 379);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 65);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(467, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 65);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // empjob
            // 
            empjob.AutoSize = true;
            empjob.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empjob.ForeColor = Color.Red;
            empjob.Location = new Point(102, 173);
            empjob.Name = "empjob";
            empjob.Size = new Size(57, 25);
            empjob.TabIndex = 13;
            empjob.Text = "Job : ";
            // 
            // txtJob
            // 
            txtJob.Location = new Point(352, 173);
            txtJob.Name = "txtJob";
            txtJob.Size = new Size(209, 27);
            txtJob.TabIndex = 3;
            // 
            // empstatus
            // 
            empstatus.AutoSize = true;
            empstatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empstatus.ForeColor = Color.Red;
            empstatus.Location = new Point(102, 248);
            empstatus.Name = "empstatus";
            empstatus.Size = new Size(75, 25);
            empstatus.TabIndex = 15;
            empstatus.Text = "Status :";
            // 
            // checkStatus
            // 
            checkStatus.AutoSize = true;
            checkStatus.Enabled = false;
            checkStatus.Location = new Point(352, 255);
            checkStatus.Name = "checkStatus";
            checkStatus.Size = new Size(17, 16);
            checkStatus.TabIndex = 16;
            checkStatus.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_19_at_18_47_21_6f4211f5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(648, 453);
            Controls.Add(checkStatus);
            Controls.Add(empstatus);
            Controls.Add(txtJob);
            Controls.Add(empjob);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpadte);
            Controls.Add(btnInsert);
            Controls.Add(btnNew);
            Controls.Add(btnNext);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(empsalary);
            Controls.Add(empname);
            Controls.Add(empid);
            Controls.Add(label1);
            Name = "Form9";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Transparent;
            Load += Form9_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label empid;
        private Label empname;
        private Label empsalary;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtSalary;
        private Button btnNext;
        private Button btnNew;
        private Button btnInsert;
        private Button btnUpadte;
        private Button btnDelete;
        private Button btnClose;
        private Label empjob;
        private TextBox txtJob;
        private Label empstatus;
        private RadioButton checkStatus;
    }
}