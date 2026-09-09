using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public DateTime inParami_RefreshWB;
public RL_4af3045b114dbc57d1481fed5aceb93a varLcList;
public AggregateRecord<RL_68b561fd1c8e1947226d48378281e5a1> ScreenDataSetGetInvoicesApprovalLevels;
public AggregateRecord<RL_41aa9995b50bccef3903021154e98b17> ScreenDataSetGetInvoiceById;
public ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetEntraUserManagerList_Model varLcGetEntraUserManagerList;
public ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetSpecialApprovalLevels_Model varLcGetSpecialApprovalLevels;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel(long inParami_InvoiceId, DateTime inParami_RefreshWB, RL_4af3045b114dbc57d1481fed5aceb93a varLcList, AggregateRecord<RL_68b561fd1c8e1947226d48378281e5a1> ScreenDataSetGetInvoicesApprovalLevels, AggregateRecord<RL_41aa9995b50bccef3903021154e98b17> ScreenDataSetGetInvoiceById, ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetEntraUserManagerList_Model varLcGetEntraUserManagerList, ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetSpecialApprovalLevels_Model varLcGetSpecialApprovalLevels, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_RefreshWB", "List", "GetInvoicesApprovalLevels", "GetInvoiceById", "GetEntraUserManagerList", "GetSpecialApprovalLevels", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_RefreshWB", "varLcList", "ScreenDataSetGetInvoicesApprovalLevels", "ScreenDataSetGetInvoiceById", "varLcGetEntraUserManagerList", "varLcGetSpecialApprovalLevels", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_RefreshWB = inParami_RefreshWB;
this.varLcList = varLcList;
this.ScreenDataSetGetInvoicesApprovalLevels = ScreenDataSetGetInvoicesApprovalLevels;
this.ScreenDataSetGetInvoiceById = ScreenDataSetGetInvoiceById;
this.varLcGetEntraUserManagerList = varLcGetEntraUserManagerList;
this.varLcGetSpecialApprovalLevels = varLcGetSpecialApprovalLevels;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_605897e6a4b36a23ebf729de65626af9> datasetGetInvoicesApprovalLevelsReadDbAsync(RC_605897e6a4b36a23ebf729de65626af9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceComment_Cancel.Read( r, ref index);
rec.ssENInvoiceComment_Modify.Read( r, ref index);
rec.ssENUser_ApprovedBy.Read( r, ref index);
rec.ssENUser_AssignedTo.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesApprovalLevels" pJkJGZD7kUGeLmNDb8vlzg of Action "Wb_InvoicesEntra_Historic"
public static async Task<(RL_68b561fd1c8e1947226d48378281e5a1,long)> datasetGetInvoicesApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinInvoiceStatusId,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoicesEntra_Historic.GetInvoicesApprovalLevels", "190999a4-fb90-4191-9e2e-63436fcbe5ce");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoicesEntra_Historic","d_Invoices.Wb_InvoicesEntra_Historic.GetInvoicesApprovalLevels");
// Query Iterations: Multiple
// Refresh Query dYG_+gdxIU2iEATyUvbAAw Iterations: Multiple
// Refresh Query _pI9MXCHIk6i32djCyRdWw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.dLJ_Va3Nn0S8Uo2+V9xO1w/ScreenDataSets.pJkJGZD7kUGeLmNDb8vlzg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole56\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"eninvoice120\".\"invoicestatusid\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"eninvoiceapprovallevel35\".\"entrajobtitle\" o46, NULL o47, NULL o48, NULL o49, NULL o50, \"eninvoiceapprovallevel35\".\"approvalstatusid\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, \"eninvoiceapprovallevel35\".\"isreassigned\" o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, \"eninvoicecomment_cancel\".\"message\" o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, \"eninvoicecomment_modify\".\"message\" o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, \"enuser_assignedto\".\"name\" o88, NULL o89, NULL o90, NULL o91");
fromBuilder.Append(" FROM ((((((({Invoice} \"eninvoice120\" Left JOIN {InvoiceApproval} \"eninvoiceapproval35\" ON (\"eninvoice120\".\"id\" = \"eninvoiceapproval35\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel35\" ON (\"eninvoiceapproval35\".\"id\" = \"eninvoiceapprovallevel35\".\"invoiceapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole56\" ON (\"eninvoiceapprovallevel35\".\"applicationroleid\" = \"enapplicationrole56\".\"id\"))  Left JOIN {InvoiceComment} \"eninvoicecomment_cancel\" ON ((\"eninvoiceapprovallevel35\".\"id\" = \"eninvoicecomment_cancel\".\"invoiceapprovallevelid\") AND ");
if (qpinInvoiceStatusId != 0) {
fromBuilder.Append("((");
fromBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
fromBuilder.Append(" = @qpinInvoiceStatusId) AND (");
fromBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
fromBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceStatusId", DbType.Int32, qpinInvoiceStatusId);
} else {
fromBuilder.Append("(");
fromBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
fromBuilder.Append(" IS NULL)");
}
fromBuilder.Append("))  Left JOIN {InvoiceComment} \"eninvoicecomment_modify\" ON ((\"eninvoiceapprovallevel35\".\"id\" = \"eninvoicecomment_modify\".\"invoiceapprovallevelid\") AND ");
if (qpinInvoiceStatusId != 0) {
fromBuilder.Append("((");
fromBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId);
fromBuilder.Append(" = @qpinInvoiceStatusId) AND (");
fromBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId);
fromBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceStatusId", DbType.Int32, qpinInvoiceStatusId);
} else {
fromBuilder.Append("(");
fromBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId);
fromBuilder.Append(" IS NULL)");
}
fromBuilder.Append("))  Left JOIN {User} \"enuser_assignedto\" ON ((\"eninvoiceapprovallevel35\".\"assignedto\" = \"enuser_assignedto\".\"id\") AND (\"eninvoiceapprovallevel35\".\"assignedto\" IS NOT NULL)))  Left JOIN {User} \"enuser_approvedby\" ON (((CASE WHEN (\"eninvoiceapprovallevel35\".\"approvedby\" IS NOT NULL) THEN (CASE WHEN (\"eninvoiceapprovallevel35\".\"approvedby\" = \"enuser_approvedby\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"eninvoiceapprovallevel35\".\"canceledby\" IS NOT NULL) THEN (CASE WHEN (\"eninvoiceapprovallevel35\".\"canceledby\" = \"enuser_approvedby\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"eninvoiceapprovallevel35\".\"requesttomodifyby\" IS NOT NULL) THEN (CASE WHEN (\"eninvoiceapprovallevel35\".\"requesttomodifyby\" = \"enuser_approvedby\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"eninvoiceapprovallevel35\".\"assignedto\" = \"enuser_approvedby\".\"id\") THEN 1 ELSE 0 END) END) END) END) = 1) AND (((\"eninvoiceapprovallevel35\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
fromBuilder.Append(") OR (\"eninvoiceapprovallevel35\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId);
fromBuilder.Append(")) OR (\"eninvoiceapprovallevel35\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId);
fromBuilder.Append(")))) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice120\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice120\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice120\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel35\".\"levelnumber\" ASC ");
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
RL_68b561fd1c8e1947226d48378281e5a1 outParamList = new RL_68b561fd1c8e1947226d48378281e5a1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, false, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, false, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetInvoicesApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_68b561fd1c8e1947226d48378281e5a1 _tmp = new RL_68b561fd1c8e1947226d48378281e5a1();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetInvoicesApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_68b561fd1c8e1947226d48378281e5a1)_tmp;
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

private static async Task<RC_0bd21c095360ef78cf6d0f1777ecf52a> datasetGetInvoiceByIdReadDbAsync(RC_0bd21c095360ef78cf6d0f1777ecf52a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" j5t4VL7GHUOE6OwDpMDc3w of Action "Wb_InvoicesEntra_Historic"
public static async Task<(RL_41aa9995b50bccef3903021154e98b17,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoicesEntra_Historic.GetInvoiceById", "54789b8f-c6be-431d-84e8-ec03a4c0dcdf");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoicesEntra_Historic","d_Invoices.Wb_InvoicesEntra_Historic.GetInvoiceById");
// Query Iterations: Never
// Refresh Query HfeWu5Nbck6bgt95DgaARg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.dLJ_Va3Nn0S8Uo2+V9xO1w/ScreenDataSets.j5t4VL7GHUOE6OwDpMDc3w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enapprovalprocess43\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"eninvoice121\".\"invoicestatusid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"eninvoiceapproval36\".\"id\" o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52");
fromBuilder.Append(" FROM (({Invoice} \"eninvoice121\" Left JOIN {InvoiceApproval} \"eninvoiceapproval36\" ON (\"eninvoice121\".\"id\" = \"eninvoiceapproval36\".\"invoiceid\"))  Left JOIN {ApprovalProcess} \"enapprovalprocess43\" ON (\"eninvoiceapproval36\".\"aprovalprocessid\" = \"enapprovalprocess43\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice121\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice121\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice121\".\"id\" IS NULL)");
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
RL_41aa9995b50bccef3903021154e98b17 outParamList = new RL_41aa9995b50bccef3903021154e98b17();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_41aa9995b50bccef3903021154e98b17 _tmp = new RL_41aa9995b50bccef3903021154e98b17();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_41aa9995b50bccef3903021154e98b17)_tmp;
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


    public class lcvGetEntraUserManagerList : VarsBag {
public Actions.lcoGetInvEntraManagers resGetInvEntraManagers =  new Actions.lcoGetInvEntraManagers();
public RL_22118fef24990e91082f637f0240b25e queryResGetLastApprover_outParamList = new RL_22118fef24990e91082f637f0240b25e();
public long queryResGetLastApprover_outParamCount = 0L;

public lcvGetEntraUserManagerList() {
}
}
public class lcoGetEntraUserManagerList : VarsBag {
public RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList = new RL_4af3045b114dbc57d1481fed5aceb93a();

public lcoGetEntraUserManagerList() {
}
}
/// <summary>
/// Action <code>GetEntraUserManagerList</code> that represents the Service Studio action
///  <code>GetEntraUserManagerList</code> <p> Description: </p>
/// </summary>
public async Task<RL_4af3045b114dbc57d1481fed5aceb93a> DataActionGetEntraUserManagerList(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_4af3045b114dbc57d1481fed5aceb93a outParamUserList = default;
lcoGetEntraUserManagerList result = new lcoGetEntraUserManagerList();
lcvGetEntraUserManagerList localVars = new lcvGetEntraUserManagerList();
ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetEntraUserManagerList", "8c38576b-2afd-4a4e-b796-253b6d538a3c"))
using (activitySource.CreateScreenDataActionActivity("Wb_InvoicesEntra_Historic", "GetEntraUserManagerList")){
if((!((((ScreenDataSetGetInvoicesApprovalLevels.List.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("4NyjEZqqGEqzQUUvdWYJqw"))).ssId)||(ScreenDataSetGetInvoicesApprovalLevels.List.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId))||(ScreenDataSetGetInvoicesApprovalLevels.List.CurrentRec.ssENInvoice.ssInvoiceStatusId==(ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId))))) {
// Query datasetGetLastApprover
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLastApprover_maxRecords = 1;
if (datasetGetLastApprover_maxRecords < 1) datasetGetLastApprover_maxRecords = 1;
int datasetGetLastApprover_startIndex = 0;(localVars.queryResGetLastApprover_outParamList,localVars.queryResGetLastApprover_outParamCount) = await FuncDataActionGetEntraUserManagerList.datasetGetLastApprover(requestContext,datasetGetLastApprover_maxRecords,datasetGetLastApprover_startIndex,IterationMultiplicity.Single,inParami_InvoiceId,cancellationToken);

if((!((localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssAssignedTo==BuiltInFunction.NullTextIdentifier ())))) {
// GetInvEntraManagers
localVars.resGetInvEntraManagers.outParamo_ListOut = await Actions.ActionGetInvEntraManagers(requestContext,(((localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUser.ssEmail)),localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENInvoiceApproval,(await RL_cff357eb9416ff34aed51af5aed473de.ConvertAsync(localVars.queryResGetLastApprover_outParamList, new RL_cff357eb9416ff34aed51af5aed473de(), async (RC_6872064329fe950ffeb72169f6f6f25b source, RC_d8e0782722e3cf21d33f17c1d3072275 target, CancellationToken cancellationToken) => {
target.ssENApplicationRole = source.ssENApplicationRole;
target.ssDoNotEntraSearch = source.ssDoNotEntraSearch;
target.ssENInvoice = source.ssENInvoice;
target.ssENInvoiceApproval = source.ssENInvoiceApproval;
target.ssENInvoiceApprovalLevel = source.ssENInvoiceApprovalLevel;
target.ssENUser = source.ssENUser;
target.ssENUser_Extended_Internal = source.ssENUser_Extended_Internal;
return target;
}, cancellationToken)),cancellationToken);

// UserList = GetInvEntraManagers.o_ListOut
result.outParamUserList=(await RL_4af3045b114dbc57d1481fed5aceb93a.ConvertAsync(localVars.resGetInvEntraManagers.outParamo_ListOut, new RL_4af3045b114dbc57d1481fed5aceb93a(), async (RC_2dabb9c9cbdbc6ba6572314572d54c39 source, ST_34625f5643caa3d12448dcec7dd4c7d3Structure target, CancellationToken cancellationToken) => {
target.ssName = source.ssDisplayName;
target.ssRole = source.ssJobTitle;
target.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId;
target.ssIsNotMapped = source.ssIsNotMapped;
return target;
}, cancellationToken));
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamUserList = result.outParamUserList;
} // inner-finally
RETURN_STATEMENT:
return outParamUserList;
}
public class lcvGetSpecialApprovalLevels : VarsBag {
public RL_be474dab9f20512d09fda3e1e99c2e25 queryResGetLevels_outParamList = new RL_be474dab9f20512d09fda3e1e99c2e25();
public long queryResGetLevels_outParamCount = 0L;

public lcvGetSpecialApprovalLevels() {
}
}
public class lcoGetSpecialApprovalLevels : VarsBag {
public RL_875afe918a46d044315dbe3410f1f2a7 outParamApprovalList = new RL_875afe918a46d044315dbe3410f1f2a7();

public lcoGetSpecialApprovalLevels() {
}
}
/// <summary>
/// Action <code>GetSpecialApprovalLevels</code> that represents the Service Studio action
///  <code>GetSpecialApprovalLevels</code> <p> Description: </p>
/// </summary>
public async Task<RL_875afe918a46d044315dbe3410f1f2a7> DataActionGetSpecialApprovalLevels(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_875afe918a46d044315dbe3410f1f2a7 outParamApprovalList = default;
lcoGetSpecialApprovalLevels result = new lcoGetSpecialApprovalLevels();
lcvGetSpecialApprovalLevels localVars = new lcvGetSpecialApprovalLevels();
ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSpecialApprovalLevels", "dfe8f0fe-3621-4fa4-b660-fd5118e960b0"))
using (activitySource.CreateScreenDataActionActivity("Wb_InvoicesEntra_Historic", "GetSpecialApprovalLevels")){
// Query QueryGetLevels
cancellationToken.ThrowIfCancellationRequested();
int QueryGetLevels_maxRecords = 0;
int QueryGetLevels_startIndex = 0;(localVars.queryResGetLevels_outParamList,localVars.queryResGetLevels_outParamCount) = await FuncDataActionGetSpecialApprovalLevels.QueryGetLevels(requestContext,QueryGetLevels_maxRecords,QueryGetLevels_startIndex,IterationMultiplicity.Multiple,ScreenDataSetGetInvoiceById.List.CurrentRec.ssENInvoiceApproval.ssId,cancellationToken);

// ApprovalList = GetLevels.List
result.outParamApprovalList=(await RL_875afe918a46d044315dbe3410f1f2a7.ConvertAsync(localVars.queryResGetLevels_outParamList, new RL_875afe918a46d044315dbe3410f1f2a7(), async (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 source, ST_3c480a6d17a69eed60b057b7ed343a1dStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamApprovalList = result.outParamApprovalList;
} // inner-finally
RETURN_STATEMENT:
return outParamApprovalList;
}


    public static class FuncDataActionGetEntraUserManagerList {

private static async Task<RC_6872064329fe950ffeb72169f6f6f25b> datasetGetLastApproverReadDbAsync(RC_6872064329fe950ffeb72169f6f6f25b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
rec.ssDoNotEntraSearch = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceApprovalLevelApplicationRoleDoNotEntraSearchUserExtensionUser_Extended_InternalRecord.DoNotEntraSearch", false);
return rec;
}
// Query Function "GetLastApprover" 8QdNYLnkGUO_9221Uq3WdQ of Action "GetEntraUserManagerList"
public static async Task<(RL_22118fef24990e91082f637f0240b25e,long)> datasetGetLastApprover(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_InvoicesEntra_Historic.GetEntraUserManagerList.GetLastApprover", "604d07f1-e4b9-4319-bff7-6db552add675");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_InvoicesEntra_Historic.GetEntraUserManagerList.GetLastApprover", "604d07f1-e4b9-4319-bff7-6db552add675", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.dLJ_Va3Nn0S8Uo2+V9xO1w/DataActions.a1c4jP0qTkq3liU7bVOKPA/NodesNotShownInESpaceTree.8QdNYLnkGUO_9221Uq3WdQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole57\".\"id\" o0, \"enapplicationrole57\".\"code\" o1, \"enapplicationrole57\".\"name\" o2, \"enapplicationrole57\".\"isactive\" o3, \"enapplicationrole57\".\"isareausuaria\" o4, \"enapplicationrole57\".\"isareacxp\" o5, \"enapplicationrole57\".\"canbulkapprovefolios\" o6, \"eninvoice122\".\"id\" o7, \"eninvoice122\".\"name\" o8, \"eninvoice122\".\"requisitionid\" o9, \"eninvoice122\".\"folioid\" o10, \"eninvoice122\".\"ordermainid\" o11, \"eninvoice122\".\"cfditypeid\" o12, trim_scale(\"eninvoice122\".\"totalamount\"::numeric) o13, \"eninvoice122\".\"currency\" o14, \"eninvoice122\".\"invoicestatusid\" o15, \"eninvoice122\".\"accountingdatetime\" o16, \"eninvoice122\".\"paymentdatetime\" o17, \"eninvoice122\".\"createdon\" o18, \"eninvoice122\".\"createdby\" o19, \"eninvoice122\".\"updatedon\" o20, \"eninvoice122\".\"updatedby\" o21, \"eninvoice122\".\"submittedon\" o22, \"eninvoice122\".\"isnewversion\" o23, \"eninvoice122\".\"id_poliza\" o24, \"eninvoice122\".\"id_poliza_sap\" o25, \"eninvoice122\".\"doc51\" o26, \"eninvoice122\".\"accountingerror\" o27, \"eninvoice122\".\"orderaccconceptsid\" o28, trim_scale(\"eninvoice122\".\"amortization\"::numeric) o29, \"eninvoice122\".\"creditnoteinvoiceid\" o30, \"eninvoiceapproval37\".\"id\" o31, \"eninvoiceapproval37\".\"invoiceid\" o32, \"eninvoiceapproval37\".\"aprovalprocessid\" o33, \"eninvoiceapproval37\".\"processtypecode\" o34, \"eninvoiceapproval37\".\"approvalprocessversion\" o35, \"eninvoiceapproval37\".\"currentlevel\" o36, \"eninvoiceapproval37\".\"maxlevel\" o37, \"eninvoiceapproval37\".\"startedon\" o38, \"eninvoiceapproval37\".\"finishedon\" o39, \"eninvoiceapproval37\".\"hasstartedaccounting\" o40, \"eninvoiceapprovallevel36\".\"id\" o41, \"eninvoiceapprovallevel36\".\"invoiceapprovalid\" o42, \"eninvoiceapprovallevel36\".\"levelnumber\" o43, \"eninvoiceapprovallevel36\".\"assignedto\" o44, \"eninvoiceapprovallevel36\".\"applicationroleid\" o45, \"eninvoiceapprovallevel36\".\"entrajobtitle\" o46, \"eninvoiceapprovallevel36\".\"departmentid\" o47, \"eninvoiceapprovallevel36\".\"managementid\" o48, \"eninvoiceapprovallevel36\".\"subdirectionid\" o49, \"eninvoiceapprovallevel36\".\"entraroleid\" o50, \"eninvoiceapprovallevel36\".\"approvalstatusid\" o51, \"eninvoiceapprovallevel36\".\"canbefirstapprover\" o52, \"eninvoiceapprovallevel36\".\"selectsnextapprover\" o53, \"eninvoiceapprovallevel36\".\"selectsfirstapprover\" o54, \"eninvoiceapprovallevel36\".\"isaccounting\" o55, \"eninvoiceapprovallevel36\".\"isstartaccounting\" o56, \"eninvoiceapprovallevel36\".\"approvedby\" o57, \"eninvoiceapprovallevel36\".\"approvedon\" o58, \"eninvoiceapprovallevel36\".\"requesttomodifyby\" o59, \"eninvoiceapprovallevel36\".\"requesttomodifyon\" o60, \"eninvoiceapprovallevel36\".\"canceledby\" o61, \"eninvoiceapprovallevel36\".\"canceledon\" o62, \"eninvoiceapprovallevel36\".\"needscontract_deprec\" o63, \"eninvoiceapprovallevel36\".\"isreassigned\" o64, \"eninvoiceapprovallevel36\".\"issubstitutefor\" o65, \"enuser169\".\"id\" o66, \"enuser169\".\"name\" o67, \"enuser169\".\"email\" o68, \"enuser169\".\"photourl\" o69, \"enuser169\".\"username\" o70, \"enuser_extended_internal104\".\"id\" o71, \"enuser_extended_internal104\".\"employeenumber\" o72, \"enuser_extended_internal104\".\"managedby\" o73, \"enuser_extended_internal104\".\"regionid\" o74, \"enuser_extended_internal104\".\"departmentid\" o75, \"enuser_extended_internal104\".\"managementid\" o76, \"enuser_extended_internal104\".\"subdirectionid\" o77, \"enuser_extended_internal104\".\"telceldirectionid\" o78, \"enuser_extended_internal104\".\"city\" o79, \"enuser_extended_internal104\".\"jobtitle\" o80, \"enuser_extended_internal104\".\"entraroleid\" o81, \"enuser_extended_internal104\".\"onpremisesdistinguishedname\" o82, \"enuser_extended_internal104\".\"hasrolesassigned\" o83, \"enuser_extended_internal104\".\"lastsync\" o84, \"enuser_extended_internal104\".\"createdby\" o85, \"enuser_extended_internal104\".\"createdon\" o86, \"enuser_extended_internal104\".\"updatedby\" o87, \"enuser_extended_internal104\".\"updatedon\" o88, \"enuser_extended_internal104\".\"entraid\" o89, \"enuser_extended_internal104\".\"telceldireccion\" o90, NULL o91, \"enuserextension71\".\"correspondentexternalemail\" o92, NULL o93, (CASE WHEN (((Upper(\"enapplicationrole57\".\"code\")) = 'GERENTE_CXP') OR ((Upper(\"enapplicationrole57\".\"code\")) = 'DIRECTOR_REGIONAL')) THEN 1 ELSE 0 END) \"donotentrasearch\"");
fromBuilder.Append(" FROM (((((({InvoiceApproval} \"eninvoiceapproval37\" Left JOIN {Invoice} \"eninvoice122\" ON (\"eninvoiceapproval37\".\"invoiceid\" = \"eninvoice122\".\"id\"))  Right JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel36\" ON (\"eninvoiceapprovallevel36\".\"invoiceapprovalid\" = \"eninvoiceapproval37\".\"id\"))  Left JOIN {User} \"enuser169\" ON (\"eninvoiceapprovallevel36\".\"assignedto\" = \"enuser169\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal104\" ON (\"enuser169\".\"id\" = \"enuser_extended_internal104\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole57\" ON (\"eninvoiceapprovallevel36\".\"applicationroleid\" = \"enapplicationrole57\".\"id\"))  Left JOIN {UserExtension} \"enuserextension71\" ON (\"enuser169\".\"id\" = \"enuserextension71\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice122\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice122\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice122\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel36\".\"levelnumber\" DESC ");
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
RL_22118fef24990e91082f637f0240b25e outParamList = new RL_22118fef24990e91082f637f0240b25e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {true, false, true});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetEntraUserManagerList.GetLastApprover.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_22118fef24990e91082f637f0240b25e _tmp = new RL_22118fef24990e91082f637f0240b25e();
_tmp.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetEntraUserManagerList.GetLastApprover.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_22118fef24990e91082f637f0240b25e)_tmp;
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
public static class FuncDataActionGetSpecialApprovalLevels {

// Query Function "GetLevels" 4IY+X+apB068I39UWxWbhw of Action "GetSpecialApprovalLevels"
public static async Task<(RL_be474dab9f20512d09fda3e1e99c2e25,long)> QueryGetLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApprovalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("d_Invoices.Wb_InvoicesEntra_Historic.GetSpecialApprovalLevels.GetLevels", "5f3e86e0-a9e6-4e07-bc23-7f545b159b87");
using var queryActivity = activitySource.CreateSqlQueryActivity("d_Invoices.Wb_InvoicesEntra_Historic.GetSpecialApprovalLevels.GetLevels", "5f3e86e0-a9e6-4e07-bc23-7f545b159b87", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityInvoiceApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("InvoiceApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
sqlCmd.CreateParameter("@qpinInvoiceApprovalId", DbType.Int64, qpinInvoiceApprovalId);
string sql = "";
string advSql = "SELECT  \n    RAL.\"levelnumber\", \n    RAL.\"approvalstatusid\", \n    COALESCE(U.\"name\", 'Sin asignación') AS \"name\", \n    STRING_AGG( \n        COALESCE(NULLIF(RAL.\"entrajobtitle\", ''), 'Sin puesto'),  \n        ' | '  \n        ORDER BY RAL.\"entrajobtitle\" \n    ) AS \"combinedjobtitles\", \n    AR.\"name\", \n    RAL.\"isreassigned\", \n    RAL.\"issubstitutefor\" \nFROM  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityInvoiceApprovalLevel,"") + " AS RAL \nLEFT JOIN  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " AS U ON RAL.\"assignedto\" = U.\"id\" \nLEFT JOIN \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " AS AR ON AR.\"id\" = RAL.\"applicationroleid\" \nWHERE  \n    RAL.\"invoiceapprovalid\" = @qpinInvoiceApprovalId \nGROUP BY  \n    RAL.\"levelnumber\",  \n    RAL.\"approvalstatusid\", \n    U.\"name\", \n    AR.\"name\", \n    RAL.\"isreassigned\", \n    RAL.\"issubstitutefor\" \nORDER BY  \n    RAL.\"levelnumber\" ASC;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_be474dab9f20512d09fda3e1e99c2e25 outParamList = new RL_be474dab9f20512d09fda3e1e99c2e25();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetSpecialApprovalLevels.GetLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_be474dab9f20512d09fda3e1e99c2e25 _tmp = new RL_be474dab9f20512d09fda3e1e99c2e25();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoicesEntra_Historic.GetSpecialApprovalLevels.GetLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_be474dab9f20512d09fda3e1e99c2e25)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetLevels in GetSpecialApprovalLevels in Wb_InvoicesEntra_Historic in d_Invoices in ConectaProveedores (SELECT       RAL.[LevelNumber],      RAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(RAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY RAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  FROM       {InvoiceApprovalLevel} AS RAL  LEFT JOIN       {User} AS U ON RAL.[AssignedTo] = U.[Id]  LEFT JOIN      {ApplicationRole} AS AR ON AR.[Id] = RAL.[ApplicationRoleId]  WHERE       RAL.[InvoiceApprovalId] = @InvoiceApprovalId  GROUP BY       RAL.[LevelNumber],       RAL.[ApprovalStatusId],      U.[Name],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  ORDER BY       RAL.[LevelNumber] ASC;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetLevels in GetSpecialApprovalLevels in Wb_InvoicesEntra_Historic in d_Invoices in ConectaProveedores (SELECT       RAL.[LevelNumber],      RAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(RAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY RAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  FROM       {InvoiceApprovalLevel} AS RAL  LEFT JOIN       {User} AS U ON RAL.[AssignedTo] = U.[Id]  LEFT JOIN      {ApplicationRole} AS AR ON AR.[Id] = RAL.[ApplicationRoleId]  WHERE       RAL.[InvoiceApprovalId] = @InvoiceApprovalId  GROUP BY       RAL.[LevelNumber],       RAL.[ApprovalStatusId],      U.[Name],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  ORDER BY       RAL.[LevelNumber] ASC;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetLevels in GetSpecialApprovalLevels in Wb_InvoicesEntra_Historic in d_Invoices in ConectaProveedores (SELECT       RAL.[LevelNumber],      RAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(RAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY RAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  FROM       {InvoiceApprovalLevel} AS RAL  LEFT JOIN       {User} AS U ON RAL.[AssignedTo] = U.[Id]  LEFT JOIN      {ApplicationRole} AS AR ON AR.[Id] = RAL.[ApplicationRoleId]  WHERE       RAL.[InvoiceApprovalId] = @InvoiceApprovalId  GROUP BY       RAL.[LevelNumber],       RAL.[ApprovalStatusId],      U.[Name],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  ORDER BY       RAL.[LevelNumber] ASC;): " + aqExcep.Message));
}
}
}
}


}
