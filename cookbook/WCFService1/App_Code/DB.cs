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

    public List<string> GetKitchens()
    {
        List<string> autors = new List<string>();
        OpenConnection();
        var command = new NpgsqlCommand("select kitchen_name from public.kitchen", conn);
        NpgsqlDataReader dr = command.ExecuteReader();
        while (dr.Read())
            autors.Add(Convert.ToString(Convert.ToString(dr[0])));
        CloseConnection();
        return autors;
    }

    public void AddRecepts(string name, string autor, string kitchen, string howto, string category, string description, string calories,
                           string ingred1, int measurec1, string measure1, string ingred2, int measurec2, string measure2,
                           string ingred3, int measurec3, string measure3, string ingred4, int measurec4, string measure4,
                           string ingred5, int measurec5, string measure5)
    {
        List<string> names = new List<string>();
        names.Add(ingred1); names.Add(ingred2); names.Add(ingred3); names.Add(ingred4); names.Add(ingred5);
        List<int> ingredsIds = new List<int>();
        List<int> measureIds = new List<int>();
        OpenConnection();
        for (int i = 0; i < names.Count; i++)
        {
            var command = new NpgsqlCommand("select ingred_id from public.ingredients where ingred_name = " + names[i], conn);
            ingredsIds.Add( (int) command.ExecuteScalar());
        }
        names.Clear();
        names.Add(measure1); names.Add(measure2); names.Add(measure3); names.Add(measure4); names.Add(measure5);
        for (int i = 0; i < names.Count; i++)
        {
            var command = new NpgsqlCommand("select measure_id from public.measure where measure_name = " + names[i], conn);
            measureIds.Add( (int) command.ExecuteScalar());
        }
        var cmd = new NpgsqlCommand();

        cmd = new NpgsqlCommand("select autor_id form public.autor where autor_name = " + autor, conn);
        int autorId = (int)cmd.ExecuteScalar();

        cmd = new NpgsqlCommand("select category_id form public.category where category_name = " + category, conn);
        int categoryId = (int)cmd.ExecuteScalar();

        cmd = new NpgsqlCommand("select howto_id form public.howtocook where howto_name = " + howto, conn);
        int howtoId = (int)cmd.ExecuteScalar();

        cmd = new NpgsqlCommand("select kitchen_id form public.kitchen where kitchen_name = " + kitchen, conn);
        int kitchenId = (int) cmd.ExecuteScalar();

        cmd = new NpgsqlCommand("insert into public.recept (recept_name, category_id, autor_id, howto_id," +
                                "kitchen_id, calories, description) values ("+name+","+categoryId+","+
                                autorId+","+howtoId+","+kitchenId+","+calories+","+description+")", conn);
        cmd.ExecuteScalar();

        cmd = new NpgsqlCommand("select recept_id from public.recepts", conn);
        NpgsqlDataReader dr = cmd.ExecuteReader();
        int receptId = 0;
        while (dr.Read())
            receptId = (int) dr[0];

       // cmd = new NpgsqlCommand("insert into public.composition (ingred_id, recept_id, measur_id, ammount) values ("+

    }
}