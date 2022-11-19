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
    public partial class RegForm : Form
    {
        public static bool regComp;
        public RegForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Go out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) { Close(); }
        }

        private void RegConfButton_Click(object sender, EventArgs e)
        {
            if(nicknameText.Text.Length > 3 && passwordText.Text.Length > 3)
            {
                string nickname = nicknameText.Text;
                string password = Form1.ComputeSha256Hash( passwordText.Text);
                int role = 0;
                if (AddNewForm.CheckUserInfo(nickname))
                {
                    MessageBox.Show("This nickname is taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    regComp = false;
                }
                else
                {


                    using (var connection = new SqliteConnection(Form1.dbPath))
                    {
                        connection.Open();

                        SqliteCommand command = new SqliteCommand();
                        command.Connection = connection;
                        command.CommandText = $"INSERT INTO user_info (nickname, password, role) VALUES ('{nickname}', '{password}', {role})";
                        int number = command.ExecuteNonQuery();
                        regComp = true;
                        MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Close();

                }
            }
            else
            {
                MessageBox.Show("Username and password must be more than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
    }
}
