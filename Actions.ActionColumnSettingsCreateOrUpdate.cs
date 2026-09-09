namespace ssConectaProveedores;

public partial class Actions {
public class lcvColumnSettingsCreateOrUpdate : VarsBag {
public EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource;
public RL_12d8bb3d9ae5ae3d570d3e14f2e9595e queryResGetColumnSettingsByTableName_outParamList = new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
public long queryResGetColumnSettingsByTableName_outParamCount = 0L;

public long resCreateOrUpdateColumnSettings_outParamId = 0L;

public lcvColumnSettingsCreateOrUpdate(EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoColumnSettingsCreateOrUpdate : VarsBag {
public long outParamId = 0L;

public lcoColumnSettingsCreateOrUpdate() {
}
}
/// <summary>
/// Action <code>ColumnSettingsCreateOrUpdate</code> that represents the Service Studio action
///  <code>ColumnSettingsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdate entit
/// y action, enabling logic to run consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ActionColumnSettingsCreateOrUpdate(IRequestContext requestContext,EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoColumnSettingsCreateOrUpdate result = new lcoColumnSettingsCreateOrUpdate();
lcvColumnSettingsCreateOrUpdate localVars = new lcvColumnSettingsCreateOrUpdate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ColumnSettingsCreateOrUpdate", "b72457c4-b1ce-4e9c-8b0c-1b386b6aeb93"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ColumnSettingsCreateOrUpdate", "b72457c4-b1ce-4e9c-8b0c-1b386b6aeb93", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetColumnSettingsByTableName
cancellationToken.ThrowIfCancellationRequested();
int datasetGetColumnSettingsByTableName_maxRecords = 0;
int datasetGetColumnSettingsByTableName_startIndex = 0;(localVars.queryResGetColumnSettingsByTableName_outParamList,localVars.queryResGetColumnSettingsByTableName_outParamCount) = await FuncActionColumnSettingsCreateOrUpdate.datasetGetColumnSettingsByTableName(requestContext,datasetGetColumnSettingsByTableName_maxRecords,datasetGetColumnSettingsByTableName_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParamSource.ssTableName,cancellationToken);

// CreateOrUpdateColumnSettings
localVars.resCreateOrUpdateColumnSettings_outParamId = await ExtendedActions.CreateOrUpdateColumnSettings(requestContext,new RC_25c6d4ad26c50e9400baa0d709166594(){ ssENColumnSettings = new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord(){ ssId = localVars.queryResGetColumnSettingsByTableName_outParamList.CurrentRec.ssENColumnSettings.ssId, ssTableName = localVars.inParamSource.ssTableName, ssJSONData = localVars.inParamSource.ssJSONData, ssUserId = BuiltInFunction.GetUserId () } }.ChangedAttributes,new RC_25c6d4ad26c50e9400baa0d709166594(){ ssENColumnSettings = new EN_b8682919578ddd4d17f9eb185aad3c49EntityRecord(){ ssId = localVars.queryResGetColumnSettingsByTableName_outParamList.CurrentRec.ssENColumnSettings.ssId, ssTableName = localVars.inParamSource.ssTableName, ssJSONData = localVars.inParamSource.ssJSONData, ssUserId = BuiltInFunction.GetUserId () } },cancellationToken);

// Set Id
// Id = CreateOrUpdateColumnSettings.Id
result.outParamId=localVars.resCreateOrUpdateColumnSettings_outParamId;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionColumnSettingsCreateOrUpdate {

// Query Function "GetColumnSettingsByTableName" TIgqUGWWOUaY1jGVcLko0Q of Action "ColumnSettingsCreateOrUpdate"
public static async Task<(RL_12d8bb3d9ae5ae3d570d3e14f2e9595e,long)> datasetGetColumnSettingsByTableName(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,string qpteTableName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ColumnSettingsCreateOrUpdate.GetColumnSettingsByTableName", "502a884c-9665-4639-98d6-319570b928d1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ColumnSettingsCreateOrUpdate.GetColumnSettingsByTableName", "502a884c-9665-4639-98d6-319570b928d1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.xFckt86xnE6LDBs4a2rrkw/NodesNotShownInESpaceTree.TIgqUGWWOUaY1jGVcLko0Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encolumnsettings\".\"id\" o0, NULL o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {ColumnSettings} \"encolumnsettings\"");
whereBuilder.Append(" WHERE ((\"encolumnsettings\".\"tablename\" = @qpteTableName) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTableName", DbType.String, qpteTableName);
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"encolumnsettings\".\"userid\" = @qpusUserId) AND (\"encolumnsettings\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"encolumnsettings\".\"userid\" IS NULL)");
}
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"encolumnsettings\".\"tablename\" ASC ");
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
RL_12d8bb3d9ae5ae3d570d3e14f2e9595e outParamList = new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ColumnSettingsCreateOrUpdate.GetColumnSettingsByTableName.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_12d8bb3d9ae5ae3d570d3e14f2e9595e _tmp = new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ColumnSettingsCreateOrUpdate.GetColumnSettingsByTableName.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_12d8bb3d9ae5ae3d570d3e14f2e9595e)_tmp;
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
