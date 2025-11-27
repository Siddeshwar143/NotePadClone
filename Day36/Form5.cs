using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day36
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Focus();
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (txtPhone.Text.Trim().Length > 0)
            {
                Regex mobileValidation = new Regex(@"^[6-9]\d{9}$");
                if (!mobileValidation.IsMatch(txtPhone.Text))
                {
                    MessageBox.Show("Entered number is not a valid mobile number.", "Phone Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Trim().Length > 0)
            {
                Regex emailValidation = new Regex(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$");
                if (!emailValidation.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Entered string is not in a valid email format.", "Email Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Employee Emailid: {txtEmail.Text}\nEmployee Phone no: {txtPhone.Text}");
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
