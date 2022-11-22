namespace CourseProject
{
    partial class AddNewBusForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberText = new System.Windows.Forms.TextBox();
            this.depDateText = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.destBox = new System.Windows.Forms.ComboBox();
            this.arrTimeText = new System.Windows.Forms.TextBox();
            this.costText = new System.Windows.Forms.TextBox();
            this.numLeftUpDown = new System.Windows.Forms.NumericUpDown();
            this.depTimeTExt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLeftUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(41, 404);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Bus Menu";
            // 
            // numberText
            // 
            this.numberText.Location = new System.Drawing.Point(41, 146);
            this.numberText.Name = "numberText";
            this.numberText.PlaceholderText = "XXXX";
            this.numberText.Size = new System.Drawing.Size(182, 31);
            this.numberText.TabIndex = 2;
            // 
            // depDateText
            // 
            this.depDateText.Location = new System.Drawing.Point(41, 364);
            this.depDateText.Name = "depDateText";
            this.depDateText.PlaceholderText = "MM/DD/YY";
            this.depDateText.Size = new System.Drawing.Size(182, 31);
            this.depDateText.TabIndex = 4;
            // 
            // typeBox
            // 
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.typeBox.Location = new System.Drawing.Point(41, 218);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(182, 33);
            this.typeBox.TabIndex = 5;
            // 
            // destBox
            // 
            this.destBox.FormattingEnabled = true;
            this.destBox.Items.AddRange(new object[] {
            "Minsk",
            "Brest",
            "Gomel",
            "Grodno",
            "Vitebsk",
            "Mogilev"});
            this.destBox.Location = new System.Drawing.Point(41, 293);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(182, 33);
            this.destBox.TabIndex = 6;
            // 
            // arrTimeText
            // 
            this.arrTimeText.Location = new System.Drawing.Point(254, 220);
            this.arrTimeText.Name = "arrTimeText";
            this.arrTimeText.PlaceholderText = "HH:MM";
            this.arrTimeText.Size = new System.Drawing.Size(180, 31);
            this.arrTimeText.TabIndex = 7;
            // 
            // costText
            // 
            this.costText.Location = new System.Drawing.Point(254, 293);
            this.costText.Name = "costText";
            this.costText.PlaceholderText = "X.X";
            this.costText.Size = new System.Drawing.Size(180, 31);
            this.costText.TabIndex = 8;
            // 
            // numLeftUpDown
            // 
            this.numLeftUpDown.Location = new System.Drawing.Point(254, 364);
            this.numLeftUpDown.Name = "numLeftUpDown";
            this.numLeftUpDown.Size = new System.Drawing.Size(180, 31);
            this.numLeftUpDown.TabIndex = 9;
            // 
            // depTimeTExt
            // 
            this.depTimeTExt.Location = new System.Drawing.Point(251, 146);
            this.depTimeTExt.Name = "depTimeTExt";
            this.depTimeTExt.PlaceholderText = "HH:MM";
            this.depTimeTExt.Size = new System.Drawing.Size(183, 31);
            this.depTimeTExt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departure date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Departure Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Arrival Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Number Left";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(322, 404);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 34);
            this.backButton.TabIndex = 19;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // AddNewBusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depTimeTExt);
            this.Controls.Add(this.numLeftUpDown);
            this.Controls.Add(this.costText);
            this.Controls.Add(this.arrTimeText);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.depDateText);
            this.Controls.Add(this.numberText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "AddNewBusForm";
            this.Text = "AddNewBusForm";
            ((System.ComponentModel.ISupportInitialize)(this.numLeftUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addButton;
        private Label label1;
        private TextBox numberText;
        private TextBox depDateText;
        private ComboBox typeBox;
        private ComboBox destBox;
        private TextBox arrTimeText;
        private TextBox costText;
        private NumericUpDown numLeftUpDown;
        private TextBox depTimeTExt;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button backButton;
    }
}