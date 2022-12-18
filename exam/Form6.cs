using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            button1.BackColor = Color.FromArgb(0, 112, 192);
            button2.BackColor = Color.FromArgb(0, 112, 192);
            form1 = new Form1();
        }
        Form1 form1;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (((textBox1.Text == "smanager") || (textBox1.Text == "manager")) && (textBox2.Text == "1111"))
            {
                form1.Show();
            }
            else
                MessageBox.Show("Неверный пароль или имя пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
