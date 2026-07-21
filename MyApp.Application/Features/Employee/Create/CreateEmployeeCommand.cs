using MediatR;
using MyApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Employee.Create
{
    public class CreateEmployeeCommand : IRequest<GenericResponse<string>>
    {
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }

        public Guid DepartmentId { get; set; }
        public Guid PositionId { get; set; }
        public string EmploymentType { get; set; }
        public string EmploymentStatus { get; set; }

        public DateOnly HireDate { get; set; }
        public DateOnly? RegularizationDate { get; set; }

        public bool IsActive { get; set; }
    }
}
