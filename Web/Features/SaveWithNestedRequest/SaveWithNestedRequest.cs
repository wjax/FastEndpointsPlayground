// namespace Web.Features.SaveWithNestedRequest;
//
// public class SaveWithNestedRequest  : Endpoint<Request>
// {
//     public override void Configure()
//     {
//         Put("Test/SaveWithNestedRequest");
//         AllowAnonymous();
//         Summary(summary => summary.Description = $"This is testing {nameof(SaveWithNestedRequest)}'");
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
//     public string? Message { get; set; }
//     public NestedClass nestedParent { get; set; }
// }
//
// public class NestedClass
// {
//     public string Identifier { get; set; }
//     public NestedClass nestedChild { get; set; } 
// }
//
// public class RequestValidator : Validator<Request>
// {
//     public RequestValidator() : base()
//     {
//         RuleFor(x => x.Message).Length(3, 100);
//         RuleFor(x => x.nestedParent.Identifier).Length(4, 100);
//     }
// }