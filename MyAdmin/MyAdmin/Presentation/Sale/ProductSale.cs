using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAdmin.Presentation.Component;

namespace MyAdmin.Presentation.Sale
{
    public partial class ProductSale : UserControl
    {
        public ProductSale()
        {
            InitializeComponent();
        }

        private void ProductSale_MouseClick(object sender, MouseEventArgs e)
        {
            int index = findId(Id);
            if (index >= 0)
            {
                Qty = int.Parse(Rows[index].Cells[2].Value.ToString());
                Qty++;
                Rows[index].Cells[2].Value = Qty;
                double p = double.Parse(LblPrice.Replace("$",""));
                int dis = 0;
                if(Rows[index].Cells[6].Value != null)
                    dis = int.Parse(Rows[index].Cells[6].Value.ToString().Replace("%", ""));
                //Rows[index].Cells[4].Value =p.ToString("$#0.00");
                double total = (p * Qty)-((p * Qty)*dis/100);
                Rows[index].Cells[5].Value = total.ToString("$#0.00");
            }
            else
            {
                Rows.Add(Id, LblName, "1", LblSize, LblPrice, LblPrice);
            }
            double t= 0;
            for(int i=0; i < Rows.Count; i++)
            {
                t += double.Parse(Rows[i].Cells[5].Value.ToString().Replace("$", ""));
            }
            Total.Text = t.ToString("$#0.00");
        }
        public int findId(int id)
        {
            int orderId = -1;
            for(int i=0; i<Rows.Count; i++)
            {
                orderId = int.Parse(Rows[i].Cells[0].Value.ToString());
                if (id.Equals(orderId))
                    return i;
            }
            return -1;
        }
        public  int Qty { get; set; }
    }
}
