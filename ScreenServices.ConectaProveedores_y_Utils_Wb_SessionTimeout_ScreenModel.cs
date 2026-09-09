using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel).Namespace);

    public long varLcIntervaltId;
public bool varLcShowWarning;
public int varLcSeconds;
public ConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel() {
}



    public ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel(long varLcIntervaltId, bool varLcShowWarning, int varLcSeconds, ConectaProveedores_y_Utils_Wb_SessionTimeout_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"IntervaltId", "ShowWarning", "Seconds", "GetSettings", "ClientVars"}, new string[] {"varLcIntervaltId", "varLcShowWarning", "varLcSeconds", "varLcGetSettings", "clientVariables"});
this.varLcIntervaltId = varLcIntervaltId;
this.varLcShowWarning = varLcShowWarning;
this.varLcSeconds = varLcSeconds;
this.varLcGetSettings = varLcGetSettings;
this.clientVariables = clientVariables;
}



    

    public class lcvGetSettings : VarsBag {
public RL_78f7eb5628c10c7f234959bf22490881 queryResGetCustomSettingValue_SessionTimeout_outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
public long queryResGetCustomSettingValue_SessionTimeout_outParamCount = 0L;

public RL_78f7eb5628c10c7f234959bf22490881 queryResGetCustomSettingValue_SessionWarning_outParamList = new RL_78f7eb5628c10c7f234959bf22490881();
public long queryResGetCustomSettingValue_SessionWarning_outParamCount = 0L;

public lcvGetSettings() {
}
}
public class lcoGetSettings : VarsBag {
public DateTime outParamWarningTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public DateTime outParamLogoutTime = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public int outParamWarningMinutes = 0;

public int outParamLogoutMinutes = 0;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<(DateTime,DateTime,int,int)> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
DateTime outParamWarningTime = default;
DateTime outParamLogoutTime = default;
int outParamWarningMinutes = default;
int outParamLogoutMinutes = default;
lcoGetSettings result = new lcoGetSettings();
lcvGetSettings localVars = new lcvGetSettings();
ConectaProveedores_y_Utils_Wb_SessionTimeout_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "01e50d22-db47-4b2c-9ad7-8f3873c94730"))
using (activitySource.CreateScreenDataActionActivity("Wb_SessionTimeout", "GetSettings")){
// Query datasetGetCustomSettingValue_SessionWarning
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCustomSettingValue_SessionWarning_maxRecords = 1;
if (datasetGetCustomSettingValue_SessionWarning_maxRecords < 1) datasetGetCustomSettingValue_SessionWarning_maxRecords = 1;
int datasetGetCustomSettingValue_SessionWarning_startIndex = 0;(localVars.queryResGetCustomSettingValue_SessionWarning_outParamList,localVars.queryResGetCustomSettingValue_SessionWarning_outParamCount) = await FuncDataActionGetSettings.datasetGetCustomSettingValue_SessionWarning(requestContext,datasetGetCustomSettingValue_SessionWarning_maxRecords,datasetGetCustomSettingValue_SessionWarning_startIndex,IterationMultiplicity.Never,cancellationToken);

// Query datasetGetCustomSettingValue_SessionTimeout
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCustomSettingValue_SessionTimeout_maxRecords = 1;
if (datasetGetCustomSettingValue_SessionTimeout_maxRecords < 1) datasetGetCustomSettingValue_SessionTimeout_maxRecords = 1;
int datasetGetCustomSettingValue_SessionTimeout_startIndex = 0;(localVars.queryResGetCustomSettingValue_SessionTimeout_outParamList,localVars.queryResGetCustomSettingValue_SessionTimeout_outParamCount) = await FuncDataActionGetSettings.datasetGetCustomSettingValue_SessionTimeout(requestContext,datasetGetCustomSettingValue_SessionTimeout_maxRecords,datasetGetCustomSettingValue_SessionTimeout_startIndex,IterationMultiplicity.Never,cancellationToken);

// Set Minutes
// WarningTime = AddMinutes
result.outParamWarningTime=BuiltInFunction.AddMinutes (BuiltInFunction.CurrDateTime (), BuiltInFunction.TextToInteger (localVars.queryResGetCustomSettingValue_SessionWarning_outParamList.CurrentRec.ssENCustomSettingValue.ssValue));

// LogoutTime = AddMinutes
result.outParamLogoutTime=BuiltInFunction.AddMinutes (BuiltInFunction.CurrDateTime (), BuiltInFunction.TextToInteger (localVars.queryResGetCustomSettingValue_SessionTimeout_outParamList.CurrentRec.ssENCustomSettingValue.ssValue));

// WarningMinutes = TextToInteger
result.outParamWarningMinutes=BuiltInFunction.TextToInteger (localVars.queryResGetCustomSettingValue_SessionWarning_outParamList.CurrentRec.ssENCustomSettingValue.ssValue);

// LogoutMinutes = TextToInteger
result.outParamLogoutMinutes=BuiltInFunction.TextToInteger (localVars.queryResGetCustomSettingValue_SessionTimeout_outParamList.CurrentRec.ssENCustomSettingValue.ssValue);
} //close CreateActionActivity using block
} // try

