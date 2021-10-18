using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerAPI.FiberConnection
{
    public partial class Billing
    {
        public Billing()
        {
            Statuses = new HashSet<Status>();
        }

        public int BillingNumber { get; set; }
        public int? CustomerId { get; set; }
        public int? PlanId { get; set; }
        public DateTime? BookedDate { get; set; }
        public string CustomerName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAadharNo { get; set; }
        public string CustomerMailId { get; set; }
        public string PlanName { get; set; }
        public string PlanPrice { get; set; }
        public double? Tax { get; set; }
        public double? Total { get; set; }
        public string PaymentMethod { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Status> Statuses { get; set; }
    }
}
