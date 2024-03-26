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
    public partial class OrdersForm : Form
    {
        public string log { set; get; }
        public OrdersForm(string log)
        {
            InitializeComponent();
            this.log = log;
            LoadOrdersList(log);
        }

        private void LoadOrdersList(string username)
        {
            try
            {
                // Получаем user_id по имени пользователя из таблицы users
                int userId = GetUserIdByUsername(username);

                // Если user_id не найден, выходим из метода
                if (userId == -1)
                {
                    MessageBox.Show("Пользователь с таким именем не найден.");
                    return;
                }

                // Запрос для получения информации о заказах пользователя
                string query = "SELECT * FROM orders WHERE customer_id = @userId";

                // Создаем подключение к базе данных и выполняем запрос
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=PublishingHouse"))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            // Помещаем данные в DataGridView
                            ordersList.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке заказов: " + ex.Message);
            }
        }

        public int GetUserIdByUsername(string username)
        {
            int userId = -1; // Значение по умолчанию, если пользователь не найден

            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=PublishingHouse"))
                {
                    string query = "SELECT user_id FROM users WHERE username = @username";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении user_id: " + ex.Message);
            }

            return userId;
        }

        private void ordersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
