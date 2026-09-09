namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXFFIMF_INSERT_UPDROV</code> that represents a client request call
///  <code>Call_ZMXFFIMF_INSERT_UPDROV</code> <p> Description: Act/Desact retenciones par
/// a proveedores</p>
/// </summary>
public static async Task<ST_b29967856499aeaa8c796dc87fe4c6e8Structure> ServiceAPICall_ZMXFFIMF_INSERT_UPDROV(IRequestContext requestContext,ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure inParamRequest,CancellationToken cancellationToken) {
ST_b29967856499aeaa8c796dc87fe4c6e8Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXFFIMF_INSERT_UPDROV<ST_b29967856499aeaa8c796dc87fe4c6e8Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_b29967856499aeaa8c796dc87fe4c6e8Structure) proxy_Response;
return outParamResponse;
}

}
