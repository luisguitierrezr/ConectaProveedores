namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXMIMMF_EM_COSMOZ</code> that represents a client request call
///  <code>Call_ZMXMIMMF_EM_COSMOZ</code> <p> Description: Entrada de Mercancía</p>
/// </summary>
public static async Task<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure> ServiceAPICall_ZMXMIMMF_EM_COSMOZ(IRequestContext requestContext,ST_6c39e0afc2ffdcac366ab8f57e83669cStructure inParamRequest,CancellationToken cancellationToken) {
ST_9142fa8204e8ba0b33acb137d6acbbd3Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXMIMMF_EM_COSMOZ<ST_9142fa8204e8ba0b33acb137d6acbbd3Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_9142fa8204e8ba0b33acb137d6acbbd3Structure) proxy_Response;
return outParamResponse;
}

}
