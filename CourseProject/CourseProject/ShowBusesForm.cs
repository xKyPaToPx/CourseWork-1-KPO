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
    
    public partial class ShowBusesForm : Form
    {
        
        public ShowBusesForm()
        {
            InitializeComponent();
        }

        private void ShowBusesForm_Load(object sender, EventArgs e)
        {
            UpdateDB();
        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void busesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        public void updateBusButton_Click(object sender, EventArgs e)
        {
            UpdateBus updateBus = new UpdateBus();
            updateBus.Show();
        }

        private void addNewBus_Click(object sender, EventArgs e)
        {
            AddNewBusForm addNewBusForm = new AddNewBusForm();
            addNewBusForm.Show();   
        }

        private void removeBusButton_Click(object sender, EventArgs e)
        {
            RemoveBusForm removeBusForm = new RemoveBusForm();
            removeBusForm.Show();
        }

        private void searchDataButton_Click(object sender, EventArgs e)
        {
            SearchDataForm searchDataForm = new SearchDataForm();
            searchDataForm.Show();
        }

        private void buyTicketButton_Click(object sender, EventArgs e)
        {
            BuyTicketForm buyTicketForm = new BuyTicketForm();
            buyTicketForm.Show();
        }

        private void updateGrid_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }
        private void UpdateDB()
        {
            busesGrid.Rows.Clear();
            string sqlExpression = "SELECT * FROM bus_info";
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
                            int number = reader.GetInt32(1);
                            string type = reader.GetString(2);
                            string dest = reader.GetString(3);
                            string depDate = reader.GetString(4);
                            string depTime = reader.GetString(5);
                            string arrTime = reader.GetString(6);
                            double cost = reader.GetDouble(7);
                            int numLeft = reader.GetInt32(8);
                            int numSold = reader.GetInt32(9);

                            busesGrid.Rows.Add(number, type, dest, depDate, depTime, arrTime, cost, numLeft, numSold);
                        }
                    }
                }
            }
        }
    }
}
