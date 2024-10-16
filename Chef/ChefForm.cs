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
    public partial class ChefForm : Form
    {
        private Order[] orders;

        public ChefForm(Order[] orders)
        {
            InitializeComponent();
            this.orders = orders ?? throw new ArgumentNullException(nameof(orders)); // Check for null
            PopulateOrders();
        }

        private void PopulateOrders()
        {

            if (orders != null)
            {
                foreach (var order in orders)
                {
                    if (order != null) // Ensure the order is not null
                    {
                        orderListBox2.Items.Add(order);
                    }
                }
            }
            else
            {
                MessageBox.Show("No orders to display."); // Handle the null case
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            while (orderListBox2.SelectedItems.Count > 0)
            {
                // Get the selected item
                var selectedItem = orderListBox2.SelectedItems[0];

                // Remove it from the first ListBox
                orderListBox2.Items.Remove(selectedItem);

                // Add it to the second ListBox
                DoneOrders.Items.Add(selectedItem);
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            while (DoneOrders.SelectedItems.Count > 0)
            {
                //Get selected item
                var selectedItem = DoneOrders.SelectedItems[0];
                //remove from done box
                DoneOrders.Items.Remove(selectedItem);
                //add it to the first box
                orderListBox2.Items.Add(selectedItem);
            }
        }

        private void Cashier_Click(object sender, EventArgs e)
        {
            CashierForm cashierForm = new CashierForm();
            cashierForm.Show();
            this.Hide();
        }

        private void Server_Click(object sender, EventArgs e)
        {
            ServerForm serverForm = new ServerForm();
            serverForm.Show();
            this.Hide();
        }
    }
}
