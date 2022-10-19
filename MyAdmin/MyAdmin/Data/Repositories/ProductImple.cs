using MyAdmin.Business.Repositories;
using MyAdmin.Business.Entities;
using MyAdmin.Data.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyAdmin.Data.Repositories
{
    class ProductImple : Repository<Product>
    {
        public bool CreateData(Product e)
        {
            try
            {
                string sql = $"exec create_product '{e.Name}', {e.CatID}, {e.Price}, N'{e.Image}', '{e.Size}'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (result == 1)
                    return true;
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteData(int id)
        {
            try
            {
                string sql = $"exec delete_product {id}";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (result == 1) return true;
                else return false;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Product> ReadData()
        {
            List<Product> ls = new List<Product>();
            try
            {
                string sql = "exec read_product";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    int id = int.Parse(r[0].ToString());
                    string n = r[1].ToString();
                    int catID = int.Parse(r[2].ToString());
                    double price = double.Parse(r[3].ToString());
                    string image = r[4].ToString();
                    string size = r[5].ToString();
                    ls.Add(new Product(id, n, catID, price, image, size));
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

        public List<Product> Search(string name)
        {
            List<Product> ls = new List<Product>();
            try
            {
                string sql = $"exec search_product '{name}%'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    int id = int.Parse(r[0].ToString());
                    string n = r[1].ToString();
                    int catID = int.Parse(r[2].ToString());
                    double price = double.Parse(r[3].ToString());
                    string image = r[4].ToString();
                    string size = r[5].ToString();
                    ls.Add(new Product(id, n, catID, price, image, size));
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

        public Product search(int id)
        {
            throw new NotImplementedException();
        }
        public List<Product> searchByCategory(int catId)
        {
            List<Product> ls = new List<Product>();
            try
            {
                string sql = $"exec product_by_catId {catId};";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    int id = int.Parse(r[0].ToString());
                    string n = r[1].ToString();
                    int catID = int.Parse(r[2].ToString());
                    double price = double.Parse(r[3].ToString());
                    string image = r[4].ToString();
                    string size = r[5].ToString();
                    ls.Add(new Product(id, n, catID, price, image, size));
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
        public bool UpdateData(Product e)
        {
            try
            {
                string sql = $"exec update_product {e.ID},'{e.Name}',{e.CatID},{e.Price},N'{e.Image}',{e.Size};";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (result == 1) return true;
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
