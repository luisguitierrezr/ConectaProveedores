namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXMIMMF_EM_SM_MO_COSMOZ</code> that represents a client request
///  call <code>Call_ZMXMIMMF_EM_SM_MO_COSMOZ</code> <p> Description: WS EM y SM a centros de costo Mov
/// . 901</p>
/// </summary>
public static async Task<ST_39fca1fbc45889b86a3f10d9a278767bStructure> ServiceAPICall_ZMXMIMMF_EM_SM_MO_COSMOZ(IRequestContext requestContext,ST_0d774220c0b1db165444568fabc9b253Structure inParamRequest,CancellationToken cancellationToken) {
ST_39fca1fbc45889b86a3f10d9a278767bStructure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXMIMMF_EM_SM_MO_COSMOZ<ST_39fca1fbc45889b86a3f10d9a278767bStructure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_39fca1fbc45889b86a3f10d9a278767bStructure) proxy_Response;
return outParamResponse;
}

}
