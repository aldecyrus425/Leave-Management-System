using MediatR;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Repository;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Employee.Create
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, GenericResponse<string>>
    {
        private readonly IEmployeeRepository _employeeRepo;
        public CreateEmployeeHandler(IEmployeeRepository employeeRepo) 
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<GenericResponse<string>> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var isExistingEmail = await _employeeRepo.getEmployeeByEmailAsync(request.Email);
                if(isExistingEmail != null)
                {
                    return new GenericResponse<string>
                    {
                        success = false,
                        message = "Email already existing."
                    };
                }

                var employee = new Employees(request.EmployeeNumber, request.FirstName, request.MiddleName, request.LastName, request.Email, request.Phone, request.DepartmentId, request.PositionId, request.EmploymentType, request.EmploymentStatus, request.HireDate, request.RegularizationDate, request.IsActive);
                await _employeeRepo.createEmployeeAsync(employee);

                return new GenericResponse<string>
                {
                    success = true,
                    message = "Employee added successfully."
                };
            }
            catch (Exception ex)
            {
                return new GenericResponse<string>
                {
                    success = false,
                    message = ex.Message
                };
            }
        }
    }
}
