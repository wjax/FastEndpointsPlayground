namespace Web.Features.SaveWithMoreThanOneValidator;

public class SaveWithMoreThanOneValidator : Endpoint<Request>
{
    public override void Configure()
    {
        Put("Test/SaveWithMoreThanOneValidator");
        AllowAnonymous();
        Summary(summary => summary.Description = $"This is testing '{nameof(SaveWithMoreThanOneValidator)}'");
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        await SendOkAsync(ct);
    }
}

public class RequestChild
{
    public Guid? NullableIdentifier { get; set; }
    public string? Message { get; set; }
}

public class Request
{
    public Guid Identifier { get; set; }
    public RequestChild? RequestChild { get; set; }
}

public class RequestValidator : Validator<Request>
{
    public RequestValidator()
    {
        RuleFor(x => x.Identifier).NotEmpty();
    }
}

public class OtherUserClass
{
    public string message { get; set; }
}

public class OtherUserClassValidatorOne : AbstractValidator<OtherUserClass>
{
    public OtherUserClassValidatorOne()
    {
        RuleFor(x => x.message).NotEmpty();
    }
}

public class OtherUserClassValidatorTwo : AbstractValidator<OtherUserClass>
{
    public OtherUserClassValidatorTwo()
    {
        RuleFor(x => x.message).NotNull();
    }
}