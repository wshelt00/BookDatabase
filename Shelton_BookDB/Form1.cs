using MySqlConnector;
using System.Data;
using System.Linq;

namespace Shelton_BookDB
{
    public partial class Form1 : Form
    {

        int count = 0;
        Queue<Catalouge> ca = new Queue<Catalouge>();
        Queue<Author> au = new Queue<Author>();

        DataTable BookCatalouge;
        DataTable customer;
        DataTable custP;
        DataTable checkIn;
        DataTable item;
        DataTable hist;
        DataTable book;

        DataDAO data;
        Book b;
        Customer c;

        public Form1()
        {
            InitializeComponent();

            data = new DataDAO();

            ca = data.getBookCata();
            au = data.getAuthor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            book = data.getAvailableBook();
            customer = data.getCustomer();
            BookCatalouge = data.getCatalouge();
            checkIn = data.getCheckIn();
            custP = data.getCustomer();

            BookGrid.DataSource = book;
            CustomerGrid.DataSource = customer;
            CataGrid.DataSource = BookCatalouge;
            CheckInGrid.DataSource = checkIn;
            CustPGrid.DataSource = custP;

            CustPGrid.Columns[0].HeaderText = "ID";
            CustPGrid.Columns[1].HeaderText = "Last Name";
            CustPGrid.Columns[2].HeaderText = "First Name";
            CustPGrid.Columns[0].ReadOnly = true;
            CustPGrid.Columns[1].ReadOnly = true;
            CustPGrid.Columns[2].ReadOnly = true;

            BookGrid.Columns[0].HeaderText = "ID";
            BookGrid.Columns[1].HeaderText = "Title";
            BookGrid.Columns[1].Width = 400;
            BookGrid.Columns[0].ReadOnly = true;
            BookGrid.Columns[1].ReadOnly = true;


            CustomerGrid.Columns[0].HeaderText = "ID";
            CustomerGrid.Columns[1].HeaderText = "Last Name";
            CustomerGrid.Columns[2].HeaderText = "First Name";
            CustomerGrid.Columns[0].ReadOnly = true;
            CustomerGrid.Columns[1].ReadOnly = true;
            CustomerGrid.Columns[2].ReadOnly = true;

            CataGrid.Columns[0].HeaderText = "ID";
            CataGrid.Columns[1].HeaderText = "Title";
            CataGrid.Columns[2].HeaderText = "Edition";
            CataGrid.Columns[3].HeaderText = "Publisher";
            CataGrid.Columns[4].HeaderText = "Subject";
            CataGrid.Columns[5].HeaderText = "ISBN";
            CataGrid.Columns[0].ReadOnly = true;
            CataGrid.Columns[1].ReadOnly = true;
            CataGrid.Columns[2].ReadOnly = true;
            CataGrid.Columns[3].ReadOnly = true;
            CataGrid.Columns[4].ReadOnly = true;
            CataGrid.Columns[5].ReadOnly = true;
            CataGrid.Columns[1].Width = 400;
            CataGrid.Columns[3].Width = 250;
            CataGrid.Columns[4].Width = 250;

            CheckInGrid.Columns[0].Visible = false;
            CheckInGrid.Columns[1].HeaderText = "Book";
            CheckInGrid.Columns[2].HeaderText = "Customer";
            CheckInGrid.Columns[1].Width = 300;
            CheckInGrid.Columns[2].Width = 150;
            CheckInGrid.Columns[1].ReadOnly = true;
            CheckInGrid.Columns[2].ReadOnly = true;
            CheckInGrid.Columns[3].ReadOnly = true;
            CheckInGrid.Columns[4].ReadOnly = true;

        }

        private void BookGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.BookGrid.Rows[e.RowIndex];

                string id = r.Cells[0].Value.ToString();
                string title = r.Cells[1].Value.ToString();

                b = new Book(id, title);

