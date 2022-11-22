namespace CourseProject
{
    partial class SearchDataForm
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
            this.byNumberButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.byTypeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.byDestButton = new System.Windows.Forms.Button();
            this.depDataText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.byDepDataButton = new System.Windows.Forms.Button();
            this.depTimeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.byDepTimeButton = new System.Windows.Forms.Button();
            this.arrTimeText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.byArrTimeButton = new System.Windows.Forms.Button();
            this.costText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.byCostButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.byNumLeftButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.byNumSoldButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.numLeftNum = new System.Windows.Forms.NumericUpDown();
            this.numSoldNum = new System.Windows.Forms.NumericUpDown();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.destComboBox2 = new System.Windows.Forms.ComboBox();
            this.sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoldNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Data";
            // 
            // byNumberButton
            // 
            this.byNumberButton.Location = new System.Drawing.Point(16, 240);
            this.byNumberButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byNumberButton.Name = "byNumberButton";
            this.byNumberButton.Size = new System.Drawing.Size(169, 78);
            this.byNumberButton.TabIndex = 1;
            this.byNumberButton.Text = "Search by number";
            this.byNumberButton.UseVisualStyleBackColor = true;
            this.byNumberButton.Click += new System.EventHandler(this.byNumberButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number";
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(16, 192);
            this.numberText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberText.Name = "numberText";
            this.numberText.PlaceholderText = "XXXX";
            this.numberText.Size = new System.Drawing.Size(167, 31);
            this.numberText.TabIndex = 3;
            this.numberText.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // byTypeButton
            // 
            this.byTypeButton.Location = new System.Drawing.Point(16, 412);
            this.byTypeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byTypeButton.Name = "byTypeButton";
            this.byTypeButton.Size = new System.Drawing.Size(169, 78);
            this.byTypeButton.TabIndex = 4;
            this.byTypeButton.Text = "Search by type";
            this.byTypeButton.UseVisualStyleBackColor = true;
            this.byTypeButton.Click += new System.EventHandler(this.byTypeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 512);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Destination";
            // 
            // byDestButton
            // 
            this.byDestButton.Location = new System.Drawing.Point(16, 590);
            this.byDestButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byDestButton.Name = "byDestButton";
            this.byDestButton.Size = new System.Drawing.Size(170, 78);
            this.byDestButton.TabIndex = 7;
            this.byDestButton.Text = "Search by destination";
            this.byDestButton.UseVisualStyleBackColor = true;
            this.byDestButton.Click += new System.EventHandler(this.byDestButton_Click);
            // 
            // depDataText
            // 
            this.depDataText.Location = new System.Drawing.Point(223, 192);
            this.depDataText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depDataText.Name = "depDataText";
            this.depDataText.PlaceholderText = "MM/DD/YY";
            this.depDataText.Size = new System.Drawing.Size(167, 31);
            this.depDataText.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Departure Date";
            // 
            // byDepDataButton
            // 
            this.byDepDataButton.Location = new System.Drawing.Point(223, 240);
            this.byDepDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byDepDataButton.Name = "byDepDataButton";
            this.byDepDataButton.Size = new System.Drawing.Size(169, 78);
            this.byDepDataButton.TabIndex = 10;
            this.byDepDataButton.Text = "Search by departure date";
            this.byDepDataButton.UseVisualStyleBackColor = true;
            this.byDepDataButton.Click += new System.EventHandler(this.byDepDataButton_Click);
            // 
            // depTimeText
            // 
            this.depTimeText.Location = new System.Drawing.Point(223, 363);
            this.depTimeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depTimeText.Name = "depTimeText";
            this.depTimeText.PlaceholderText = "HH:MM";
            this.depTimeText.Size = new System.Drawing.Size(167, 31);
            this.depTimeText.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departure Time";
            // 
            // byDepTimeButton
            // 
            this.byDepTimeButton.Location = new System.Drawing.Point(223, 412);
            this.byDepTimeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byDepTimeButton.Name = "byDepTimeButton";
            this.byDepTimeButton.Size = new System.Drawing.Size(169, 78);
            this.byDepTimeButton.TabIndex = 13;
            this.byDepTimeButton.Text = "Search by departure time";
            this.byDepTimeButton.UseVisualStyleBackColor = true;
            this.byDepTimeButton.Click += new System.EventHandler(this.byDepTimeButton_Click);
            // 
            // arrTimeText
            // 
            this.arrTimeText.Location = new System.Drawing.Point(223, 542);
            this.arrTimeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.arrTimeText.Name = "arrTimeText";
            this.arrTimeText.PlaceholderText = "HH:MM";
            this.arrTimeText.Size = new System.Drawing.Size(167, 31);
            this.arrTimeText.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 512);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Arrival Time";
            // 
            // byArrTimeButton
            // 
            this.byArrTimeButton.Location = new System.Drawing.Point(223, 590);
            this.byArrTimeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byArrTimeButton.Name = "byArrTimeButton";
            this.byArrTimeButton.Size = new System.Drawing.Size(169, 78);
            this.byArrTimeButton.TabIndex = 16;
            this.byArrTimeButton.Text = "Search by arrival time";
            this.byArrTimeButton.UseVisualStyleBackColor = true;
            this.byArrTimeButton.Click += new System.EventHandler(this.byArrTimeButton_Click);
            // 
            // costText
            // 
            this.costText.Location = new System.Drawing.Point(431, 192);
            this.costText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.costText.Name = "costText";
            this.costText.PlaceholderText = "X.X";
            this.costText.Size = new System.Drawing.Size(167, 31);
            this.costText.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cost";
            // 
            // byCostButton
            // 
            this.byCostButton.Location = new System.Drawing.Point(431, 240);
            this.byCostButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byCostButton.Name = "byCostButton";
            this.byCostButton.Size = new System.Drawing.Size(169, 78);
            this.byCostButton.TabIndex = 19;
            this.byCostButton.Text = "Search by cos";
            this.byCostButton.UseVisualStyleBackColor = true;
            this.byCostButton.Click += new System.EventHandler(this.byCostButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(431, 333);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Number Left";
            // 
            // byNumLeftButton
            // 
            this.byNumLeftButton.Location = new System.Drawing.Point(431, 412);
            this.byNumLeftButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byNumLeftButton.Name = "byNumLeftButton";
            this.byNumLeftButton.Size = new System.Drawing.Size(169, 78);
            this.byNumLeftButton.TabIndex = 22;
            this.byNumLeftButton.Text = "Search by number of left tickets";
            this.byNumLeftButton.UseVisualStyleBackColor = true;
            this.byNumLeftButton.Click += new System.EventHandler(this.byNumLeftButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 512);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Number Sold";
            // 
            // byNumSoldButton
            // 
            this.byNumSoldButton.Location = new System.Drawing.Point(431, 590);
            this.byNumSoldButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.byNumSoldButton.Name = "byNumSoldButton";
            this.byNumSoldButton.Size = new System.Drawing.Size(169, 78);
            this.byNumSoldButton.TabIndex = 25;
            this.byNumSoldButton.Text = "Search by number of sold tickets";
            this.byNumSoldButton.UseVisualStyleBackColor = true;
            this.byNumSoldButton.Click += new System.EventHandler(this.byNumSoldButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(16, 695);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(584, 63);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // numLeftNum
            // 
            this.numLeftNum.Location = new System.Drawing.Point(431, 363);
            this.numLeftNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numLeftNum.Name = "numLeftNum";
            this.numLeftNum.Size = new System.Drawing.Size(169, 31);
            this.numLeftNum.TabIndex = 29;
            // 
            // numSoldNum
            // 
            this.numSoldNum.Location = new System.Drawing.Point(431, 542);
            this.numSoldNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numSoldNum.Name = "numSoldNum";
            this.numSoldNum.Size = new System.Drawing.Size(169, 31);
            this.numSoldNum.TabIndex = 30;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.typeComboBox.Location = new System.Drawing.Point(17, 363);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(165, 33);
            this.typeComboBox.TabIndex = 31;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // destComboBox2
            // 
            this.destComboBox2.FormattingEnabled = true;
            this.destComboBox2.Items.AddRange(new object[] {
            "Brest",
            "Grodno",
            "Gomel",
            "Minsk",
            "Mogilev",
            "Vitebsk"});
            this.destComboBox2.Location = new System.Drawing.Point(17, 540);
            this.destComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destComboBox2.Name = "destComboBox2";
            this.destComboBox2.Size = new System.Drawing.Size(165, 33);
            this.destComboBox2.TabIndex = 32;
            // 
            // sqliteCommand1
            // 
            this.sqliteCommand1.CommandTimeout = 30;
            this.sqliteCommand1.Connection = null;
            this.sqliteCommand1.Transaction = null;
            this.sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // SearchDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 773);
            this.Controls.Add(this.destComboBox2);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.numSoldNum);
            this.Controls.Add(this.numLeftNum);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.byNumSoldButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.byNumLeftButton);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.byCostButton);
            this.Controls.Add(this.arrTimeText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.byArrTimeButton);
            this.Controls.Add(this.depTimeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.byDepTimeButton);
            this.Controls.Add(this.depDataText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.byDepDataButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.byDestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.byTypeButton);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.byNumberButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchDataForm";
            this.Text = "SearchDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.numLeftNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoldNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button byNumberButton;
        private Label label2;
        private TextBox numberText;
        private Label label3;
        private Button byTypeButton;
        private Label label4;
        private Button byDestButton;
        private TextBox depDataText;
        private Label label6;
        private Button byDepDataButton;
        private TextBox depTimeText;
        private Label label5;
        private Button byDepTimeButton;
        private TextBox arrTimeText;
        private Label label7;
        private Button byArrTimeButton;
        private TextBox costText;
        private Label label8;
        private Button byCostButton;
        private Label label9;
        private Button byNumLeftButton;
        private Label label10;
        private Button byNumSoldButton;
        private Button backButton;
        private NumericUpDown numLeftNum;
        private NumericUpDown numSoldNum;
        private ComboBox typeComboBox;
        private ComboBox destComboBox2;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    }
}