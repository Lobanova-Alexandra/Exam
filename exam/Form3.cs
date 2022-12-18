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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(189, 214, 238);
            button1.BackColor = Color.FromArgb(0, 112, 192);
            button2.BackColor = Color.FromArgb(0, 112, 192);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") ||
                (textBox4.Text == "") || (maskedTextBox2.Text == ""))
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                string sql = "INSERT INTO client (name_client, sname_client, patron_client, phone_number, email)" + "VALUES(@name_client, @sname_client, @patron_client, @phone_number, @email)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("name_client", textBox2.Text);
                command.Parameters.AddWithValue("sname_client", textBox1.Text);
                command.Parameters.AddWithValue("patron_client", textBox3.Text);
                command.Parameters.AddWithValue("email", textBox4.Text);
                command.Parameters.AddWithValue("phone_number", maskedTextBox2.Text);
                command.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }
    }
}
