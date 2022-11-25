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
            if(numberText.Text.Length > 3 && typeBox.Text.Length > 0 && destBox.Text.Length > 0 && costText.Text.Length > 0 && numLeftUpDown.Value > 0)
            {
                using (var connection = new SqliteConnection(Form1.dbPath))
                {
                    connection.Open();

                    SqliteCommand command = new SqliteCommand();
                    bool wrongCheck = true; //если true - ошибок не найдено
                    int number;
                    
                    if(!int.TryParse(numberText.Text, out number))
                    {
                        wrongCheck = false;
                        ErrMsg("Number it's incorrent");
                    }
                    string type = typeBox.Text;
                    string dest = destBox.Text;
                    var depDate = depDatePic.Value.ToShortDateString();
                    var depTime = depTimePic.Value.ToShortTimeString();
                    var arrTime = arrTimePic.Value.ToShortTimeString();

                    double cost;
                    if (!double.TryParse(costText.Text, out cost))
                    {
                        wrongCheck = false;
                        ErrMsg("Cost it's incorrect");
                    }
                    int numLeft = Convert.ToInt32(numLeftUpDown.Value);
                    if (numLeft <= 0)
                    {
                        wrongCheck = false;
                        ErrMsg("Num left it's incorrect");
                    }
                    int numSold = 0;
                    if(!RemoveBusForm.CheckBusInfo(number))
                    {
                        if (wrongCheck)
                        {
                            command.Connection = connection;
                            command.CommandText = $"INSERT INTO bus_info (number, type, dest, dep_date, dep_time, arr_time, cost, num_left, num_sold) VALUES ({number}, '{type}', '{dest}', '{depDate}', '{depTime}', '{arrTime}', {cost},{numLeft},{numSold})";
                            number = command.ExecuteNonQuery();

                            InfMsg("Success");
                            Close();
                        }
                    }
                    else
                    {
                       ErrMsg("Number is taken");
                    }
                    
                    

                }
            }
            else
            {
                ErrMsg("Wrong data");
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static void ErrMsg(string errMsg)
        {
            MessageBox.Show($"{errMsg}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void InfMsg(string infMsg)
        {
            MessageBox.Show($"{infMsg}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        


    }
}
