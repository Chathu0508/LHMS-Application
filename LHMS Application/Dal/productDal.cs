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

namespace LHMS_Application.Dal
{
    internal class productDal
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method for the Product Module.
        public DataTable Select()
        {
            //createing SQl Connetion to the connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Datatable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //Writtinf queary to seclet the all the prducted from database
                String sql = "SELECT * FROM tbl_Product";

                //Creating SQL Command to execute Queary
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQL Data Adapter to hold the value from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        #endregion
        #region Method to insert the data to Data Table
        public bool Insert(productBll p)
        {
            //creating a booland variable and set its defult value to fales.
            bool isSuccess = false;

            //SQL Connection to DB
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Queary to insert product into database
                String sql = "INSERT INTO  tbl_Product (name, category, description, rate, qty, added_date, added_by) VALUES (@name, @category, @description, @rate, @qty, @added_date, @added_by)";

                //Creating SQL Command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the value throug pratameter
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                //Open the connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the queary is excuted the successfully then value of rows will be grater than 0 
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
                conn.Close();
            }


            return isSuccess;
        }
        #endregion
        #region Update the data in the Database
        public bool Update(productBll p)
        {
            //creating a booland variable and set its defult value to fales.
            bool isSuccess = false;

            //Creating SQL Command to pass the value
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Queary to update the data in the DB
                String sql = "UPDATE tbl_Product SET name=@name, category=@category, description=@description, rate=@rate, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //Creating SQL Command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the value throug pratameter
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                //open the connection to DB
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the queary is excuted the successfully then value of rows will be grater than 0 
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
                conn.Close();
            }


            return isSuccess;
        }
        #endregion
        #region Delete the data in the Database
        public bool Delete(productBll p)
        {
            //creating a booland variable and set its defult value to fales.
            bool isSuccess = false;

            //Creating SQL Command to pass the value
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Queary to update the data in the DB
                String sql = "DELETE FROM tbl_Product WHERE id=@id";

                //Creating SQL Command to pass the value
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passign the value throug pratameter
                cmd.Parameters.AddWithValue("@id", p.id);

                //open the connection to DB
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the queary is excuted the successfully then value of rows will be grater than 0 
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
                conn.Close();
            }


            return isSuccess;
        }
        #endregion
        #region Search Method for product Module 
        public DataTable Search(String keywords)
        {
            //connection for DB connaction
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Creating Datetable to hold value from datatable
            DataTable dt = new DataTable();

            try
            {
                //SQL queary to search product 
                string sql = "SELECT * FROM tbl_Product WHERE id LIKE '%" + keywords + "'or name LIKE '%" + keywords + "' OR category LIKE '%" + keywords + "'";

                //SQL connection 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //sql date adpter to hold the data from database temporarily 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open connection to the db
                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion

    }
}
