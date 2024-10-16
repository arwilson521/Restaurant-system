namespace Restaurant_System
{
    partial class ServerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Pizza = new Button();
            Pasta = new Button();
            Lasagna = new Button();
            Chef = new Button();
            Cashier = new Button();
            Pepperoni = new Button();
            Cheese = new Button();
            orderlist = new ListBox();
            label1 = new Label();
            Clearorder = new Button();
            SendOrder = new Button();
            SuspendLayout();
            // 
            // Pizza
            // 
            Pizza.Location = new Point(12, 55);
            Pizza.Name = "Pizza";
            Pizza.Size = new Size(75, 23);
            Pizza.TabIndex = 0;
            Pizza.Text = "Pizza";
            Pizza.UseVisualStyleBackColor = true;
            Pizza.Click += Pizza_Click;
            // 
            // Pasta
            // 
            Pasta.Location = new Point(109, 55);
            Pasta.Name = "Pasta";
            Pasta.Size = new Size(75, 23);
            Pasta.TabIndex = 1;
            Pasta.Text = "Pasta";
            Pasta.UseVisualStyleBackColor = true;
            Pasta.Click += Pasta_Click;
            // 
            // Lasagna
            // 
            Lasagna.Location = new Point(204, 55);
            Lasagna.Name = "Lasagna";
            Lasagna.Size = new Size(75, 23);
            Lasagna.TabIndex = 2;
            Lasagna.Text = "Lasagna";
            Lasagna.UseVisualStyleBackColor = true;
            Lasagna.Click += button1_Click;
            // 
            // Chef
            // 
            Chef.Location = new Point(713, 12);
            Chef.Name = "Chef";
            Chef.Size = new Size(75, 23);
            Chef.TabIndex = 3;
            Chef.Text = "Chef";
            Chef.UseVisualStyleBackColor = true;
            Chef.Click += Chef_Click;
            // 
            // Cashier
            // 
            Cashier.Location = new Point(632, 12);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(75, 23);
            Cashier.TabIndex = 4;
            Cashier.Text = "Cashier";
            Cashier.UseVisualStyleBackColor = true;
            // 
            // Pepperoni
            // 
            Pepperoni.Location = new Point(12, 105);
            Pepperoni.Name = "Pepperoni";
            Pepperoni.Size = new Size(75, 23);
            Pepperoni.TabIndex = 5;
            Pepperoni.Text = "Pepperoni";
            Pepperoni.UseVisualStyleBackColor = true;
            Pepperoni.Visible = false;
            Pepperoni.Click += Pepperoni_Click;
            // 
            // Cheese
            // 
            Cheese.Location = new Point(12, 152);
            Cheese.Name = "Cheese";
            Cheese.Size = new Size(75, 23);
            Cheese.TabIndex = 6;
            Cheese.Text = "Cheese";
            Cheese.UseVisualStyleBackColor = true;
            Cheese.Visible = false;
            Cheese.Click += Cheese_Click;
            // 
            // orderlist
            // 
            orderlist.FormattingEnabled = true;
            orderlist.ItemHeight = 15;
            orderlist.Location = new Point(343, 81);
            orderlist.Name = "orderlist";
            orderlist.Size = new Size(120, 94);
            orderlist.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 63);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 8;
            label1.Text = "Current Order";
            // 
            // Clearorder
            // 
            Clearorder.Location = new Point(360, 181);
            Clearorder.Name = "Clearorder";
            Clearorder.Size = new Size(75, 23);
            Clearorder.TabIndex = 10;
            Clearorder.Text = "Clear Order";
            Clearorder.UseVisualStyleBackColor = true;
            Clearorder.Click += Clearorder_Click;
            // 
            // SendOrder
            // 
            SendOrder.Location = new Point(488, 105);
            SendOrder.Name = "SendOrder";
            SendOrder.Size = new Size(75, 23);
            SendOrder.TabIndex = 11;
            SendOrder.Text = "Send Order";
            SendOrder.UseVisualStyleBackColor = true;
            SendOrder.Click += SendOrder_Click;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SendOrder);
            Controls.Add(Clearorder);
            Controls.Add(label1);
            Controls.Add(orderlist);
            Controls.Add(Cheese);
            Controls.Add(Pepperoni);
            Controls.Add(Cashier);
            Controls.Add(Chef);
            Controls.Add(Lasagna);
            Controls.Add(Pasta);
            Controls.Add(Pizza);
            Name = "ServerForm";
            Text = "ServerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Pizza;
        private Button Pasta;
        private Button Lasagna;
        private Button Chef;
        private Button Cashier;
        private Button Pepperoni;
        private Button Cheese;
        private ListBox orderlist;
        private Label label1;
        private Button Clearorder;
        private Button SendOrder;
    }
}