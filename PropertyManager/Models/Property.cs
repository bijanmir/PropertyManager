namespace PropertyManager.Models
{
    public class Property
    {
        public string Address { get; set; }
        public double Rent { get; set; }
        public Tenant Tenant { get; set; } = null;
        
    }
}