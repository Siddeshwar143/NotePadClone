using System.Data.Odbc;

namespace Day36
{
    public partial class Form12 : Form
    {
        OdbcConnection con;
        OdbcCommand cmd;
        OdbcDataReader dr;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            con = new OdbcConnection("DSN=ExcelDSN;ReadOnly=0");
            cmd = new OdbcCommand();
            cmd.Connection = con;
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            cmd.CommandText = "Select * From [Student$]";
            dr = cmd.ExecuteReader();
            ShowData();
        }
        private void ShowData()
        {
            if (dr.Read())
            {
                txtSid.Text = dr["Studentid"].ToString();
                txtSName.Text = dr["StudentName"].ToString();
                txtClass.Text = dr["Class"].ToString();
                txtFees.Text = dr["Fees"].ToString();
            }
            else
                MessageBox.Show("Your are at the last record of the table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSid.Text=txtSName.Text=txtClass.Text=txtFees.Text="";
            btnInsert.Enabled = true;

        }
    }
}
