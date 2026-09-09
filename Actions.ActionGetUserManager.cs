namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetUserManager</code> that represents the Service Studio reference action
///  <code>GetUserManager</code> <p> Description: Retrieves Manager of a especific Person</p>
/// </summary>
public static async Task<(ST_d32097d2629a99529d77b865dae9fb0cStructure,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)> ActionGetUserManager(IRequestContext requestContext,string inParamUserID,CancellationToken cancellationToken) {
ST_d32097d2629a99529d77b865dae9fb0cStructure outParamResponse = default;
ST_38509e9fbd36a9b928c2f4e34a1342aeStructure outParamResult = default;
IRecord proxy_Response;
IRecord proxy_Result;
(proxy_Response,proxy_Result) = await RsseSpaceIS_EntraIDGraphConnector.MssGetUserManager<ST_d32097d2629a99529d77b865dae9fb0cStructure,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure>(requestContext,inParamUserID,cancellationToken);
outParamResponse = (ST_d32097d2629a99529d77b865dae9fb0cStructure) proxy_Response;
outParamResult = (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure) proxy_Result;
return (outParamResponse,outParamResult);
}

}
