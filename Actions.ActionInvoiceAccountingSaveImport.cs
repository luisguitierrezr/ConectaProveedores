namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingSaveImport : VarsBag {
public RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries;
public long inParami_InvoiceId;
public RL_f5917f1dc841252de92dfa9bbe2bfadf queryResGetInvoiceAccountingEntriesByInvoiceId_outParamList = new RL_f5917f1dc841252de92dfa9bbe2bfadf();
public long queryResGetInvoiceAccountingEntriesByInvoiceId_outParamCount = 0L;

public Actions.lcoInvoiceAccountingEntriesCreate resInvoiceAccountingEntriesCreate =  new Actions.lcoInvoiceAccountingEntriesCreate();
public lcvInvoiceAccountingSaveImport(RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries, long inParami_InvoiceId) {
this.inParami_InvoiceAccountingEntries = inParami_InvoiceAccountingEntries;
this.inParami_InvoiceId = inParami_InvoiceId;
}
}
/// <summary>
/// Action <code>InvoiceAccountingSaveImport</code> that represents the Service Studio action
///  <code>InvoiceAccountingSaveImport</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvoiceAccountingSaveImport(IRequestContext requestContext,RL_0704e14bc1b3305d76f59d709913c287 inParami_InvoiceAccountingEntries,long inParami_InvoiceId,CancellationToken cancellationToken) {
lcvInvoiceAccountingSaveImport localVars = new lcvInvoiceAccountingSaveImport(inParami_InvoiceAccountingEntries, inParami_InvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingSaveImport", "1c04e4a1-95c4-4103-87c2-00f9f1c5fc5c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingSaveImport", "1c04e4a1-95c4-4103-87c2-00f9f1c5fc5c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceAccountingEntriesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingEntriesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceAccountingEntriesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceAccountingEntriesByInvoiceId_outParamList,localVars.queryResGetInvoiceAccountingEntriesByInvoiceId_outParamCount) = await FuncActionInvoiceAccountingSaveImport.datasetGetInvoiceAccountingEntriesByInvoiceId(requestContext,datasetGetInvoiceAccountingEntriesByInvoiceId_maxRecords,datasetGetInvoiceAccountingEntriesByInvoiceId_startIndex,IterationMultiplicity.Single,localVars.inParami_InvoiceId,cancellationToken);

// Foreach GetInvoiceAccountingEntriesByInvoiceId.List
localVars.queryResGetInvoiceAccountingEntriesByInvoiceId_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceAccountingEntriesByInvoiceId_outParamList.Eof))) {
// DeleteInvoiceAccountingEntries
await ExtendedActions.DeleteInvoiceAccountingEntries(requestContext,localVars.queryResGetInvoiceAccountingEntriesByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccountingEntries.ssId,cancellationToken);

localVars.queryResGetInvoiceAccountingEntriesByInvoiceId_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceAccountingEntriesByInvoiceId_outParamList.EndIteration();
}

// Foreach i_InvoiceAccountingEntries
localVars.inParami_InvoiceAccountingEntries.StartIteration();
try {while (!((localVars.inParami_InvoiceAccountingEntries.Eof))) {
// InvoiceAccountingEntriesCreate
localVars.resInvoiceAccountingEntriesCreate.outParamId = await Actions.ActionInvoiceAccountingEntriesCreate(requestContext,localVars.inParami_InvoiceAccountingEntries.CurrentRec,cancellationToken);

localVars.inParami_InvoiceAccountingEntries.Advance();
}

} finally {
localVars.inParami_InvoiceAccountingEntries.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceAccountingSaveImport {

// Query Function "GetInvoiceAccountingEntriesByInvoiceId" +yOgQuhzsU6PcVjOcgyi6Q of Action "InvoiceAccountingSaveImport"
public static async Task<(RL_f5917f1dc841252de92dfa9bbe2bfadf,long)> datasetGetInvoiceAccountingEntriesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingSaveImport.GetInvoiceAccountingEntriesByInvoiceId", "42a023fb-73e8-4eb1-8f71-58ce720ca2e9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingSaveImport.GetInvoiceAccountingEntriesByInvoiceId", "42a023fb-73e8-4eb1-8f71-58ce720ca2e9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.oeQEHMSVA0GHwgD58cX8XA/NodesNotShownInESpaceTree.+yOgQuhzsU6PcVjOcgyi6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccountingentries\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM {InvoiceAccountingEntries} \"eninvoiceaccountingentries\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingentries\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceaccountingentries\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingentries\".\"invoiceid\" IS NULL)");
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
RL_f5917f1dc841252de92dfa9bbe2bfadf outParamList = new RL_f5917f1dc841252de92dfa9bbe2bfadf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingSaveImport.GetInvoiceAccountingEntriesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f5917f1dc841252de92dfa9bbe2bfadf _tmp = new RL_f5917f1dc841252de92dfa9bbe2bfadf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingSaveImport.GetInvoiceAccountingEntriesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f5917f1dc841252de92dfa9bbe2bfadf)_tmp;
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
