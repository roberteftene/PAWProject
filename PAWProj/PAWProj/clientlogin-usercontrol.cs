using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWProj
{
    public partial class clientlogin_usercontrol : UserControl
    {
        public clientlogin_usercontrol()
        {
            InitializeComponent();
        }

        private void loginClientBtn_Click(object sender, EventArgs e)
        {
            Client newForm = new Client();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientlogin_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
