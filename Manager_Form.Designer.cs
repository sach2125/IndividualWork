namespace IndividualWork
{
    partial class Manager_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_reg_user = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_add_apartment = new System.Windows.Forms.Button();
            this.button_View_all_clients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_all = new System.Windows.Forms.ListBox();
            this.textBox_block_user = new System.Windows.Forms.TextBox();
            this.button_test_serial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_show_all_apartments = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_reg_user
            // 
            this.button_reg_user.Location = new System.Drawing.Point(6, 19);
            this.button_reg_user.Name = "button_reg_user";
            this.button_reg_user.Size = new System.Drawing.Size(240, 23);
            this.button_reg_user.TabIndex = 2;
            this.button_reg_user.Text = "Зарегистрировать клиента";
            this.button_reg_user.UseVisualStyleBackColor = true;
            this.button_reg_user.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_show_all_apartments);
            this.groupBox1.Controls.Add(this.button_add_apartment);
            this.groupBox1.Controls.Add(this.button_View_all_clients);
            this.groupBox1.Controls.Add(this.button_reg_user);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Администрирование";
            // 
            // button_add_apartment
            // 
            this.button_add_apartment.Location = new System.Drawing.Point(6, 77);
            this.button_add_apartment.Name = "button_add_apartment";
            this.button_add_apartment.Size = new System.Drawing.Size(240, 23);
            this.button_add_apartment.TabIndex = 4;
            this.button_add_apartment.Text = "Добавить квартиру в список";
            this.button_add_apartment.UseVisualStyleBackColor = true;
            this.button_add_apartment.Click += new System.EventHandler(this.button_add_apartment_Click);
            // 
            // button_View_all_clients
            // 
            this.button_View_all_clients.Location = new System.Drawing.Point(6, 48);
            this.button_View_all_clients.Name = "button_View_all_clients";
            this.button_View_all_clients.Size = new System.Drawing.Size(240, 23);
            this.button_View_all_clients.TabIndex = 3;
            this.button_View_all_clients.Text = "Отобразить всех клентов";
            this.button_View_all_clients.UseVisualStyleBackColor = true;
            this.button_View_all_clients.Click += new System.EventHandler(this.button_View_all_clients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список (выберите, чтобы изменить)";
            // 
            // listBox_all
            // 
            this.listBox_all.FormattingEnabled = true;
            this.listBox_all.Location = new System.Drawing.Point(21, 195);
            this.listBox_all.Name = "listBox_all";
            this.listBox_all.Size = new System.Drawing.Size(761, 95);
            this.listBox_all.TabIndex = 7;
            this.listBox_all.SelectedIndexChanged += new System.EventHandler(this.listBox_all_SelectedIndexChanged);
            // 
            // textBox_block_user
            // 
            this.textBox_block_user.Location = new System.Drawing.Point(299, 43);
            this.textBox_block_user.Name = "textBox_block_user";
            this.textBox_block_user.Size = new System.Drawing.Size(230, 20);
            this.textBox_block_user.TabIndex = 9;
            // 
            // button_test_serial
            // 
            this.button_test_serial.Location = new System.Drawing.Point(557, 43);
            this.button_test_serial.Name = "button_test_serial";
            this.button_test_serial.Size = new System.Drawing.Size(240, 23);
            this.button_test_serial.TabIndex = 10;
            this.button_test_serial.Text = "Заблокировать клиента";
            this.button_test_serial.UseVisualStyleBackColor = true;
            this.button_test_serial.Click += new System.EventHandler(this.button_test_serial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите логин клиента";
            // 
            // button_show_all_apartments
            // 
            this.button_show_all_apartments.Location = new System.Drawing.Point(6, 106);
            this.button_show_all_apartments.Name = "button_show_all_apartments";
            this.button_show_all_apartments.Size = new System.Drawing.Size(240, 23);
            this.button_show_all_apartments.TabIndex = 5;
            this.button_show_all_apartments.Text = "Отобразить все квартиры";
            this.button_show_all_apartments.UseVisualStyleBackColor = true;
            this.button_show_all_apartments.Click += new System.EventHandler(this.button_show_all_apartments_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 54);
            this.button1.TabIndex = 13;
            this.button1.Text = "Подтвердить оформление аренды";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 54);
            this.button2.TabIndex = 14;
            this.button2.Text = "Просмотреть договор на аренду";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_test_serial);
            this.Controls.Add(this.textBox_block_user);
            this.Controls.Add(this.listBox_all);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_reg_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_View_all_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_all;
        private System.Windows.Forms.Button button_add_apartment;
        private System.Windows.Forms.TextBox textBox_block_user;
        private System.Windows.Forms.Button button_test_serial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_show_all_apartments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}