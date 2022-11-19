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
    public partial class UpdateUser : Form
    {
        string nickname;
        string newNickname, newPassword;
        int newRole;
        public UpdateUser()
        {
            InitializeComponent();
        }

        private void editNicknameButton_Click(object sender, EventArgs e)
        {
            
            if(newNicknameText.Text.Length > 3 && nickCheck())
            {
                nickname = nicknameText.Text;

                if (AddNewForm.CheckUserInfo(nickname))
                {
                    newNickname = newNicknameText.Text;
                    string sqlExpression = $"UPDATE user_info SET nickname='{newNickname}' WHERE nickname='{nickname}'";
                    using (var connection = new SqliteConnection(Form1.dbPath))
                    {
                        connection.Open();
                        SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Nickname is changed successfly","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("User isn't found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("New nickname must be more than 3 characters", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        

        private void editPAsswordButton_Click(object sender, EventArgs e)
        {
            if(newPasswordText.Text.Length > 3 && nickCheck())
            {
                nickname = nicknameText.Text;

                if (AddNewForm.CheckUserInfo(nickname))
                {
                    newPassword = Form1.ComputeSha256Hash( newPasswordText.Text);
                    string sqlExpression = $"UPDATE user_info SET password='{newPassword}' WHERE nickname='{nickname}'";
                    using (var connection = new SqliteConnection(Form1.dbPath))
                    {
                        connection.Open();
                        SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Password is changed successfly");
                    }
                }
                else
                {
                    MessageBox.Show("User isn't found");
                }
            }
            else
            {
                MessageBox.Show("Password must be more than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newNicknameText_TextChanged(object sender, EventArgs e)
        {

        }

        bool nickCheck()
        {
            if (nicknameText.Text.Length == 0) 
            {
                MessageBox.Show("Nickname must be more than 3 characters");
                return false;
            }
            return true;
        }

        private void editRoleButton_Click(object sender, EventArgs e)
        {

            if(newRoleBox.Text != "" && nickCheck())
            {
                nickname = nicknameText.Text;

                if (AddNewForm.CheckUserInfo(nickname))
                {
                    newRole = newRoleBox.SelectedIndex;
                    string sqlExpression = $"UPDATE user_info SET role='{newRole}' WHERE nickname='{nickname}'";
                    using (var connection = new SqliteConnection(Form1.dbPath))
                    {
                        connection.Open();
                        SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Role is changed successfly");
                    }
                }
                else
                {
                    MessageBox.Show("User isn't found");
                }
            }
            else
            {
                MessageBox.Show("Role must be more not null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
            
        }
    }
}
