using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class WorkCalendar
    {
        public Guid CalendarId { get; private set; }
        public DayOfWeek DayOfWeek { get; private set; }
        public bool IsWorkingDay { get; private set; }

        
        protected WorkCalendar() { }
    }
}
