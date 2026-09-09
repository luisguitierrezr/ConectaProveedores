namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXFFIMF_CONTA_FACTURAS</code> that represents a client request
///  call <code>Call_ZMXFFIMF_CONTA_FACTURAS</code> <p> Description: Contabilizacion Obtencion de tip
/// o de cambio</p>
/// </summary>
public static async Task<ST_926df962559a6c34055113c885aa4885Structure> ServiceAPICall_ZMXFFIMF_CONTA_FACTURAS(IRequestContext requestContext,ST_012aef00497ef6b298e25799608b1289Structure inParamRequest,CancellationToken cancellationToken) {
ST_926df962559a6c34055113c885aa4885Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXFFIMF_CONTA_FACTURAS<ST_926df962559a6c34055113c885aa4885Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_926df962559a6c34055113c885aa4885Structure) proxy_Response;
return outParamResponse;
}

}
