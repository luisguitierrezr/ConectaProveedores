namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetDirectReportsList</code> that represents the Service Studio reference action
///  <code>GetDirectReportsList</code> <p> Description: Retrieves Direct Reports of a especifi
/// c Person</p>
/// </summary>
public static async Task<(ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure)> ActionGetDirectReportsList(IRequestContext requestContext,string inParamUserID,CancellationToken cancellationToken) {
ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure outParamUsers = default;
ST_38509e9fbd36a9b928c2f4e34a1342aeStructure outParamResult = default;
IRecord proxy_Users;
IRecord proxy_Result;
(proxy_Users,proxy_Result) = await RsseSpaceIS_EntraIDGraphConnector.MssGetDirectReportsList<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure,ST_38509e9fbd36a9b928c2f4e34a1342aeStructure>(requestContext,inParamUserID,cancellationToken);
outParamUsers = (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure) proxy_Users;
outParamResult = (ST_38509e9fbd36a9b928c2f4e34a1342aeStructure) proxy_Result;
return (outParamUsers,outParamResult);
}

}
