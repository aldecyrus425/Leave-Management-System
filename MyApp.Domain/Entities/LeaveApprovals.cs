using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveApprovals
    {
        // Primary Key
        public Guid LeaveApprovalId { get; private set; }

        // Foreign Keys
        public Guid LeaveRequestId { get; private set; }
        public Guid ApproverId { get; private set; }

        // Approval Details
        public int ApprovalLevel { get; private set; }
        public string Status { get; private set; } = string.Empty;
        public string? Remarks { get; private set; }
        public DateTime? ActionDate { get; private set; }

        // Navigation Properties
        public virtual LeaveRequests LeaveRequest { get; private set; } = null!;
        public virtual Employees Approver { get; private set; } = null!;

        protected LeaveApprovals() { }
    }
}
