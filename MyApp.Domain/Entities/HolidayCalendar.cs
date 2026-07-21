using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class HolidayCalendar
    {
        public Guid HolidayId { get; private set; }

        public string HolidayName { get; private set; } = string.Empty;
        public DateOnly HolidayDate { get; private set; }
        public string HolidayType { get; private set; } = string.Empty; // It determines that if it is regular, special non-working, company, local holiday
        public bool IsRecurring { get; private set; } // it determine if the holiday is yearly repeated like christmas, newyears.

        protected HolidayCalendar() { }

        public HolidayCalendar(string holidayName, DateOnly holidayDate, string holidayType, bool isRecurring)
        {
            HolidayName = holidayName;
            HolidayDate = holidayDate;
            HolidayType = holidayType;
            IsRecurring = isRecurring;
        }
    }
}
