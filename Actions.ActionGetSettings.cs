namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetSettings : VarsBag {
public string inParamTableName;
public RL_12d8bb3d9ae5ae3d570d3e14f2e9595e queryResGetColumnSettingsByTableName_outParamList = new RL_12d8bb3d9ae5ae3d570d3e14f2e9595e();
public long queryResGetColumnSettingsByTableName_outParamCount = 0L;

public string resBinaryDataToText_outParamText = "";

public lcvGetSettings(string inParamTableName) {
this.inParamTableName = inParamTableName;
}
}
public class lcoGetSettings : VarsBag {
public string outParamOutSettingsText = "";

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetSettings(IRequestContext requestContext,string inParamTableName,CancellationToken cancellationToken) {
string outParamOutSettingsText = default;
lcoGetSettings result = new lcoGetSettings();
lcvGetSettings localVars = new lcvGetSettings(inParamTableName);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetSettings", "cf0e9209-a3bd-4677-a149-06f9ec265149"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetSettings", "cf0e9209-a3bd-4677-a149-06f9ec265149", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetColumnSettingsByTableName
cancellationToken.ThrowIfCancellationRequested();
int datasetGetColumnSettingsByTableName_maxRecords = 0;
int datasetGetColumnSettingsByTableName_startIndex = 0;(localVars.queryResGetColumnSettingsByTableName_outParamList,localVars.queryResGetColumnSettingsByTableName_outParamCount) = await FuncActionGetSettings.datasetGetColumnSettingsByTableName(requestContext,datasetGetColumnSettingsByTableName_maxRecords,datasetGetColumnSettingsByTableName_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParamTableName,cancellationToken);

// BinaryDataToText
localVars.resBinaryDataToText_outParamText = await Actions.ActionBinaryDataToText(requestContext,localVars.queryResGetColumnSettingsByTableName_outParamList.CurrentRec.ssENColumnSettings.ssJSONData,"",cancellationToken);

// OutSettingsText = BinaryDataToText.Text
result.outParamOutSettingsText=localVars.resBinaryDataToText_outParamText;
} //close CreateActionActivity using block
} // try

finally {
outParamOutSettingsText = result.outParamOutSettingsText;
} // inner-finally
RETURN_STATEMENT:
return outParamOutSettingsText;
}

public static class FuncActionGetSettings {

// Query Function "GetColumnSettingsByTableName" VciaXZgea0q5PsGXdQclNQ of Action "GetSettings"
public static async Task<(RL_12d8bb3d9ae5ae3d570d3e14f2e9595e,long)> datasetGetColumnSettingsByTableName(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,string qpteTableName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetSettings.GetColumnSettingsByTableName", "5d9ac855-1e98-4a6b-b93e-c19775072535");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetSettings.GetColumnSettingsByTableName", "5d9ac855-1e98-4a6b-b93e-c19775072535", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.CZIOz72jd0ahSQb57CZRSQ/NodesNotShownInESpaceTree.VciaXZgea0q5PsGXdQclNQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encolumnsettings1\".\"jsondata\" o2, NULL o3");
fromBuilder.Append(" FROM {ColumnSettings} \"encolumnsettings1\"");
whereBuilder.Append(" WHERE (\"encolumnsettings1\".\"tablename\" = @qpteTableName) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTableName", DbType.String, qpteTableName);
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"encolumnsettings1\".\"userid\" = @qpusUserId) AND (\"encolumnsettings1\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"encolumnsettings1\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"encolumnsettings1\".\"tablename\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetSettings.GetColumnSettingsByTableName.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetSettings.GetColumnSettingsByTableName.List", cancellationToken: cancellationToken);
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
