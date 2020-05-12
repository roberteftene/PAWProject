using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAWProj
{
    public partial class reservationForm : Form
    {
        List<Reservation> reservations = new List<Reservation>();

        public reservationForm()
        {
            InitializeComponent();
        }

        private void reservationForm_Load(object sender, EventArgs e)
        {
            this.reservationContainer.Hide();
            this.listView1.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitReservationBtn_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(o[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValid = regex.IsMatch(reservDateInput.Text.Trim());
            DateTime dt;
            isValid = DateTime.TryParseExact(reservDateInput.Text,"dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
           

            dt.ToString();

            bool isOK = true;
            if(!isValid)
            {
                errorProviderReservation.SetError(reservDateInput,"Please enter the correct date");
                isOK = false;
            }

            if(reservTimeInput.Text == "")
            {
                errorProviderReservation.SetError(reservTimeInput, "Please enter a time for reservation");
                isOK = false;
            }

            int val;
            if(!(int.TryParse(noPersonInput.Text, out val))) {
                errorProviderReservation.SetError(noPersonInput, "Please enter a number of persons");
                isOK = false;
            }
            if (isOK)
            {
                try
                {
                    string date = reservDateInput.Text;
                    string time = reservTimeInput.Text;
                    int noPers = Convert.ToInt32(noPersonInput.Text);

                    Reservation r = new Reservation(date, time, noPers);
                    reservations.Add(r);
                    ListViewItem itm = new ListViewItem(r.ReservationDate);
                    itm.SubItems.Add(r.ReservationTime);
                    itm.SubItems.Add(r.NoPerson.ToString());
                    listView1.Items.Add(itm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    reservDateInput.Text = "";
                    reservTimeInput.Text = "";
                    noPersonInput.Text = "";
                }
            }
        }

        private void reservationContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.listView1.Hide();
            this.reservationContainer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.reservationContainer.Hide();
            this.listView1.Show();
        }
    }
}
