using FluentValidation;

namespace ProjectCollection.TimeCalculator
{
    public class ValidateTimeCalculator : AbstractValidator<Time>
    {
        public ValidateTimeCalculator()
        {
            RuleFor(time => time.Start).Matches(@"\d\d:\d\d").WithErrorCode("Arbeitsbeginn ist ungültig.");
            //RuleFor(time => time.Start).Matches("[0 - 1]?[0 - 9] | 2[0 - 3]):[0 - 5][0 - 9]").WithErrorCode("Arbeitsbeginn ist ungültig.");
            RuleFor(time => time.Lunch).Matches("[0-9][0-9]").WithErrorCode("Mittagspause in Minuten ist ungültig.");
            RuleFor(time => time.End).Matches(@"\d\d:\d\d").WithErrorCode("Arbeitsschluss ist ungültig.");
        }
    }
}
