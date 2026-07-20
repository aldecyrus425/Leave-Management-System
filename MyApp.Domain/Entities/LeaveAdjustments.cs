using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveAdjustments
    {
        public Guid AdjustmentId { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Guid LeaveTypeId { get; private set; }
        public string AdjustmentType { get; private set; } = string.Empty;
        public decimal Amount { get; private set; }
        public string Reason { get; private set; } = string.Empty;
        public string AdjustedBy { get; private set; } = string.Empty;
        public DateTime AdjustedDate { get; private set; }
        public virtual Employees Employee { get; private set; } = null!;
        public virtual LeaveTypes LeaveType { get; private set; } = null!;

        protected LeaveAdjustments() { }
    }
}
