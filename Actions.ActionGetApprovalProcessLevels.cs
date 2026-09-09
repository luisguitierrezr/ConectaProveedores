namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetApprovalProcessLevels : VarsBag {
public long inParami_ProposalId;
public EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord inParami_ApprovalProcess;
public RL_aa6d551b6d5a88ffd31c1dc552b78a0a inParami_ProposalLinesList;
/// <summary>
/// Variable <code>l_HasStarted</code> that represents the Service Studio Boolean
///  <code>l_HasStarted</code> <p>Description: HasStarted</p>
/// </summary>
public bool varLcl_HasStarted = false;

/// <summary>
/// Variable <code>l_ApprovalProcessLevels</code> that represents the Service Studio
///  ApprovalProcessLevelList <code>l_ApprovalProcessLevels</code> <p>Description: ApprovalProcessLeve
/// l List</p>
/// </summary>
public RL_be2041fc5a275dcf5504e8e79ebd2184 varLcl_ApprovalProcessLevels = new RL_be2041fc5a275dcf5504e8e79ebd2184();

public Actions.lcoProposalApprovalCreateOrUpdate resProposalApprovalCreateOrUpdate =  new Actions.lcoProposalApprovalCreateOrUpdate();
public Actions.lcoProposalLineApprovalLevelCreateOrUpdate resProposalLineApprovalLevelCreateOrUpdate =  new Actions.lcoProposalLineApprovalLevelCreateOrUpdate();
public int resListIndexOf_outParamPosition = 0;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount = 0L;

public Actions.lcoProposalApprovalLevelCreateOrUpdate resProposalApprovalLevelCreateOrUpdate =  new Actions.lcoProposalApprovalLevelCreateOrUpdate();
public lcvGetApprovalProcessLevels(long inParami_ProposalId, EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord inParami_ApprovalProcess, RL_aa6d551b6d5a88ffd31c1dc552b78a0a inParami_ProposalLinesList) {
this.inParami_ProposalId = inParami_ProposalId;
this.inParami_ApprovalProcess = inParami_ApprovalProcess;
this.inParami_ProposalLinesList = inParami_ProposalLinesList;
}
}
public class lcoGetApprovalProcessLevels : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoGetApprovalProcessLevels() {
}
}
/// <summary>
/// Action <code>GetApprovalProcessLevels</code> that represents the Service Studio action
///  <code>GetApprovalProcessLevels</code> <p> Description: Action to get list of approval proces
/// s levels</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionGetApprovalProcessLevels(IRequestContext requestContext,long inParami_ProposalId,EN_b31af3b0976e3bd2f173f02f852fc788EntityRecord inParami_ApprovalProcess,RL_aa6d551b6d5a88ffd31c1dc552b78a0a inParami_ProposalLinesList,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoGetApprovalProcessLevels result = new lcoGetApprovalProcessLevels();
lcvGetApprovalProcessLevels localVars = new lcvGetApprovalProcessLevels(inParami_ProposalId, inParami_ApprovalProcess, inParami_ProposalLinesList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetApprovalProcessLevels", "baa53c93-9e7f-4317-acd3-64dc5a1a59d6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetApprovalProcessLevels", "baa53c93-9e7f-4317-acd3-64dc5a1a59d6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetApprovalProcessLevelsByApprovalProcessId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords = 0;
int datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex = 0;(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamCount) = await FuncActionGetApprovalProcessLevels.datasetGetApprovalProcessLevelsByApprovalProcessId(requestContext,datasetGetApprovalProcessLevelsByApprovalProcessId_maxRecords,datasetGetApprovalProcessLevelsByApprovalProcessId_startIndex,IterationMultiplicity.Single,localVars.inParami_ApprovalProcess.ssId,cancellationToken);

// Foreach GetApprovalProcessLevelsByApprovalProcessId.List
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.StartIteration();
try {while (!((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Eof))) {
if(((localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount!=(((decimal)0))))) {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.inParami_ProposalLinesList,async (p, cancellationToken) => (p.ssImporteenML>=localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel.ssMinAmount),cancellationToken);

if(((localVars.resListIndexOf_outParamPosition!=(-1)))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_ApprovalProcessLevels,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel,cancellationToken);

}

} else {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_ApprovalProcessLevels,localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcessLevel,cancellationToken);

}

localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.Advance();
}

} finally {
localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.EndIteration();
}

