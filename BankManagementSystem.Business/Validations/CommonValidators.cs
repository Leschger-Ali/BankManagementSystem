
using System.Text.RegularExpressions;

namespace BankManagementSystem.Business.Validations;

public static class CommonValidators
{
    public static bool IsRequired(string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }

    public static bool HasLength(string? value, int minLength, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        string trimmedValue = value.Trim();

        return trimmedValue.Length >= minLength && trimmedValue.Length <= maxLength;
    }

    public static bool IsValidName(string? name)
    {
        if (!HasLength(name, 2, 100))
            return false;

        string pattern = @"^[A-Za-zÄÖÜäöüßÀ-ÿ\s'\-]+$";

        return Regex.IsMatch(name.Trim(), pattern);
    }

    public static bool IsValidEmail(string? email)
    {
        if (!HasLength(email, 5, 100))
            return false;
        
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        return Regex.IsMatch(email.Trim(), pattern);
    }

    public static bool IsValidPhoneNumber(string? phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            return true;

        string pattern = @"^\+?[0-9\s\-\(\)]{7,20}$";

        return Regex.IsMatch(phoneNumber.Trim(), pattern);
    }

    public static bool IsNotFutureDate(DateTime date)
    {
        return date.Date <= DateTime.Today;
    }

    public static bool IsDateInRange(DateTime date, DateTime minDate, DateTime maxDate)
    {
        return date.Date >= minDate.Date && date.Date <= maxDate.Date;
    }

    public static bool IsValidPostalCode(string? postalCode)
    {
        if (!HasLength(postalCode, 4, 10))
            return false;

        string pattern = @"^[A-Za-z0-9\s\-]+$";

        return Regex.IsMatch(postalCode.Trim(), pattern);
    }

    public static bool IsValidShortText(string? text, int maxLength)
    {
        if (string.IsNullOrWhiteSpace(text))
            return true;

        return text.Trim().Length <= maxLength;
    }

    public static bool IsPositiveAmount(decimal amount)
    {
        return amount > 0;
    }

    public static bool IsNonNegativeAmount(decimal amount)
    {
        return amount >= 0;
    }

    public static bool IsValidAccountNumber(string? accountNumber, int requiredLength)
    {
        if (string.IsNullOrWhiteSpace(accountNumber))
            return false;

        string pattern = $@"^\d{{{requiredLength}}}$";

        return Regex.IsMatch(accountNumber.Trim(), pattern);
    }

    public static bool IsValidIban(string? iban)
    {
        if (string.IsNullOrWhiteSpace(iban))
            return false;

        string normalizedIban = iban.Replace(" ", "").ToUpper();

        string pattern = @"^[A-Z]{2}[0-9]{2}[A-Z0-9]{11,30}$";

        return Regex.IsMatch(normalizedIban, pattern);
    }
}