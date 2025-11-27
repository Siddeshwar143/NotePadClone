namespace Day36
{
    partial class Form3
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
            label4 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtLName = new TextBox();
            btnSubmit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 51);
            label1.Name = "label1";
            label1.Size = new Size(275, 38);
            label1.TabIndex = 0;
            label1.Text = "Student Registration ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 125);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Your ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 182);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 2;
            label3.Text = "Enter Your Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 237);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 3;
            label4.Text = "Enter your Last Name:";
            // 
            // txtId
            // 
            txtId.Location = new Point(416, 122);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 4;
            txtId.TextChanged += txtId_TextChanged;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(416, 182);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(416, 234);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(125, 27);
            txtLName.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(205, 352);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // button1
            // 
            button1.Location = new Point(378, 352);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 450);
            Controls.Add(button1);
            Controls.Add(btnSubmit);
            Controls.Add(txtLName);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtLName;
        private Button btnSubmit;
        private Button button1;
    }
}