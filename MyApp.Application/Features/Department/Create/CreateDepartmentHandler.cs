using MediatR;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Repository;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Department.Create
{
    public class CreateDepartmentHandler : IRequestHandler<CreateDepartmentCommand, GenericResponse<string>>
    {
        private readonly IDepartmentRepository _departmentRepo;

        public CreateDepartmentHandler(IDepartmentRepository departmentRepo) 
        {
            _departmentRepo = departmentRepo;
        }

        public async Task<GenericResponse<string>> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var isExisting = await _departmentRepo.getDepartmentByNameAsync(request.DepartmentName);
                if(isExisting != null)
                {
                    return new GenericResponse<string>
                    {
                        success = false,
                        message = "Department name already existing."
                    };
                }

                var department = new Departments(request.DepartmentName, request.DepartmentDescription);
                await _departmentRepo.createDepartmentAsync(department);

                return new GenericResponse<string>
                {
                    success = true,
                    message = "Department added successfully."
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
