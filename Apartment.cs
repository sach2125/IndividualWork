using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork
{
    //Добалвяем класс Квартира
    [Serializable]
    class Apartment
    {
        //Добавляем свойства класса
        private string address;
        private int area;
        private int count_room;
        private double price_per_day;
        private string description;
        //private int grade; // оценка квартиры
        private bool status;

        //Добавляем конструктор
        public Apartment(string address, int area, int count_room, double price_per_day, string description)
        {
            this.address = address;
            this.area = area;
            this.count_room = count_room;
            this.price_per_day = price_per_day;
            this.description = description;
            this.status = true;
            //this.grade = grade;
        }
        //Добавляем методы
        public string view_apartment()
        {
            string _status;
            if (this.status == true)
            {
                _status = "Квартира свободна";
            }
            else
            {
                _status = "Квартира в аренде";
            }
            return $"Адрес: {this.address}; Площадь: {this.area}; Кол-во комнат: {this.count_room};Стоимость в сутки: {this.price_per_day};Описание: {this.description}; {_status}";
        }
        override
            public string ToString()
        {
            return $"Квартира по адресу {this.address} добавлена";
        }
    }
}
