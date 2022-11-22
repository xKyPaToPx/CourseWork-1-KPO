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
    
    public partial class UpdateBus : Form
    {
        public UpdateBus()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void newDepTimeButton_Click(object sender, EventArgs e)
        {
            if (numCheck())
            {
                if (newDepTimeTExt.Text.Length == 5)
                {
                    string number = numberText.Text;
                    string newDepTime = newDepTimeTExt.Text;
                    string sqlExpression = $"UPDATE bus_info SET dep_time='{newDepTime}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Departure time is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Departure time must be hh:mm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void UpdateBus_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Update(string sqlExpression)
        {
            using (var connection = new SqliteConnection(Form1.dbPath))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                command.ExecuteNonQuery();
            }
        }

        private void newNumberButton_Click(object sender, EventArgs e)
        {
            if(numCheck())
            {
                if (newNumberText.Text.Length > 3)
                {
                    string number = numberText.Text;
                    int newNumber = Convert.ToInt32(newNumberText.Text);
                    string sqlExpression = $"UPDATE bus_info SET number='{newNumber}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Number is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Number must be more than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
            
            
        }

        private void newTypeButton_Click(object sender, EventArgs e)
        {
            if (numCheck())
            {
                if (newTypeBox.Text.Length != 0)
                {
                    string number = numberText.Text;
                    string newType = newTypeBox.Text;
                    string sqlExpression = $"UPDATE bus_info SET type='{newType}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Type is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Type must be not null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void newDestButton_Click(object sender, EventArgs e)
        {
            if (numCheck())
            {
                if (newDestBox.Text.Length != 0)
                {
                    string number = numberText.Text;
                    string newDestination = newDestBox.Text;
                    string sqlExpression = $"UPDATE bus_info SET dest='{newDestination}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Destination is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Destination must be not null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void newDepDateButton_Click(object sender, EventArgs e)
        {
            if(numCheck())
            {
                if (newDepDateText.Text.Length == 8)
                {
                    string number = numberText.Text;
                    string newDepDate = newDepDateText.Text;
                    string sqlExpression = $"UPDATE bus_info SET dep_date='{newDepDate}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Departure date is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Departure date must be mm/dd/yy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void newArrTimeButton_Click(object sender, EventArgs e)
        {
            if(numCheck())
            {
                if (newArrTimeText.Text.Length == 5)
                {
                    string number = numberText.Text;
                    string newArrTime = newArrTimeText.Text;
                    string sqlExpression = $"UPDATE bus_info SET arr_time='{newArrTime}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Arrival time is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Arrival time must be hh:mm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void newCostButton_Click(object sender, EventArgs e)
        {
            if (numCheck())
            {
                if (newCostText.Text.Length != 0)
                {
                    string number = numberText.Text;
                    double newCost = Convert.ToDouble(newCostText.Text);
                    string sqlExpression = $"UPDATE bus_info SET cost='{newCost}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Cost is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cost must be more not null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
           
        }

        private void newNumLeftButton_Click(object sender, EventArgs e)
        {
            if(numCheck())
            {
                if (newNumLeftUpDown.Value > 0)
                {
                    string number = numberText.Text;
                    int newNumLeft = Convert.ToInt32(newNumLeftUpDown.Value);
                    string sqlExpression = $"UPDATE bus_info SET num_left='{newNumLeft}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Num left is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Number  left must be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void newNumSoldButton_Click(object sender, EventArgs e)
        {
            if (numCheck())
            {
                if (newNumberText.Text.Length > 0)
                {
                    string number = numberText.Text;
                    int newNumSold = Convert.ToInt32(newNumSoldUpDown.Value);
                    string sqlExpression = $"UPDATE bus_info SET num_sold='{newNumSold}' WHERE number='{number}'";
                    Update(sqlExpression);
                    MessageBox.Show("Num sold is changed successfly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Num sold must be more than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        bool numCheck()
        {
            if(numberText.Text.Length < 4)
            {
                MessageBox.Show("Enter correct number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
