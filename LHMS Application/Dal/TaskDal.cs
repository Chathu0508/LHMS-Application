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
    internal class TaskDal
    {
        DbConnection db = DbConnection.getInstance();
        #region Select method for task
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                string sql = "SELECT * FROM tbl_task";
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
        #region Insert method for tasks
        public bool Insert(TaskBLL tc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "INSERT INTO tbl_task (title, description, factory, departments, added_date, added_by) VALUES(@title, @description, @factory, @departments, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@title", tc.title);
                cmd.Parameters.AddWithValue("@description", tc.description);
                cmd.Parameters.AddWithValue("@factory", tc.factory);
                cmd.Parameters.AddWithValue("@departments", tc.departments);
                cmd.Parameters.AddWithValue("@added_date", tc.added_date);
                cmd.Parameters.AddWithValue("@added_by", tc.added_by);
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
        #region update method for task
        public bool Update(TaskBLL tc)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "UPDATE tbl_task SET title=@title, description=@description, factory=@factory, departments=@departments, added_date=@added_date, added_by=@added_by WHERE Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@Id", tc.Id);
                cmd.Parameters.AddWithValue("@title", tc.title);
                cmd.Parameters.AddWithValue("@description", tc.description);
                cmd.Parameters.AddWithValue("@factory", tc.factory);
                cmd.Parameters.AddWithValue("@departments", tc.departments);
                cmd.Parameters.AddWithValue("@added_date", tc.added_date);
                cmd.Parameters.AddWithValue("@added_by", tc.added_by);
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
        #region Delete method for task
        public bool Delete(TaskBLL t)
        {
            bool isSuccess = false;
            try
            {
                db.OpenCon();
                string sql = "DELETE FROM tbl_task WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, db.conn);
                cmd.Parameters.AddWithValue("@id", t.Id);
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
        #region Search method for data
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                db.OpenCon();
                String sql = "SELECT * FROM tbl_task WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' ";
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


    }
}
