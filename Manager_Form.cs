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
    public partial class Manager_Form : Form
    {
        public Manager_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Зарегистрировать клиента
        private void button1_Click_1(object sender, EventArgs e)
        {
            Registration_User_form man = new Registration_User_form();
            man.Show();
        }

        private void button_View_all_clients_Click(object sender, EventArgs e)
        {
            Repository rep = new Repository();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream_object = new FileStream("List_users.txt", FileMode.Open))
            {
                listBox_all.Items.Clear();
                while (fileStream_object.Position != fileStream_object.Length)
                {
                    Client all_clients = (Client)binaryFormatter.Deserialize(fileStream_object);
                    listBox_all.Items.Add(all_clients.account_view());
                }
            }
        }

        private void button_add_apartment_Click(object sender, EventArgs e)
        {
            Add_Apartment_Form add = new Add_Apartment_Form();
            add.Show();
        }

        private void button_block_user_Click(object sender, EventArgs e)
        {

            Repository rep = new Repository();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Client> all_client = new List<Client>();
            List<Client> change_client = new List<Client>(all_client);

        }

        private void button_test_serial_Click(object sender, EventArgs e)
        {

            Repository rep = new Repository();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            List<Client> all_client = new List<Client>();
            
            using (FileStream fileStream_object = new FileStream("List_users.txt", FileMode.OpenOrCreate))
            {
                while (fileStream_object.Position != fileStream_object.Length)
                {

                    Client all_clients = (Client)binaryFormatter.Deserialize(fileStream_object);
                    all_client.Add(all_clients);
                }
            }
            //создаём переменную, поля которой будем изменять
            var itemtoRemove = all_client.Single(r => r.get_login() == textBox_block_user.Text);
                itemtoRemove.SetAccountFalse();
            MessageBox.Show(itemtoRemove.get_FIO());
            //Добавляем ещё одну коллекцию, копию предыдущей, чтобы можно было перебрать форичем
            List<Client> change_client = new List<Client>(all_client);
            // создаём поток и сразу закрываем чтобы пересоздать файл
            using (FileStream fileStream = new FileStream("List_users.txt", FileMode.Create)) { }

                foreach (Client client in change_client)
            {
                rep.Save_Client(client);
            }

        }

        private void listBox_all_SelectedIndexChanged(object sender, EventArgs e)
        {
                MessageBox.Show($"Здесь вы могли бы изменить пользователя или квартиру, если бы я умел писать код...");

        }

        private void button_show_all_apartments_Click(object sender, EventArgs e)
        {
            Repository rep = new Repository();

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fileStream_object = new FileStream("List_apartments.txt", FileMode.Open))
            {
                listBox_all.Items.Clear();
                while (fileStream_object.Position != fileStream_object.Length)
                {
                    Apartment apartment = (Apartment)binaryFormatter.Deserialize(fileStream_object);
                    listBox_all.Items.Add(apartment.view_apartment());
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Одобрена заявка на аренду квартиры");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Договор на аренду");
        }
    }
}