if((localVars.varLcl_ApprovalProcessLevels.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Approval Process not configured!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("6xnYmCxuzU+chw522bR+iQ#Value.-777494200.1", "Approval Process not configured!");
} else {
// ListSort
await ExtendedActions.ListSort(requestContext,localVars.varLcl_ApprovalProcessLevels,async (p, cancellationToken) => p.ssLevelNumber,true,cancellationToken);

// ProposalApprovalCreateOrUpdate
localVars.resProposalApprovalCreateOrUpdate.outParamId = await Actions.ActionProposalApprovalCreateOrUpdate(requestContext,new EN_5464a383ceb6bec564e8dfa03f011357EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalId = localVars.inParami_ProposalId, ssProcessTypeCode = localVars.inParami_ApprovalProcess.ssCode, ssApprovalProcessVersion = Convert.ToString(localVars.queryResGetApprovalProcessLevelsByApprovalProcessId_outParamList.CurrentRec.ssENApprovalProcess.ssVersion), ssStartedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// Foreach l_ApprovalProcessLevels
localVars.varLcl_ApprovalProcessLevels.StartIteration();
try {while (!((localVars.varLcl_ApprovalProcessLevels.Eof))) {
// ProposalApprovalLevelCreateOrUpdate
localVars.resProposalApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalApprovalLevelCreateOrUpdate(requestContext,new EN_9d8b873ac73cc192f28429eff2455f5bEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalApprovalId = localVars.resProposalApprovalCreateOrUpdate.outParamId, ssLevelNumber = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssLevelNumber, ssApplicationRoleId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssApplicationRoleId, ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId, ssHasStarted = (((!localVars.varLcl_HasStarted)) ? (true) : (false)), ssHasFinished = false },cancellationToken);

// Foreach i_ProposalLinesList
localVars.inParami_ProposalLinesList.StartIteration();
try {while (!((localVars.inParami_ProposalLinesList.Eof))) {
// MinAmount <> 0?
if(((localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssMinAmount!=(((decimal)0))))) {
// ImporteenML >= MinAmount?
if((!((localVars.inParami_ProposalLinesList.CurrentRec.ssImporteenML>=localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssMinAmount)))) {
// ALIGN
localVars.inParami_ProposalLinesList.Advance();
continue;
}

}

// ProposalLineApprovalLevelCreateOrUpdate
localVars.resProposalLineApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionProposalLineApprovalLevelCreateOrUpdate(requestContext,new EN_b0769c5ea1cb8e3ae3dd3da33328e669EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssProposalLineId = localVars.inParami_ProposalLinesList.CurrentRec.ssId, ssProposalApprovalLevelId = localVars.resProposalApprovalLevelCreateOrUpdate.outParamId, ssApplicationRoleId = localVars.varLcl_ApprovalProcessLevels.CurrentRec.ssApplicationRoleId, ssApprovalStatusId = (((!localVars.varLcl_HasStarted)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)) },cancellationToken);

localVars.inParami_ProposalLinesList.Advance();
}

} finally {
localVars.inParami_ProposalLinesList.EndIteration();
}

// l_HasStarted = True
localVars.varLcl_HasStarted=true;
localVars.varLcl_ApprovalProcessLevels.Advance();
}

} finally {
localVars.varLcl_ApprovalProcessLevels.EndIteration();
}

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionGetApprovalProcessLevels {

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessLevelsByApprovalProcessId" wQAX9e02AUaeZ4ob9agjnw of Action "GetApprovalProcessLevels"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcessLevelsByApprovalProcessId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapApprovalProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId", "f51700c1-36ed-4601-9e67-8a1bf5a8239f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId", "f51700c1-36ed-4601-9e67-8a1bf5a8239f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.kzylun+eF0Os02TcWhpZ1g/NodesNotShownInESpaceTree.wQAX9e02AUaeZ4ob9agjnw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess28\".\"version\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enapprovalprocesslevel11\".\"levelnumber\" o21, \"enapprovalprocesslevel11\".\"applicationroleid\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, trim_scale(\"enapprovalprocesslevel11\".\"minamount\"::numeric) o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess28\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel11\" ON (\"enapprovalprocess28\".\"id\" = \"enapprovalprocesslevel11\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpapApprovalProcess_Id != 0) {
whereBuilder.Append("((\"enapprovalprocess28\".\"id\" = @qpapApprovalProcess_Id) AND (\"enapprovalprocess28\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_Id", DbType.Int64, qpapApprovalProcess_Id);
} else {
whereBuilder.Append("(\"enapprovalprocess28\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enapprovalprocesslevel11\".\"levelnumber\" ASC ");
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
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessLevelsByApprovalProcessIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessLevels.GetApprovalProcessLevelsByApprovalProcessId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
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
