namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetRegionCodeById : VarsBag {
public long inParamRegionId;
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionById_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionById_outParamCount = 0L;

public lcvGetRegionCodeById(long inParamRegionId) {
this.inParamRegionId = inParamRegionId;
}
}
public class lcoGetRegionCodeById : VarsBag {
public string outParamCode = "";

public lcoGetRegionCodeById() {
}
}
/// <summary>
/// Action <code>GetRegionCodeById</code> that represents the Service Studio action
///  <code>GetRegionCodeById</code> <p> Description: </p>
/// </summary>
public static async Task<string> ActionGetRegionCodeById(IRequestContext requestContext,long inParamRegionId,CancellationToken cancellationToken) {
string outParamCode = default;
lcoGetRegionCodeById result = new lcoGetRegionCodeById();
lcvGetRegionCodeById localVars = new lcvGetRegionCodeById(inParamRegionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetRegionCodeById", "31edcd2b-c9cb-4ddb-8c06-29ac2b4e9de5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetRegionCodeById", "31edcd2b-c9cb-4ddb-8c06-29ac2b4e9de5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRegionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionById_maxRecords = 1;
if (datasetGetRegionById_maxRecords < 1) datasetGetRegionById_maxRecords = 1;
int datasetGetRegionById_startIndex = 0;(localVars.queryResGetRegionById_outParamList,localVars.queryResGetRegionById_outParamCount) = await FuncActionGetRegionCodeById.datasetGetRegionById(requestContext,datasetGetRegionById_maxRecords,datasetGetRegionById_startIndex,IterationMultiplicity.Never,localVars.inParamRegionId,cancellationToken);

// Code = GetRegionById.List.Current.Region.Code
result.outParamCode=localVars.queryResGetRegionById_outParamList.CurrentRec.ssENRegion.ssCode;
} //close CreateActionActivity using block
} // try

finally {
outParamCode = result.outParamCode;
} // inner-finally
RETURN_STATEMENT:
return outParamCode;
}

public static class FuncActionGetRegionCodeById {

// Query Function "GetRegionById" a+FVZu_chEmLTklg2PwW6Q of Action "GetRegionCodeById"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetRegionCodeById.GetRegionById", "6655e16b-dcef-4984-8b4e-4960d8fc16e9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetRegionCodeById.GetRegionById", "6655e16b-dcef-4984-8b4e-4960d8fc16e9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.K83tMcvJ202MBimsK06d5Q/NodesNotShownInESpaceTree.a+FVZu_chEmLTklg2PwW6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enregion10\".\"code\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion10\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enregion10\".\"id\" = @qpreId) AND (\"enregion10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enregion10\".\"id\" IS NULL)");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRegionCodeById.GetRegionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRegionCodeById.GetRegionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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
