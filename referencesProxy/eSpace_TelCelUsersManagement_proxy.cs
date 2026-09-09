// Proxy for reference eSpace with name TelCelUsersManagement and key uoro2_pILUWCIaUqmDNf8A
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceTelCelUsersManagement
/// </summary>
public partial class RsseSpaceTelCelUsersManagement {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceTelCelUsersManagement");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61");
       }
   }
public static async Task<long> ServiceUserManagementLogsCreate(IRequestContext requestContext,string inParamUserId,string inParamMessage,string inParamIpAddress,string inParamScreen,CancellationToken cancellationToken) {
long outParamId = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61");
outParamId = await TelCelUsersManagementServiceAPIClients.ServiceUserManagementLogsCreate(requestContext,inParamUserId,inParamMessage,inParamIpAddress,inParamScreen,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<(RecordList,int)> ServiceApplicationRoles_GetLst_Wrapper<ToutParamRoleslList>(IRequestContext requestContext,string inParamKey,string inParamAssetKey,string inParamStageKey,string inParamSearchText,string inParamSort,int inParamMaxRecords,int inParamStartIndex,CancellationToken cancellationToken) where ToutParamRoleslList : RecordList,new() {
RecordList outParamRoleslList = default;
int outParamTotalRoles = default;
outParamRoleslList = new ToutParamRoleslList();;
RL_c31de23e3d152f2b2321aea18f795545 _proxyoutParamRoleslList = new RL_c31de23e3d152f2b2321aea18f795545();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61");
(_proxyoutParamRoleslList,outParamTotalRoles) = await TelCelUsersManagementServiceAPIClients.ServiceApplicationRoles_GetLst_Wrapper(requestContext,inParamKey,inParamAssetKey,inParamStageKey,inParamSearchText,inParamSort,inParamMaxRecords,inParamStartIndex,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamRoleslList.FillFromOther(_proxyoutParamRoleslList);await Task.Yield();
return (outParamRoleslList,outParamTotalRoles);
}


public static async Task<RecordList> ServiceApplicationRoles_GetUsers_Wrapper<ToutParamUsersList>(IRequestContext requestContext,string inParamKey,int inParamLimit,int inParamOffset,CancellationToken cancellationToken) where ToutParamUsersList : RecordList,new() {
RecordList outParamUsersList = default;
outParamUsersList = new ToutParamUsersList();;
RL_c22ca0e0dff4c8c0d1575277d6d892be _proxyoutParamUsersList = new RL_c22ca0e0dff4c8c0d1575277d6d892be();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61");
_proxyoutParamUsersList = await TelCelUsersManagementServiceAPIClients.ServiceApplicationRoles_GetUsers_Wrapper(requestContext,inParamKey,inParamLimit,inParamOffset,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamUsersList.FillFromOther(_proxyoutParamUsersList);await Task.Yield();
return outParamUsersList;
}


public static async Task<(string,string)> ServiceGetUserExtensionExternalEmail(IRequestContext requestContext,string inParami_UserEmail,CancellationToken cancellationToken) {
string outParamo_ExternalEmail = default;
string outParamo_RegionToBeAssigned = default;
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61");
(outParamo_ExternalEmail,outParamo_RegionToBeAssigned) = await TelCelUsersManagementServiceAPIClients.ServiceGetUserExtensionExternalEmail(requestContext,inParami_UserEmail,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return (outParamo_ExternalEmail,outParamo_RegionToBeAssigned);
}


public sealed partial class ENUserExtensionEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@TelCelUsersManagement, _EntityKeyConstants._TelCelUsersManagementEntityKeys.@UserExtension, "usere_ihdi729yy17qst3kjw76auy3"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("abbc6e11-902c-4319-878b-9d0fec641e61");
} // ENUserExtensionEntity

public class DefaultValues {
}
}
}
