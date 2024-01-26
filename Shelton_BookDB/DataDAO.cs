using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelton_BookDB
{
    internal class DataDAO
    {

        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataTable CustomerDS = new DataTable();
        DataTable BookDS = new DataTable();
        DataTable BookCataDS = new DataTable();
        DataTable checkIn = new DataTable();
        DataTable hist = new DataTable();
        DataTable CO = new DataTable();

        int count = 0;
        Queue<Catalouge> cat = new Queue<Catalouge>();
        Queue<Author> aut = new Queue<Author>();

        public DataDAO()
        {

            conn = new MySqlConnection();
            adapter = new MySqlDataAdapter();

            conn.ConnectionString =
               "server=74.117.171.73;" +
               "port=32010;" +
               "uid=dotnet05;" +
               "pwd=DOTnet258853;" +
               "database=dotnet05;";

        }

        public DataTable getCustomer()
        {

            CustomerDS.Clear();

            try
            {

                conn.Open();

                string sql = "SELECT Cust_ID, Cust_LName,Cust_FName FROM CUSTOMER;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                adapter.SelectCommand = cmd;
                adapter.Fill(CustomerDS);

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return CustomerDS;

        }

        public DataTable getAvailableBook()
        {

            BookDS.Clear();

            try
            {

                conn.Open();

                string sql = "SELECT Book_ID, Book_Title FROM BOOK WHERE Book_Status = 'OPEN';";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                adapter.SelectCommand = cmd;
                adapter.Fill(BookDS);

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return BookDS;

        }

        public DataTable getCatalouge() 
        {

            BookCataDS.Clear();

            try
            {

                conn.Open();

                string sql = "SELECT Book_ID,Book_Title,Book_Edition,Book_Publisher,Book_Subject,Book_ISBN FROM BOOK;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                adapter.SelectCommand = cmd;
                adapter.Fill(BookCataDS);

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return BookCataDS;

        }

        public void saveCheckOut(int bid, int cid, DateOnly co, DateOnly due)
        {

            try
            {

                conn.Open();

                string sql = "INSERT INTO CHECKOUT(Book_ID,Cust_ID,Check_Out_Date,Check_Due_Date) VALUES(?,?,?,?);";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Book_ID", bid);
                cmd.Parameters.AddWithValue("Cust_ID", cid);
                cmd.Parameters.AddWithValue("Check_Out_Date", co);
                cmd.Parameters.AddWithValue("Check_Due_Date", due);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book checked out");

                string sql2 = "UPDATE BOOK SET Book_Status='OUT' WHERE Book_ID =?;";

                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("Book_ID", bid);

                cmd2.ExecuteNonQuery();

                conn.Close();

            } catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();

            }

        }

        public void checkInBook(int cid, int bid, DateOnly co)
        {

            try
            {

                conn.Open();

                string sql = "UPDATE CHECKOUT SET Check_In_Date = ? WHERE Check_ID = ?;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Check_In_Date", co);
                cmd.Parameters.AddWithValue("Check_ID", cid);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book checked in");

                string sql2 = "UPDATE BOOK SET Book_Status='OPEN' WHERE Book_ID = ?;";

                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                cmd2.Parameters.AddWithValue("Book_ID", bid);

                cmd2.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();

            }

        }

        public Queue<Catalouge> getBookCata() 
        {

            count = getRowCount();

            conn.Open();

            string sql = "SELECT Book_ID,Book_Title,Book_Edition,Book_Publisher,Book_Subject,Book_ISBN FROM BOOK;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {

                cat.Enqueue(new Catalouge(read.GetInt32((read.GetOrdinal("Book_ID"))), read.GetString(read.GetOrdinal("Book_Title")), read.GetString(read.GetOrdinal("Book_Edition")), read.GetString(read.GetOrdinal("Book_Publisher")), read.GetString(read.GetOrdinal("Book_Subject")), read.GetString(read.GetOrdinal("Book_ISBN"))));

                if (cat.Count > count)
                {
                    cat.Dequeue();
                }

            }

            conn.Close();

            read.Close();

            return cat;

        } 

        public int getRowCount()
        {

            conn.Open();

            string sql = "SELECT COUNT(Book_ID) FROM BOOK;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {

                count = Int32.Parse(read.GetInt32(0).ToString());

            }

            conn.Close();

            read.Close();

            return count;

        }

        public Queue<Author> getAuthor()
        {

            count = getAuthorCount();

            conn.Open();

            string sql = "SELECT * FROM AUTHOR;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {

                aut.Enqueue(new Author(read.GetInt32((read.GetOrdinal("Auth_ID"))), read.GetString(read.GetOrdinal("Auth_FName")), read.GetString(read.GetOrdinal("Auth_LName"))));

                if (aut.Count > count)
                {
                    aut.Dequeue();
                }

            }

            conn.Close();

            read.Close();

            return aut;

        }

        public int getAuthorCount()
        {

            conn.Open();

            string sql = "SELECT COUNT(Auth_ID) FROM AUTHOR;";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {

                count = Int32.Parse(read.GetInt32(0).ToString());

            }

            conn.Close();

            read.Close();

            return count;

        }

        public DataTable getCheckIn()
        {

            checkIn.Clear();

            try
            {

                conn.Open();

                string sql = "SELECT CH.Check_ID, CONCAT(B.Book_ID,'-',B.Book_Title), CONCAT(C.Cust_ID,'-',C.Cust_LName,' ', C.Cust_FName), CH.Check_Out_Date,CH.Check_Due_Date FROM CHECKOUT CH JOIN BOOK B ON CH.Book_ID = B.Book_ID JOIN CUSTOMER C ON CH.Cust_ID = C.Cust_ID WHERE CH.Check_In_Date IS NULL;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                adapter.SelectCommand = cmd;
                adapter.Fill(checkIn);

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return checkIn;

        }

        public DataTable getHist(int cid)
        {

            hist.Clear();

            try
            {

                conn.Open();

                string sql = "SELECT CONCAT(B.Book_ID,'-',B.Book_Title) AS 'BOOK', CH.Check_Out_Date, CH.Check_Due_Date, CH.Check_In_Date FROM CHECKOUT CH JOIN BOOK B ON CH.Book_ID = B.Book_ID WHERE CH.Cust_ID=?;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Cust_ID",cid);

                cmd.ExecuteNonQuery();

                adapter.SelectCommand = cmd; 
                adapter.Fill(hist);

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return hist;

        }

        public DataTable getCO(string fname)
        {

            CO.Clear();

            try
            {

                conn.Open();

                string sql = "SELECT CH.Check_ID, CONCAT(B.Book_ID,'-',B.Book_Title), CONCAT(C.Cust_ID,'-',C.Cust_LName,' ', C.Cust_FName), CH.Check_Out_Date,CH.Check_Due_Date FROM CHECKOUT CH JOIN BOOK B ON CH.Book_ID = B.Book_ID JOIN CUSTOMER C ON CH.Cust_ID = C.Cust_ID WHERE CH.Check_In_Date IS NULL AND C.Cust_FName = ?;";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("Cust_Fname", fname);

                cmd.ExecuteNonQuery();

                adapter.SelectCommand = cmd; 
                adapter.Fill(CO);

                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conn.Close();
            }

            return CO;

        }

    } 
}
