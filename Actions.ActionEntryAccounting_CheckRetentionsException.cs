namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccounting_CheckRetentionsException : VarsBag {
public long inParamInvoiceId;
public long inParamOrderAccConceptId;
public RL_5b975f6376260cc87a4dc39e570700ae queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
public long queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamCount = 0L;

public RL_b323e0bdf1fec18079c1034e78738762 queryResGetOrderAccConceptById_outParamList = new RL_b323e0bdf1fec18079c1034e78738762();
public long queryResGetOrderAccConceptById_outParamCount = 0L;

public RL_772f048f6ee632348101044a1e0eef2f queryResGetInvoiceExtendedItemsByInvoiceId_outParamList = new RL_772f048f6ee632348101044a1e0eef2f();
public long queryResGetInvoiceExtendedItemsByInvoiceId_outParamCount = 0L;

public lcvEntryAccounting_CheckRetentionsException(long inParamInvoiceId, long inParamOrderAccConceptId) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamOrderAccConceptId = inParamOrderAccConceptId;
}
}
public class lcoEntryAccounting_CheckRetentionsException : VarsBag {
public int outParamCountRetentions = 0;

public lcoEntryAccounting_CheckRetentionsException() {
}
}
/// <summary>
/// Action <code>EntryAccounting_CheckRetentionsException</code> that represents the Service Studio
///  action <code>EntryAccounting_CheckRetentionsException</code> <p> Description: </p>
/// </summary>
public static async Task<int> ActionEntryAccounting_CheckRetentionsException(IRequestContext requestContext,long inParamInvoiceId,long inParamOrderAccConceptId,CancellationToken cancellationToken) {
int outParamCountRetentions = default;
lcoEntryAccounting_CheckRetentionsException result = new lcoEntryAccounting_CheckRetentionsException();
lcvEntryAccounting_CheckRetentionsException localVars = new lcvEntryAccounting_CheckRetentionsException(inParamInvoiceId, inParamOrderAccConceptId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccounting_CheckRetentionsException", "ab7c8bd1-9205-4f86-84ff-c98ea088e68f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccounting_CheckRetentionsException", "ab7c8bd1-9205-4f86-84ff-c98ea088e68f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderAccConceptById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccConceptById_maxRecords = 1;
if (datasetGetOrderAccConceptById_maxRecords < 1) datasetGetOrderAccConceptById_maxRecords = 1;
int datasetGetOrderAccConceptById_startIndex = 0;(localVars.queryResGetOrderAccConceptById_outParamList,localVars.queryResGetOrderAccConceptById_outParamCount) = await FuncActionEntryAccounting_CheckRetentionsException.datasetGetOrderAccConceptById(requestContext,datasetGetOrderAccConceptById_maxRecords,datasetGetOrderAccConceptById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderAccConceptId,cancellationToken);

// Estim-Finiq-Invoice
if((((((localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==1)||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==4))||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==3))||(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==2)))) {
// Query datasetGetInvoiceExtendedItemsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedItemsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedItemsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamCount) = await FuncActionEntryAccounting_CheckRetentionsException.datasetGetInvoiceExtendedItemsByInvoiceId(requestContext,datasetGetInvoiceExtendedItemsByInvoiceId_maxRecords,datasetGetInvoiceExtendedItemsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedItemsByInvoiceId.List
localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.Eof))) {
// break
if(((result.outParamCountRetentions>=2))) {
goto RETURN_STATEMENT;

} else {
// Query datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords = 1;
if (datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords < 1) datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords = 1;
int datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_startIndex = 0;(localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList,localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamCount) = await FuncActionEntryAccounting_CheckRetentionsException.datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId(requestContext,datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_maxRecords,datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItem.ssId,cancellationToken);

// CountRetentions = If
result.outParamCountRetentions=(((!localVars.queryResGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId_outParamList.Empty)) ? ((result.outParamCountRetentions+1)) : (result.outParamCountRetentions));
}

localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedItemsByInvoiceId_outParamList.EndIteration();
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamCountRetentions = result.outParamCountRetentions;
} // inner-finally
RETURN_STATEMENT:
return outParamCountRetentions;
}

