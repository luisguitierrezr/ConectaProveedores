namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIService_EM</code> that represents a client request call
///  <code>Service_EM</code> <p> Description: Service EM</p>
/// </summary>
public static async Task<ST_ff65d449d860eb4ed98725735a32f4f3Structure> ServiceAPIService_EM(IRequestContext requestContext,ST_471afc38d91cd307b39846c7ca5ddb86Structure inParamRequest,CancellationToken cancellationToken) {
ST_ff65d449d860eb4ed98725735a32f4f3Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Service_EM<ST_ff65d449d860eb4ed98725735a32f4f3Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_ff65d449d860eb4ed98725735a32f4f3Structure) proxy_Response;
return outParamResponse;
}

}
