using CareerPortal.MvcWebUI.Areas.HomePage.Models;
using FluentValidation;

namespace CareerPortal.MvcWebUI.ValidationRules.FluentValidation.JobGiver
{
    public class JobGiverLoginModelValidator:AbstractValidator<JobGiverLoginModel>
    {
        public JobGiverLoginModelValidator()
        {
            RuleFor(s => s.Email).NotEmpty();
            RuleFor(s => s.Email).EmailAddress();
            RuleFor(s => s.Email).MaximumLength(100);

            RuleFor(s => s.Password).NotEmpty();
        }
    }
}
