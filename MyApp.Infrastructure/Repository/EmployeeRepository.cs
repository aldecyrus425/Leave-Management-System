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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDBContext _context;

        public EmployeeRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task createEmployeeAsync(Employees employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employees>> getActiveEmployees()
        {
            return await _context.Employees.Where(x => x.IsActive).ToListAsync();
        }

        public async Task<Employees?> getEmployeeByEmailAsync(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
