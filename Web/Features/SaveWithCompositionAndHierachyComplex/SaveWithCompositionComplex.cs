namespace Web.Features.SaveWithCompositionAndHierachyComplex;

public class SaveWithCompositionAndHierachyComplex  : Endpoint<Request>
{
    public override void Configure()
    {
        Put("Test/SaveWithCompositionAndHierachyComplex");
        AllowAnonymous();
        Summary(summary => summary.Description = $"This is testing {nameof(SaveWithCompositionAndHierachyComplex)}'");
    }

    public override async Task HandleAsync(Request req, CancellationToken ct)
    {
        await SendOkAsync(ct);
    }
}

public class Request : BaseRequest
{
    public string? requestIdOriginallyCamelCase { get; set; }
    public ChildObject Child{ get; set; }
    public ChildObjectWithInheritance ChildWithInheritance{ get; set; }
    public ChildObjectForSetValidator ChildObjectForSetValidator { get; set; }
}

public class ChildObject
{
    public string ChildMesage { get; set; }
}

public class ChildObjectWithInheritance : ChildBaseObject
{
    public string ChildMesageWithInheritance { get; set; }
}

public class ChildObjectForSetValidator
{
    public string ChildMesageForSetValidator { get; set; }
}

public class ChildBaseObject
{
    public string ChildBaseMesage { get; set; }
}

public class BaseRequest
{
    public string? BaseRequestId { get; set; }
    public ChildBaseRequest ChildBase{ get; set; }
    public ChildBaseRequestWithInheritance childBaseWithInheritance{ get; set; }
    public ChildBaseObjectForSetValidator childBaseObjectForSetValidator { get; set; }

}

public class ChildBaseRequestWithInheritance : ChildBaseRequestBase
{
    public string MessageChildBaseWithInheritance { get; set; }
}

public class ChildBaseRequestBase
{
    public string ChildBaseMesageBase { get; set; }
}

public class ChildBaseRequest
{
    public string Message { get; set; }
}

public class ChildBaseObjectForSetValidator
{
    public string ChildBaseMesageForSetValidator { get; set; }
}




public class RequestValidator : Validator<Request>
{
    public RequestValidator() : base()
    {
        RuleFor(x => x.requestIdOriginallyCamelCase).NotEmpty();
        RuleFor(x => x.Child.ChildMesage).NotEmpty();
        RuleFor(x => x.ChildWithInheritance.ChildMesageWithInheritance).NotEmpty();
        RuleFor(x => x.BaseRequestId).NotEmpty();
        RuleFor(x => x.ChildBase.Message).NotEmpty();
        RuleFor(x => x.childBaseWithInheritance.MessageChildBaseWithInheritance).NotEmpty();
        RuleFor(x => x.childBaseWithInheritance.ChildBaseMesageBase).NotEmpty();
        RuleFor(x => x.ChildWithInheritance.ChildBaseMesage).MinimumLength(120);
        RuleFor(x => x.ChildObjectForSetValidator).SetValidator(new ChildObjectForSetValidatorValidator());
        RuleFor(x => x.childBaseObjectForSetValidator).SetValidator(new ChildBaseObjectForSetValidatorValidator());

    }
}

public class ChildObjectForSetValidatorValidator : Validator<ChildObjectForSetValidator>
{
    public ChildObjectForSetValidatorValidator()
    {
        RuleFor(x => x.ChildMesageForSetValidator).MinimumLength(40);
    }
}

public class ChildBaseObjectForSetValidatorValidator : Validator<ChildBaseObjectForSetValidator>
{
    public ChildBaseObjectForSetValidatorValidator()
    {
        RuleFor(x => x.ChildBaseMesageForSetValidator).MinimumLength(121);
    }
}