using LHMS_Application.BLL;
using LHMS_Application.Database;
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
        DbConnection db = DbConnection.getInstance();
        #region Select Method
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM task_log";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return dt;
        }
        #endregion
        #region Insert Method
        public bool Insert(TracklogBll tl)
        {
            bool isSuucess = false;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO task_log(taskId, numberofstages, completesatges, pendingsatges, added_date, add_by)VALUES(@taskId, @numberofstages, @completesatges, @pendingsatges, @added_date, @add_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@taskId", tl.taskId);
                cmd.Parameters.AddWithValue("@numberofstages", tl.numberofstages);
                cmd.Parameters.AddWithValue("@completesatges", tl.completesatges);
                cmd.Parameters.AddWithValue("@pendingsatges", tl.pendingsatges);
                cmd.Parameters.AddWithValue("@added_date", tl.added_date);
                cmd.Parameters.AddWithValue("@add_by", tl.add_by);
                cmd.Parameters.AddWithValue("@Id", tl.Id);
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
                db.CloseCon();
            }
            return isSuucess;
        }
        #endregion
        #region Update Method
        public bool Update(TracklogBll tl)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "UPDATE task_log SET taskId=@taskId, numberofstages=@numberofstages, completesatges=@completesatges, pendingsatges=@pendingsatges, added_date=@added_date, add_by=@add_by WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@taskId", tl.taskId);
                cmd.Parameters.AddWithValue("@numberofstages", tl.numberofstages);
                cmd.Parameters.AddWithValue("@completesatges", tl.completesatges);
                cmd.Parameters.AddWithValue("@pendingsatges", tl.pendingsatges);
                cmd.Parameters.AddWithValue("@added_date", tl.added_date);
                cmd.Parameters.AddWithValue("@add_by", tl.add_by);
                cmd.Parameters.AddWithValue("@ID", tl.Id);
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
                db.CloseCon();
            }
            return isSuccess;
        }
        #endregion
        #region Delete method
        public bool Delete(TracklogBll tl)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "DELETE FROM task_log WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@Id", tl.Id);
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
                db.CloseCon();
            }
            return isSuccess;
        }
        #endregion
        #region Search Method
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM task_log WHERE id LIKE '%" + keywords + "%' OR taskId LIKE '%" + keywords + "%' ";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseCon();
            }
            return dt;

            #endregion
        }
    }
}
