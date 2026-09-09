namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetUserManagersUntilEmailFound</code> that represents the Service Studio
///  reference action <code>GetUserManagersUntilEmailFound</code> <p> Description: Retrieves Managers o
/// f a especific Person</p>
/// </summary>
public static async Task<(RL_c68f8e92ccdada3f2f3589e091be34b8,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)> ActionGetUserManagersUntilEmailFound(IRequestContext requestContext,string inParamUserEmail,bool inParamIncludeUserEmail,string inParamLastEmail,CancellationToken cancellationToken) {
RL_c68f8e92ccdada3f2f3589e091be34b8 outParamResponse = default;
ST_38509e9fbd36a9b928c2f4e34a1342aeStructure outParamResult = default;
RecordList proxy_Response;
IRecord proxy_Result;
(proxy_Response,proxy_Result) = await RsseSpaceIS_EntraIDGraphConnector.MssGetUserManagersUntilEmailFound<RL_c68f8e92ccdada3f2f3589e091be34b8,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure>(requestContext,inParamUserEmail,inParamIncludeUserEmail,inParamLastEmail,cancellationToken);
outParamResponse = (RL_c68f8e92ccdada3f2f3589e091be34b8) proxy_Response;
outParamResult = (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure) proxy_Result;
return (outParamResponse,outParamResult);
}

}
