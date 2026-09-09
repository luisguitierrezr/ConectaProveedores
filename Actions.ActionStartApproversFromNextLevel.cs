namespace ssConectaProveedores;

public partial class Actions {
public class lcvStartApproversFromNextLevel : VarsBag {
public long inParami_RequisitionId;
public int inParami_LevelNumber;
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionApprovalLevelsById_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionApprovalLevelsById_outParamCount = 0L;

public Actions.lcoRequisitionApprovalLevelCreateOrUpdate resRequisitionApprovalLevelCreateOrUpdate =  new Actions.lcoRequisitionApprovalLevelCreateOrUpdate();
public lcvStartApproversFromNextLevel(long inParami_RequisitionId, int inParami_LevelNumber) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_LevelNumber = inParami_LevelNumber;
}
}
/// <summary>
/// Action <code>StartApproversFromNextLevel</code> that represents the Service Studio action
///  <code>StartApproversFromNextLevel</code> <p> Description: </p>
/// </summary>
public static async Task ActionStartApproversFromNextLevel(IRequestContext requestContext,long inParami_RequisitionId,int inParami_LevelNumber,CancellationToken cancellationToken) {
lcvStartApproversFromNextLevel localVars = new lcvStartApproversFromNextLevel(inParami_RequisitionId, inParami_LevelNumber);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("StartApproversFromNextLevel", "e483757f-89d9-435d-96d5-2f817d42ff03"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("StartApproversFromNextLevel", "e483757f-89d9-435d-96d5-2f817d42ff03", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionApprovalLevelsById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevelsById_maxRecords = 0;
int datasetGetRequisitionApprovalLevelsById_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevelsById_outParamList,localVars.queryResGetRequisitionApprovalLevelsById_outParamCount) = await FuncActionStartApproversFromNextLevel.datasetGetRequisitionApprovalLevelsById(requestContext,datasetGetRequisitionApprovalLevelsById_maxRecords,datasetGetRequisitionApprovalLevelsById_startIndex,IterationMultiplicity.Single,localVars.inParami_LevelNumber,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionApprovalLevelsById.List
localVars.queryResGetRequisitionApprovalLevelsById_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionApprovalLevelsById_outParamList.Eof))) {
// GetRequisitionApprovalLevelsById.List.Current.RequisitionApprovalLevel.ApprovalStatusId = NotApproved
localVars.queryResGetRequisitionApprovalLevelsById_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovalStatusId = (ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId;
// RequisitionApprovalLevelCreateOrUpdate
localVars.resRequisitionApprovalLevelCreateOrUpdate.outParamId = await Actions.ActionRequisitionApprovalLevelCreateOrUpdate(requestContext,localVars.queryResGetRequisitionApprovalLevelsById_outParamList.CurrentRec.ssENRequisitionApprovalLevel,cancellationToken);

localVars.queryResGetRequisitionApprovalLevelsById_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionApprovalLevelsById_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionStartApproversFromNextLevel {

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionApprovalLevelsByIdReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalLevelsById" XeycaOaVAU+lTS+Ixb2Oew of Action "StartApproversFromNextLevel"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionApprovalLevelsById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpinRequisitionApprovalLevel_LevelNumber,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("StartApproversFromNextLevel.GetRequisitionApprovalLevelsById", "689cec5d-95e6-4f01-a54d-2f88c5bd8e7b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("StartApproversFromNextLevel.GetRequisitionApprovalLevelsById", "689cec5d-95e6-4f01-a54d-2f88c5bd8e7b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.f3WD5NmJXUOW1S+BfUL_Aw/NodesNotShownInESpaceTree.XeycaOaVAU+lTS+Ixb2Oew, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enrequisitionapprovallevel20\".\"id\" o68, \"enrequisitionapprovallevel20\".\"requisitionapprovalid\" o69, \"enrequisitionapprovallevel20\".\"levelnumber\" o70, \"enrequisitionapprovallevel20\".\"applicationroleid\" o71, \"enrequisitionapprovallevel20\".\"entrajobtitle\" o72, \"enrequisitionapprovallevel20\".\"departmentid\" o73, \"enrequisitionapprovallevel20\".\"managementid\" o74, \"enrequisitionapprovallevel20\".\"subdirectionid\" o75, \"enrequisitionapprovallevel20\".\"entraroleid\" o76, \"enrequisitionapprovallevel20\".\"entrausername\" o77, \"enrequisitionapprovallevel20\".\"assignedto\" o78, \"enrequisitionapprovallevel20\".\"needscontract\" o79, \"enrequisitionapprovallevel20\".\"approvalstatusid\" o80, \"enrequisitionapprovallevel20\".\"approvedby\" o81, \"enrequisitionapprovallevel20\".\"approvedon\" o82, \"enrequisitionapprovallevel20\".\"requesttomodifyby\" o83, \"enrequisitionapprovallevel20\".\"requesttomodifyon\" o84, \"enrequisitionapprovallevel20\".\"canceledby\" o85, \"enrequisitionapprovallevel20\".\"canceledon_deprec\" o86, \"enrequisitionapprovallevel20\".\"isaccounting\" o87, \"enrequisitionapprovallevel20\".\"isstartaccounting\" o88, \"enrequisitionapprovallevel20\".\"canceledon_\" o89, \"enrequisitionapprovallevel20\".\"approveasareausuaria\" o90, \"enrequisitionapprovallevel20\".\"ismandatory\" o91, \"enrequisitionapprovallevel20\".\"isreassigned\" o92, \"enrequisitionapprovallevel20\".\"issubstitutefor\" o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition65\" Left JOIN {RequisitionApproval} \"enrequisitionapproval22\" ON (\"enrequisition65\".\"id\" = \"enrequisitionapproval22\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel20\" ON (\"enrequisitionapproval22\".\"id\" = \"enrequisitionapprovallevel20\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition65\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition65\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition65\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel20\".\"levelnumber\" = @qpinRequisitionApprovalLevel_LevelNumber)");
sqlCmd.CreateParameterWithoutReplacements("@qpinRequisitionApprovalLevel_LevelNumber", DbType.Int32, qpinRequisitionApprovalLevel_LevelNumber);
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelsByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query StartApproversFromNextLevel.GetRequisitionApprovalLevelsById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelsByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query StartApproversFromNextLevel.GetRequisitionApprovalLevelsById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f3e9ea72dc7b010c56ee9146ee277c5)_tmp;
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
