namespace Day36
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnRed = new Button();
            btnGreen = new Button();
            btnYellow = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnRed
            // 
            btnRed.BackColor = SystemColors.Control;
            btnRed.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRed.ForeColor = Color.Red;
            btnRed.Location = new Point(42, 277);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(159, 61);
            btnRed.TabIndex = 1;
            btnRed.Text = "RED";
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += button1_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = SystemColors.Control;
            btnGreen.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGreen.ForeColor = Color.Green;
            btnGreen.Location = new Point(295, 277);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(159, 61);
            btnGreen.TabIndex = 2;
            btnGreen.Text = "GREEN";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += button2_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = SystemColors.Control;
            btnYellow.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYellow.ForeColor = Color.Yellow;
            btnYellow.Location = new Point(540, 277);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(159, 61);
            btnYellow.TabIndex = 3;
            btnYellow.Text = "YELLOW";
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYellow);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnRed;
        private Button btnGreen;
        private Button btnYellow;
    }
}
