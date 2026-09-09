namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetSupplier_CreateIfNotExist : VarsBag {
public int inParamSupplierNumber;
public string inParamSupplierName;
public long resServiceSupplierCreateOrUpdate_outParamId = 0L;

public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSuppliersByNumber_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSuppliersByNumber_outParamCount = 0L;

public lcvGetSupplier_CreateIfNotExist(int inParamSupplierNumber, string inParamSupplierName) {
this.inParamSupplierNumber = inParamSupplierNumber;
this.inParamSupplierName = inParamSupplierName;
}
}
public class lcoGetSupplier_CreateIfNotExist : VarsBag {
public long outParamSupplierId = 0L;

public lcoGetSupplier_CreateIfNotExist() {
}
}
/// <summary>
/// Action <code>GetSupplier_CreateIfNotExist</code> that represents the Service Studio action
///  <code>GetSupplier_CreateIfNotExist</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionGetSupplier_CreateIfNotExist(IRequestContext requestContext,int inParamSupplierNumber,string inParamSupplierName,CancellationToken cancellationToken) {
long outParamSupplierId = default;
lcoGetSupplier_CreateIfNotExist result = new lcoGetSupplier_CreateIfNotExist();
lcvGetSupplier_CreateIfNotExist localVars = new lcvGetSupplier_CreateIfNotExist(inParamSupplierNumber, inParamSupplierName);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetSupplier_CreateIfNotExist", "6cd7ae81-c7aa-4c8c-a453-50c161305003"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetSupplier_CreateIfNotExist", "6cd7ae81-c7aa-4c8c-a453-50c161305003", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetSuppliersByNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSuppliersByNumber_maxRecords = 1;
if (datasetGetSuppliersByNumber_maxRecords < 1) datasetGetSuppliersByNumber_maxRecords = 1;
int datasetGetSuppliersByNumber_startIndex = 0;(localVars.queryResGetSuppliersByNumber_outParamList,localVars.queryResGetSuppliersByNumber_outParamCount) = await FuncActionGetSupplier_CreateIfNotExist.datasetGetSuppliersByNumber(requestContext,datasetGetSuppliersByNumber_maxRecords,datasetGetSuppliersByNumber_startIndex,IterationMultiplicity.Multiple,localVars.inParamSupplierNumber,BuiltInFunction.TextToLongIntegerValidate (BuiltInFunction.Trim (Convert.ToString(localVars.inParamSupplierNumber))),cancellationToken);

// empty?
if((localVars.queryResGetSuppliersByNumber_outParamList.Empty)) {
// ServiceSupplierCreateOrUpdate
localVars.resServiceSupplierCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceSupplierCreateOrUpdate(requestContext,new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssName = localVars.inParamSupplierName, ssNumber = Convert.ToString(localVars.inParamSupplierNumber), ssIsActive = true },cancellationToken);

// SupplierId = ServiceSupplierCreateOrUpdate.Id
result.outParamSupplierId=localVars.resServiceSupplierCreateOrUpdate_outParamId;
} else {
// SupplierId = GetSuppliersByNumber.List.Current.Supplier.Id
result.outParamSupplierId=localVars.queryResGetSuppliersByNumber_outParamList.CurrentRec.ssENSupplier.ssId;
}

} //close CreateActionActivity using block
} // try

finally {
outParamSupplierId = result.outParamSupplierId;
} // inner-finally
RETURN_STATEMENT:
return outParamSupplierId;
}

public static class FuncActionGetSupplier_CreateIfNotExist {

// Query Function "GetSuppliersByNumber" 4NePpwUBXEaK33ff+x719w of Action "GetSupplier_CreateIfNotExist"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSuppliersByNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpinNumber,bool qpboTextToLongIntegerValidate,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetSupplier_CreateIfNotExist.GetSuppliersByNumber", "a78fd7e0-0105-465c-8adf-77dffb1ef5f7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetSupplier_CreateIfNotExist.GetSuppliersByNumber", "a78fd7e0-0105-465c-8adf-77dffb1ef5f7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
CacheHelper myCacheHelper = new CacheHelper();
myCacheHelper.AddValue(AppUtils.eSpaceId.ToString());
myCacheHelper.AddValue("4NePpwUBXEaK33ff+x719w");
myCacheHelper.AddValue(Convert.ToString(maxRecords));
myCacheHelper.AddValue(Convert.ToString(qpinNumber));
myCacheHelper.AddValue(Convert.ToString(qpboTextToLongIntegerValidate));
string cacheHash = myCacheHelper.GetHash();
OutSystems.RuntimeCommon.Pair<RL_d5c1b2482ff109e80580d8b5fb920193, long> temp = RuntimeCache.Instance.Get(new OutSystems.Application.Caching.CacheKey(cacheHash)) as OutSystems.RuntimeCommon.Pair<RL_d5c1b2482ff109e80580d8b5fb920193, long>;
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
selectBuilder.Append("/* /UserActions.ga7XbKrHjEykU1DBYTBQAw/NodesNotShownInESpaceTree.4NePpwUBXEaK33ff+x719w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplier21\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier21\"");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpboTextToLongIntegerValidate = 1) THEN (CASE WHEN ((coalesce(cast(nullif((Upper(\"ensupplier21\".\"number\")),'') as bigint), 0)) = (coalesce(cast(nullif((Upper((trim(cast(@qpinNumber as text))))),'') as bigint), 0))) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((Upper(\"ensupplier21\".\"number\")) = (Upper((trim(cast(@qpinNumber as text)))))) THEN 1 ELSE 0 END) END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboTextToLongIntegerValidate", DbType.Boolean, qpboTextToLongIntegerValidate);
sqlCmd.CreateParameterWithoutReplacements("@qpinNumber", DbType.Int32, qpinNumber);
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetSupplier_CreateIfNotExist.GetSuppliersByNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
RuntimeCache.Instance.Add(new OutSystems.Application.Caching.CacheKey(cacheHash), new OutSystems.RuntimeCommon.Pair<RL_d5c1b2482ff109e80580d8b5fb920193,long>((RL_d5c1b2482ff109e80580d8b5fb920193)(outParamList.Duplicate()),-1), new OutSystems.Application.Caching.ModuleDependency(requestContext.AppInfo.eSpaceUIDAsKey, requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Tenant.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Environment.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Kind), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Region), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Index)), TimeSpan.FromMinutes(1));
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetSupplier_CreateIfNotExist.GetSuppliersByNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
RuntimeCache.Instance.Add(new OutSystems.Application.Caching.CacheKey(cacheHash), new OutSystems.RuntimeCommon.Pair<RL_d5c1b2482ff109e80580d8b5fb920193,long>((RL_d5c1b2482ff109e80580d8b5fb920193)(outParamList.Duplicate()),-1), new OutSystems.Application.Caching.ModuleDependency(requestContext.AppInfo.eSpaceUIDAsKey, requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Tenant.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Environment.Key), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Kind), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Region), requestContext.AppInfo.SettingsProvider.Get(OutSystems.RuntimeSettingsConfiguration.RuntimeSettingsDefinition.Stamp.Index)), TimeSpan.FromMinutes(1));
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
return ((RL_d5c1b2482ff109e80580d8b5fb920193)temp.First.Duplicate(),outParamCount);
}
}
}



}


}
