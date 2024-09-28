using Oracle.ManagedDataAccess.Client;
using System.Data; // Don't forget to include this namespace for ConnectionState
using System;
public static class Class1
{
    private static OracleConnection conn;
    private static string connectionString = @"DATA SOURCE = localhost:1521/XE; USER ID=farhan;PASSWORD=3681;";

    public static void OpenConnection()
    {
        conn = new OracleConnection(connectionString);
        conn.Open();
    }

    public static void CloseConnection()
    {
        if (conn != null && conn.State == ConnectionState.Open)
        {
            conn.Close();
        }
    }

    public static OracleConnection GetConnection()
    {
        if (conn == null || conn.State == ConnectionState.Closed)
        {
            OpenConnection();
        }
        return conn;
    }


}
