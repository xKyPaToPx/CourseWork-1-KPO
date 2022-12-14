namespace CourseProject
{
    partial class AddNewForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nickname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // nicknameText
            // 
            this.nicknameText.Location = new System.Drawing.Point(174, 152);
            this.nicknameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.Size = new System.Drawing.Size(190, 31);
            this.nicknameText.TabIndex = 4;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(174, 243);
            this.passwordText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(190, 31);
            this.passwordText.TabIndex = 5;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(174, 408);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(191, 50);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create New User";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // roleBox
            // 
            this.roleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Standart",
            "Admin"});
            this.roleBox.Location = new System.Drawing.Point(174, 333);
            this.roleBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(190, 33);
            this.roleBox.TabIndex = 8;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(174, 468);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(196, 50);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // AddNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 555);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.nicknameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddNewForm";
            this.Text = "AddNewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nicknameText;
        private TextBox passwordText;
        private Button createButton;
        private ComboBox roleBox;
        private Button backButton;
    }
}