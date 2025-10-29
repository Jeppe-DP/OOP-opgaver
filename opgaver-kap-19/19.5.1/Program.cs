class Person
{
    private string name;
    private int age;
    private string cpr;

    public Person(string name, int age, string cpr)
    {
        this.name = name;
        this.age = age;
        this.cpr = cpr;
    }
    public string GetName()
    {
        return name;
    }
    public int GetAge()
    {
        return age;
    }
    public string GetCpr()
    {
        return  cpr;
    }
    public override string ToString()
    {
        return "name = " + name + "  age = " + age + "  cpr = " + cpr;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Person Jens = new Person("Jens", 20, "020202-0202");
        Person Kalle = new Person("Kalle", 30, "020202-0202");
        Person Marianne = new Person("Marianne", 25, "010101-0101");
        Person Ida = new Person("Ida", 28, "020202-0202");
        Person Torben = new Person("Torben", 80, "020202-0202");

        List<Person> personer = new List<Person>{Jens, Kalle, Marianne, Ida, Torben};

        foreach(Person person in personer){
            if (person.GetCpr() == "010101-0101")
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}

