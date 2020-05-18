using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalSystem
{
    public class DatabaseConnection
    {
        private SqlConnection Obj_Conn = new SqlConnection();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader Data_Reader;
        private SqlDataAdapter da = new SqlDataAdapter();
        string QueryString;
        public string CustName;
        public string Book_Name, Book_Available;
        public int CustomerID;
        public int BookID;
        public int RentID;
        public DatabaseConnection()
        {
            string ConnString = @"Data Source=SINGH-PC;Initial Catalog=Libaray;Integrated Security=True";
            Obj_Conn.ConnectionString = ConnString;
        }
        
        public string Login(string username, string password)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Select UserName, Password from UserDetails where UserName =  @UserName  and Password =  @Password ";
                Cmd.Parameters.AddWithValue("@UserName", username);
                Cmd.Parameters.AddWithValue("@Password", password);

                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();

                // get data stream
                Data_Reader = Cmd.ExecuteReader();
                if (Data_Reader.HasRows)
                {
                    return "User Login Successfully"; ;
                }
                else
                {
                    return "User details are not correct";
                }
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        // below  mentione function is used the register a new customer
        public string Registration(string UserName, string Email, string Password)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into UserDetails(UserName,Email, Password) Values(@UserName, @Email, @Password)";
                Cmd.Parameters.AddWithValue("@UserName",UserName);
                Cmd.Parameters.AddWithValue("@Email", Email);
                Cmd.Parameters.AddWithValue("@Password", Password);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "User registered Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public DataTable FillCustomer_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Customer";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }

        public DataTable FillBook_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Books";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public DataTable FillRent_Data()
        {
            DataTable dt = new DataTable();
            QueryString = "select * From Rent";
            using (da = new SqlDataAdapter(QueryString, Obj_Conn))
            {
                Obj_Conn.Open();
                da.Fill(dt);
                Obj_Conn.Close();
            }
            return dt;
        }
        public string CustomerInsert(string FirstName,string LastName,string Mobile,string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Customer(FirstName,LastName,Address, Mobile) Values(@FirstName,@LastName,@Address, @Mobile)";
                Cmd.Parameters.AddWithValue("@FirstName", FirstName);
                Cmd.Parameters.AddWithValue("@LastName", LastName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string BookInsert(string BookName, string Author, string Available)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Books(BookName,Author,Available) Values(@BookName,@Author,@Available)";
                Cmd.Parameters.AddWithValue("@BookName", BookName);
                Cmd.Parameters.AddWithValue("@Author", Author);
                Cmd.Parameters.AddWithValue("@Available", Available);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Book Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string IssueBook(int Cust_ID, int Book_Id, DateTime BorrowDate)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Insert into Rent(CustIDFK,BookIDFK,BorrowDate,ReturnedDate) Values(@Cust_ID,@Book_Id,@BorrowDate,NULL)";
                Cmd.Parameters.AddWithValue("@Cust_ID", Cust_ID);
                Cmd.Parameters.AddWithValue("@Book_Id", Book_Id);
                Cmd.Parameters.AddWithValue("@BorrowDate", BorrowDate);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Rent Data Inserted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string CustomerUpdate(int CustID, string FirstName, string LastName, string Mobile, string Address)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Update Customer Set FirstName = @FirstName, LastName = @LastName, Address = @Address,Mobile = @Mobile where CustID like @CustID";
                Cmd.Parameters.AddWithValue("@CustID", CustID);
                Cmd.Parameters.AddWithValue("@FirstName", FirstName);
                Cmd.Parameters.AddWithValue("@LastName", LastName);
                Cmd.Parameters.AddWithValue("@Address", Address);
                Cmd.Parameters.AddWithValue("@Mobile", Mobile);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string BookUpdate(int BookID, string BookName, string Author, string Available)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Update Books set BookName = @BookName,Author = @Author, Available = @Available where BookID = @BookID";
                Cmd.Parameters.AddWithValue("@BookID", BookID);
                Cmd.Parameters.AddWithValue("@BookName", BookName);
                Cmd.Parameters.AddWithValue("@Author", Author);
                Cmd.Parameters.AddWithValue("@Available", Available);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Book Data Updated Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string ReturnBook(int Rent_Id, DateTime ReturnDate)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Update Rent set ReturnedDate = @ReturnDate where BorrowID = @Rent_ID";
                Cmd.Parameters.AddWithValue("@Rent_ID", Rent_Id);
                Cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Rent Data Returneded Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public void BookBorrow(int BookBorrowID)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Update Books set Available = 'No', Borrower = 'Yes' where BookID = @BookBorrowID";
                Cmd.Parameters.AddWithValue("@BookBorrowID", BookBorrowID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // show error Message
                Obj_Conn.Close();
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public void BookReturn(int BookReturnID)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Update Books set Available = 'Yes', Borrower = NULL where BookID = @BookReturnID";
                Cmd.Parameters.AddWithValue("@BookReturnID", BookReturnID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // show error Message
                Obj_Conn.Close();
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }


        public string CustomerDelete(int CustID)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Customer where CustID like @CustID";
                Cmd.Parameters.AddWithValue("@CustID", CustID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Customer Data Deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string BookDelete(int BookID)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "Delete from Books where BookID like @BookID";
                Cmd.Parameters.AddWithValue("@BookID", BookID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // Executed query
                Cmd.ExecuteNonQuery();
                return "Book Data Deleted Successfully";
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string CustomerName(int CustomerID)
        {
             try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "select FirstName, LastName From Customer where CustID like @CustID";
                Cmd.Parameters.AddWithValue("@CustID", CustomerID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();

                // get data stream
                Data_Reader = Cmd.ExecuteReader();
                if (Data_Reader.HasRows)
                {
                    while (Data_Reader.Read())
                    {
                        CustName = Data_Reader.GetString(0) + " " + Data_Reader.GetString(1);
                    }
                    return CustName;
                }
                else
                {
                    return "Customer details are not correct";
                }
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
        public string BookName(int Books_ID)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "select BookName From Books where BookID = @Books_ID";
                Cmd.Parameters.AddWithValue("@Books_ID", Books_ID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // get data stream
                Data_Reader = Cmd.ExecuteReader();
                if (Data_Reader.HasRows)
                {
                    while (Data_Reader.Read())
                    {
                        Book_Name = Data_Reader.GetString(0);
                    }
                    return Book_Name;
                }
                else
                {
                    return "Book details are not correct";
                }
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }

        public string BookAvailable(int Books_ID)
        {
            try
            {
                Cmd.Parameters.Clear();
                Cmd.Connection = Obj_Conn;
                QueryString = "select Available From Books where BookID = @Books_ID";
                Cmd.Parameters.AddWithValue("@Books_ID", Books_ID);
                Cmd.CommandText = QueryString;
                //connection opened
                Obj_Conn.Open();
                // get data stream
                Data_Reader = Cmd.ExecuteReader();
                if (Data_Reader.HasRows)
                {
                    while (Data_Reader.Read())
                    {
                        Book_Available = Data_Reader.GetString(0);
                    }
                    return Book_Available;
                }
                else
                {
                    return "Book details are not correct";
                }
            }
            catch (Exception ex)
            {
                // show error Message
                return ex.Message;
            }
            finally
            {
                // close connection
                if (Obj_Conn != null)
                {
                    Obj_Conn.Close();
                }
            }
        }
    }
}
