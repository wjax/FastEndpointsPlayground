// namespace Web.Features.SaveWithValidatorInheritance;
//
// public class SaveWithValidatorInheritance  : Endpoint<RequestWithInheritance>
// {
//     public override void Configure()
//     {
//         Put("Test/SaveWithValidatorInheritance");
//         AllowAnonymous();
//         Summary(summary => summary.Description = $"This is testing {nameof(SaveWithValidatorInheritance)}'");
//     }
//
//     public override async Task HandleAsync(RequestWithInheritance req, CancellationToken ct)
//     {
//         await SendOkAsync(ct);
//     }
// }
//
// public class RequestWithInheritance : BaseIdentifier
// {
//     public string? NullableIdentifier { get; set; }
//     public string? Message { get; set; }
// }
//
// public class BaseIdentifier
// {
//     public string Identifier { get; set; }
//     public string baseMessage { get; set; }
// }
//
// public class RequestValidator : BaseIdentifierValidator<RequestWithInheritance>
// {
//     public RequestValidator()
//     {
//         RuleFor(x => x.Identifier).NotEmpty();
//         RuleFor(x => x.NullableIdentifier).NotEmpty();
//         RuleFor(x => x.Message).Length(3, 100);
//     }
// }
//
// public class BaseIdentifierValidator<TDto> : Validator<TDto> where TDto : BaseIdentifier
// {
//     public BaseIdentifierValidator()
//     {
//         RuleFor(x => x.baseMessage).Length(10, 100);
//     }
// }