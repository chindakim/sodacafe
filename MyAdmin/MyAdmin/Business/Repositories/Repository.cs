using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdmin.Business.Repositories
{
    interface Repository<E>
    {
        List<E> ReadData();
        bool CreateData(E e);
        bool UpdateData(E e);
        bool DeleteData(int id);
        List<E> Search(string name);
    }
}
