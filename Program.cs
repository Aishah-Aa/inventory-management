
using sda_onsite_2_inventory_management.src;

internal class Program {
    private static void Main(string[] args)
    {
        Store store = new("Market");
        Item chocolate = new("Kinder bueno",430);
        Item cookies = new("classic",100);

        List<Item> items = store.GetItems();

        store.AddItem(chocolate);
        store.AddItem(cookies);

        Console.WriteLine(items.Count);
        Console.WriteLine(chocolate.GetName());
        Console.WriteLine(cookies.GetName());
        
        foreach (Item item in items)
        {
            Console.WriteLine($"Name = {item.GetName()} Created_At = {item.GetCreatedAt()} Quantity = {item.GetQuantity()}");
            
        }

    }
 







}