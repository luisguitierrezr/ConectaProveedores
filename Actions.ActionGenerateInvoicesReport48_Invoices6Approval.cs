namespace ssConectaProveedores;

public partial class Actions {
public class lcvGenerateInvoicesReport48_Invoices6Approval : VarsBag {
public long inParami_InvoiceId;
public RL_b4ddf0f42ca95f85f71ab38d7b039957 resListFilterAreaAprobadora_outParamFilteredList = new RL_b4ddf0f42ca95f85f71ab38d7b039957();

public RL_b4ddf0f42ca95f85f71ab38d7b039957 queryResGetInvoiceApprovalLevels_outParamList = new RL_b4ddf0f42ca95f85f71ab38d7b039957();
public long queryResGetInvoiceApprovalLevels_outParamCount = 0L;

public RL_540f5613fbde7a506fffd29a691298e6 queryResGetFirstAccountingInvoiceApprovalLevelApproved_outParamList = new RL_540f5613fbde7a506fffd29a691298e6();
public long queryResGetFirstAccountingInvoiceApprovalLevelApproved_outParamCount = 0L;

public lcvGenerateInvoicesReport48_Invoices6Approval(long inParami_InvoiceId) {
this.inParami_InvoiceId = inParami_InvoiceId;
}
}
public class lcoGenerateInvoicesReport48_Invoices6Approval : VarsBag {
public ST_39962f5b1f9edd4db48277d9dcced378Structure outParamo_InvoicesReport48_Approval = new ST_39962f5b1f9edd4db48277d9dcced378Structure();

public lcoGenerateInvoicesReport48_Invoices6Approval() {
}
}
/// <summary>
/// Action <code>GenerateInvoicesReport48_Invoices6Approval</code> that represents the Service Studio
///  action <code>GenerateInvoicesReport48_Invoices6Approval</code> <p> Description: </p>
/// </summary>
public static async Task<ST_39962f5b1f9edd4db48277d9dcced378Structure> ActionGenerateInvoicesReport48_Invoices6Approval(IRequestContext requestContext,long inParami_InvoiceId,CancellationToken cancellationToken) {
ST_39962f5b1f9edd4db48277d9dcced378Structure outParamo_InvoicesReport48_Approval = default;
lcoGenerateInvoicesReport48_Invoices6Approval result = new lcoGenerateInvoicesReport48_Invoices6Approval();
lcvGenerateInvoicesReport48_Invoices6Approval localVars = new lcvGenerateInvoicesReport48_Invoices6Approval(inParami_InvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GenerateInvoicesReport48_Invoices6Approval", "62e821ac-d335-4579-960d-6eb605004687"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GenerateInvoicesReport48_Invoices6Approval", "62e821ac-d335-4579-960d-6eb605004687", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceApprovalLevels
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalLevels_maxRecords = 0;
int datasetGetInvoiceApprovalLevels_startIndex = 0;(localVars.queryResGetInvoiceApprovalLevels_outParamList,localVars.queryResGetInvoiceApprovalLevels_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices6Approval.datasetGetInvoiceApprovalLevels(requestContext,datasetGetInvoiceApprovalLevels_maxRecords,datasetGetInvoiceApprovalLevels_startIndex,IterationMultiplicity.Multiple,localVars.inParami_InvoiceId,cancellationToken);

// Foreach GetInvoiceApprovalLevels.List
localVars.queryResGetInvoiceApprovalLevels_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceApprovalLevels_outParamList.Eof))) {
// o_InvoicesReport48_Approval.ApprovingUsers = o_InvoicesReport48_Approval.ApprovingUsers + If + GetInvoiceApprovalLevels.List.Current.User.Name
result.outParamo_InvoicesReport48_Approval.ssApprovingUsers = ((result.outParamo_InvoicesReport48_Approval.ssApprovingUsers+(((result.outParamo_InvoicesReport48_Approval.ssApprovingUsers!="")) ? (",") : ("")))+localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENUser.ssName);
localVars.queryResGetInvoiceApprovalLevels_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceApprovalLevels_outParamList.EndIteration();
}

// ListFilterAreaAprobadora
localVars.resListFilterAreaAprobadora_outParamFilteredList = (((RL_b4ddf0f42ca95f85f71ab38d7b039957)await  localVars.queryResGetInvoiceApprovalLevels_outParamList.FilterAsync(async (p, cancellationToken) => (!p.ssENInvoiceApprovalLevel.ssIsAccounting), cancellationToken)));

// Query datasetGetFirstAccountingInvoiceApprovalLevelApproved
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFirstAccountingInvoiceApprovalLevelApproved_maxRecords = 1;
if (datasetGetFirstAccountingInvoiceApprovalLevelApproved_maxRecords < 1) datasetGetFirstAccountingInvoiceApprovalLevelApproved_maxRecords = 1;
int datasetGetFirstAccountingInvoiceApprovalLevelApproved_startIndex = 0;(localVars.queryResGetFirstAccountingInvoiceApprovalLevelApproved_outParamList,localVars.queryResGetFirstAccountingInvoiceApprovalLevelApproved_outParamCount) = await FuncActionGenerateInvoicesReport48_Invoices6Approval.datasetGetFirstAccountingInvoiceApprovalLevelApproved(requestContext,datasetGetFirstAccountingInvoiceApprovalLevelApproved_maxRecords,datasetGetFirstAccountingInvoiceApprovalLevelApproved_startIndex,IterationMultiplicity.Never,localVars.inParami_InvoiceId,cancellationToken);

// o_InvoicesReport48_Approval.InvoiceApprovalDate = GetInvoiceApprovalLevels.List.Current.InvoiceApproval.FinishedOn
result.outParamo_InvoicesReport48_Approval.ssInvoiceApprovalDate = BuiltInFunction.DateTimeToDate(localVars.queryResGetInvoiceApprovalLevels_outParamList.CurrentRec.ssENInvoiceApproval.ssFinishedOn);

// o_InvoicesReport48_Approval.ApprovalArea = ListFilterAreaAprobadora.FilteredList.Current.Department.Name + " 
//" + ListFilterAreaAprobadora.FilteredList.Current.User.Name
result.outParamo_InvoicesReport48_Approval.ssApprovalArea = ((localVars.resListFilterAreaAprobadora_outParamFilteredList.CurrentRec.ssENDepartment.ssName+" \r\n")+localVars.resListFilterAreaAprobadora_outParamFilteredList.CurrentRec.ssENUser.ssName);

// o_InvoicesReport48_Approval.AccountingUser = GetFirstAccountingInvoiceApprovalLevelApproved.List.Current.User.Name
result.outParamo_InvoicesReport48_Approval.ssAccountingUser = localVars.queryResGetFirstAccountingInvoiceApprovalLevelApproved_outParamList.CurrentRec.ssENUser.ssName;
} //close CreateActionActivity using block
} // try

