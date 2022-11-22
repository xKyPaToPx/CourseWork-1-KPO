using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class AddNewBusForm : Form
    {
        public AddNewBusForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(numberText.Text.Length > 3 && typeBox.Text.Length > 0 && destBox.Text.Length > 0 && depDateText.Text.Length == 8 && depTimeTExt.Text.Length == 5 && arrTimeText.Text.Length == 5 && costText.Text.Length > 0 && numLeftUpDown.Value > 0)
            {
                using (var connection = new SqliteConnection(Form1.dbPath))
                {
                    connection.Open();

                    SqliteCommand command = new SqliteCommand();
                    int number = Convert.ToInt32(numberText.Text);
                    string type = typeBox.Text;
                    string dest = destBox.Text;
                    string depDate = depDateText.Text;
                    string depTime = depTimeTExt.Text;
                    string arrTime = arrTimeText.Text;
                    double cost = Convert.ToDouble(costText.Text);
                    int numLeft = Convert.ToInt32(numLeftUpDown.Value);
                    int numSold = 0;
                    
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO bus_info (number, type, dest, dep_date, dep_time, arr_time, cost, num_left, num_sold) VALUES ({number}, '{type}', '{dest}', '{depDate}', '{depTime}', '{arrTime}', {cost},{numLeft},{numSold})";
                    number = command.ExecuteNonQuery();
                    
                    MessageBox.Show("Success","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Close();

                }
            }
            else
            {
                MessageBox.Show("Wrong data","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
