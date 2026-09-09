using System.Collections.Immutable;
using Microsoft.Extensions.Primitives;
using OutSystems.Application.RestConsume.Definitions;
using OutSystems.Application.RestConsume.Callbacks;

namespace ssConectaProveedores;

public class Notifications_90eca6e8b896426c930ac11800b3905c : IRestConsumeApi {
    public Guid ModuleKey { get; } = Guid.Parse("588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
    public Guid Key { get; } = Guid.Parse("90eca6e8-b896-426c-930a-c11800b3905c");
    public string Name => "Notifications";
    public string ModuleName => "ConectaProveedores";
    public string BaseUrl => "https://conectaprov-dev.conectatelcel.com/TelCelNotifications/rest/app"; 
    public IRestConsumeApiBasicAuthentication? BasicAuthentication => null;
    public DateFormat DateFormat => DateFormat.ISO;
    public Func<IRequestContext, RestConsumeHttpRequest, CancellationToken, Task<RestConsumeHttpRequest>>? OnBeforeRequestAsync { get; } = async (requestContext, httpRequest, cancellationToken) => {
ST_ea2141f4206e3eb2cd0fdd847e008166Structure internalHttpRequest = new ST_ea2141f4206e3eb2cd0fdd847e008166Structure();
internalHttpRequest.ssBaseURL = httpRequest.GetBaseUrl();
internalHttpRequest.ssURLPath = httpRequest.GetUrlPath();
internalHttpRequest.ssURLQueryParameters = RL_09d38ca4875adba9fe0bf71f298f1c3d.ToList(httpRequest.GetUrlQueryParameters(), kv => new ST_f9be77c0ae9485d53ded05b1557548f9Structure {
ssName = kv.Key,
ssValue = kv.Value
});
internalHttpRequest.ssHTTPMethod = httpRequest.GetHttpMethod();
internalHttpRequest.ssHeaders = RL_c06bca3d168b84039f4414ae52f271eb.ToList(httpRequest.GetHeaders(), kv => new ST_3cf3b984041595af1703070620d6367bStructure {
ssName = kv.Key,
ssValue = kv.Value
});
internalHttpRequest.ssRequestText = httpRequest.GetRequestText();
internalHttpRequest.ssRequestBinary = httpRequest.GetRequestBinary();
var outputRequest = await Callback_Notifications_90eca6e8b896426c930ac11800b3905c.NewInstance().FlowNotificationsActionOnBeforeRequest(requestContext,internalHttpRequest,cancellationToken);
var resultRestRequest = new RestConsumeHttpRequest(
baseUrl: outputRequest.ssBaseURL,
urlPath: outputRequest.ssURLPath,
urlQueryParameters: outputRequest.ssURLQueryParameters.ToArray(st => new KeyValuePair<string, string>(st.ssName, st.ssValue)),
httpMethod: outputRequest.ssHTTPMethod,
headers: outputRequest.ssHeaders.ToArray(st => new KeyValuePair<string, string>(st.ssName, st.ssValue)),
requestText: outputRequest.ssRequestText,
requestBinary: outputRequest.ssRequestBinary);
return resultRestRequest;
};
    public Func<IRequestContext, RestConsumeHttpResponse, CancellationToken, Task<RestConsumeHttpResponse>>? OnAfterResponseAsync { get; } = null;

    public async Task<IReadOnlyDictionary<string, StringValues>> GetHeadersAsync(IRequestContext requestContext, CancellationToken cancellationToken) {
        return ImmutableDictionary<string, StringValues>.Empty;
    }
}