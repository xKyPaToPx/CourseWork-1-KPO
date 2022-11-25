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
    public partial class AddNewForm : Form
    {
        public AddNewForm()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if(nicknameText.Text.Length > 3 && passwordText.Text.Length > 3 && roleBox.Text != "")
            {
                using (var connection = new SqliteConnection(Form1.dbPath))
                {
                    connection.Open();

                    SqliteCommand command = new SqliteCommand();
                    string nickname = nicknameText.Text;
                    string password = Form1.ComputeSha256Hash(passwordText.Text);
                    int role = roleBox.SelectedIndex;
                    if (CheckUserInfo(nickname))
                    {
                        AddNewBusForm.ErrMsg("Nickname is taken");
                    }
                    else
                    {
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO user_info (nickname, password, role) VALUES ('{nickname}', '{password}', {role})";
                        int number = command.ExecuteNonQuery();
                        AddNewBusForm.InfMsg("Success");
                        Close();
                    }
                }
            }
            else
            {
                AddNewBusForm.ErrMsg("Username and password must be more than 3 characters, and role must be not null");
            }
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static bool CheckUserInfo(string nickname)
        {
            
            string sqlExpression = $"SELECT * FROM user_info WHERE nickname='{nickname}'";
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
