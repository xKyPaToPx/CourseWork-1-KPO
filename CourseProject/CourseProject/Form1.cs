using System.Security.Cryptography;
using System.Text;

namespace CourseProject;

public partial class Form1 : Form
{
    public static string dbPath = "Data Source=../../../../database.db";
    LogForm logForm;
    RegForm regForm;
    AdminForm adminForm;
    
    public static string ComputeSha256Hash(string rawData)
    {
        // Create a SHA256   
        using (SHA256 sha256Hash = SHA256.Create())
        {
            // ComputeHash - returns byte array  
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            // Convert byte array to a string   
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }

    int role = -1;
    public Form1()
    {
        InitializeComponent();
    }

    private void logButton_Click(object sender, EventArgs e)
    {
        logForm = new LogForm();
        logForm.Show();
        logForm.FormClosing += LogForm_FormClosing;
        
        
        
    }

    private void LogForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        role = logForm.role;
        switch (role)
        {
            case 0:
                UserForm userForm = new UserForm();
                userForm.Show();
                break;
            case 1:
                adminForm = new AdminForm();
                adminForm.Show();
                break;
        }

    }

    private void regButton_Click(object sender, EventArgs e)
    {
        regForm = new RegForm();
        regForm.Show();
        regForm.FormClosing += RegForm_FormClosing;
    }

    private void RegForm_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if(RegForm.regComp)
        {
            UserForm userForm = new UserForm();
            userForm.Show();
        }
        
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        DialogResult dialog = MessageBox.Show("Go out?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        if (dialog == DialogResult.Yes) { Close(); }
    }
}