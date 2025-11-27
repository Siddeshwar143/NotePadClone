using Microsoft.Data.SqlClient;

namespace Day36
{
    public partial class Form11 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=SIDDU;database=CSDB;user Id=sa;password=123;trust server certificate=true");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = $"select * from Form where Userid='{textBox1.Text}' and Pwd='{textBox2.Text}' ";
            cmd = new SqlCommand(s, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Ado5 a = new Ado5();
                a.Show();
            }
            else
            {
                MessageBox.Show("Login credentials are Invalid");
            }
            con.Close();
        }
    }
}