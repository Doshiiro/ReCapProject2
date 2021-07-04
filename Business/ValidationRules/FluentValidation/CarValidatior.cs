using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidatior : AbstractValidator<Car>
    {
        public CarValidatior()
        {
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.CarName).MinimumLength(1);
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            //RuleFor(c => c.Description).Must(StartWithA).WithMessage("Açıklama 'A' ile başlamalı");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
