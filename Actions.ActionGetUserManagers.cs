namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetUserManagers</code> that represents the Service Studio reference action
///  <code>GetUserManagers</code> <p> Description: Retrieves Managers of a especific Person</p>
/// </summary>
public static async Task<(RL_c68f8e92ccdada3f2f3589e091be34b8,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)> ActionGetUserManagers(IRequestContext requestContext,string inParamUserEmail,bool inParamIncludeUserEmail,CancellationToken cancellationToken) {
RL_c68f8e92ccdada3f2f3589e091be34b8 outParamResponse = default;
ST_38509e9fbd36a9b928c2f4e34a1342aeStructure outParamResult = default;
RecordList proxy_Response;
IRecord proxy_Result;
(proxy_Response,proxy_Result) = await RsseSpaceIS_EntraIDGraphConnector.MssGetUserManagers<RL_c68f8e92ccdada3f2f3589e091be34b8,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure>(requestContext,inParamUserEmail,inParamIncludeUserEmail,cancellationToken);
outParamResponse = (RL_c68f8e92ccdada3f2f3589e091be34b8) proxy_Response;
outParamResult = (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure) proxy_Result;
return (outParamResponse,outParamResult);
}

}
