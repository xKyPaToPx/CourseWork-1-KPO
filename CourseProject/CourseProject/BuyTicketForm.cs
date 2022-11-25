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
            if (numberText.Text.Length == 4)
            {
                bool allRight = true;
                bool wrongCheck = true;
                int numLeft = 0;
                int numSold = 0;
                int number;
                if(!int.TryParse(numberText.Text, out number))
                {
                    AddNewBusForm.ErrMsg("Numer it's incorrect");
                    wrongCheck = false;
                }
                int numberTick = Convert.ToInt32(numTickUpDown.Value);
                if(numberTick <= 0) 
                {
                    AddNewBusForm.ErrMsg("Number tickets it's incorrect");
                    wrongCheck = false;
                }
                
                if(wrongCheck)
                {
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
                                MessageBox.Show("Wrong number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                AddNewBusForm.InfMsg("Ticket purchased successfully");
                                Close();
                            }
                            else
                            {
                                AddNewBusForm.ErrMsg("Missing number of tickets");
                            }
                        }

                    }
                }
                
            }
            else
            {
                AddNewBusForm.ErrMsg("Number must equal 4 char");
            }
            
        }
    }
}
