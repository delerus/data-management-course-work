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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
            String loginUser = loginBox.Text;
            String passwordUser = passBox.Text;

            PublishingHouseDB database = new PublishingHouseDB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Users` WHERE `username` = @uL AND `password` = @uP", database.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MainForm mainForm = new MainForm(table.Rows[0]["username"].ToString());
                this.Hide();

                if (loginUser == "admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    MessageBox.Show("Авторизован");
                }
                else
                {
                    mainForm.Show();
                }

            }

            else
                MessageBox.Show("Ошибка авторизации");
        }

    }

}
