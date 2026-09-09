namespace ssConectaProveedores;

public partial class Actions {
public class lcvClearInvoiceApproval : VarsBag {
public long inParami_InvoiceId;
public RL_e8a2bfdbad62aa404e80d55d80faa387 queryResGetInvoiceById_outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvClearInvoiceApproval(long inParami_InvoiceId) {
this.inParami_InvoiceId = inParami_InvoiceId;
}
}
/// <summary>
/// Action <code>ClearInvoiceApproval</code> that represents the Service Studio action
///  <code>ClearInvoiceApproval</code> <p> Description: </p>
/// </summary>
public static async Task ActionClearInvoiceApproval(IRequestContext requestContext,long inParami_InvoiceId,CancellationToken cancellationToken) {
lcvClearInvoiceApproval localVars = new lcvClearInvoiceApproval(inParami_InvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ClearInvoiceApproval", "d345a2c8-3146-4b34-aacc-6fe72682d5d6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ClearInvoiceApproval", "d345a2c8-3146-4b34-aacc-6fe72682d5d6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 0;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionClearInvoiceApproval.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Single,localVars.inParami_InvoiceId,cancellationToken);

// Foreach GetInvoiceById.List
localVars.queryResGetInvoiceById_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceById_outParamList.Eof))) {
// DeleteInvoiceApprovalLevel
await ExtendedActions.DeleteInvoiceApprovalLevel(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssId,cancellationToken);

localVars.queryResGetInvoiceById_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceById_outParamList.EndIteration();
}

if(((!(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApproval.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// DeleteInvoiceApproval
await ExtendedActions.DeleteInvoiceApproval(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceApproval.ssId,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionClearInvoiceApproval {

private static async Task<RC_bc68025e789d69992aef27aed0947c65> datasetGetInvoiceByIdReadDbAsync(RC_bc68025e789d69992aef27aed0947c65 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" Kitz4S9JP0Sxk353mmYRqg of Action "ClearInvoiceApproval"
public static async Task<(RL_e8a2bfdbad62aa404e80d55d80faa387,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearInvoiceApproval.GetInvoiceById", "e1732b2a-492f-443f-b193-7e779a6611aa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearInvoiceApproval.GetInvoiceById", "e1732b2a-492f-443f-b193-7e779a6611aa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.yKJF00YxNEuqzG_nJoLV1g/NodesNotShownInESpaceTree.Kitz4S9JP0Sxk353mmYRqg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceapproval21\".\"id\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceapprovallevel22\".\"id\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice65\" Left JOIN {InvoiceApproval} \"eninvoiceapproval21\" ON (\"eninvoice65\".\"id\" = \"eninvoiceapproval21\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel22\" ON (\"eninvoiceapproval21\".\"id\" = \"eninvoiceapprovallevel22\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice65\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice65\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice65\".\"id\" IS NULL)");
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
RL_e8a2bfdbad62aa404e80d55d80faa387 outParamList = new RL_e8a2bfdbad62aa404e80d55d80faa387();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearInvoiceApproval.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8a2bfdbad62aa404e80d55d80faa387 _tmp = new RL_e8a2bfdbad62aa404e80d55d80faa387();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearInvoiceApproval.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8a2bfdbad62aa404e80d55d80faa387)_tmp;
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
