namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersDistribution_DeleteOld : VarsBag {
public long inParamOrderMainId;
public RL_3c2483fef931c35c62e6128a52ac9903 queryResGetOrderApprovalsByOrderId_outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
public long queryResGetOrderApprovalsByOrderId_outParamCount = 0L;

public lcvOrdersDistribution_DeleteOld(long inParamOrderMainId) {
this.inParamOrderMainId = inParamOrderMainId;
}
}
/// <summary>
/// Action <code>OrdersDistribution_DeleteOld</code> that represents the Service Studio action
///  <code>OrdersDistribution_DeleteOld</code> <p> Description: </p>
/// </summary>
public static async Task ActionOrdersDistribution_DeleteOld(IRequestContext requestContext,long inParamOrderMainId,CancellationToken cancellationToken) {
lcvOrdersDistribution_DeleteOld localVars = new lcvOrdersDistribution_DeleteOld(inParamOrderMainId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersDistribution_DeleteOld", "3073ec70-6b2b-44b5-8221-743201a56e5b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersDistribution_DeleteOld", "3073ec70-6b2b-44b5-8221-743201a56e5b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderApprovalsByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalsByOrderId_maxRecords = 0;
int datasetGetOrderApprovalsByOrderId_startIndex = 0;(localVars.queryResGetOrderApprovalsByOrderId_outParamList,localVars.queryResGetOrderApprovalsByOrderId_outParamCount) = await FuncActionOrdersDistribution_DeleteOld.datasetGetOrderApprovalsByOrderId(requestContext,datasetGetOrderApprovalsByOrderId_maxRecords,datasetGetOrderApprovalsByOrderId_startIndex,IterationMultiplicity.Single,localVars.inParamOrderMainId,cancellationToken);

// Empty?
if((!(localVars.queryResGetOrderApprovalsByOrderId_outParamList.Empty))) {
// Foreach GetOrderApprovalsByOrderId.List
localVars.queryResGetOrderApprovalsByOrderId_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderApprovalsByOrderId_outParamList.Eof))) {
if((!((localVars.queryResGetOrderApprovalsByOrderId_outParamList.CurrentRec.ssENOrderApprovalLevel.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// DeleteOrderApprovalLevel
await ExtendedActions.DeleteOrderApprovalLevel(requestContext,localVars.queryResGetOrderApprovalsByOrderId_outParamList.CurrentRec.ssENOrderApprovalLevel.ssId,cancellationToken);

}

localVars.queryResGetOrderApprovalsByOrderId_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderApprovalsByOrderId_outParamList.EndIteration();
}

// DeleteOrderApproval
await ExtendedActions.DeleteOrderApproval(requestContext,localVars.queryResGetOrderApprovalsByOrderId_outParamList.CurrentRec.ssENOrderApproval.ssId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrdersDistribution_DeleteOld {

private static async Task<RC_2929b54077988f623db253f22a62f498> datasetGetOrderApprovalsByOrderIdReadDbAsync(RC_2929b54077988f623db253f22a62f498 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalsByOrderId" 9EwBwXTPeEGnVJymGJjIsA of Action "OrdersDistribution_DeleteOld"
public static async Task<(RL_3c2483fef931c35c62e6128a52ac9903,long)> datasetGetOrderApprovalsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("OrdersDistribution_DeleteOld.GetOrderApprovalsByOrderId", "c1014cf4-cf74-4178-a754-9ca61898c8b0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("OrdersDistribution_DeleteOld.GetOrderApprovalsByOrderId", "c1014cf4-cf74-4178-a754-9ca61898c8b0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.cOxzMCtrtUSCIXQyAaVuWw/NodesNotShownInESpaceTree.9EwBwXTPeEGnVJymGJjIsA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enorderapprovallevel2\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({OrderApproval} \"enorderapproval2\" Left JOIN {OrderApprovalLevel} \"enorderapprovallevel2\" ON (\"enorderapproval2\".\"id\" = \"enorderapprovallevel2\".\"orderapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval2\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval2\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval2\".\"orderid\" IS NULL)");
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
RL_3c2483fef931c35c62e6128a52ac9903 outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalsByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query OrdersDistribution_DeleteOld.GetOrderApprovalsByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c2483fef931c35c62e6128a52ac9903 _tmp = new RL_3c2483fef931c35c62e6128a52ac9903();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalsByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query OrdersDistribution_DeleteOld.GetOrderApprovalsByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c2483fef931c35c62e6128a52ac9903)_tmp;
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
