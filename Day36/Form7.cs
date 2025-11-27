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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox1.Items.Remove(listBox1.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox1.Items.Add(listBox2.Text);
                listBox2.Items.Remove(listBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var items in listBox1.Items)
            {
                listBox2.Items.Add(items);
            }
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var items in listBox2.Items)
            {
                listBox1.Items.Add(items);
            }
            listBox2.Items.Clear();
        }
    }
}
