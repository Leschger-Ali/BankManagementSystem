//using BankManagementSystem.Business.Validations;

//namespace BankManagementSystem.BLL.Validators;

//public static class CustomerValidator
//{
//    public static List<string> Validate(Customer customer)
//    {
//        List<string> errors = new();

//        if (!CommonValidator.IsValidName(customer.FirstName))
//            errors.Add("First name is invalid.");

//        if (!CommonValidator.IsValidName(customer.LastName))
//            errors.Add("Last name is invalid.");

//        if (!CommonValidator.IsValidEmail(customer.Email))
//            errors.Add("Email address is invalid.");

//        if (!CommonValidator.IsValidPhoneNumber(customer.PhoneNumber))
//            errors.Add("Phone number is invalid.");

//        if (!CommonValidator.IsNotFutureDate(customer.DateOfBirth))
//            errors.Add("Date of birth cannot be in the future.");

//        if (customer.DateOfBirth > DateTime.Today.AddYears(-18))
//            errors.Add("Customer must be at least 18 years old.");

//        return errors;
//    }

//    public static bool IsValid(Customer customer)
//    {
//        return Validate(customer).Count == 0;
//    }
//}