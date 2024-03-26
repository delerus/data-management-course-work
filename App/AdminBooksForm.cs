using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_SQL_course_work
{
    public partial class AdminBooksForm : Form
    {
        public AdminBooksForm()
        {
            InitializeComponent();
            LoadBookList();
        }

        private void LoadBookList()
        {
            DataTable table1 = new DataTable();
            PublishingHouseDB database = new PublishingHouseDB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;

            string mainform_query = "SELECT * FROM `Books`;";

            database.openConnection();

            command = new MySqlCommand(mainform_query, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table1);

            reviewsList.DataSource = table1;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void reviewID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bookid = int.Parse(bookID.Text);
                string bookname = bookName.Text;
                int bookauthor = int.Parse(bookAuthor.Text);
                string bookgenre = bookGenre.Text;
                int bookamount = int.Parse(bookAmount.Text);
                decimal bookprice = decimal.Parse(bookPrice.Text);
                int bookyear = int.Parse(bookYear.Text);

                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=PublishingHouse"))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Books WHERE book_id = @bookId";
                    using (MySqlCommand command = new MySqlCommand(checkQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bookId", bookid);
                        int existingCount = Convert.ToInt32(command.ExecuteScalar());

                        if (existingCount > 0)
                        {
                            string updateQuery = "UPDATE Books SET quantity = quantity + @bookAmount WHERE book_id = @bookId";
                            using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@bookId", bookid);
                                updateCommand.Parameters.AddWithValue("@bookAmount", bookamount);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO Books (book_id, author_id, title, genre, quantity, price, year) VALUES (@bookId, @bookAuthor, @bookName, @bookGenre, @bookAmount, @bookPrice, @bookYear)";
                            using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@bookId", bookid);
                                insertCommand.Parameters.AddWithValue("@bookAuthor", bookauthor);
                                insertCommand.Parameters.AddWithValue("@bookName", bookname);
                                insertCommand.Parameters.AddWithValue("@bookGenre", bookgenre);
                                insertCommand.Parameters.AddWithValue("@bookAmount", bookamount);
                                insertCommand.Parameters.AddWithValue("@bookPrice", bookprice);
                                insertCommand.Parameters.AddWithValue("@bookYear", bookyear);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Книга успешно добавлена.");
                    LoadBookList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении книги: " + ex.Message);
                LoadBookList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = int.Parse(bookID.Text);

                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=PublishingHouse"))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Books WHERE book_id = @bookId";

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bookId", bookId);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Книга успешно удалена.");
                LoadBookList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении книги: " + ex.Message);
            }
        }
    }
}
