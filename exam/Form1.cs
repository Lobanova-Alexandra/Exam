using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace exam
{
    public partial class Form1 : Form
    {

        public Form1()
        {
           
            InitializeComponent();
            tabControl1.Enabled = false;
            DialogResult check = MessageBox.Show("Войти под пользователем Старший менеджер? Если НЕТ, то будет выполнен вход под пользователем Менеджер","Выберите пользователя", MessageBoxButtons.YesNo);

            // Настройка стиля
            panel1.BackColor = Color.FromArgb(189, 214, 238);
            Exit.BackColor = Color.FromArgb(0, 112, 192);
            ConnRes.BackColor = Color.FromArgb(0, 112, 192);
            dataGridViewEmployee.BackgroundColor = Color.FromArgb(189, 214, 238);
            dataGridView2.BackgroundColor = Color.FromArgb(189, 214, 238);
            dataGridView3.BackgroundColor = Color.FromArgb(189, 214, 238);
            dataGridView1.BackgroundColor = Color.FromArgb(189, 214, 238);

            if (check == System.Windows.Forms.DialogResult.Yes) { tabControl1.Enabled = true; }

            if (check == System.Windows.Forms.DialogResult.No)
            {
                button10.Visible = false;
                button10.Enabled = false;
                button9.Visible = false;
                button9.Enabled = false;
                button11.Visible = false;
                button11.Enabled = false;
                button5.Visible = false;
                button5.Enabled = false;
                button6.Visible = false;
                button6.Enabled = false;
                button7.Visible = false;
                button7.Enabled = false;
                button2.Visible = false;
                button2.Enabled = false;
                button3.Visible = false;
                button3.Enabled = false;
                button4.Visible = false;
                button4.Enabled = false;
            }

            //Проверка подключения
            string connect = "server=localhost; user=root; database=exam;";
            MySqlConnection conn = new MySqlConnection(connect);
            try
            {
                conn.Open();
                label3.ForeColor = Color.Green;
                label3.Text = "OK";
                conn.Close();
                tabControl1.Enabled = true;
                
            }
            catch
            {
                tabControl1.Enabled = false;
                label3.ForeColor = Color.Red;
                label3.Text = "NO";
                DialogResult res = MessageBox.Show("Не удалось подключиться к серверу. Проверьте соединение", "Ошибка", MessageBoxButtons.OK);
            }
            
            
            conn.Open();
            LoadApp(conn);
            LoadClient(conn);
            LoadEmployee(conn);
            LoadService(conn);
            conn.Close();
        }

        //кнопка повторить подключение
        private void ConnRes_Click(object sender, EventArgs e)
        {
            string connect = "server=localhost; user=root; database=exam;";
            MySqlConnection conn = new MySqlConnection(connect);
            try
            {
                conn.Open();
                label3.ForeColor = Color.Green;
                label3.Text = "OK";
                conn.Close();
                tabControl1.Enabled = true;
            }
            catch
            {
                tabControl1.Enabled = false;
                label3.ForeColor = Color.Red;
                label3.Text = "NO";
                DialogResult res = MessageBox.Show("Не удалось подключиться к серверу. Проверьте соединение", "Ошибка", MessageBoxButtons.OK);
            }
        }

        //кнопка выход
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //загрузка сотрудников
        private void LoadEmployee(MySqlConnection conn)
        {
            dataGridViewEmployee.Rows.Clear();
            string st = "SELECT * FROM employee";
            MySqlCommand command = new MySqlCommand(st, conn);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                dataGridViewEmployee.Rows.Add(s);
        }

        //проверка подключеия
        public bool check()
        {
            bool c = true;
            string connect = "server=localhost; user=root; database=exam;";
            MySqlConnection conn = new MySqlConnection(connect);
            try
            {
                conn.Open();
                label3.ForeColor = Color.Green;
                label3.Text = "OK";
                conn.Close();
                tabControl1.Enabled = true;

            }
            catch
            {
                tabControl1.Enabled = false;
                label3.ForeColor = Color.Red;
                label3.Text = "NO";
                DialogResult res = MessageBox.Show("Не удалось подключиться к серверу. Проверьте соединение", "Ошибка", MessageBoxButtons.OK);
                c = false;
            }
            return c;
        }

        //загрузка сотрудников
        private void button1_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                LoadEmployee(conn);
                conn.Close();
            }
        }
        
        //добавление сотрудника
        private void button4_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }


        //изменение сотрудника
        private void button2_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridViewEmployee.CurrentRow.Cells["id_employee"].Value.ToString();
                if (this.dataGridViewEmployee.CurrentCell.Value == null) { MessageBox.Show($"Введите корректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    DialogResult check = MessageBox.Show($"Вы хотите изменить запись {str}?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (check == System.Windows.Forms.DialogResult.Yes)
                    {
                        MySqlConnection conn = new MySqlConnection(connect);
                        conn.Open();
                        string s = this.dataGridViewEmployee.CurrentCell.OwningColumn.Name.ToString();
                        string sql = $"UPDATE employee SET {s} = @new WHERE employee.id_employee = @num";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.Add(new MySqlParameter("@new", this.dataGridViewEmployee.CurrentCell.Value));
                        command.Parameters.Add(new MySqlParameter("@num", this.dataGridViewEmployee.CurrentRow.Cells["id_employee"].Value));
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Запись {str} успешно изменена", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEmployee(conn);
                        conn.Close();
                    }
                }
            }
        }

        //удаление сотрудника
        private void button3_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridViewEmployee.CurrentRow.Cells["id_employee"].Value.ToString();
                DialogResult check = MessageBox.Show($"Вы хотите удалить запись {str}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection(connect);
                    conn.Open();
                    string sql = "DELETE FROM employee WHERE id_employee = @num";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add(new MySqlParameter("@num", this.dataGridViewEmployee.CurrentRow.Cells["id_employee"].Value));
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Запись {str} успешно удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployee(conn);
                    conn.Close();
                }
            }
        }

        //загрузка клиентов
        private void LoadClient(MySqlConnection conn)
        {
            dataGridView2.Rows.Clear();
            string st = "SELECT * FROM client";
            MySqlCommand command = new MySqlCommand(st, conn);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
        }

        //обновление клиентов
        private void button8_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                LoadClient(conn);
                conn.Close();
            }
        }

        //добавление клиента
        private void button5_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                Form3 newForm = new Form3();
                newForm.Show();
            }
        }

        //изменение клиента
        private void button7_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridView2.CurrentRow.Cells["id_client"].Value.ToString();
                if (this.dataGridView2.CurrentCell.Value == null) { MessageBox.Show($"Введите корректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    DialogResult check = MessageBox.Show($"Вы хотите изменить запись {str}?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (check == System.Windows.Forms.DialogResult.Yes)
                    {
                        MySqlConnection conn = new MySqlConnection(connect);
                        conn.Open();
                        string s = this.dataGridView2.CurrentCell.OwningColumn.Name.ToString();
                        string sql = $"UPDATE client SET {s} = @new WHERE client.id_client = @num";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.Add(new MySqlParameter("@new", this.dataGridView2.CurrentCell.Value));
                        command.Parameters.Add(new MySqlParameter("@num", this.dataGridView2.CurrentRow.Cells["id_client"].Value));
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Запись {str} успешно изменена", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClient(conn);
                        conn.Close();
                    }
                }
            }
        }

        //удаление клиента
        private void button6_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridView2.CurrentRow.Cells["id_client"].Value.ToString();
                DialogResult check = MessageBox.Show($"Вы хотите удалить запись {str}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection(connect);
                    conn.Open();
                    string sql = "DELETE FROM client WHERE id_client = @num";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add(new MySqlParameter("@num", this.dataGridView2.CurrentRow.Cells["id_client"].Value));
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Запись {str} успешно удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadClient(conn);
                    conn.Close();
                }
            }
        }

        //загрузка клиентов
        private void LoadService(MySqlConnection conn)
        {
            dataGridView3.Rows.Clear();
            string st = "SELECT * FROM service";
            MySqlCommand command = new MySqlCommand(st, conn);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);
        }

        //обновление услуг
        private void button12_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                LoadService(conn);
                conn.Close();
            }
        }

        //добавление услуг
        private void button9_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                Form4 newForm = new Form4();
                newForm.Show();
            }
        }

        //изменение услуг
        private void button11_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridView3.CurrentRow.Cells["id_service"].Value.ToString();
                if (this.dataGridView3.CurrentCell.Value == null) { MessageBox.Show($"Введите корректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    DialogResult check = MessageBox.Show($"Вы хотите изменить запись {str}?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (check == System.Windows.Forms.DialogResult.Yes)
                    {
                        MySqlConnection conn = new MySqlConnection(connect);
                        conn.Open();
                        string s = this.dataGridView3.CurrentCell.OwningColumn.Name.ToString();
                        string sql = $"UPDATE service SET {s} = @new WHERE service.id_service = @num";
                        MySqlCommand command = new MySqlCommand(sql, conn);
                        command.Parameters.Add(new MySqlParameter("@new", this.dataGridView3.CurrentCell.Value));
                        command.Parameters.Add(new MySqlParameter("@num", this.dataGridView3.CurrentRow.Cells["id_service"].Value));
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Запись {str} успешно изменена", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadClient(conn);
                        conn.Close();
                    }
                }
            }
        }

        //удаление услуги
        private void button10_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridView3.CurrentRow.Cells["id_service"].Value.ToString();
                DialogResult check = MessageBox.Show($"Вы хотите удалить запись {str}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection(connect);
                    conn.Open();
                    string sql = "DELETE FROM service WHERE id_service = @num";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add(new MySqlParameter("@num", this.dataGridView3.CurrentRow.Cells["id_service"].Value));
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Запись {str} успешно удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadService(conn);
                    conn.Close();
                }
            }
        }

        //загрущка заявок
        private void LoadApp(MySqlConnection conn)
        {
            dataGridView1.Rows.Clear();
            string st = "SELECT * FROM application";
            MySqlCommand command = new MySqlCommand(st, conn);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[5]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        //обновление заявок
        private void button16_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                MySqlConnection conn = new MySqlConnection(connect);
                conn.Open();
                LoadApp(conn);
                conn.Close();
            }
        }

        //добавление заявки
        private void button13_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                Form5 newForm = new Form5();
                newForm.Show();
            }
        }

        //изменение заявки
        private void button15_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridView1.CurrentRow.Cells["id_application"].Value.ToString();
                if (this.dataGridView1.CurrentCell.Value == null) { MessageBox.Show($"Введите корректное значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else
                {
                    if ((int.TryParse(this.dataGridView1.CurrentCell.Value.ToString(), out int numericValue) == false) || (Int32.Parse(this.dataGridView1.CurrentCell.Value.ToString()) <= 0)) { MessageBox.Show($"Введите положительное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    else
                    {
                        DialogResult check = MessageBox.Show($"Вы хотите изменить запись {str}?", "Изменение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (check == System.Windows.Forms.DialogResult.Yes)
                        {
                            MySqlConnection conn = new MySqlConnection(connect);
                            conn.Open();
                            string s = this.dataGridView1.CurrentCell.OwningColumn.Name.ToString();
                            string sql = $"UPDATE application SET {s} = @new WHERE application.id_application = @num";
                            MySqlCommand command = new MySqlCommand(sql, conn);
                            command.Parameters.Add(new MySqlParameter("@new", this.dataGridView1.CurrentCell.Value));
                            command.Parameters.Add(new MySqlParameter("@num", this.dataGridView1.CurrentRow.Cells["id_application"].Value));
                            command.ExecuteNonQuery();
                            MessageBox.Show($"Запись {str} успешно изменена", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadClient(conn);
                            conn.Close();
                        }
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                string connect = "server=localhost; user=root; database=exam;";
                string str = this.dataGridView1.CurrentRow.Cells["id_application"].Value.ToString();
                DialogResult check = MessageBox.Show($"Вы хотите удалить запись {str}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (check == System.Windows.Forms.DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection(connect);
                    conn.Open();
                    string sql = "DELETE FROM application WHERE id_application = @num";
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    command.Parameters.Add(new MySqlParameter("@num", this.dataGridView1.CurrentRow.Cells["id_application"].Value));
                    command.ExecuteNonQuery();
                    MessageBox.Show($"Запись {str} успешно удалена", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadApp(conn);
                    conn.Close();
                }
            }
        }
    }
}
