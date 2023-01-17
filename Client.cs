using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork
{
    //Добавляем класс Клиент
    [Serializable]
    class Client
    {
        //private bool active_account;
        private string first_name;
        private string second_name;
        private string middle_name;
        private string birth_date;
        private long nubmer_tel;
        private string login;
        private string password;
        private bool active_account = true;

        public Client(string first_name, string second_name, string middle_name, string birth_date, long nubmer_tel, string login, string password)
        {
            this.first_name = first_name;
            this.second_name = second_name;
            this.middle_name = middle_name;
            this.birth_date = birth_date;
            this.nubmer_tel = nubmer_tel;
            this.login = login;
            this.password = password;
            this.active_account = true;
        }
        public bool ActiveAccount { get { return active_account;} }
        public void SetAccountFalse()
        {
            this.active_account = false;
        }
        public string account_view()
        {
            string status_account;
            if (this.active_account == true)
            {
                status_account = "УЗ включена";
            }
            else
            {
                status_account = "УЗ отключена";
            }
            return $"{this.second_name} {this.first_name} {this.middle_name}; Номер телефона: {this.nubmer_tel}; Дата рождения: {this.birth_date}; логин - {this.login}; пароль - {this.password}; {status_account}";
        }
        public string get_FIO()
        {
            return $"{this.second_name} {this.first_name} {this.middle_name} Заблокирован!";
        }
        public string get_login()
        {
            return this.login ;
        }
        public string get_password()
        {
            return this.password ;
        }
        public void change_mid_name(string mid_name)
        {
            this.middle_name = mid_name;
        }


        override
            public String ToString()
        {
            return $"Пользователь {this.second_name} {this.first_name[0]}. {this.middle_name[0]}. зарегистрирован";
        }
    }
}
