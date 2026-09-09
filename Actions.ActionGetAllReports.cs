namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetAllReports</code> that represents the Service Studio reference action
///  <code>GetAllReports</code> <p> Description: Get All Reports</p>
/// </summary>
public static async Task<RL_33aa275c739b8b537ec846fb1cac5907> ActionGetAllReports(IRequestContext requestContext,string inParamUserID,CancellationToken cancellationToken) {
RL_33aa275c739b8b537ec846fb1cac5907 outParamDirectReports = default;
RecordList proxy_DirectReports;
proxy_DirectReports = await RsseSpaceIS_EntraIDGraphConnector.MssGetAllReports<RL_33aa275c739b8b537ec846fb1cac5907>(requestContext,inParamUserID,cancellationToken);
outParamDirectReports = (RL_33aa275c739b8b537ec846fb1cac5907) proxy_DirectReports;
return outParamDirectReports;
}

}
