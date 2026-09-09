namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedMoreChargesCreateOrUpdate : VarsBag {
public RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParamInvoiceExtendedMoreCharges;
public long inParamInvoiceId;
public Actions.lcoInvoiceExtendedMoreChargeCreateOrUpdate resInvoiceExtendedMoreChargeCreateOrUpdate =  new Actions.lcoInvoiceExtendedMoreChargeCreateOrUpdate();
public RL_ef088826c46241557fb82e7c7f21d334 queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList = new RL_ef088826c46241557fb82e7c7f21d334();
public long queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount = 0L;

public lcvInvoiceExtendedMoreChargesCreateOrUpdate(RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParamInvoiceExtendedMoreCharges, long inParamInvoiceId) {
this.inParamInvoiceExtendedMoreCharges = inParamInvoiceExtendedMoreCharges;
this.inParamInvoiceId = inParamInvoiceId;
}
}
/// <summary>
/// Action <code>InvoiceExtendedMoreChargesCreateOrUpdate</code> that represents the Service Studio
///  action <code>InvoiceExtendedMoreChargesCreateOrUpdate</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task ActionInvoiceExtendedMoreChargesCreateOrUpdate(IRequestContext requestContext,RL_4d4dc9b85c4a7d6bf03b676c2530ea4f inParamInvoiceExtendedMoreCharges,long inParamInvoiceId,CancellationToken cancellationToken) {
lcvInvoiceExtendedMoreChargesCreateOrUpdate localVars = new lcvInvoiceExtendedMoreChargesCreateOrUpdate(inParamInvoiceExtendedMoreCharges, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedMoreChargesCreateOrUpdate", "95fb31b1-2fbb-490e-a813-1f55d12dd862"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedMoreChargesCreateOrUpdate", "95fb31b1-2fbb-490e-a813-1f55d12dd862", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedMoreChargesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount) = await FuncActionInvoiceExtendedMoreChargesCreateOrUpdate.datasetGetInvoiceExtendedMoreChargesByInvoiceId(requestContext,datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords,datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedMoreChargesByInvoiceId.List
localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceExtendedMoreCharges
await ExtendedActions.DeleteInvoiceExtendedMoreCharges(requestContext,localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedMoreCharges.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.EndIteration();
}

// Foreach InvoiceExtendedMoreCharges
localVars.inParamInvoiceExtendedMoreCharges.StartIteration();
try {while (!((localVars.inParamInvoiceExtendedMoreCharges.Eof))) {
// InvoiceExtendedMoreCharges.Current.InvoiceId = InvoiceId
localVars.inParamInvoiceExtendedMoreCharges.CurrentRec.ssInvoiceId = localVars.inParamInvoiceId;
// InvoiceExtendedMoreChargeCreateOrUpdate
localVars.resInvoiceExtendedMoreChargeCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedMoreChargeCreateOrUpdate(requestContext,localVars.inParamInvoiceExtendedMoreCharges.CurrentRec,cancellationToken);

localVars.inParamInvoiceExtendedMoreCharges.Advance();
}

} finally {
localVars.inParamInvoiceExtendedMoreCharges.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceExtendedMoreChargesCreateOrUpdate {

// Query Function "GetInvoiceExtendedMoreChargesByInvoiceId" x5nos1N6tEaWO6Vndt9nFw of Action "InvoiceExtendedMoreChargesCreateOrUpdate"
public static async Task<(RL_ef088826c46241557fb82e7c7f21d334,long)> datasetGetInvoiceExtendedMoreChargesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceExtendedMoreChargesCreateOrUpdate.GetInvoiceExtendedMoreChargesByInvoiceId", "b3e899c7-7a53-46b4-963b-a56776df6717");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceExtendedMoreChargesCreateOrUpdate.GetInvoiceExtendedMoreChargesByInvoiceId", "b3e899c7-7a53-46b4-963b-a56776df6717", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.sTH7lbsvDkmoEx9V0S3YYg/NodesNotShownInESpaceTree.x5nos1N6tEaWO6Vndt9nFw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedmorecharges2\".\"id\" o0, NULL o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges2\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges2\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges2\".\"invoiceid\" IS NULL)");
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
RL_ef088826c46241557fb82e7c7f21d334 outParamList = new RL_ef088826c46241557fb82e7c7f21d334();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceExtendedMoreChargesCreateOrUpdate.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ef088826c46241557fb82e7c7f21d334 _tmp = new RL_ef088826c46241557fb82e7c7f21d334();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceExtendedMoreChargesCreateOrUpdate.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ef088826c46241557fb82e7c7f21d334)_tmp;
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
