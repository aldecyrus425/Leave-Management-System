using MediatR;
using MyApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Department.Create
{
    public class CreateDepartmentCommand : IRequest<GenericResponse<string>>
    {
        public string DepartmentName { get; set; }
        public string? DepartmentDescription { get; set; }
    }
}
