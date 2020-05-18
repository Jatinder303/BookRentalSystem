using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalSystem
{
    public partial class DashboardForm : Form
    {
        DatabaseConnection Obj_Data = new DatabaseConnection();
        DateTime obj_Current_Date = DateTime.Now;

        public DashboardForm()
        {
            InitializeComponent();
            Customer_Load();
            Book_Load();
            Rent_Load();
        }

        public void Customer_Load()
        {
            DGV_Customer.DataSource = null;
            try
            {
                DGV_Customer.DataSource = Obj_Data.FillCustomer_Data();
                DGV_Customer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Book_Load()
        {
            DGV_Books.DataSource = null;
            try
            {
                DGV_Books.DataSource = Obj_Data.FillBook_Data();
                DGV_Books.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rent_Load()
        {
            DGV_Rent.DataSource = null;
            try
            {
                DGV_Rent.DataSource = Obj_Data.FillRent_Data();
                DGV_Rent.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var LoginForm_Obj = new LoginForm();
            LoginForm_Obj.Closed += (s, args) => this.Close();
            LoginForm_Obj.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DGV_Customer_SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Customer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.CustomerID = Convert.ToInt32(DGV_Customer.Rows[e.RowIndex].Cells[0].Value);
                txt_FirstName.Text = DGV_Customer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_LastName.Text = DGV_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Mobile.Text = DGV_Customer.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_Address.Text = DGV_Customer.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_CustName.Text = DGV_Customer.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + DGV_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }
        private void DGV_Books_SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Books.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.BookID = Convert.ToInt32(DGV_Books.Rows[e.RowIndex].Cells[0].Value);
                txt_BookName.Text = DGV_Books.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_Author.Text = DGV_Books.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_Available.Text = DGV_Books.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_BookName_Rented.Text = DGV_Books.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }
        private void DGV_Rent_SelectRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string newvalue = DGV_Rent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                Obj_Data.RentID = Convert.ToInt32(DGV_Rent.Rows[e.RowIndex].Cells[0].Value);
                Obj_Data.CustomerID = Convert.ToInt32(DGV_Rent.Rows[e.RowIndex].Cells[2].Value);
                Obj_Data.BookID = Convert.ToInt32(DGV_Rent.Rows[e.RowIndex].Cells[1].Value);
                txt_BookName_Rented.Text = Obj_Data.BookName(Obj_Data.BookID);
                txt_CustName.Text = Obj_Data.CustomerName(Obj_Data.CustomerID);
                DatePicker_IssueDate.Value = Convert.ToDateTime(DGV_Rent.Rows[e.RowIndex].Cells[3].Value);
                datePicker_ReturnedDate.Value = obj_Current_Date;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong", ex.Message);
            }
        }
        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text != "" && txt_LastName.Text != "" && txt_Mobile.Text != "" && txt_Address.Text != "" )
            {
                string message = Obj_Data.CustomerInsert(txt_FirstName.Text, txt_LastName.Text, txt_Mobile.Text, txt_Address.Text);
                MessageBox.Show(message);
                txt_FirstName.Text = "";
                txt_LastName.Text = "";
                txt_Mobile.Text = "";
                txt_Address.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please Fill all the fields related to Customer");
            }
        }

        private void btn_UpdateCustomer_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.CustomerUpdate(Obj_Data.CustomerID, txt_FirstName.Text, txt_LastName.Text, txt_Mobile.Text, txt_Address.Text);
            MessageBox.Show(message);
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Mobile.Text = "";
            txt_Address.Text = "";
            Customer_Load();

        }

        private void btn_DeleteCustomer_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.CustomerDelete(Obj_Data.CustomerID);
            MessageBox.Show(message);
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            txt_Mobile.Text = "";
            txt_Address.Text = "";
            Customer_Load();
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if (txt_BookName.Text != "" && txt_Author.Text != "" && txt_Available.Text != "" )
            {
                string message = Obj_Data.BookInsert(txt_BookName.Text, txt_Author.Text, txt_Available.Text);
                MessageBox.Show(message);
                txt_BookName.Text = "";
                txt_Author.Text = "";
                txt_Available.Text = "";
                Book_Load();
            }
            else
            {
                MessageBox.Show("Please Fill all the fields related to Customer");
            }
        }

        private void btn_UpdateBook_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.BookUpdate(Obj_Data.BookID ,txt_BookName.Text, txt_Author.Text, txt_Available.Text);
            MessageBox.Show(message);
            txt_BookName.Text = "";
            txt_Author.Text = "";
            txt_Available.Text = "";
            Book_Load();
        }

        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            string message = Obj_Data.BookDelete(Obj_Data.BookID);
            MessageBox.Show(message);
            txt_BookName.Text = "";
            txt_Author.Text = "";
            txt_Available.Text = "";
            Book_Load();
        }

        private void btn_IssueBook_Click(object sender, EventArgs e)
        {
            if (txt_CustName.Text != "" && txt_BookName_Rented.Text != "" && DatePicker_IssueDate.Text != "")
            {
                string available_book = Obj_Data.BookAvailable(Obj_Data.BookID);
                if (available_book == "No")
                {
                    MessageBox.Show("This book is already rented out");
                }
                else {
                    string message = Obj_Data.IssueBook(Obj_Data.CustomerID, Obj_Data.BookID, Convert.ToDateTime(DatePicker_IssueDate.Text));
                    Obj_Data.BookBorrow(Obj_Data.BookID);
                    MessageBox.Show(message);
                    txt_CustName.Text = "";
                    txt_BookName_Rented.Text = "";
                    Rent_Load();
                    Book_Load(); }
            }
            else
            {
                MessageBox.Show("Please Fill all the fields related to Customer");
            }
        }

        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            if (datePicker_ReturnedDate.Text != "")
            {
                string available_book = Obj_Data.BookAvailable(Obj_Data.BookID);
                if (available_book == "Yes")
                {
                    MessageBox.Show("This book is already returned");
                }
                else
                {
                    string message = Obj_Data.ReturnBook(Obj_Data.RentID, datePicker_ReturnedDate.Value);
                    Obj_Data.BookReturn(Obj_Data.BookID);
                    MessageBox.Show(message);
                    txt_CustName.Text = "";
                    txt_BookName_Rented.Text = "";
                    Rent_Load();
                    Book_Load();
                }
            }
            else
            {
                MessageBox.Show("Please Fill all the fields related to Customer");
            }
        }
    }
}
