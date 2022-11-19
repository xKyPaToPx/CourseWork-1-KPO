namespace CourseProject
{
    partial class UserForm
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
            this.showAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(48, 82);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(209, 58);
            this.showAllButton.TabIndex = 0;
            this.showAllButton.Text = "Show all buses";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Menu";
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.Location = new System.Drawing.Point(48, 146);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(209, 58);
            this.buyTicketButton.TabIndex = 2;
            this.buyTicketButton.Text = "Buy a Ticket";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(48, 210);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(209, 58);
            this.searchDataButton.TabIndex = 3;
            this.searchDataButton.Text = "Search Data";
            this.searchDataButton.UseVisualStyleBackColor = true;
            this.searchDataButton.Click += new System.EventHandler(this.searchDataButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(48, 291);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(209, 58);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 365);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchDataButton);
            this.Controls.Add(this.buyTicketButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAllButton);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showAllButton;
        private Label label1;
        private Button buyTicketButton;
        private Button searchDataButton;
        private Button exitButton;
    }
}