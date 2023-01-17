using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualWork
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button_loginasmanager_Click(object sender, EventArgs e)
        {
            if (textBox_login.Text == "manager" && textBox_password.Text == "123")
            {
                Manager_Form manager = new Manager_Form();
                manager.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Введён неверный логин или пароль!");
            }
        }

        private void button_login_as_client_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream_object = new FileStream("List_users.txt", FileMode.Open))
            {
                bool view_form;
                view_form = false;

                while (fileStream_object.Position != fileStream_object.Length)
                {
                    Client all_clients = (Client)binaryFormatter.Deserialize(fileStream_object);
                    string login = all_clients.get_login();
                    string password = all_clients.get_password();
                    if (textBox_login.Text == login && textBox_password.Text == password && all_clients.ActiveAccount == true)
                    {
                        view_form = true;
                    }
                }
                if (view_form == true)
                {
                    Client_Form client = new Client_Form();
                    client.Show();
                }
                else
                {
                    MessageBox.Show("Введён неверный логин или пароль!");
                }
            }
        }
    }
}
