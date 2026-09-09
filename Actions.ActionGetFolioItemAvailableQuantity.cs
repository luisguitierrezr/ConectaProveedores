namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFolioItemAvailableQuantity : VarsBag {
public long inParamOrderMainItemId;
public long inParamFolioIdtoExclude;
public RL_f09a54b116410a7027db4eb30998df1e queryResGetFolioItemsByOrderMainItemId_outParamList = new RL_f09a54b116410a7027db4eb30998df1e();
public long queryResGetFolioItemsByOrderMainItemId_outParamCount = 0L;

public lcvGetFolioItemAvailableQuantity(long inParamOrderMainItemId, long inParamFolioIdtoExclude) {
this.inParamOrderMainItemId = inParamOrderMainItemId;
this.inParamFolioIdtoExclude = inParamFolioIdtoExclude;
}
}
public class lcoGetFolioItemAvailableQuantity : VarsBag {
public decimal outParamDeliveryQtt = 0.0M;

public lcoGetFolioItemAvailableQuantity() {
}
}
/// <summary>
/// Action <code>GetFolioItemAvailableQuantity</code> that represents the Service Studio action
///  <code>GetFolioItemAvailableQuantity</code> <p> Description: </p>
/// </summary>
public static async Task<decimal> ActionGetFolioItemAvailableQuantity(IRequestContext requestContext,long inParamOrderMainItemId,long inParamFolioIdtoExclude,CancellationToken cancellationToken) {
decimal outParamDeliveryQtt = default;
lcoGetFolioItemAvailableQuantity result = new lcoGetFolioItemAvailableQuantity();
lcvGetFolioItemAvailableQuantity localVars = new lcvGetFolioItemAvailableQuantity(inParamOrderMainItemId, inParamFolioIdtoExclude);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFolioItemAvailableQuantity", "5f827727-bf3f-415b-819d-93b22b413465"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFolioItemAvailableQuantity", "5f827727-bf3f-415b-819d-93b22b413465", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioItemsByOrderMainItemId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByOrderMainItemId_maxRecords = 0;
int datasetGetFolioItemsByOrderMainItemId_startIndex = 0;(localVars.queryResGetFolioItemsByOrderMainItemId_outParamList,localVars.queryResGetFolioItemsByOrderMainItemId_outParamCount) = await FuncActionGetFolioItemAvailableQuantity.datasetGetFolioItemsByOrderMainItemId(requestContext,datasetGetFolioItemsByOrderMainItemId_maxRecords,datasetGetFolioItemsByOrderMainItemId_startIndex,IterationMultiplicity.Never,localVars.inParamFolioIdtoExclude,localVars.inParamOrderMainItemId,cancellationToken);

// DeliveryQtt = GetFolioItemsByOrderMainItemId.List.Current.InvoiceQttSum
result.outParamDeliveryQtt=localVars.queryResGetFolioItemsByOrderMainItemId_outParamList.CurrentRec.ssInvoiceQttSum;
} //close CreateActionActivity using block
} // try

finally {
outParamDeliveryQtt = result.outParamDeliveryQtt;
} // inner-finally
RETURN_STATEMENT:
return outParamDeliveryQtt;
}

public static class FuncActionGetFolioItemAvailableQuantity {

// Query Function "GetFolioItemsByOrderMainItemId" ecH+zBUOREmjhuHQHIbMBw of Action "GetFolioItemAvailableQuantity"
public static async Task<(RL_f09a54b116410a7027db4eb30998df1e,long)> datasetGetFolioItemsByOrderMainItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,long qporFolioItems_OrderMainItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolioItemAvailableQuantity.GetFolioItemsByOrderMainItemId", "ccfec179-0e15-4944-a386-e1d01c86cc07");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolioItemAvailableQuantity.GetFolioItemsByOrderMainItemId", "ccfec179-0e15-4944-a386-e1d01c86cc07", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.J3eCXz+_W0GBnZOyK0E0ZQ/NodesNotShownInESpaceTree.ecH+zBUOREmjhuHQHIbMBw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems4\".\"invoiceqtt\") \"invoiceqttsum\"");
fromBuilder.Append(" FROM ({FolioItems} \"enfolioitems4\" Left JOIN {Folio} \"enfolio17\" ON (\"enfolioitems4\".\"folioid\" = \"enfolio17\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporFolioItems_OrderMainItemId != 0) {
whereBuilder.Append("((\"enfolioitems4\".\"ordermainitemid\" = @qporFolioItems_OrderMainItemId) AND (\"enfolioitems4\".\"ordermainitemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporFolioItems_OrderMainItemId", DbType.Int64, qporFolioItems_OrderMainItemId);
} else {
whereBuilder.Append("(\"enfolioitems4\".\"ordermainitemid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enfolio17\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId);
whereBuilder.Append(") AND (\"enfolio17\".\"foliostatusid\" <> ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("l5OG661dZEe+gAZwnNLhSA"))).ssId);
whereBuilder.Append(")) AND ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio17\".\"id\" <> @qpfoFolio_Id) OR (\"enfolio17\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio17\".\"id\" IS NOT NULL)");
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
RL_f09a54b116410a7027db4eb30998df1e outParamList = new RL_f09a54b116410a7027db4eb30998df1e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolioItemAvailableQuantity.GetFolioItemsByOrderMainItemId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f09a54b116410a7027db4eb30998df1e _tmp = new RL_f09a54b116410a7027db4eb30998df1e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolioItemAvailableQuantity.GetFolioItemsByOrderMainItemId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f09a54b116410a7027db4eb30998df1e)_tmp;
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
