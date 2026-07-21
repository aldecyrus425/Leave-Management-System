using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveLedger
    {
        public Guid LeaveLedgerId { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Guid LeaveTypeId { get; private set; }
        public string ReferenceType { get; private set; } = string.Empty;
        public Guid ReferenceId { get; private set; }
        public string TransactionType { get; private set; } = string.Empty;
        public decimal Credit { get; private set; }
        public decimal Debit { get; private set; }
        public decimal BalanceAfterTransaction { get; private set; }
        public DateTime TransactionDate { get; private set; }
        public string? Remarks { get; private set; }
        public string CreatedBy { get; private set; } = string.Empty;
        public virtual Employees Employee { get; private set; } = null!;
        public virtual LeaveTypes LeaveType { get; private set; } = null!;

        protected LeaveLedger() { }
    }
}
