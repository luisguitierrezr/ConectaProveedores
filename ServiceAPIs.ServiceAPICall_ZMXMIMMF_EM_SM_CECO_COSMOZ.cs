namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXMIMMF_EM_SM_CECO_COSMOZ</code> that represents a client request
///  call <code>Call_ZMXMIMMF_EM_SM_CECO_COSMOZ</code> <p> Description: WS EM y SM a centros de cost
/// o Mov. 901</p>
/// </summary>
public static async Task<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure> ServiceAPICall_ZMXMIMMF_EM_SM_CECO_COSMOZ(IRequestContext requestContext,ST_f9c1c13a018839a3b7bd285f1331e967Structure inParamRequest,CancellationToken cancellationToken) {
ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXMIMMF_EM_SM_CECO_COSMOZ<ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_ecd8bf4dc0f110548ef2317e70fd4c61Structure) proxy_Response;
return outParamResponse;
}

}
