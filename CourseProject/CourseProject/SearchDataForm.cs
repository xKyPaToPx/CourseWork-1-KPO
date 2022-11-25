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
            int temp;
            if(numberText.Text.Length == 4)
            {
                if (!int.TryParse(numberText.Text, out temp))
                {
                    string sqlExpression = $"SELECT * FROM bus_info WHERE number = '{numberText.Text}'";
                    SearchGrid(sqlExpression);
                }
                else
                {
                    AddNewBusForm.ErrMsg("Number it's incorrect");
                }
            }
            else
            {
                AddNewBusForm.ErrMsg("Number must equal 4 char");
            }
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
            string sqlExpression = $"SELECT * FROM bus_info WHERE dep_date = '{depDatePic.Value.ToShortDateString()}'";
            SearchGrid(sqlExpression);
        }

        private void byDepTimeButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE dep_time = '{depTimePic.Value.ToShortTimeString}'";
            SearchGrid(sqlExpression);
        }

        private void byArrTimeButton_Click(object sender, EventArgs e)
        {
            string sqlExpression = $"SELECT * FROM bus_info WHERE arr_time = '{arrTimePic.Value.ToShortTimeString}'";
            SearchGrid(sqlExpression);
        }

        private void byCostButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(costText.Text, out var cost))
            {
                if (cost > 0)
                {
                    string sqlExpression = $"SELECT * FROM bus_info WHERE cost = '{costText.Text}'";
                    SearchGrid(sqlExpression);
                }
                else
                {
                    AddNewBusForm.ErrMsg("Cost must be more than 0");
                }
                
            }
            else
            {
                AddNewBusForm.ErrMsg("Cost it's incorrect");
            }
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

        private void SearchDataForm_Load(object sender, EventArgs e)
        {

        }
    }
}
