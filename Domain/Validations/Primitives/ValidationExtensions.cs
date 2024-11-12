using FluentValidation;

namespace Domain.Validations;

public static class ValidationExtensions
{
    public static IRuleBuilderOptions<T, TProperty> NotNullOrEmptyWithMessage<T, TProperty>(
        this IRuleBuilder<T, TProperty> ruleBuilder, 
        string paramName)
    {
        return ruleBuilder
            .NotNull().WithMessage(ValidationMasages.NullException(paramName))
            .NotEmpty().WithMessage(ValidationMasages.EmptyException(paramName));
    }
    
    public static IRuleBuilderOptions<T, string?> IsValidUrlWithMessage<T>(
        this IRuleBuilder<T, string?> ruleBuilder, 
        string paramName)
    {
        return ruleBuilder
            .Must(param => Uri.IsWellFormedUriString(param, UriKind.Absolute))
            .WithMessage(ValidationMasages.InvalidFormat(paramName));
    }
}