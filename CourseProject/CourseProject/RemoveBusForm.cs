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
    public partial class RemoveBusForm : Form
    {
        public RemoveBusForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberText.Text);
            if (CheckBusInfo(number))
            {
                string sqlExpression = $"DELETE FROM bus_info WHERE number='{number}'";
                using (var connection = new SqliteConnection(Form1.dbPath))
                {
                    connection.Open();
                    SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Remove is success");
            }
            else
            {
                MessageBox.Show("User isn't found");
            }
            Close();
        }

        public bool CheckBusInfo(int number)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE number='{number}'";
            using (var connection = new SqliteConnection(Form1.dbPath))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
