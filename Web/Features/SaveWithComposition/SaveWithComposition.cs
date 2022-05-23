// namespace Web.Features.SaveWithComposition;
//
// public class SaveWithComposition  : Endpoint<Request>
// {
//     public override void Configure()
//     {
//         Put("Test/SaveWithComposition");
//         AllowAnonymous();
//         Summary(summary => summary.Description = $"This is testing {nameof(SaveWithComposition)}'");
//     }
//
//     public override async Task HandleAsync(Request req, CancellationToken ct)
//     {
//         await SendOkAsync(ct);
//     }
// }
//
// public class Request
// {
//     public string? NullableIdentifier { get; set; }
//     public string? Message { get; set; }
//     public BaseIdentifier Baseid { get; set; }
//     public List<string> AddressLines { get; set; }
//     public List<BaseIdentifier> BaseIdentifiers { get; set; }
// }
//
// public class BaseIdentifier
// {
//     public string Identifier { get; set; }
//     public string messageBase { get; set; } 
// }
//
// public class RequestValidator : Validator<Request>
// {
//     public RequestValidator() : base()
//     {
//         RuleFor(x => x.NullableIdentifier).NotEmpty();
//         RuleFor(x => x.Message).Length(3, 100);
//         RuleFor(x => x.Baseid).SetValidator(new BaseIdentifierValidator());
//         RuleFor(x => x.Baseid.Identifier).NotEmpty();
//         RuleForEach(x => x.AddressLines).NotEmpty();
//         RuleForEach(x => x.BaseIdentifiers).SetValidator(new BaseIdentifierValidator());
//     }
// }
//
// public class BaseIdentifierValidator : Validator<BaseIdentifier>
// {
//     public BaseIdentifierValidator()
//     {
//         RuleFor(x => x.messageBase).NotNull().Length(10, 100);
//     }
// }