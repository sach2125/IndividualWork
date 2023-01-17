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
    public partial class Registration_User_form : Form
    {
        public Registration_User_form()
        {
            InitializeComponent();
        }

        private void button_reg_client_Click(object sender, EventArgs e)
        {
            string second_name = textBox_client_second_name.Text;
            string first_name = textBox_client_first_name.Text;
            string mid_name = textBox_client_mid_name.Text;
            string birth_date = textBox_client_birth_date.Text;
            long number_telephone = Convert.ToInt64(textBox_number_telephone.Text);
            string login = textBox_client_login.Text;
            string password = textBox_client_password.Text;

            Client client = new Client(first_name, second_name, mid_name, birth_date, number_telephone, login, password);
            Repository rep = new Repository();

            label_register_client.Text = client.ToString();
            label_register_client.Visible =true;

            rep.Save_Client(client);
        }
    }
}
