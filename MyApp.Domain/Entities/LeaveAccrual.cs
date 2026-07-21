using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveAccrual
    {
        public Guid LeaveAccrualId { get; private set; }

        public Guid EmployeeId { get; private set; }
        public Guid LeaveTypeId { get; private set; }

        public DateOnly AccrualDate { get; private set; }
        public decimal CreditsEarned { get; private set; }
        public string? Remarks { get; private set; }
        public string GeneratedBy { get; private set; } = string.Empty;
        public DateTime CreatedAt { get; private set; }

        public virtual Employees Employee { get; private set; } = null!;
        public virtual LeaveTypes LeaveType { get; private set; } = null!;

        protected LeaveAccrual() { }

        public LeaveAccrual(Guid employeeId, Guid leaveTypeId, DateOnly accrualDate, decimal creditsEarned, string? remarks, string generatedBy)
        {
            EmployeeId = employeeId;
            LeaveTypeId = leaveTypeId;
            AccrualDate = accrualDate;
            CreditsEarned = creditsEarned;
            Remarks = remarks;
            GeneratedBy = generatedBy;
            CreatedAt = DateTime.Now;
        }
    }
}

//Sample Data

//| LeaveAccrualId | EmployeeId     | LeaveTypeId    | AccrualDate    | CreditsEarned       | Remarks                       | GeneratedBy | CreatedAt           |
//| -------------- | ----------     | -----------    | -----------    | ------------        | -------                       | ----------- | ------------------- |
//| 8C7E...        | EMP001         | VL001          | 2026 - 01 - 31 | 1.25                | January 2026 Monthly Accrual  | System      | 2026-01-31 11:59 PM |
//| A91B...        | EMP001         | VL001          | 2026 - 02 - 28 | 1.25                | February 2026 Monthly Accrual | System      | 2026-02-28 11:59 PM |
//| 52DE...        | EMP001         | VL001          | 2026 - 03 - 31 | 1.25                | March 2026 Monthly Accrual    | System      | 2026-03-31 11:59 PM |
//| D124...        | EMP001         | VL001          | 2026 - 04 - 30 | 1.25                | April 2026 Monthly Accrual    | System      | 2026-04-30 11:59 PM |
