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
    public partial class AddWaiter : Form
    {

        List<Waiter> waiters = new List<Waiter>();

        public AddWaiter()
        {
            InitializeComponent();
        }

        private void addWaiterBtn_Click(object sender, EventArgs e)
        {

            try
            {
                string firstName = fNameInput.Text;
                string lastName = lNameInput.Text;
                int age = Convert.ToInt32(ageInput.Text);
                string experience = experienceInput.Text;

                Waiter w = new Waiter(firstName, lastName, age, experience);
                waiters.Add(w);
                MessageBox.Show(w.ToString());
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fNameInput.Text = "";
                lNameInput.Text = "";
                ageInput.Text = "";
                experienceInput.Text = "";
            }
        }
    }
}
