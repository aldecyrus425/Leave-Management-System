using MediatR;
using MyApp.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Holiday.Create
{
    public class CreateHolidayCalendarCommand : IRequest<GenericResponse<string>>
    {
        public string HolidayName { get; set; }
        public DateOnly HolidayDate { get; set; }
        public string HolidayType { get; set; } 
        public bool IsRecurring { get; set; }
    }
}
