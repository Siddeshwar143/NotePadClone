using Microsoft.Data.SqlClient;
using System.Data;
namespace Day36
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private void Form9_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=SIDDU;Database=CSDB;User Id=sa;Password=123;Trust Server Certificate=true");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            cmd.CommandText = "Select Eno,Ename,Job,Salary,Status From Employee";
            dr = cmd.ExecuteReader();
            ShowData();
        }
        private void ShowData()
        {
            if (dr.Read())
            {
                txtId.Text = dr["Eno"].ToString();
                txtName.Text = dr["Ename"].ToString();
                txtJob.Text = dr["Job"].ToString();
                txtSalary.Text = dr["Salary"].ToString();
                checkStatus.Checked = (bool)dr["Status"];
            }
            else
            {
                MessageBox.Show("You are at the last record of table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox? tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            checkStatus.Checked = false;
            dr.Close();
            cmd.CommandText = "Select IsNull(Max(Eno), 1000) + 1 From Employee";
            txtId.Text = cmd.ExecuteScalar().ToString();
            checkStatus.Enabled = btnInsert.Enabled = true;
            txtName.Focus();

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"Insert into Employee values({txtId.Text},'{txtName.Text}','{txtJob.Text}',{txtSalary.Text},{Convert.ToInt32(checkStatus.Checked)})";
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insert operations is successful.", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
                checkStatus.Enabled = btnInsert.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed inserting record into the table.", "Failure", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dr.Close();
            cmd.CommandText = $"Update Employee Set Ename='{txtName.Text}', Job='{txtJob.Text}',Salary ={ txtSalary.Text} Where Eno = { txtId.Text }";

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Update operations is successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                checkStatus.Enabled = btnInsert.Enabled = false;
            }
            else
            {
                MessageBox.Show("Failed Updating record into the table.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure of deleting the current record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dr.Close();
                cmd.CommandText = $"Update Employee Set Status=0 Where Eno={txtId.Text}";
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Delete operations is successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    checkStatus.Enabled = btnInsert.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed to deleting record into the table.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            this.Close();
        }
    }
}
