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
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDBContext _context;

        public DepartmentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task createDepartmentAsync(Departments departments)
        {
            await _context.Departments.AddAsync(departments);
            await _context.SaveChangesAsync();
        }

        public async Task<Departments?> getDepartmentByNameAsync(string name)
        {
            return await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentName == name)
        }
    }
}
