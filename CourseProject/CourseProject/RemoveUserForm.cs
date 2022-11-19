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
using static System.Windows.Forms.DataFormats;

namespace CourseProject
{
    public partial class RemoveUserForm : Form
    {
        public RemoveUserForm()
        {
            InitializeComponent();
        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Remove user?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                string nickname = nicknameText.Text;
                if (AddNewForm.CheckUserInfo(nickname))
                {
                    string sqlExpression = $"DELETE FROM user_info WHERE nickname='{nickname}'";
                    using (var connection = new SqliteConnection(Form1.dbPath))
                    {
                        connection.Open();
                        SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Remove is success","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User isn't found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
            
                
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
