using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class HolidayCalendar
    {
        // Primary Key
        public Guid HolidayId { get; private set; }

        // Holiday Details
        public string HolidayName { get; private set; } = string.Empty;
        public DateOnly HolidayDate { get; private set; }
        public string HolidayType { get; private set; } = string.Empty;
        public bool IsRecurring { get; private set; }

        protected HolidayCalendar() { }
    }
}
