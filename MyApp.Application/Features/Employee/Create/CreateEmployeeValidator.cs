using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Employee.Create
{
    public class CreateEmployeeValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeValidator()
        {
            RuleFor(x => x.EmployeeNumber).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
            RuleFor(x => x.DepartmentId).NotEmpty();
            RuleFor(x => x.PositionId).NotEmpty();
            RuleFor(x => x.EmploymentType).NotEmpty();
            RuleFor(x => x.EmploymentStatus).NotEmpty();
            RuleFor(x => x.HireDate).GreaterThan(DateOnly.FromDateTime(DateTime.Now)).NotEmpty();
            RuleFor(x => x.IsActive).NotEmpty();
        }
    }
}
