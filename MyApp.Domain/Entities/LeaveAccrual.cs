using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveAccrual
    {
        // Primary Key
        public Guid LeaveAccrualId { get; private set; }

        // Foreign Keys
        public Guid EmployeeId { get; private set; }
        public Guid LeaveTypeId { get; private set; }

        // Accrual Details
        public DateOnly AccrualDate { get; private set; }
        public decimal CreditsEarned { get; private set; }
        public string? Remarks { get; private set; }
        public string GeneratedBy { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }

        // Navigation Properties
        public virtual Employees Employee { get; private set; } = null!;
        public virtual LeaveTypes LeaveType { get; private set; } = null!;

        protected LeaveAccrual() { }
    }
}
