using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using LHMS_Application.BLL;

namespace LHMS_Application.Dal
{
    internal class userDal
    {
        //connecting the database with the application
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select the data from the database.
            public DataTable Select()
            {
                //static method to connect the database.
                SqlConnection conn = new SqlConnection(myconnstrng);

                //to hold the data from the database.
                DataTable dt = new DataTable();
                try
                {
                    //SQL quray to get the data from the dtabase.
                    String sql = "SELECT * FROM tbl_UserD";

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
                    //throw any eorror masessage from the sysytem.
                    MessageBox.Show(ex.Message);
                }
                finally
                { 
                    //Close the connection for the data base.
                    conn.Close();
                }

                //return the vale of the database.
                return dt;
            }
        #endregion
        #region Insert date tothe Database.
        public bool Insert(UserBll u)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO tbl_UserD (firstname, lastname, email, username, password, contact, address, gender, user_type,department, Factory, added_Date, added_by) VALUES(@firstname, @lastname, @email, @username, @password, @contact, @address, @gender, @user_type, @department, @Factory, @added_Date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@firstname", u.firstname);
                cmd.Parameters.AddWithValue("@lastname", u.lastname);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@department", u.department);
                cmd.Parameters.AddWithValue("@Factory", u.Factory);
                cmd.Parameters.AddWithValue("@added_Date", u.added_Date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //if the qurey is excute successsfully then the value to the rows will be greater than 0 elese it will be issue lass than 0
                if (rows > 0)
                {
                    //query Succesfull
                    isSuccess = true;
                }
                else
                {
                    //query failed
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
        #region get thw
        public UserBll GetIDFromUsername(string username)
        {
            UserBll u = new UserBll();
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id FROM tbl_UserD WHERE username='" + username + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());

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
            return u;
        }
        #endregion
        #region Update data in database
        public bool Update(UserBll u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_UserD SET firstname=@firstname, lastname=@lastname, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, user_type=@user_type,department=@department, Factory=@Factory, added_Date=@added_Date, added_by=@added_by WHERE id=@id ";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@firstname", u.firstname);
                cmd.Parameters.AddWithValue("@lastname", u.lastname);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@department", u.department);
                cmd.Parameters.AddWithValue("@Factory", u.Factory);
                cmd.Parameters.AddWithValue("@added_Date", u.added_Date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //query Succesfull
                    isSuccess = true;
                }
                else
                {
                    //query failed
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
        #region Delete data from Database
        public bool Delete(UserBll u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_UserD WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);

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
            catch (SqlException ex)
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
        #region Search data from using keywords
        public DataTable Search(string keywords)
        {
            //static method to connect the database.
            SqlConnection conn = new SqlConnection(myconnstrng);

            //to hold the data from the database.
            DataTable dt = new DataTable();
            try
            {
                //SQL quray to get the data from the dtabase.
                String sql = "SELECT * FROM tbl_UserD WHERE id LIKE '%" + keywords + "%' OR firstname LIKE '%" + keywords + "%' OR lastname LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%' ";

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
                //throw any eorror masessage from the sysytem.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close the connection for the data base.
                conn.Close();
            }
            //return the vale of the database.
            return dt;
        }
        #endregion

    }
}
