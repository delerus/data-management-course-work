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
    public partial class AdminReviewsForm : Form
    {
        public AdminReviewsForm()
        {
            InitializeComponent();
            LoadReviewList();
        }

        private void reviewID_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadReviewList()
        {
            DataTable table1 = new DataTable();
            PublishingHouseDB database = new PublishingHouseDB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;

            string mainform_query = "SELECT * FROM `reviews`;";

            database.openConnection();

            command = new MySqlCommand(mainform_query, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table1);

            reviewsList.DataSource = table1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем ID отзыва из выделенной строки в DataGridView
                int reviewId = int.Parse(reviewID.Text);

                // Удаляем отзыв из таблицы Review
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=PublishingHouse"))
                {
                    connection.Open();

                    string query = "DELETE FROM Reviews WHERE review_id = @reviewId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@reviewId", reviewId);
                        command.ExecuteNonQuery();
                    }
                }

                // Обновляем DataGridView
                LoadReviewList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении отзыва: " + ex.Message);
            }
        }
    }
}
