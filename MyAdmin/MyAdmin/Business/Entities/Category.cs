using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdmin.Business.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string UptoDate { get; set; }
        public Category()
        {

        }

        public Category(int id, string name, string description, string uptoDate)
        {
            Id = id;
            Name = name;
            Description = description;
            UptoDate = uptoDate;
        }
    }
}
