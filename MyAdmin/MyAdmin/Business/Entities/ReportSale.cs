using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdmin.Business.Entities
{
    public class ReportSale
    {
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public double Amount
        {
            get { return (Qty * Price) - ((Qty * Price) * Discount) / 100; }
        }
        public ReportSale()
        {

        }

        public ReportSale(string name, int qty, string size,double price, double discount)
        {
            Name = name;
            Qty = qty;
            Size = size;
            Price = price;
            Discount = discount;
        }
    }
}
