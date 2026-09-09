namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIService_EM_SM_CECO</code> that represents a client request call
///  <code>Service_EM_SM_CECO</code> <p> Description: Service_EM_SM_CECO</p>
/// </summary>
public static async Task<ST_92e975006ec90075480e9af34dc228e3Structure> ServiceAPIService_EM_SM_CECO(IRequestContext requestContext,ST_abeb699a3b96359819e408d199643162Structure inParamRequest,CancellationToken cancellationToken) {
ST_92e975006ec90075480e9af34dc228e3Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Service_EM_SM_CECO<ST_92e975006ec90075480e9af34dc228e3Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_92e975006ec90075480e9af34dc228e3Structure) proxy_Response;
return outParamResponse;
}

}
