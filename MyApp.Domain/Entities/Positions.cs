using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Positions
    {
        // Primary Key
        public Guid PositionId { get; private set; }

        // Properties
        public string PositionName { get; private set; } = string.Empty;
        public string? Description { get; private set; }

        // Audit Fields
        public bool IsActive { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public virtual ICollection<Employees> Employees { get; private set; } = new List<Employees>();

        // Required by EF Core
        protected Positions() { }
    }
}
