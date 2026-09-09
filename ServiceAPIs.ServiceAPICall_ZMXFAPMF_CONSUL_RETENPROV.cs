namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXFAPMF_CONSUL_RETENPROV</code> that represents a client request
///  call <code>Call_ZMXFAPMF_CONSUL_RETENPROV</code> <p> Description: Act/Desact retenciones par
/// a proveedores</p>
/// </summary>
public static async Task<ST_24353ddcec93ac51b13ce9ab94fe4001Structure> ServiceAPICall_ZMXFAPMF_CONSUL_RETENPROV(IRequestContext requestContext,ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure inParamRequest,CancellationToken cancellationToken) {
ST_24353ddcec93ac51b13ce9ab94fe4001Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXFAPMF_CONSUL_RETENPROV<ST_24353ddcec93ac51b13ce9ab94fe4001Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_24353ddcec93ac51b13ce9ab94fe4001Structure) proxy_Response;
return outParamResponse;
}

}
