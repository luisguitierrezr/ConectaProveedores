namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallBlocked : VarsBag {
public RL_c1ecbb923fb25bd526ed138d8050d95e queryResGetFolioItemsByFolioId_outParamList = new RL_c1ecbb923fb25bd526ed138d8050d95e();
public long queryResGetFolioItemsByFolioId_outParamCount = 0L;

public Actions.lcoEntry_CallService0Blocks resEntry_CallService0Blocks =  new Actions.lcoEntry_CallService0Blocks();
public Actions.lcoCallEntryAccountingFolio resCallEntryAccountingFolio =  new Actions.lcoCallEntryAccountingFolio();
public RL_4f8b259bdd04db22be8fb771f1ad1d4f queryResGetFoliosPendingEntry_outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
public long queryResGetFoliosPendingEntry_outParamCount = 0L;

public lcvEntry_CallBlocked() {
}
}
/// <summary>
/// Action <code>Entry_CallBlocked</code> that represents the Service Studio action
///  <code>Entry_CallBlocked</code> <p> Description: </p>
/// </summary>
public static async Task ActionEntry_CallBlocked(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvEntry_CallBlocked localVars = new lcvEntry_CallBlocked();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallBlocked", "f79caa92-ee25-4d88-ad88-a381173e42cc"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallBlocked", "f79caa92-ee25-4d88-ad88-a381173e42cc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetFoliosPendingEntry
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosPendingEntry_maxRecords = 0;
int datasetGetFoliosPendingEntry_startIndex = 0;(localVars.queryResGetFoliosPendingEntry_outParamList,localVars.queryResGetFoliosPendingEntry_outParamCount) = await FuncActionEntry_CallBlocked.datasetGetFoliosPendingEntry(requestContext,datasetGetFoliosPendingEntry_maxRecords,datasetGetFoliosPendingEntry_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetFoliosPendingEntry.List
localVars.queryResGetFoliosPendingEntry_outParamList.StartIteration();
try {while (!((localVars.queryResGetFoliosPendingEntry_outParamList.Eof))) {
// Query datasetGetFolioItemsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByFolioId_maxRecords = 1;
if (datasetGetFolioItemsByFolioId_maxRecords < 1) datasetGetFolioItemsByFolioId_maxRecords = 1;
int datasetGetFolioItemsByFolioId_startIndex = 0;(localVars.queryResGetFolioItemsByFolioId_outParamList,localVars.queryResGetFolioItemsByFolioId_outParamCount) = await FuncActionEntry_CallBlocked.datasetGetFolioItemsByFolioId(requestContext,datasetGetFolioItemsByFolioId_maxRecords,datasetGetFolioItemsByFolioId_startIndex,IterationMultiplicity.Never,localVars.queryResGetFoliosPendingEntry_outParamList.CurrentRec.ssENFolio.ssId,cancellationToken);

// Entry_CallService0Blocks
localVars.resEntry_CallService0Blocks.outParamIsBlocked = await Actions.ActionEntry_CallService0Blocks(requestContext,localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolioItems.ssInputationCode,localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENOrderMainItem.ssGLAccountId,6,cancellationToken);

// block?
if((!(localVars.resEntry_CallService0Blocks.outParamIsBlocked))) {
// CallEntryAccountingFolio
localVars.resCallEntryAccountingFolio.outParamo_Output = await Actions.ActionCallEntryAccountingFolio(requestContext,localVars.queryResGetFoliosPendingEntry_outParamList.CurrentRec.ssENFolio,false,6,cancellationToken);

}

localVars.queryResGetFoliosPendingEntry_outParamList.Advance();
}

} finally {
localVars.queryResGetFoliosPendingEntry_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionEntry_CallBlocked {

private static async Task<RC_9e12e346359269058e01a3334f3aaf87> datasetGetFolioItemsByFolioIdReadDbAsync(RC_9e12e346359269058e01a3334f3aaf87 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" HdtGD9y2oUSgGJ4xUNjnLw of Action "Entry_CallBlocked"
public static async Task<(RL_c1ecbb923fb25bd526ed138d8050d95e,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Entry_CallBlocked.GetFolioItemsByFolioId", "0f46db1d-b6dc-44a1-a018-9e3150d8e72f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Entry_CallBlocked.GetFolioItemsByFolioId", "0f46db1d-b6dc-44a1-a018-9e3150d8e72f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.kqqc9yXuiE2tiKOBFz5CzA/NodesNotShownInESpaceTree.HdtGD9y2oUSgGJ4xUNjnLw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enfolioitems9\".\"inputationcode\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enordermainitem15\".\"glaccountid\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68");
fromBuilder.Append(" FROM ({FolioItems} \"enfolioitems9\" Left JOIN {OrderMainItem} \"enordermainitem15\" ON (\"enfolioitems9\".\"ordermainitemid\" = \"enordermainitem15\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems9\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems9\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems9\".\"folioid\" IS NULL)");
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
RL_c1ecbb923fb25bd526ed138d8050d95e outParamList = new RL_c1ecbb923fb25bd526ed138d8050d95e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Entry_CallBlocked.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c1ecbb923fb25bd526ed138d8050d95e _tmp = new RL_c1ecbb923fb25bd526ed138d8050d95e();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Entry_CallBlocked.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c1ecbb923fb25bd526ed138d8050d95e)_tmp;
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

// Query Function "GetFoliosPendingEntry" 9SMb6lo5ckCO7PJHiWZtNg of Action "Entry_CallBlocked"
public static async Task<(RL_4f8b259bdd04db22be8fb771f1ad1d4f,long)> datasetGetFoliosPendingEntry(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Entry_CallBlocked.GetFoliosPendingEntry", "ea1b23f5-395a-4072-8eec-f24789666d36");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Entry_CallBlocked.GetFoliosPendingEntry", "ea1b23f5-395a-4072-8eec-f24789666d36", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.kqqc9yXuiE2tiKOBFz5CzA/NodesNotShownInESpaceTree.9SMb6lo5ckCO7PJHiWZtNg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio57\".\"id\" o0, \"enfolio57\".\"isdraft\" o1, \"enfolio57\".\"folionumber\" o2, \"enfolio57\".\"canproveedorcancel\" o3, \"enfolio57\".\"orderid\" o4, \"enfolio57\".\"supplierid\" o5, \"enfolio57\".\"companyid\" o6, \"enfolio57\".\"foliostatusid\" o7, trim_scale(\"enfolio57\".\"totalamount\"::numeric) o8, trim_scale(\"enfolio57\".\"totaliva_amount\"::numeric) o9, trim_scale(\"enfolio57\".\"partialamount\"::numeric) o10, \"enfolio57\".\"currencyid\" o11, \"enfolio57\".\"firstapproveruserid\" o12, \"enfolio57\".\"approvalprocesstypeid\" o13, \"enfolio57\".\"sapentryerror\" o14, \"enfolio57\".\"createdby\" o15, \"enfolio57\".\"createdon\" o16, \"enfolio57\".\"updatedby\" o17, \"enfolio57\".\"updatedon\" o18, \"enfolio57\".\"minuteselected\" o19");
fromBuilder.Append(" FROM {Folio} \"enfolio57\"");
whereBuilder.Append(" WHERE (\"enfolio57\".\"foliostatusid\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cKaejollq0a9gDFyfLxCKg"))).ssId);
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
RL_4f8b259bdd04db22be8fb771f1ad1d4f outParamList = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Entry_CallBlocked.GetFoliosPendingEntry.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4f8b259bdd04db22be8fb771f1ad1d4f _tmp = new RL_4f8b259bdd04db22be8fb771f1ad1d4f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Entry_CallBlocked.GetFoliosPendingEntry.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4f8b259bdd04db22be8fb771f1ad1d4f)_tmp;
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
