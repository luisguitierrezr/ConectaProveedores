namespace ssConectaProveedores;

public partial class Actions {
public class lcvRemoveNeedsContractApprovalLevels : VarsBag {
public long inParami_RequisitionId;
public Actions.lcoRequisitionLogAdd resRequisitionLogAdd =  new Actions.lcoRequisitionLogAdd();
public RL_17106260236c729f86b4f7919e212d21 queryResGetRequisitionApprovalLevels_outParamList = new RL_17106260236c729f86b4f7919e212d21();
public long queryResGetRequisitionApprovalLevels_outParamCount = 0L;

public lcvRemoveNeedsContractApprovalLevels(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
/// <summary>
/// Action <code>RemoveNeedsContractApprovalLevels</code> that represents the Service Studio action
///  <code>RemoveNeedsContractApprovalLevels</code> <p> Description: Recalculate workflow after contra
/// t file upload.</p>
/// </summary>
public static async Task ActionRemoveNeedsContractApprovalLevels(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
lcvRemoveNeedsContractApprovalLevels localVars = new lcvRemoveNeedsContractApprovalLevels(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RemoveNeedsContractApprovalLevels", "8115a575-09c9-4e15-86ec-aa01d0e4ed53"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RemoveNeedsContractApprovalLevels", "8115a575-09c9-4e15-86ec-aa01d0e4ed53", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionApprovalLevels
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevels_maxRecords = 0;
int datasetGetRequisitionApprovalLevels_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevels_outParamList,localVars.queryResGetRequisitionApprovalLevels_outParamCount) = await FuncActionRemoveNeedsContractApprovalLevels.datasetGetRequisitionApprovalLevels(requestContext,datasetGetRequisitionApprovalLevels_maxRecords,datasetGetRequisitionApprovalLevels_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

if((!(localVars.queryResGetRequisitionApprovalLevels_outParamList.Empty))) {
// Foreach GetRequisitionApprovalLevels.List
localVars.queryResGetRequisitionApprovalLevels_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionApprovalLevels_outParamList.Eof))) {
// RequisitionApprovalLevelDelete
await Actions.ActionRequisitionApprovalLevelDelete(requestContext,localVars.queryResGetRequisitionApprovalLevels_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId,cancellationToken);

localVars.queryResGetRequisitionApprovalLevels_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionApprovalLevels_outParamList.EndIteration();
}

// RequisitionLogAdd
localVars.resRequisitionLogAdd.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = BuiltInFunction.NullTextIdentifier (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = AppUtils.GetStringResource("ifXfkK_5c0yC2MbaecZdcw#Value.2146258401.1", "Requisition workflow recalculated after contract file upload.") },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionRemoveNeedsContractApprovalLevels {

private static async Task<RC_7a202946b9c9ade4fc5b7dc7c07f3279> datasetGetRequisitionApprovalLevelsReadDbAsync(RC_7a202946b9c9ade4fc5b7dc7c07f3279 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalLevels" QOfB+eJepEqOR+DeGReK_A of Action "RemoveNeedsContractApprovalLevels"
public static async Task<(RL_17106260236c729f86b4f7919e212d21,long)> datasetGetRequisitionApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RemoveNeedsContractApprovalLevels.GetRequisitionApprovalLevels", "f9c1e740-5ee2-4aa4-8e47-e0de19178afc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RemoveNeedsContractApprovalLevels.GetRequisitionApprovalLevels", "f9c1e740-5ee2-4aa4-8e47-e0de19178afc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.daUVgckJFU6G7KoB0OTtUw/NodesNotShownInESpaceTree.QOfB+eJepEqOR+DeGReK_A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enrequisitionapprovallevel10\".\"id\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35");
fromBuilder.Append(" FROM ({RequisitionApprovalLevel} \"enrequisitionapprovallevel10\" Left JOIN {RequisitionApproval} \"enrequisitionapproval12\" ON (\"enrequisitionapprovallevel10\".\"requisitionapprovalid\" = \"enrequisitionapproval12\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval12\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval12\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval12\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel10\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (\"enrequisitionapprovallevel10\".\"needscontract\" = 1)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RemoveNeedsContractApprovalLevels.GetRequisitionApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_17106260236c729f86b4f7919e212d21 _tmp = new RL_17106260236c729f86b4f7919e212d21();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RemoveNeedsContractApprovalLevels.GetRequisitionApprovalLevels.List", cancellationToken: cancellationToken);
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



}


}
