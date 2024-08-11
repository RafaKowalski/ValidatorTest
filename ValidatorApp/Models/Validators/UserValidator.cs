using FluentValidation;

namespace ValidatorApp.Models.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .WithMessage("the Name not be empty");

            RuleFor(u => u.Name)
                .Matches(@"^[A-Za-z].*")
                .WithMessage("The name must init with letter");

            RuleFor(u => u.UserPermission)
                .IsInEnum()
                .WithMessage("enter a valid enum");

            RuleFor(u => u.UserPermission)
                .ToString();
        }
    }
}
