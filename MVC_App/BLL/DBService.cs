namespace BLL;
using BOL;
using DAL;

public class DBService
{
    public static List<Login> AllData()
    {
        List<Login> list=DBManager.FindAllData();
        return list;
    }

}
