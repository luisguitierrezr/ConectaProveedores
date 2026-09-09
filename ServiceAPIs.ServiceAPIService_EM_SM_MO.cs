namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIService_EM_SM_MO</code> that represents a client request call
///  <code>Service_EM_SM_MO</code> <p> Description: Service_EM_SM_MO</p>
/// </summary>
public static async Task<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure> ServiceAPIService_EM_SM_MO(IRequestContext requestContext,ST_f61ad0d448ed247a1bde22a5051a7d04Structure inParamRequest,CancellationToken cancellationToken) {
ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Service_EM_SM_MO<ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_5a2f27e86c3f9cff3d6a27ca1772d236Structure) proxy_Response;
return outParamResponse;
}

}
