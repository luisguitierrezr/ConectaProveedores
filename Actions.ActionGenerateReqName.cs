namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateReqName : VarsBag {
public long inParami_RegionId;
public RL_7c5a995519f0d2ebac2441eb253f1bf8 queryResGetLastReqCounter_outParamList = new RL_7c5a995519f0d2ebac2441eb253f1bf8();
public long queryResGetLastReqCounter_outParamCount = 0L;

public RL_5c6c8b32275d20f737a40af96822f0ed queryResGetNextConsecutiveCode_outParamList = new RL_5c6c8b32275d20f737a40af96822f0ed();
public long queryResGetNextConsecutiveCode_outParamCount = 0L;

public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionCode_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionCode_outParamCount = 0L;

public lcvGenerateReqName(long inParami_RegionId) {
this.inParami_RegionId = inParami_RegionId;
}
}
public class lcoGenerateReqName : VarsBag {
public string outParamo_Name = "";

public int outParamo_Counter = 0;

public lcoGenerateReqName() {
}
}
/// <summary>
/// Action <code>GenerateReqName</code> that represents the Service Studio action
///  <code>GenerateReqName</code> <p> Description: </p>
/// </summary>
public static async Task<(string,int)> ActionGenerateReqName(IRequestContext requestContext,long inParami_RegionId,CancellationToken cancellationToken) {
string outParamo_Name = default;
int outParamo_Counter = default;
lcoGenerateReqName result = new lcoGenerateReqName();
lcvGenerateReqName localVars = new lcvGenerateReqName(inParami_RegionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateReqName", "92a16bed-3e80-403a-b46c-a883e610f89a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateReqName", "92a16bed-3e80-403a-b46c-a883e610f89a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRegionCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionCode_maxRecords = 1;
if (datasetGetRegionCode_maxRecords < 1) datasetGetRegionCode_maxRecords = 1;
int datasetGetRegionCode_startIndex = 0;(localVars.queryResGetRegionCode_outParamList,localVars.queryResGetRegionCode_outParamCount) = await FuncActionGenerateReqName.datasetGetRegionCode(requestContext,datasetGetRegionCode_maxRecords,datasetGetRegionCode_startIndex,IterationMultiplicity.Never,localVars.inParami_RegionId,cancellationToken);

// Query datasetGetLastReqCounter
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLastReqCounter_maxRecords = 1;
if (datasetGetLastReqCounter_maxRecords < 1) datasetGetLastReqCounter_maxRecords = 1;
int datasetGetLastReqCounter_startIndex = 0;(localVars.queryResGetLastReqCounter_outParamList,localVars.queryResGetLastReqCounter_outParamCount) = await FuncActionGenerateReqName.datasetGetLastReqCounter(requestContext,datasetGetLastReqCounter_maxRecords,datasetGetLastReqCounter_startIndex,IterationMultiplicity.Never,localVars.inParami_RegionId,cancellationToken);

// Query QueryGetNextConsecutiveCode
cancellationToken.ThrowIfCancellationRequested();
int QueryGetNextConsecutiveCode_maxRecords = 0;
int QueryGetNextConsecutiveCode_startIndex = 0;(localVars.queryResGetNextConsecutiveCode_outParamList,localVars.queryResGetNextConsecutiveCode_outParamCount) = await FuncActionGenerateReqName.QueryGetNextConsecutiveCode(requestContext,QueryGetNextConsecutiveCode_maxRecords,QueryGetNextConsecutiveCode_startIndex,IterationMultiplicity.Never,Convert.ToInt64((localVars.queryResGetLastReqCounter_outParamList.CurrentRec.ssCounter+1)),cancellationToken);

// o_Name = "REQ" + Substr + FormatDateTime + GetNextConsecutiveCode.List.Current.Text.Value
result.outParamo_Name=((("REQ"+BuiltInFunction.SubstrSC (localVars.queryResGetRegionCode_outParamList.CurrentRec.ssENRegion.ssCode, 2, 10))+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "yyyyMM"))+localVars.queryResGetNextConsecutiveCode_outParamList.CurrentRec.ssSTText.ssValue);

// o_Counter = GetLastReqCounter.List.Current.Counter + 1
result.outParamo_Counter=(localVars.queryResGetLastReqCounter_outParamList.CurrentRec.ssCounter+1);
} //close CreateActionActivity using block
} // try

finally {
outParamo_Name = result.outParamo_Name;
outParamo_Counter = result.outParamo_Counter;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Name,outParamo_Counter);
}

