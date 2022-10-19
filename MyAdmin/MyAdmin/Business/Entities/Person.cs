using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdmin.Business.Entities
{
    class Person
    {

        public int ID { get; set; }
        public string NAME { get; set; }
        public string PHONE { get; set; }
        public string ADDRESS { get; set; }
        public string Img { get; set; }
        public Person()
        {

        }

        public Person(int iD, string nAME, string pHONE, string aDDRESS, string img)
        {
            ID = iD;
            NAME = nAME;
            PHONE = pHONE;
            ADDRESS = aDDRESS;
            Img = img;
        }
    }
}
