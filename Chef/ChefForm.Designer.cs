namespace Restaurant_System
{
    partial class ChefForm
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
            label1 = new Label();
            currentorders = new Label();
            orderListBox = new ListBox();
            orderListBox2 = new ListBox();
            DoneOrders = new ListBox();
            Done = new Button();
            Undo = new Button();
            label2 = new Label();
            Cashier = new Button();
            Server = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // currentorders
            // 
            currentorders.AutoSize = true;
            currentorders.Location = new Point(12, 9);
            currentorders.Name = "currentorders";
            currentorders.Size = new Size(85, 15);
            currentorders.TabIndex = 1;
            currentorders.Text = "Current Orders";
            // 
            // orderListBox
            // 
            orderListBox.FormattingEnabled = true;
            orderListBox.Location = new Point(12, 9);
            orderListBox.Name = "orderListBox";
            orderListBox.Size = new Size(100, 100);
            orderListBox.TabIndex = 0;
            // 
            // orderListBox2
            // 
            orderListBox2.FormattingEnabled = true;
            orderListBox2.ItemHeight = 15;
            orderListBox2.Location = new Point(12, 37);
            orderListBox2.Name = "orderListBox2";
            orderListBox2.Size = new Size(189, 394);
            orderListBox2.TabIndex = 2;
            // 
            // DoneOrders
            // 
            DoneOrders.FormattingEnabled = true;
            DoneOrders.ItemHeight = 15;
            DoneOrders.Location = new Point(290, 37);
            DoneOrders.Name = "DoneOrders";
            DoneOrders.Size = new Size(180, 394);
            DoneOrders.TabIndex = 3;
            // 
            // Done
            // 
            Done.Location = new Point(207, 85);
            Done.Name = "Done";
            Done.Size = new Size(75, 23);
            Done.TabIndex = 4;
            Done.Text = "=====>";
            Done.UseVisualStyleBackColor = true;
            Done.Click += Done_Click;
            // 
            // Undo
            // 
            Undo.Location = new Point(209, 131);
            Undo.Name = "Undo";
            Undo.Size = new Size(75, 23);
            Undo.TabIndex = 5;
            Undo.Text = "<=====";
            Undo.UseVisualStyleBackColor = true;
            Undo.Click += Undo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 9);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 6;
            label2.Text = "Completed Orders";
            // 
            // Cashier
            // 
            Cashier.Location = new Point(623, 5);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(75, 23);
            Cashier.TabIndex = 7;
            Cashier.Text = "Cashier";
            Cashier.UseVisualStyleBackColor = true;
            Cashier.Click += Cashier_Click;
            // 
            // Server
            // 
            Server.Location = new Point(713, 5);
            Server.Name = "Server";
            Server.Size = new Size(75, 23);
            Server.TabIndex = 8;
            Server.Text = "Server";
            Server.UseVisualStyleBackColor = true;
            Server.Click += Server_Click;
            // 
            // ChefForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Server);
            Controls.Add(Cashier);
            Controls.Add(label2);
            Controls.Add(Undo);
            Controls.Add(Done);
            Controls.Add(DoneOrders);
            Controls.Add(orderListBox2);
            Controls.Add(currentorders);
            Controls.Add(label1);
            Name = "ChefForm";
            Text = "ChefForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label currentorders;
        private ListBox orderListBox;
        private ListBox orderListBox2;
        private ListBox DoneOrders;
        private Button Done;
        private Button Undo;
        private Label label2;
        private Button Cashier;
        private Button Server;
    }
}