using FastEndpoints;
using func.fastendpoints.models;

namespace func.fastendpoints;

public class PostFastEndpoint : Endpoint<SampleRequest>
{
    public override void Configure()
    {
        Verbs(Http.POST);
        Routes("/cidapi/product/create");
        AllowAnonymous();
    }

    public override Task HandleAsync(SampleRequest req, CancellationToken ct)
    {
        // Here we would add some business logic to create a product
        return Task.CompletedTask;
    }
}