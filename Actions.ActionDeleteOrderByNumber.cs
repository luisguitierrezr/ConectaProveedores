namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteOrderByNumber : VarsBag {
public string inParamOrderNumber;
public RL_339e5fbd74448809f3620bf1c8c54b9a queryResGetOrderMainsByOrderNumber_outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
public long queryResGetOrderMainsByOrderNumber_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public lcvDeleteOrderByNumber(string inParamOrderNumber) {
this.inParamOrderNumber = inParamOrderNumber;
}
}
public class lcoDeleteOrderByNumber : VarsBag {
public bool outParamIsDeleted = false;

public lcoDeleteOrderByNumber() {
}
}
/// <summary>
/// Action <code>DeleteOrderByNumber</code> that represents the Service Studio action
///  <code>DeleteOrderByNumber</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionDeleteOrderByNumber(IRequestContext requestContext,string inParamOrderNumber,CancellationToken cancellationToken) {
bool outParamIsDeleted = default;
lcoDeleteOrderByNumber result = new lcoDeleteOrderByNumber();
lcvDeleteOrderByNumber localVars = new lcvDeleteOrderByNumber(inParamOrderNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteOrderByNumber", "5a44098c-936f-4a6b-af7c-4f0a83f3bf4a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteOrderByNumber", "5a44098c-936f-4a6b-af7c-4f0a83f3bf4a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderMainsByOrderNumber
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainsByOrderNumber_maxRecords = 1;
if (datasetGetOrderMainsByOrderNumber_maxRecords < 1) datasetGetOrderMainsByOrderNumber_maxRecords = 1;
int datasetGetOrderMainsByOrderNumber_startIndex = 0;(localVars.queryResGetOrderMainsByOrderNumber_outParamList,localVars.queryResGetOrderMainsByOrderNumber_outParamCount) = await FuncActionDeleteOrderByNumber.datasetGetOrderMainsByOrderNumber(requestContext,datasetGetOrderMainsByOrderNumber_maxRecords,datasetGetOrderMainsByOrderNumber_startIndex,IterationMultiplicity.Never,localVars.inParamOrderNumber,cancellationToken);

if((localVars.queryResGetOrderMainsByOrderNumber_outParamList.Empty)) {
// IsDeleted = False
result.outParamIsDeleted=false;
} else {
// DeleteOrderMain
await ExtendedActions.DeleteOrderMain(requestContext,localVars.queryResGetOrderMainsByOrderNumber_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// IsDeleted = True
result.outParamIsDeleted=true;
}

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("Order manual delete "+(result.outParamIsDeleted ? "True" : "False")), ssDescription = ("Delete of Order "+localVars.inParamOrderNumber), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamIsDeleted = result.outParamIsDeleted;
} // inner-finally
RETURN_STATEMENT:
return outParamIsDeleted;
}

public static class FuncActionDeleteOrderByNumber {

// Query Function "GetOrderMainsByOrderNumber" f+NkQYGjlEa9hR9FbWGpFA of Action "DeleteOrderByNumber"
public static async Task<(RL_339e5fbd74448809f3620bf1c8c54b9a,long)> datasetGetOrderMainsByOrderNumber(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteOrderByNumber.GetOrderMainsByOrderNumber", "4164e37f-a381-4694-bd85-1f456d61a914");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteOrderByNumber.GetOrderMainsByOrderNumber", "4164e37f-a381-4694-bd85-1f456d61a914", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jAlEWm+Ta0qvfE8Kg_O_Sg/NodesNotShownInESpaceTree.f+NkQYGjlEa9hR9FbWGpFA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain26\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM {OrderMain} \"enordermain26\"");
whereBuilder.Append(" WHERE ((trim(\"enordermain26\".\"ordernumber\")) = (trim(@qpteOrderNumber)))");
orderByBuilder.Append(" ORDER BY \"enordermain26\".\"ordernumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumber", DbType.String, qpteOrderNumber);
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
RL_339e5fbd74448809f3620bf1c8c54b9a outParamList = new RL_339e5fbd74448809f3620bf1c8c54b9a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteOrderByNumber.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_339e5fbd74448809f3620bf1c8c54b9a _tmp = new RL_339e5fbd74448809f3620bf1c8c54b9a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteOrderByNumber.GetOrderMainsByOrderNumber.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_339e5fbd74448809f3620bf1c8c54b9a)_tmp;
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
