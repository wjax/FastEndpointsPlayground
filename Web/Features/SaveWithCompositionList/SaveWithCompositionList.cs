// namespace Web.Features.SaveWithCompositionList;
//
// public class SaveWithCompositionList  : Endpoint<Request>
// {
//     public override void Configure()
//     {
//         Put("Test/SaveWithCompositionList");
//         AllowAnonymous();
//         Summary(summary => summary.Description = $"This is testing {nameof(SaveWithCompositionList)}'");
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
//     public Guid? NullableIdentifier { get; set; }
//     public string? Message { get; set; }
//     public SomeEntity[] entities { get; set; }
// }
//
// public class SomeEntity
// {
//     public Guid Identifier { get; set; } = Guid.NewGuid();
//     public string messageBase { get; set; } 
// }
//
// public class RequestValidator : Validator<Request>
// {
//     public RequestValidator()
//     {
//         RuleFor(x => x.NullableIdentifier).NotEmpty();
//         RuleFor(x => x.Message).Length(3, 100);
//     }
// }
//
// public class BaseIdentifierValidator : Validator<SomeEntity>
// {
//     public BaseIdentifierValidator()
//     {
//         RuleFor(x => x.messageBase).Length(10, 100);
//     }
// }