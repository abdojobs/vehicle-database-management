using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace JarmuBerloDAL
{
    //absztrakt osztaly, az osszes tobbi adatbaziskezelo osztaly ezt terjeszti ki
    //tartalmazza az alap muveleteket: kapcsolat letrehozasa, zarasa, lekerdezes, tarolt eljaras vegrehajtasa
    public class DAL : IDAL
    {
        private static bool Connected;
        private static bool ConnectionCreated;

        private static SqlConnection m_Connection;
        private string m_ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=JarmuBerles;Integrated Security=SSPI";

        public DAL() { }

        public bool IsConnectCreated()
        {
            return ConnectionCreated;
        }

        public bool IsConnected()
        {
            return Connected;
        }

        public SqlConnection GetConnection()
        {
            return m_Connection;
        }

        public bool CreateConnection()
        {
            if (ConnectionCreated != true)
            {
                try
                {
                    m_Connection = new SqlConnection(m_ConnectionString);
                    m_Connection.Open();
                    ConnectionCreated = true;
                    m_Connection.Close();
                    Connected = false;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool OpenConnection()
        {
            if (Connected != true)
            {
                try
                {
                    CreateConnection();
                    m_Connection.Open();
                    Connected = true;
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                return true;
            }
        }

        internal void CloseConnection()
        {
            if (Connected)
            {
                m_Connection.Close();
                Connected = false;
            }
        }

        public object ExecuteScalar(string query, ref string errorMessage)
        {
            object value;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, m_Connection);
                value = cmd.ExecuteScalar();
                errorMessage = "OK";
            }
            catch (SqlException e)
            {
                value = null;
                errorMessage = e.Message;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }
        
        public SqlDataReader ExecuteReader(string query, ref string errorMessage)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, m_Connection);
                SqlDataReader rdr = cmd.ExecuteReader();
                errorMessage = "OK";
                return rdr;

            }
            catch (SqlException e)
            {
                errorMessage = e.Message;
                CloseConnection();
                return null;
            }
        }
        
        public SqlDataReader ExecuteReader(string query, string[] parameterNames, string[] parameters, ref string errorMessage)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(query, m_Connection);
                //add parameters
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.AddWithValue(parameterNames[i], parameters[i]);
                }
                SqlDataReader rdr = cmd.ExecuteReader();
                errorMessage = "OK";
                return rdr;
            }
            catch (SqlException e)
            {
                errorMessage = e.Message;
                CloseConnection();
                return null;
            }
        }
        
        public void CloseDataReader(SqlDataReader rdr)
        {
            if (rdr != null)
                rdr.Close();
            CloseConnection();
        }
        
        public string ExecuteNonQuery(string command)
        {
            string error;
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(command, m_Connection);
                cmd.ExecuteNonQuery();
                error = "OK";
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                CloseConnection();
            }
            return error;
        }
        
        public int ExecuteStoredProcedureNonQuery(string name, string[] parameterNames, string[] parameterValues)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(name, m_Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parameterNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(parameterNames[i], parameterValues[i]);
                }
                cmd.Parameters.Add("@ret", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(cmd.Parameters["@ret"].Value);
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}