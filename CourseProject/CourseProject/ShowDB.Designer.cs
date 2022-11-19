namespace CourseProject
{
    partial class ShowDB
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
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.NicknameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DBGrid
            // 
            this.DBGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NicknameCol,
            this.PasswordCol,
            this.RoleCol});
            this.DBGrid.Location = new System.Drawing.Point(12, 12);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.RowHeadersWidth = 62;
            this.DBGrid.RowTemplate.Height = 33;
            this.DBGrid.Size = new System.Drawing.Size(515, 426);
            this.DBGrid.TabIndex = 0;
            this.DBGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid_CellContentClick);
            // 
            // NicknameCol
            // 
            this.NicknameCol.HeaderText = "Nickname";
            this.NicknameCol.MinimumWidth = 8;
            this.NicknameCol.Name = "NicknameCol";
            this.NicknameCol.ReadOnly = true;
            this.NicknameCol.Width = 150;
            // 
            // PasswordCol
            // 
            this.PasswordCol.HeaderText = "Password";
            this.PasswordCol.MinimumWidth = 8;
            this.PasswordCol.Name = "PasswordCol";
            this.PasswordCol.ReadOnly = true;
            this.PasswordCol.Width = 150;
            // 
            // RoleCol
            // 
            this.RoleCol.HeaderText = "Role";
            this.RoleCol.MinimumWidth = 8;
            this.RoleCol.Name = "RoleCol";
            this.RoleCol.ReadOnly = true;
            this.RoleCol.Width = 150;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(537, 360);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(251, 78);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ShowDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.DBGrid);
            this.Name = "ShowDB";
            this.Text = "ShowDB";
            this.Load += new System.EventHandler(this.ShowDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DBGrid;
        private DataGridViewTextBoxColumn NicknameCol;
        private DataGridViewTextBoxColumn PasswordCol;
        private DataGridViewTextBoxColumn RoleCol;
        private Button backButton;
    }
}