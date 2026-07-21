using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveTypes
    {
        public Guid LeaveTypeId { get; private set; }
        public string Code { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;
        public string? Description { get; private set; }

        public bool IsPaid { get; private set; } // This is to identify if the employee may still recieved a salary even he/she is on leave.
        public bool IsAccruable { get; private set; }
        public bool RequiresApproval { get; private set; }
        public bool RequiresMedicalCertificate { get; private set; }
        public int MaximumConsecutiveDays { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public virtual ICollection<LeaveRequests> LeaveRequests { get; private set; } = new List<LeaveRequests>();
        public virtual ICollection<LeaveBalances> LeaveBalances { get; private set; } = new List<LeaveBalances>();

        protected LeaveTypes() { }  
    }
}
