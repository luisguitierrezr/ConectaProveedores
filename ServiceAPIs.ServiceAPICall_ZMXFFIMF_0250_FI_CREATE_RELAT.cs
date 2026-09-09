namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXFFIMF_0250_FI_CREATE_RELAT</code> that represents a client
///  request call <code>Call_ZMXFFIMF_0250_FI_CREATE_RELAT</code> <p> Description
/// : ZMXFFIMF_0250_FI_CREATE_RELAT</p>
/// </summary>
public static async Task<ST_31a464e509d55210f80b735594283423Structure> ServiceAPICall_ZMXFFIMF_0250_FI_CREATE_RELAT(IRequestContext requestContext,ST_b9515582922fdbd4d217706a5c5c0f3fStructure inParamRequest,CancellationToken cancellationToken) {
ST_31a464e509d55210f80b735594283423Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXFFIMF_0250_FI_CREATE_RELAT<ST_31a464e509d55210f80b735594283423Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_31a464e509d55210f80b735594283423Structure) proxy_Response;
return outParamResponse;
}

}
