using System;
using FluentValidation;
using PlayingWithBlazor.Models;

namespace PlayingWithBlazor.Validation
{
    public class MelbourneHousePricesInputValidator : AbstractValidator<MelbourneHousePricesInput>
    {
        public MelbourneHousePricesInputValidator()
        {
            RuleFor(p => p.Address).NotEmpty().WithMessage("You must enter the company name")
                .MaximumLength(60).WithMessage("Company name cannot be longer than 50 characters");

            RuleFor(p => p.Rooms).NotNull().WithMessage("You must enter the number of rooms")
                .GreaterThanOrEqualTo(1).WithMessage("The number of rooms must be at least 1");

            RuleFor(p => p.SellerG).MaximumLength(50).WithMessage("Seller Name must not exceed 50 characters");

            // RuleFor(p => p.Date).Must(BeAValidDate).WithMessage("Invalid date");

            RuleFor(p => p.Distance).GreaterThan(0).WithMessage("Distance must me more than 0");

            RuleFor(p => p.Postcode).InclusiveBetween(3000, 9999);

            RuleFor(p => p.Bedroom2).NotNull().WithMessage("You must enter the number of bedrooms")
                .GreaterThanOrEqualTo(1).WithMessage("The number of bedrooms must be at least 1");
            
            RuleFor(p => p.Bathroom).NotNull().WithMessage("You must enter the number of bathrooms");

            RuleFor(p => p.YearBuilt).Must(BeAValidYear).WithMessage($"Year must be between 1600 and {DateTime.Today.Year}");


        }

        private bool BeAValidDate(string value)
        {
            DateTime date;
            return DateTime.TryParse(value, out date);
        }

        private bool BeAValidYear(float value)
        {
            return value > 1600 && value <= DateTime.Today.Year;
        }
    }
}