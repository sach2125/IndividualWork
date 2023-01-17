using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualWork
{
    public partial class Add_Apartment_Form : Form
    {
        public Add_Apartment_Form()
        {
            InitializeComponent();
        }

        private void button_add_apartment_Click(object sender, EventArgs e)
        {
            string addreess = textBox_address.Text;
            int ps = Convert.ToInt32(textBox_ps.Text);
            int cs = Convert.ToInt32(textBox_cs.Text);
            double chsum = Convert.ToDouble(textBox_chsum.Text);
            string desc = textBox_desc.Text;

            Apartment apartment = new Apartment(addreess,ps,cs,chsum,desc);
            Repository rep = new Repository();

            rep.Save_Apartment(apartment);
            label_rp.Text = apartment.ToString();
            label_rp.Visible = true;
        }
    }
}
