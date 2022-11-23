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
    internal class TaskDal
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Method
        public DataTable Select()
        {
            //creating SQL Connetciong to the data base
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();
            try
            {
                // Wirtting SQL Queray to get the data from the Database.
                string sql = "SELECT * FROM tbl_task";

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
        #region Insert New Categories
        public bool Insert(taskBLL tc)
        {
            // Creating a Boolean Variable And set its defualt value to fales. 
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //witting queary to add the new categories.
                string sql = "INSERT INTO tbl_task (title, description, factory, departments, added_date, added_by) VALUES(@title, @description, @factory, @departments, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values to through the parameters.
                cmd.Parameters.AddWithValue("@title", tc.title);
                cmd.Parameters.AddWithValue("@description", tc.description);
                cmd.Parameters.AddWithValue("@factory", tc.factory);
                cmd.Parameters.AddWithValue("@departments", tc.departments);
                cmd.Parameters.AddWithValue("@added_date", tc.added_date);
                cmd.Parameters.AddWithValue("@added_by", tc.added_by);

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

        #endregion
        #region Update method 
        public bool Update(taskBLL tc)
        {
            // creating boolean variables and set its defulats 
            bool isSuccess = false;

            //Cretaing a SQL Connection. 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //queary to update catagories.
                string sql = "UPDATE tbl_task SET title=@title, description=@description, factory=@factory, departments=@departments, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //SQL command to pass the Values on Sql Queary
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values using cmd
                cmd.Parameters.AddWithValue("@title", tc.title);
                cmd.Parameters.AddWithValue("@description", tc.description);
                cmd.Parameters.AddWithValue("@factory", tc.factory);
                cmd.Parameters.AddWithValue("@departments", tc.departments);
                cmd.Parameters.AddWithValue("@added_date", tc.added_date);
                cmd.Parameters.AddWithValue("@added_by", tc.added_by);
                cmd.Parameters.AddWithValue("@id", tc.id);

                //open the connection to database
                conn.Open();

                //create INT varibles to excuted queary
                int rows = cmd.ExecuteNonQuery();

                //if the queary excuted successfully then the value will be greater than zero
                if (rows > 0)
                {
                    //Queary was success
                    isSuccess = true;
                }
                else
                {
                    //faild the queary
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
        #region Delete Categories
        public bool Delete(taskBLL t)
        {
            //Createing boolean variable and set its values to fales.
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Queary to delete from database
                string sql = "DELETE FROM tbl_task WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing the values 
                cmd.Parameters.AddWithValue("@id", t.id);

                //open connection to the database
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //close the connection toe the database
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Search data
        public DataTable Search(string keywords)
        {
            //SQL Connection to the database
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Creating Data Table to hold the data base
            DataTable dt = new DataTable();
            try
            {
                //SQL quray to get the data from the dtabase.
                String sql = "SELECT * FROM tbl_task WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' ";

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
