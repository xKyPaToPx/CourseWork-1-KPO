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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
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

        private void showDBButton_Click(object sender, EventArgs e)
        {
            ShowDB showDB = new ShowDB();
            showDB.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Come back?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) { Close(); }
        }

        private void addNewBus_Click(object sender, EventArgs e)
        {
            AddNewBusForm addNewBusForm = new AddNewBusForm();
            addNewBusForm.Show();
        }

        private void updateBusButton_Click(object sender, EventArgs e)
        {
            UpdateBus updateBus = new UpdateBus();
            updateBus.Show();
        }

        private void showBusButton_Click(object sender, EventArgs e)
        {
            ShowBusesForm showBusesForm = new ShowBusesForm();
            showBusesForm.Show();
        }

        private void removeBusButton_Click(object sender, EventArgs e)
        {
            RemoveBusForm removeBusForm = new RemoveBusForm();
            removeBusForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void buyTicketButton_Click(object sender, EventArgs e)
        {
            BuyTicketForm buyTicketForm = new BuyTicketForm();
            buyTicketForm.Show();
        }

        private void searchDataButton_Click(object sender, EventArgs e)
        {
            SearchDataForm searchDataForm = new SearchDataForm();
            searchDataForm.Show();
        }
    }
}
