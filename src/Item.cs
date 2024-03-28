namespace sda_onsite_2_inventory_management.src
{
  public class Item : Base
  {
    private readonly string _name;

    private readonly Guid _id = Guid.NewGuid();
    private int _quantity;
    private readonly DateTime _createdAt;
    public int Quantity
    {
      get
      {
        return _quantity;
      }
      set
      {
        if (value < 0)
        {
          throw new ArgumentOutOfRangeException("Quantity cannot be negative");
        }
        else
        {
          _quantity = value;
        }
      }

    }


    public Item(string name, int quantity, DateTime createdAt)
    {
      _name = name;
      Quantity = quantity;
      _createdAt = createdAt;
    }
    public Item(string name, int quantity)
    {
      _name = name;
      Quantity = quantity;
      _createdAt = DateTime.Now;
    }

    public string GetName()
    {
      return _name;
    }

    public int GetQuantity()
    {
      return _quantity;
    }
    public int GetCreatedAt()
    {
      return _createdAt;
    }
    public int GetId()
    {
      return _id;
    }
  }
};