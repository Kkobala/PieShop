namespace PieShop.Accounting
{
    public class Customer
    {
        private string? customerId;
        private string? customerName;

        public string CustomerId { 
            get { return customerId!; }
            set 
            {
                customerId = value;
            }
        }

        public string Name
        { 
            get { return customerName!; }
            set
            {
                customerName = value;
            }
        }
    }
}
