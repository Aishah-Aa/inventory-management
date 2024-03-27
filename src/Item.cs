namespace sda_onsite_2_inventory_management.src
{
  public class Item : Base
  {
    private string _name;

    private int _quantity;
    private readonly DateTime _createdAt;
    // var item1 = new Item{"fruits", -20}

    public Item(string name, int quantity, DateTime? createdAt)
    {
      _name = name;
      _quantity = quantity < 0 ? throw new ArgumentException("Quantity should be bigger than 0" : quantity);
      _createdAt = createdAt is null ? DateTime.Now: createdAt;
    }

    public string GetName()
    {
      return _name;
    }
    
    public int GetQuantity()
    {
      return _quantity;
    }

    

    


  }

};