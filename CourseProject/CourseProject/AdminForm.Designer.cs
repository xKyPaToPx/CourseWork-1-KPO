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
            this.label1 = new System.Windows.Forms.Label();
            this.showDBButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.showBusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 71);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Menu";
            // 
            // showDBButton
            // 
            this.showDBButton.Location = new System.Drawing.Point(55, 90);
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
            this.exitButton.Location = new System.Drawing.Point(55, 282);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(246, 75);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showBusButton
            // 
            this.showBusButton.Location = new System.Drawing.Point(55, 175);
            this.showBusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showBusButton.Name = "showBusButton";
            this.showBusButton.Size = new System.Drawing.Size(246, 75);
            this.showBusButton.TabIndex = 10;
            this.showBusButton.Text = "Show All Buses";
            this.showBusButton.UseVisualStyleBackColor = true;
            this.showBusButton.Click += new System.EventHandler(this.showBusButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 369);
            this.Controls.Add(this.showBusButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showDBButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button showDBButton;
        private Button exitButton;
        private Button showBusButton;
    }
}