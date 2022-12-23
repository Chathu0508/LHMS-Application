using LHMS_Application.Database;
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
        DbConnection db = DbConnection.getInstance();


        #region Insert transaction Method 
        public bool Insert_transaction(TransactionsBll ta, out int transactionID)
        {
            bool isSuccess = false;
            transactionID = -1;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO tbl_transactions (type, dea_cust_id, grandTotal, transaction_date, tax, discount, added_by) VALUES (@type, @dea_cust_id, @grandTotal, @transaction_date, @tax, @discount, @added_by)";
                
                SqlCommand cmd= new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@type", ta.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", ta.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", ta.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", ta.transaction_date);
                cmd.Parameters.AddWithValue("@tax",ta.tax);
                cmd.Parameters.AddWithValue("@discount", ta.discount );
                cmd.Parameters.AddWithValue("@added_by", ta.added_by);
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
                db.CloseCon();
            }


            return isSuccess;
        }

        #endregion
    }
}
