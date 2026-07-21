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
    public class LeaveAccrualRepository : ILeaveAccrualRepository
    {
        private readonly ApplicationDBContext _context;

        public LeaveAccrualRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task createLeaveAccrual(LeaveAccrual entry)
        {
            await _context.LeaveAccrual.AddAsync(entry);
        }

        public async Task<LeaveAccrual?> getLeaveAccrualByEmployeeAndDate(Guid employeeId, DateOnly date)
        {
            return await _context.LeaveAccrual.Where(x => x.AccrualDate == date && x.EmployeeId == employeeId).FirstOrDefaultAsync();
        }
    }
}
