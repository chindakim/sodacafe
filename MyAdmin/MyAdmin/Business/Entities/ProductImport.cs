using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdmin.Business.Entities
{
    public class ProductImport
    {
        public int Id { get; set; }
        public string Name { get; set; }  
       public double Cost { get; set; }
        public string Description { get; set; }
        public ProductImport()
        {

        }
        public ProductImport(int id, string name, double cost, string description)
        {
            Id = id;
            Name = name;
            Cost = cost;
            Description = description;
        }
    }
}
