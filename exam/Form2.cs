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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(0, 112, 192);
            button1.BackColor = Color.FromArgb(0, 112, 192);
            button2.BackColor = Color.FromArgb(0, 112, 192);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") ||
                (maskedTextBox1.Text == "") || (maskedTextBox2.Text == ""))
            {
                MessageBox.Show("Заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                string sql = "INSERT INTO employee (name_employee, sname_employee, patron_employee, date_birth, phone_number)" + "VALUES(@name_employee, @sname_employee, @patron_employee, @date_birth, @phone_number)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.Parameters.AddWithValue("sname_employee", textBox1.Text);
                command.Parameters.AddWithValue("name_employee", textBox2.Text);
                command.Parameters.AddWithValue("patron_employee", textBox3.Text);
                command.Parameters.AddWithValue("date_birth", maskedTextBox1.Text);
                command.Parameters.AddWithValue("phone_number", maskedTextBox2.Text);
                command.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
