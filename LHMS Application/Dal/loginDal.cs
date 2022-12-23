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
    internal class loginDal
    {
        DbConnection db= DbConnection.getInstance();
        public bool loginCheck(LoginBll l)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_UserD WHERE username=@username AND password=@password AND user_type=@user_type";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
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
    }
}
