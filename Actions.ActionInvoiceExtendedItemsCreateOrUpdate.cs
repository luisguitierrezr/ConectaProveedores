namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedItemsCreateOrUpdate : VarsBag {
public RL_698fc6adea2f9e4df8f68df6dcd5ea9d inParamInvoiceExtendedItemList;
public long inParamInvoiceId;
public string inParamCurrency;
public Actions.lcoInvoiceExtendedItemCreateOrUpdate resInvoiceExtendedItemCreateOrUpdate =  new Actions.lcoInvoiceExtendedItemCreateOrUpdate();
public RL_772f048f6ee632348101044a1e0eef2f queryResGetInvoiceExtendedItemTaxs_outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
public long queryResGetInvoiceExtendedItemTaxs_outParamCount = 0L;

public lcvInvoiceExtendedItemsCreateOrUpdate(RL_698fc6adea2f9e4df8f68df6dcd5ea9d inParamInvoiceExtendedItemList, long inParamInvoiceId, string inParamCurrency) {
this.inParamInvoiceExtendedItemList = inParamInvoiceExtendedItemList;
this.inParamInvoiceId = inParamInvoiceId;
this.inParamCurrency = inParamCurrency;
}
}
/// <summary>
/// Action <code>InvoiceExtendedItemsCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedItemsCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task ActionInvoiceExtendedItemsCreateOrUpdate(IRequestContext requestContext,RL_698fc6adea2f9e4df8f68df6dcd5ea9d inParamInvoiceExtendedItemList,long inParamInvoiceId,string inParamCurrency,CancellationToken cancellationToken) {
lcvInvoiceExtendedItemsCreateOrUpdate localVars = new lcvInvoiceExtendedItemsCreateOrUpdate(inParamInvoiceExtendedItemList, inParamInvoiceId, inParamCurrency);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedItemsCreateOrUpdate", "ffbf51a1-536a-4bfd-b220-26a1b8fee3b7"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedItemsCreateOrUpdate", "ffbf51a1-536a-4bfd-b220-26a1b8fee3b7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedItemTaxs
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedItemTaxs_maxRecords = 0;
int datasetGetInvoiceExtendedItemTaxs_startIndex = 0;(localVars.queryResGetInvoiceExtendedItemTaxs_outParamList,localVars.queryResGetInvoiceExtendedItemTaxs_outParamCount) = await FuncActionInvoiceExtendedItemsCreateOrUpdate.datasetGetInvoiceExtendedItemTaxs(requestContext,datasetGetInvoiceExtendedItemTaxs_maxRecords,datasetGetInvoiceExtendedItemTaxs_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedItemTaxs.List
localVars.queryResGetInvoiceExtendedItemTaxs_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedItemTaxs_outParamList.Eof))) {
// InvoiceExtendedItem_Delete
await Actions.ActionInvoiceExtendedItem_Delete(requestContext,localVars.queryResGetInvoiceExtendedItemTaxs_outParamList.CurrentRec.ssENInvoiceExtendedItem.ssId,cancellationToken);

// DeleteInvoiceExtendedItem
await ExtendedActions.DeleteInvoiceExtendedItem(requestContext,localVars.queryResGetInvoiceExtendedItemTaxs_outParamList.CurrentRec.ssENInvoiceExtendedItem.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedItemTaxs_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedItemTaxs_outParamList.EndIteration();
}

// Foreach InvoiceExtendedItemList
localVars.inParamInvoiceExtendedItemList.StartIteration();
try {while (!((localVars.inParamInvoiceExtendedItemList.Eof))) {
// InvoiceExtendedItemList.Current.InvoiceExtendedItem.InvoiceId = InvoiceId
localVars.inParamInvoiceExtendedItemList.CurrentRec.ssENInvoiceExtendedItem.ssInvoiceId = localVars.inParamInvoiceId;

// InvoiceExtendedItemList.Current.InvoiceExtendedItem.Currency = Currency
localVars.inParamInvoiceExtendedItemList.CurrentRec.ssENInvoiceExtendedItem.ssCurrency = localVars.inParamCurrency;
// InvoiceExtendedItemCreateOrUpdate
localVars.resInvoiceExtendedItemCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedItemCreateOrUpdate(requestContext,localVars.inParamInvoiceExtendedItemList.CurrentRec.ssENInvoiceExtendedItem,cancellationToken);

// InvoiceExtendedItemsTaxCreateOrUpdate
await Actions.ActionInvoiceExtendedItemsTaxCreateOrUpdate(requestContext,localVars.inParamInvoiceExtendedItemList.CurrentRec.ssRLInvoiceExtendedItemTaxList,localVars.resInvoiceExtendedItemCreateOrUpdate.outParamId,cancellationToken);

localVars.inParamInvoiceExtendedItemList.Advance();
}

} finally {
localVars.inParamInvoiceExtendedItemList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceExtendedItemsCreateOrUpdate {

// Query Function "GetInvoiceExtendedItemTaxs" AFSQ7coOEkGYJ9iozSnEJA of Action "InvoiceExtendedItemsCreateOrUpdate"
public static async Task<(RL_772f048f6ee632348101044a1e0eef2f,long)> datasetGetInvoiceExtendedItemTaxs(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceExtendedItemsCreateOrUpdate.GetInvoiceExtendedItemTaxs", "ed905400-0eca-4112-9827-d8a8cd29c424");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceExtendedItemsCreateOrUpdate.GetInvoiceExtendedItemTaxs", "ed905400-0eca-4112-9827-d8a8cd29c424", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.oVG__2pT_UuyICahuP7jtw/NodesNotShownInESpaceTree.AFSQ7coOEkGYJ9iozSnEJA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditem6\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItem} \"eninvoiceextendeditem6\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem6\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendeditem6\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem6\".\"invoiceid\" IS NULL)");
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
RL_772f048f6ee632348101044a1e0eef2f outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceExtendedItemsCreateOrUpdate.GetInvoiceExtendedItemTaxs.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_772f048f6ee632348101044a1e0eef2f _tmp = new RL_772f048f6ee632348101044a1e0eef2f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceExtendedItemsCreateOrUpdate.GetInvoiceExtendedItemTaxs.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_772f048f6ee632348101044a1e0eef2f)_tmp;
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
