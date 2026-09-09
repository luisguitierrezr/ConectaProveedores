namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIService_EM_SM_RM</code> that represents a client request call
///  <code>Service_EM_SM_RM</code> <p> Description: Service_EM_SM_RM</p>
/// </summary>
public static async Task<ST_b3b2573902c6e22d9647e405d3baf728Structure> ServiceAPIService_EM_SM_RM(IRequestContext requestContext,ST_c338780fd6468541199340ed93f1aecdStructure inParamRequest,CancellationToken cancellationToken) {
ST_b3b2573902c6e22d9647e405d3baf728Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Service_EM_SM_RM<ST_b3b2573902c6e22d9647e405d3baf728Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_b3b2573902c6e22d9647e405d3baf728Structure) proxy_Response;
return outParamResponse;
}

}
