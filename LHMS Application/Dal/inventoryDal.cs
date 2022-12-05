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

    }
}
