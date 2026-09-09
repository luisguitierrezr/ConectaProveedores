namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServicePostValidacfdiprov</code> that represents a client request call
///  <code>ServicePostValidacfdiprov</code> <p> Description: CFD Receiver</p>
/// </summary>
public static async Task<ST_13caff817360521524d01995a65282cdStructure> ServiceAPIServicePostValidacfdiprov(IRequestContext requestContext,ST_1e5384bdcb5c8be6badd45c0e821aec6Structure inParamRequest,CancellationToken cancellationToken) {
ST_13caff817360521524d01995a65282cdStructure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.ServicePostValidacfdiprov<ST_13caff817360521524d01995a65282cdStructure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_13caff817360521524d01995a65282cdStructure) proxy_Response;
return outParamResponse;
}

}
