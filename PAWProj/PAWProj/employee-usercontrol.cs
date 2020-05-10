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
    public partial class employee_usercontrol : UserControl
    {
        public employee_usercontrol()
        {
            InitializeComponent();
        }

        private void loginClientBtn_Click(object sender, EventArgs e)
        {
            Employee newForm = new Employee();
            this.Hide();
            newForm.ShowDialog();
            this.Show();
        }

        private void employee_usercontrol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Method to hide the initial form when opening another form

            //Opening the another form
            this.Hide();
            Employee newForm = new Employee();
            newForm.ShowDialog();
            this.Show();
            
        }
    }
}
