using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Interfaces.Repository
{
    public interface IHolidayCalendarRepository
    {
        Task createHolidayAsync(HolidayCalendar holiday);
        Task<HolidayCalendar?> getHolidayByDateAsync(DateOnly date);
    }
}
