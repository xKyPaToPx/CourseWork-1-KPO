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
    public partial class SearchDataForm : Form
    {
        public static string sqlGridExpression;
        public SearchDataForm()
        {
            InitializeComponent();
        }

        

        private void byNumberButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE number = '{numberText.Text}'";
            SearchGrid(sqlExpression);

        }

        public static void SearchGrid(string sqlExpression)
        {
            sqlGridExpression = sqlExpression;
            SearchShowGridForm searchShowGridForm = new SearchShowGridForm();
            searchShowGridForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void byTypeButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE type = '{typeComboBox.Text}'";
            SearchGrid(sqlExpression);
        }

        private void byDepDataButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE dep_date = '{depDataText.Text}'";
            SearchGrid(sqlExpression);
        }

        private void byDepTimeButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE dep_time = '{depTimeText.Text}'";
            SearchGrid(sqlExpression);
        }

        private void byArrTimeButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE arr_time = '{arrTimeText.Text}'";
            SearchGrid(sqlExpression);
        }

        private void byCostButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE cost = '{costText.Text}'";
            SearchGrid(sqlExpression);
        }

        private void byNumLeftButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE num_left = '{numLeftNum.Text}'";
            SearchGrid(sqlExpression);
        }

        private void byNumSoldButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE num_sold = '{numSoldNum.Text}'";
            SearchGrid(sqlExpression);
        }

        private void byDestButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE dest = '{destComboBox2.Text}'";
            SearchGrid(sqlExpression);
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
