using Banking;

Account acct=new Account();
acct.Balance=150000;
Console.WriteLine(acct.Balance);

acct.Deposite(25000);
Console.WriteLine("Current Balance: "+acct.Balance);

acct.Withdraw(10000);
Console.WriteLine("Current Balance: "+acct.Balance);