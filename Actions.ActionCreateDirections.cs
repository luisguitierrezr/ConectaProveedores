namespace ssConectaProveedores;

public partial class Actions {
public class lcvCreateDirections : VarsBag {
public BasicTypeList<string> inParamDirectionsList;
public RL_9895159eebcdcdaed80fbd832f52d838 queryResGetAllDirections_outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
public long queryResGetAllDirections_outParamCount = 0L;

public BasicTypeList<string> resGetDistinctDirections_outParamDistinctList = new BasicTypeList<string>();

public RL_9895159eebcdcdaed80fbd832f52d838 resListFilter_outParamFilteredList = new RL_9895159eebcdcdaed80fbd832f52d838();

public long resServiceTelcelDirectionCreate_outParamId = 0L;

public BasicTypeList<string> resGetJustWithNotEmptyValues_outParamFilteredList = new BasicTypeList<string>();

public RL_9895159eebcdcdaed80fbd832f52d838 queryResGetLast_outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
public long queryResGetLast_outParamCount = 0L;

public lcvCreateDirections(BasicTypeList<string> inParamDirectionsList) {
this.inParamDirectionsList = inParamDirectionsList;
}
}
public class lcoCreateDirections : VarsBag {
public long outParamLastDirectionsId = 0L;

public lcoCreateDirections() {
}
}
/// <summary>
/// Action <code>CreateDirections</code> that represents the Service Studio action
///  <code>CreateDirections</code> <p> Description: </p>
/// </summary>
public static async Task<long> ActionCreateDirections(IRequestContext requestContext,BasicTypeList<string> inParamDirectionsList,CancellationToken cancellationToken) {
long outParamLastDirectionsId = default;
lcoCreateDirections result = new lcoCreateDirections();
lcvCreateDirections localVars = new lcvCreateDirections(inParamDirectionsList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CreateDirections", "4ea256e4-4d4a-462e-969b-ef3c43949e44"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CreateDirections", "4ea256e4-4d4a-462e-969b-ef3c43949e44", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetDistinctDirections
localVars.resGetDistinctDirections_outParamDistinctList = (((BasicTypeList<string>) localVars.inParamDirectionsList.Distinct()));

// GetJustWithNotEmptyValues
localVars.resGetJustWithNotEmptyValues_outParamFilteredList = (((BasicTypeList<string>)await  localVars.resGetDistinctDirections_outParamDistinctList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.Trim (p)!=""), cancellationToken)));

// Query datasetGetAllDirections
cancellationToken.ThrowIfCancellationRequested();
int datasetGetAllDirections_maxRecords = 99999;
if (datasetGetAllDirections_maxRecords < 1) datasetGetAllDirections_maxRecords = 1;
int datasetGetAllDirections_startIndex = 0;(localVars.queryResGetAllDirections_outParamList,localVars.queryResGetAllDirections_outParamCount) = await FuncActionCreateDirections.datasetGetAllDirections(requestContext,datasetGetAllDirections_maxRecords,datasetGetAllDirections_startIndex,IterationMultiplicity.Multiple,cancellationToken);

// Foreach GetJustWithNotEmptyValues.FilteredList
localVars.resGetJustWithNotEmptyValues_outParamFilteredList.StartIteration();
try {while (!((localVars.resGetJustWithNotEmptyValues_outParamFilteredList.Eof))) {
if((!(localVars.queryResGetAllDirections_outParamList.Empty))) {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_9895159eebcdcdaed80fbd832f52d838)await  localVars.queryResGetAllDirections_outParamList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.ToUpper (p.ssENTelcelDirection.ssName)==BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resGetJustWithNotEmptyValues_outParamFilteredList.CurrentRec))), cancellationToken)));

if((!(localVars.resListFilter_outParamFilteredList.Empty))) {
localVars.resGetJustWithNotEmptyValues_outParamFilteredList.Advance();
continue;
}

}

