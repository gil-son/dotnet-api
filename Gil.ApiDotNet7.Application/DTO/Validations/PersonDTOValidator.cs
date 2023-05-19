using System;
using FluentValidation;
namespace Gil.ApiDotNet7.Application.DTO.Validations{
    public class PersonDTOValidator : AbstractValidator<PersonDTO>
    {
        public PersonDTOValidator()
        {
            RuleFor(x => x.Document)
                .NotEmpty()
                .NotNull()
                .WithMessage("The document is required!");

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("The name is required!");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .NotNull()
                .WithMessage("The phone is required!");
        }
    }
}


