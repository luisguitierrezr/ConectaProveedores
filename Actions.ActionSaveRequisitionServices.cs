namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveRequisitionServices : VarsBag {
public long inParami_RequisitionId;
public RL_f631cdf92d6e85a1d6f52da923631909 inParami_RequisitionServices;
public Actions.lcoRequisitionServiceCreateOrUpdate resRequisitionServiceCreateOrUpdate =  new Actions.lcoRequisitionServiceCreateOrUpdate();
public RL_b47d9310671b1b627f451a333bb8980a queryResGetRequisitionServicesByRequisitionId_outParamList = new RL_b47d9310671b1b627f451a333bb8980a();
public long queryResGetRequisitionServicesByRequisitionId_outParamCount = 0L;

public lcvSaveRequisitionServices(long inParami_RequisitionId, RL_f631cdf92d6e85a1d6f52da923631909 inParami_RequisitionServices) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_RequisitionServices = inParami_RequisitionServices;
}
}
/// <summary>
/// Action <code>SaveRequisitionServices</code> that represents the Service Studio action
///  <code>SaveRequisitionServices</code> <p> Description: Action that saves a Requisitio
/// n Services.</p>
/// </summary>
public static async Task ActionSaveRequisitionServices(IRequestContext requestContext,long inParami_RequisitionId,RL_f631cdf92d6e85a1d6f52da923631909 inParami_RequisitionServices,CancellationToken cancellationToken) {
lcvSaveRequisitionServices localVars = new lcvSaveRequisitionServices(inParami_RequisitionId, inParami_RequisitionServices);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveRequisitionServices", "d248d0e4-eff2-4f2e-b273-80b584a94624"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveRequisitionServices", "d248d0e4-eff2-4f2e-b273-80b584a94624", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionServicesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionServicesByRequisitionId_maxRecords = 0;
int datasetGetRequisitionServicesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionServicesByRequisitionId_outParamList,localVars.queryResGetRequisitionServicesByRequisitionId_outParamCount) = await FuncActionSaveRequisitionServices.datasetGetRequisitionServicesByRequisitionId(requestContext,datasetGetRequisitionServicesByRequisitionId_maxRecords,datasetGetRequisitionServicesByRequisitionId_startIndex,IterationMultiplicity.Single,localVars.inParami_RequisitionId,cancellationToken);

// Foreach GetRequisitionServicesByRequisitionId.List
localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.Eof))) {
// DeleteRequisitionService
await ExtendedActions.DeleteRequisitionService(requestContext,localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.CurrentRec.ssENRequisitionService.ssId,cancellationToken);

localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitionServicesByRequisitionId_outParamList.EndIteration();
}

// Foreach i_RequisitionServices
localVars.inParami_RequisitionServices.StartIteration();
try {while (!((localVars.inParami_RequisitionServices.Eof))) {
// i_RequisitionServices.Current.Id = NullIdentifier
localVars.inParami_RequisitionServices.CurrentRec.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// i_RequisitionServices.Current.RequisitionId = i_RequisitionId
localVars.inParami_RequisitionServices.CurrentRec.ssRequisitionId = localVars.inParami_RequisitionId;
// RequisitionServiceCreateOrUpdate
localVars.resRequisitionServiceCreateOrUpdate.outParamId = await Actions.ActionRequisitionServiceCreateOrUpdate(requestContext,localVars.inParami_RequisitionServices.CurrentRec,cancellationToken);

localVars.inParami_RequisitionServices.Advance();
}

} finally {
localVars.inParami_RequisitionServices.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSaveRequisitionServices {

// Query Function "GetRequisitionServicesByRequisitionId" _sc29GNsfEaTYvFTopnj0g of Action "SaveRequisitionServices"
public static async Task<(RL_b47d9310671b1b627f451a333bb8980a,long)> datasetGetRequisitionServicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveRequisitionServices.GetRequisitionServicesByRequisitionId", "f436c7fe-6c63-467c-9362-f153a299e3d2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveRequisitionServices.GetRequisitionServicesByRequisitionId", "f436c7fe-6c63-467c-9362-f153a299e3d2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.5NBI0vLvLk+yc4C1hKlGJA/NodesNotShownInESpaceTree._sc29GNsfEaTYvFTopnj0g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionservice2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {RequisitionService} \"enrequisitionservice2\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionservice2\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionservice2\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionservice2\".\"requisitionid\" IS NULL)");
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
RL_b47d9310671b1b627f451a333bb8980a outParamList = new RL_b47d9310671b1b627f451a333bb8980a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveRequisitionServices.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b47d9310671b1b627f451a333bb8980a _tmp = new RL_b47d9310671b1b627f451a333bb8980a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveRequisitionServices.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b47d9310671b1b627f451a333bb8980a)_tmp;
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
