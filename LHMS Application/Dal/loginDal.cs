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
using LHMS_Application.UI;

namespace LHMS_Application.Dal
{
    public class loginDal
    {
        //private readonly LogTrackDal logTrackDal;
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
                    int UserD_id = 0;
                    LogTrackBll logTrackBillModel = new LogTrackBll();
                    foreach (DataRow row in dt.Rows)
                    {
                         UserD_id = Convert.ToInt32(row["id"]);
                    }

                    logTrackBillModel.id = 1;
                    logTrackBillModel.username = l.username;
                    logTrackBillModel.UserD_id = UserD_id;
                    logTrackBillModel.InOut = "LogIn";

                    LogTrackDal dal = new LogTrackDal();
                    dal.UsrAuthor(logTrackBillModel);
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
