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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            ShowBusesForm showBusesForm = new ShowBusesForm();
            showBusesForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Come back?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) { Close(); }
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

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
