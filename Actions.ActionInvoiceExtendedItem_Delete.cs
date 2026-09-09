namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedItem_Delete : VarsBag {
public long inParamInvoiceExtendedItemId;
public RL_5b975f6376260cc87a4dc39e570700ae queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
public long queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamCount = 0L;

public lcvInvoiceExtendedItem_Delete(long inParamInvoiceExtendedItemId) {
this.inParamInvoiceExtendedItemId = inParamInvoiceExtendedItemId;
}
}
/// <summary>
/// Action <code>InvoiceExtendedItem_Delete</code> that represents the Service Studio action
///  <code>InvoiceExtendedItem_Delete</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvoiceExtendedItem_Delete(IRequestContext requestContext,long inParamInvoiceExtendedItemId,CancellationToken cancellationToken) {
lcvInvoiceExtendedItem_Delete localVars = new lcvInvoiceExtendedItem_Delete(inParamInvoiceExtendedItemId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedItem_Delete", "a3d7f02c-9f92-414b-a837-786ecdb41218"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedItem_Delete", "a3d7f02c-9f92-414b-a837-786ecdb41218", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords = 0;
int datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_startIndex = 0;(localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList,localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamCount) = await FuncActionInvoiceExtendedItem_Delete.datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId(requestContext,datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords,datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceExtendedItemId,cancellationToken);

// Foreach GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List
localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.Eof))) {
// DeleteInvoiceExtendedItemTax
await ExtendedActions.DeleteInvoiceExtendedItemTax(requestContext,localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceExtendedItem_Delete {

// Query Function "GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId" M6qZaVvEwEuJk0K9Au6ttA of Action "InvoiceExtendedItem_Delete"
public static async Task<(RL_5b975f6376260cc87a4dc39e570700ae,long)> datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceExtendedItem_Delete.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId", "6999aa33-c45b-4bc0-8993-42bd02eeadb4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceExtendedItem_Delete.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId", "6999aa33-c45b-4bc0-8993-42bd02eeadb4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.LPDXo5KfS0GoN3huzbQSGA/NodesNotShownInESpaceTree.M6qZaVvEwEuJk0K9Au6ttA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditemtax2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax2\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItemId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditemtax2\".\"invoiceextendeditemid\" = @qpinInvoiceExtendedItemId) AND (\"eninvoiceextendeditemtax2\".\"invoiceextendeditemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItemId", DbType.Int64, qpinInvoiceExtendedItemId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditemtax2\".\"invoiceextendeditemid\" IS NULL)");
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
RL_5b975f6376260cc87a4dc39e570700ae outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceExtendedItem_Delete.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5b975f6376260cc87a4dc39e570700ae _tmp = new RL_5b975f6376260cc87a4dc39e570700ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceExtendedItem_Delete.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5b975f6376260cc87a4dc39e570700ae)_tmp;
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
