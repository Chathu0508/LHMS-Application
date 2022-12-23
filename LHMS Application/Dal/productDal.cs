using LHMS_Application.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LHMS_Application.Database;

namespace LHMS_Application.Dal
{
    internal class productDal
    {

        DbConnection db = DbConnection.getInstance();

        #region Select Method for the Product Module.
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_Product";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return dt;
        }

        #endregion
        #region Method to insert the data to Data Table
        public bool Insert(ProductBll p)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                String sql = "INSERT INTO  tbl_Product (name, category, description, rate, qty, added_date, added_by) VALUES (@name, @category, @description, @rate, @qty, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return isSuccess;
        }
        #endregion
        #region Update the data in the Database
        public bool Update(ProductBll p)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                String sql = "UPDATE tbl_Product SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return isSuccess;
        }
        #endregion
        #region Delete the data in the Database
        public bool Delete(ProductBll p)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                String sql = "DELETE FROM tbl_Product WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", p.id);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return isSuccess;
        }
        #endregion
        #region Search Method for product Module 
        public DataTable Search(String keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_Product WHERE id LIKE '%" + keywords + "'or name LIKE '%" + keywords + "' OR category LIKE '%" + keywords + "'";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return dt;
        }
        #endregion

    }
}
