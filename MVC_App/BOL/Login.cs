namespace BOL;

public class Login
{
    public int Id{get;set;}
    public string Username{get;set;}
    public string Password{get;set;}

    public Login (int Id,string Username, string Password){
        this.Id=Id;
        this.Username=Username;
        this.Password=Password;
    }
}

