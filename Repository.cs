using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWork
{
    class Repository
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        public void Save_Client(Client client)
        {
            
            using (FileStream fileStream = new FileStream("List_users.txt", FileMode.Append))
            {
                
                {
                    binaryFormatter.Serialize(fileStream, client);
                }
            }
        }
        public void Save_Client_UP(Client client)
        {
 
            using (FileStream fileStream = new FileStream("List_users.txt", FileMode.Append))
            {

                {
                    binaryFormatter.Serialize(fileStream, client);
                }
            }
        }
        public object Read_all_clients() // Здесь я пытался создать отдельную функцию на вывод пользователей. Не получилось
        {
            using (FileStream fileStream_object = new FileStream("List_users.txt", FileMode.Open))
            {
                while (fileStream_object.Position != fileStream_object.Length)
                {
                Client all_clients = (Client)binaryFormatter.Deserialize(fileStream_object);
                    //all_clients.Equals("Петров");
                    //all_clients.change_mid_name("Воробьёв");
                    return all_clients.account_view();
                }
                return null;

            }
        }
        public void Save_Apartment(Apartment apartment)
        {

            using (FileStream fileStream = new FileStream("List_apartments.txt", FileMode.Append))
            {

                {
                    binaryFormatter.Serialize(fileStream, apartment);
                }
            }
        }

    }
}
