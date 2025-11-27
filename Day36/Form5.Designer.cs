
namespace Day36
{
    partial class Form5
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
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(157, 55);
            label1.Name = "label1";
            label1.Size = new Size(389, 38);
            label1.TabIndex = 0;
            label1.Text = "Validation in Windows Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(50, 146);
            label2.Name = "label2";
            label2.Size = new Size(236, 28);
            label2.TabIndex = 1;
            label2.Text = "Enter Employee Emailid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(50, 214);
            label3.Name = "label3";
            label3.Size = new Size(210, 28);
            label3.TabIndex = 2;
            label3.Text = "Enter Phone Number";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.Location = new Point(383, 150);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 27);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.Gainsboro;
            txtPhone.Location = new Point(383, 218);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(247, 27);
            txtPhone.TabIndex = 4;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Gainsboro;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.Red;
            btnSubmit.Location = new Point(260, 306);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(169, 41);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnSubmit;
    }
}