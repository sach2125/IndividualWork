using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork
{
    //Добавляем абстрактный класс Аренда
    class Lease
    {
        private bool treaty; //Договор аренды оформлен или нет
        private string data_from; // Дата начала аренды 
        private string data_to; //Дата окончания аренды

        public Lease(bool treaty, string data_from, string data_to)
        {
            this.treaty = true;
            this.data_from = data_from;
            this.data_to = data_to;
        }
        public string Get_treaty()
        {
            string result;
            if (this.treaty == true)
            {
                result = "Договор оформлен";
            }
            else
            {
                result = "Договор не оформлен";
            }
            return $"{result} с {this.data_from} по {this.data_to}";
        }
    }
}
