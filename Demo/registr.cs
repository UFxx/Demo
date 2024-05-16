using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Demo
{
    public partial class registr : Form
    {
        public registr()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button_registr_Click(object sender, EventArgs e)
        {


            string Name = textBoxName.Text;
            string Surname = textBoxSurname.Text;
            string Patronymic = textBoxPatronymic.Text;
            string Birthday = textBoxBirthday.Text;
            int PassportSeries = Convert.ToInt32(textBoxPassportSeries.Text);
            int PassportNumber = Convert.ToInt32(textBoxPassportNumber.Text);
            string Phone = textBoxPhone.Text;
            string Password = textBoxPassword.Text;
            string Login = textBoxLogin.Text;

            using (SqlConnection connection = new SqlConnection("Data Source = HOME-PC\\SQLEXPRESS; Initial Catalog = Demo; Integrated Security = True"))
            {
                connection.Open();

                string sql = "INSERT INTO Users (Name, Surname, Patronymic, Birthday, PassportSeries, PassportNumber, Phone, Password, Login) VALUES (@Name, @Surname, @Patronymic, @Birthday, @PassportSeries, @PassportNumber, @Phone, @Password, @Login)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Surname", Surname);
                command.Parameters.AddWithValue("@Patronymic", Patronymic);
                command.Parameters.AddWithValue("@Birthday", Birthday);
                command.Parameters.AddWithValue("@PassportSeries", PassportSeries);
                command.Parameters.AddWithValue("@PassportNumber", PassportNumber);
                command.Parameters.AddWithValue("@Phone", Phone);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Login", Login);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка регистрации: " + ex.Message);
                }

            }


        }

        private void registr_Load(object sender, EventArgs e)
        {

        }
    }
}
