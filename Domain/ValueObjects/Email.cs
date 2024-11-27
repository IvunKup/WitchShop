namespace Domain.ValueObjects;

public class Email
{
    public string Value { get; private set; }
    
    /*public Email(string value)
    {
        Value = value;
        
        Validate();
    }
    
    private void Validate()
    {
        var validator = new EmailValidator();
        var result = validator.Validate(this);

        if (!result.IsValid)
        {
            var errors = string.Join(" || ", result.Errors.Select(x => x.ErrorMessage));
            throw new ValidationException(errors);
        }
    }*/
}