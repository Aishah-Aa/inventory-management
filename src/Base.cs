namespace sda_onsite_2_inventory_management.src
{
    public class Base
    {
        private int _id;
        private DateTime _createdAt;


        public Base()
        {
            _id++;
            _createdAt = DateTime.Now;

        }

        public DateTime GetCreatedAt()
        {
            return _createdAt;
        }

    }

}