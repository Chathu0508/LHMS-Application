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
    internal class dealcusDal
    {
        DbConnection db = DbConnection.getInstance();
        #region Select Method
        public DataTable Select()
        {

            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_dea_cust";
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
        #region Insert New Deal and customer
        public bool Insert(DealCusBll dc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO tbl_dea_cust (type, name, email, contact, address, add_date, added_by) VALUES(@type, @name, @email, @contact, @address, @add_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@add_date", dc.add_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
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

            catch (SqlException ex)
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
        #region Update method 
        public bool Update(DealCusBll dc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "UPDATE tbl_dea_cust SET type=@type, name=@name, email=@email, contact=@contact, address=@address, add_date=@add_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@add_date", dc.add_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);
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
        #region Delete Deal and customer
        public bool Delete(DealCusBll dc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", dc.id);

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
        #region Search data
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' ";
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
        #region Serach the Dealer & customer for taranaction details
        public DealCusBll SearchDealerCustomerFortransaction(string keyword)
        {
            DealCusBll dc = new DealCusBll();
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * from tbl_dea_cust WHERE id =" + keyword ;
                SqlDataAdapter adapter = new SqlDataAdapter(sql, db.conn);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"]!=""? dt.Rows[0]["name"].ToString() : "";
                    dc.email = dt.Rows[0]["email"] != "" ? dt.Rows[0]["email"].ToString() : "";
                    dc.contact = dt.Rows[0]["contact"] != "" ? dt.Rows[0]["contact"].ToString() : "";
                    dc.address = dt.Rows[0]["address"] != "" ? dt.Rows[0]["address"].ToString():"";
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
            return dc;
        }
        #endregion


    }
}
