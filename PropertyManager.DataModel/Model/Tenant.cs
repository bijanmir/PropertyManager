using System.ComponentModel.DataAnnotations.Schema;

namespace PropertyManager.DataModel.Model
{
    [Table("tenant")]
    public class Tenant
    {
        [Column("tenant_id")]
        public int TenantId { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}