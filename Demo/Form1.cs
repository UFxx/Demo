using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        List<AgencyWorker> workers = new List<AgencyWorker>();
        List<Users> users = new List<Users>();
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        public void SelectWorkers()
        {
            // Соединение с БД
            sqlConnection = new SqlConnection("Data Source = KOMPUTER\\SQLEXPRESS; Initial Catalog = Demo; Integrated Security = True");
            sqlConnection.Open();

            // Запрос к БД
            sqlCommand = new SqlCommand("Select * From Workers", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows) 
            {
                while (sqlDataReader.Read())
                {
                    workers.Add(new AgencyWorker(Convert.ToString(sqlDataReader[10]), Convert.ToString(sqlDataReader[11])));
                }
            }

            sqlDataReader.Close();
        }

        public void SelectUsers()
        {
            // Соединение с БД
            sqlConnection = new SqlConnection("Data Source = KOMPUTER\\SQLEXPRESS; Initial Catalog = Demo; Integrated Security = True");
            sqlConnection.Open();

            // Запрос к БД
            sqlCommand = new SqlCommand("Select * From Users", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    users.Add(new Users(Convert.ToString(sqlDataReader[9]), Convert.ToString(sqlDataReader[10])));
                }
            }

            sqlDataReader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectWorkers();
            SelectUsers();
        }

        private void sumbit_button_Click(object sender, EventArgs e)
        {
            // Валидация поля ввода логина
            if (!string.IsNullOrEmpty(login_textbox.Text) && !string.IsNullOrWhiteSpace(login_textbox.Text) 
                && 
            // Валидация поля ввода пароля
                !string.IsNullOrEmpty(password_textbox.Text) && !string.IsNullOrWhiteSpace(password_textbox.Text))
                {
                    string login = login_textbox.Text;
                    string password = password_textbox.Text;
                    int tempForWorkers = 0;
                    int tempForUsers = 0;

                    // Перебор данных сотрудников
                    for(int i = 0; i < workers.Count; i++)
                    {
                        if (workers[i].Login == login && workers[i].Password == password) 
                        {
                            Hide();
                            WorkerPersonalAccount newForm = new WorkerPersonalAccount();
                            newForm.ShowDialog();
                            Close();
                        } else tempForWorkers++;
                    }

                    // Перебор данных клиентов
                    for (int i = 0; i < users.Count; i++)
                    {
                        if (users[i].Login == login && users[i].Password == password)
                        {
                            Hide();
                            UserPersonalAccount newForm = new UserPersonalAccount();
                            newForm.ShowDialog();
                            Close();
                        }
                        else tempForUsers++;
                    }

                    if (tempForWorkers == workers.Count && tempForUsers == users.Count)
                        {
                            MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
             else MessageBox.Show("Все данные должны быть заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            registr newForm = new registr();
            newForm.ShowDialog();
            Close();

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана Студентом 3-ИС Добровольским Дмитрием", "О программе", MessageBoxButtons.OK);
        }

        private void loginAsGuest_Click(object sender, EventArgs e)
        {
            Hide();
            new GuestForm().ShowDialog();
            Close();
        }
    }
}
