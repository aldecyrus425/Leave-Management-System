using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveBalances
    {
        public Guid LeaveBalanceId { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Guid LeaveTypeId { get; private set; }

        public decimal CurrentBalance { get; private set; }
        public DateOnly? LastAccrualDate { get; private set; }
        public DateTime LastUpdated { get; private set; }
        public virtual Employees Employee { get; private set; } = null!;
        public virtual LeaveTypes LeaveType { get; private set; } = null!;

       protected LeaveBalances() { }
    }
}
