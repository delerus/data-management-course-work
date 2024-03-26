using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_SQL_course_work
{
    public partial class MainForm : Form
    {
        public string log { get; set; }
        public int userID { get; set; }

        public MainForm(string log)
        {
            InitializeComponent();
            this.log = log;
            LoadBookList();
        }

        private void LoadBookList()
        {
            DataTable table1 = new DataTable();
            PublishingHouseDB database = new PublishingHouseDB();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;

            string mainform_query = "SELECT * FROM `books`;";

            database.openConnection();

            command = new MySqlCommand(mainform_query, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table1);

            bookList.DataSource = table1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            // Получаем ID книги из текстового поля
            int book;
            if (!int.TryParse(bookID.Text, out book))
            {
                MessageBox.Show("Введите корректный ID книги.");
                return;
            }

            // Получаем количество книг из NumericUpDown
            int amount = (int)booksAmount.Value;

            // Создаем экземпляр сервиса заказов
            OrderService orderService = new OrderService("server=localhost;port=3306;username=root;password=;database=PublishingHouse");

            // Проверяем наличие книг на складе
            if (!orderService.CheckAvailableQuantity(book, amount))
            {
                MessageBox.Show("Недостаточное количество книг на складе.");
                return;
            }

            // Создаем заказ
            try
            {
                orderService.CreateOrder(book, amount, log);
                LoadBookList();
                MessageBox.Show("Заказ успешно создан.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании заказа: " + ex.Message);
            }
        }

        private void ordersCheckButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(log);
            ordersForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
