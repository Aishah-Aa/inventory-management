namespace sda_onsite_2_inventory_management.src
{
    public class Base
    {
        private readonly _id;
        private DateTime _createdAt;


        public Base()
        {
            _id++;

        }

        public DateTime GetCreatedAt()
        {
            return _createdAt;
        }
    }
}