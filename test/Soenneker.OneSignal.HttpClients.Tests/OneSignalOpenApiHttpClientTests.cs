using Soenneker.OneSignal.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.OneSignal.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OneSignalOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IOneSignalOpenApiHttpClient _httpclient;

    public OneSignalOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IOneSignalOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
