using System;
class BankAccount
{
    public string AccountNumber { get; }      
    public string OwnerName { get; set; }    
    public double Balance { get; private set; }  

    public BankAccount(string account_num, string owner_name)
    {
        AccountNumber = account_num;
        OwnerName = owner_name;
        Balance = 0; 
    }
    public BankAccount(string account_num, string owner_name, double _initi)
    {
        AccountNumber = account_num;
        OwnerName = owner_name;
        Balance = _initi;
    }
    public void Deposit(double amount)
    {
        if (amount > 0){
            Balance = Balance + amount;
}
        else{
            Console.WriteLine(" The amount must be greater than 0 ");
}
    }
    public void Withdraw(double amount)
    {
        if (amount <= 0){
            Console.WriteLine(" The amount must be greater than 0 ");
            }
              else if (amount > Balance) {
                     Console.WriteLine(" U can not withdraw an amount greater than the current balance ^_^ ");
                  }
        else{
            Balance = Balance - amount;
                   }
     }
class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("123", "Ali");
        acc1.Deposit(500);
        acc1.Withdraw(200);
        Console.WriteLine(acc1.Balance); //300
    }
 }
}  
