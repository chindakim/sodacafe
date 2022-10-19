using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAdmin.Business.Repositories;
using MyAdmin.Business.Entities;
using MyAdmin.Data.DataSource;
using System.Data.SqlClient;


namespace MyAdmin.Data.Repositories
{
    class SupplierImple : Repository<Supplier>
    {
        public bool CreateData(Supplier e)
        {
            try
            {
                string sql = $"create_supplier N'{e.NAME}','{e.PHONE}',N'{e.ADDRESS}','{e.EMAIL}',N'{e.Img}','{e.UPTODATE}'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int c = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (c==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteData(int id)
        {
            try
            {
                string sql = $"exec delete_supplier {id}";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int c = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (c == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Supplier> ReadData()
        {
            List<Supplier> ls = new List<Supplier>();
            try
            {
                String sql = "exec read_supplier;";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    int iD = int.Parse(r[0].ToString());
                    string nAME = r[1].ToString();
                    string pHONE = r[2].ToString();
                    string aDDRESS = r[3].ToString();
                    string eMAIL = r[4].ToString();
                    string iMg = r[5].ToString();
                    string uPTODATE = r[6].ToString();
                    ls.Add(new Supplier(iD, nAME, pHONE, aDDRESS, eMAIL, iMg, uPTODATE));
                }
                sqlCommand.Dispose();
                r.Close();
                return ls;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Supplier search(int id)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> Search(string name)
        {
            List<Supplier> ls = new List<Supplier>();
            try
            {
                String sql = $"exec search_supplier N'{name}%'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    int iD = int.Parse(r[0].ToString());
                    string nAME = r[1].ToString(); 
                    string pHONE = r[2].ToString();
                    string aDDRESS = r[3].ToString();
                    string eMAIL = r[4].ToString();
                    string iMg = r[5].ToString();
                    string uPTODATE = r[6].ToString();
                    ls.Add(new Supplier(iD, nAME, pHONE, aDDRESS, eMAIL, iMg, uPTODATE));
                }
                sqlCommand.Dispose();
                r.Close();
                return ls;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateData(Supplier e)
        {
            try
            {
                string sql = $"exec update_supplier {e.ID},N'{e.NAME}','{e.PHONE}',N'{e.ADDRESS}','{e.EMAIL}','{e.Img}','{e.UPTODATE}';";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (result==1) return true;
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        //public SqlDataAdapter getData()
        //{
        //    try
        //    {
        //        String sql = "select id,name,phone,address,email,uptodate from tblsupplier where active = 1";
        //        SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, Connection.DataCon);
        //        return dataAdapter;
        //    }catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
