namespace CourseProject
{
    partial class SearchShowGridForm
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
            this.busesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arr_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.busesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // busesGrid
            // 
            this.busesGrid.AllowUserToAddRows = false;
            this.busesGrid.AllowUserToDeleteRows = false;
            this.busesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.type,
            this.dest,
            this.dep_date,
            this.dep_time,
            this.arr_time,
            this.cost,
            this.num_left,
            this.num_sold});
            this.busesGrid.Location = new System.Drawing.Point(12, 12);
            this.busesGrid.Name = "busesGrid";
            this.busesGrid.ReadOnly = true;
            this.busesGrid.RowHeadersWidth = 62;
            this.busesGrid.RowTemplate.Height = 33;
            this.busesGrid.Size = new System.Drawing.Size(1418, 503);
            this.busesGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Number";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 150;
            // 
            // dest
            // 
            this.dest.HeaderText = "Destination";
            this.dest.MinimumWidth = 8;
            this.dest.Name = "dest";
            this.dest.ReadOnly = true;
            this.dest.Width = 150;
            // 
            // dep_date
            // 
            this.dep_date.HeaderText = "Departure Date";
            this.dep_date.MinimumWidth = 8;
            this.dep_date.Name = "dep_date";
            this.dep_date.ReadOnly = true;
            this.dep_date.Width = 150;
            // 
            // dep_time
            // 
            this.dep_time.HeaderText = "Departure Time";
            this.dep_time.MinimumWidth = 8;
            this.dep_time.Name = "dep_time";
            this.dep_time.ReadOnly = true;
            this.dep_time.Width = 150;
            // 
            // arr_time
            // 
            this.arr_time.HeaderText = "Arrival Time";
            this.arr_time.MinimumWidth = 8;
            this.arr_time.Name = "arr_time";
            this.arr_time.ReadOnly = true;
            this.arr_time.Width = 150;
            // 
            // cost
            // 
            this.cost.HeaderText = "Cost";
            this.cost.MinimumWidth = 8;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 150;
            // 
            // num_left
            // 
            this.num_left.HeaderText = "Num Left";
            this.num_left.MinimumWidth = 8;
            this.num_left.Name = "num_left";
            this.num_left.ReadOnly = true;
            this.num_left.Width = 150;
            // 
            // num_sold
            // 
            this.num_sold.HeaderText = "Num Sold";
            this.num_sold.MinimumWidth = 8;
            this.num_sold.Name = "num_sold";
            this.num_sold.ReadOnly = true;
            this.num_sold.Width = 150;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1318, 521);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 34);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SearchShowGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 565);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.busesGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchShowGridForm";
            this.Text = "SearchShowGridForm";
            this.Load += new System.EventHandler(this.SearchShowGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView busesGrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn dest;
        private DataGridViewTextBoxColumn dep_date;
        private DataGridViewTextBoxColumn dep_time;
        private DataGridViewTextBoxColumn arr_time;
        private DataGridViewTextBoxColumn cost;
        private DataGridViewTextBoxColumn num_left;
        private DataGridViewTextBoxColumn num_sold;
        private Button backButton;
    }
}