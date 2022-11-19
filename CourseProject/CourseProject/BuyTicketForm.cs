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
    public partial class BuyTicketForm : Form
    {
        public BuyTicketForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Come back?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) { Close(); }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (numberText.Text != "")
            {
                bool allRight = true;
                int numLeft = 0;
                int numSold = 0;
                int number = Convert.ToInt32(numberText.Text);
                int numberTick = Convert.ToInt32(numTickUpDown.Value);
                string sqlExpression = $"SELECT num_left,num_sold FROM bus_info WHERE number = {number}";
                using (SqliteConnection connection = new SqliteConnection(Form1.dbPath))
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                numLeft = reader.GetInt32(0);
                                numSold = reader.GetInt32(1);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            allRight = false;

                        }
                    }
                    if (allRight)
                    {
                        int newNumLeft = numLeft - numberTick;

                        int newNumSold = numSold + numberTick;

                        if (newNumLeft >= 0)
                        {
                            string sqlExpression2 = $"UPDATE bus_info SET num_left='{newNumLeft}',num_sold='{newNumSold}' WHERE number = '{number}'";
                            connection.Open();
                            SqliteCommand command2 = new SqliteCommand(sqlExpression2, connection);
                            command2.ExecuteNonQuery();
                            MessageBox.Show("Ticket purchased successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Missing number of tickets","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
