using MediatR;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Repository;
using MyApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Holiday.Create
{
    public class CreateHolidayCalendarHandler : IRequestHandler<CreateHolidayCalendarCommand, GenericResponse<string>>
    {
        private readonly IHolidayCalendarRepository _holidayRepo;

        public CreateHolidayCalendarHandler(IHolidayCalendarRepository holidayRepo)
        {
            _holidayRepo = holidayRepo;
        }

        public async Task<GenericResponse<string>> Handle(CreateHolidayCalendarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var isExisting = await _holidayRepo.getHolidayByDateAsync(request.HolidayDate);
                if(isExisting != null)
                {
                    return new GenericResponse<string>
                    {
                        success = false,
                        message = "Holiday date conflict."
                    };
                }

                var holiday = new HolidayCalendar(request.HolidayName, request.HolidayDate, request.HolidayType, request.IsRecurring);
                await _holidayRepo.createHolidayAsync(holiday);

                return new GenericResponse<string>
                {
                    success = true,
                    message = "Holiday added successfully."
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
