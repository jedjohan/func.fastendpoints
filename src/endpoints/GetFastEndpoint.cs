using FastEndpoints;
using func.fastendpoints.models;

namespace func.fastendpoints;

public class GetFastEndpoint : Endpoint<SampleRequest>
{
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("/cidapi/product/");

        AllowAnonymous();
    }

    public override async Task HandleAsync(SampleRequest req, CancellationToken ct)
    {
        // Here we would fetch some data from somewhere
        var response = new SampleResponse()
        {
            Title = "the title of the product",
            CID = "18456124"
        };

        await SendAsync(response, cancellation: ct);
    }
}
