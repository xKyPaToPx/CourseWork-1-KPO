namespace CourseProject
{
    partial class ShowBusesForm
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
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arr_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_sold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backButton = new System.Windows.Forms.Button();
            this.searchDataButton = new System.Windows.Forms.Button();
            this.buyTicketButton = new System.Windows.Forms.Button();
            this.removeBusButton = new System.Windows.Forms.Button();
            this.updateBusButton = new System.Windows.Forms.Button();
            this.addNewBus = new System.Windows.Forms.Button();
            this.updateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.busesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // busesGrid
            // 
            this.busesGrid.AllowUserToAddRows = false;
            this.busesGrid.AllowUserToDeleteRows = false;
            this.busesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number,
            this.type,
            this.dest,
            this.dep_date,
            this.dep_time,
            this.arr_time,
            this.cost,
            this.num_left,
            this.num_sold});
            this.busesGrid.Location = new System.Drawing.Point(13, 23);
            this.busesGrid.Name = "busesGrid";
            this.busesGrid.ReadOnly = true;
            this.busesGrid.RowHeadersWidth = 62;
            this.busesGrid.RowTemplate.Height = 33;
            this.busesGrid.Size = new System.Drawing.Size(1415, 525);
            this.busesGrid.TabIndex = 0;
            this.busesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.busesGrid_CellContentClick);
            // 
            // number
            // 
            this.number.HeaderText = "Number";
            this.number.MinimumWidth = 8;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 150;
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
            this.backButton.Location = new System.Drawing.Point(1263, 554);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(165, 83);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchDataButton
            // 
            this.searchDataButton.Location = new System.Drawing.Point(356, 554);
            this.searchDataButton.Name = "searchDataButton";
            this.searchDataButton.Size = new System.Drawing.Size(165, 83);
            this.searchDataButton.TabIndex = 17;
            this.searchDataButton.Text = "Search Data";
            this.searchDataButton.UseVisualStyleBackColor = true;
            this.searchDataButton.Click += new System.EventHandler(this.searchDataButton_Click);
            // 
            // buyTicketButton
            // 
            this.buyTicketButton.Location = new System.Drawing.Point(185, 554);
            this.buyTicketButton.Name = "buyTicketButton";
            this.buyTicketButton.Size = new System.Drawing.Size(165, 83);
            this.buyTicketButton.TabIndex = 16;
            this.buyTicketButton.Text = "Buy a Ticket";
            this.buyTicketButton.UseVisualStyleBackColor = true;
            this.buyTicketButton.Click += new System.EventHandler(this.buyTicketButton_Click);
            // 
            // removeBusButton
            // 
            this.removeBusButton.Location = new System.Drawing.Point(701, 554);
            this.removeBusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.removeBusButton.Name = "removeBusButton";
            this.removeBusButton.Size = new System.Drawing.Size(165, 83);
            this.removeBusButton.TabIndex = 15;
            this.removeBusButton.Text = "Remove Bus";
            this.removeBusButton.UseVisualStyleBackColor = true;
            this.removeBusButton.Click += new System.EventHandler(this.removeBusButton_Click);
            // 
            // updateBusButton
            // 
            this.updateBusButton.Location = new System.Drawing.Point(528, 554);
            this.updateBusButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateBusButton.Name = "updateBusButton";
            this.updateBusButton.Size = new System.Drawing.Size(165, 83);
            this.updateBusButton.TabIndex = 14;
            this.updateBusButton.Text = "Update Bus";
            this.updateBusButton.UseVisualStyleBackColor = true;
            this.updateBusButton.Click += new System.EventHandler(this.updateBusButton_Click);
            // 
            // addNewBus
            // 
            this.addNewBus.Location = new System.Drawing.Point(13, 554);
            this.addNewBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNewBus.Name = "addNewBus";
            this.addNewBus.Size = new System.Drawing.Size(165, 83);
            this.addNewBus.TabIndex = 13;
            this.addNewBus.Text = "Add New Bus";
            this.addNewBus.UseVisualStyleBackColor = true;
            this.addNewBus.Click += new System.EventHandler(this.addNewBus_Click);
            // 
            // updateGrid
            // 
            this.updateGrid.Location = new System.Drawing.Point(1092, 554);
            this.updateGrid.Name = "updateGrid";
            this.updateGrid.Size = new System.Drawing.Size(165, 83);
            this.updateGrid.TabIndex = 18;
            this.updateGrid.Text = "Update";
            this.updateGrid.UseVisualStyleBackColor = true;
            this.updateGrid.Click += new System.EventHandler(this.updateGrid_Click);
            // 
            // ShowBusesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 646);
            this.Controls.Add(this.updateGrid);
            this.Controls.Add(this.searchDataButton);
            this.Controls.Add(this.buyTicketButton);
            this.Controls.Add(this.removeBusButton);
            this.Controls.Add(this.updateBusButton);
            this.Controls.Add(this.addNewBus);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.busesGrid);
            this.Name = "ShowBusesForm";
            this.Text = "ShowBusesForm";
            this.Load += new System.EventHandler(this.ShowBusesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.busesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView busesGrid;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn dest;
        private DataGridViewTextBoxColumn dep_date;
        private DataGridViewTextBoxColumn dep_time;
        private DataGridViewTextBoxColumn arr_time;
        private DataGridViewTextBoxColumn cost;
        private DataGridViewTextBoxColumn num_left;
        private DataGridViewTextBoxColumn num_sold;
        private Button backButton;
        private Button searchDataButton;
        private Button buyTicketButton;
        private Button removeBusButton;
        private Button updateBusButton;
        private Button addNewBus;
        private Button updateGrid;
    }
}