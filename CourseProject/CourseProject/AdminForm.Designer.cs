namespace CourseProject
{
    partial class AdminForm
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
            this.addNewButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showDBButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addNewBus = new System.Windows.Forms.Button();
            this.updateBusButton = new System.Windows.Forms.Button();
            this.removeBusButton = new System.Windows.Forms.Button();
            this.showBusButton = new System.Windows.Forms.Button();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewButton
            // 
            this.addNewButton.Location = new System.Drawing.Point(55, 164);
            this.addNewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(246, 83);
            this.addNewButton.TabIndex = 0;
            this.addNewButton.Text = "Add New User";
            this.addNewButton.UseVisualStyleBackColor = true;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(56, 257);
            this.updateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(246, 75);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update User";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(56, 342);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(244, 75);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Remove User";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Menu";
            // 
            // showDBButton
            // 
            this.showDBButton.Location = new System.Drawing.Point(56, 427);
            this.showDBButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showDBButton.Name = "showDBButton";
            this.showDBButton.Size = new System.Drawing.Size(246, 75);
            this.showDBButton.TabIndex = 5;
            this.showDBButton.Text = "Show All Users";
            this.showDBButton.UseVisualStyleBackColor = true;
            this.showDBButton.Click += new System.EventHandler(this.showDBButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(621, 427);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(255, 75);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addNewBus
            // 
            this.addNewBus.Location = new System.Drawing.Point(338, 164);
            this.addNewBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNewBus.Name = "addNewBus";
            this.addNewBus.Size = new System.Drawing.Size(246, 83);
            this.addNewBus.TabIndex = 7;
            this.addNewBus.Text = "Add New Bus";
            this.addNewBus.UseVisualStyleBackColor = true;
            this.addNewBus.Click += new System.EventHandler(this.addNewBus_Click);
            // 
            // updateBusButton
            // 
            this.updateBusButton.Location = new System.Drawing.Point(338, 257);
            this.updateBusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateBusButton.Name = "updateBusButton";
            this.updateBusButton.Size = new System.Drawing.Size(246, 75);
            this.updateBusButton.TabIndex = 8;
            this.updateBusButton.Text = "Update Bus";
            this.updateBusButton.UseVisualStyleBackColor = true;
            this.updateBusButton.Click += new System.EventHandler(this.updateBusButton_Click);
            // 
            // removeBusButton
            // 
            this.removeBusButton.Location = new System.Drawing.Point(338, 342);
            this.removeBusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeBusButton.Name = "removeBusButton";
            this.removeBusButton.Size = new System.Drawing.Size(246, 75);
            this.removeBusButton.TabIndex = 9;
            this.removeBusButton.Text = "Remove Bus";
            this.removeBusButton.UseVisualStyleBackColor = true;
            this.removeBusButton.Click += new System.EventHandler(this.removeBusButton_Click);
            // 
            // showBusButton
            // 
            this.showBusButton.Location = new System.Drawing.Point(338, 427);
            this.showBusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showBusButton.Name = "showBusButton";
            this.showBusButton.Size = new System.Drawing.Size(246, 75);
            this.showBusButton.TabIndex = 10;
            this.showBusButton.Text = "Show All Buses";
            this.showBusButton.UseVisualStyleBackColor = true;
            this.showBusButton.Click += new System.EventHandler(this.showBusButton_Click);
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(621, 257);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(255, 75);
            this.searchDataButton.TabIndex = 12;
            this.searchDataButton.Text = "Search Data";
            this.searchDataButton.UseVisualStyleBackColor = true;
            this.searchDataButton.Click += new System.EventHandler(this.searchDataButton_Click);
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.Location = new System.Drawing.Point(621, 164);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(255, 83);
            this.buyTicketButton.TabIndex = 11;
            this.buyTicketButton.Text = "Buy a Ticket";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 524);
            this.Controls.Add(this.searchDataButton);
            this.Controls.Add(this.buyTicketButton);
            this.Controls.Add(this.showBusButton);
            this.Controls.Add(this.removeBusButton);
            this.Controls.Add(this.updateBusButton);
            this.Controls.Add(this.addNewBus);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showDBButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addNewButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addNewButton;
        private Button updateButton;
        private Button removeButton;
        private Label label1;
        private Button showDBButton;
        private Button exitButton;
        private Button addNewBus;
        private Button updateBusButton;
        private Button removeBusButton;
        private Button showBusButton;
        private Button searchDataButton;
        private Button buyTicketButton;
    }
}