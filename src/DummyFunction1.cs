namespace func.fastendpoints;

public static class Dummy
{
    [Function("DummyRun")]
    public static HttpResponseData? DummyRun([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
    {
        return null;
    }
}