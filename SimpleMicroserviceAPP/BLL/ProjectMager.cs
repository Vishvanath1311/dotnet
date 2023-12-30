using BOL;
public class ProjectManager{

    public static List<Activities> GetAll(){
    List<Activities> items=new List<Activities>();
    items.Add(new Activities {Id=1, Name="Print", IsComplete=false});
    items.Add(new Activities{ Id=2, Name="Code", IsComplete=false});
    items.Add(new Activities{ Id=3, Name="Test", IsComplete=false});
    items.Add(new Activities{ Id=4, Name="Deploy", IsComplete=false});
    items.Add(new Activities{ Id=5, Name="Support", IsComplete=false});
    //Access list from DAL 
    return items;
}
}