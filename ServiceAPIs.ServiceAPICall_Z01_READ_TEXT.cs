namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_Z01_READ_TEXT</code> that represents a client request call
///  <code>Call_Z01_READ_TEXT</code> <p> Description: Call_Z01_READ_TEXT</p>
/// </summary>
public static async Task<ST_cc99e347274d861473c4d7d08b6332b6Structure> ServiceAPICall_Z01_READ_TEXT(IRequestContext requestContext,ST_c4a97e6963b2cd0d749b56dde8d26a02Structure inParamRequest,CancellationToken cancellationToken) {
ST_cc99e347274d861473c4d7d08b6332b6Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_Z01_READ_TEXT<ST_cc99e347274d861473c4d7d08b6332b6Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_cc99e347274d861473c4d7d08b6332b6Structure) proxy_Response;
return outParamResponse;
}

}
