using FluentValidation;

namespace Web.Extensions;

public static class ValidationExtensions
{
    public static IRuleBuilder<T, string> CountryValidator<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder
            .NotEmpty()
            .Length<T>(2).Matches("[A-Za-z]");
    }
    
    public static IRuleBuilder<T, string> HomeStationValidation<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        
        return ruleBuilder
            .NotEmpty()
            .Length<T>(3).Matches("[A-Za-z]");
    }
}