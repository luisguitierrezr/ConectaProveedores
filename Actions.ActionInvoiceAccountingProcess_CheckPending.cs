namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcess_CheckPending : VarsBag {
public long inParamSupplierId;
public RL_00bd7d2e1d6477607f48fdc5409b4a65 queryResGetInvAccountingProcessesREQ_outParamList = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
public long queryResGetInvAccountingProcessesREQ_outParamCount = 0L;

public RL_9ffab0739d7699671c697b53b449a84f queryResGetInvAccountingProcessesFCP_outParamList = new RL_9ffab0739d7699671c697b53b449a84f();
public long queryResGetInvAccountingProcessesFCP_outParamCount = 0L;

public RL_e1821cde66da1d9e887529d6d8944d88 queryResGetInvAccountingProcessesFSP_outParamList = new RL_e1821cde66da1d9e887529d6d8944d88();
public long queryResGetInvAccountingProcessesFSP_outParamCount = 0L;

public lcvInvoiceAccountingProcess_CheckPending(long inParamSupplierId) {
this.inParamSupplierId = inParamSupplierId;
}
}
public class lcoInvoiceAccountingProcess_CheckPending : VarsBag {
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord outParamInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();

public bool outParamIsFCP = false;

public bool outParamIsREQ = false;

public lcoInvoiceAccountingProcess_CheckPending() {
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcess_CheckPending</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcess_CheckPending</code> <p> Description: </p>
/// </summary>
public static async Task<(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord,bool,bool)> ActionInvoiceAccountingProcess_CheckPending(IRequestContext requestContext,long inParamSupplierId,CancellationToken cancellationToken) {
EN_d21666375df829d28ffce8e5e0a3400dEntityRecord outParamInvoiceAccountingProcess = default;
bool outParamIsFCP = default;
bool outParamIsREQ = default;
lcoInvoiceAccountingProcess_CheckPending result = new lcoInvoiceAccountingProcess_CheckPending();
lcvInvoiceAccountingProcess_CheckPending localVars = new lcvInvoiceAccountingProcess_CheckPending(inParamSupplierId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcess_CheckPending", "b255357e-5035-4c09-ba7d-4b439dcc1a55"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcess_CheckPending", "b255357e-5035-4c09-ba7d-4b439dcc1a55", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvAccountingProcessesFCP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvAccountingProcessesFCP_maxRecords = 1;
if (datasetGetInvAccountingProcessesFCP_maxRecords < 1) datasetGetInvAccountingProcessesFCP_maxRecords = 1;
int datasetGetInvAccountingProcessesFCP_startIndex = 0;(localVars.queryResGetInvAccountingProcessesFCP_outParamList,localVars.queryResGetInvAccountingProcessesFCP_outParamCount) = await FuncActionInvoiceAccountingProcess_CheckPending.datasetGetInvAccountingProcessesFCP(requestContext,datasetGetInvAccountingProcessesFCP_maxRecords,datasetGetInvAccountingProcessesFCP_startIndex,IterationMultiplicity.Never,localVars.inParamSupplierId,cancellationToken);

// exists
if(((!localVars.queryResGetInvAccountingProcessesFCP_outParamList.Empty))) {
// InvoiceAccountingProcess = GetInvAccountingProcessesFCP.List.Current.InvoiceAccountingProcess
result.outParamInvoiceAccountingProcess=localVars.queryResGetInvAccountingProcessesFCP_outParamList.CurrentRec.ssENInvoiceAccountingProcess;

// IsFCP = True
result.outParamIsFCP=true;
} else {
// Query datasetGetInvAccountingProcessesFSP
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvAccountingProcessesFSP_maxRecords = 1;
if (datasetGetInvAccountingProcessesFSP_maxRecords < 1) datasetGetInvAccountingProcessesFSP_maxRecords = 1;
int datasetGetInvAccountingProcessesFSP_startIndex = 0;(localVars.queryResGetInvAccountingProcessesFSP_outParamList,localVars.queryResGetInvAccountingProcessesFSP_outParamCount) = await FuncActionInvoiceAccountingProcess_CheckPending.datasetGetInvAccountingProcessesFSP(requestContext,datasetGetInvAccountingProcessesFSP_maxRecords,datasetGetInvAccountingProcessesFSP_startIndex,IterationMultiplicity.Never,localVars.inParamSupplierId,cancellationToken);

// exists
if(((!localVars.queryResGetInvAccountingProcessesFSP_outParamList.Empty))) {
// InvoiceAccountingProcess = GetInvAccountingProcessesFSP.List.Current.InvoiceAccountingProcess
result.outParamInvoiceAccountingProcess=localVars.queryResGetInvAccountingProcessesFSP_outParamList.CurrentRec.ssENInvoiceAccountingProcess;
} else {
// Query datasetGetInvAccountingProcessesREQ
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvAccountingProcessesREQ_maxRecords = 1;
if (datasetGetInvAccountingProcessesREQ_maxRecords < 1) datasetGetInvAccountingProcessesREQ_maxRecords = 1;
int datasetGetInvAccountingProcessesREQ_startIndex = 0;(localVars.queryResGetInvAccountingProcessesREQ_outParamList,localVars.queryResGetInvAccountingProcessesREQ_outParamCount) = await FuncActionInvoiceAccountingProcess_CheckPending.datasetGetInvAccountingProcessesREQ(requestContext,datasetGetInvAccountingProcessesREQ_maxRecords,datasetGetInvAccountingProcessesREQ_startIndex,IterationMultiplicity.Never,localVars.inParamSupplierId,cancellationToken);

// exists
if(((!localVars.queryResGetInvAccountingProcessesREQ_outParamList.Empty))) {
// InvoiceAccountingProcess = GetInvAccountingProcessesREQ.List.Current.InvoiceAccountingProcess
result.outParamInvoiceAccountingProcess=localVars.queryResGetInvAccountingProcessesREQ_outParamList.CurrentRec.ssENInvoiceAccountingProcess;

// IsREQ = True
result.outParamIsREQ=true;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamInvoiceAccountingProcess = result.outParamInvoiceAccountingProcess;
outParamIsFCP = result.outParamIsFCP;
outParamIsREQ = result.outParamIsREQ;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoiceAccountingProcess,outParamIsFCP,outParamIsREQ);
}

public static class FuncActionInvoiceAccountingProcess_CheckPending {

private static async Task<RC_bf8addab42f215a7fe4584fe7162ae78> datasetGetInvAccountingProcessesREQReadDbAsync(RC_bf8addab42f215a7fe4584fe7162ae78 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvAccountingProcessesREQ" Q3iWiO1+OUS6SzkfYx_HBg of Action "InvoiceAccountingProcess_CheckPending"
public static async Task<(RL_00bd7d2e1d6477607f48fdc5409b4a65,long)> datasetGetInvAccountingProcessesREQ(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuRequisition_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesREQ", "88967843-7eed-4439-ba4b-391f631fc706");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesREQ", "88967843-7eed-4439-ba4b-391f631fc706", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fjVVsjVQCUy6fUtDncwaVQ/NodesNotShownInESpaceTree.Q3iWiO1+OUS6SzkfYx_HBg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccountingprocess2\".\"id\" o0, \"eninvoiceaccountingprocess2\".\"invoiceid\" o1, \"eninvoiceaccountingprocess2\".\"requisitionid\" o2, \"eninvoiceaccountingprocess2\".\"offsetutc\" o3, \"eninvoiceaccountingprocess2\".\"comment\" o4, \"eninvoiceaccountingprocess2\".\"processnumber\" o5, \"eninvoiceaccountingprocess2\".\"createdon\" o6, \"eninvoiceaccountingprocess2\".\"nexttry\" o7, \"eninvoiceaccountingprocess2\".\"invoiceprocessstatusid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66");
fromBuilder.Append(" FROM ({InvoiceAccountingProcess} \"eninvoiceaccountingprocess2\" Left JOIN {Requisition} \"enrequisition45\" ON (\"eninvoiceaccountingprocess2\".\"requisitionid\" = \"enrequisition45\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition45\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition45\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition45\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceaccountingprocess2\".\"invoiceprocessstatusid\" = ");
whereBuilder.Append((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("Tc6389H3X0+sBfcYBvMR1g"))).ssId);
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
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesREQ.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesREQ.List", cancellationToken: cancellationToken);
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

private static async Task<RC_ff169b020f7f52f3fee2c054b741a07f> datasetGetInvAccountingProcessesFCPReadDbAsync(RC_ff169b020f7f52f3fee2c054b741a07f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetInvAccountingProcessesFCP" FpMru3tqyE2tu3PbaJnLYA of Action "InvoiceAccountingProcess_CheckPending"
public static async Task<(RL_9ffab0739d7699671c697b53b449a84f,long)> datasetGetInvAccountingProcessesFCP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuOrderMain_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFCP", "bb2b9316-6a7b-4dc8-adbb-73db6899cb60");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFCP", "bb2b9316-6a7b-4dc8-adbb-73db6899cb60", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fjVVsjVQCUy6fUtDncwaVQ/NodesNotShownInESpaceTree.FpMru3tqyE2tu3PbaJnLYA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceaccountingprocess3\".\"id\" o24, \"eninvoiceaccountingprocess3\".\"invoiceid\" o25, \"eninvoiceaccountingprocess3\".\"requisitionid\" o26, \"eninvoiceaccountingprocess3\".\"offsetutc\" o27, \"eninvoiceaccountingprocess3\".\"comment\" o28, \"eninvoiceaccountingprocess3\".\"processnumber\" o29, \"eninvoiceaccountingprocess3\".\"createdon\" o30, \"eninvoiceaccountingprocess3\".\"nexttry\" o31, \"eninvoiceaccountingprocess3\".\"invoiceprocessstatusid\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61");
fromBuilder.Append(" FROM (({InvoiceAccountingProcess} \"eninvoiceaccountingprocess3\" Left JOIN {Invoice} \"eninvoice48\" ON (\"eninvoiceaccountingprocess3\".\"invoiceid\" = \"eninvoice48\".\"id\"))  Left JOIN {OrderMain} \"enordermain46\" ON (\"eninvoice48\".\"ordermainid\" = \"enordermain46\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain46\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain46\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain46\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceaccountingprocess3\".\"invoiceprocessstatusid\" = ");
whereBuilder.Append((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("Tc6389H3X0+sBfcYBvMR1g"))).ssId);
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
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFCP.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFCP.List", cancellationToken: cancellationToken);
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

private static async Task<RC_93712ae8022b855afd9826482f80eceb> datasetGetInvAccountingProcessesFSPReadDbAsync(RC_93712ae8022b855afd9826482f80eceb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvAccountingProcessesFSP" zvx+u_qpo02q+zpCdGwLmw of Action "InvoiceAccountingProcess_CheckPending"
public static async Task<(RL_e1821cde66da1d9e887529d6d8944d88,long)> datasetGetInvAccountingProcessesFSP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuRequisition_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFSP", "bb7efcce-a9fa-4da3-aafb-3a42746c0b9b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFSP", "bb7efcce-a9fa-4da3-aafb-3a42746c0b9b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.fjVVsjVQCUy6fUtDncwaVQ/NodesNotShownInESpaceTree.zvx+u_qpo02q+zpCdGwLmw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceaccountingprocess4\".\"id\" o24, \"eninvoiceaccountingprocess4\".\"invoiceid\" o25, \"eninvoiceaccountingprocess4\".\"requisitionid\" o26, \"eninvoiceaccountingprocess4\".\"offsetutc\" o27, \"eninvoiceaccountingprocess4\".\"comment\" o28, \"eninvoiceaccountingprocess4\".\"processnumber\" o29, \"eninvoiceaccountingprocess4\".\"createdon\" o30, \"eninvoiceaccountingprocess4\".\"nexttry\" o31, \"eninvoiceaccountingprocess4\".\"invoiceprocessstatusid\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90");
fromBuilder.Append(" FROM (({InvoiceAccountingProcess} \"eninvoiceaccountingprocess4\" Left JOIN {Invoice} \"eninvoice49\" ON (\"eninvoiceaccountingprocess4\".\"invoiceid\" = \"eninvoice49\".\"id\"))  Left JOIN {Requisition} \"enrequisition46\" ON (\"eninvoice49\".\"requisitionid\" = \"enrequisition46\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition46\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition46\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition46\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceaccountingprocess4\".\"invoiceprocessstatusid\" = ");
whereBuilder.Append((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("Tc6389H3X0+sBfcYBvMR1g"))).ssId);
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
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFSP.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_CheckPending.GetInvAccountingProcessesFSP.List", cancellationToken: cancellationToken);
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
