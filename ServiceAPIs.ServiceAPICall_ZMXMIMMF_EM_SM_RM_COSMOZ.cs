namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXMIMMF_EM_SM_RM_COSMOZ</code> that represents a client request
///  call <code>Call_ZMXMIMMF_EM_SM_RM_COSMOZ</code> <p> Description: Entrada y salida de mercancía 
/// - Pep MO - Cosmoz</p>
/// </summary>
public static async Task<ST_b413183d4662c427b8a9318270b9732cStructure> ServiceAPICall_ZMXMIMMF_EM_SM_RM_COSMOZ(IRequestContext requestContext,ST_e629b825a45e94758f239d11120cb772Structure inParamRequest,CancellationToken cancellationToken) {
ST_b413183d4662c427b8a9318270b9732cStructure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_ZMXMIMMF_EM_SM_RM_COSMOZ<ST_b413183d4662c427b8a9318270b9732cStructure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_b413183d4662c427b8a9318270b9732cStructure) proxy_Response;
return outParamResponse;
}

}
