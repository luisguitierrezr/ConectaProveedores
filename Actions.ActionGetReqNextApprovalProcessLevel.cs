namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetReqNextApprovalProcessLevel : VarsBag {
public long inParami_RequisitionId;
public bool inParami_IsSubstitute;
public string inParami_AssignTo;
/// <summary>
/// Variable <code>l_UserApplicationRole</code> that represents the Service Studio
///  ApplicationRoleIdentifier <code>l_UserApplicationRole</code> <p>Description
/// : UserApplicationRole</p>
/// </summary>
public long varLcl_UserApplicationRole = 0L;

/// <summary>
/// Variable <code>l_StartAccounting</code> that represents the Service Studio Boolean
///  <code>l_StartAccounting</code> <p>Description: </p>
/// </summary>
public bool varLcl_StartAccounting = false;

public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoHasRoleNeeded resHasRoleNeeded =  new Actions.lcoHasRoleNeeded();
public Actions.lcoRequisitionApprovalCreateOrUpdate resRequisitionApprovalCreateOrUpdate =  new Actions.lcoRequisitionApprovalCreateOrUpdate();
public RL_17106260236c729f86b4f7919e212d21 queryResGetNextRequisitionApprovalLevel_outParamList = new RL_17106260236c729f86b4f7919e212d21();
public long queryResGetNextRequisitionApprovalLevel_outParamCount = 0L;

public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate2 =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public Actions.lcoApproveModifyRequisition resApproveModifyRequisition =  new Actions.lcoApproveModifyRequisition();
public RL_d22dbb34ff25b8803ae17b65f615d2c8 queryResGetUserApplicationRoleByUserId_outParamList = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
public long queryResGetUserApplicationRoleByUserId_outParamCount = 0L;

public lcvGetReqNextApprovalProcessLevel(long inParami_RequisitionId, bool inParami_IsSubstitute, string inParami_AssignTo) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_IsSubstitute = inParami_IsSubstitute;
this.inParami_AssignTo = inParami_AssignTo;
}
}
/// <summary>
/// Action <code>GetReqNextApprovalProcessLevel</code> that represents the Service Studio action
///  <code>GetReqNextApprovalProcessLevel</code> <p> Description: </p>
/// </summary>
public static async Task ActionGetReqNextApprovalProcessLevel(IRequestContext requestContext,long inParami_RequisitionId,bool inParami_IsSubstitute,string inParami_AssignTo,CancellationToken cancellationToken) {
lcvGetReqNextApprovalProcessLevel localVars = new lcvGetReqNextApprovalProcessLevel(inParami_RequisitionId, inParami_IsSubstitute, inParami_AssignTo);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetReqNextApprovalProcessLevel", "4c2b86db-da2a-4d84-9b87-8f83e7d92140"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetReqNextApprovalProcessLevel", "4c2b86db-da2a-4d84-9b87-8f83e7d92140", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetNextRequisitionApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextRequisitionApprovalLevel_maxRecords = 1;
if (datasetGetNextRequisitionApprovalLevel_maxRecords < 1) datasetGetNextRequisitionApprovalLevel_maxRecords = 1;
int datasetGetNextRequisitionApprovalLevel_startIndex = 0;(localVars.queryResGetNextRequisitionApprovalLevel_outParamList,localVars.queryResGetNextRequisitionApprovalLevel_outParamCount) = await FuncActionGetReqNextApprovalProcessLevel.datasetGetNextRequisitionApprovalLevel(requestContext,datasetGetNextRequisitionApprovalLevel_maxRecords,datasetGetNextRequisitionApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// l_StartAccounting = notGetNextRequisitionApprovalLevel.List.Current.RequisitionApproval.HasStartedAccounting and GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.IsStartAccounting
localVars.varLcl_StartAccounting=((!localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting)&&localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssIsStartAccounting);
// GetNextRequisitionApprovalLevel.List.Current.RequisitionApproval.CurrentLevel = GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.LevelNumber
localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssCurrentLevel = localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssLevelNumber;

// GetNextRequisitionApprovalLevel.List.Current.RequisitionApproval.HasStartedAccounting = If
localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting = ((localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval.ssHasStartedAccounting) ? (true) : (localVars.varLcl_StartAccounting));
// RequisitionApprovalCreateOrUpdate
localVars.resRequisitionApprovalCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalCreateOrUpdate(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApproval,cancellationToken);

if((localVars.varLcl_StartAccounting)) {
// InitializeRequisitionAccounting
await Actions.ActionInitializeRequisitionAccounting(requestContext,localVars.inParami_RequisitionId,cancellationToken);

} else {
if((localVars.inParami_IsSubstitute)) {
// Query datasetGetUserApplicationRoleByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleByUserId_maxRecords = 1;
if (datasetGetUserApplicationRoleByUserId_maxRecords < 1) datasetGetUserApplicationRoleByUserId_maxRecords = 1;
int datasetGetUserApplicationRoleByUserId_startIndex = 0;(localVars.queryResGetUserApplicationRoleByUserId_outParamList,localVars.queryResGetUserApplicationRoleByUserId_outParamCount) = await FuncActionGetReqNextApprovalProcessLevel.datasetGetUserApplicationRoleByUserId(requestContext,datasetGetUserApplicationRoleByUserId_maxRecords,datasetGetUserApplicationRoleByUserId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// l_UserApplicationRole = GetUserApplicationRoleByUserId.List.Current.UserApplicationRole.ApplicationRoleId
localVars.varLcl_UserApplicationRole=localVars.queryResGetUserApplicationRoleByUserId_outParamList.CurrentRec.ssENUserApplicationRole.ssApplicationRoleId;
}

}

if((!((localVars.inParami_IsSubstitute&&(localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApplicationRoleId==localVars.varLcl_UserApplicationRole))))) {
// HasRoleNeeded
(localVars.resHasRoleNeeded.outParamo_Output,localVars.resHasRoleNeeded.outParamo_UserId) = await Actions.ActionHasRoleNeeded(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApplicationRoleId,"",BuiltInFunction.GetUserId (),0L,3,cancellationToken);

// IsSuccess
if((!(localVars.resHasRoleNeeded.outParamo_Output.ssIsSuccess))) {
// GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.AssignedTo = If
localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = (((localVars.inParami_AssignTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_AssignTo) : (BuiltInFunction.NullTextIdentifier ()));
// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// SendReqNextApproverEmail
await Actions.ActionSendReqNextApproverEmail(requestContext,localVars.inParami_RequisitionId,cancellationToken);

goto RETURN_STATEMENT;

}

}

// GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;

// GetNextRequisitionApprovalLevel.List.Current.RequisitionApprovalLevel.AssignedTo = If
localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssAssignedTo = (((localVars.inParami_AssignTo!=BuiltInFunction.NullTextIdentifier ())) ? (localVars.inParami_AssignTo) : (BuiltInFunction.NullTextIdentifier ()));
// RequisitionApprovalLevelCreateOrUpdate2
localVars.resRequisitionApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

// ApproveModifyRequisition
localVars.resApproveModifyRequisition.outParamo_Output = await Actions.ActionApproveModifyRequisition(requestContext,localVars.inParami_RequisitionId,localVars.queryResGetNextRequisitionApprovalLevel_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId,true,"",cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionGetReqNextApprovalProcessLevel {

private static async Task<RC_7a202946b9c9ade4fc5b7dc7c07f3279> datasetGetNextRequisitionApprovalLevelReadDbAsync(RC_7a202946b9c9ade4fc5b7dc7c07f3279 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetNextRequisitionApprovalLevel" KkBtfeiHVEODH4dtpekrzw of Action "GetReqNextApprovalProcessLevel"
public static async Task<(RL_17106260236c729f86b4f7919e212d21,long)> datasetGetNextRequisitionApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqNextApprovalProcessLevel.GetNextRequisitionApprovalLevel", "7d6d402a-87e8-4354-831f-876da5e92bcf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqNextApprovalProcessLevel.GetNextRequisitionApprovalLevel", "7d6d402a-87e8-4354-831f-876da5e92bcf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.24YrTCrahE2bh4+D59khQA/NodesNotShownInESpaceTree.KkBtfeiHVEODH4dtpekrzw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionapproval8\".\"id\" o0, \"enrequisitionapproval8\".\"requisitionid\" o1, \"enrequisitionapproval8\".\"aprovalprocessid\" o2, \"enrequisitionapproval8\".\"processtypecode\" o3, \"enrequisitionapproval8\".\"approvalprocessversion\" o4, \"enrequisitionapproval8\".\"currentlevel\" o5, \"enrequisitionapproval8\".\"maxlevel\" o6, \"enrequisitionapproval8\".\"startedon\" o7, \"enrequisitionapproval8\".\"finishedon\" o8, \"enrequisitionapproval8\".\"hasstartedaccounting\" o9, \"enrequisitionapprovallevel7\".\"id\" o10, \"enrequisitionapprovallevel7\".\"requisitionapprovalid\" o11, \"enrequisitionapprovallevel7\".\"levelnumber\" o12, \"enrequisitionapprovallevel7\".\"applicationroleid\" o13, \"enrequisitionapprovallevel7\".\"entrajobtitle\" o14, \"enrequisitionapprovallevel7\".\"departmentid\" o15, \"enrequisitionapprovallevel7\".\"managementid\" o16, \"enrequisitionapprovallevel7\".\"subdirectionid\" o17, \"enrequisitionapprovallevel7\".\"entraroleid\" o18, \"enrequisitionapprovallevel7\".\"entrausername\" o19, \"enrequisitionapprovallevel7\".\"assignedto\" o20, \"enrequisitionapprovallevel7\".\"needscontract\" o21, \"enrequisitionapprovallevel7\".\"approvalstatusid\" o22, \"enrequisitionapprovallevel7\".\"approvedby\" o23, \"enrequisitionapprovallevel7\".\"approvedon\" o24, \"enrequisitionapprovallevel7\".\"requesttomodifyby\" o25, \"enrequisitionapprovallevel7\".\"requesttomodifyon\" o26, \"enrequisitionapprovallevel7\".\"canceledby\" o27, \"enrequisitionapprovallevel7\".\"canceledon_deprec\" o28, \"enrequisitionapprovallevel7\".\"isaccounting\" o29, \"enrequisitionapprovallevel7\".\"isstartaccounting\" o30, \"enrequisitionapprovallevel7\".\"canceledon_\" o31, \"enrequisitionapprovallevel7\".\"approveasareausuaria\" o32, \"enrequisitionapprovallevel7\".\"ismandatory\" o33, \"enrequisitionapprovallevel7\".\"isreassigned\" o34, \"enrequisitionapprovallevel7\".\"issubstitutefor\" o35");
fromBuilder.Append(" FROM ({RequisitionApproval} \"enrequisitionapproval8\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel7\" ON (\"enrequisitionapproval8\".\"id\" = \"enrequisitionapprovallevel7\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval8\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval8\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval8\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel7\".\"levelnumber\" > \"enrequisitionapproval8\".\"currentlevel\")");
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel7\".\"levelnumber\" ASC ");
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
RL_17106260236c729f86b4f7919e212d21 outParamList = new RL_17106260236c729f86b4f7919e212d21();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextRequisitionApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqNextApprovalProcessLevel.GetNextRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_17106260236c729f86b4f7919e212d21 _tmp = new RL_17106260236c729f86b4f7919e212d21();
_tmp.AlternateReadDbMethodAsync = datasetGetNextRequisitionApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqNextApprovalProcessLevel.GetNextRequisitionApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_17106260236c729f86b4f7919e212d21)_tmp;
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

// Query Function "GetUserApplicationRoleByUserId" UYpc_5NmoUSpmAE8DAkVdg of Action "GetReqNextApprovalProcessLevel"
public static async Task<(RL_d22dbb34ff25b8803ae17b65f615d2c8,long)> datasetGetUserApplicationRoleByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetReqNextApprovalProcessLevel.GetUserApplicationRoleByUserId", "ff5c8a51-6693-44a1-a998-013c0c091576");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetReqNextApprovalProcessLevel.GetUserApplicationRoleByUserId", "ff5c8a51-6693-44a1-a998-013c0c091576", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.24YrTCrahE2bh4+D59khQA/NodesNotShownInESpaceTree.UYpc_5NmoUSpmAE8DAkVdg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuserapplicationrole7\".\"applicationroleid\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {UserApplicationRole} \"enuserapplicationrole7\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationrole7\".\"userid\" = @qpusUserId) AND (\"enuserapplicationrole7\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationrole7\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole7\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
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
RL_d22dbb34ff25b8803ae17b65f615d2c8 outParamList = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetReqNextApprovalProcessLevel.GetUserApplicationRoleByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d22dbb34ff25b8803ae17b65f615d2c8 _tmp = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetReqNextApprovalProcessLevel.GetUserApplicationRoleByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d22dbb34ff25b8803ae17b65f615d2c8)_tmp;
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
