using Microsoft.EntityFrameworkCore;
using MyApp.Application.Interfaces.Repository;
using MyApp.Domain.Entities;
using MyApp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repository
{
    public class HolidayCalendarRepository : IHolidayCalendarRepository
    {
        private readonly ApplicationDBContext _context;

        public HolidayCalendarRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task createHolidayAsync(HolidayCalendar holiday)
        {
            await _context.HolidayCalendars.AddAsync(holiday);
            await _context.SaveChangesAsync();
        }

        public Task<HolidayCalendar?> getHolidayByDateAsync(DateOnly date)
        {
            return _context.HolidayCalendars.FirstOrDefaultAsync(x => x.HolidayDate == date);
        }
    }
}
