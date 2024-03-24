namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {
        private readonly string _name;
        private List<Item> _items;
    

         public Store(string name)
         {
            _name = name;
            _items = [];
         }

         public bool AddItem(Item newItem)
        {
           _items.Add(newItem);
            return true;
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
 }   
}