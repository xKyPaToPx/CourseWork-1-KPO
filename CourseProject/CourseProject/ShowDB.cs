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
    public partial class ShowDB : Form
    {
        public ShowDB()
        {
            InitializeComponent();
        }

        private void ShowDB_Load(object sender, EventArgs e)
        {
            UpdateUDB();
        }

        void UpdateUDB()
        {
            string sqlExpression = "SELECT * FROM user_info";
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
                            string nickname = reader.GetString(1);
                            string password = reader.GetString(2);
                            int role = reader.GetInt32(3);

                            DBGrid.Rows.Add(nickname, password, role);
                        }
                    }
                }
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DBGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddNewForm addNewForm = new AddNewForm();
            addNewForm.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveUserForm removeUserForm = new RemoveUserForm();
            removeUserForm.Show();
        }

        private void updateBut_Click(object sender, EventArgs e)
        {
            UpdateUDB();
        }
    }
}
