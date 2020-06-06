using CareerPortal.MvcWebUI.Areas.HomePage.Models;
using FluentValidation;

namespace CareerPortal.MvcWebUI.ValidationRules.FluentValidation.JobSeeker
{
    public class JobSeekerLoginModelValidator : AbstractValidator<JobSeekerLoginModel>
    {
        public JobSeekerLoginModelValidator()
        {
            RuleFor(s => s.Email).NotEmpty();
            RuleFor(s => s.Email).EmailAddress();
            RuleFor(s => s.Email).MaximumLength(100);

            RuleFor(s => s.Password).NotEmpty();
        }
    }
}
