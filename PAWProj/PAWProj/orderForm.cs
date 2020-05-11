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
        List<Order> orders = new List<Order>();
       

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
            if(menuChoice.Text == "")
            {
                errorProvider1.SetError(menuChoice, "Please select your choice");
                //labelName.Text = "Please select your choice";
                //labelName.Enable = true;
            }
            try
            {
                string choice = menuChoice.Text;
                string drink = drinkChoice.Text;
                string add = address.Text;
                string promotional = discount.Text;

                Order o = new Order(choice, drink, add, promotional);
                orders.Add(o);

                ListViewItem itm = new ListViewItem(o.FoodName);
                itm.SubItems.Add(o.DrinkName);
                itm.SubItems.Add(o.Address);
                itm.SubItems.Add(o.Code);
                orderListView.Items.Add(itm);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                menuChoice.Text = "";
                drinkChoice.Text = "";
                address.Clear();
                discount.Clear();
            }
            

        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            orderInputP.Hide();
            orderListView.Hide();
        }

        private void msjBox1_Load(object sender, EventArgs e)
        {
            
        }

        private void seeOrder_Click(object sender, EventArgs e)
        {

            orderListView.Show();           

        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }
    }
}
