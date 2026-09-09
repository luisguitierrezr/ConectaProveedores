// Proxy for reference eSpace with name AuditEngine and key 7ALlCl5XjEO9aaKJqzHVpA
using System.Diagnostics;
using OutSystems.Application.ManifestGeneration;
using ssConectaProveedores;
using ssConectaProveedores.ReferencesProxy;
namespace ssConectaProveedores.ReferencesProxy {
// empty namespace to ensure the namespace always exists
}
namespace ssConectaProveedores {
/// <summary>
/// Class: RsseSpaceAuditEngine
/// </summary>
public partial class RsseSpaceAuditEngine {
private static readonly ActivitySource source = new("ssConectaProveedores.RsseSpaceAuditEngine");
   public static ObjectKey eSpaceId {
       get {
           return ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
       }
   }
public static async Task<(RecordList,long)> ServiceGetAuditsByOrigin4List<ToutParamAuditList>(IRequestContext requestContext,int inParamOriginId,DateTime inParamPeriodInit,DateTime inParamPeriodEnd,bool inParamShowErrors,int inParamStartIndex,int inParamMaxRecords,string inParamTableSort,CancellationToken cancellationToken) where ToutParamAuditList : RecordList,new() {
RecordList outParamAuditList = default;
long outParamTotalCount = default;
outParamAuditList = new ToutParamAuditList();;
RL_d271bd6e591b75c186c4ae8d222dee55 _proxyoutParamAuditList = new RL_d271bd6e591b75c186c4ae8d222dee55();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
(_proxyoutParamAuditList,outParamTotalCount) = await AuditEngineServiceAPIClients.ServiceGetAuditsByOrigin4List(requestContext,inParamOriginId,inParamPeriodInit,inParamPeriodEnd,inParamShowErrors,inParamStartIndex,inParamMaxRecords,inParamTableSort,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamAuditList.FillFromOther(_proxyoutParamAuditList);await Task.Yield();
return (outParamAuditList,outParamTotalCount);
}


public static async Task<long> ServiceAuditCreate(IRequestContext requestContext,IRecord inParamSource,string inParamIP,CancellationToken cancellationToken) {
long outParamId = default;
var _proxyinParamSource = new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
_proxyinParamSource.FillFromOther(inParamSource);var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
outParamId = await AuditEngineServiceAPIClients.ServiceAuditCreate(requestContext,_proxyinParamSource,inParamIP,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
await Task.Yield();
return outParamId;
}


public static async Task<(RecordList,long)> ServiceGetAuditsByIdentifier4List<ToutParamAuditList>(IRequestContext requestContext,int inParamOriginId,long inParamIdentifier,bool inParamShowErrors,int inParamStartIndex,int inParamMaxRecords,string inParamTableSort,CancellationToken cancellationToken) where ToutParamAuditList : RecordList,new() {
RecordList outParamAuditList = default;
long outParamTotalCount = default;
outParamAuditList = new ToutParamAuditList();;
RL_d271bd6e591b75c186c4ae8d222dee55 _proxyoutParamAuditList = new RL_d271bd6e591b75c186c4ae8d222dee55();
var oldCurrentESpaceKey = requestContext.CurrentESpaceKey;
try {
    requestContext.CurrentESpaceKey = ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
(_proxyoutParamAuditList,outParamTotalCount) = await AuditEngineServiceAPIClients.ServiceGetAuditsByIdentifier4List(requestContext,inParamOriginId,inParamIdentifier,inParamShowErrors,inParamStartIndex,inParamMaxRecords,inParamTableSort,cancellationToken);
} finally {
    requestContext.CurrentESpaceKey = oldCurrentESpaceKey;
}
outParamAuditList.FillFromOther(_proxyoutParamAuditList);await Task.Yield();
return (outParamAuditList,outParamTotalCount);
}


public sealed partial class ENAuditEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Audit, "audit_9j9tk7mvvctqktpzi7zi_og0"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
} // ENAuditEntity
public sealed partial class ENOriginEntity {
public static string ViewName(string locale) {
return BaseAppUtils.EscapeAndQualifySqlIdentifier(DatabaseAccess.ForRuntimeDatabase, TableDetailsServiceAccessor.Instance?.GetValidatedTableName(_EntityKeyConstants.@AuditEngine, _EntityKeyConstants._AuditEngineEntityKeys.@Origin, "origi_9j9tk7mvvctn72stjmado5w0"));
}
public static readonly ObjectKey eSpaceKey = ObjectKey.Parse("8aa2689a-6d7f-45a1-9c5a-5206a69f8877");
} // ENOriginEntity

public class DefaultValues {
}
}
}
