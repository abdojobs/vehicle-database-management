using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JarmuBerloDAL;
using System.Data.SqlClient;

namespace JarmuBerlo.Tests
{
    public class MockDAL : IDAL
    {
        public bool ExecuteReaderCalled;

        public MockDAL()
        {
            ExecuteReaderCalled = false;
        }

        public bool CreateConnection()
        {
            return true;
        }

        public object ExecuteScalar(string query, ref string errorMessage)
        {
            return null;
        }

        public SqlDataReader ExecuteReader(string query, ref string errorMessage)
        {
            ExecuteReaderCalled = true;
            return null;
        }

        public SqlDataReader ExecuteReader(string query, string[] parameterNames, string[] parameters, ref string errorMessage)
        {
            return null;
        }

        public void CloseDataReader(SqlDataReader rdr)
        {

        }

        public string ExecuteNonQuery(string command)
        {
            return "nonquery";
        }

        public int ExecuteStoredProcedureNonQuery(string name, string[] parameterNames, string[] parameterValues)
        {
            return -10;
        }
    }
}