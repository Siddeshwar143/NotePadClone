namespace Day36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }
    }
}
