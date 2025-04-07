using FluentValidation;
using TaskManagementSystem.Services.PersonServices.Dtos;

namespace TaskManagementSystem.Validators
{
    public class PersonValidator : AbstractValidator<CreatePersonDto>
    {
        public PersonValidator()
        {
            RuleFor(x => x.CreateUserDto.Name).NotEmpty().WithMessage("Please type in something");
            RuleFor(x => x.CreateUserDto.EmailAddress).EmailAddress().WithMessage("Bruv, this must be an email");
        }
    }
}
