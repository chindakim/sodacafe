using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyAdmin.Business.Repositories;
using MyAdmin.Business.Entities;
using MyAdmin.Data.DataSource;

namespace MyAdmin.Data.Repositories
{
    public class ProductImportImple : Repository<ProductImport>
    {
        public bool CreateData(ProductImport e)
        {
            try
            {
                string sql = $"exec create_product_import N'{e.Name}',{e.Cost},'{e.Description}'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (result == 1)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteData(int id)
        {
            try
            {
                string sql = $"exec delete_product_import {id}";
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

        public List<ProductImport> ReadData()
        {
            List<ProductImport> ls = new List<ProductImport>();
            try
            {
                string sql = "exec read_product_import";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    int id = int.Parse(r[0].ToString());
                    string name = r[1].ToString();
                    double cost = double.Parse(r[2].ToString());
                    string description = r[3].ToString();
                    ls.Add(new ProductImport(id, name, cost, description));
                }
                sqlCommand.Dispose();
                r.Close();
                return ls;
                
            }catch(Exception ex)
            {
                throw ex;
            }
           
        }
        public List<ProductImport> Search(string name)
        {
            List<ProductImport> ls = new List<ProductImport>();
            try
            {
                string sql = $"exec search_product_import N'{name}%'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    int id = int.Parse(r[0].ToString());
                    string n = r[1].ToString();
                    double cost = double.Parse(r[2].ToString());
                    string description = r[3].ToString();
                    ls.Add(new ProductImport(id, n, cost, description));
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

        public ProductImport Search(int id)
        {
            try
            {
                string sql = $"select * from tblproductimport where id = {id}";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                if (r.Read())
                {
                    int pid = int.Parse(r[0].ToString());
                    string n = r[1].ToString();
                    double cost = double.Parse(r[2].ToString());
                    string description = r[3].ToString();
                    r.Close();
                    return new ProductImport(pid,n,cost,description);
                }
                r.Close();
                return null;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateData(ProductImport e)
        {
            try
            {
                string sql = $"exec update_product_import {e.Id},N'{e.Name}',{e.Cost},N'{e.Description}'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
                if (result == 1) return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}