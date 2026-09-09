namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccounting_GetRetentions : VarsBag {
public long inParamInvoiceId;
/// <summary>
/// Variable <code>Count</code> that represents the Service Studio Integer <code>Count</code>
///  <p>Description: </p>
/// </summary>
public int varLcCount = 0;

public RL_772f048f6ee632348101044a1e0eef2f queryResGetInvoiceExtendedItemsByInvoiceId_outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
public long queryResGetInvoiceExtendedItemsByInvoiceId_outParamCount = 0L;

public Actions.lcoInvoiceTaxesRetentionRules_ByItem resInvoiceTaxesRetentionRules_ByItem =  new Actions.lcoInvoiceTaxesRetentionRules_ByItem();
public lcvEntryAccounting_GetRetentions(long inParamInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoEntryAccounting_GetRetentions : VarsBag {
public RL_f2d9c802fb1adc89fda1ad392c027309 outParamTI_WXD_InList = new RL_f2d9c802fb1adc89fda1ad392c027309();

public lcoEntryAccounting_GetRetentions() {
}
}
/// <summary>
/// Action <code>EntryAccounting_GetRetentions</code> that represents the Service Studio action
///  <code>EntryAccounting_GetRetentions</code> <p> Description: </p>
/// </summary>
public static async Task<RL_f2d9c802fb1adc89fda1ad392c027309> ActionEntryAccounting_GetRetentions(IRequestContext requestContext,long inParamInvoiceId,CancellationToken cancellationToken) {
RL_f2d9c802fb1adc89fda1ad392c027309 outParamTI_WXD_InList = default;
lcoEntryAccounting_GetRetentions result = new lcoEntryAccounting_GetRetentions();
lcvEntryAccounting_GetRetentions localVars = new lcvEntryAccounting_GetRetentions(inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccounting_GetRetentions", "fcce578c-7b53-432b-b281-22bedb00115e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccounting_GetRetentions", "fcce578c-7b53-432b-b281-22bedb00115e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedItemsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedItemsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedItemsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamCount) = await FuncActionEntryAccounting_GetRetentions.datasetGetInvoiceExtendedItemsByInvoiceId(requestContext,datasetGetInvoiceExtendedItemsByInvoiceId_maxRecords,datasetGetInvoiceExtendedItemsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedItemsByInvoiceId.List
localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.Eof))) {
// Count = Count + 1
localVars.varLcCount=(localVars.varLcCount+1);
// InvoiceTaxesRetentionRules_ByItem
(localVars.resInvoiceTaxesRetentionRules_ByItem.outParamTI_WXD_InList,localVars.resInvoiceTaxesRetentionRules_ByItem.outParamIsToCancel) = await Actions.ActionInvoiceTaxesRetentionRules_ByItem(requestContext,localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItem.ssId,cancellationToken);

// Foreach InvoiceTaxesRetentionRules_ByItem.TI_WXD_InList
localVars.resInvoiceTaxesRetentionRules_ByItem.outParamTI_WXD_InList.StartIteration();
try {while (!((localVars.resInvoiceTaxesRetentionRules_ByItem.outParamTI_WXD_InList.Eof))) {
// set split_key
// InvoiceTaxesRetentionRules_ByItem.TI_WXD_InList.Current.SPLIT_KEY = Count
localVars.resInvoiceTaxesRetentionRules_ByItem.outParamTI_WXD_InList.CurrentRec.ssSPLIT_KEY = localVars.varLcCount;
// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,localVars.resInvoiceTaxesRetentionRules_ByItem.outParamTI_WXD_InList.CurrentRec,cancellationToken);

localVars.resInvoiceTaxesRetentionRules_ByItem.outParamTI_WXD_InList.Advance();
}

} finally {
localVars.resInvoiceTaxesRetentionRules_ByItem.outParamTI_WXD_InList.EndIteration();
}

localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamTI_WXD_InList = result.outParamTI_WXD_InList;
} // inner-finally
RETURN_STATEMENT:
return outParamTI_WXD_InList;
}

public static class FuncActionEntryAccounting_GetRetentions {

// Query Function "GetInvoiceExtendedItemsByInvoiceId" f5p_eF_rnEGYVcgkiKue5Q of Action "EntryAccounting_GetRetentions"
public static async Task<(RL_772f048f6ee632348101044a1e0eef2f,long)> datasetGetInvoiceExtendedItemsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_GetRetentions.GetInvoiceExtendedItemsByInvoiceId", "787f9a7f-eb5f-419c-9855-c82488ab9ee5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_GetRetentions.GetInvoiceExtendedItemsByInvoiceId", "787f9a7f-eb5f-419c-9855-c82488ab9ee5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.jFfO_FN7K0OygSK+2wARXg/NodesNotShownInESpaceTree.f5p_eF_rnEGYVcgkiKue5Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditem5\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItem} \"eninvoiceextendeditem5\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem5\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendeditem5\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem5\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_GetRetentions.GetInvoiceExtendedItemsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_GetRetentions.GetInvoiceExtendedItemsByInvoiceId.List", cancellationToken: cancellationToken);
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
