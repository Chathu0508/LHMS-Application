using LHMS_Application.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Dal
{
    internal class inventoryDal
    {
        static string myconnstrng= ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select method
        public DataTable Select()
        {
            //static method to connect the database.
            SqlConnection conn = new SqlConnection(myconnstrng);

            //to hold the data from the database.
            DataTable dt = new DataTable();
            try
            {
                //SQL quray to get the data from the dtabase.
                string sql = "SELECT * FROM tbl_Inventory";

                // for Excute the Command.
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Gatting the data from the data base.
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //database Connection open.
                conn.Open();

                //Fill the data in our database.
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close the connection between the database and the Application
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert MEthod
        public bool Insert(inventorybll il)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_Inventory (category_id,product_id,total_qty,assign_qty,leftover_qty,Added_date,added_by) VALUES (@category_id,@product_id,@total_qty,@assign_qty,@leftover_qty,@Added_date,@added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@category_id", il.category_id);
                cmd.Parameters.AddWithValue("@product_id", il.product_id);
                cmd.Parameters.AddWithValue("@total_qty", il.total_qty);
                cmd.Parameters.AddWithValue("@assign_qty", il.assign_qty);
                cmd.Parameters.AddWithValue("@leftover_qty", il.leftover_qty);
                cmd.Parameters.AddWithValue("@Added_date", il.Added_date);
                cmd.Parameters.AddWithValue("@added_by", il.added_by);

                conn.Open();

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
            catch(Exception ex)
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

    }
}
