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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(0, 112, 192);
            button1.BackColor = Color.FromArgb(0, 112, 192);
            button2.BackColor = Color.FromArgb(0, 112, 192);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (maskedTextBox1.Text == ""))
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                string sql = "INSERT INTO service (name_service, cost_service)" + "VALUES(@name_service, @cost_service)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("name_service", textBox1.Text);
                command.Parameters.AddWithValue("cost_service", maskedTextBox1.Text);
                command.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }
    }
}
