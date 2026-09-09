using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel).Namespace);

    public long inParami_RequisitionId;
public DateTime inParami_RefreshWB;
public RL_4af3045b114dbc57d1481fed5aceb93a varLcList;
public AggregateRecord<RL_7c4c6843d8ddca100085fd31262966c6> ScreenDataSetGetRequisitionsApprovalLevels;
public AggregateRecord<RL_72dedb526963c58e79ee56edd8352664> ScreenDataSetGetRequisitionById;
public ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetEntraUserManagerList_Model varLcGetEntraUserManagerList;
public ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetSpecialApprovalLevels_Model varLcGetSpecialApprovalLevels;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel(long inParami_RequisitionId, DateTime inParami_RefreshWB, RL_4af3045b114dbc57d1481fed5aceb93a varLcList, AggregateRecord<RL_7c4c6843d8ddca100085fd31262966c6> ScreenDataSetGetRequisitionsApprovalLevels, AggregateRecord<RL_72dedb526963c58e79ee56edd8352664> ScreenDataSetGetRequisitionById, ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetEntraUserManagerList_Model varLcGetEntraUserManagerList, ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_DataActionGetSpecialApprovalLevels_Model varLcGetSpecialApprovalLevels, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_RequisitionId", "i_RefreshWB", "List", "GetRequisitionsApprovalLevels", "GetRequisitionById", "GetEntraUserManagerList", "GetSpecialApprovalLevels", "ClientVars"}, new string[] {"inParami_RequisitionId", "inParami_RefreshWB", "varLcList", "ScreenDataSetGetRequisitionsApprovalLevels", "ScreenDataSetGetRequisitionById", "varLcGetEntraUserManagerList", "varLcGetSpecialApprovalLevels", "clientVariables"});
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RefreshWB = inParami_RefreshWB;
this.varLcList = varLcList;
this.ScreenDataSetGetRequisitionsApprovalLevels = ScreenDataSetGetRequisitionsApprovalLevels;
this.ScreenDataSetGetRequisitionById = ScreenDataSetGetRequisitionById;
this.varLcGetEntraUserManagerList = varLcGetEntraUserManagerList;
this.varLcGetSpecialApprovalLevels = varLcGetSpecialApprovalLevels;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_8b89674084a8b334109c261c1cd156c4> datasetGetRequisitionsApprovalLevelsReadDbAsync(RC_8b89674084a8b334109c261c1cd156c4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENRequisitionComment_Cancel.Read( r, ref index);
rec.ssENRequisitionComment_Modify.Read( r, ref index);
rec.ssENUser_Approved.Read( r, ref index);
rec.ssENUser_Assigned.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionsApprovalLevels" k1SRa0D_YE6n4eciB6b8SQ of Action "Wb_RequisitionEntra_Historic"
public static async Task<(RL_7c4c6843d8ddca100085fd31262966c6,long)> datasetGetRequisitionsApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpreRequisitionStatusId,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionsApprovalLevels", "6b915493-ff40-4e60-a7e1-e72207a6fc49");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionEntra_Historic","c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionsApprovalLevels");
// Query Iterations: Multiple
// Refresh Query zRG8BPEBSkq+DrmF1yuVRg Iterations: Multiple
// Refresh Query 0y0m6327UUyXqAJ2j8bvWw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.xL6YpI_9NEibZA4UdFYx7w/ScreenDataSets.k1SRa0D_YE6n4eciB6b8SQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole61\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enrequisition111\".\"requisitionstatusid\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, \"enrequisitionapprovallevel24\".\"entrajobtitle\" o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enrequisitionapprovallevel24\".\"approvalstatusid\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, \"enrequisitionapprovallevel24\".\"approveasareausuaria\" o97, NULL o98, \"enrequisitionapprovallevel24\".\"isreassigned\" o99, \"enrequisitionapprovallevel24\".\"issubstitutefor\" o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, \"enrequisitioncomment_cancel\".\"message\" o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, \"enrequisitioncomment_modify\".\"message\" o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, \"enuser_assigned\".\"name\" o123, NULL o124, NULL o125, NULL o126");
fromBuilder.Append(" FROM ((((((({RequisitionApproval} \"enrequisitionapproval28\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel24\" ON (\"enrequisitionapproval28\".\"id\" = \"enrequisitionapprovallevel24\".\"requisitionapprovalid\"))  Left JOIN {ApplicationRole} \"enapplicationrole61\" ON (\"enrequisitionapprovallevel24\".\"applicationroleid\" = \"enapplicationrole61\".\"id\"))  Left JOIN {RequisitionComment} \"enrequisitioncomment_cancel\" ON ((\"enrequisitionapprovallevel24\".\"id\" = \"enrequisitioncomment_cancel\".\"requisitionapprovallevelid\") AND ");
if (qpreRequisitionStatusId != 0) {
fromBuilder.Append("((");
fromBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"))).ssId);
fromBuilder.Append(" = @qpreRequisitionStatusId) AND (");
fromBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"))).ssId);
fromBuilder.Append(" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionStatusId", DbType.Int32, qpreRequisitionStatusId);
} else {
fromBuilder.Append("(");
fromBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"))).ssId);
fromBuilder.Append(" IS NULL)");
}
fromBuilder.Append("))  Left JOIN {RequisitionComment} \"enrequisitioncomment_modify\" ON ((\"enrequisitionapprovallevel24\".\"id\" = \"enrequisitioncomment_modify\".\"requisitionapprovallevelid\") AND (\"enrequisitionapprovallevel24\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId);
fromBuilder.Append(")))  Left JOIN {User} \"enuser_assigned\" ON ((\"enrequisitionapprovallevel24\".\"assignedto\" IS NOT NULL) AND (\"enrequisitionapprovallevel24\".\"assignedto\" = \"enuser_assigned\".\"id\")))  Left JOIN {User} \"enuser_approved\" ON (((CASE WHEN (\"enrequisitionapprovallevel24\".\"approvedby\" IS NOT NULL) THEN (CASE WHEN (\"enrequisitionapprovallevel24\".\"approvedby\" = \"enuser_approved\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enrequisitionapprovallevel24\".\"canceledby\" IS NOT NULL) THEN (CASE WHEN (\"enrequisitionapprovallevel24\".\"canceledby\" = \"enuser_approved\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enrequisitionapprovallevel24\".\"requesttomodifyby\" IS NOT NULL) THEN (CASE WHEN (\"enrequisitionapprovallevel24\".\"requesttomodifyby\" = \"enuser_approved\".\"id\") THEN 1 ELSE 0 END) ELSE (CASE WHEN (\"enrequisitionapprovallevel24\".\"assignedto\" = \"enuser_approved\".\"id\") THEN 1 ELSE 0 END) END) END) END) = 1) AND (((\"enrequisitionapprovallevel24\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
fromBuilder.Append(") OR (\"enrequisitionapprovallevel24\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId);
fromBuilder.Append(")) OR (\"enrequisitionapprovallevel24\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId);
fromBuilder.Append("))))  Left JOIN {Requisition} \"enrequisition111\" ON (\"enrequisitionapproval28\".\"requisitionid\" = \"enrequisition111\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval28\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval28\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval28\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1)");
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel24\".\"levelnumber\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
RL_7c4c6843d8ddca100085fd31262966c6 outParamList = new RL_7c4c6843d8ddca100085fd31262966c6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, false, true, false, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, false});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, false});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionsApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7c4c6843d8ddca100085fd31262966c6 _tmp = new RL_7c4c6843d8ddca100085fd31262966c6();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionsApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7c4c6843d8ddca100085fd31262966c6)_tmp;
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

