namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetRegionIdByCode : VarsBag {
public string inParamRegionCode;
public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionById_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionById_outParamCount = 0L;

public lcvGetRegionIdByCode(string inParamRegionCode) {
this.inParamRegionCode = inParamRegionCode;
}
}
public class lcoGetRegionIdByCode : VarsBag {
public long outParamId = 0L;

public lcoGetRegionIdByCode() {
}
}
/// <summary>
/// Action <code>GetRegionIdByCode</code> that represents the Service Studio action
///  <code>GetRegionIdByCode</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionGetRegionIdByCode(IRequestContext requestContext,string inParamRegionCode,CancellationToken cancellationToken) {
long outParamId = default;
lcoGetRegionIdByCode result = new lcoGetRegionIdByCode();
lcvGetRegionIdByCode localVars = new lcvGetRegionIdByCode(inParamRegionCode);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetRegionIdByCode", "6328edb9-ff2d-4beb-a08d-00a76909fd71"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetRegionIdByCode", "6328edb9-ff2d-4beb-a08d-00a76909fd71", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((BuiltInFunction.LengthSC (localVars.inParamRegionCode)!=4))) {
// Id = NullIdentifier
result.outParamId=Convert.ToInt64(BuiltInFunction.NullIdentifier ());
} else {
// Query datasetGetRegionById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionById_maxRecords = 1;
if (datasetGetRegionById_maxRecords < 1) datasetGetRegionById_maxRecords = 1;
int datasetGetRegionById_startIndex = 0;(localVars.queryResGetRegionById_outParamList,localVars.queryResGetRegionById_outParamCount) = await FuncActionGetRegionIdByCode.datasetGetRegionById(requestContext,datasetGetRegionById_maxRecords,datasetGetRegionById_startIndex,IterationMultiplicity.Never,localVars.inParamRegionCode,cancellationToken);

// Id = GetRegionById.List.Current.Region.Id
result.outParamId=localVars.queryResGetRegionById_outParamList.CurrentRec.ssENRegion.ssId;
}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionGetRegionIdByCode {

// Query Function "GetRegionById" rIiSK8KJI0GEiUCcORGXnA of Action "GetRegionIdByCode"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteRegionCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetRegionIdByCode.GetRegionById", "2b9288ac-89c2-4123-8489-409c3911979c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetRegionIdByCode.GetRegionById", "2b9288ac-89c2-4123-8489-409c3911979c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ue0oYy3_60ugjQCnaQn9cQ/NodesNotShownInESpaceTree.rIiSK8KJI0GEiUCcORGXnA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion22\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion22\"");
whereBuilder.Append(" WHERE ((substring(\"enregion22\".\"code\" from (2) + 1 for 2)) = (substring(@qpteRegionCode from (2) + 1 for 2)))");
sqlCmd.CreateParameterWithoutReplacements("@qpteRegionCode", DbType.String, qpteRegionCode);
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRegionIdByCode.GetRegionById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRegionIdByCode.GetRegionById.List", cancellationToken: cancellationToken);
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
