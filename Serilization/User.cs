using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serilization
{
    [Serializable]
    public class User
    {
        [NonSerialized]
        [JsonIgnore]
        private int id; 
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public Person Person { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
