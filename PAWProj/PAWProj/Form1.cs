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
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
            clientlogin_usercontrol1.Hide();
            employee_usercontrol1.Hide();
          
        }

        void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void Login_Click(object sender, EventArgs e)
        {
            clientlogin_usercontrol1.Show();
            clientlogin_usercontrol1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void waiterButton_Click(object sender, EventArgs e)
        {
            employee_usercontrol1.Show();
            employee_usercontrol1.BringToFront();
        }

        private void clientlogin_usercontrol1_Load_1(object sender, EventArgs e)
        {

            clientlogin_usercontrol1.Hide();

        }

        private void employee_usercontrol1_Load(object sender, EventArgs e)
        {
            employee_usercontrol1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void employee_usercontrol1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
