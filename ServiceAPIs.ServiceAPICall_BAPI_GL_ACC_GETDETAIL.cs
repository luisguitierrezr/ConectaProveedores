namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_BAPI_GL_ACC_GETDETAIL</code> that represents a client request call
///  <code>Call_BAPI_GL_ACC_GETDETAIL</code> <p> Description:  BAPI_GL_ACC_GETDETAIL</p>
/// </summary>
public static async Task<ST_0f0d90fe4adeeddf082edffc80174eb8Structure> ServiceAPICall_BAPI_GL_ACC_GETDETAIL(IRequestContext requestContext,ST_442654d6c8649545cfc0a9d6bfc9f12cStructure inParamRequest,CancellationToken cancellationToken) {
ST_0f0d90fe4adeeddf082edffc80174eb8Structure outParamResponse = default;
IRecord proxy_Response;
proxy_Response = await RsseSpaceTelcelIntegrations.Call_BAPI_GL_ACC_GETDETAIL<ST_0f0d90fe4adeeddf082edffc80174eb8Structure>(requestContext,inParamRequest,cancellationToken);
outParamResponse = (ST_0f0d90fe4adeeddf082edffc80174eb8Structure) proxy_Response;
return outParamResponse;
}

}
