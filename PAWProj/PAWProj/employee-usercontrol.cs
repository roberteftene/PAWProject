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
    }
}
