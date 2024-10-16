namespace Restaurant_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Chef = new Button();
            WaitStaff = new Button();
            Cashier = new Button();
            Roletext = new Label();
            SuspendLayout();
            // 
            // Chef
            // 
            Chef.Location = new Point(551, 0);
            Chef.Name = "Chef";
            Chef.Size = new Size(75, 23);
            Chef.TabIndex = 0;
            Chef.Text = "Chef";
            Chef.UseVisualStyleBackColor = true;
            Chef.Click += Chef_Click_1;
            // 
            // WaitStaff
            // 
            WaitStaff.Location = new Point(632, 0);
            WaitStaff.Name = "WaitStaff";
            WaitStaff.Size = new Size(75, 23);
            WaitStaff.TabIndex = 1;
            WaitStaff.Text = "WaitStaff";
            WaitStaff.UseVisualStyleBackColor = true;
            WaitStaff.Click += WaitStaff_Click;
            // 
            // Cashier
            // 
            Cashier.Location = new Point(713, 0);
            Cashier.Name = "Cashier";
            Cashier.Size = new Size(75, 23);
            Cashier.TabIndex = 2;
            Cashier.Text = "Cashier";
            Cashier.UseVisualStyleBackColor = true;
            Cashier.Click += Cashier_Click;
            // 
            // Roletext
            // 
            Roletext.AutoSize = true;
            Roletext.Location = new Point(258, 9);
            Roletext.Name = "Roletext";
            Roletext.Size = new Size(165, 15);
            Roletext.TabIndex = 3;
            Roletext.Text = "Pick a role from the right side.";
            Roletext.Click += Roletext_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Roletext);
            Controls.Add(Cashier);
            Controls.Add(WaitStaff);
            Controls.Add(Chef);
            Name = "Form1";
            Text = "Main page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Chef;
        private Button WaitStaff;

        private Button Cashier;
        private Label Roletext;
    }
}