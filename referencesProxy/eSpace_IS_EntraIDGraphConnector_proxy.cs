// Proxy for reference eSpace with name IS_EntraIDGraphConnector and key GMLfgJA9BU+lOCnz6CqRUA
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceIS_EntraIDGraphConnector
/// </summary>
public partial class RsseSpaceIS_EntraIDGraphConnector {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceIS_EntraIDGraphConnector");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
       }
   }
public static async Task<(RecordList,IRecord)> MssGetUserManagers<ToutParamResponse,ToutParamResult>(IRequestContext requestContext,string inParamUserEmail,bool inParamIncludeUserEmail,CancellationToken cancellationToken) where ToutParamResponse : RecordList,new() where ToutParamResult : IRecord,new() {
RecordList outParamResponse = default;
IRecord outParamResult = default;
outParamResponse = new ToutParamResponse();;
ssIS_EntraIDGraphConnector.RL_c68f8e92ccdada3f2f3589e091be34b8 _proxyoutParamResponse = new ssIS_EntraIDGraphConnector.RL_c68f8e92ccdada3f2f3589e091be34b8();
outParamResult = new ToutParamResult();;
ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure _proxyoutParamResult = new ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
(_proxyoutParamResponse,_proxyoutParamResult) = await ssIS_EntraIDGraphConnector.Actions.ActionGetUserManagers(requestContext,inParamUserEmail,inParamIncludeUserEmail,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);outParamResult.FillFromOther(_proxyoutParamResult);await Task.Yield();
return (outParamResponse,outParamResult);
}


