namespace Day36
{
    partial class Form12
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
            txtClass = new TextBox();
            sclass = new Label();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpadte = new Button();
            btnInsert = new Button();
            btnClear = new Button();
            btnNext = new Button();
            txtFees = new TextBox();
            txtSName = new TextBox();
            txtSid = new TextBox();
            sfees = new Label();
            sname = new Label();
            sid = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtClass
            // 
            txtClass.Location = new Point(338, 166);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(209, 27);
            txtClass.TabIndex = 22;
            // 
            // sclass
            // 
            sclass.AutoSize = true;
            sclass.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sclass.ForeColor = Color.Red;
            sclass.Location = new Point(88, 166);
            sclass.Name = "sclass";
            sclass.Size = new Size(69, 25);
            sclass.TabIndex = 31;
            sclass.Text = "Class : ";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(473, 372);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(160, 65);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(248, 372);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 65);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpadte
            // 
            btnUpadte.Location = new Point(18, 372);
            btnUpadte.Name = "btnUpadte";
            btnUpadte.Size = new Size(160, 65);
            btnUpadte.TabIndex = 28;
            btnUpadte.Text = "Update";
            btnUpadte.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Enabled = false;
            btnInsert.Location = new Point(464, 281);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(160, 65);
            btnInsert.TabIndex = 27;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 281);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 65);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(18, 281);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(160, 65);
            btnNext.TabIndex = 25;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtFees
            // 
            txtFees.Location = new Point(338, 207);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(209, 27);
            txtFees.TabIndex = 24;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(338, 125);
            txtSName.Name = "txtSName";
            txtSName.Size = new Size(209, 27);
            txtSName.TabIndex = 21;
            // 
            // txtSid
            // 
            txtSid.Enabled = false;
            txtSid.Location = new Point(338, 84);
            txtSid.Name = "txtSid";
            txtSid.ReadOnly = true;
            txtSid.Size = new Size(209, 27);
            txtSid.TabIndex = 18;
            // 
            // sfees
            // 
            sfees.AutoSize = true;
            sfees.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfees.ForeColor = Color.Red;
            sfees.Location = new Point(85, 206);
            sfees.Name = "sfees";
            sfees.Size = new Size(59, 25);
            sfees.TabIndex = 23;
            sfees.Text = "Fees :";
            // 
            // sname
            // 
            sname.AutoSize = true;
            sname.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sname.ForeColor = Color.Red;
            sname.Location = new Point(85, 126);
            sname.Name = "sname";
            sname.Size = new Size(149, 25);
            sname.TabIndex = 20;
            sname.Text = "Student Name : ";
            // 
            // sid
            // 
            sid.AutoSize = true;
            sid.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sid.ForeColor = Color.Red;
            sid.Location = new Point(88, 86);
            sid.Name = "sid";
            sid.Size = new Size(118, 25);
            sid.TabIndex = 19;
            sid.Text = "Student ID : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 17;
            label1.Text = "Student Details";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 495);
            Controls.Add(txtClass);
            Controls.Add(sclass);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpadte);
            Controls.Add(btnInsert);
            Controls.Add(btnClear);
            Controls.Add(btnNext);
            Controls.Add(txtFees);
            Controls.Add(txtSName);
            Controls.Add(txtSid);
            Controls.Add(sfees);
            Controls.Add(sname);
            Controls.Add(sid);
            Controls.Add(label1);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClass;
        private Label sclass;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpadte;
        private Button btnInsert;
        private Button btnClear;
        private Button btnNext;
        private TextBox txtFees;
        private TextBox txtSName;
        private TextBox txtSid;
        private Label sfees;
        private Label sname;
        private Label sid;
        private Label label1;
    }
}