namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetTelcelCopilotBlockData : VarsBag {
public bool resCheckProveedorRole_outParamHasRole = false;

public RL_8430333e95ceffc00def96d8abb01f75 queryResGetLoggedUser_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetLoggedUser_outParamCount = 0L;

public lcvGetTelcelCopilotBlockData() {
}
}
public class lcoGetTelcelCopilotBlockData : VarsBag {
public string outParamName = "";

public string outParamEmail = "";

public string outParamURL = "";

public string outParamRoles = "";

public string outParamSecret = "";

public lcoGetTelcelCopilotBlockData() {
}
}
/// <summary>
/// Action <code>GetTelcelCopilotBlockData</code> that represents the Service Studio action
///  <code>GetTelcelCopilotBlockData</code> <p> Description: To retrieve all the necessary data for th
/// e bot.</p>
/// </summary>
public static async Task<(string,string,string,string,string)> ActionGetTelcelCopilotBlockData(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamName = default;
string outParamEmail = default;
string outParamURL = default;
string outParamRoles = default;
string outParamSecret = default;
lcoGetTelcelCopilotBlockData result = new lcoGetTelcelCopilotBlockData();
lcvGetTelcelCopilotBlockData localVars = new lcvGetTelcelCopilotBlockData();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetTelcelCopilotBlockData", "2446cb8b-30c9-4d8e-ba8c-bbc7f6f165f2"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetTelcelCopilotBlockData", "2446cb8b-30c9-4d8e-ba8c-bbc7f6f165f2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// User is Logged?
if(((BuiltInFunction.GetUserId ()!=BuiltInFunction.NullTextIdentifier ()))) {
// Query datasetGetLoggedUser
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLoggedUser_maxRecords = 1;
if (datasetGetLoggedUser_maxRecords < 1) datasetGetLoggedUser_maxRecords = 1;
int datasetGetLoggedUser_startIndex = 0;(localVars.queryResGetLoggedUser_outParamList,localVars.queryResGetLoggedUser_outParamCount) = await FuncActionGetTelcelCopilotBlockData.datasetGetLoggedUser(requestContext,datasetGetLoggedUser_maxRecords,datasetGetLoggedUser_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// Set Name, Email and URL
// Name = GetLoggedUser.List.Current.User.Name
result.outParamName=localVars.queryResGetLoggedUser_outParamList.CurrentRec.ssENUser.ssName;

// URL = GetBookmarkableURL
result.outParamURL=BuiltInFunction.GetBookmarkableURL ();

// Email = GetLoggedUser.List.Current.User.Email
result.outParamEmail=localVars.queryResGetLoggedUser_outParamList.CurrentRec.ssENUser.ssEmail;
// CheckProveedorRole
localVars.resCheckProveedorRole_outParamHasRole = await ExtendedActions.CheckProveedorRole(requestContext,"",cancellationToken);

// Secret = BotSecret
result.outParamSecret=((((string)AppUtils.SiteProperties[SitePropertiesModel.spBotSecret])));
// Is Proveedor?
if((localVars.resCheckProveedorRole_outParamHasRole)) {
// Set Role PROVEEDOR
// Roles = "PROVEEDOR"
result.outParamRoles="PROVEEDOR";
} else {
// Set Role INTERNO
// Roles = "INTERNO"
result.outParamRoles="INTERNO";
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamName = result.outParamName;
outParamEmail = result.outParamEmail;
outParamURL = result.outParamURL;
outParamRoles = result.outParamRoles;
outParamSecret = result.outParamSecret;
} // inner-finally
RETURN_STATEMENT:
return (outParamName,outParamEmail,outParamURL,outParamRoles,outParamSecret);
}

public static class FuncActionGetTelcelCopilotBlockData {

// Query Function "GetLoggedUser" M5d0cgind0C3eWtBV2j0_Q of Action "GetTelcelCopilotBlockData"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetLoggedUser(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetTelcelCopilotBlockData.GetLoggedUser", "72749733-a708-4077-b779-6b415768f4fd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetTelcelCopilotBlockData.GetLoggedUser", "72749733-a708-4077-b779-6b415768f4fd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
CacheHelper myCacheHelper = new CacheHelper();
myCacheHelper.AddValue(AppUtils.eSpaceId.ToString());
myCacheHelper.AddValue("M5d0cgind0C3eWtBV2j0_Q");
myCacheHelper.AddValue(Convert.ToString(maxRecords));
myCacheHelper.AddValue(Convert.ToString(qpusId));
string cacheHash = myCacheHelper.GetHash();
OutSystems.RuntimeCommon.Pair<RL_8430333e95ceffc00def96d8abb01f75, long> temp = RuntimeCache.Instance.Get(new OutSystems.Application.Caching.CacheKey(cacheHash)) as OutSystems.RuntimeCommon.Pair<RL_8430333e95ceffc00def96d8abb01f75, long>;
if(temp == null){
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.i8tGJMkwjk26jLvH9vFl8g/NodesNotShownInESpaceTree.M5d0cgind0C3eWtBV2j0_Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser22\".\"name\" o1, \"enuser22\".\"email\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser22\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser22\".\"id\" = @qpusId) AND (\"enuser22\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser22\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetTelcelCopilotBlockData.GetLoggedUser.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
RuntimeCache.Instance.Add(new OutSystems.Application.Caching.CacheKey(cacheHash), new OutSystems.RuntimeCommon.Pair<RL_8430333e95ceffc00def96d8abb01f75,long>((RL_8430333e95ceffc00def96d8abb01f75)(outParamList.Duplicate()),-1), new OutSystems.Application.Caching.ModuleDependency(requestContext.AppInfo.eSpaceUIDAsKey, requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Tenant.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Environment.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Kind), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Region), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Index)), TimeSpan.FromMinutes(30));
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetTelcelCopilotBlockData.GetLoggedUser.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
RuntimeCache.Instance.Add(new OutSystems.Application.Caching.CacheKey(cacheHash), new OutSystems.RuntimeCommon.Pair<RL_8430333e95ceffc00def96d8abb01f75,long>((RL_8430333e95ceffc00def96d8abb01f75)(outParamList.Duplicate()),-1), new OutSystems.Application.Caching.ModuleDependency(requestContext.AppInfo.eSpaceUIDAsKey, requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Tenant.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Environment.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Kind), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Region), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Index)), TimeSpan.FromMinutes(30));
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}else{
lock(temp) {
return ((RL_8430333e95ceffc00def96d8abb01f75)temp.First.Duplicate(),outParamCount);
}
}
}



}


}
