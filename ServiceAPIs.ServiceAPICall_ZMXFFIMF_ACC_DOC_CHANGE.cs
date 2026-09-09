namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICall_ZMXFFIMF_ACC_DOC_CHANGE</code> that represents a client request
///  call <code>Call_ZMXFFIMF_ACC_DOC_CHANGE</code> <p> Description: ZMXFFIMF_ACC_DOC_CHANGE</p>
/// </summary>
public static async Task<string> ServiceAPICall_ZMXFFIMF_ACC_DOC_CHANGE(IRequestContext requestContext,ST_0cb1a5ee06af693baf5508d00a19d139Structure inParamRequest,CancellationToken cancellationToken) {
string outParamResponse = default;
outParamResponse = await RsseSpaceTelcelIntegrations.Call_ZMXFFIMF_ACC_DOC_CHANGE(requestContext,inParamRequest,cancellationToken);
return outParamResponse;
}

}
