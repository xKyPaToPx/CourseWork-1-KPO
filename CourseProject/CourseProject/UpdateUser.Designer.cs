namespace CourseProject
{
    partial class UpdateUser
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
            this.nicknameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editNicknameButton = new System.Windows.Forms.Button();
            this.editPAsswordButton = new System.Windows.Forms.Button();
            this.editRoleButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.newNicknameText = new System.Windows.Forms.TextBox();
            this.newPasswordText = new System.Windows.Forms.TextBox();
            this.newRoleBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nicknameText
            // 
            this.nicknameText.Location = new System.Drawing.Point(149, 115);
            this.nicknameText.Name = "nicknameText";
            this.nicknameText.Size = new System.Drawing.Size(214, 31);
            this.nicknameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update User Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nickname";
            // 
            // editNicknameButton
            // 
            this.editNicknameButton.Location = new System.Drawing.Point(377, 194);
            this.editNicknameButton.Name = "editNicknameButton";
            this.editNicknameButton.Size = new System.Drawing.Size(214, 31);
            this.editNicknameButton.TabIndex = 3;
            this.editNicknameButton.Text = "Edit Nickname";
            this.editNicknameButton.UseVisualStyleBackColor = true;
            this.editNicknameButton.Click += new System.EventHandler(this.editNicknameButton_Click);
            // 
            // editPAsswordButton
            // 
            this.editPAsswordButton.Location = new System.Drawing.Point(377, 264);
            this.editPAsswordButton.Name = "editPAsswordButton";
            this.editPAsswordButton.Size = new System.Drawing.Size(214, 31);
            this.editPAsswordButton.TabIndex = 4;
            this.editPAsswordButton.Text = "Edit Password";
            this.editPAsswordButton.UseVisualStyleBackColor = true;
            this.editPAsswordButton.Click += new System.EventHandler(this.editPAsswordButton_Click);
            // 
            // editRoleButton
            // 
            this.editRoleButton.Location = new System.Drawing.Point(377, 342);
            this.editRoleButton.Name = "editRoleButton";
            this.editRoleButton.Size = new System.Drawing.Size(214, 31);
            this.editRoleButton.TabIndex = 5;
            this.editRoleButton.Text = "Edit Role";
            this.editRoleButton.UseVisualStyleBackColor = true;
            this.editRoleButton.Click += new System.EventHandler(this.editRoleButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(148, 404);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(214, 34);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // newNicknameText
            // 
            this.newNicknameText.Location = new System.Drawing.Point(149, 194);
            this.newNicknameText.Name = "newNicknameText";
            this.newNicknameText.Size = new System.Drawing.Size(214, 31);
            this.newNicknameText.TabIndex = 7;
            this.newNicknameText.TextChanged += new System.EventHandler(this.newNicknameText_TextChanged);
            // 
            // newPasswordText
            // 
            this.newPasswordText.Location = new System.Drawing.Point(149, 264);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.Size = new System.Drawing.Size(213, 31);
            this.newPasswordText.TabIndex = 8;
            // 
            // newRoleBox
            // 
            this.newRoleBox.FormattingEnabled = true;
            this.newRoleBox.Items.AddRange(new object[] {
            "Standart",
            "Admin"});
            this.newRoleBox.Location = new System.Drawing.Point(149, 340);
            this.newRoleBox.Name = "newRoleBox";
            this.newRoleBox.Size = new System.Drawing.Size(213, 33);
            this.newRoleBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "New Nickname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "New Role";
            // 
            // UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newRoleBox);
            this.Controls.Add(this.newPasswordText);
            this.Controls.Add(this.newNicknameText);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editRoleButton);
            this.Controls.Add(this.editPAsswordButton);
            this.Controls.Add(this.editNicknameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nicknameText);
            this.Name = "UpdateUser";
            this.Text = "UpdateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nicknameText;
        private Label label1;
        private Label label2;
        private Button editNicknameButton;
        private Button editPAsswordButton;
        private Button editRoleButton;
        private Button backButton;
        private TextBox newNicknameText;
        private TextBox newPasswordText;
        private ComboBox newRoleBox;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}