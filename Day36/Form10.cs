using Microsoft.Data.SqlClient;
namespace Day36
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void Form10_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=SIDDU; database=master; User Id=sa; Password=123; Trust Server Certificate=true;");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            cmd.CommandText = "Select EmpId, EmpName, EmpDesignation, EmpDoj From Employee1";
            dr = cmd.ExecuteReader();
            ShowData();
        }
        private void ShowData()
        {
            if (dr.Read())
            {
                textBox1.Text = dr["label2"].ToString();
                textBox2.Text = dr["label3"].ToString();
                textBox3.Text = dr["label4"].ToString();
                textBox4.Text = dr["label5"].ToString();
            }
            else
            {
                MessageBox.Show("You are at the last record of table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            dr.Close();
            cmd.CommandText = $"Insert Into Employee1 (EmpId, EmpName, EmpDesignation, FORMATE(EmpDoj,'yyyy-MM-dd')) Values ({textBox1.Text}, '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}')";
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insert operations is successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed inserting record into the table.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dr.Close();
            cmd.CommandText = $"Update Into Employee1 (EmpId, EmpName, EmpDesignation, FORMATE(EmpDoj,'yyyy-MM-dd')) Values ({textBox1.Text}, '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}')";
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Update operations is successful.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed Updating record into the table.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