                BookTXT.Text = b.ToString();

            }

        }

        private void CustomerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.CustomerGrid.Rows[e.RowIndex];

                string id = r.Cells[0].Value.ToString();
                string lname = r.Cells[1].Value.ToString();
                string fname = r.Cells[2].Value.ToString();

                c = new Customer(id, lname, fname);

                CustTXT.Text = c.ToString();

            }

        }

        private void COBtn_Click(object sender, EventArgs e)
        {

            string str = b.ToString();
            string bsbstr = str.Substring(0, 1);

            string ctr = c.ToString();
            string csbtr = ctr.Substring(0, 1);

            int bid = Int32.Parse(bsbstr);
            int cid = Int32.Parse(csbtr);

            DateOnly dto = DateOnly.Parse(DTOut.Text.ToString());

            DateOnly mon = dto.AddMonths(1);

            data.saveCheckOut(bid, cid, dto, mon);

            RefreshBTN_Click(sender, e);

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            ResetBtn_Click(sender, e);

            string searchval = SearchBar.Text.ToUpper();

            IEnumerable<Catalouge> results =
                    from book in ca
                    orderby book.ID
                    select book;

            if (BookRB.Checked)
            {

                results =
                    from book in ca
                    where (book.title.ToString().ToUpper().Contains(searchval))
                    orderby book.title
                    select book;

            }
            else if (SubjectRB.Checked)
            {

                results =
                    from book in ca
                    where (book.subject.ToString().ToUpper().Contains(searchval))
                    orderby book.subject
                    select book;

            }
            else if (ISBNRB.Checked)
            {

                results =
                    from book in ca
                    where (book.isbn.ToString().ToUpper().Contains(searchval))
                    orderby book.isbn
                    select book;

            }

            CataGrid.DataSource = results.ToList();

            CataGrid.Columns[0].HeaderText = "ID";
            CataGrid.Columns[1].HeaderText = "Title";
            CataGrid.Columns[2].HeaderText = "Edition";
            CataGrid.Columns[3].HeaderText = "Publisher";
            CataGrid.Columns[4].HeaderText = "Subject";
            CataGrid.Columns[5].HeaderText = "ISBN";
            CataGrid.Columns[0].ReadOnly = true;
            CataGrid.Columns[1].ReadOnly = true;
            CataGrid.Columns[2].ReadOnly = true;
            CataGrid.Columns[3].ReadOnly = true;
            CataGrid.Columns[4].ReadOnly = true;
            CataGrid.Columns[5].ReadOnly = true;
            CataGrid.Columns[1].Width = 400;
            CataGrid.Columns[3].Width = 250;
            CataGrid.Columns[4].Width = 250;

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {

            string searchval = SearchBar.Text.ToUpper();

            IEnumerable<Catalouge> results =
                    from book in ca
                    orderby book.ID
                    select book;

            CataGrid.DataSource = results.ToList();

            CataGrid.Columns[0].HeaderText = "ID";
            CataGrid.Columns[1].HeaderText = "Title";
            CataGrid.Columns[2].HeaderText = "Edition";
            CataGrid.Columns[3].HeaderText = "Publisher";
            CataGrid.Columns[4].HeaderText = "Subject";
            CataGrid.Columns[5].HeaderText = "ISBN";
            CataGrid.Columns[0].ReadOnly = true;
            CataGrid.Columns[1].ReadOnly = true;
            CataGrid.Columns[2].ReadOnly = true;
            CataGrid.Columns[3].ReadOnly = true;
            CataGrid.Columns[4].ReadOnly = true;
            CataGrid.Columns[5].ReadOnly = true;
            CataGrid.Columns[1].Width = 400;
            CataGrid.Columns[3].Width = 250;
            CataGrid.Columns[4].Width = 250;

        }

        private void CataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var row = CataGrid.CurrentCell.RowIndex;

            if (row == 0)
            {

                MessageBox.Show(au.ElementAtOrDefault(0).ToString());

            }
            else if (row == 1)
            {

                MessageBox.Show(au.ElementAtOrDefault(1).ToString());

            }
            else if (row == 2)
            {

                MessageBox.Show(au.ElementAtOrDefault(2).ToString());

            }
            else if (row == 3)
            {

                MessageBox.Show(au.ElementAtOrDefault(3).ToString());

            }
            else if (row == 4)
            {

                MessageBox.Show(au.ElementAtOrDefault(4).ToString());

            }
            else if (row == 5)
            {

                MessageBox.Show(au.ElementAtOrDefault(5).ToString());

            }

        }

        private void CheckInBtn_Click(object sender, EventArgs e)
        {

            int cid = (int)CheckInGrid.CurrentRow.Cells[0].Value;

            DateOnly co = DateOnly.Parse(DTIn.Text.ToString());

            string str = BookInTXT.Text.ToString().Substring(0, 1);

            int bid = Int32.Parse(str);

            data.checkInBook(cid, bid, co);

            CheckRe_Click(sender, e);

        }

        private void CheckInGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.CheckInGrid.Rows[e.RowIndex];

                string book = r.Cells[1].Value.ToString();
                string cust = r.Cells[2].Value.ToString();

                BookInTXT.Text = book;
                CustomerInTXT.Text = cust;

            }

        }

        private void CheckRe_Click(object sender, EventArgs e)
        {

            data.getCheckIn();

        }

        private void RefreshBTN_Click(object sender, EventArgs e)
        {

            data.getAvailableBook();

        }

        private void UNKBtn_Click(object sender, EventArgs e)
        {

            int cid = (int)CustPGrid.CurrentRow.Cells[0].Value;

            string fname = CustPGrid.CurrentRow.Cells[2].Value.ToString();

            hist = data.getHist(cid);

            HistoryGrid.DataSource = hist;

            item = data.getCO(fname);

            ItemGrid.DataSource = item;

            HistoryGrid.Columns[0].ReadOnly = true;
            HistoryGrid.Columns[1].ReadOnly = true;
            HistoryGrid.Columns[2].ReadOnly = true;
            HistoryGrid.Columns[3].ReadOnly = true;
            HistoryGrid.Columns[0].Width = 275;
            HistoryGrid.Columns[0].HeaderText = "Book";
            HistoryGrid.Columns[1].HeaderText = "Check Out Date";
            HistoryGrid.Columns[2].HeaderText = "Due Date";
            HistoryGrid.Columns[3].HeaderText = "Check In Date";

            ItemGrid.Columns[0].Visible = false;
            ItemGrid.Columns[2].Visible = false;
            ItemGrid.Columns[1].HeaderText = "Book";
            ItemGrid.Columns[3].HeaderText = "Check Out Date";
            ItemGrid.Columns[4].HeaderText = "Due Date";
            ItemGrid.Columns[1].ReadOnly = true;
            ItemGrid.Columns[3].ReadOnly = true;
            ItemGrid.Columns[4].ReadOnly = true;
            ItemGrid.Columns[1].Width = 275;

            if (count <= 0)
            {

                MessageBox.Show("This button does the same as the value click does because I had no idea what purpose it was supposed to serve.");

                count++;

            }

            count++;

        }

        private void CustPGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            CheckInGrid.Columns[0].Visible = false;

            if (e.RowIndex >= 0)
            {

                DataGridViewRow r = this.CustPGrid.Rows[e.RowIndex];

                string id = r.Cells[0].Value.ToString();
                string lname = r.Cells[1].Value.ToString();
                string fname = r.Cells[2].Value.ToString();

                c = new Customer(id, lname, fname);

                UNKtxt.Text = c.ToString();

            }

            DataGridViewRow fn = this.CustPGrid.Rows[e.RowIndex];

            int cid = (int)CustPGrid.CurrentRow.Cells[0].Value;

            hist = data.getHist(cid);

            HistoryGrid.DataSource = hist;

            item = data.getCO(fn.Cells[2].Value.ToString());

            ItemGrid.DataSource = item;

            HistoryGrid.Columns[0].ReadOnly = true;
            HistoryGrid.Columns[1].ReadOnly = true;
            HistoryGrid.Columns[2].ReadOnly = true;
            HistoryGrid.Columns[3].ReadOnly = true;
            HistoryGrid.Columns[0].Width = 275;
            HistoryGrid.Columns[0].HeaderText = "Book";
            HistoryGrid.Columns[1].HeaderText = "Check Out Date";
            HistoryGrid.Columns[2].HeaderText = "Due Date";
            HistoryGrid.Columns[3].HeaderText = "Check In Date";

            ItemGrid.Columns[0].Visible = false;
            ItemGrid.Columns[2].Visible = false;
            ItemGrid.Columns[1].HeaderText = "Book";
            ItemGrid.Columns[3].HeaderText = "Check Out Date";
            ItemGrid.Columns[4].HeaderText = "Due Date";
            ItemGrid.Columns[1].ReadOnly = true;
            ItemGrid.Columns[3].ReadOnly = true;
            ItemGrid.Columns[4].ReadOnly = true;
            ItemGrid.Columns[1].Width = 275;

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) //DON'T REMOVE
        {

        }
    }
}