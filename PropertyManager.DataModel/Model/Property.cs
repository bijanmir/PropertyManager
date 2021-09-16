using System.Collections.Generic;

namespace PropertyManager.DataModel.Model
{
    public class Property
    {
        public int PropId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int RentCost { get; set; }
    }
}