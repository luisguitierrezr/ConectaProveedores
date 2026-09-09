namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZTC_GENERA_POLIZA_GRAL</code> that represents a client request call
///  <code>Call_ZTC_GENERA_POLIZA_GRAL</code> <p> Description: MODULO DE FUNCION POLIZA GENERAL</p>
/// </summary>
public static async Task<ST_35778da666b987b02b8cb887e66647a4Structure> ServiceAPICall_ZTC_GENERA_POLIZA_GRAL(IRequestContext requestContext,ST_7d9ca3de97b3b074755ccb195cd9efb0Structure inParamRequest,CancellationToken cancellationToken) {
ST_35778da666b987b02b8cb887e66647a4Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZTC_GENERA_POLIZA_GRAL<ST_35778da666b987b02b8cb887e66647a4Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_35778da666b987b02b8cb887e66647a4Structure) proxy_Response;
return outParamResponse;
}

}
