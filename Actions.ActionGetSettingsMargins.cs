namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetSettingsMargins : VarsBag {
public RL_78f7eb5628c10c7f234959bf22490881 queryResGetCustomSetting_NationalMargin_outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
public long queryResGetCustomSetting_NationalMargin_outParamCount = 0L;

public RL_78f7eb5628c10c7f234959bf22490881 queryResGetCustomSetting_ForeignMargin_outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
public long queryResGetCustomSetting_ForeignMargin_outParamCount = 0L;

public lcvGetSettingsMargins() {
}
}
public class lcoGetSettingsMargins : VarsBag {
public decimal outParamNationalMargin = 0.0M;

public decimal outParamForeignMargin = 0.0M;

public lcoGetSettingsMargins() {
}
}
/// <summary>
/// Action <code>GetSettingsMargins</code> that represents the Service Studio action
///  <code>GetSettingsMargins</code> <p> Description: </p>
/// </summary>
public static async Task<(decimal,decimal)> ActionGetSettingsMargins(IRequestContext requestContext,CancellationToken cancellationToken) {
decimal outParamNationalMargin = default;
decimal outParamForeignMargin = default;
lcoGetSettingsMargins result = new lcoGetSettingsMargins();
lcvGetSettingsMargins localVars = new lcvGetSettingsMargins();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetSettingsMargins", "e5ce1115-01f6-436d-99cb-9f5f61928c02"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetSettingsMargins", "e5ce1115-01f6-436d-99cb-9f5f61928c02", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetCustomSetting_NationalMargin
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCustomSetting_NationalMargin_maxRecords = 1;
if (datasetGetCustomSetting_NationalMargin_maxRecords < 1) datasetGetCustomSetting_NationalMargin_maxRecords = 1;
int datasetGetCustomSetting_NationalMargin_startIndex = 0;(localVars.queryResGetCustomSetting_NationalMargin_outParamList,localVars.queryResGetCustomSetting_NationalMargin_outParamCount) = await FuncActionGetSettingsMargins.datasetGetCustomSetting_NationalMargin(requestContext,datasetGetCustomSetting_NationalMargin_maxRecords,datasetGetCustomSetting_NationalMargin_startIndex,IterationMultiplicity.Never,cancellationToken);

// Query datasetGetCustomSetting_ForeignMargin
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCustomSetting_ForeignMargin_maxRecords = 1;
if (datasetGetCustomSetting_ForeignMargin_maxRecords < 1) datasetGetCustomSetting_ForeignMargin_maxRecords = 1;
int datasetGetCustomSetting_ForeignMargin_startIndex = 0;(localVars.queryResGetCustomSetting_ForeignMargin_outParamList,localVars.queryResGetCustomSetting_ForeignMargin_outParamCount) = await FuncActionGetSettingsMargins.datasetGetCustomSetting_ForeignMargin(requestContext,datasetGetCustomSetting_ForeignMargin_maxRecords,datasetGetCustomSetting_ForeignMargin_startIndex,IterationMultiplicity.Never,cancellationToken);

// NationalMargin = TextToDecimal
result.outParamNationalMargin=BuiltInFunction.TextToDecimal (localVars.queryResGetCustomSetting_NationalMargin_outParamList.CurrentRec.ssENCustomSettingValue.ssValue);

// ForeignMargin = TextToDecimal
result.outParamForeignMargin=BuiltInFunction.TextToDecimal (localVars.queryResGetCustomSetting_ForeignMargin_outParamList.CurrentRec.ssENCustomSettingValue.ssValue);
} //close CreateActionActivity using block
} // try

finally {
outParamNationalMargin = result.outParamNationalMargin;
outParamForeignMargin = result.outParamForeignMargin;
} // inner-finally
RETURN_STATEMENT:
return (outParamNationalMargin,outParamForeignMargin);
}

public static class FuncActionGetSettingsMargins {

// Query Function "GetCustomSetting_NationalMargin" 4O4SN3XIBEeqAAXz_PaFiQ of Action "GetSettingsMargins"
public static async Task<(RL_78f7eb5628c10c7f234959bf22490881,long)> datasetGetCustomSetting_NationalMargin(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetSettingsMargins.GetCustomSetting_NationalMargin", "3712eee0-c875-4704-aa00-05f3fcf68589");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetSettingsMargins.GetCustomSetting_NationalMargin", "3712eee0-c875-4704-aa00-05f3fcf68589", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.FRHO5fYBbUOZy59fYZKMAg/NodesNotShownInESpaceTree.4O4SN3XIBEeqAAXz_PaFiQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encustomsettingvalue2\".\"value\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {CustomSettingValue} \"encustomsettingvalue2\"");
whereBuilder.Append(" WHERE (\"encustomsettingvalue2\".\"customsettingid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")");
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
RL_78f7eb5628c10c7f234959bf22490881 outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetSettingsMargins.GetCustomSetting_NationalMargin.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_78f7eb5628c10c7f234959bf22490881 _tmp = new RL_78f7eb5628c10c7f234959bf22490881();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetSettingsMargins.GetCustomSetting_NationalMargin.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_78f7eb5628c10c7f234959bf22490881)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetCustomSetting_ForeignMargin" fIZPUslss0WEARBKjGRJOw of Action "GetSettingsMargins"
public static async Task<(RL_78f7eb5628c10c7f234959bf22490881,long)> datasetGetCustomSetting_ForeignMargin(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetSettingsMargins.GetCustomSetting_ForeignMargin", "524f867c-6cc9-45b3-8401-104a8c64493b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetSettingsMargins.GetCustomSetting_ForeignMargin", "524f867c-6cc9-45b3-8401-104a8c64493b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.FRHO5fYBbUOZy59fYZKMAg/NodesNotShownInESpaceTree.fIZPUslss0WEARBKjGRJOw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encustomsettingvalue3\".\"value\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {CustomSettingValue} \"encustomsettingvalue3\"");
whereBuilder.Append(" WHERE (\"encustomsettingvalue3\".\"customsettingid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")");
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
RL_78f7eb5628c10c7f234959bf22490881 outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetSettingsMargins.GetCustomSetting_ForeignMargin.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_78f7eb5628c10c7f234959bf22490881 _tmp = new RL_78f7eb5628c10c7f234959bf22490881();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetSettingsMargins.GetCustomSetting_ForeignMargin.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_78f7eb5628c10c7f234959bf22490881)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
