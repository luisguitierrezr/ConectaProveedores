namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveRequisitionCostCenters : VarsBag {
public long inParami_RequisitionId;
public RL_943f36694cec370c0ce0c406bfa23715 inParami_RequisitionCostCenters;
public Actions.lcoRequisitionCostCenterCreateOrUpdate resRequisitionCostCenterCreateOrUpdate =  new Actions.lcoRequisitionCostCenterCreateOrUpdate();
public RL_d3e0bac8462c62ccd7f8cc475394c310 queryResGetRequisitionCostCentersByRequisitionId_outParamList = new RL_d3e0bac8462c62ccd7f8cc475394c310();
public long queryResGetRequisitionCostCentersByRequisitionId_outParamCount = 0L;

public lcvSaveRequisitionCostCenters(long inParami_RequisitionId, RL_943f36694cec370c0ce0c406bfa23715 inParami_RequisitionCostCenters) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionCostCenters = inParami_RequisitionCostCenters;
}
}
/// <summary>
/// Action <code>SaveRequisitionCostCenters</code> that represents the Service Studio action
///  <code>SaveRequisitionCostCenters</code> <p> Description: Action that saves a Requisition Cos
/// t Centers.</p>
/// </summary>
public static async Task ActionSaveRequisitionCostCenters(IRequestContext requestContext,long inParami_RequisitionId,RL_943f36694cec370c0ce0c406bfa23715 inParami_RequisitionCostCenters,CancellationToken cancellationToken) {
lcvSaveRequisitionCostCenters localVars = new lcvSaveRequisitionCostCenters(inParami_RequisitionId, inParami_RequisitionCostCenters);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveRequisitionCostCenters", "cdf69754-6a4b-4bab-a054-31500d2432f5"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveRequisitionCostCenters", "cdf69754-6a4b-4bab-a054-31500d2432f5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionCostCentersByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionCostCentersByRequisitionId_maxRecords = 0;
int datasetGetRequisitionCostCentersByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList,localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamCount) = await FuncActionSaveRequisitionCostCenters.datasetGetRequisitionCostCentersByRequisitionId(requestContext,datasetGetRequisitionCostCentersByRequisitionId_maxRecords,datasetGetRequisitionCostCentersByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionCostCentersByRequisitionId.List
localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionCostCenter
await ExtendedActions.DeleteRequisitionCostCenter(requestContext,localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.CurrentRec.ssENRequisitionCostCenter.ssId,cancellationToken);

localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionCostCentersByRequisitionId_outParamList.EndIteration();
}

// Foreach i_RequisitionCostCenters
localVars.inParami_RequisitionCostCenters.StartIteration();
try {while (!((localVars.inParami_RequisitionCostCenters.Eof))) {
// i_RequisitionCostCenters.Current.Id = NullIdentifier
localVars.inParami_RequisitionCostCenters.CurrentRec.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// i_RequisitionCostCenters.Current.RequisitionId = i_RequisitionId
localVars.inParami_RequisitionCostCenters.CurrentRec.ssRequisitionId = localVars.inParami_RequisitionId;
// RequisitionCostCenterCreateOrUpdate
localVars.resRequisitionCostCenterCreateOrUpdate.outParamId = await Actions.ActionRequisitionCostCenterCreateOrUpdate(requestContext,localVars.inParami_RequisitionCostCenters.CurrentRec,cancellationToken);

localVars.inParami_RequisitionCostCenters.Advance();
}

} finally {
localVars.inParami_RequisitionCostCenters.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSaveRequisitionCostCenters {

// Query Function "GetRequisitionCostCentersByRequisitionId" 1dw4JTV5b0K7P0Wuw+tdog of Action "SaveRequisitionCostCenters"
public static async Task<(RL_d3e0bac8462c62ccd7f8cc475394c310,long)> datasetGetRequisitionCostCentersByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisitionCostCenters.GetRequisitionCostCentersByRequisitionId", "2538dcd5-7935-426f-bb3f-45aec3eb5da2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisitionCostCenters.GetRequisitionCostCentersByRequisitionId", "2538dcd5-7935-426f-bb3f-45aec3eb5da2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.VJf2zUtqq0ugVDFQDSQy9Q/NodesNotShownInESpaceTree.1dw4JTV5b0K7P0Wuw+tdog, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncostcenter\".\"id\" o0, NULL o1, NULL o2");
fromBuilder.Append(" FROM {RequisitionCostCenter} \"enrequisitioncostcenter\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncostcenter\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncostcenter\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncostcenter\".\"requisitionid\" IS NULL)");
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
RL_d3e0bac8462c62ccd7f8cc475394c310 outParamList = new RL_d3e0bac8462c62ccd7f8cc475394c310();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisitionCostCenters.GetRequisitionCostCentersByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d3e0bac8462c62ccd7f8cc475394c310 _tmp = new RL_d3e0bac8462c62ccd7f8cc475394c310();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisitionCostCenters.GetRequisitionCostCentersByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d3e0bac8462c62ccd7f8cc475394c310)_tmp;
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
