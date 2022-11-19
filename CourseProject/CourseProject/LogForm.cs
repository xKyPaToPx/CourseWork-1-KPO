using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace CourseProject;

public partial class LogForm : Form
{
    
    private string nickname;
    private string password;
    public int role = -1;

    public LogForm()
    {
        InitializeComponent();
    }

    private void loginConfButton_Click(object sender, EventArgs e)
    {
        if (nicknameText.Text.Length > 3 && passwordText.Text.Length > 3 )
        {
            bool loginCheck = true;

            string nicknameDB, passwordDB = "";
            int roleDB = -1;
            nickname = nicknameText.Text;
            password = Form1.ComputeSha256Hash( passwordText.Text);
            string sqlExpression = $"SELECT * FROM user_info WHERE nickname='{nickname}'";
            using (var connection = new SqliteConnection(Form1.dbPath))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(sqlExpression, connection);
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            nicknameDB = reader.GetString(1);
                            passwordDB = reader.GetString(2);
                            roleDB = reader.GetInt32(3);


                        }
                    }
                    else
                    {
                        loginCheck = false;
                    }
                }
            }
            if (password != passwordDB)
            {
                loginCheck = false;
            }
            if (!loginCheck)
            {
                MessageBox.Show("Wrong data. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Login successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                role = roleDB;
                Close();
            }
        }
        else
        {
            MessageBox.Show("Гsername and password must be more than 3 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    private void backButton_Click(object sender, EventArgs e)
    {
        DialogResult dialog = MessageBox.Show("Go out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dialog == DialogResult.Yes) { Close(); }
    }
}