namespace BookRentalSystem
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tabCtl_Dashboard = new System.Windows.Forms.TabControl();
            this.tab_Customer = new System.Windows.Forms.TabPage();
            this.DGV_Customer = new System.Windows.Forms.DataGridView();
            this.tab_Book = new System.Windows.Forms.TabPage();
            this.DGV_Books = new System.Windows.Forms.DataGridView();
            this.tab_Rent = new System.Windows.Forms.TabPage();
            this.DGV_Rent = new System.Windows.Forms.DataGridView();
            this.pnl_Customer = new System.Windows.Forms.Panel();
            this.btn_DeleteCustomer = new System.Windows.Forms.Button();
            this.btn_UpdateCustomer = new System.Windows.Forms.Button();
            this.btn_AddCustomer = new System.Windows.Forms.Button();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_CustomerDetails = new System.Windows.Forms.Label();
            this.pnl_Book = new System.Windows.Forms.Panel();
            this.txt_Available = new System.Windows.Forms.TextBox();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.lbl_Available = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_BookName = new System.Windows.Forms.Label();
            this.btn_DeleteBook = new System.Windows.Forms.Button();
            this.lbl_Book = new System.Windows.Forms.Label();
            this.btn_UpdateBook = new System.Windows.Forms.Button();
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.pnl_Rent = new System.Windows.Forms.Panel();
            this.datePicker_ReturnedDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ReturnedDate = new System.Windows.Forms.Label();
            this.DatePicker_IssueDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_IssueDate = new System.Windows.Forms.Label();
            this.txt_BookName_Rented = new System.Windows.Forms.TextBox();
            this.txt_CustName = new System.Windows.Forms.TextBox();
            this.lbl_BookName_Rented = new System.Windows.Forms.Label();
            this.btn_ReturnBook = new System.Windows.Forms.Button();
            this.lbl_CustName = new System.Windows.Forms.Label();
            this.lbl_Rent = new System.Windows.Forms.Label();
            this.btn_IssueBook = new System.Windows.Forms.Button();
            this.btn_PopularCust = new System.Windows.Forms.Button();
            this.btn_PopularBook = new System.Windows.Forms.Button();
            this.btn_AllBorrowedBooks = new System.Windows.Forms.Button();
            this.btn_AllBooks = new System.Windows.Forms.Button();
            this.tab_Popular_Customer = new System.Windows.Forms.TabPage();
            this.tab_Popular_Books = new System.Windows.Forms.TabPage();
            this.DGV_Popular_Movie = new System.Windows.Forms.DataGridView();
            this.DGV_PopularCustomer = new System.Windows.Forms.DataGridView();
            this.tabCtl_Dashboard.SuspendLayout();
            this.tab_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).BeginInit();
            this.tab_Book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).BeginInit();
            this.tab_Rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rent)).BeginInit();
            this.pnl_Customer.SuspendLayout();
            this.pnl_Book.SuspendLayout();
            this.pnl_Rent.SuspendLayout();
            this.tab_Popular_Customer.SuspendLayout();
            this.tab_Popular_Books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Popular_Movie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PopularCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Back.Location = new System.Drawing.Point(855, 555);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(146, 41);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Exit.Location = new System.Drawing.Point(1038, 555);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(146, 41);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tabCtl_Dashboard
            // 
            this.tabCtl_Dashboard.Controls.Add(this.tab_Customer);
            this.tabCtl_Dashboard.Controls.Add(this.tab_Book);
            this.tabCtl_Dashboard.Controls.Add(this.tab_Rent);
            this.tabCtl_Dashboard.Controls.Add(this.tab_Popular_Customer);
            this.tabCtl_Dashboard.Controls.Add(this.tab_Popular_Books);
            this.tabCtl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.tabCtl_Dashboard.Name = "tabCtl_Dashboard";
            this.tabCtl_Dashboard.SelectedIndex = 0;
            this.tabCtl_Dashboard.Size = new System.Drawing.Size(1188, 295);
            this.tabCtl_Dashboard.TabIndex = 2;
            // 
            // tab_Customer
            // 
            this.tab_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tab_Customer.Controls.Add(this.DGV_Customer);
            this.tab_Customer.Location = new System.Drawing.Point(4, 25);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Customer.Size = new System.Drawing.Size(1180, 266);
            this.tab_Customer.TabIndex = 0;
            this.tab_Customer.Text = "Customer";
            // 
            // DGV_Customer
            // 
            this.DGV_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Customer.Location = new System.Drawing.Point(16, 19);
            this.DGV_Customer.Name = "DGV_Customer";
            this.DGV_Customer.RowHeadersWidth = 51;
            this.DGV_Customer.RowTemplate.Height = 24;
            this.DGV_Customer.Size = new System.Drawing.Size(1139, 230);
            this.DGV_Customer.TabIndex = 0;
            this.DGV_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_SelectRow);
            this.DGV_Customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_SelectRow);
            this.DGV_Customer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_SelectRow);
            this.DGV_Customer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Customer_SelectRow);
            // 
            // tab_Book
            // 
            this.tab_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tab_Book.Controls.Add(this.DGV_Books);
            this.tab_Book.Location = new System.Drawing.Point(4, 25);
            this.tab_Book.Name = "tab_Book";
            this.tab_Book.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Book.Size = new System.Drawing.Size(1180, 266);
            this.tab_Book.TabIndex = 1;
            this.tab_Book.Text = "Book";
            // 
            // DGV_Books
            // 
            this.DGV_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Books.Location = new System.Drawing.Point(16, 20);
            this.DGV_Books.Name = "DGV_Books";
            this.DGV_Books.RowHeadersWidth = 51;
            this.DGV_Books.RowTemplate.Height = 24;
            this.DGV_Books.Size = new System.Drawing.Size(1134, 221);
            this.DGV_Books.TabIndex = 0;
            this.DGV_Books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Books_SelectRow);
            this.DGV_Books.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Books_SelectRow);
            // 
            // tab_Rent
            // 
            this.tab_Rent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tab_Rent.Controls.Add(this.DGV_Rent);
            this.tab_Rent.Location = new System.Drawing.Point(4, 25);
            this.tab_Rent.Name = "tab_Rent";
            this.tab_Rent.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Rent.Size = new System.Drawing.Size(1180, 266);
            this.tab_Rent.TabIndex = 2;
            this.tab_Rent.Text = "Book Rented";
            // 
            // DGV_Rent
            // 
            this.DGV_Rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Rent.Location = new System.Drawing.Point(16, 7);
            this.DGV_Rent.Name = "DGV_Rent";
            this.DGV_Rent.RowHeadersWidth = 51;
            this.DGV_Rent.RowTemplate.Height = 24;
            this.DGV_Rent.Size = new System.Drawing.Size(1138, 253);
            this.DGV_Rent.TabIndex = 0;
            this.DGV_Rent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Rent_SelectRow);
            this.DGV_Rent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Rent_SelectRow);
            // 
            // pnl_Customer
            // 
            this.pnl_Customer.BackColor = System.Drawing.Color.Wheat;
            this.pnl_Customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Customer.Controls.Add(this.btn_DeleteCustomer);
            this.pnl_Customer.Controls.Add(this.btn_UpdateCustomer);
            this.pnl_Customer.Controls.Add(this.btn_AddCustomer);
            this.pnl_Customer.Controls.Add(this.txt_Address);
            this.pnl_Customer.Controls.Add(this.txt_Mobile);
            this.pnl_Customer.Controls.Add(this.txt_LastName);
            this.pnl_Customer.Controls.Add(this.txt_FirstName);
            this.pnl_Customer.Controls.Add(this.lbl_Address);
            this.pnl_Customer.Controls.Add(this.lbl_Mobile);
            this.pnl_Customer.Controls.Add(this.lbl_LastName);
            this.pnl_Customer.Controls.Add(this.lbl_FirstName);
            this.pnl_Customer.Controls.Add(this.lbl_CustomerDetails);
            this.pnl_Customer.Location = new System.Drawing.Point(12, 311);
            this.pnl_Customer.Name = "pnl_Customer";
            this.pnl_Customer.Size = new System.Drawing.Size(371, 225);
            this.pnl_Customer.TabIndex = 3;
            // 
            // btn_DeleteCustomer
            // 
            this.btn_DeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteCustomer.Location = new System.Drawing.Point(259, 148);
            this.btn_DeleteCustomer.Name = "btn_DeleteCustomer";
            this.btn_DeleteCustomer.Size = new System.Drawing.Size(101, 48);
            this.btn_DeleteCustomer.TabIndex = 11;
            this.btn_DeleteCustomer.Text = "Delete";
            this.btn_DeleteCustomer.UseVisualStyleBackColor = false;
            this.btn_DeleteCustomer.Click += new System.EventHandler(this.btn_DeleteCustomer_Click);
            // 
            // btn_UpdateCustomer
            // 
            this.btn_UpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_UpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UpdateCustomer.Location = new System.Drawing.Point(259, 91);
            this.btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            this.btn_UpdateCustomer.Size = new System.Drawing.Size(101, 48);
            this.btn_UpdateCustomer.TabIndex = 10;
            this.btn_UpdateCustomer.Text = "Update";
            this.btn_UpdateCustomer.UseVisualStyleBackColor = false;
            this.btn_UpdateCustomer.Click += new System.EventHandler(this.btn_UpdateCustomer_Click);
            // 
            // btn_AddCustomer
            // 
            this.btn_AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddCustomer.Location = new System.Drawing.Point(259, 36);
            this.btn_AddCustomer.Name = "btn_AddCustomer";
            this.btn_AddCustomer.Size = new System.Drawing.Size(101, 48);
            this.btn_AddCustomer.TabIndex = 9;
            this.btn_AddCustomer.Text = "Add";
            this.btn_AddCustomer.UseVisualStyleBackColor = false;
            this.btn_AddCustomer.Click += new System.EventHandler(this.btn_AddCustomer_Click);
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(109, 168);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(134, 22);
            this.txt_Address.TabIndex = 8;
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(109, 121);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(134, 22);
            this.txt_Mobile.TabIndex = 7;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(109, 81);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(134, 22);
            this.txt_LastName.TabIndex = 6;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(109, 36);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(134, 22);
            this.txt_FirstName.TabIndex = 5;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(4, 168);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(60, 17);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Location = new System.Drawing.Point(4, 121);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(49, 17);
            this.lbl_Mobile.TabIndex = 3;
            this.lbl_Mobile.Text = "Mobile";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(4, 81);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(76, 17);
            this.lbl_LastName.TabIndex = 2;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(4, 36);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(76, 17);
            this.lbl_FirstName.TabIndex = 1;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_CustomerDetails
            // 
            this.lbl_CustomerDetails.AutoSize = true;
            this.lbl_CustomerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerDetails.Location = new System.Drawing.Point(101, 0);
            this.lbl_CustomerDetails.Name = "lbl_CustomerDetails";
            this.lbl_CustomerDetails.Size = new System.Drawing.Size(156, 20);
            this.lbl_CustomerDetails.TabIndex = 0;
            this.lbl_CustomerDetails.Text = "Customer Details";
            // 
            // pnl_Book
            // 
            this.pnl_Book.BackColor = System.Drawing.Color.Wheat;
            this.pnl_Book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Book.Controls.Add(this.txt_Available);
            this.pnl_Book.Controls.Add(this.txt_Author);
            this.pnl_Book.Controls.Add(this.txt_BookName);
            this.pnl_Book.Controls.Add(this.lbl_Available);
            this.pnl_Book.Controls.Add(this.lbl_Author);
            this.pnl_Book.Controls.Add(this.lbl_BookName);
            this.pnl_Book.Controls.Add(this.btn_DeleteBook);
            this.pnl_Book.Controls.Add(this.lbl_Book);
            this.pnl_Book.Controls.Add(this.btn_UpdateBook);
            this.pnl_Book.Controls.Add(this.btn_AddBook);
            this.pnl_Book.Location = new System.Drawing.Point(413, 311);
            this.pnl_Book.Name = "pnl_Book";
            this.pnl_Book.Size = new System.Drawing.Size(378, 225);
            this.pnl_Book.TabIndex = 4;
            // 
            // txt_Available
            // 
            this.txt_Available.Location = new System.Drawing.Point(108, 160);
            this.txt_Available.Name = "txt_Available";
            this.txt_Available.Size = new System.Drawing.Size(134, 22);
            this.txt_Available.TabIndex = 21;
            // 
            // txt_Author
            // 
            this.txt_Author.Location = new System.Drawing.Point(108, 101);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(134, 22);
            this.txt_Author.TabIndex = 20;
            // 
            // txt_BookName
            // 
            this.txt_BookName.Location = new System.Drawing.Point(108, 50);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(134, 22);
            this.txt_BookName.TabIndex = 19;
            // 
            // lbl_Available
            // 
            this.lbl_Available.AutoSize = true;
            this.lbl_Available.Location = new System.Drawing.Point(3, 160);
            this.lbl_Available.Name = "lbl_Available";
            this.lbl_Available.Size = new System.Drawing.Size(65, 17);
            this.lbl_Available.TabIndex = 17;
            this.lbl_Available.Text = "Available";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Location = new System.Drawing.Point(3, 101);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(50, 17);
            this.lbl_Author.TabIndex = 16;
            this.lbl_Author.Text = "Author";
            // 
            // lbl_BookName
            // 
            this.lbl_BookName.AutoSize = true;
            this.lbl_BookName.Location = new System.Drawing.Point(3, 50);
            this.lbl_BookName.Name = "lbl_BookName";
            this.lbl_BookName.Size = new System.Drawing.Size(81, 17);
            this.lbl_BookName.TabIndex = 15;
            this.lbl_BookName.Text = "Book Name";
            // 
            // btn_DeleteBook
            // 
            this.btn_DeleteBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteBook.Location = new System.Drawing.Point(263, 148);
            this.btn_DeleteBook.Name = "btn_DeleteBook";
            this.btn_DeleteBook.Size = new System.Drawing.Size(101, 48);
            this.btn_DeleteBook.TabIndex = 14;
            this.btn_DeleteBook.Text = "Delete";
            this.btn_DeleteBook.UseVisualStyleBackColor = false;
            this.btn_DeleteBook.Click += new System.EventHandler(this.btn_DeleteBook_Click);
            // 
            // lbl_Book
            // 
            this.lbl_Book.AutoSize = true;
            this.lbl_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book.Location = new System.Drawing.Point(121, 0);
            this.lbl_Book.Name = "lbl_Book";
            this.lbl_Book.Size = new System.Drawing.Size(117, 20);
            this.lbl_Book.TabIndex = 1;
            this.lbl_Book.Text = "Book Details";
            // 
            // btn_UpdateBook
            // 
            this.btn_UpdateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_UpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_UpdateBook.Location = new System.Drawing.Point(263, 91);
            this.btn_UpdateBook.Name = "btn_UpdateBook";
            this.btn_UpdateBook.Size = new System.Drawing.Size(101, 48);
            this.btn_UpdateBook.TabIndex = 13;
            this.btn_UpdateBook.Text = "Update";
            this.btn_UpdateBook.UseVisualStyleBackColor = false;
            this.btn_UpdateBook.Click += new System.EventHandler(this.btn_UpdateBook_Click);
            // 
            // btn_AddBook
            // 
            this.btn_AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddBook.Location = new System.Drawing.Point(263, 36);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(101, 48);
            this.btn_AddBook.TabIndex = 12;
            this.btn_AddBook.Text = "Add";
            this.btn_AddBook.UseVisualStyleBackColor = false;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // pnl_Rent
            // 
            this.pnl_Rent.BackColor = System.Drawing.Color.Wheat;
            this.pnl_Rent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Rent.Controls.Add(this.datePicker_ReturnedDate);
            this.pnl_Rent.Controls.Add(this.lbl_ReturnedDate);
            this.pnl_Rent.Controls.Add(this.DatePicker_IssueDate);
            this.pnl_Rent.Controls.Add(this.lbl_IssueDate);
            this.pnl_Rent.Controls.Add(this.txt_BookName_Rented);
            this.pnl_Rent.Controls.Add(this.txt_CustName);
            this.pnl_Rent.Controls.Add(this.lbl_BookName_Rented);
            this.pnl_Rent.Controls.Add(this.btn_ReturnBook);
            this.pnl_Rent.Controls.Add(this.lbl_CustName);
            this.pnl_Rent.Controls.Add(this.lbl_Rent);
            this.pnl_Rent.Controls.Add(this.btn_IssueBook);
            this.pnl_Rent.Location = new System.Drawing.Point(818, 311);
            this.pnl_Rent.Name = "pnl_Rent";
            this.pnl_Rent.Size = new System.Drawing.Size(366, 225);
            this.pnl_Rent.TabIndex = 4;
            // 
            // datePicker_ReturnedDate
            // 
            this.datePicker_ReturnedDate.CustomFormat = "yyyy/mm/dd";
            this.datePicker_ReturnedDate.Location = new System.Drawing.Point(155, 140);
            this.datePicker_ReturnedDate.Name = "datePicker_ReturnedDate";
            this.datePicker_ReturnedDate.Size = new System.Drawing.Size(200, 22);
            this.datePicker_ReturnedDate.TabIndex = 27;
            // 
            // lbl_ReturnedDate
            // 
            this.lbl_ReturnedDate.AutoSize = true;
            this.lbl_ReturnedDate.Location = new System.Drawing.Point(12, 140);
            this.lbl_ReturnedDate.Name = "lbl_ReturnedDate";
            this.lbl_ReturnedDate.Size = new System.Drawing.Size(101, 17);
            this.lbl_ReturnedDate.TabIndex = 26;
            this.lbl_ReturnedDate.Text = "Returned Date";
            // 
            // DatePicker_IssueDate
            // 
            this.DatePicker_IssueDate.CustomFormat = "";
            this.DatePicker_IssueDate.Location = new System.Drawing.Point(155, 101);
            this.DatePicker_IssueDate.Name = "DatePicker_IssueDate";
            this.DatePicker_IssueDate.Size = new System.Drawing.Size(200, 22);
            this.DatePicker_IssueDate.TabIndex = 25;
            // 
            // lbl_IssueDate
            // 
            this.lbl_IssueDate.AutoSize = true;
            this.lbl_IssueDate.Location = new System.Drawing.Point(12, 101);
            this.lbl_IssueDate.Name = "lbl_IssueDate";
            this.lbl_IssueDate.Size = new System.Drawing.Size(75, 17);
            this.lbl_IssueDate.TabIndex = 24;
            this.lbl_IssueDate.Text = "Issue Date";
            // 
            // txt_BookName_Rented
            // 
            this.txt_BookName_Rented.Enabled = false;
            this.txt_BookName_Rented.Location = new System.Drawing.Point(155, 62);
            this.txt_BookName_Rented.Name = "txt_BookName_Rented";
            this.txt_BookName_Rented.Size = new System.Drawing.Size(134, 22);
            this.txt_BookName_Rented.TabIndex = 23;
            // 
            // txt_CustName
            // 
            this.txt_CustName.Enabled = false;
            this.txt_CustName.Location = new System.Drawing.Point(155, 26);
            this.txt_CustName.Name = "txt_CustName";
            this.txt_CustName.Size = new System.Drawing.Size(134, 22);
            this.txt_CustName.TabIndex = 13;
            // 
            // lbl_BookName_Rented
            // 
            this.lbl_BookName_Rented.AutoSize = true;
            this.lbl_BookName_Rented.Location = new System.Drawing.Point(12, 62);
            this.lbl_BookName_Rented.Name = "lbl_BookName_Rented";
            this.lbl_BookName_Rented.Size = new System.Drawing.Size(81, 17);
            this.lbl_BookName_Rented.TabIndex = 22;
            this.lbl_BookName_Rented.Text = "Book Name";
            // 
            // btn_ReturnBook
            // 
            this.btn_ReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ReturnBook.Location = new System.Drawing.Point(190, 172);
            this.btn_ReturnBook.Name = "btn_ReturnBook";
            this.btn_ReturnBook.Size = new System.Drawing.Size(165, 40);
            this.btn_ReturnBook.TabIndex = 23;
            this.btn_ReturnBook.Text = "Return Book";
            this.btn_ReturnBook.UseVisualStyleBackColor = false;
            this.btn_ReturnBook.Click += new System.EventHandler(this.btn_ReturnBook_Click);
            // 
            // lbl_CustName
            // 
            this.lbl_CustName.AutoSize = true;
            this.lbl_CustName.Location = new System.Drawing.Point(12, 26);
            this.lbl_CustName.Name = "lbl_CustName";
            this.lbl_CustName.Size = new System.Drawing.Size(109, 17);
            this.lbl_CustName.TabIndex = 12;
            this.lbl_CustName.Text = "Customer Name";
            // 
            // lbl_Rent
            // 
            this.lbl_Rent.AutoSize = true;
            this.lbl_Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rent.Location = new System.Drawing.Point(125, 0);
            this.lbl_Rent.Name = "lbl_Rent";
            this.lbl_Rent.Size = new System.Drawing.Size(114, 20);
            this.lbl_Rent.TabIndex = 2;
            this.lbl_Rent.Text = "Rent Details";
            // 
            // btn_IssueBook
            // 
            this.btn_IssueBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_IssueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IssueBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_IssueBook.Location = new System.Drawing.Point(15, 172);
            this.btn_IssueBook.Name = "btn_IssueBook";
            this.btn_IssueBook.Size = new System.Drawing.Size(153, 40);
            this.btn_IssueBook.TabIndex = 22;
            this.btn_IssueBook.Text = "Issue Book";
            this.btn_IssueBook.UseVisualStyleBackColor = false;
            this.btn_IssueBook.Click += new System.EventHandler(this.btn_IssueBook_Click);
            // 
            // btn_PopularCust
            // 
            this.btn_PopularCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_PopularCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PopularCust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_PopularCust.Location = new System.Drawing.Point(20, 555);
            this.btn_PopularCust.Name = "btn_PopularCust";
            this.btn_PopularCust.Size = new System.Drawing.Size(170, 41);
            this.btn_PopularCust.TabIndex = 5;
            this.btn_PopularCust.Text = "Popular Customer";
            this.btn_PopularCust.UseVisualStyleBackColor = false;
            // 
            // btn_PopularBook
            // 
            this.btn_PopularBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_PopularBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PopularBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_PopularBook.Location = new System.Drawing.Point(223, 555);
            this.btn_PopularBook.Name = "btn_PopularBook";
            this.btn_PopularBook.Size = new System.Drawing.Size(160, 41);
            this.btn_PopularBook.TabIndex = 6;
            this.btn_PopularBook.Text = "Popular Book";
            this.btn_PopularBook.UseVisualStyleBackColor = false;
            // 
            // btn_AllBorrowedBooks
            // 
            this.btn_AllBorrowedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AllBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllBorrowedBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AllBorrowedBooks.Location = new System.Drawing.Point(616, 555);
            this.btn_AllBorrowedBooks.Name = "btn_AllBorrowedBooks";
            this.btn_AllBorrowedBooks.Size = new System.Drawing.Size(170, 41);
            this.btn_AllBorrowedBooks.TabIndex = 8;
            this.btn_AllBorrowedBooks.Text = "Borrowed Books";
            this.btn_AllBorrowedBooks.UseVisualStyleBackColor = false;
            this.btn_AllBorrowedBooks.Click += new System.EventHandler(this.btn_AllBorrowedBooks_Click);
            // 
            // btn_AllBooks
            // 
            this.btn_AllBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AllBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AllBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AllBooks.Location = new System.Drawing.Point(413, 555);
            this.btn_AllBooks.Name = "btn_AllBooks";
            this.btn_AllBooks.Size = new System.Drawing.Size(170, 41);
            this.btn_AllBooks.TabIndex = 7;
            this.btn_AllBooks.Text = "All Books";
            this.btn_AllBooks.UseVisualStyleBackColor = false;
            this.btn_AllBooks.Click += new System.EventHandler(this.btn_AllBooks_Click);
            // 
            // tab_Popular_Customer
            // 
            this.tab_Popular_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tab_Popular_Customer.Controls.Add(this.DGV_PopularCustomer);
            this.tab_Popular_Customer.Location = new System.Drawing.Point(4, 25);
            this.tab_Popular_Customer.Name = "tab_Popular_Customer";
            this.tab_Popular_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Popular_Customer.Size = new System.Drawing.Size(1180, 266);
            this.tab_Popular_Customer.TabIndex = 3;
            this.tab_Popular_Customer.Text = "Popular Customer";
            // 
            // tab_Popular_Books
            // 
            this.tab_Popular_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tab_Popular_Books.Controls.Add(this.DGV_Popular_Movie);
            this.tab_Popular_Books.Location = new System.Drawing.Point(4, 25);
            this.tab_Popular_Books.Name = "tab_Popular_Books";
            this.tab_Popular_Books.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Popular_Books.Size = new System.Drawing.Size(1180, 266);
            this.tab_Popular_Books.TabIndex = 4;
            this.tab_Popular_Books.Text = "Popular Movie";
            // 
            // DGV_Popular_Movie
            // 
            this.DGV_Popular_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Popular_Movie.Location = new System.Drawing.Point(12, 15);
            this.DGV_Popular_Movie.Name = "DGV_Popular_Movie";
            this.DGV_Popular_Movie.RowHeadersWidth = 51;
            this.DGV_Popular_Movie.RowTemplate.Height = 24;
            this.DGV_Popular_Movie.Size = new System.Drawing.Size(1143, 235);
            this.DGV_Popular_Movie.TabIndex = 0;
            // 
            // DGV_PopularCustomer
            // 
            this.DGV_PopularCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PopularCustomer.Location = new System.Drawing.Point(12, 16);
            this.DGV_PopularCustomer.Name = "DGV_PopularCustomer";
            this.DGV_PopularCustomer.RowHeadersWidth = 51;
            this.DGV_PopularCustomer.RowTemplate.Height = 24;
            this.DGV_PopularCustomer.Size = new System.Drawing.Size(1131, 233);
            this.DGV_PopularCustomer.TabIndex = 0;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1201, 608);
            this.Controls.Add(this.btn_AllBorrowedBooks);
            this.Controls.Add(this.btn_AllBooks);
            this.Controls.Add(this.btn_PopularBook);
            this.Controls.Add(this.btn_PopularCust);
            this.Controls.Add(this.pnl_Book);
            this.Controls.Add(this.pnl_Rent);
            this.Controls.Add(this.pnl_Customer);
            this.Controls.Add(this.tabCtl_Dashboard);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Back);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.tabCtl_Dashboard.ResumeLayout(false);
            this.tab_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Customer)).EndInit();
            this.tab_Book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Books)).EndInit();
            this.tab_Rent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Rent)).EndInit();
            this.pnl_Customer.ResumeLayout(false);
            this.pnl_Customer.PerformLayout();
            this.pnl_Book.ResumeLayout(false);
            this.pnl_Book.PerformLayout();
            this.pnl_Rent.ResumeLayout(false);
            this.pnl_Rent.PerformLayout();
            this.tab_Popular_Customer.ResumeLayout(false);
            this.tab_Popular_Books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Popular_Movie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PopularCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TabControl tabCtl_Dashboard;
        private System.Windows.Forms.TabPage tab_Customer;
        private System.Windows.Forms.TabPage tab_Book;
        private System.Windows.Forms.TabPage tab_Rent;
        private System.Windows.Forms.Panel pnl_Customer;
        private System.Windows.Forms.Panel pnl_Book;
        private System.Windows.Forms.Panel pnl_Rent;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_CustomerDetails;
        private System.Windows.Forms.Label lbl_Book;
        private System.Windows.Forms.Label lbl_Rent;
        private System.Windows.Forms.Button btn_DeleteCustomer;
        private System.Windows.Forms.Button btn_UpdateCustomer;
        private System.Windows.Forms.Button btn_AddCustomer;
        private System.Windows.Forms.TextBox txt_Available;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label lbl_Available;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label lbl_BookName;
        private System.Windows.Forms.Button btn_DeleteBook;
        private System.Windows.Forms.Button btn_UpdateBook;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button btn_ReturnBook;
        private System.Windows.Forms.Button btn_IssueBook;
        private System.Windows.Forms.TextBox txt_CustName;
        private System.Windows.Forms.Label lbl_CustName;
        private System.Windows.Forms.DateTimePicker datePicker_ReturnedDate;
        private System.Windows.Forms.Label lbl_ReturnedDate;
        private System.Windows.Forms.DateTimePicker DatePicker_IssueDate;
        private System.Windows.Forms.Label lbl_IssueDate;
        private System.Windows.Forms.TextBox txt_BookName_Rented;
        private System.Windows.Forms.Label lbl_BookName_Rented;
        private System.Windows.Forms.Button btn_PopularCust;
        private System.Windows.Forms.Button btn_PopularBook;
        private System.Windows.Forms.Button btn_AllBorrowedBooks;
        private System.Windows.Forms.Button btn_AllBooks;
        private System.Windows.Forms.DataGridView DGV_Customer;
        private System.Windows.Forms.DataGridView DGV_Books;
        private System.Windows.Forms.DataGridView DGV_Rent;
        private System.Windows.Forms.TabPage tab_Popular_Customer;
        private System.Windows.Forms.DataGridView DGV_PopularCustomer;
        private System.Windows.Forms.TabPage tab_Popular_Books;
        private System.Windows.Forms.DataGridView DGV_Popular_Movie;
    }
}