public static class FuncActionEntryAccounting_CheckRetentionsException {

// Query Function "GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId" O+F4EQ_QD0qzmSvr5MhGng of Action "EntryAccounting_CheckRetentionsException"
public static async Task<(RL_5b975f6376260cc87a4dc39e570700ae,long)> datasetGetInvoiceExtendedItemTaxsByInvoiceExtendedItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId", "1178e13b-d00f-4a0f-b399-2bebe4c8469e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId", "1178e13b-d00f-4a0f-b399-2bebe4c8469e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.0Yt8qwWShk+E_8mOoIjmjw/NodesNotShownInESpaceTree.O+F4EQ_QD0qzmSvr5MhGng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax3\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItemId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditemtax3\".\"invoiceextendeditemid\" = @qpinInvoiceExtendedItemId) AND (\"eninvoiceextendeditemtax3\".\"invoiceextendeditemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItemId", DbType.Int64, qpinInvoiceExtendedItemId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditemtax3\".\"invoiceextendeditemid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendeditemtax3\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId);
whereBuilder.Append(")");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemTaxsByInvoiceExtendedItemId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_fba480f5c1b92eb8b15d33020b0023b5> datasetGetOrderAccConceptByIdReadDbAsync(RC_fba480f5c1b92eb8b15d33020b0023b5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAdvancePaymentType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccConceptById" ZOdEdBjeP0CQcoUu5pK2tA of Action "EntryAccounting_CheckRetentionsException"
public static async Task<(RL_b323e0bdf1fec18079c1034e78738762,long)> datasetGetOrderAccConceptById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConcepts_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CheckRetentionsException.GetOrderAccConceptById", "7444e764-de18-403f-9072-852ee692b6b4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CheckRetentionsException.GetOrderAccConceptById", "7444e764-de18-403f-9072-852ee692b6b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.0Yt8qwWShk+E_8mOoIjmjw/NodesNotShownInESpaceTree.ZOdEdBjeP0CQcoUu5pK2tA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enorderaccconcepts6\".\"accountingdatatypeid\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({OrderAccConcepts} \"enorderaccconcepts6\" Left JOIN {PaymentTerms} \"enpaymentterms10\" ON (\"enorderaccconcepts6\".\"paymenttermid\" = \"enpaymentterms10\".\"id\"))  Left JOIN {AdvancePaymentType} \"enadvancepaymenttype1\" ON (\"enorderaccconcepts6\".\"advancepaymenttypeid\" = \"enadvancepaymenttype1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccConcepts_Id != 0) {
whereBuilder.Append("((\"enorderaccconcepts6\".\"id\" = @qporOrderAccConcepts_Id) AND (\"enorderaccconcepts6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConcepts_Id", DbType.Int64, qporOrderAccConcepts_Id);
} else {
whereBuilder.Append("(\"enorderaccconcepts6\".\"id\" IS NULL)");
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
RL_b323e0bdf1fec18079c1034e78738762 outParamList = new RL_b323e0bdf1fec18079c1034e78738762();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CheckRetentionsException.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b323e0bdf1fec18079c1034e78738762 _tmp = new RL_b323e0bdf1fec18079c1034e78738762();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CheckRetentionsException.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b323e0bdf1fec18079c1034e78738762)_tmp;
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

// Query Function "GetInvoiceExtendedItemsByInvoiceId" NivBqu2ankebXHEGshfZRw of Action "EntryAccounting_CheckRetentionsException"
public static async Task<(RL_772f048f6ee632348101044a1e0eef2f,long)> datasetGetInvoiceExtendedItemsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemsByInvoiceId", "aac12b36-9aed-479e-9b5c-7106b217d947");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemsByInvoiceId", "aac12b36-9aed-479e-9b5c-7106b217d947", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.0Yt8qwWShk+E_8mOoIjmjw/NodesNotShownInESpaceTree.NivBqu2ankebXHEGshfZRw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditem\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItem} \"eninvoiceextendeditem\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendeditem\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CheckRetentionsException.GetInvoiceExtendedItemsByInvoiceId.List", cancellationToken: cancellationToken);
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
