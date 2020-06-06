using CareerPortal.MvcWebUI.Areas.HomePage.Models;
using FluentValidation;

namespace CareerPortal.MvcWebUI.ValidationRules.FluentValidation.JobSeeker
{
    public class JobSeekerSignUpModelValidator : AbstractValidator<JobSeekerSignUpModel>
    {
        public JobSeekerSignUpModelValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty();
            RuleFor(s => s.FirstName).MaximumLength(50);

            RuleFor(s => s.LastName).NotEmpty();
            RuleFor(s => s.LastName).MaximumLength(50);

            RuleFor(s => s.Email).NotEmpty();
            RuleFor(s => s.Email).EmailAddress();

            RuleFor(s => s.Password).NotEmpty();
            RuleFor(s => s.Password).Matches(x => x.ConfirmPassword);
            //RuleFor(s => s.Password)
            //.Equal(s => s.ConfirmPassword)
            //.When(s => !String.IsNullOrWhitespace(s.Password));
        }
    }
}
