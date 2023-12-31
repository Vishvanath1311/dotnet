namespace DAL;
using MySql.Data.MySqlClient;
using BOL;

public static class DBManager
{
    public static List<Login> FindAllData(){
        List<Login> plist=new List<Login>();
        //192.168.0.101
        MySqlConnection connection=new MySqlConnection();
        connection.ConnectionString="server=Localhost; port=3306; user=root; password=13@Panther; database=students";
        string query="select * from Login";
        MySqlCommand command=new MySqlCommand(query, connection);

        try
        {
            connection.Open();
            MySqlDataReader reader=command.ExecuteReader();

            while(reader.Read())
            {
                int id= int.Parse(reader["Id"].ToString());
                string name=reader["Username"].ToString();
                string pwd=reader["Password"].ToString();

                Login l= new Login(id,name,pwd);
                plist.Add(l);
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {
            connection.Close();
        }
    return plist;
    }
    
}
