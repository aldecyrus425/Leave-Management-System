using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Departments
    {
        public Guid DepartmentId { get; private set; }

        public string DepartmentName { get; private set; } = string.Empty;
        public string? Description { get; private set; }

        public virtual ICollection<Employees> Employees { get; private set; } = new List<Employees>();

        protected Departments() { }

        public Departments(string departmentName, string? description)
        {
            DepartmentName = departmentName;
            Description = description;
        }
    }
}
