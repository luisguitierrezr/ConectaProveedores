namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXMIMMF_ESTD_CUENTA_COSMOZ</code> that represents a client request
///  call <code>Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ</code> <p> Description: Estado de cuenta portal</p>
/// </summary>
public static async Task<ST_382afa1d8361f400b6ea03403d75e294Structure> ServiceAPICall_ZMXMIMMF_ESTD_CUENTA_COSMOZ(IRequestContext requestContext,ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure inParamRequest,CancellationToken cancellationToken) {
ST_382afa1d8361f400b6ea03403d75e294Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ<ST_382afa1d8361f400b6ea03403d75e294Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_382afa1d8361f400b6ea03403d75e294Structure) proxy_Response;
return outParamResponse;
}

}
