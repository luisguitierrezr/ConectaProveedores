namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetNextProposalApprovalLevel : VarsBag {
public long inParami_ProposalId;
public long inParami_ProposalLineId;
public int inParami_CurrentProposalApprovalLevelNumber;
public bool inParami_IsSubstitute;
public bool inParami_IsRefreshProposal;
/// <summary>
/// Variable <code>l_UserApplicationRole</code> that represents the Service Studio
///  ApplicationRoleIdentifier <code>l_UserApplicationRole</code> <p>Description
/// : UserApplicationRole</p>
/// </summary>
public long varLcl_UserApplicationRole = 0L;

public RC_cbff39127609a0f830b2d34948d1c019 resGetProposalLine_outParamRecord = new RC_cbff39127609a0f830b2d34948d1c019();

public Actions.lcoApproveRejectSingleProposalLineApprovalLevel resApproveRejectSingleProposalLineApprovalLevel =  new Actions.lcoApproveRejectSingleProposalLineApprovalLevel();
public Actions.lcoProposalLineApprovalLevelCreateOrUpdate resProposalLineApprovalLevelCreateOrUpdate2 =  new Actions.lcoProposalLineApprovalLevelCreateOrUpdate();
public Actions.lcoProposalApprovalLevelCreateOrUpdate resProposalApprovalLevelCreateOrUpdate =  new Actions.lcoProposalApprovalLevelCreateOrUpdate();
public RL_5be428ef6f9c9aa8b3df8260aa8d6a98 queryResGetNextProposalApprovalLevel_outParamList = new RL_5be428ef6f9c9aa8b3df8260aa8d6a98();
public long queryResGetNextProposalApprovalLevel_outParamCount = 0L;

public Actions.lcoProposalLineCreateOrUpdate resProposalLineCreateOrUpdate =  new Actions.lcoProposalLineCreateOrUpdate();
public RL_d22dbb34ff25b8803ae17b65f615d2c8 queryResGetUserApplicationRoleByUserId_outParamList = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
public long queryResGetUserApplicationRoleByUserId_outParamCount = 0L;

public Actions.lcoProposalLineApprovalLevelCreateOrUpdate resProposalLineApprovalLevelCreateOrUpdate =  new Actions.lcoProposalLineApprovalLevelCreateOrUpdate();
public lcvGetNextProposalApprovalLevel(long inParami_ProposalId, long inParami_ProposalLineId, int inParami_CurrentProposalApprovalLevelNumber, bool inParami_IsSubstitute, bool inParami_IsRefreshProposal) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_ProposalLineId = inParami_ProposalLineId;
this.inParami_CurrentProposalApprovalLevelNumber = inParami_CurrentProposalApprovalLevelNumber;
this.inParami_IsSubstitute = inParami_IsSubstitute;
this.inParami_IsRefreshProposal = inParami_IsRefreshProposal;
}
}
/// <summary>
/// Action <code>GetNextProposalApprovalLevel</code> that represents the Service Studio action
///  <code>GetNextProposalApprovalLevel</code> <p> Description: Action to refres
/// h ProposalApprovalLevel</p>
/// </summary>
public static async Task ActionGetNextProposalApprovalLevel(IRequestContext requestContext,long inParami_ProposalId,long inParami_ProposalLineId,int inParami_CurrentProposalApprovalLevelNumber,bool inParami_IsSubstitute,bool inParami_IsRefreshProposal,CancellationToken cancellationToken) {
lcvGetNextProposalApprovalLevel localVars = new lcvGetNextProposalApprovalLevel(inParami_ProposalId, inParami_ProposalLineId, inParami_CurrentProposalApprovalLevelNumber, inParami_IsSubstitute, inParami_IsRefreshProposal);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetNextProposalApprovalLevel", "65fd0b77-390a-4ff4-8057-2d024660dc81"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetNextProposalApprovalLevel", "65fd0b77-390a-4ff4-8057-2d024660dc81", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetNextProposalApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetNextProposalApprovalLevel_maxRecords = 1;
if (datasetGetNextProposalApprovalLevel_maxRecords < 1) datasetGetNextProposalApprovalLevel_maxRecords = 1;
int datasetGetNextProposalApprovalLevel_startIndex = 0;(localVars.queryResGetNextProposalApprovalLevel_outParamList,localVars.queryResGetNextProposalApprovalLevel_outParamCount) = await FuncActionGetNextProposalApprovalLevel.datasetGetNextProposalApprovalLevel(requestContext,datasetGetNextProposalApprovalLevel_maxRecords,datasetGetNextProposalApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_CurrentProposalApprovalLevelNumber,localVars.inParami_ProposalId,localVars.inParami_ProposalLineId,cancellationToken);

if((localVars.queryResGetNextProposalApprovalLevel_outParamList.Empty)) {
// GetProposalLine
localVars.resGetProposalLine_outParamRecord = await ExtendedActions.GetProposalLine(requestContext,localVars.inParami_ProposalLineId,cancellationToken);

// GetProposalLine.Record.ProposalLine.ApprovalStatusId = Approved
localVars.resGetProposalLine_outParamRecord.ssENProposalLine.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId;
// ProposalLineCreateOrUpdate
localVars.resProposalLineCreateOrUpdate.outParamId = await Actions.ActionProposalLineCreateOrUpdate(requestContext,localVars.resGetProposalLine_outParamRecord.ssENProposalLine,cancellationToken);

if((localVars.inParami_IsRefreshProposal)) {
// RefreshProposal
await Actions.ActionRefreshProposal(requestContext,localVars.inParami_ProposalId,cancellationToken);

}

} else {
if((localVars.inParami_IsSubstitute)) {
// Query datasetGetUserApplicationRoleByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleByUserId_maxRecords = 1;
if (datasetGetUserApplicationRoleByUserId_maxRecords < 1) datasetGetUserApplicationRoleByUserId_maxRecords = 1;
int datasetGetUserApplicationRoleByUserId_startIndex = 0;(localVars.queryResGetUserApplicationRoleByUserId_outParamList,localVars.queryResGetUserApplicationRoleByUserId_outParamCount) = await FuncActionGetNextProposalApprovalLevel.datasetGetUserApplicationRoleByUserId(requestContext,datasetGetUserApplicationRoleByUserId_maxRecords,datasetGetUserApplicationRoleByUserId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// l_UserApplicationRole = GetUserApplicationRoleByUserId.List.Current.UserApplicationRole.ApplicationRoleId
localVars.varLcl_UserApplicationRole=localVars.queryResGetUserApplicationRoleByUserId_outParamList.CurrentRec.ssENUserApplicationRole.ssApplicationRoleId;
}

// not HasStarted
if(((!localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalApprovalLevel.ssHasStarted))) {
// GetNextProposalApprovalLevel.List.Current.ProposalApprovalLevel.HasStarted = True
localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalApprovalLevel.ssHasStarted = true;
// ProposalApprovalLevelCreateOrUpdate
localVars.resProposalApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalApprovalLevel,cancellationToken);

}

if(((localVars.inParami_IsSubstitute&&(localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalApprovalLevel.ssApplicationRoleId==localVars.varLcl_UserApplicationRole)))) {
// GetNextProposalApprovalLevel.List.Current.ProposalLineApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;
// ProposalLineApprovalLevelCreateOrUpdate
localVars.resProposalLineApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalLineApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalLineApprovalLevel,cancellationToken);

// ApproveRejectSingleProposalLineApprovalLevel
localVars.resApproveRejectSingleProposalLineApprovalLevel.outParamo_Output = await Actions.ActionApproveRejectSingleProposalLineApprovalLevel(requestContext,localVars.inParami_ProposalId,localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssId,false,"",cancellationToken);

} else {
// GetNextProposalApprovalLevel.List.Current.ProposalLineApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalLineApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;
// ProposalLineApprovalLevelCreateOrUpdate2
localVars.resProposalLineApprovalLevelCreateOrUpdate2.outParamId = await Actions.ActionProposalLineApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetNextProposalApprovalLevel_outParamList.CurrentRec.ssENProposalLineApprovalLevel,cancellationToken);

if((localVars.inParami_IsRefreshProposal)) {
// RefreshProposal2
await Actions.ActionRefreshProposal(requestContext,localVars.inParami_ProposalId,cancellationToken);

}

}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionGetNextProposalApprovalLevel {

private static async Task<RC_be1a2f02e9ce96cb93b1fb40e877c6b4> datasetGetNextProposalApprovalLevelReadDbAsync(RC_be1a2f02e9ce96cb93b1fb40e877c6b4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENProposalApproval.Read( r, ref index);
rec.ssENProposalApprovalLevel.Read( r, ref index);
rec.ssENProposalLine.Read( r, ref index);
rec.ssENProposalLineApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetNextProposalApprovalLevel" pZm+eT6ks025QKzYNcARqw of Action "GetNextProposalApprovalLevel"
public static async Task<(RL_5be428ef6f9c9aa8b3df8260aa8d6a98,long)> datasetGetNextProposalApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpini_CurrentProposalApprovalLevelNumber,long qpprProposalApproval_ProposalId,long qpprProposalLineApprovalLevel_ProposalLineId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetNextProposalApprovalLevel.GetNextProposalApprovalLevel", "79be99a5-a43e-4db3-b940-acd835c011ab");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetNextProposalApprovalLevel.GetNextProposalApprovalLevel", "79be99a5-a43e-4db3-b940-acd835c011ab", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dwv9ZQo59E+AVy0CRmDcgQ/NodesNotShownInESpaceTree.pZm+eT6ks025QKzYNcARqw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enproposalapprovallevel1\".\"id\" o8, \"enproposalapprovallevel1\".\"proposalapprovalid\" o9, \"enproposalapprovallevel1\".\"levelnumber\" o10, \"enproposalapprovallevel1\".\"applicationroleid\" o11, \"enproposalapprovallevel1\".\"approvalstatusid\" o12, \"enproposalapprovallevel1\".\"hasstarted\" o13, \"enproposalapprovallevel1\".\"hasfinished\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"enproposallineapprovallevel\".\"id\" o43, \"enproposallineapprovallevel\".\"proposallineid\" o44, \"enproposallineapprovallevel\".\"proposalapprovallevelid\" o45, \"enproposallineapprovallevel\".\"applicationroleid\" o46, \"enproposallineapprovallevel\".\"approvalstatusid\" o47, \"enproposallineapprovallevel\".\"approvedby\" o48, \"enproposallineapprovallevel\".\"approvedon\" o49, \"enproposallineapprovallevel\".\"rejectedby\" o50, \"enproposallineapprovallevel\".\"rejectedon\" o51");
fromBuilder.Append(" FROM ((({ProposalApproval} \"enproposalapproval1\" Left JOIN {ProposalApprovalLevel} \"enproposalapprovallevel1\" ON (\"enproposalapproval1\".\"id\" = \"enproposalapprovallevel1\".\"proposalapprovalid\"))  Left JOIN {ProposalLineApprovalLevel} \"enproposallineapprovallevel\" ON (\"enproposalapprovallevel1\".\"id\" = \"enproposallineapprovallevel\".\"proposalapprovallevelid\"))  Left JOIN {ProposalLine} \"enproposalline\" ON (\"enproposallineapprovallevel\".\"proposallineid\" = \"enproposalline\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprProposalApproval_ProposalId != 0) {
whereBuilder.Append("((\"enproposalapproval1\".\"proposalid\" = @qpprProposalApproval_ProposalId) AND (\"enproposalapproval1\".\"proposalid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalApproval_ProposalId", DbType.Int64, qpprProposalApproval_ProposalId);
} else {
whereBuilder.Append("(\"enproposalapproval1\".\"proposalid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enproposalapprovallevel1\".\"levelnumber\" > @qpini_CurrentProposalApprovalLevelNumber) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpini_CurrentProposalApprovalLevelNumber", DbType.Int32, qpini_CurrentProposalApprovalLevelNumber);
if (qpprProposalLineApprovalLevel_ProposalLineId != 0) {
whereBuilder.Append("((\"enproposallineapprovallevel\".\"proposallineid\" = @qpprProposalLineApprovalLevel_ProposalLineId) AND (\"enproposallineapprovallevel\".\"proposallineid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProposalLineApprovalLevel_ProposalLineId", DbType.Int64, qpprProposalLineApprovalLevel_ProposalLineId);
} else {
whereBuilder.Append("(\"enproposallineapprovallevel\".\"proposallineid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enproposalapprovallevel1\".\"levelnumber\" ASC ");
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
RL_5be428ef6f9c9aa8b3df8260aa8d6a98 outParamList = new RL_5be428ef6f9c9aa8b3df8260aa8d6a98();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetNextProposalApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetNextProposalApprovalLevel.GetNextProposalApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5be428ef6f9c9aa8b3df8260aa8d6a98 _tmp = new RL_5be428ef6f9c9aa8b3df8260aa8d6a98();
_tmp.AlternateReadDbMethodAsync = datasetGetNextProposalApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetNextProposalApprovalLevel.GetNextProposalApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5be428ef6f9c9aa8b3df8260aa8d6a98)_tmp;
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

// Query Function "GetUserApplicationRoleByUserId" yE_ozU8aVkSpU2mCowWY2w of Action "GetNextProposalApprovalLevel"
public static async Task<(RL_d22dbb34ff25b8803ae17b65f615d2c8,long)> datasetGetUserApplicationRoleByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetNextProposalApprovalLevel.GetUserApplicationRoleByUserId", "cde84fc8-1a4f-4456-a953-6982a30598db");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetNextProposalApprovalLevel.GetUserApplicationRoleByUserId", "cde84fc8-1a4f-4456-a953-6982a30598db", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.dwv9ZQo59E+AVy0CRmDcgQ/NodesNotShownInESpaceTree.yE_ozU8aVkSpU2mCowWY2w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enuserapplicationrole8\".\"applicationroleid\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {UserApplicationRole} \"enuserapplicationrole8\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationrole8\".\"userid\" = @qpusUserId) AND (\"enuserapplicationrole8\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationrole8\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole8\".\"rolestatusid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetNextProposalApprovalLevel.GetUserApplicationRoleByUserId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetNextProposalApprovalLevel.GetUserApplicationRoleByUserId.List", cancellationToken: cancellationToken);
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
