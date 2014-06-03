using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace JarmuBerloDAL
{
    public interface IDAL
    {
        bool CreateConnection();
        object ExecuteScalar(string query, ref string errorMessage);
        SqlDataReader ExecuteReader(string query, ref string errorMessage);
        SqlDataReader ExecuteReader(string query, string[] parameterNames, string[] parameters, ref string errorMessage);
        void CloseDataReader(SqlDataReader rdr);
        string ExecuteNonQuery(string command);
        int ExecuteStoredProcedureNonQuery(string name, string[] parameterNames, string[] parameterValues);
    }
}