using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManager.DataModel.Model
{
    [Table("property")]
    public class Property
    {
        [Column("prop_id")]
        [Key]
        public int PropId { get; set; }
        [Column("street_address")]
        public string StreetAddress { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("state")]
        public string State { get; set; }
        [Column("zip_code")]
        public int ZipCode { get; set; }
        [Column("rent_cost")]
        public int RentCost { get; set; }
    }
}