namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {
        private readonly string _name;
        private readonly List<Item> _items;
        private readonly int _maximumCapacity;


        public Store(string name, int maximumCapacity;)
         {
            _name = name;
            _maximumCapacity = maximumCapacity;
            _items = [];
         }

    public List<Item> SortByName(SortOrder sortOrder)
    {
        if (order == SortOrder.DESC)
        {
            return _items.OrderByDecending(item => item.GetName()).ToList();
        }

        if (order == SortOrder.ASC)
        {
            return _items.OrderBy(item => item.GetName()).ToList();
        }

        return _items;
    }

    public Item? FindByName(string targetItem)
    {
        return _items.Find(item => item.GetName() == targetItem.GetName());
    }

    public bool AddItem(Item newItem)
    {
        int availableSpace = GetMaximumCapacity() - GetCurrentVolume();
        Console.WriteLine($"availableSpace {availableSpace}");

        if (availableSpace < newItem.GetQuantity())
        {
            throw ArgumentException("Maximum Capacity should not be exceeded!");
        }
        bool foundItem = _items.Contains(newItem);

        if (!foundItem)
        {
            _items.Add(newItem);
            return true;
        }
        return false;
    }
    public bool RemoveItem(Item item)
    {
        _items.Remove(item);
        return true;
    }

    public List<Item> GetItems()
    {
        return _items;
    }

    public List<Item> GetName()
    {
        return _name;
    }

    public int GetCurrentVolume()
    {
        int totalAmount = 0;
        foreach (Item item in _items)
        {
            totalAmount += item.GetQuantity();
        }
        return totalAmount;
    }
    public int GetMaximumCapacity()
    {
        return _maximumCapacity;
    }
}   
}