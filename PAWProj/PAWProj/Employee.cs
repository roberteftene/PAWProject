using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWProj
{
    public partial class Employee : Form
    {

        IFormatter formatter = new BinaryFormatter();
        Stream stream = new FileStream(@"C:\Users\Robert\Desktop\Projects\PAWProject\PAWProj\PAWProj\WaiterCV.txt", FileMode.Create, FileAccess.Write);
        List<Waiter> waiters = new List<Waiter>();


        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            this.listView1.Hide();
            this.waiterInputP.Hide();
            timer1.Start();
            timer2.Start();
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void getOrdersButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void getReservationsButton_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortDateString();
        }

        private void time_Click(object sender, EventArgs e)
        {
            //time.Text = DateTime.Now.ToLongTimeString();
        }

        private void viewOrdersBtn_Click(object sender, EventArgs e)
        {
            this.waiterInputP.Hide();
            this.listView1.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addWaiterBtn_Click(object sender, EventArgs e)
        {
            //this.waiterPanel.Controls.Add(waiterAdd);
            //waiterAdd.Show();
            this.listView1.Hide();
            waiterInputP.Show();
    
            
        }

        private void Employee_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.W)
            {
                this.listView1.Hide();
                waiterInputP.Show();
            }
        }

        private void viewWaiter_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                try
                {
                    string firstName = fNameInput.Text;
                    string lastName = lNameInput.Text;
                    int age = Convert.ToInt32(ageInput.Text);
                    string experience = experienceInput.Text;

                    Waiter w = new Waiter(firstName, lastName, age, experience);

                    ListViewItem itm = new ListViewItem(w.FirstName);
                    itm.SubItems.Add(w.LastName);
                    itm.SubItems.Add(w.Age.ToString());
                    itm.SubItems.Add(w.Experience);
                    listView1.Items.Add(itm);


                    formatter.Serialize(stream, w);
                    stream.Close();
                    stream = new FileStream(@"C:\Users\Robert\Desktop\Projects\PAWProject\PAWProj\PAWProj\WaiterCV.txt", FileMode.Open, FileAccess.Read);
                    Waiter wNew = (Waiter)formatter.Deserialize(stream);
                    MessageBox.Show(wNew.ToString());

                    waiters.Add(w);
                    //MessageBox.Show(w.ToString());
                }
                catch (Exception ex)
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

        private void fNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(fNameInput.Text) || fNameInput.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider1.SetError(fNameInput, "Enter a valid first name!");

            }
            else if (!Regex.IsMatch(fNameInput.Text, @"^[a-zA-Z]+$"))
            {

                e.Cancel = true;
                errorProvider1.SetError(fNameInput, "The name must contain only letters!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(fNameInput, null);
            }
        }

        private void lNameInput_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(lNameInput.Text) || lNameInput.Text.Length < 2)
            {
                e.Cancel = true;
                errorProvider1.SetError(lNameInput, "Enter a valid first name!");

            }
            else if (!Regex.IsMatch(lNameInput.Text, @"^[a-zA-Z]+$"))
            {

                e.Cancel = true;
                errorProvider1.SetError(lNameInput, "The name must contain only letters!");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lNameInput, null);
            }
        }

        private void ageInput_Validating(object sender, CancelEventArgs e)
        {
            if (ageInput.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(ageInput, "Enter the age!");
            }
            else if (!(int.TryParse(ageInput.Text, out int val)))
            {
                e.Cancel = true;
                errorProvider1.SetError(ageInput, "The age must not contain letters!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ageInput, null);
            }
        }

        private void experienceInput_Validating(object sender, CancelEventArgs e)
        {
            if (experienceInput.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(experienceInput, "Enter the experience!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(experienceInput, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (Waiter m in waiters)
                {
                    sw.WriteLine(m.ToString());
                }

                sw.Close();
            }

        }

        private void importCVBtn_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void clock_Click(object sender, EventArgs e)
        {
            //time.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
