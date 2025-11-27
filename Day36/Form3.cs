using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day36
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtLName.Text == "" || txtName.Text == "")
            {
                MessageBox.Show($"ERROR...");
            }
            else
                MessageBox.Show($"Student ID: {txtId.Text}\nStudent Full Name: {txtName.Text} {txtLName.Text}");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) ;

            else
            {
                MessageBox.Show("enter digits only");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
