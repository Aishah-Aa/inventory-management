
using sda_onsite_2_inventory_management.src;

internal class Program {
    private static void Main(string[] args)
    {
        Store store = new("Market", 150);
        
        Item chocolate = new("Kinder bueno",43);
        Item cookies = new("classic",10);
        Item water = new("water",33);
        Item bread = new("toast",40);
        Item Juice = new("juice", 18);
        Item coffee = new("coffee",30);
        Item butter = new("butter",100);
        Item salt = new("salt",70);
        Item sugar = new("sugar",200);
        Item cheese = new("cheese",20);
        Item chips = new("chips", 80);
        Item cashew = new("cashew",180);

        List<Item> items = store.GetItems();
        Console.WriteLine("Count before" +items.Count);
        

        store.AddItem(chocolate);
        store.AddItem(cookies);
        store.AddItem(water);
        store.AddItem(bread);
        store.AddItem(Juice);
        store.AddItem(coffee);
        store.AddItem(butter);
        store.AddItem(salt);
        store.AddItem(sugar);
        store.AddItem(cheese);
        store.AddItem(chips);
        store.AddItem(cashew);
        

        Console.WriteLine($"current vol= {store.GetCurrentVolume()}");
        Console.WriteLine($"max cap = {store.GetMaximumCapacity()}");
        

        Console.WriteLine("Count After" +items.Count);
       
        
        foreach (Item item in items)
        {
            Console.WriteLine($"Name = {item.GetName()} Created_At = {item.GetCreatedAt()} Quantity = {item.GetQuantity()}");
            
        }
        Item? butter = store.FindByName("butter");
        if (butter is not null)
        {
            Console.WriteLine(butter.GetName());
            Console.WriteLine(butter.GetQuantity());
            
        }

       List<Item> sorted = store.SortByName(SortOrder.DESC);
        foreach (var item in sorted)
        {
            Console.WriteLine(item.GetName());
            
        }


    }
 







}