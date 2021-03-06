using Domain.Abstractions.Mediator;
using Domain.Extensions;
using FluentValidation;

namespace Domain.UseCases.Account.Register
{
    public class RegisterInput: IUseCaseInput
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class RegisterInputValidator : AbstractValidator<RegisterInput>
    {
        public RegisterInputValidator()
        {
            RuleFor(x => x.Password)
                .ValidatePassword();

            RuleFor(x => x.Username)
                .ValidateUsername();
        }
    }
}