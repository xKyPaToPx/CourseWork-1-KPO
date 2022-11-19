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
    public partial class SearchShowGridForm : Form
    {
        public SearchShowGridForm()
        {
            InitializeComponent();
        }

        private void SearchShowGridForm_Load(object sender, EventArgs e)
        {
            string sqlExpression = SearchDataForm.sqlGridExpression;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
