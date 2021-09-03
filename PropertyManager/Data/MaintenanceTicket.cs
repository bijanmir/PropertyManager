using System;
using PropertyManager.Models;

namespace PropertyManager.Data
{
    public class MaintenanceTicket
    {
        public string MaintenanceIssue { get; set; }
        public DateTime TimeSubmitted { get; set; }
        public string Urgency { get; set; }
        public Property Property { get; set; }

        
    }
}