private static async Task<RC_8ada9c8e65e1e09d1e1af032494a5fa8> datasetGetRequisitionByIdReadDbAsync(RC_8ada9c8e65e1e09d1e1af032494a5fa8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionById" ATUhlSjJIE+1YSK1FSPnJQ of Action "Wb_RequisitionEntra_Historic"
public static async Task<(RL_72dedb526963c58e79ee56edd8352664,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionById", "95213501-c928-4f20-b561-22b51523e725");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_RequisitionEntra_Historic","c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionById");
// Query Iterations: Never
// Refresh Query fl+_DqrM_Uyx_YnK1nsakw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.xL6YpI_9NEibZA4UdFYx7w/ScreenDataSets.ATUhlSjJIE+1YSK1FSPnJQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enapprovalprocess45\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enrequisition112\".\"requisitionstatusid\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, \"enrequisitionapproval29\".\"id\" o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition112\" Left JOIN {RequisitionApproval} \"enrequisitionapproval29\" ON (\"enrequisition112\".\"id\" = \"enrequisitionapproval29\".\"requisitionid\"))  Left JOIN {ApprovalProcess} \"enapprovalprocess45\" ON (\"enrequisitionapproval29\".\"aprovalprocessid\" = \"enapprovalprocess45\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition112\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition112\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition112\".\"id\" IS NULL)");
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
RL_72dedb526963c58e79ee56edd8352664 outParamList = new RL_72dedb526963c58e79ee56edd8352664();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_72dedb526963c58e79ee56edd8352664 _tmp = new RL_72dedb526963c58e79ee56edd8352664();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_72dedb526963c58e79ee56edd8352664)_tmp;
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
public Actions.lcoGetReqEntraManagers resGetReqEntraManagers =  new Actions.lcoGetReqEntraManagers();
public RL_f3017756521ae7cf1942cba9952a490e queryResGetLastApprover_outParamList = new RL_f3017756521ae7cf1942cba9952a490e();
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
ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetEntraUserManagerList", "1266899d-86f2-41ac-b894-1b1c081d0070"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionEntra_Historic", "GetEntraUserManagerList")){
if((!((((ScreenDataSetGetRequisitionsApprovalLevels.List.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId)||(ScreenDataSetGetRequisitionsApprovalLevels.List.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("5K2SyCJmtU+vkuFEbRmA_g"))).ssId))||(ScreenDataSetGetRequisitionsApprovalLevels.List.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("1_RsQxcxokySProxyWT5mw"))).ssId))))) {
// Query datasetGetLastApprover
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLastApprover_maxRecords = 1;
if (datasetGetLastApprover_maxRecords < 1) datasetGetLastApprover_maxRecords = 1;
int datasetGetLastApprover_startIndex = 0;(localVars.queryResGetLastApprover_outParamList,localVars.queryResGetLastApprover_outParamCount) = await FuncDataActionGetEntraUserManagerList.datasetGetLastApprover(requestContext,datasetGetLastApprover_maxRecords,datasetGetLastApprover_startIndex,IterationMultiplicity.Single,inParami_RequisitionId,cancellationToken);

if((!((localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo==BuiltInFunction.NullTextIdentifier ())))) {
// GetReqEntraManagers
localVars.resGetReqEntraManagers.outParamo_ListOut = await Actions.ActionGetReqEntraManagers(requestContext,(((localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENUser.ssEmail)),localVars.queryResGetLastApprover_outParamList.CurrentRec.ssENRequisitionApproval,(await RL_ea7571189236cea4825c6d506aa74c2b.ConvertAsync(localVars.queryResGetLastApprover_outParamList, new RL_ea7571189236cea4825c6d506aa74c2b(), async (RC_24dd7a73eff50484286a3caaeb8033d4 source, RC_569a299175d95eeb71a4b753c517c619 target, CancellationToken cancellationToken) => {
target.ssENApplicationRole = source.ssENApplicationRole;
target.ssDoNotEntraSearch = source.ssDoNotEntraSearch;
target.ssENRequisition = source.ssENRequisition;
target.ssENRequisitionApproval = source.ssENRequisitionApproval;
target.ssENRequisitionApprovalLevel = source.ssENRequisitionApprovalLevel;
target.ssENUser = source.ssENUser;
target.ssENUser_Extended_Internal = source.ssENUser_Extended_Internal;
return target;
}, cancellationToken)),cancellationToken);

// UserList = GetReqEntraManagers.o_ListOut
result.outParamUserList=(await RL_4af3045b114dbc57d1481fed5aceb93a.ConvertAsync(localVars.resGetReqEntraManagers.outParamo_ListOut, new RL_4af3045b114dbc57d1481fed5aceb93a(), async (RC_2dabb9c9cbdbc6ba6572314572d54c39 source, ST_34625f5643caa3d12448dcec7dd4c7d3Structure target, CancellationToken cancellationToken) => {
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
ConectaProveedores_c_Requisitions_Wb_RequisitionEntra_Historic_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSpecialApprovalLevels", "6dc7d0e0-fcf6-44ab-bdff-aefe37271514"))
using (activitySource.CreateScreenDataActionActivity("Wb_RequisitionEntra_Historic", "GetSpecialApprovalLevels")){
// Query QueryGetLevels
cancellationToken.ThrowIfCancellationRequested();
int QueryGetLevels_maxRecords = 0;
int QueryGetLevels_startIndex = 0;(localVars.queryResGetLevels_outParamList,localVars.queryResGetLevels_outParamCount) = await FuncDataActionGetSpecialApprovalLevels.QueryGetLevels(requestContext,QueryGetLevels_maxRecords,QueryGetLevels_startIndex,IterationMultiplicity.Multiple,ScreenDataSetGetRequisitionById.List.CurrentRec.ssENRequisitionApproval.ssId,cancellationToken);

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

private static async Task<RC_24dd7a73eff50484286a3caaeb8033d4> datasetGetLastApproverReadDbAsync(RC_24dd7a73eff50484286a3caaeb8033d4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
rec.ssDoNotEntraSearch = r.ReadBoolean(index++, "UserRequisitionRequisitionApprovalLevelRequisitionApprovalApplicationRoleDoNotEntraSearchUserExtensionUser_Extended_InternalRecord.DoNotEntraSearch", false);
return rec;
}
// Query Function "GetLastApprover" oXTCreAOyEGCITaZViSamQ of Action "GetEntraUserManagerList"
public static async Task<(RL_f3017756521ae7cf1942cba9952a490e,long)> datasetGetLastApprover(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.Wb_RequisitionEntra_Historic.GetEntraUserManagerList.GetLastApprover", "adc274a1-0ee0-41c8-8221-369956249a99");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.Wb_RequisitionEntra_Historic.GetEntraUserManagerList.GetLastApprover", "adc274a1-0ee0-41c8-8221-369956249a99", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.xL6YpI_9NEibZA4UdFYx7w/DataActions.nYlmEvKGrEG4lBscCB0AcA/NodesNotShownInESpaceTree.oXTCreAOyEGCITaZViSamQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole62\".\"id\" o0, \"enapplicationrole62\".\"code\" o1, \"enapplicationrole62\".\"name\" o2, \"enapplicationrole62\".\"isactive\" o3, \"enapplicationrole62\".\"isareausuaria\" o4, \"enapplicationrole62\".\"isareacxp\" o5, \"enapplicationrole62\".\"canbulkapprovefolios\" o6, \"enrequisition113\".\"id\" o7, \"enrequisition113\".\"name\" o8, \"enrequisition113\".\"counter\" o9, \"enrequisition113\".\"requisitionstatusid\" o10, \"enrequisition113\".\"supplierid\" o11, \"enrequisition113\".\"regionid\" o12, \"enrequisition113\".\"accountingregionid\" o13, \"enrequisition113\".\"applicantid\" o14, \"enrequisition113\".\"maxdatefinishcapture\" o15, \"enrequisition113\".\"projectassetserviceid\" o16, \"enrequisition113\".\"projectassetservice\" o17, \"enrequisition113\".\"projectdescription\" o18, \"enrequisition113\".\"frequencyid\" o19, \"enrequisition113\".\"issustainability\" o20, \"enrequisition113\".\"sustainabilityid\" o21, \"enrequisition113\".\"businessvaluecategoryid\" o22, \"enrequisition113\".\"businessvaluesubcategoryid\" o23, trim_scale(\"enrequisition113\".\"totalamount\"::numeric) o24, \"enrequisition113\".\"currencyid\" o25, \"enrequisition113\".\"distributionid\" o26, \"enrequisition113\".\"costcenterid\" o27, \"enrequisition113\".\"hascontract\" o28, \"enrequisition113\".\"iscontractpending\" o29, \"enrequisition113\".\"hasdeposit\" o30, \"enrequisition113\".\"hasinsurance\" o31, \"enrequisition113\".\"hasadvancepayment\" o32, \"enrequisition113\".\"accountingservicetypeid_depr\" o33, \"enrequisition113\".\"servicedescription_deprec\" o34, \"enrequisition113\".\"invoiceusageid_deprec\" o35, \"enrequisition113\".\"serviceformatid\" o36, \"enrequisition113\".\"companyid\" o37, trim_scale(\"enrequisition113\".\"retentionrate\"::numeric) o38, trim_scale(\"enrequisition113\".\"negotiatedexchangerate\"::numeric) o39, \"enrequisition113\".\"paymentmethodid\" o40, \"enrequisition113\".\"paymenttermsid\" o41, \"enrequisition113\".\"isautomaticaccounting\" o42, \"enrequisition113\".\"createdby\" o43, \"enrequisition113\".\"createdon\" o44, \"enrequisition113\".\"updatedon\" o45, \"enrequisition113\".\"updatedby\" o46, \"enrequisition113\".\"createdbyapplicationrole\" o47, \"enrequisition113\".\"dateofcommitment\" o48, \"enrequisition113\".\"hascontractfileuploaded\" o49, \"enrequisition113\".\"hasupdateddateofcommitment\" o50, \"enrequisition113\".\"submittedon\" o51, \"enrequisition113\".\"isdonation\" o52, \"enrequisition113\".\"advwithoutinvoice\" o53, \"enrequisition113\".\"wasadvwithoutinvoice\" o54, \"enrequisition113\".\"isadvanced\" o55, \"enrequisition113\".\"documenttypeid\" o56, \"enrequisition113\".\"iscreatedbyanassistente\" o57, \"enrequisition113\".\"telceldirectionid\" o58, \"enrequisition113\".\"hasmultiupload\" o59, \"enrequisition113\".\"accountingdate\" o60, \"enrequisition113\".\"paymentoptionsid\" o61, \"enrequisition113\".\"paymentwaysid\" o62, \"enrequisition113\".\"buydocnumber\" o63, \"enrequisition113\".\"buydocposition\" o64, \"enrequisitionapproval30\".\"id\" o65, \"enrequisitionapproval30\".\"requisitionid\" o66, \"enrequisitionapproval30\".\"aprovalprocessid\" o67, \"enrequisitionapproval30\".\"processtypecode\" o68, \"enrequisitionapproval30\".\"approvalprocessversion\" o69, \"enrequisitionapproval30\".\"currentlevel\" o70, \"enrequisitionapproval30\".\"maxlevel\" o71, \"enrequisitionapproval30\".\"startedon\" o72, \"enrequisitionapproval30\".\"finishedon\" o73, \"enrequisitionapproval30\".\"hasstartedaccounting\" o74, \"enrequisitionapprovallevel25\".\"id\" o75, \"enrequisitionapprovallevel25\".\"requisitionapprovalid\" o76, \"enrequisitionapprovallevel25\".\"levelnumber\" o77, \"enrequisitionapprovallevel25\".\"applicationroleid\" o78, \"enrequisitionapprovallevel25\".\"entrajobtitle\" o79, \"enrequisitionapprovallevel25\".\"departmentid\" o80, \"enrequisitionapprovallevel25\".\"managementid\" o81, \"enrequisitionapprovallevel25\".\"subdirectionid\" o82, \"enrequisitionapprovallevel25\".\"entraroleid\" o83, \"enrequisitionapprovallevel25\".\"entrausername\" o84, \"enrequisitionapprovallevel25\".\"assignedto\" o85, \"enrequisitionapprovallevel25\".\"needscontract\" o86, \"enrequisitionapprovallevel25\".\"approvalstatusid\" o87, \"enrequisitionapprovallevel25\".\"approvedby\" o88, \"enrequisitionapprovallevel25\".\"approvedon\" o89, \"enrequisitionapprovallevel25\".\"requesttomodifyby\" o90, \"enrequisitionapprovallevel25\".\"requesttomodifyon\" o91, \"enrequisitionapprovallevel25\".\"canceledby\" o92, \"enrequisitionapprovallevel25\".\"canceledon_deprec\" o93, \"enrequisitionapprovallevel25\".\"isaccounting\" o94, \"enrequisitionapprovallevel25\".\"isstartaccounting\" o95, \"enrequisitionapprovallevel25\".\"canceledon_\" o96, \"enrequisitionapprovallevel25\".\"approveasareausuaria\" o97, \"enrequisitionapprovallevel25\".\"ismandatory\" o98, \"enrequisitionapprovallevel25\".\"isreassigned\" o99, \"enrequisitionapprovallevel25\".\"issubstitutefor\" o100, \"enuser182\".\"id\" o101, \"enuser182\".\"name\" o102, \"enuser182\".\"email\" o103, \"enuser182\".\"photourl\" o104, \"enuser182\".\"username\" o105, \"enuser_extended_internal110\".\"id\" o106, \"enuser_extended_internal110\".\"employeenumber\" o107, \"enuser_extended_internal110\".\"managedby\" o108, \"enuser_extended_internal110\".\"regionid\" o109, \"enuser_extended_internal110\".\"departmentid\" o110, \"enuser_extended_internal110\".\"managementid\" o111, \"enuser_extended_internal110\".\"subdirectionid\" o112, \"enuser_extended_internal110\".\"telceldirectionid\" o113, \"enuser_extended_internal110\".\"city\" o114, \"enuser_extended_internal110\".\"jobtitle\" o115, \"enuser_extended_internal110\".\"entraroleid\" o116, \"enuser_extended_internal110\".\"onpremisesdistinguishedname\" o117, \"enuser_extended_internal110\".\"hasrolesassigned\" o118, \"enuser_extended_internal110\".\"lastsync\" o119, \"enuser_extended_internal110\".\"createdby\" o120, \"enuser_extended_internal110\".\"createdon\" o121, \"enuser_extended_internal110\".\"updatedby\" o122, \"enuser_extended_internal110\".\"updatedon\" o123, \"enuser_extended_internal110\".\"entraid\" o124, \"enuser_extended_internal110\".\"telceldireccion\" o125, NULL o126, \"enuserextension74\".\"correspondentexternalemail\" o127, NULL o128, (CASE WHEN (((Upper(\"enapplicationrole62\".\"code\")) = 'GERENTE_CXP') OR ((Upper(\"enapplicationrole62\".\"code\")) = 'DIRECTOR_REGIONAL')) THEN 1 ELSE 0 END) \"donotentrasearch\"");
fromBuilder.Append(" FROM (((((({RequisitionApprovalLevel} \"enrequisitionapprovallevel25\" Left JOIN {RequisitionApproval} \"enrequisitionapproval30\" ON (\"enrequisitionapprovallevel25\".\"requisitionapprovalid\" = \"enrequisitionapproval30\".\"id\"))  Left JOIN {Requisition} \"enrequisition113\" ON (\"enrequisitionapproval30\".\"requisitionid\" = \"enrequisition113\".\"id\"))  Left JOIN {User} \"enuser182\" ON (\"enrequisitionapprovallevel25\".\"assignedto\" = \"enuser182\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal110\" ON (\"enuser182\".\"id\" = \"enuser_extended_internal110\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole62\" ON (\"enrequisitionapprovallevel25\".\"applicationroleid\" = \"enapplicationrole62\".\"id\"))  Left JOIN {UserExtension} \"enuserextension74\" ON (\"enuser182\".\"id\" = \"enuserextension74\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition113\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition113\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition113\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel25\".\"levelnumber\" DESC ");
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
RL_f3017756521ae7cf1942cba9952a490e outParamList = new RL_f3017756521ae7cf1942cba9952a490e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {true, false, true});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetEntraUserManagerList.GetLastApprover.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f3017756521ae7cf1942cba9952a490e _tmp = new RL_f3017756521ae7cf1942cba9952a490e();
_tmp.AlternateReadDbMethodAsync = datasetGetLastApproverReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetEntraUserManagerList.GetLastApprover.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f3017756521ae7cf1942cba9952a490e)_tmp;
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

// Query Function "GetLevels" 7VyHuTc3J0uDm8rPEAedDw of Action "GetSpecialApprovalLevels"
public static async Task<(RL_be474dab9f20512d09fda3e1e99c2e25,long)> QueryGetLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApprovalId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.Wb_RequisitionEntra_Historic.GetSpecialApprovalLevels.GetLevels", "b9875ced-3737-4b27-839b-cacf10079d0f");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.Wb_RequisitionEntra_Historic.GetSpecialApprovalLevels.GetLevels", "b9875ced-3737-4b27-839b-cacf10079d0f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
sqlCmd.CreateParameter("@qpreRequisitionApprovalId", DbType.Int64, qpreRequisitionApprovalId);
string sql = "";
string advSql = "SELECT  \n    RAL.\"levelnumber\", \n    RAL.\"approvalstatusid\", \n    COALESCE(U.\"name\", 'Sin asignación') AS \"name\", \n    STRING_AGG( \n        COALESCE(NULLIF(RAL.\"entrajobtitle\", ''), 'Sin puesto'),  \n        ' | '  \n        ORDER BY RAL.\"entrajobtitle\" \n    ) AS \"combinedjobtitles\", \n    AR.\"name\", \n    RAL.\"isreassigned\", \n    RAL.\"issubstitutefor\" \nFROM  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " AS RAL \nLEFT JOIN  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " AS U ON RAL.\"assignedto\" = U.\"id\" \nLEFT JOIN \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " AS AR ON AR.\"id\" = RAL.\"applicationroleid\" \nWHERE  \n    RAL.\"requisitionapprovalid\" = @qpreRequisitionApprovalId \n     \nGROUP BY  \n    RAL.\"levelnumber\",  \n    RAL.\"approvalstatusid\", \n    U.\"name\", \n    AR.\"name\", \n    RAL.\"isreassigned\", \n    RAL.\"issubstitutefor\" \nORDER BY  \n    RAL.\"levelnumber\" ASC;";
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetSpecialApprovalLevels.GetLevels.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.Wb_RequisitionEntra_Historic.GetSpecialApprovalLevels.GetLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_be474dab9f20512d09fda3e1e99c2e25)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetLevels in GetSpecialApprovalLevels in Wb_RequisitionEntra_Historic in c_Requisitions in ConectaProveedores (SELECT       RAL.[LevelNumber],      RAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(RAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY RAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  FROM       {RequisitionApprovalLevel} AS RAL  LEFT JOIN       {User} AS U ON RAL.[AssignedTo] = U.[Id]  LEFT JOIN      {ApplicationRole} AS AR ON AR.[Id] = RAL.[ApplicationRoleId]  WHERE       RAL.[RequisitionApprovalId] = @RequisitionApprovalId      --AND RAL.[ApprovalStatusId] <> @PendingApprovalStatus  GROUP BY       RAL.[LevelNumber],       RAL.[ApprovalStatusId],      U.[Name],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  ORDER BY       RAL.[LevelNumber] ASC;): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetLevels in GetSpecialApprovalLevels in Wb_RequisitionEntra_Historic in c_Requisitions in ConectaProveedores (SELECT       RAL.[LevelNumber],      RAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(RAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY RAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  FROM       {RequisitionApprovalLevel} AS RAL  LEFT JOIN       {User} AS U ON RAL.[AssignedTo] = U.[Id]  LEFT JOIN      {ApplicationRole} AS AR ON AR.[Id] = RAL.[ApplicationRoleId]  WHERE       RAL.[RequisitionApprovalId] = @RequisitionApprovalId      --AND RAL.[ApprovalStatusId] <> @PendingApprovalStatus  GROUP BY       RAL.[LevelNumber],       RAL.[ApprovalStatusId],      U.[Name],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  ORDER BY       RAL.[LevelNumber] ASC;): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetLevels in GetSpecialApprovalLevels in Wb_RequisitionEntra_Historic in c_Requisitions in ConectaProveedores (SELECT       RAL.[LevelNumber],      RAL.[ApprovalStatusId],      COALESCE(U.[Name], 'Sin asignación') AS [Name],      STRING_AGG(          COALESCE(NULLIF(RAL.[EntraJobTitle], ''), 'Sin puesto'),           ' | '           ORDER BY RAL.[EntraJobTitle]      ) AS [CombinedJobTitles],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  FROM       {RequisitionApprovalLevel} AS RAL  LEFT JOIN       {User} AS U ON RAL.[AssignedTo] = U.[Id]  LEFT JOIN      {ApplicationRole} AS AR ON AR.[Id] = RAL.[ApplicationRoleId]  WHERE       RAL.[RequisitionApprovalId] = @RequisitionApprovalId      --AND RAL.[ApprovalStatusId] <> @PendingApprovalStatus  GROUP BY       RAL.[LevelNumber],       RAL.[ApprovalStatusId],      U.[Name],      AR.[Name],      RAL.[IsReassigned],      RAL.[IsSubstituteFor]  ORDER BY       RAL.[LevelNumber] ASC;): " + aqExcep.Message));
}
}
}
}


}
