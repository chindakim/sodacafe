using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdmin.Business.Entities
{
    class Supplier:Person
    {
        public string EMAIL { get; set; }
        public string UPTODATE { get; set; }
        public Supplier()
        {

        }
        public Supplier(int iD, string nAME, string pHONE, string aDDRESS,string eMAIL,string iMg,string uPTODATE):
            base(iD,nAME,pHONE,aDDRESS,iMg)
        {
            EMAIL = eMAIL;
            UPTODATE = uPTODATE;
        }
    }
}
