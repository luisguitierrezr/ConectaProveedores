namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT</code> that represents a client request
///  call <code>Call_ZMXMIMMF_VISUALIZAR_SAL_ANT</code> <p> Description: Visualizar saldo anticipo</p>
/// </summary>
public static async Task<ST_cbb2055cf19f871ed882642269bd43ceStructure> ServiceAPICall_ZMXMIMMF_VISUALIZAR_SAL_ANT(IRequestContext requestContext,ST_f68ab54e767928bb7cc21e9801e8642bStructure inParamRequest,CancellationToken cancellationToken) {
ST_cbb2055cf19f871ed882642269bd43ceStructure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXMIMMF_VISUALIZAR_SAL_ANT<ST_cbb2055cf19f871ed882642269bd43ceStructure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_cbb2055cf19f871ed882642269bd43ceStructure) proxy_Response;
return outParamResponse;
}

}
