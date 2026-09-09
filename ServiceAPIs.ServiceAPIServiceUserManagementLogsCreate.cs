namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceUserManagementLogsCreate</code> that represents a client request
///  call <code>ServiceUserManagementLogsCreate</code> <p> Description: Encapsulates the Create entit
/// y action, enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceUserManagementLogsCreate(IRequestContext requestContext,string inParamUserId,string inParamMessage,string inParamIpAddress,string inParamScreen,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceTelCelUsersManagement.ServiceUserManagementLogsCreate(requestContext,inParamUserId,inParamMessage,inParamIpAddress,inParamScreen,cancellationToken);
return outParamId;
}

}
