namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcess_CheckOngoing : VarsBag {
public long inParamSupplierId;
public RL_9ffab0739d7699671c697b53b449a84f queryResGetInvAccountingProcessesFCP_outParamList = new RL_9ffab0739d7699671c697b53b449a84f();
public long queryResGetInvAccountingProcessesFCP_outParamCount = 0L;

public RL_00bd7d2e1d6477607f48fdc5409b4a65 queryResGetInvAccountingProcessesREQ_outParamList = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
public long queryResGetInvAccountingProcessesREQ_outParamCount = 0L;

public RL_e1821cde66da1d9e887529d6d8944d88 queryResGetInvAccountingProcessesFSP_outParamList = new RL_e1821cde66da1d9e887529d6d8944d88();
public long queryResGetInvAccountingProcessesFSP_outParamCount = 0L;

public lcvInvoiceAccountingProcess_CheckOngoing(long inParamSupplierId) {
this.inParamSupplierId = inParamSupplierId;
}
}
public class lcoInvoiceAccountingProcess_CheckOngoing : VarsBag {
public bool outParamIsOngoing = false;

public long outParamInvoiceAccountingProcessId = 0L;

public lcoInvoiceAccountingProcess_CheckOngoing() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcess_CheckOngoing</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcess_CheckOngoing</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,long)> ActionInvoiceAccountingProcess_CheckOngoing(IRequestContext requestContext,long inParamSupplierId,CancellationToken cancellationToken) {
bool outParamIsOngoing = default;
long outParamInvoiceAccountingProcessId = default;
lcoInvoiceAccountingProcess_CheckOngoing result = new lcoInvoiceAccountingProcess_CheckOngoing();
lcvInvoiceAccountingProcess_CheckOngoing localVars = new lcvInvoiceAccountingProcess_CheckOngoing(inParamSupplierId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcess_CheckOngoing", "d1212518-5717-4b9d-afbc-8dc33c527c89"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcess_CheckOngoing", "d1212518-5717-4b9d-afbc-8dc33c527c89", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvAccountingProcessesFCP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvAccountingProcessesFCP_maxRecords = 1;
if (datasetGetInvAccountingProcessesFCP_maxRecords < 1) datasetGetInvAccountingProcessesFCP_maxRecords = 1;
int datasetGetInvAccountingProcessesFCP_startIndex = 0;(localVars.queryResGetInvAccountingProcessesFCP_outParamList,localVars.queryResGetInvAccountingProcessesFCP_outParamCount) = await FuncActionInvoiceAccountingProcess_CheckOngoing.datasetGetInvAccountingProcessesFCP(requestContext,datasetGetInvAccountingProcessesFCP_maxRecords,datasetGetInvAccountingProcessesFCP_startIndex,IterationMultiplicity.Never,localVars.inParamSupplierId,cancellationToken);

// exists
if(((!localVars.queryResGetInvAccountingProcessesFCP_outParamList.Empty))) {
// InvoiceAccountingProcessId = GetInvAccountingProcessesFCP.List.Current.InvoiceAccountingProcess.Id
result.outParamInvoiceAccountingProcessId=localVars.queryResGetInvAccountingProcessesFCP_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssId;

// IsOngoing = True
result.outParamIsOngoing=true;
} else {
// Query datasetGetInvAccountingProcessesFSP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvAccountingProcessesFSP_maxRecords = 1;
if (datasetGetInvAccountingProcessesFSP_maxRecords < 1) datasetGetInvAccountingProcessesFSP_maxRecords = 1;
int datasetGetInvAccountingProcessesFSP_startIndex = 0;(localVars.queryResGetInvAccountingProcessesFSP_outParamList,localVars.queryResGetInvAccountingProcessesFSP_outParamCount) = await FuncActionInvoiceAccountingProcess_CheckOngoing.datasetGetInvAccountingProcessesFSP(requestContext,datasetGetInvAccountingProcessesFSP_maxRecords,datasetGetInvAccountingProcessesFSP_startIndex,IterationMultiplicity.Never,localVars.inParamSupplierId,cancellationToken);

// exists
if(((!localVars.queryResGetInvAccountingProcessesFSP_outParamList.Empty))) {
// InvoiceAccountingProcessId = GetInvAccountingProcessesFSP.List.Current.InvoiceAccountingProcess.Id
result.outParamInvoiceAccountingProcessId=localVars.queryResGetInvAccountingProcessesFSP_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssId;

// IsOngoing = True
result.outParamIsOngoing=true;
} else {
// Query datasetGetInvAccountingProcessesREQ
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvAccountingProcessesREQ_maxRecords = 1;
if (datasetGetInvAccountingProcessesREQ_maxRecords < 1) datasetGetInvAccountingProcessesREQ_maxRecords = 1;
int datasetGetInvAccountingProcessesREQ_startIndex = 0;(localVars.queryResGetInvAccountingProcessesREQ_outParamList,localVars.queryResGetInvAccountingProcessesREQ_outParamCount) = await FuncActionInvoiceAccountingProcess_CheckOngoing.datasetGetInvAccountingProcessesREQ(requestContext,datasetGetInvAccountingProcessesREQ_maxRecords,datasetGetInvAccountingProcessesREQ_startIndex,IterationMultiplicity.Never,localVars.inParamSupplierId,cancellationToken);

// exists
if(((!localVars.queryResGetInvAccountingProcessesREQ_outParamList.Empty))) {
// InvoiceAccountingProcessId = GetInvAccountingProcessesREQ.List.Current.InvoiceAccountingProcess.Id
result.outParamInvoiceAccountingProcessId=localVars.queryResGetInvAccountingProcessesREQ_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssId;

// IsOngoing = True
result.outParamIsOngoing=true;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsOngoing = result.outParamIsOngoing;
outParamInvoiceAccountingProcessId = result.outParamInvoiceAccountingProcessId;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsOngoing,outParamInvoiceAccountingProcessId);
}

public static class FuncActionInvoiceAccountingProcess_CheckOngoing {

private static async Task<RC_ff169b020f7f52f3fee2c054b741a07f> datasetGetInvAccountingProcessesFCPReadDbAsync(RC_ff169b020f7f52f3fee2c054b741a07f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetInvAccountingProcessesFCP" cQn0mp+NnkCM9sj8Gpc2Rg of Action "InvoiceAccountingProcess_CheckOngoing"
public static async Task<(RL_9ffab0739d7699671c697b53b449a84f,long)> datasetGetInvAccountingProcessesFCP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuOrderMain_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFCP", "9af40971-8d9f-409e-8cf6-c8fc1a973646");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFCP", "9af40971-8d9f-409e-8cf6-c8fc1a973646", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.GCUh0RdXnUuvvI3DPFJ8iQ/NodesNotShownInESpaceTree.cQn0mp+NnkCM9sj8Gpc2Rg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceaccountingprocess5\".\"id\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61");
fromBuilder.Append(" FROM (({InvoiceAccountingProcess} \"eninvoiceaccountingprocess5\" Left JOIN {Invoice} \"eninvoice63\" ON (\"eninvoiceaccountingprocess5\".\"invoiceid\" = \"eninvoice63\".\"id\"))  Left JOIN {OrderMain} \"enordermain55\" ON (\"eninvoice63\".\"ordermainid\" = \"enordermain55\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain55\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain55\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain55\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceaccountingprocess5\".\"invoiceprocessstatusid\" = ");
whereBuilder.Append((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"))).ssId);
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
RL_9ffab0739d7699671c697b53b449a84f outParamList = new RL_9ffab0739d7699671c697b53b449a84f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvAccountingProcessesFCPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFCP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9ffab0739d7699671c697b53b449a84f _tmp = new RL_9ffab0739d7699671c697b53b449a84f();
_tmp.AlternateReadDbMethodAsync = datasetGetInvAccountingProcessesFCPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFCP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9ffab0739d7699671c697b53b449a84f)_tmp;
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

private static async Task<RC_bf8addab42f215a7fe4584fe7162ae78> datasetGetInvAccountingProcessesREQReadDbAsync(RC_bf8addab42f215a7fe4584fe7162ae78 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvAccountingProcessesREQ" Ux3K60J+YUG2M0j1iuNVlw of Action "InvoiceAccountingProcess_CheckOngoing"
public static async Task<(RL_00bd7d2e1d6477607f48fdc5409b4a65,long)> datasetGetInvAccountingProcessesREQ(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuRequisition_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesREQ", "ebca1d53-7e42-4161-b633-48f58ae35597");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesREQ", "ebca1d53-7e42-4161-b633-48f58ae35597", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.GCUh0RdXnUuvvI3DPFJ8iQ/NodesNotShownInESpaceTree.Ux3K60J+YUG2M0j1iuNVlw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccountingprocess6\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66");
fromBuilder.Append(" FROM ({InvoiceAccountingProcess} \"eninvoiceaccountingprocess6\" Left JOIN {Requisition} \"enrequisition59\" ON (\"eninvoiceaccountingprocess6\".\"requisitionid\" = \"enrequisition59\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition59\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition59\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition59\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceaccountingprocess6\".\"invoiceprocessstatusid\" = ");
whereBuilder.Append((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"))).ssId);
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
RL_00bd7d2e1d6477607f48fdc5409b4a65 outParamList = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvAccountingProcessesREQReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesREQ.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00bd7d2e1d6477607f48fdc5409b4a65 _tmp = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
_tmp.AlternateReadDbMethodAsync = datasetGetInvAccountingProcessesREQReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesREQ.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00bd7d2e1d6477607f48fdc5409b4a65)_tmp;
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

private static async Task<RC_93712ae8022b855afd9826482f80eceb> datasetGetInvAccountingProcessesFSPReadDbAsync(RC_93712ae8022b855afd9826482f80eceb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvAccountingProcessesFSP" GWLj_t7TtEaKtXK+lAdGKA of Action "InvoiceAccountingProcess_CheckOngoing"
public static async Task<(RL_e1821cde66da1d9e887529d6d8944d88,long)> datasetGetInvAccountingProcessesFSP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuRequisition_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFSP", "fee36219-d3de-46b4-8ab5-72be94074628");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFSP", "fee36219-d3de-46b4-8ab5-72be94074628", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.GCUh0RdXnUuvvI3DPFJ8iQ/NodesNotShownInESpaceTree.GWLj_t7TtEaKtXK+lAdGKA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceaccountingprocess7\".\"id\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90");
fromBuilder.Append(" FROM (({InvoiceAccountingProcess} \"eninvoiceaccountingprocess7\" Left JOIN {Invoice} \"eninvoice64\" ON (\"eninvoiceaccountingprocess7\".\"invoiceid\" = \"eninvoice64\".\"id\"))  Left JOIN {Requisition} \"enrequisition60\" ON (\"eninvoice64\".\"requisitionid\" = \"enrequisition60\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition60\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition60\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition60\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceaccountingprocess7\".\"invoiceprocessstatusid\" = ");
whereBuilder.Append((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"))).ssId);
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
RL_e1821cde66da1d9e887529d6d8944d88 outParamList = new RL_e1821cde66da1d9e887529d6d8944d88();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvAccountingProcessesFSPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFSP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e1821cde66da1d9e887529d6d8944d88 _tmp = new RL_e1821cde66da1d9e887529d6d8944d88();
_tmp.AlternateReadDbMethodAsync = datasetGetInvAccountingProcessesFSPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_CheckOngoing.GetInvAccountingProcessesFSP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e1821cde66da1d9e887529d6d8944d88)_tmp;
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
