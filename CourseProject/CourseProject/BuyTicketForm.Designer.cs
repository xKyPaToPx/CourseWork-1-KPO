namespace CourseProject
{
    partial class BuyTicketForm
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
            this.buyButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numTickUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTickUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // buyButton
            // 
            this.buyButton.Location = new System.Drawing.Point(12, 267);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(294, 57);
            this.buyButton.TabIndex = 0;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 330);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(294, 57);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(12, 137);
            this.numberText.Name = "numberText";
            this.numberText.PlaceholderText = "XXXX";
            this.numberText.Size = new System.Drawing.Size(294, 31);
            this.numberText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of bus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 70);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buy a Ticket";
            // 
            // numTickUpDown
            // 
            this.numTickUpDown.Location = new System.Drawing.Point(12, 216);
            this.numTickUpDown.Name = "numTickUpDown";
            this.numTickUpDown.Size = new System.Drawing.Size(292, 31);
            this.numTickUpDown.TabIndex = 5;
            this.numTickUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of ticket";
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTickUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.buyButton);
            this.Name = "BuyTicketForm";
            this.Text = "BuyTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.numTickUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buyButton;
        private Button backButton;
        private TextBox numberText;
        private Label label1;
        private Label label2;
        private NumericUpDown numTickUpDown;
        private Label label3;
    }
}