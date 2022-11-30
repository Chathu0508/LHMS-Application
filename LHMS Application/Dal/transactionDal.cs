using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.BLL
{
    internal class transactionDal
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert transaction Method 
        public bool Insert_transaction(transactionsBll ta, out int transactionID)
        {
            bool isSuccess = false;
            //set the transaction value into nagative value
            transactionID = -1;

            //create a SQL connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO tbl_transactions (type, dea_cust_id, grandTotal, transaction_date, tax, discount, added_by) VALUES (@type, @dea_cust_id, @grandTotal, @transaction_date, @tax, @discount, @added_by)";
                
                //sql commom
                SqlCommand cmd= new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", ta.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", ta.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", ta.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", ta.transaction_date);
                cmd.Parameters.AddWithValue("@tax",ta.tax);
                cmd.Parameters.AddWithValue("@discount", ta.discount );
                cmd.Parameters.AddWithValue("@added_by", ta.added_by);

                //open connection
                conn.Open();

                //excuyte  curry 
                object o = cmd.ExecuteScalar();

                if (o != null)
                {
                    transactionID = int.Parse(o.ToString());
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
