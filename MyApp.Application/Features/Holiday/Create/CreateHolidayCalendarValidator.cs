using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.Features.Holiday.Create
{
    public class CreateHolidayCalendarValidator : AbstractValidator<CreateHolidayCalendarCommand>
    {
        public CreateHolidayCalendarValidator()
        {
            RuleFor(x => x.HolidayName).NotEmpty();
            RuleFor(x => x.HolidayDate).NotEmpty();
            RuleFor(x => x.HolidayType).NotEmpty();
            RuleFor(x => x.IsRecurring).NotEmpty();
        }
    }
}
