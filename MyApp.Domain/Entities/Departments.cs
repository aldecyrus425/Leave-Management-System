using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Departments
    {
        // Primary Key
        public Guid DepartmentId { get; private set; }

        // Properties
        public string DepartmentName { get; private set; } = string.Empty;
        public string? Description { get; private set; }

        // Navigation Properties
        public virtual ICollection<Employees> Employees { get; private set; } = new List<Employees>();

    }
}
