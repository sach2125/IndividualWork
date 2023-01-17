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
    public partial class Client_Form : Form
    {
        public Client_Form()
        {
            InitializeComponent();
        }

        private void listBox_all_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Заявка подана");
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

        private void button_grade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оцените квартиру");
        }

        private void button_show_lease_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Договор");
        }
    }
}
