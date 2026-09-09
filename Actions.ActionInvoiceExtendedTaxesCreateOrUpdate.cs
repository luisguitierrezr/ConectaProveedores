namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedTaxesCreateOrUpdate : VarsBag {
public RL_18908f1ccb5f6631454d810d9be77594 inParamInvoiceExtendedTaxList;
public long inParamInvoiceId;
public Actions.lcoInvoiceExtendedTaxCreateOrUpdate resInvoiceExtendedTaxCreateOrUpdate =  new Actions.lcoInvoiceExtendedTaxCreateOrUpdate();
public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount = 0L;

public lcvInvoiceExtendedTaxesCreateOrUpdate(RL_18908f1ccb5f6631454d810d9be77594 inParamInvoiceExtendedTaxList, long inParamInvoiceId) {
this.inParamInvoiceExtendedTaxList = inParamInvoiceExtendedTaxList;
this.inParamInvoiceId = inParamInvoiceId;
}
}
/// <summary>
/// Action <code>InvoiceExtendedTaxesCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedTaxesCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task ActionInvoiceExtendedTaxesCreateOrUpdate(IRequestContext requestContext,RL_18908f1ccb5f6631454d810d9be77594 inParamInvoiceExtendedTaxList,long inParamInvoiceId,CancellationToken cancellationToken) {
lcvInvoiceExtendedTaxesCreateOrUpdate localVars = new lcvInvoiceExtendedTaxesCreateOrUpdate(inParamInvoiceExtendedTaxList, inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedTaxesCreateOrUpdate", "ecab729b-dfbf-4af5-bbc9-5dcbd2a084b3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedTaxesCreateOrUpdate", "ecab729b-dfbf-4af5-bbc9-5dcbd2a084b3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedTaxsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount) = await FuncActionInvoiceExtendedTaxesCreateOrUpdate.datasetGetInvoiceExtendedTaxsByInvoiceId(requestContext,datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords,datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceId,cancellationToken);

// Foreach GetInvoiceExtendedTaxsByInvoiceId.List
localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceExtendedTax
await ExtendedActions.DeleteInvoiceExtendedTax(requestContext,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssId,cancellationToken);

localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.EndIteration();
}

// Foreach InvoiceExtendedTaxList
localVars.inParamInvoiceExtendedTaxList.StartIteration();
try {while (!((localVars.inParamInvoiceExtendedTaxList.Eof))) {
// InvoiceExtendedTaxList.Current.InvoiceId = InvoiceId
localVars.inParamInvoiceExtendedTaxList.CurrentRec.ssInvoiceId = localVars.inParamInvoiceId;
// InvoiceExtendedTaxCreateOrUpdate
localVars.resInvoiceExtendedTaxCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedTaxCreateOrUpdate(requestContext,localVars.inParamInvoiceExtendedTaxList.CurrentRec,cancellationToken);

localVars.inParamInvoiceExtendedTaxList.Advance();
}

} finally {
localVars.inParamInvoiceExtendedTaxList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceExtendedTaxesCreateOrUpdate {

// Query Function "GetInvoiceExtendedTaxsByInvoiceId" 32RAMn_OVESkgufZx9nLzg of Action "InvoiceExtendedTaxesCreateOrUpdate"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceExtendedTaxsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceExtendedTaxesCreateOrUpdate.GetInvoiceExtendedTaxsByInvoiceId", "324064df-ce7f-4454-a482-e7d9c7d9cbce");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceExtendedTaxesCreateOrUpdate.GetInvoiceExtendedTaxsByInvoiceId", "324064df-ce7f-4454-a482-e7d9c7d9cbce", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.m3Kr7L_f9Uq7yV3L0qCEsw/NodesNotShownInESpaceTree.32RAMn_OVESkgufZx9nLzg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedtax7\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax7\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax7\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax7\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax7\".\"invoiceid\" IS NULL)");
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
RL_9404dc36b913809894c7e4e44e8e1dd8 outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceExtendedTaxesCreateOrUpdate.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9404dc36b913809894c7e4e44e8e1dd8 _tmp = new RL_9404dc36b913809894c7e4e44e8e1dd8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceExtendedTaxesCreateOrUpdate.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9404dc36b913809894c7e4e44e8e1dd8)_tmp;
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
