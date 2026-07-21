using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Employees
    {
        public Guid EmployeeId { get; private set; }

        public string EmployeeNumber { get; private set; } = string.Empty;
        public string FirstName { get; private set; } = string.Empty;
        public string? MiddleName { get; private set; }
        public string LastName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string? Phone { get; private set; }

        public Guid DepartmentId { get; private set; }
        public Guid PositionId { get; private set; }
        public string EmploymentType { get; private set; } = string.Empty;
        public string EmploymentStatus { get; private set; } = string.Empty;

        public DateOnly HireDate { get; private set; }
        public DateOnly? RegularizationDate { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public virtual Departments Department { get; private set; } = null!;
        public virtual Positions Position { get; private set; } = null!;

        protected Employees() { }
    }
}
