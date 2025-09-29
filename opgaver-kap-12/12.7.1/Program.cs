class Program
{
    static void Main(string[] args)
    {
        Customer a = new Customer("ole", 1, 200.5);

        a.Deposit(100);

        Console.WriteLine(Convert.ToString(a.GetBalance));
    }
}
