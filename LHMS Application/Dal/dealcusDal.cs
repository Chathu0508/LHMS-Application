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
    internal class dealcusDal
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
                string sql = "SELECT * FROM tbl_dea_cust";

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
        #region Insert New Deal and customer
        public bool Insert(dealcusBll dc)
        {
            // Creating a Boolean Variable And set its defualt value to fales. 
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //witting queary to add the new Deal and customer.
                string sql = "INSERT INTO tbl_dea_cust (type, name, email, contact, address, add_date, added_by) VALUES(@type, @name, @email, @contact, @address, @add_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values to through the parameters.
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@add_date", dc.add_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

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
        public bool Update(dealcusBll dc)
        {
            // creating boolean variables and set its defulats 
            bool isSuccess = false;

            //Cretaing a SQL Connection. 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //queary to update catagories.
                string sql = "UPDATE tbl_dea_cust SET type=@type, name=@name, email=@email, contact=@contact, address=@address, add_date=@add_date, added_by=@added_by WHERE id=@id";

                //SQL command to pass the Values on Sql Queary
                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing values using cmd
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@add_date", dc.add_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

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
        #region Delete Deal and customer
        public bool Delete(dealcusBll dc)
        {
            //Createing boolean variable and set its values to fales.
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //SQL Queary to delete from database
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //passing the values 
                cmd.Parameters.AddWithValue("@id", dc.id);

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
                String sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' ";

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
        #region Serach the Dealer & customer for taranaction details
        public dealcusBll SearchDealerCustomerFortransaction (string keyword)
        {
            //creat a object for deacustbLl
            dealcusBll dc = new dealcusBll();

            // create a databsae connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a data tabel tp hold the value.
            DataTable dt = new DataTable();
            try
            {
                //wirte a sql qurry to  search the dealer or customer bassed on the keyword.
                string sql = "SELECT name, email, contact, address, from tbl_dea_cust WHERE id like '%" + keyword + "%' OR name LIKE '%" + keyword + "%' ";

                //create sql dataadpter to excute the queary
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //open data base connection
                conn.Open();

                //transfer the data from SQL Data to datatable.
                adapter.Fill(dt);

                //if we have value  on ythe dt we need to save it in dealcustomer bll
                if(dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[1]["email"].ToString();
                    dc.contact = dt.Rows[2]["contact"].ToString();
                    dc.address = dt.Rows[3]["address"].ToString();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dc;
        }
        #endregion


    }
}
