namespace Web.Features.SaveWithInheritance;

public class SaveWithInheritance  : Endpoint<Request>
{
    public override void Configure()
    {
        Put("Test/SaveWithInheritance");
        base.Configure();
        Summary(summary => summary.Description = $"This is testing {nameof(SaveWithInheritance)}'");
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        await SendOkAsync(ct);
    }
}

public class Request : BaseIdentifier
{
    public Guid? NullableIdentifier { get; set; }
    public string? Message { get; set; }
}

public class BaseIdentifier
{
    public Guid Identifier { get; set; } = Guid.NewGuid();
}

public class RequestValidator : Validator<Request>
{
    public RequestValidator()
    {
        RuleFor(x => x.Identifier).NotEmpty();
        RuleFor(x => x.NullableIdentifier).NotEmpty();
        RuleFor(x => x.Message).Length(3, 100);
    }
}