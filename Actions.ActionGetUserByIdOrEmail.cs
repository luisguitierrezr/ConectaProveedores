namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetUserByIdOrEmail</code> that represents the Service Studio reference action
///  <code>GetUserByIdOrEmail</code> <p> Description: Retreive User detail</p>
/// </summary>
public static async Task<(ST_38509e9fbd36a9b928c2f4e34a1342aeStructure,ST_d32097d2629a99529d77b865dae9fb0cStructure)> ActionGetUserByIdOrEmail(IRequestContext requestContext,string inParamUserIdOrEmail,CancellationToken cancellationToken) {
ST_38509e9fbd36a9b928c2f4e34a1342aeStructure outParamResult = default;
ST_d32097d2629a99529d77b865dae9fb0cStructure outParamResponse = default;
IRecord proxy_Result;
IRecord proxy_Response;
(proxy_Result,proxy_Response) = await RsseSpaceIS_EntraIDGraphConnector.MssGetUserByIdOrEmail<ST_38509e9fbd36a9b928c2f4e34a1342aeStructure,ST_d32097d2629a99529d77b865dae9fb0cStructure>(requestContext,inParamUserIdOrEmail,cancellationToken);
outParamResult = (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure) proxy_Result;
outParamResponse = (ST_d32097d2629a99529d77b865dae9fb0cStructure) proxy_Response;
return (outParamResult,outParamResponse);
}

}
