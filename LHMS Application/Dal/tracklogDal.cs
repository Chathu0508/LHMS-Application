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

        #region Select Method
        public DataTable Select()
        {
            //static method to connect the database.
            SqlConnection conn = new SqlConnection(myconnstrng);

            //to hold the data from the database.
            DataTable dt = new DataTable();
            try
            {
                //SQL quray to get the data from the dtabase.
                string sql = "SELECT * FROM task_log";

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
        #region Insert Method
        public bool Insert(tracklogBll tl)
        {
            bool isSuucess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO task_log(taskId, numberofstages, completesatges, pendingsatges, added_date, add_by)VALUES(@taskId, @numberofstages, @completesatges, @pendingsatges, @added_date, @add_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@taskId", tl.taskId);
                cmd.Parameters.AddWithValue("@numberofstages", tl.numberofstages);
                cmd.Parameters.AddWithValue("@completesatges", tl.completesatges);
                cmd.Parameters.AddWithValue("@pendingsatges", tl.pendingsatges);
                cmd.Parameters.AddWithValue("@added_date", tl.added_date);
                cmd.Parameters.AddWithValue("@add_by", tl.add_by);
                cmd.Parameters.AddWithValue("@Id", tl.Id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuucess = true;
                }
                else
                {
                    isSuucess = false;
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
            return isSuucess;
        }
        #endregion
        #region Update Method
        public bool Update(tracklogBll tl)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE task_log SET taskId=@taskId, numberofstages=@numberofstages, completesatges=@completesatges, pendingsatges=@pendingsatges, added_date=@added_date, add_by=@add_by WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@taskId", tl.taskId);
                cmd.Parameters.AddWithValue("@numberofstages", tl.numberofstages);
                cmd.Parameters.AddWithValue("@completesatges", tl.completesatges);
                cmd.Parameters.AddWithValue("@pendingsatges", tl.pendingsatges);
                cmd.Parameters.AddWithValue("@added_date", tl.added_date);
                cmd.Parameters.AddWithValue("@add_by", tl.add_by);
                cmd.Parameters.AddWithValue("@ID", tl.Id);
                conn.Open();

                Console.WriteLine();
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
        #region
        public bool Delete(tracklogBll tl)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM task_log WHERE Id=@Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", tl.Id);

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

            #endregion
        }
    }
   }
