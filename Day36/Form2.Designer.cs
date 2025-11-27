namespace Day36
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            optmale = new RadioButton();
            optfemale = new RadioButton();
            btnSubmit = new Button();
            lblDisplay = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(154, 240);
            label2.Name = "label2";
            label2.Size = new Size(190, 31);
            label2.TabIndex = 1;
            label2.Text = "Employee Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(154, 172);
            label3.Name = "label3";
            label3.Size = new Size(187, 31);
            label3.TabIndex = 2;
            label3.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(154, 104);
            label4.Name = "label4";
            label4.Size = new Size(148, 31);
            label4.TabIndex = 3;
            label4.Text = "Employee ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(154, 308);
            label5.Name = "label5";
            label5.Size = new Size(91, 31);
            label5.TabIndex = 4;
            label5.Text = "Gender";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Gainsboro;
            txtID.Location = new Point(423, 110);
            txtID.Name = "txtID";
            txtID.Size = new Size(214, 27);
            txtID.TabIndex = 15;
            txtID.KeyPress += txtID_KeyPress_1;
            // 
            // txtName
            // 
            txtName.BackColor = Color.Gainsboro;
            txtName.Location = new Point(423, 172);
            txtName.Name = "txtName";
            txtName.Size = new Size(214, 27);
            txtName.TabIndex = 14;
            // 
            // optmale
            // 
            optmale.AutoSize = true;
            optmale.BackColor = Color.Transparent;
            optmale.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optmale.ForeColor = Color.Red;
            optmale.Location = new Point(423, 315);
            optmale.Name = "optmale";
            optmale.Size = new Size(86, 35);
            optmale.TabIndex = 9;
            optmale.TabStop = true;
            optmale.Text = "Male";
            optmale.UseVisualStyleBackColor = false;
            // 
            // optfemale
            // 
            optfemale.AutoSize = true;
            optfemale.BackColor = Color.Transparent;
            optfemale.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            optfemale.ForeColor = Color.Red;
            optfemale.Location = new Point(542, 315);
            optfemale.Name = "optfemale";
            optfemale.Size = new Size(108, 35);
            optfemale.TabIndex = 10;
            optfemale.TabStop = true;
            optfemale.Text = "Female";
            optfemale.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Red;
            btnSubmit.Location = new Point(279, 368);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(167, 41);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += lblDisplay_Click;
            // 
            // lblDisplay
            // 
            lblDisplay.Location = new Point(254, 413);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(252, 82);
            lblDisplay.TabIndex = 12;
            lblDisplay.Text = "Display";
            lblDisplay.Click += lblDisplay_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(222, 37);
            label6.Name = "label6";
            label6.Size = new Size(293, 38);
            label6.TabIndex = 17;
            label6.Text = "Employee Registration";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Location = new Point(423, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(805, 504);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(lblDisplay);
            Controls.Add(btnSubmit);
            Controls.Add(optfemale);
            Controls.Add(optmale);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtSalary;
        private RadioButton optmale;
        private RadioButton optfemale;
        private Button btnSubmit;
        private Label lblDisplay;
        private Label label6;
        private TextBox textBox1;
    }
}