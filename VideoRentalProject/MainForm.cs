using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRentalProject
{
    public partial class MainForm : Form
    {
        DB Database = new DB();
        string WhichButtonClicked = "";
        string RMID = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadCustomers();
            WhichButtonClicked = "Customer";
        }

        private void LoadMovies_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadMovies();
            WhichButtonClicked = "Movies";
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            Database.AddCustomer(FirstNBox.Text, LastNBox.Text, PhBox.Text, AddBox.Text);
            LoadBtn_Click(null, null);
        }

        private void UpdCustBtn_Click(object sender, EventArgs e)
        {
            Database.UpdateCustomer(CIdBox.Text, FirstNBox.Text, LastNBox.Text, PhBox.Text, AddBox.Text);
            LoadBtn_Click(null, null);
        }


        private void DltCustBtn_Click(object sender, EventArgs e)
        {
            Database.DltCustBtn(CIdBox.Text);
            LoadBtn_Click(null, null);
        }

        private void IssueMovieBtn_Click(object sender, EventArgs e)
        {
            Database.IssueMovieBtn(MIdBox.Text, CIdBox.Text);
            LoadRentedMovies_Click(null, null);
        }

        private void LoadRentedMovies_Click(object sender, EventArgs e)
        {
            MainGrid.DataSource = Database.LoadRentedMovies();
            WhichButtonClicked = "Rented";
        }

        private void ReturnMovieBtn_Click(object sender, EventArgs e)
        {
            Database.ReturnMovieBtn(RMID);
            LoadRentedMovies_Click(null, null);
        }

        private void MainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];

            if (WhichButtonClicked == "Customer")
            {
                CIdBox.Text = row.Cells[0].Value.ToString();
                FirstNBox.Text = row.Cells[1].Value.ToString();
                LastNBox.Text = row.Cells[2].Value.ToString();
                AddBox.Text = row.Cells[3].Value.ToString();
                PhBox.Text = row.Cells[4].Value.ToString();
            }
            else if(WhichButtonClicked == "Movies")
            {
                MIdBox.Text = row.Cells[0].Value.ToString();
            }
            else if (WhichButtonClicked == "Rented")
            {
                RMID = row.Cells[0].Value.ToString();
                Console.WriteLine(RMID);
            }
        }

        private void PopCustBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.PopCustBtn());
        }

        private void PopMovBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Database.PopMovBtn());
        }

        private void MovieIDTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = MainGrid.Rows[index];

            if (row.Cells.Count == 5)
            {
                CIdBox.Text = row.Cells[0].Value.ToString();
                FirstNBox.Text = row.Cells[1].Value.ToString();
                LastNBox.Text = row.Cells[2].Value.ToString();
                AddBox.Text = row.Cells[3].Value.ToString();
                PhBox.Text = row.Cells[4].Value.ToString();
            }
            else
                 if (row.Cells.Count == 8)
            {

                MIdBox.Text = row.Cells[0].Value.ToString();
                RatiBox.Text = row.Cells[1].Value.ToString();
                TitleBox.Text = row.Cells[2].Value.ToString();
                YearBox.Text = row.Cells[3].Value.ToString();
                RCostBox.Text = row.Cells[4].Value.ToString();
                CopBox.Text = row.Cells[5].Value.ToString();
                PLBox.Text = row.Cells[6].Value.ToString();
                GenreBox.Text = row.Cells[7].Value.ToString();
            }

        }


        private void AddMovieBtn_Click(object sender, EventArgs e)
        {
            Database.AddMovieBtn(RatiBox.Text, TitleBox.Text, YearBox.Text, RCostBox.Text, CopBox.Text, PLBox.Text, GenreBox.Text);
            LoadBtn_Click(null, null);
        }

        private void UpdMovieBtn_Click(object sender, EventArgs e)
        {
            Database.UpdMovieBtn(MIdBox.Text, RatiBox.Text, TitleBox.Text, YearBox.Text, RCostBox.Text, CopBox.Text, PLBox.Text, GenreBox.Text);
            LoadBtn_Click(null, null);
        }

        private void DltMovieBtn_Click(object sender, EventArgs e)
        {
            Database.DltMovieBtn(MIdBox.Text);
            LoadBtn_Click(null, null);
        }
    }
}
