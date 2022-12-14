using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Framework.Database
{
    public class Transaction
    {
        #region Properties
        public SqlConnection Connection;
        private string ConnectionString;
        #endregion

        #region Constructor        
        public Transaction() {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["TestsDatabase"].ConnectionString;
        }

        public Transaction(string ConctString)
        {
            this.ConnectionString = ConctString;
        }
        #endregion

        #region Methods
        public static string GetConnectionString()
        {
            try
            {
                var cString = ConfigurationManager.ConnectionStrings["TestsDatabase"].ConnectionString;
                return cString;
            }
            catch (Exception e)
            {
                throw e;
            }            
        }
        
        public static void ExecuteCreateObjectCommand(string sqlQuery)
        {
            try
            {                
                var connectionString = GetConnectionString();
                DataSet data = new DataSet();
                data.Tables.Add(new DataTable());

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = connection.CreateCommand())
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.CommandText = sqlQuery;
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    sda.Fill(data.Tables[0]);
                    connection.Close();                    
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static void ExecuteUpdateObjectCommand(string sqlQuery)
        {
            try
            {
                var connectionString = GetConnectionString();
                DataSet data = new DataSet();
                data.Tables.Add(new DataTable());

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = connection.CreateCommand())
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.CommandText = sqlQuery;
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    sda.Fill(data.Tables[0]);
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static DataRow ExecuteSelectSingleObjectCommand(string sqlQuery)
        {
            try
            {                            
                DataSet data = new DataSet();
                data.Tables.Add(new DataTable());

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = connection.CreateCommand())
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.CommandText = sqlQuery;
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    sda.Fill(data.Tables[0]);
                    connection.Close();
                    return data.Tables[0].Rows[0];
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static DataSet ExecuteSelectListOfObjectCommand(string sqlQuery)
        {
            try
            {               
                DataSet data = new DataSet();
                data.Tables.Add(new DataTable());

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = connection.CreateCommand())
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    cmd.CommandText = sqlQuery;
                    cmd.CommandType = CommandType.Text;
                    connection.Open();
                    sda.Fill(data.Tables[0]);
                    connection.Close();
                    return data;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public SqlConnection GetConnection()
        //{
        //    try
        //    {
        //        this.Connection = new SqlConnection(this.ConnectionString);
        //        return Connection;
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //}

        //public void OpenConnection()
        //{
        //    try
        //    {
        //        this.Connection = new SqlConnection(this.ConnectionString);
        //        Connection.Open();
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }

        //}

        //public void CloseConnection()
        //{
        //    try
        //    {
        //        if (this.Connection.State == System.Data.ConnectionState.Open)
        //        {
        //            this.Connection.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Open a connection before calling the closa method.");
        //            return;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion
    }
}
