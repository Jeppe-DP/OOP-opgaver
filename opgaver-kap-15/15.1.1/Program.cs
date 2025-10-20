class Inventory {
    private List<Item> items = new List<Item>();
    public void AddItem(Item item)
    {
        items.Add(item);
    }
    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }
    public double GetInventoryValue(){
        double sum = 0;
        foreach(Item i in items)
            sum = sum + i.GetPrice();
        return sum;
    }
    public void PrintInventory()
    {
        foreach(Item i in items)
        {
            Console.Write(i.name + " ");
        }
    }
}

class Item {
    public string name;
    public double price;
    public Item (string nameValue, double priceValue)
    {
        name = nameValue;
        price = priceValue;
    }
    public string GetName ()
    {
        return name;
    }
    public double GetPrice ()
    {
        return price;
    }
}
class FoodItem : Item {
    private DateTime expiresAt;
    public FoodItem (string name, double price, DateTime expiresAtValue)
    : base(name, price) {
        expiresAt = expiresAtValue;
    }
    public DateTime GetExpiresAt () {
        return expiresAt;
    }
    public override string ToString () {
        return "FoodItem name='"+GetName()+"'"
        +" price='"+GetPrice()+"'"
        +" expiresAt='"+GetExpiresAt()+"'";
    }
    // comment out the Main method to use this class as the entry point of the program
    //public static void Main(string[] args) {
    // FoodItem[] items = new FoodItem[10];
    //
    // for (int i=0 ; i<items.Length ; i++) {
    // items[i] = new FoodItem($"Item {i}", 12.3 * i, DateTime.Now.AddDays(i));
    // }
    //
    // foreach (FoodItem item in items) {
    // Console.WriteLine(item);
    // }
    //}
}
class NonFoodItem : Item {
    public string[] materials;
    public NonFoodItem (string name, double price, string[] materialsValue)
    : base(name, price) {
        materials = materialsValue;
    }
    public string[] GetMaterials () {
        return materials;
    }
    public override string ToString () {
        string m = "[";
        for (int i=0 ; i<materials.Length ; i++) {
            m += (i == 0 ? "" : ",") + materials[i];
        }
        m += "]";
        return "NonFoodItem name='" + GetName()
        + "' price='" + GetPrice()
        + "' materials='" + m + "'";
    }

    // comment out the Main method to use this class as the entry point of the program
    //public static void Main (string[] args)
    //{
    // NonFoodItem[] items = new NonFoodItem[10];
    //
    // for (int i=0 ; i<items.Length ; i++) {
    // items[i] = new NonFoodItem("Item " + i, 12.3 * i,
    // new string[] { "butter", "cream" });
    // }
    //
    // foreach (NonFoodItem item in items) {
    // Console.WriteLine(item);
    // }
    //}
}
class Mixed
{
    // comment out the Main method to use this class as the entry point of the program
    static void Main (string[] args)
    {

    }

//        Item[] items = new Item[10];
//        for (int i=0 ; i<items.Length ; i++) {
//            if (i % 2 == 0) {
//                items[i] = new FoodItem("Item " + i, 12.3 * i,
//                                        new DateTime(i * 1000 * 60 * 60 * 24));
//            } else {
//                items[i] = new NonFoodItem("Item " + i, 12.3 * i,
//                                           new string[] { "butter", "cream" });
//            }
//        }
//        foreach (Item item in items) {
//            Console.WriteLine(item);
//        }
//    }
//}
