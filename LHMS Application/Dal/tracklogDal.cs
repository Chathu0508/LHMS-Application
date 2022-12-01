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
    internal class tracklogDal
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method from the database
        public DataTable Select()
        {
            //creating SQL Connetciong to the data base
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                // Wirtting SQL Queray to get the data from the Database.
                string sql = "SELECT * FROM task_Log";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //creating conntion to the database
                conn.Open();

                // adding the value from adptor to data table at
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
        #region Insert New tracklog
        public bool Insert(tracklogBll tc)
        {
            // Creating a Boolean Variable And set its defualt value to fales. 
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //witting queary to add the new categories.
                string sql = "INSERT INTO task_Log (numberofstages, completesatges,added_date, add_by) VALUES(@numberofstages, @completesatges, @pendingsatges, @added_date, @add_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values to through the parameters.
                cmd.Parameters.AddWithValue("@numberofstages", tc.numberofstages);
                cmd.Parameters.AddWithValue("@completesatges", tc.completesatges);
                cmd.Parameters.AddWithValue("@pendingsatges", tc.pendingsatges);
                cmd.Parameters.AddWithValue("@added_date", tc.added_date);
                cmd.Parameters.AddWithValue("@added_by", tc.add_by);

                //open the connectionn to the database
                conn.Open();

                //creating the int variables to excute the queary. 
                int rows = cmd.ExecuteNonQuery();

                //if the queary is excuted successfully then it's va;ues will be greaters than 0 else is will be less than 0
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

    }
}
#endregion
