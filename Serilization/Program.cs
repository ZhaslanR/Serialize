using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Serilization
{
    class Program
    {

        static void Main(string[] args)
        {
            User[] users = new User[]
                {
            new User
            {
                ID = 1,
                person = new Person
                {
                    Id = 1,
                    FullName = "Zhaslan Ryspekov"
                },
                Login = "zhaslan",
                Password = "zhaslan",
                CreationDate = DateTime.Now,
                IsDelete = false
            }
                };

            //BinaryFormatter serializer = new BinaryFormatter();
            XmlSerializer serializer = new XmlSerializer(typeof(User[]));

            using (FileStream stream = new FileStream(@"C:\name_of_folder\data.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, users);
            }

            using (FileStream stream = new FileStream(@"C:\name_of_folder\data.xml", FileMode.OpenOrCreate))
            {
                User[] newUser = serializer.Deserialize(stream) as User[];
            }

            string json = JsonConvert.SerializeObject(users);
            User[] newUsers = JsonConvert.DeserializeObject<User[]>(json);
        }
    }
}
