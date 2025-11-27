namespace Day36
{
    partial class Ado5
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
            lblsuccess = new Label();
            SuspendLayout();
            // 
            // lblsuccess
            // 
            lblsuccess.AutoSize = true;
            lblsuccess.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblsuccess.Location = new Point(236, 184);
            lblsuccess.Name = "lblsuccess";
            lblsuccess.Size = new Size(244, 38);
            lblsuccess.TabIndex = 0;
            lblsuccess.Text = "Successfully Login";
            // 
            // Ado5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblsuccess);
            Name = "Ado5";
            Text = "Ado5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblsuccess;
    }
}