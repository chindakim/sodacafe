using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdmin.Business.Entities
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CatID { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Size { get; set; }
        public Product()
        {

        }

        public Product(int iD, string name, int catID, double price, string image, string size)
        {
            ID = iD;
            Name = name;
            CatID = catID;
            Price = price;
            Image = image;
            Size = size;
        }
    }
}
