namespace Banking;
public class Account{
    public float Balance{get;set;}

    public void Deposite(float amount){
        Console.WriteLine("Deposited Amount: " + amount);
        this.Balance=this.Balance+amount;
    }

    public void Withdraw(float amount){
        Console.WriteLine("Amount Withdrawn: " + amount);
        this.Balance=this.Balance-amount;
    }
}