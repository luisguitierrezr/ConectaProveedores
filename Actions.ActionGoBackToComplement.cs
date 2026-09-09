namespace ssConectaProveedores;

public partial class Actions {
public class lcvGoBackToComplement : VarsBag {
public long inParami_OrderId;
public Actions.lcoOrderApprovalLevelCreateOrUpdate resOrderApprovalLevelCreateOrUpdate =  new Actions.lcoOrderApprovalLevelCreateOrUpdate();
public Actions.lcoOrderApprovalCreateOrUpdate resOrderApprovalCreateOrUpdate =  new Actions.lcoOrderApprovalCreateOrUpdate();
public RL_466c605dd07558761818d5a27c59c2b8 queryResGetOrderMainComplementLevel_outParamList = new RL_466c605dd07558761818d5a27c59c2b8();
public long queryResGetOrderMainComplementLevel_outParamCount = 0L;

public lcvGoBackToComplement(long inParami_OrderId) {
this.inParami_OrderId = inParami_OrderId;
}
}
/// <summary>
/// Action <code>GoBackToComplement</code> that represents the Service Studio action
///  <code>GoBackToComplement</code> <p> Description: </p>
/// </summary>
public static async Task ActionGoBackToComplement(IRequestContext requestContext,long inParami_OrderId,CancellationToken cancellationToken) {
lcvGoBackToComplement localVars = new lcvGoBackToComplement(inParami_OrderId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GoBackToComplement", "11fda4a3-be20-4073-9f96-2ebe2fa39f5a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GoBackToComplement", "11fda4a3-be20-4073-9f96-2ebe2fa39f5a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderMainComplementLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainComplementLevel_maxRecords = 1;
if (datasetGetOrderMainComplementLevel_maxRecords < 1) datasetGetOrderMainComplementLevel_maxRecords = 1;
int datasetGetOrderMainComplementLevel_startIndex = 0;(localVars.queryResGetOrderMainComplementLevel_outParamList,localVars.queryResGetOrderMainComplementLevel_outParamCount) = await FuncActionGoBackToComplement.datasetGetOrderMainComplementLevel(requestContext,datasetGetOrderMainComplementLevel_maxRecords,datasetGetOrderMainComplementLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_OrderId,cancellationToken);

// Empty?
if((!(localVars.queryResGetOrderMainComplementLevel_outParamList.Empty))) {
// Approval
// GetOrderMainComplementLevel.List.Current.OrderApproval.CurrentLevel = GetOrderMainComplementLevel.List.Current.OrderApprovalLevel.LevelNumber
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApproval.ssCurrentLevel = localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssLevelNumber;

// GetOrderMainComplementLevel.List.Current.OrderApproval.FinishedOn = NullDate
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApproval.ssFinishedOn = BuiltInFunction.NullDate ();

// GetOrderMainComplementLevel.List.Current.OrderApproval.LastApproverPuestodelGerente = ""
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApproval.ssLastApproverPuestodelGerente = "";

// GetOrderMainComplementLevel.List.Current.OrderApproval.LastApproverPuestodelJefe = ""
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApproval.ssLastApproverPuestodelJefe = "";
// Approval Level
// GetOrderMainComplementLevel.List.Current.OrderApprovalLevel.AssignedOn = CurrDateTime
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedOn = BuiltInFunction.CurrDateTime ();

// GetOrderMainComplementLevel.List.Current.OrderApprovalLevel.ApprovalStatusId = InInformationCompletion
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId;

// GetOrderMainComplementLevel.List.Current.OrderApprovalLevel.ApprovedBy = NullTextIdentifier
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedBy = BuiltInFunction.NullTextIdentifier ();

// GetOrderMainComplementLevel.List.Current.OrderApprovalLevel.ApprovedOn = NullDate
localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApprovalLevel.ssApprovedOn = BuiltInFunction.NullDate ();
// OrderApprovalLevelCreateOrUpdate
localVars.resOrderApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApprovalLevel,cancellationToken);

// OrderApprovalCreateOrUpdate
localVars.resOrderApprovalCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalCreateOrUpdate(requestContext,localVars.queryResGetOrderMainComplementLevel_outParamList.CurrentRec.ssENOrderApproval,cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionGoBackToComplement {

private static async Task<RC_7074703fd377ca40d733f2d5d8d3fde2> datasetGetOrderMainComplementLevelReadDbAsync(RC_7074703fd377ca40d733f2d5d8d3fde2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainComplementLevel" LZg2ySTTjUC8xlnzJ3xIPg of Action "GoBackToComplement"
public static async Task<(RL_466c605dd07558761818d5a27c59c2b8,long)> datasetGetOrderMainComplementLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GoBackToComplement.GetOrderMainComplementLevel", "c936982d-d324-408d-bcc6-59f3277c483e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GoBackToComplement.GetOrderMainComplementLevel", "c936982d-d324-408d-bcc6-59f3277c483e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.o6T9ESC+c0Cfli6+L6OfWg/NodesNotShownInESpaceTree.LZg2ySTTjUC8xlnzJ3xIPg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval\".\"id\" o0, \"enorderapproval\".\"orderid\" o1, \"enorderapproval\".\"currentlevel\" o2, \"enorderapproval\".\"maxlevel\" o3, \"enorderapproval\".\"startedon\" o4, \"enorderapproval\".\"finishedon\" o5, \"enorderapproval\".\"lastapproverpuestodelgerente\" o6, \"enorderapproval\".\"lastapproverpuestodeljefe\" o7, \"enorderapprovallevel\".\"id\" o8, \"enorderapprovallevel\".\"orderapprovalid\" o9, \"enorderapprovallevel\".\"levelnumber\" o10, \"enorderapprovallevel\".\"entraroleid\" o11, \"enorderapprovallevel\".\"assignedto\" o12, \"enorderapprovallevel\".\"assignedon\" o13, \"enorderapprovallevel\".\"approvalstatusid\" o14, \"enorderapprovallevel\".\"approvedby\" o15, \"enorderapprovallevel\".\"approvedon\" o16, \"enorderapprovallevel\".\"rejectedby\" o17, \"enorderapprovallevel\".\"rejectedon\" o18, \"enorderapprovallevel\".\"iscomplement\" o19, \"enorderapprovallevel\".\"isreassigned\" o20, \"enorderapprovallevel\".\"issubstitutefor\" o21, \"enorderapprovallevel\".\"tomodifyby\" o22, \"enorderapprovallevel\".\"tomodifyon\" o23, \"enorderapprovallevel\".\"wascanceledby\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain3\" Left JOIN {OrderApproval} \"enorderapproval\" ON (\"enordermain3\".\"id\" = \"enorderapproval\".\"orderid\"))  Left JOIN {OrderApprovalLevel} \"enorderapprovallevel\" ON (\"enorderapproval\".\"id\" = \"enorderapprovallevel\".\"orderapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain3\".\"id\" = @qporOrderMain_Id) AND (\"enordermain3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain3\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel\".\"iscomplement\" = 1)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainComplementLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GoBackToComplement.GetOrderMainComplementLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_466c605dd07558761818d5a27c59c2b8 _tmp = new RL_466c605dd07558761818d5a27c59c2b8();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainComplementLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GoBackToComplement.GetOrderMainComplementLevel.List", cancellationToken: cancellationToken);
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