finally {
outParamo_InvoicesReport48_Approval = result.outParamo_InvoicesReport48_Approval;
} // inner-finally
RETURN_STATEMENT:
return outParamo_InvoicesReport48_Approval;
}

public static class FuncActionGenerateInvoicesReport48_Invoices6Approval {

private static async Task<RC_7e7b9dfb6acc38af212baa91da8cd5bf> datasetGetInvoiceApprovalLevelsReadDbAsync(RC_7e7b9dfb6acc38af212baa91da8cd5bf rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDepartment.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalLevels" cPjjQoBLwkiM9PQiIqUhIg of Action "GenerateInvoicesReport48_Invoices6Approval"
public static async Task<(RL_b4ddf0f42ca95f85f71ab38d7b039957,long)> datasetGetInvoiceApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices6Approval.GetInvoiceApprovalLevels", "42e3f870-4b80-48c2-8cf4-f42222a52122");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices6Approval.GetInvoiceApprovalLevels", "42e3f870-4b80-48c2-8cf4-f42222a52122", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /UserActions.rCHoYjXTeUWWDW62BQBGhw/NodesNotShownInESpaceTree.cPjjQoBLwkiM9PQiIqUhIg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"endepartment4\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"eninvoiceapproval7\".\"finishedon\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"eninvoiceapprovallevel8\".\"isaccounting\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"enuser61\".\"name\" o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66");
fromBuilder.Append(" FROM (((({InvoiceApprovalLevel} \"eninvoiceapprovallevel8\" Left JOIN {User} \"enuser61\" ON (\"eninvoiceapprovallevel8\".\"assignedto\" = \"enuser61\".\"id\"))  Left JOIN {InvoiceApproval} \"eninvoiceapproval7\" ON (\"eninvoiceapprovallevel8\".\"invoiceapprovalid\" = \"eninvoiceapproval7\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal38\" ON (\"enuser61\".\"id\" = \"enuser_extended_internal38\".\"id\"))  Left JOIN {Department} \"endepartment4\" ON (\"enuser_extended_internal38\".\"departmentid\" = \"endepartment4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval7\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval7\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval7\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel8\".\"levelnumber\" ASC ");
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
RL_b4ddf0f42ca95f85f71ab38d7b039957 outParamList = new RL_b4ddf0f42ca95f85f71ab38d7b039957();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices6Approval.GetInvoiceApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b4ddf0f42ca95f85f71ab38d7b039957 _tmp = new RL_b4ddf0f42ca95f85f71ab38d7b039957();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices6Approval.GetInvoiceApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b4ddf0f42ca95f85f71ab38d7b039957)_tmp;
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

