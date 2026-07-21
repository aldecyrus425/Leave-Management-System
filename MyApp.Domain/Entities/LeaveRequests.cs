using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveRequests
    {
        public Guid LeaveRequestId { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Guid LeaveTypeId { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }
        public decimal WorkingDays { get; private set; }
        public string Reason { get; private set; } = string.Empty;
        public string Status { get; private set; } = string.Empty;
        public int CurrentApproverLevel { get; private set; }
        public DateTime RequestedDate { get; private set; }
        public DateTime? ApprovedDate { get; private set; }
        public DateTime? CancelledDate { get; private set; }
        public virtual Employees Employee { get; private set; } = null!;
        public virtual LeaveTypes LeaveType { get; private set; } = null!;
        
        protected LeaveRequests() { }
    }
}
