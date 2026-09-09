namespace ssConectaProveedores;

public partial class Actions {
public class lcvClearOtherApproversFromSameLevel : VarsBag {
public long inParami_RequisitionId;
public int inParami_LevelNumber;
public long inParami_RequisitionApprovalLevelId;
public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitionApprovalLevelsById_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitionApprovalLevelsById_outParamCount = 0L;

public lcvClearOtherApproversFromSameLevel(long inParami_RequisitionId, int inParami_LevelNumber, long inParami_RequisitionApprovalLevelId) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_LevelNumber = inParami_LevelNumber;
this.inParami_RequisitionApprovalLevelId = inParami_RequisitionApprovalLevelId;
}
}
/// <summary>
/// Action <code>ClearOtherApproversFromSameLevel</code> that represents the Service Studio action
///  <code>ClearOtherApproversFromSameLevel</code> <p> Description: </p>
/// </summary>
public static async Task ActionClearOtherApproversFromSameLevel(IRequestContext requestContext,long inParami_RequisitionId,int inParami_LevelNumber,long inParami_RequisitionApprovalLevelId,CancellationToken cancellationToken) {
lcvClearOtherApproversFromSameLevel localVars = new lcvClearOtherApproversFromSameLevel(inParami_RequisitionId, inParami_LevelNumber, inParami_RequisitionApprovalLevelId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ClearOtherApproversFromSameLevel", "6787513a-2949-4521-9068-39b3b9b1d753"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ClearOtherApproversFromSameLevel", "6787513a-2949-4521-9068-39b3b9b1d753", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionApprovalLevelsById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalLevelsById_maxRecords = 0;
int datasetGetRequisitionApprovalLevelsById_startIndex = 0;(localVars.queryResGetRequisitionApprovalLevelsById_outParamList,localVars.queryResGetRequisitionApprovalLevelsById_outParamCount) = await FuncActionClearOtherApproversFromSameLevel.datasetGetRequisitionApprovalLevelsById(requestContext,datasetGetRequisitionApprovalLevelsById_maxRecords,datasetGetRequisitionApprovalLevelsById_startIndex,IterationMultiplicity.Single,localVars.inParami_LevelNumber,localVars.inParami_RequisitionApprovalLevelId,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionApprovalLevelsById.List
localVars.queryResGetRequisitionApprovalLevelsById_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionApprovalLevelsById_outParamList.Eof))) {
// RequisitionApprovalLevelDelete
await Actions.ActionRequisitionApprovalLevelDelete(requestContext,localVars.queryResGetRequisitionApprovalLevelsById_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssId,cancellationToken);

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

public static class FuncActionClearOtherApproversFromSameLevel {

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionApprovalLevelsByIdReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalLevelsById" __IIVrMnlUGLuvtcUjrkZg of Action "ClearOtherApproversFromSameLevel"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitionApprovalLevelsById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpinRequisitionApprovalLevel_LevelNumber,long qpreRequisitionApprovalLevel_Id,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ClearOtherApproversFromSameLevel.GetRequisitionApprovalLevelsById", "5608f2ff-27b3-4195-8bba-fb5c523ae466");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ClearOtherApproversFromSameLevel.GetRequisitionApprovalLevelsById", "5608f2ff-27b3-4195-8bba-fb5c523ae466", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.OlGHZ0kpIUWQaDmzubHXUw/NodesNotShownInESpaceTree.__IIVrMnlUGLuvtcUjrkZg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, \"enrequisitionapprovallevel8\".\"id\" o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition30\" Left JOIN {RequisitionApproval} \"enrequisitionapproval9\" ON (\"enrequisition30\".\"id\" = \"enrequisitionapproval9\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel8\" ON (\"enrequisitionapproval9\".\"id\" = \"enrequisitionapprovallevel8\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition30\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition30\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition30\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel8\".\"levelnumber\" = @qpinRequisitionApprovalLevel_LevelNumber) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinRequisitionApprovalLevel_LevelNumber", DbType.Int32, qpinRequisitionApprovalLevel_LevelNumber);
if (qpreRequisitionApprovalLevel_Id != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel8\".\"id\" <> @qpreRequisitionApprovalLevel_Id) OR (\"enrequisitionapprovallevel8\".\"id\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApprovalLevel_Id", DbType.Int64, qpreRequisitionApprovalLevel_Id);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel8\".\"id\" IS NOT NULL)");
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalLevelsByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ClearOtherApproversFromSameLevel.GetRequisitionApprovalLevelsById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ClearOtherApproversFromSameLevel.GetRequisitionApprovalLevelsById.List", cancellationToken: cancellationToken);
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
