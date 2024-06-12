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

namespace Demo
{
    public partial class WorkerPersonalAccount : Form
    {
        public WorkerPersonalAccount()
        {
            InitializeComponent();
        }

        private void WorkerPersonalAccount_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demoDataSet2.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.demoDataSet2.Products);

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            string productName = productNameTextBox.Text;
            string productCategory = productCategoryTextBox.Text;
            string productDescription = productDescriptionTextBox.Text;
               // Добавляем товар в таблицу
            using (SqlConnection connection = new SqlConnection("Data Source = KOMPUTER\\SQLEXPRESS; Initial Catalog = Demo; Integrated Security = True"))
            {
                connection.Open();

                string sql = "INSERT INTO Products (ProductDescription, ProductName, ProductCategory) VALUES (@ProductDescription, @ProductName, @ProductCategory )";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ProductDescription", productDescription);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@ProductCategory", productCategory);
                // Обработка ошибки, если нет ошибки, то выводим окно "Товар добавлен!"
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Товар добавлен!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка регистрации: " + ex.Message);
                }
                dataGridView1 = new DataGridView();
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            string deleteProductID = deleteProductTextbox.Text;

            using (SqlConnection connection = new SqlConnection("Data Source = KOMPUTER\\SQLEXPRESS; Initial Catalog = Demo; Integrated Security = True"))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Products WHERE ID_product = @ID", connection);
                sqlCommand.Parameters.AddWithValue("@ID", deleteProductID);
                // Опять обработка ошибки
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Товар удален!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка регистрации: " + ex.Message);
                }
            }
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().ShowDialog();
            Close();
        }
    }
}