private static async Task<RC_85f15a383e9651f9f34f899ceee2be30> datasetGetFirstAccountingInvoiceApprovalLevelApprovedReadDbAsync(RC_85f15a383e9651f9f34f899ceee2be30 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFirstAccountingInvoiceApprovalLevelApproved" Qm+FTAkr30uCkEzRC38niQ of Action "GenerateInvoicesReport48_Invoices6Approval"
public static async Task<(RL_540f5613fbde7a506fffd29a691298e6,long)> datasetGetFirstAccountingInvoiceApprovalLevelApproved(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GenerateInvoicesReport48_Invoices6Approval.GetFirstAccountingInvoiceApprovalLevelApproved", "4c856f42-2b09-4bdf-8290-4cd10b7f2789");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GenerateInvoicesReport48_Invoices6Approval.GetFirstAccountingInvoiceApprovalLevelApproved", "4c856f42-2b09-4bdf-8290-4cd10b7f2789", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.rCHoYjXTeUWWDW62BQBGhw/NodesNotShownInESpaceTree.Qm+FTAkr30uCkEzRC38niQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"enuser62\".\"name\" o36, NULL o37, NULL o38, NULL o39");
fromBuilder.Append(" FROM (({InvoiceApprovalLevel} \"eninvoiceapprovallevel9\" Left JOIN {InvoiceApproval} \"eninvoiceapproval8\" ON (\"eninvoiceapprovallevel9\".\"invoiceapprovalid\" = \"eninvoiceapproval8\".\"id\"))  Left JOIN {User} \"enuser62\" ON (\"eninvoiceapprovallevel9\".\"assignedto\" = \"enuser62\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval8\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval8\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval8\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel9\".\"isaccounting\" = 1) AND (\"eninvoiceapprovallevel9\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel9\".\"levelnumber\" ASC ");
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
RL_540f5613fbde7a506fffd29a691298e6 outParamList = new RL_540f5613fbde7a506fffd29a691298e6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFirstAccountingInvoiceApprovalLevelApprovedReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GenerateInvoicesReport48_Invoices6Approval.GetFirstAccountingInvoiceApprovalLevelApproved.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_540f5613fbde7a506fffd29a691298e6 _tmp = new RL_540f5613fbde7a506fffd29a691298e6();
_tmp.AlternateReadDbMethodAsync = datasetGetFirstAccountingInvoiceApprovalLevelApprovedReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GenerateInvoicesReport48_Invoices6Approval.GetFirstAccountingInvoiceApprovalLevelApproved.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_540f5613fbde7a506fffd29a691298e6)_tmp;
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
