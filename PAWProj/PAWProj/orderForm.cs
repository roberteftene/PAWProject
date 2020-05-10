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
    public partial class orderForm : Form
    {
        public orderForm()
        {
            InitializeComponent();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {

        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            orderInputP.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            orderInputP.Hide();
        }
    }
}
