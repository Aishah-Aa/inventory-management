using System.Text;

namespace sda_onsite_2_inventory_management.src
{
    public class Store
    {
        private readonly string _name;
        private readonly List<Item> _items;
        private readonly int _maximumCapacity;


        public Store(string name, int maximumCapacity)
        {
            _name = name;
            _maximumCapacity = maximumCapacity;
            _items = [];
        }

        public List<Item> SortByName(SortOrder Order)
        {
            if (order == SortOrder.ASC)
            {
                return _items.OrderBy(item => item.GetName()).ToList();
            }

            if (order == SortOrder.DESC)
            {
                return _items.OrderByDescending(item => item.GetName()).ToList();
            }

            return _items;
        }

        public List<Item> SortByDate(SortOrder sortOrder)
        {
            if (order == SortOrder.ASC)
            {
                var asc = _items.OrderBy(i => i.GetCreatedAt()).ToList();

                return asc;
            }

            if (order == SortOrder.DESC)
            {
                var desc = _items.OrderByDescending(item => item.GetName()).ToList();
                return desc;
            }

            return _items;

        }



        public void GroupByDate()
        {
            var grouped = _items.GroupBy(item =>
            {
                double timeDiffrenceInDays = (DateTime.Now - item.GetCreatedAt()).TotalDays;
                if (timeDiffrenceInDays < 90)
                {
                    return "new";
                }
                else
                {
                    return "old";
                }
            });
            return grouped;
        }

        public Item? FindByName(string targetItem)
        {
            return _items.Find(item => item.GetName() == targetItem.GetName());
        }

        public bool AddItem(Item newItem)
        {
            int availableSpace = GetMaximumCapacity() - GetCurrentVolume();


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
            int totalAmount = _items.Sum(item => item.GetQuantity());

            return totalAmount;
        }
        public int GetMaximumCapacity()
        {
            return _maximumCapacity;
        }
    }

}
