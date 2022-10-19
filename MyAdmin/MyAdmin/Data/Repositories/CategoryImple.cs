using MyAdmin.Business.Entities;
using MyAdmin.Business.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyAdmin.Data.DataSource;

namespace MyAdmin.Data.Repositories
{
    internal class CategoryImple : Repository<Category>
    {
        public bool CreateData(Category e)
        {
            try
            {
                string sql = $"insert into tblcategory (name,description,uptodate) " +
                    $"values('{e.Name}','{e.Description}','{e.UptoDate}')";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                    return true;
                else return false;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteData(int id)
        {
            try
            {
                string sql = $"delete from tblcategory where id = {id}";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Category> ReadData()
        {
            List<Category> ls = new List<Category>();
            try
            {
                string sql = "select * from tblcategory;";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    ls.Add(
                        new Category(int.Parse(r[0].ToString()), r[1].ToString(), r[2].ToString(), r[3].ToString())
                        );
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

        public List<Category> Search(string name)
        {
            List<Category> ls = new List<Category>();
            try
            {
                string sql = $"select * from tblcategory where name like '{name}%'";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                while (r.Read())
                {
                    ls.Add(
                        new Category(int.Parse(r[0].ToString()), r[1].ToString(), r[2].ToString(), r[3].ToString())
                        );
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
        public bool UpdateData(Category e)
        {
            try
            {
                string sql = $"update  tblcategory set name = '{e.Name}',description = '{e.Description}'" +
                    $" uptodate = '{e.UptoDate}' where id = {e.Id}";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                int result = sqlCommand.ExecuteNonQuery();
                if (result == 1)
                    return true;
                else return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
