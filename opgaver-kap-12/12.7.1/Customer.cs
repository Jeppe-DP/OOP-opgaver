public class Customer
{
    public string name;
    public int id;
    public double balance;

    public Customer (string name, int id)
    {
        this.name = name;
        this.id = id;
    }
    public Customer (string name, int id, double balance)
    {
        this.name = name;
        this.id = id;
        this.balance = balance;
    }
    public void Deposit(double amount)
    {
        balance = balance + amount;
    }
    public void Withdraw(double amount)
    {
        if (amount < balance)
            balance = balance - amount;
    }
    public double GetBalance()
    {
        return balance;
    }
}
