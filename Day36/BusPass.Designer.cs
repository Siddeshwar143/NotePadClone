namespace Day36
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            txtDob = new TextBox();
            txtYearofPass = new TextBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.Client;
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(txtDob);
            groupBox1.Controls.Add(txtYearofPass);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1079, 279);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "1.Student 10th Details";
            // 
            // comboBox2
            // 
            comboBox2.AccessibleRole = AccessibleRole.None;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Regular", "Supplementry" });
            comboBox2.Location = new Point(843, 51);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(139, 36);
            comboBox2.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(843, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 34);
            textBox2.TabIndex = 8;
            // 
            // txtDob
            // 
            txtDob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDob.Location = new Point(261, 165);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(139, 34);
            txtDob.TabIndex = 7;
            // 
            // txtYearofPass
            // 
            txtYearofPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYearofPass.Location = new Point(261, 106);
            txtYearofPass.Name = "txtYearofPass";
            txtYearofPass.Size = new Size(139, 34);
            txtYearofPass.TabIndex = 6;
            txtYearofPass.Validating += txtYearofPass_Validating;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleRole = AccessibleRole.None;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SSC", "CBSC", "ICSE", "ORIENTAL", "APOS", "Other Board" });
            comboBox1.Location = new Point(261, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 36);
            comboBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(556, 131);
            label5.Name = "label5";
            label5.Size = new Size(221, 28);
            label5.TabIndex = 4;
            label5.Text = "1.4 SSC hall ticket no. *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(556, 51);
            label4.Name = "label4";
            label4.Size = new Size(158, 56);
            label4.TabIndex = 3;
            label4.Text = "1.2 SSC Regular/\r\nSupplementry *\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 165);
            label3.Name = "label3";
            label3.Size = new Size(159, 56);
            label3.TabIndex = 2;
            label3.Text = "1.5 Date of Birth\r\n(dd/mm/yyyy) *\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 106);
            label2.Name = "label2";
            label2.Size = new Size(205, 28);
            label2.TabIndex = 1;
            label2.Text = "1.3 SSC Year of Pass *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 0;
            label1.Text = "1.1 SSC Board Type *";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 498);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox txtDob;
        private TextBox txtYearofPass;
        private ComboBox comboBox2;
        private TextBox textBox2;
    }
}