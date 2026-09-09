namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServicePostCarganovim</code> that represents a client request call
///  <code>ServicePostCarganovim</code> <p> Description: CFD Receiver</p>
/// </summary>
public static async Task<ST_6636acdf9f49922edfd43b4865475460Structure> ServiceAPIServicePostCarganovim(IRequestContext requestContext,ST_9b7f85dc32c7c81ceef0a0963388237dStructure inParamRequest,CancellationToken cancellationToken) {
ST_6636acdf9f49922edfd43b4865475460Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.ServicePostCarganovim<ST_6636acdf9f49922edfd43b4865475460Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_6636acdf9f49922edfd43b4865475460Structure) proxy_Response;
return outParamResponse;
}

}
