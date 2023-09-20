using FluentValidation;
using Mc2.CrudTest.Presentation.Domain;
using PhoneNumbers;

namespace Mc2.CrudTest.Presentation.Infrustructure.Validators
{
    //public class CustomerValidator : AbstractValidator<Customer>
    //{
    //    public CustomerValidator()
    //    {
    //        RuleFor(x => x.FirstName).Equal("Ali").WithMessage("Should be Ali");
    //        RuleFor(x => x.PhoneNumber)
    //            .Custom((x, context) =>
    //            {
    //                if (!isValidMobileNumber(x))
    //                {
    //                    context.AddFailure("This is not valid phone number");
    //                }
    //            });
    //    }

    //    public static bool isValidMobileNumber(string phone)
    //    {
    //        var phoneNumberUtil = PhoneNumberUtil.GetInstance();
    //        var phoneNumber = phoneNumberUtil.Parse(phone, "US");

    //        return phoneNumberUtil.IsValidNumberForRegion(phoneNumber, "US");
    //    }
    //}
}
