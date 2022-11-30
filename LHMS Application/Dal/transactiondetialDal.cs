using LHMS_Application.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Dal
{
    internal class transactiondetialDal
    {
        //connecting with the date base
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        #region Insert transaction Method 
        public bool Inserttransactiondeetails(transactionalDetailsBll td)
        {
            bool isSuccess = false;

            //create a SQL connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_transactionaldetails (product_id, rate, qty, total, dea_cust_id, added_date, added_by) VALUES (@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by)";

                //sql commom
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                //open connection
                conn.Open();

                //excuyte  curry 
                int rows = cmd.ExecuteNonQuery();


                if (rows>0)
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

    }
}
