using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;

/// <summary>
/// Summary description for DB
/// </summary>
public class DB
{
    private static string Host = "localhost";
    private static string User = "postgres";
    private static string DBname = "CookBook";
    private static string Password = "root";
    private static string Port = "5432";

    NpgsqlConnection conn;

    public void OpenConnection()
    {
        string connString =
                String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

        conn = new NpgsqlConnection(connString);

        conn.Open();
    }

    public void CloseConnection()
    {
        if (conn != null && conn.State != System.Data.ConnectionState.Closed)
            conn.Close();
    }

    public List<string> GetIngreds()
    {
        List<string> ingreds = new List<string>();
        OpenConnection();
        var command = new NpgsqlCommand("select ingred_name from public.ingredients", conn);
        NpgsqlDataReader dr = command.ExecuteReader();
        while (dr.Read())
            ingreds.Add(Convert.ToString(Convert.ToString(dr[0])));
        CloseConnection();
        return ingreds;
    }

    public List<string> GetMeasures()
    {
        List<string> measures = new List<string>();
        OpenConnection();
        var command = new NpgsqlCommand("select measur_name from public.measure", conn);
        NpgsqlDataReader dr = command.ExecuteReader();
        while (dr.Read())
            measures.Add(Convert.ToString(Convert.ToString(dr[0])));
        CloseConnection();
        return measures;
    }

    public List<string> GetAutors()
    {
        List<string> autors = new List<string>();
        OpenConnection();
        var command = new NpgsqlCommand("select autor_name from public.autors", conn);
        NpgsqlDataReader dr = command.ExecuteReader();
        while (dr.Read())
            autors.Add(Convert.ToString(Convert.ToString(dr[0])));
        CloseConnection();
        return autors;
    }
}