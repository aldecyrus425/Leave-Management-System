using MediatR;
using MyApp.Application.DTOs;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.LeaveAccrual.Create
{
    public class CreateLeaveAccrualCommand : IRequest<GenericResponse<string>>
    {
        public Guid EmployeeId { get; set; }
        public Guid LeaveTypeId { get; set; }
        public DateOnly AccrualDate { get; set; }
        public decimal CreditsEarned { get; set; }
        public string? Remarks { get; set; }
        public string GeneratedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
