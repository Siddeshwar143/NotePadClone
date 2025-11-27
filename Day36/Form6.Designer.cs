namespace Day36
{
    partial class Form6
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
            comboBoxCountries = new ComboBox();
            comboBoxStates = new ComboBox();
            comboBoxCities = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 86);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 0;
            label1.Text = "Countries :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 167);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 1;
            label2.Text = "States :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 248);
            label3.Name = "label3";
            label3.Size = new Size(85, 31);
            label3.TabIndex = 2;
            label3.Text = "Cities :";
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountries.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Items.AddRange(new object[] { "India", "South Korea", "Russia" });
            comboBoxCountries.Location = new Point(382, 91);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(151, 33);
            comboBoxCountries.TabIndex = 3;
            comboBoxCountries.SelectedIndexChanged += comboBoxCountries_SelectedIndexChanged;
            // 
            // comboBoxStates
            // 
            comboBoxStates.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxStates.FormattingEnabled = true;
            comboBoxStates.Location = new Point(382, 169);
            comboBoxStates.Name = "comboBoxStates";
            comboBoxStates.Size = new Size(151, 33);
            comboBoxStates.TabIndex = 4;
            // 
            // comboBoxCities
            // 
            comboBoxCities.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCities.FormattingEnabled = true;
            comboBoxCities.Location = new Point(382, 250);
            comboBoxCities.Name = "comboBoxCities";
            comboBoxCities.Size = new Size(151, 33);
            comboBoxCities.TabIndex = 5;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxCities);
            Controls.Add(comboBoxStates);
            Controls.Add(comboBoxCountries);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxCountries;
        private ComboBox comboBoxStates;
        private ComboBox comboBoxCities;
    }
}