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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Day36
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBoxType_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtYearofPass_Validating(object sender, CancelEventArgs e)
        {


            if (txtYearofPass.Text.Trim().Length > 0)
            {
                Regex YearofPassValidation = new Regex(@"^[0-9]\d{4}$");
                if (!YearofPassValidation.IsMatch(txtYearofPass.Text))
                {
                }
            }
        }
    }
}
