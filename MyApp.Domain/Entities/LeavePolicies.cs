using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeavePolicies
    {
        public Guid LeavePolicyId { get; private set; }
        public Guid LeaveTypeId { get; private set; }
        public decimal AnnualCredits { get; private set; }
        public decimal MonthlyAccrualRate { get; private set; }
        public decimal MaximumCarryOver { get; private set; }
        public int MinimumServiceMonths { get; private set; }
        public int AdvanceNoticeDays { get; private set; }
        public bool AllowNegativeBalance { get; private set; }
        public bool ResetEveryYear { get; private set; }
        public bool CashConvertible { get; private set; }
        public DateOnly EffectiveDate { get; private set; }
        public DateOnly? ExpirationDate { get; private set; }
        public virtual LeaveTypes LeaveType { get; private set; } = null!;

        protected LeavePolicies() { }
    }
}