public static async Task<(IRecord,IRecord)> MssGetDirectReportsList<ToutParamUsers,ToutParamResult>(IRequestContext requestContext,string inParamUserID,CancellationToken cancellationToken) where ToutParamUsers : IRecord,new() where ToutParamResult : IRecord,new() {
IRecord outParamUsers = default;
IRecord outParamResult = default;
outParamUsers = new ToutParamUsers();;
ssIS_EntraIDGraphConnector.ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure _proxyoutParamUsers = new ssIS_EntraIDGraphConnector.ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure();
outParamResult = new ToutParamResult();;
ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure _proxyoutParamResult = new ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
(_proxyoutParamUsers,_proxyoutParamResult) = await ssIS_EntraIDGraphConnector.Actions.ActionGetDirectReportsList(requestContext,inParamUserID,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamUsers.FillFromOther(_proxyoutParamUsers);outParamResult.FillFromOther(_proxyoutParamResult);await Task.Yield();
return (outParamUsers,outParamResult);
}


public static async Task<(IRecord,IRecord)> MssGetAccessToken<ToutParamResponse,ToutParamResult>(IRequestContext requestContext,string inParamUserId,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() where ToutParamResult : IRecord,new() {
IRecord outParamResponse = default;
IRecord outParamResult = default;
outParamResponse = new ToutParamResponse();;
ssIS_EntraIDGraphConnector.ST_d5188f28891fd075d6bc1034899cfadeStructure _proxyoutParamResponse = new ssIS_EntraIDGraphConnector.ST_d5188f28891fd075d6bc1034899cfadeStructure();
outParamResult = new ToutParamResult();;
ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure _proxyoutParamResult = new ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
(_proxyoutParamResponse,_proxyoutParamResult) = await ssIS_EntraIDGraphConnector.Actions.ActionGetAccessToken(requestContext,inParamUserId,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);outParamResult.FillFromOther(_proxyoutParamResult);await Task.Yield();
return (outParamResponse,outParamResult);
}


public static async Task<(IRecord,IRecord)> MssGetUserManager<ToutParamResponse,ToutParamResult>(IRequestContext requestContext,string inParamUserID,CancellationToken cancellationToken) where ToutParamResponse : IRecord,new() where ToutParamResult : IRecord,new() {
IRecord outParamResponse = default;
IRecord outParamResult = default;
outParamResponse = new ToutParamResponse();;
ssIS_EntraIDGraphConnector.ST_d32097d2629a99529d77b865dae9fb0cStructure _proxyoutParamResponse = new ssIS_EntraIDGraphConnector.ST_d32097d2629a99529d77b865dae9fb0cStructure();
outParamResult = new ToutParamResult();;
ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure _proxyoutParamResult = new ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
(_proxyoutParamResponse,_proxyoutParamResult) = await ssIS_EntraIDGraphConnector.Actions.ActionGetUserManager(requestContext,inParamUserID,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);outParamResult.FillFromOther(_proxyoutParamResult);await Task.Yield();
return (outParamResponse,outParamResult);
}


public static async Task<(RecordList,IRecord)> MssGetUserManagersUntilEmailFound<ToutParamResponse,ToutParamResult>(IRequestContext requestContext,string inParamUserEmail,bool inParamIncludeUserEmail,string inParamLastEmail,CancellationToken cancellationToken) where ToutParamResponse : RecordList,new() where ToutParamResult : IRecord,new() {
RecordList outParamResponse = default;
IRecord outParamResult = default;
outParamResponse = new ToutParamResponse();;
ssIS_EntraIDGraphConnector.RL_c68f8e92ccdada3f2f3589e091be34b8 _proxyoutParamResponse = new ssIS_EntraIDGraphConnector.RL_c68f8e92ccdada3f2f3589e091be34b8();
outParamResult = new ToutParamResult();;
ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure _proxyoutParamResult = new ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
(_proxyoutParamResponse,_proxyoutParamResult) = await ssIS_EntraIDGraphConnector.Actions.ActionGetUserManagersUntilEmailFound(requestContext,inParamUserEmail,inParamIncludeUserEmail,inParamLastEmail,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResponse.FillFromOther(_proxyoutParamResponse);outParamResult.FillFromOther(_proxyoutParamResult);await Task.Yield();
return (outParamResponse,outParamResult);
}


public static async Task<RecordList> MssGetAllReports<ToutParamDirectReports>(IRequestContext requestContext,string inParamUserID,CancellationToken cancellationToken) where ToutParamDirectReports : RecordList,new() {
RecordList outParamDirectReports = default;
outParamDirectReports = new ToutParamDirectReports();;
ssIS_EntraIDGraphConnector.RL_33aa275c739b8b537ec846fb1cac5907 _proxyoutParamDirectReports = new ssIS_EntraIDGraphConnector.RL_33aa275c739b8b537ec846fb1cac5907();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
_proxyoutParamDirectReports = await ssIS_EntraIDGraphConnector.Actions.ActionGetAllReports(requestContext,inParamUserID,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamDirectReports.FillFromOther(_proxyoutParamDirectReports);await Task.Yield();
return outParamDirectReports;
}


public static async Task<(IRecord,IRecord)> MssGetUserByIdOrEmail<ToutParamResult,ToutParamResponse>(IRequestContext requestContext,string inParamUserIdOrEmail,CancellationToken cancellationToken) where ToutParamResult : IRecord,new() where ToutParamResponse : IRecord,new() {
IRecord outParamResult = default;
IRecord outParamResponse = default;
outParamResult = new ToutParamResult();;
ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure _proxyoutParamResult = new ssIS_EntraIDGraphConnector.ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();
outParamResponse = new ToutParamResponse();;
ssIS_EntraIDGraphConnector.ST_d32097d2629a99529d77b865dae9fb0cStructure _proxyoutParamResponse = new ssIS_EntraIDGraphConnector.ST_d32097d2629a99529d77b865dae9fb0cStructure();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
(_proxyoutParamResult,_proxyoutParamResponse) = await ssIS_EntraIDGraphConnector.Actions.ActionGetUserByIdOrEmail(requestContext,inParamUserIdOrEmail,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamResult.FillFromOther(_proxyoutParamResult);outParamResponse.FillFromOther(_proxyoutParamResponse);await Task.Yield();
return (outParamResult,outParamResponse);
}


public sealed partial class ENEntraDomainEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, "");
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("e640e17c-9497-4b8d-927c-ea245aad4d59");
} // ENEntraDomainEntity
    partial class ENEntraDomainEntity {
        

        public static TRecord GetRecordById<TRecord>(int id) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssIS_EntraIDGraphConnector.ENEntraDomainEntity.GetRecordById(id));
return rec;
}


        public static TRecord GetRecordByKey<TRecord>(ObjectKey key) where TRecord : IRecord,new() {
var rec = new TRecord();
rec.FillFromOther(ssIS_EntraIDGraphConnector.ENEntraDomainEntity.GetRecordByKey(key));
return rec;
}

    } // ENEntraDomainEntity;


public class DefaultValues {
}
}
}
