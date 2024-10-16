using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_System
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderlist.Items.Add("Lasagna");
        }

        private void Pizza_Click(object sender, EventArgs e)
        {
            // Toggle visibility of the pizza options
            bool isVisible = Pepperoni.Visible;

            // Show/hide pizza buttons based on current state
            Pepperoni.Visible = !isVisible;
            Cheese.Visible = !isVisible;

        }

        private void Chef_Click(object sender, EventArgs e)
        {
            //Sends you to chef screen


            Order[] orders = new Order[0];
            ChefForm chefForm = new ChefForm(orders);
            chefForm.Show();
            this.Hide();
        }

        private void Pepperoni_Click(object sender, EventArgs e)
        {
            orderlist.Items.Add("Pepperoni");
        }

        private void Cheese_Click(object sender, EventArgs e)
        {
            orderlist.Items.Add("Cheese");
        }

        private void Clearorder_Click(object sender, EventArgs e)
        {
            orderlist.Items.Clear();
        }

        private void SendOrder_Click(object sender, EventArgs e)
        {
            List<Order> orderssend = new List<Order>();
            foreach (var item in orderlist.Items)
            {
                string itemName = item.ToString();
                orderssend.Add(new Order { ItemName = itemName, Quantity = 1 });
            }
            if (orderssend.Count == 0)
            {
                MessageBox.Show("no orders to send,");
            }
            ChefForm chefForm = new ChefForm(orderssend.ToArray());
            chefForm.Show();
            orderlist.Items.Clear();
        }

        private void Pasta_Click(object sender, EventArgs e)
        {
            orderlist.Items.Add("pasta");
        }
    }
}
