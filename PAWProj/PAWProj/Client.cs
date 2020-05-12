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
        orderForm orderMethodsForm = new orderForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        reservationForm reservationMethodsForm = new reservationForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


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
            reservationMethodsForm.Hide();
            this.pContainer.Controls.Add(orderMethodsForm);
            orderMethodsForm.Show();
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

        private void reviewBtn_Click(object sender, EventArgs e)
        {

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void reservationBtn_Click(object sender, EventArgs e)
        //{
        //    //reservationForm newForm = new orderFo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        //    ////newForm.FormBorderStyle = { FormBorderStyle}cbo
        //    //this.pContainer.Controls.Add(newForm);
        //    //newForm.Show();
        //}

        private void reservationBtn_Click_1(object sender, EventArgs e)
        {
            orderMethodsForm.Hide();
            this.pContainer.Controls.Add(reservationMethodsForm);
            reservationMethodsForm.Show();
        }
    }
}
