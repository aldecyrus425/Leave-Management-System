using MediatR;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Repository;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.LeaveAccrual.Create
{
    public class CreateLeaveAccrualHandler : IRequestHandler<CreateLeaveAccrualCommand, GenericResponse<string>>
    {
        private readonly ILeaveAccrualRepository _leaveAccrualRepo;
        private readonly IEmployeeRepository _employeeRepo;

        public CreateLeaveAccrualHandler(ILeaveAccrualRepository leaveAccrualRepo, IEmployeeRepository employeeRepo)
        {
            _leaveAccrualRepo = leaveAccrualRepo;
            _employeeRepo = employeeRepo;
        }

        public async Task<GenericResponse<string>> Handle(CreateLeaveAccrualCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var employeeList = await _employeeRepo.getActiveEmployees();

                foreach(var employee in employeeList)
                {
                    var isExisting = await _leaveAccrualRepo.getLeaveAccrualByEmployeeAndDate(request.EmployeeId, request.AccrualDate);
                    if(isExisting == null)
                    {
                        // Get the list of LeaveType then loop to insert each employee with all the leave types with the corresponding credit will earned.
                    }
                }

                return new GenericResponse<string>
                {
                    success = true,
                    message = "Accrual successfully executed."
                };
            }
            catch(Exception ex)
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
