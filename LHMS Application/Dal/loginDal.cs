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
    internal class loginDal
    {
        //Static connection for the connection database.
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(loginBll l)
        {
            // create boolean varibale and set its values to fales and retuen it
            bool isSuccess = false;

            //connection to database 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to check login
                string sql = "SELECT * FROM tbl_UserD WHERE username=@username AND password=@password and user_type=@user_type";

                //Creating SQL Command to pass value
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //checking the rows in Datatable
                if (dt.Rows.Count > 0)
                {
                    //login success
                    isSuccess = true;
                }
                else
                {
                    //login failed
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
    }
}
