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

namespace exam
{
    public partial class Form5 : Form
    {
        public Form5()
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
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (maskedTextBox1.Text == ""))
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                string sql = "INSERT INTO application (id_service, id_employee, id_client, date_registration)" + "VALUES(@id_service, @id_employee, @id_client, @date_registration)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("id_service", textBox1.Text);
                command.Parameters.AddWithValue("id_employee", textBox2.Text);
                command.Parameters.AddWithValue("id_client", textBox3.Text);
                command.Parameters.AddWithValue("date_registration", maskedTextBox1.Text);
                command.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }
    }
}
