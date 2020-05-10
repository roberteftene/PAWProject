using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWProj
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void getOrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
