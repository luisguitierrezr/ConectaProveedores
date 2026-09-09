namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetAccessToken</code> that represents the Service Studio reference action
///  <code>GetAccessToken</code> <p> Description: It is used to get an access token 🔑 from Azure Activ
/// e Directory (AAD).</p>
/// </summary>
public static async Task<(ST_d5188f28891fd075d6bc1034899cfadeStructure,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)> ActionGetAccessToken(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) {
ST_d5188f28891fd075d6bc1034899cfadeStructure outParamResponse = default;
ST_38509e9fbd36a9b928c2f4e34a1342aeStructure outParamResult = default;
IRecord proxy_Response;
IRecord proxy_Result;
(proxy_Response,proxy_Result) = await RsseSpaceIS_EntraIDGraphConnector.MssGetAccessToken<ST_d5188f28891fd075d6bc1034899cfadeStructure,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure>(requestContext,inParamUserId,cancellationToken);
outParamResponse = (ST_d5188f28891fd075d6bc1034899cfadeStructure) proxy_Response;
outParamResult = (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure) proxy_Result;
return (outParamResponse,outParamResult);
}

}
