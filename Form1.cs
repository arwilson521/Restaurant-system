using Restaurant_System;

namespace Restaurant_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Roletext.Text = "Pick a role from the right side.";
        }


        private void Chef_Click(object sender, EventArgs e)
        {
            //useless chef-click function
        }

        private void Roletext_Click(object sender, EventArgs e)
        {

        }

        private void Chef_Click_1(object sender, EventArgs e)
        {
            try
            {
                Order[] orders = new Order[]
                {
                    new Order { ItemName = "Test Order Pizza", Quantity = 2 },
                    new Order { ItemName = "Test Order Pasta", Quantity = 1 }
                };

                if (orders.Length == 0) // Check if the orders array is empty
                {
                    MessageBox.Show("No orders to display.");
                    return;
                }

                ChefForm chefForm = new ChefForm(orders);
                chefForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in chef_click1: {ex.Message}");
            }
        }

        private void WaitStaff_Click(object sender, EventArgs e)
        {
            try
            {

                Roletext.Text = "Hello Waiter/Waitress";
                ServerForm serverForm = new ServerForm();
                serverForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Handle the exception and show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cashier_Click(object sender, EventArgs e)
        {
            try
            {

                Roletext.Text = "Hello Cashier";
            }
            catch (Exception ex)
            {
                // Handle the exception and show an error message
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}