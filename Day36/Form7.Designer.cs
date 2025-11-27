namespace Day36
{
    partial class Form7
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Red;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Thums Up", "Sprite", "Maaza", "Coca-Cola" });
            listBox1.Location = new Point(52, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(166, 196);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(214, 36);
            label1.Name = "label1";
            label1.Size = new Size(409, 38);
            label1.TabIndex = 1;
            label1.Text = "LISTBOX IN WINDOWS FORM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(52, 341);
            label2.Name = "label2";
            label2.Size = new Size(161, 38);
            label2.TabIndex = 2;
            label2.Text = "ColdDrinks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(561, 341);
            label3.Name = "label3";
            label3.Size = new Size(151, 38);
            label3.TabIndex = 3;
            label3.Text = "HotDrinks";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.Fuchsia;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.Items.AddRange(new object[] { "Tea", "Coffee", "Green Tea", "Boost" });
            listBox2.Location = new Point(561, 92);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(166, 196);
            listBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(361, 98);
            button1.Name = "button1";
            button1.Size = new Size(81, 45);
            button1.TabIndex = 5;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(361, 149);
            button2.Name = "button2";
            button2.Size = new Size(81, 45);
            button2.TabIndex = 6;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(361, 200);
            button3.Name = "button3";
            button3.Size = new Size(81, 45);
            button3.TabIndex = 7;
            button3.Text = ">>";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(361, 251);
            button4.Name = "button4";
            button4.Size = new Size(81, 45);
            button4.TabIndex = 8;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}