finally {
outParamWarningTime = result.outParamWarningTime;
outParamLogoutTime = result.outParamLogoutTime;
outParamWarningMinutes = result.outParamWarningMinutes;
outParamLogoutMinutes = result.outParamLogoutMinutes;
} // inner-finally
RETURN_STATEMENT:
return (outParamWarningTime,outParamLogoutTime,outParamWarningMinutes,outParamLogoutMinutes);
}


    public static class FuncDataActionGetSettings {

// Query Function "GetCustomSettingValue_SessionTimeout" __MZXEEey06qemIhHjDctQ of Action "GetSettings"
public static async Task<(RL_78f7eb5628c10c7f234959bf22490881,long)> datasetGetCustomSettingValue_SessionTimeout(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionTimeout", "5c19f3ff-1e41-4ecb-aa7a-62211e30dcb5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionTimeout", "5c19f3ff-1e41-4ecb-aa7a-62211e30dcb5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.4tf+qk+qnE+RF7jGc91+3A/DataActions.Ig3lAUfbLEua1484c8lHMA/NodesNotShownInESpaceTree.__MZXEEey06qemIhHjDctQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encustomsettingvalue5\".\"value\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {CustomSettingValue} \"encustomsettingvalue5\"");
whereBuilder.Append(" WHERE (\"encustomsettingvalue5\".\"customsettingid\" = ");
whereBuilder.Append(5
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionTimeout.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionTimeout.List", cancellationToken: cancellationToken);
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

// Query Function "GetCustomSettingValue_SessionWarning" NVEDguSP2ku0xOJ3zgDTNA of Action "GetSettings"
public static async Task<(RL_78f7eb5628c10c7f234959bf22490881,long)> datasetGetCustomSettingValue_SessionWarning(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionWarning", "82035135-8fe4-4bda-b4c4-e277ce00d334");
using var queryActivity = activitySource.CreateAggregateQueryActivity("y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionWarning", "82035135-8fe4-4bda-b4c4-e277ce00d334", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.4tf+qk+qnE+RF7jGc91+3A/DataActions.Ig3lAUfbLEua1484c8lHMA/NodesNotShownInESpaceTree.NVEDguSP2ku0xOJ3zgDTNA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encustomsettingvalue6\".\"value\" o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {CustomSettingValue} \"encustomsettingvalue6\"");
whereBuilder.Append(" WHERE (\"encustomsettingvalue6\".\"customsettingid\" = ");
whereBuilder.Append(4
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionWarning.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_SessionTimeout.GetSettings.GetCustomSettingValue_SessionWarning.List", cancellationToken: cancellationToken);
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
