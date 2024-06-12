using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class UserPersonalAccount : Form
    {
        public UserPersonalAccount()
        {
            InitializeComponent();
        }


        private void UserPersonalAccount_Load(object sender, EventArgs e)
        {
            // данная строка кода позволяет загрузить данные в таблицу "demoDataSet1.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.demoDataSet1.Products);

        }


        private void назадToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            new Login().ShowDialog();
            Close();
        }
    }
}
