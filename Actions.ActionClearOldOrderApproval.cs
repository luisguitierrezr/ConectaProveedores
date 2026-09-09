namespace ssConectaProveedores;

public partial class Actions {
public class lcvClearOldOrderApproval : VarsBag {
public long inParami_OrderId;
public Actions.lcoOrderApprovalLevelCreateOrUpdate resOrderApprovalLevelCreateOrUpdate =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public RL_466c605dd07558761818d5a27c59c2b8 queryResGetOrderApprovalLevels_outParamList = new RL_466c605dd07558761818d5a27c59c2b8();
public long queryResGetOrderApprovalLevels_outParamCount = 0L;

public int resListIndexOf_outParamPosition = 0;

public lcvClearOldOrderApproval(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
/// <summary>
/// Action <code>ClearOldOrderApproval</code> that represents the Service Studio action
///  <code>ClearOldOrderApproval</code> <p> Description: </p>
/// </summary>
public static async Task ActionClearOldOrderApproval(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
lcvClearOldOrderApproval localVars = new lcvClearOldOrderApproval(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ClearOldOrderApproval", "716733cc-5730-4f24-88a4-411c8e5a3f39"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ClearOldOrderApproval", "716733cc-5730-4f24-88a4-411c8e5a3f39", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderApprovalLevels
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalLevels_maxRecords = 1;
if (datasetGetOrderApprovalLevels_maxRecords < 1) datasetGetOrderApprovalLevels_maxRecords = 1;
int datasetGetOrderApprovalLevels_startIndex = 0;(localVars.queryResGetOrderApprovalLevels_outParamList,localVars.queryResGetOrderApprovalLevels_outParamCount) = await FuncActionClearOldOrderApproval.datasetGetOrderApprovalLevels(requestContext,datasetGetOrderApprovalLevels_maxRecords,datasetGetOrderApprovalLevels_startIndex,IterationMultiplicity.Multiple,localVars.inParami_OrderId,cancellationToken);

// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetOrderApprovalLevels_outParamList,async (p, cancellationToken) => p.ssENOrderApprovalLevel.ssIsComplement,cancellationToken);

// Foreach GetOrderApprovalLevels.List
localVars.queryResGetOrderApprovalLevels_outParamList.StartIteration();
try {localVars.queryResGetOrderApprovalLevels_outParamList.Advance((localVars.resListIndexOf_outParamPosition+1));
while (!((localVars.queryResGetOrderApprovalLevels_outParamList.Eof))) {
// GetOrderApprovalLevels.List.Current.OrderApprovalLevel.AssignedOn = NullDate
localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedOn = BuiltInFunction.NullDate ();

// GetOrderApprovalLevels.List.Current.OrderApprovalLevel.ApprovalStatusId = Pending
localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId;

// GetOrderApprovalLevels.List.Current.OrderApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetOrderApprovalLevels.List.Current.OrderApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();
// OrderApprovalLevelCreateOrUpdate
localVars.resOrderApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

localVars.queryResGetOrderApprovalLevels_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderApprovalLevels_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionClearOldOrderApproval {

private static async Task<RC_7074703fd377ca40d733f2d5d8d3fde2> datasetGetOrderApprovalLevelsReadDbAsync(RC_7074703fd377ca40d733f2d5d8d3fde2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalLevels" jcpdwPdzgkang6oxLvf+qA of Action "ClearOldOrderApproval"
public static async Task<(RL_466c605dd07558761818d5a27c59c2b8,long)> datasetGetOrderApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearOldOrderApproval.GetOrderApprovalLevels", "c05dca8d-73f7-4682-a783-aa312ef7fea8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearOldOrderApproval.GetOrderApprovalLevels", "c05dca8d-73f7-4682-a783-aa312ef7fea8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zDNncTBXJE+IpEEcjlo_OQ/NodesNotShownInESpaceTree.jcpdwPdzgkang6oxLvf+qA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enorderapprovallevel8\".\"id\" o8, \"enorderapprovallevel8\".\"orderapprovalid\" o9, \"enorderapprovallevel8\".\"levelnumber\" o10, \"enorderapprovallevel8\".\"entraroleid\" o11, \"enorderapprovallevel8\".\"assignedto\" o12, \"enorderapprovallevel8\".\"assignedon\" o13, \"enorderapprovallevel8\".\"approvalstatusid\" o14, \"enorderapprovallevel8\".\"approvedby\" o15, \"enorderapprovallevel8\".\"approvedon\" o16, \"enorderapprovallevel8\".\"rejectedby\" o17, \"enorderapprovallevel8\".\"rejectedon\" o18, \"enorderapprovallevel8\".\"iscomplement\" o19, \"enorderapprovallevel8\".\"isreassigned\" o20, \"enorderapprovallevel8\".\"issubstitutefor\" o21, \"enorderapprovallevel8\".\"tomodifyby\" o22, \"enorderapprovallevel8\".\"tomodifyon\" o23, \"enorderapprovallevel8\".\"wascanceledby\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain33\" Left JOIN {OrderApproval} \"enorderapproval9\" ON (\"enordermain33\".\"id\" = \"enorderapproval9\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel8\" ON (\"enorderapproval9\".\"id\" = \"enorderapprovallevel8\".\"orderapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain33\".\"id\" = @qporOrderMain_Id) AND (\"enordermain33\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain33\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel8\".\"levelnumber\" ASC ");
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
RL_466c605dd07558761818d5a27c59c2b8 outParamList = new RL_466c605dd07558761818d5a27c59c2b8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearOldOrderApproval.GetOrderApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_466c605dd07558761818d5a27c59c2b8 _tmp = new RL_466c605dd07558761818d5a27c59c2b8();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearOldOrderApproval.GetOrderApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_466c605dd07558761818d5a27c59c2b8)_tmp;
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
