using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveBalances
    {
        // Primary Key
        public Guid LeaveBalanceId { get; private set; }

        // Foreign Keys
        public Guid EmployeeId { get; private set; }
        public Guid LeaveTypeId { get; private set; }

        // Balance
        public decimal CurrentBalance { get; private set; }
        public DateOnly? LastAccrualDate { get; private set; }
        public DateTime LastUpdated { get; private set; }

        // Navigation Properties
        public virtual Employees Employee { get; private set; } = null!;
        public virtual LeaveTypes LeaveType { get; private set; } = null!;

       protected LeaveBalances() { }
    }
}
