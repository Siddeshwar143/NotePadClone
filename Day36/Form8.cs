using Microsoft.Data.SqlClient;
using System.Data.Odbc;

namespace Day36
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdbcConnection con = new OdbcConnection("DSN=SqlD;");
                con.Open();
            MessageBox.Show("Connection State: " + con.State);
            con.Close();
            MessageBox.Show("Connection State: " + con.State);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SIDDU; database=master; User Id=sa; Password=123; Trust Server Certificate=true;");
            con.Open();
            MessageBox.Show("Connection State: " + con.State);
            con.Close();
            MessageBox.Show("Connection State: " + con.State);
        }
    }
}
