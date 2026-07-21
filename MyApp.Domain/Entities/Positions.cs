using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class Positions
    {
        public Guid PositionId { get; private set; }
        public string PositionName { get; private set; } = string.Empty;
        public string? Description { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }

        public virtual ICollection<Employees> Employees { get; private set; } = new List<Employees>();
        protected Positions() { }
    }
}
