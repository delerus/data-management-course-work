using System;
using MySql.Data.MySqlClient;

public class OrderService
{
    private string connectionString; 

    public OrderService(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public bool CheckAvailableQuantity(int bookId, int amount)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT quantity FROM Books WHERE book_id = @bookId";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);

                    connection.Open();
                    int availableQuantity = Convert.ToInt32(command.ExecuteScalar());

                    return availableQuantity >= amount;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при проверке наличия книг на складе: " + ex.Message);
            return false;
        }
    }

    public void CreateOrder(int bookId, int amount, string log)
    {
        int userID = -1;

        try
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT user_id FROM USERS WHERE username = @username";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", log);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        userID = Convert.ToInt32(result);
                    }
                }

                string orderQuery = "INSERT INTO Orders (book_id, customer_id, quantity, status, order_date) VALUES (@bookId, @customer_id, @quantity, 'Pending', CURRENT_TIMESTAMP)";
                using (MySqlCommand command = new MySqlCommand(orderQuery, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);
                    command.Parameters.AddWithValue("@quantity", amount);
                    command.Parameters.AddWithValue("@customer_id", userID);
                    command.ExecuteNonQuery();
                }

                string updateBooksQuery = "UPDATE Books SET quantity = quantity - @amount WHERE book_id = @bookId";
                using (MySqlCommand command = new MySqlCommand(updateBooksQuery, connection))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при создании заказа: " + ex.Message);
        }
    }
}