// ServiceTelcelDirectionCreate
localVars.resServiceTelcelDirectionCreate_outParamId = await ServiceAPIs.ServiceAPIServiceTelcelDirectionCreate(requestContext,new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssName = BuiltInFunction.Trim (BuiltInFunction.ToUpper (localVars.resGetJustWithNotEmptyValues_outParamFilteredList.CurrentRec)), ssIsActive = true, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssUpdatedOn = BuiltInFunction.CurrDateTime (), ssUpdatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// not IsSuccess?
if(((localVars.resServiceTelcelDirectionCreate_outParamId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// RaiseError GetNextApprover
throw new Ex_GetNextApproverUserException (AppUtils.GetStringResource("DjpG_uKFW0ePNjxG8D6itg#Message.257874243.1", "New Direction detected. Error creating new record."));

}

localVars.resGetJustWithNotEmptyValues_outParamFilteredList.Advance();
}

} finally {
localVars.resGetJustWithNotEmptyValues_outParamFilteredList.EndIteration();
}

// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

// Query datasetGetLast
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLast_maxRecords = 1;
if (datasetGetLast_maxRecords < 1) datasetGetLast_maxRecords = 1;
int datasetGetLast_startIndex = 0;(localVars.queryResGetLast_outParamList,localVars.queryResGetLast_outParamCount) = await FuncActionCreateDirections.datasetGetLast(requestContext,datasetGetLast_maxRecords,datasetGetLast_startIndex,IterationMultiplicity.Never,localVars.resGetJustWithNotEmptyValues_outParamFilteredList.CurrentRec,cancellationToken);

// LastDirectionsId = GetLast.List.Current.TelcelDirection.Id
result.outParamLastDirectionsId=localVars.queryResGetLast_outParamList.CurrentRec.ssENTelcelDirection.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamLastDirectionsId = result.outParamLastDirectionsId;
} // inner-finally
RETURN_STATEMENT:
return outParamLastDirectionsId;
}

public static class FuncActionCreateDirections {

// Query Function "GetAllDirections" zx3XDEzUtEi+hWZ_ZI6mvg of Action "CreateDirections"
public static async Task<(RL_9895159eebcdcdaed80fbd832f52d838,long)> datasetGetAllDirections(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CreateDirections.GetAllDirections", "0cd71dcf-d44c-48b4-be85-667f648ea6be");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CreateDirections.GetAllDirections", "0cd71dcf-d44c-48b4-be85-667f648ea6be", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.5FaiTkpNLkaWm+88Q5SeRA/NodesNotShownInESpaceTree.zx3XDEzUtEi+hWZ_ZI6mvg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"entelceldirection4\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TelcelDirection} \"entelceldirection4\"");
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
RL_9895159eebcdcdaed80fbd832f52d838 outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CreateDirections.GetAllDirections.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9895159eebcdcdaed80fbd832f52d838 _tmp = new RL_9895159eebcdcdaed80fbd832f52d838();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CreateDirections.GetAllDirections.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9895159eebcdcdaed80fbd832f52d838)_tmp;
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

// Query Function "GetLast" ynt57BnKqEGGcivt2C+PfQ of Action "CreateDirections"
public static async Task<(RL_9895159eebcdcdaed80fbd832f52d838,long)> datasetGetLast(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CreateDirections.GetLast", "ec797bca-ca19-41a8-8672-2bedd82f8f7d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CreateDirections.GetLast", "ec797bca-ca19-41a8-8672-2bedd82f8f7d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.5FaiTkpNLkaWm+88Q5SeRA/NodesNotShownInESpaceTree.ynt57BnKqEGGcivt2C+PfQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entelceldirection5\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TelcelDirection} \"entelceldirection5\"");
whereBuilder.Append(" WHERE ((Upper(\"entelceldirection5\".\"name\")) = (trim((Upper(@qpteName)))))");
sqlCmd.CreateParameterWithoutReplacements("@qpteName", DbType.String, qpteName);
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
RL_9895159eebcdcdaed80fbd832f52d838 outParamList = new RL_9895159eebcdcdaed80fbd832f52d838();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CreateDirections.GetLast.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9895159eebcdcdaed80fbd832f52d838 _tmp = new RL_9895159eebcdcdaed80fbd832f52d838();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CreateDirections.GetLast.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9895159eebcdcdaed80fbd832f52d838)_tmp;
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
