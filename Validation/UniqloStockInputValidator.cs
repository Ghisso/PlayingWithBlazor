using System;
using FluentValidation;
using PlayingWithBlazor.Models;

namespace PlayingWithBlazor.Validation
{
    public class UniqloStockInputValidator : AbstractValidator<UniqloStockInput>
    {
        public UniqloStockInputValidator()
        {
            RuleFor( stockinfo => stockinfo.Low).NotEmpty().WithMessage("You must input a value.")
                .Must( (stockinfo, low) => low <= stockinfo.High).WithMessage("Low value must be inferior or equal to High.");


            RuleFor( stockinfo => stockinfo.High).NotEmpty().WithMessage("You must input a value.")
                .Must( (stockinfo, high) => high >= stockinfo.Low).WithMessage("High value must be superior or equal to Low.");


            RuleFor( stockinfo => stockinfo.Open).NotEmpty().WithMessage("You must input a value.")
                .Must( (stockinfo, open) => open >= stockinfo.Low && open <= stockinfo.High).WithMessage("Open value must be between Low and High values.");
            

            RuleFor( stockinfo => stockinfo.Volume).NotEmpty().WithMessage("You must input a value.");
        }
    }
}