public static class FuncActionGenerateReqName {

// Query Function "GetLastReqCounter" iKxrnm1zKkelt4SKo9uw8A of Action "GenerateReqName"
public static async Task<(RL_7c5a995519f0d2ebac2441eb253f1bf8,long)> datasetGetLastReqCounter(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateReqName.GetLastReqCounter", "9e6bac88-736d-472a-a5b7-848aa3dbb0f0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateReqName.GetLastReqCounter", "9e6bac88-736d-472a-a5b7-848aa3dbb0f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7WuhkoA+OkC0bKiD5hD4mg/NodesNotShownInESpaceTree.iKxrnm1zKkelt4SKo9uw8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisition38\".\"counter\" \"counter\"");
fromBuilder.Append(" FROM {Requisition} \"enrequisition38\"");
whereBuilder.Append(" WHERE ");
if (qpreRegionId != 0) {
whereBuilder.Append("((\"enrequisition38\".\"regionid\" = @qpreRegionId) AND (\"enrequisition38\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"enrequisition38\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ((extract(year from \"enrequisition38\".\"createdon\"::timestamptz)) = (extract(year from (to_date(@qepCurrdate, 'YYYY-MM-DD'))::timestamptz)))");
groupByBuilder.Append(" GROUP BY \"enrequisition38\".\"counter\"");
orderByBuilder.Append(" ORDER BY \"counter\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
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
RL_7c5a995519f0d2ebac2441eb253f1bf8 outParamList = new RL_7c5a995519f0d2ebac2441eb253f1bf8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateReqName.GetLastReqCounter.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7c5a995519f0d2ebac2441eb253f1bf8 _tmp = new RL_7c5a995519f0d2ebac2441eb253f1bf8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateReqName.GetLastReqCounter.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7c5a995519f0d2ebac2441eb253f1bf8)_tmp;
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

// Query Function "GetNextConsecutiveCode" dx44ruaumkeC3amv8X3tNQ of Action "GenerateReqName"
public static async Task<(RL_5c6c8b32275d20f737a40af96822f0ed,long)> QueryGetNextConsecutiveCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qploValue,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GenerateReqName.GetNextConsecutiveCode", "ae381e77-aee6-479a-82dd-a9aff17ded35");
using var queryActivity = activitySource.CreateSqlQueryActivity("GenerateReqName.GetNextConsecutiveCode", "ae381e77-aee6-479a-82dd-a9aff17ded35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
sqlCmd.CreateParameter("@qploValue", DbType.Int64, qploValue);
string sql = "";
string advSql = "SELECT LPAD(number::text, GREATEST(5, LENGTH(number::text)), '0') \nFROM (VALUES (@qploValue)) AS t(number);";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_5c6c8b32275d20f737a40af96822f0ed outParamList = new RL_5c6c8b32275d20f737a40af96822f0ed();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateReqName.GetNextConsecutiveCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c6c8b32275d20f737a40af96822f0ed _tmp = new RL_5c6c8b32275d20f737a40af96822f0ed();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateReqName.GetNextConsecutiveCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c6c8b32275d20f737a40af96822f0ed)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetNextConsecutiveCode in GenerateReqName in ConectaProveedores (SELECT LPAD(number::text, GREATEST(5, LENGTH(number::text)), '0')  FROM (VALUES (@Value)) AS t(number);): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetNextConsecutiveCode in GenerateReqName in ConectaProveedores (SELECT LPAD(number::text, GREATEST(5, LENGTH(number::text)), '0')  FROM (VALUES (@Value)) AS t(number);): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetNextConsecutiveCode in GenerateReqName in ConectaProveedores (SELECT LPAD(number::text, GREATEST(5, LENGTH(number::text)), '0')  FROM (VALUES (@Value)) AS t(number);): " + aqExcep.Message));
}
}
}

// Query Function "GetRegionCode" qtLIwOs440O4ynKNnO5FnQ of Action "GenerateReqName"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateReqName.GetRegionCode", "c0c8d2aa-38eb-43e3-b8ca-728d9cee459d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateReqName.GetRegionCode", "c0c8d2aa-38eb-43e3-b8ca-728d9cee459d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.7WuhkoA+OkC0bKiD5hD4mg/NodesNotShownInESpaceTree.qtLIwOs440O4ynKNnO5FnQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enregion38\".\"code\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion38\"");
whereBuilder.Append(" WHERE ");
if (qpreId != 0) {
whereBuilder.Append("((\"enregion38\".\"id\" = @qpreId) AND (\"enregion38\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreId", DbType.Int64, qpreId);
} else {
whereBuilder.Append("(\"enregion38\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateReqName.GetRegionCode.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateReqName.GetRegionCode.List", cancellationToken: cancellationToken);
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
