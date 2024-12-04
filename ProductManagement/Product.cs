using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return $"ID : {ID}, Name : {Name}, Price : {Price}€ ";
        }
    }
}
