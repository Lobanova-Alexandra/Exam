using System.Windows.Forms;

namespace exam
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnRes = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patron_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number_client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.id_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patron_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_service_app = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_employee_app = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_client_app = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ConnRes);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 74);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(456, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "ОО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Соединение с сервером:";
            // 
            // ConnRes
            // 
            this.ConnRes.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnRes.Location = new System.Drawing.Point(533, 18);
            this.ConnRes.Name = "ConnRes";
            this.ConnRes.Size = new System.Drawing.Size(221, 40);
            this.ConnRes.TabIndex = 2;
            this.ConnRes.Text = "Повторить подключение";
            this.ConnRes.UseVisualStyleBackColor = true;
            this.ConnRes.Click += new System.EventHandler(this.ConnRes_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(770, 16);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(108, 42);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Navto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 457);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button14);
            this.tabPage1.Controls.Add(this.button15);
            this.tabPage1.Controls.Add(this.button16);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(882, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заявки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(706, 64);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(168, 38);
            this.button13.TabIndex = 16;
            this.button13.Text = "Добавить";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(706, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(168, 38);
            this.button14.TabIndex = 15;
            this.button14.Text = "Удалить";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(706, 108);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(168, 38);
            this.button15.TabIndex = 14;
            this.button15.Text = "Изменить";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(706, 20);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(168, 38);
            this.button16.TabIndex = 13;
            this.button16.Text = "Обновить";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_application,
            this.id_service_app,
            this.id_employee_app,
            this.id_client_app,
            this.date_registration});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(700, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Услуги";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(706, 64);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(168, 38);
            this.button9.TabIndex = 12;
            this.button9.Text = "Добавить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(706, 152);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(168, 38);
            this.button10.TabIndex = 11;
            this.button10.Text = "Удалить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(706, 108);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(168, 38);
            this.button11.TabIndex = 10;
            this.button11.Text = "Изменить";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(706, 20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(168, 38);
            this.button12.TabIndex = 9;
            this.button12.Text = "Обновить";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_service,
            this.name_service,
            this.cost_service});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(700, 412);
            this.dataGridView3.TabIndex = 0;
            // 
            // id_service
            // 
            this.id_service.HeaderText = "id";
            this.id_service.MinimumWidth = 6;
            this.id_service.Name = "id_service";
            this.id_service.ReadOnly = true;
            this.id_service.Width = 125;
            // 
            // name_service
            // 
            this.name_service.HeaderText = "Наименование услуги";
            this.name_service.MinimumWidth = 6;
            this.name_service.Name = "name_service";
            this.name_service.Width = 125;
            // 
            // cost_service
            // 
            this.cost_service.HeaderText = "Стоимость услуги";
            this.cost_service.MinimumWidth = 6;
            this.cost_service.Name = "cost_service";
            this.cost_service.Width = 125;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(882, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Клиенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_client,
            this.name_client,
            this.sname_client,
            this.patron_client,
            this.phone_number_client,
            this.email});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(700, 418);
            this.dataGridView2.TabIndex = 9;
            // 
            // id_client
            // 
            this.id_client.HeaderText = "id";
            this.id_client.MinimumWidth = 6;
            this.id_client.Name = "id_client";
            this.id_client.ReadOnly = true;
            this.id_client.Width = 125;
            // 
            // name_client
            // 
            this.name_client.HeaderText = "Имя";
            this.name_client.MinimumWidth = 6;
            this.name_client.Name = "name_client";
            this.name_client.Width = 125;
            // 
            // sname_client
            // 
            this.sname_client.HeaderText = "Фамилия";
            this.sname_client.MinimumWidth = 6;
            this.sname_client.Name = "sname_client";
            this.sname_client.Width = 125;
            // 
            // patron_client
            // 
            this.patron_client.HeaderText = "Отчество";
            this.patron_client.MinimumWidth = 6;
            this.patron_client.Name = "patron_client";
            this.patron_client.Width = 125;
            // 
            // phone_number_client
            // 
            this.phone_number_client.HeaderText = "Номер телефона";
            this.phone_number_client.MinimumWidth = 6;
            this.phone_number_client.Name = "phone_number_client";
            this.phone_number_client.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(706, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 38);
            this.button5.TabIndex = 8;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(706, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 38);
            this.button6.TabIndex = 7;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(706, 108);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "Изменить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(706, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(168, 38);
            this.button8.TabIndex = 5;
            this.button8.Text = "Обновить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.dataGridViewEmployee);
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(882, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сотрудники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(706, 64);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 38);
            this.button4.TabIndex = 4;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(706, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(706, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_employee,
            this.name_employee,
            this.sname_employee,
            this.patron_employee,
            this.date_birth,
            this.phone_number});
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(700, 418);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // id_employee
            // 
            this.id_employee.HeaderText = "id";
            this.id_employee.MinimumWidth = 6;
            this.id_employee.Name = "id_employee";
            this.id_employee.ReadOnly = true;
            this.id_employee.Width = 125;
            // 
            // name_employee
            // 
            this.name_employee.HeaderText = "Имя";
            this.name_employee.MinimumWidth = 6;
            this.name_employee.Name = "name_employee";
            this.name_employee.Width = 125;
            // 
            // sname_employee
            // 
            this.sname_employee.HeaderText = "Фамилия";
            this.sname_employee.MinimumWidth = 6;
            this.sname_employee.Name = "sname_employee";
            this.sname_employee.Width = 125;
            // 
            // patron_employee
            // 
            this.patron_employee.HeaderText = "Отчество";
            this.patron_employee.MinimumWidth = 6;
            this.patron_employee.Name = "patron_employee";
            this.patron_employee.Width = 125;
            // 
            // date_birth
            // 
            this.date_birth.HeaderText = "Дата рождения";
            this.date_birth.MinimumWidth = 6;
            this.date_birth.Name = "date_birth";
            this.date_birth.Width = 125;
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Номер телефона";
            this.phone_number.MinimumWidth = 6;
            this.phone_number.Name = "phone_number";
            this.phone_number.Width = 125;
            // 
            // id_application
            // 
            this.id_application.HeaderText = "id";
            this.id_application.MinimumWidth = 6;
            this.id_application.Name = "id_application";
            this.id_application.ReadOnly = true;
            this.id_application.Width = 125;
            // 
            // id_service_app
            // 
            this.id_service_app.HeaderText = "id услуги";
            this.id_service_app.MinimumWidth = 6;
            this.id_service_app.Name = "id_service_app";
            this.id_service_app.Width = 125;
            // 
            // id_employee_app
            // 
            this.id_employee_app.HeaderText = "id сотрудника";
            this.id_employee_app.MinimumWidth = 6;
            this.id_employee_app.Name = "id_employee_app";
            this.id_employee_app.Width = 125;
            // 
            // id_client_app
            // 
            this.id_client_app.HeaderText = "id клиента";
            this.id_client_app.MinimumWidth = 6;
            this.id_client_app.Name = "id_client_app";
            this.id_client_app.Width = 125;
            // 
            // date_registration
            // 
            this.date_registration.HeaderText = "дата регистрации заявки";
            this.date_registration.MinimumWidth = 6;
            this.date_registration.Name = "date_registration";
            this.date_registration.ReadOnly = true;
            this.date_registration.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Navto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Label label1;
        private Button Exit;
        private Button ConnRes;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewEmployee;
        private DataGridViewTextBoxColumn id_employee;
        private DataGridViewTextBoxColumn name_employee;
        private DataGridViewTextBoxColumn sname_employee;
        private DataGridViewTextBoxColumn patron_employee;
        private DataGridViewTextBoxColumn date_birth;
        private DataGridViewTextBoxColumn phone_number;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn id_client;
        private DataGridViewTextBoxColumn name_client;
        private DataGridViewTextBoxColumn sname_client;
        private DataGridViewTextBoxColumn patron_client;
        private DataGridViewTextBoxColumn phone_number_client;
        private DataGridViewTextBoxColumn email;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn id_service;
        private DataGridViewTextBoxColumn name_service;
        private DataGridViewTextBoxColumn cost_service;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private DataGridViewTextBoxColumn id_application;
        private DataGridViewTextBoxColumn id_service_app;
        private DataGridViewTextBoxColumn id_employee_app;
        private DataGridViewTextBoxColumn id_client_app;
        private DataGridViewTextBoxColumn date_registration;
    }
}

