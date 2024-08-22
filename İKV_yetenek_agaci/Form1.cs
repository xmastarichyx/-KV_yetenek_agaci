using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İKV_yetenek_agaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buyucu11.Hide();
            savasci11.Show();
            savasci11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buyucu11.Hide();
            savasci11.Show();
            savasci11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            savasci11.Hide();
            buyucu11.Show();
            buyucu11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            savasci11.Hide();
            buyucu11.Hide();
            envanter1.Show();
            envanter1.BringToFront();
        }
    }
}
