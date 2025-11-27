using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day36
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (optmale.Checked)
            {
                gender = optmale.Text;
            }
            else
            {
                gender = optfemale.Text;
            }
            lblDisplay.Text = $"Employee id: {txtID.Text}\nEmployee Name: {txtName.Text}\nEmployee Salary: {txtSalary.Text}\nEmployee Gender:{gender}";
        }

        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && Convert.ToInt32(e.KeyChar) != 8)
            {
                MessageBox.Show("Please enter numeric values only", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) == true)
            {
                MessageBox.Show("Please enter Name only", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
