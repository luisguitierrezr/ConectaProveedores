namespace ssConectaProveedores;

public partial class Actions {
public class lcvDeleteOneRequisition : VarsBag {
public RL_c30d58936515a1bd8b3b632af88fba4d queryResGetRequisitions_outParamList = new RL_c30d58936515a1bd8b3b632af88fba4d();
public long queryResGetRequisitions_outParamCount = 0L;

public lcvDeleteOneRequisition() {
}
}
/// <summary>
/// Action <code>DeleteOneRequisition</code> that represents the Service Studio action
///  <code>DeleteOneRequisition</code> <p> Description: </p>
/// </summary>
public static async Task ActionDeleteOneRequisition(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvDeleteOneRequisition localVars = new lcvDeleteOneRequisition();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DeleteOneRequisition", "9bffb939-89c1-44f6-a75a-bafa9816acfe"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DeleteOneRequisition", "9bffb939-89c1-44f6-a75a-bafa9816acfe", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitions_maxRecords = 1;
if (datasetGetRequisitions_maxRecords < 1) datasetGetRequisitions_maxRecords = 1;
int datasetGetRequisitions_startIndex = 0;(localVars.queryResGetRequisitions_outParamList,localVars.queryResGetRequisitions_outParamCount) = await FuncActionDeleteOneRequisition.datasetGetRequisitions(requestContext,datasetGetRequisitions_maxRecords,datasetGetRequisitions_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetRequisitions.List
localVars.queryResGetRequisitions_outParamList.StartIteration();
try {while (!((localVars.queryResGetRequisitions_outParamList.Eof))) {
// DeleteRequisition
await ExtendedActions.DeleteRequisition(requestContext,localVars.queryResGetRequisitions_outParamList.CurrentRec.ssENRequisition.ssId,cancellationToken);

localVars.queryResGetRequisitions_outParamList.Advance();
}

} finally {
localVars.queryResGetRequisitions_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionDeleteOneRequisition {

private static async Task<RC_7fadf2cbff2fecd5fbe9b2e13c5588e9> datasetGetRequisitionsReadDbAsync(RC_7fadf2cbff2fecd5fbe9b2e13c5588e9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDistribution.Read( r, ref index);
rec.ssENFrequency.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionStatus.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitions" 4f1WOJ6ax0urJ0amxDUlgA of Action "DeleteOneRequisition"
public static async Task<(RL_c30d58936515a1bd8b3b632af88fba4d,long)> datasetGetRequisitions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("DeleteOneRequisition.GetRequisitions", "3856fde1-9a9e-4bc7-ab27-46a6c4352580");
using var queryActivity = activitySource.CreateAggregateQueryActivity("DeleteOneRequisition.GetRequisitions", "3856fde1-9a9e-4bc7-ab27-46a6c4352580", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Obn_m8GJ9kSnWrr6mBas_g/NodesNotShownInESpaceTree.4f1WOJ6ax0urJ0amxDUlgA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enrequisition42\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71");
fromBuilder.Append(" FROM ((({Requisition} \"enrequisition42\" Left JOIN {RequisitionStatus} \"enrequisitionstatus\" ON (\"enrequisition42\".\"requisitionstatusid\" = \"enrequisitionstatus\".\"id\"))  Left JOIN {Frequency} \"enfrequency3\" ON (\"enrequisition42\".\"frequencyid\" = \"enfrequency3\".\"id\"))  Left JOIN {Distribution} \"endistribution\" ON (\"enrequisition42\".\"distributionid\" = \"endistribution\".\"id\")) ");
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
RL_c30d58936515a1bd8b3b632af88fba4d outParamList = new RL_c30d58936515a1bd8b3b632af88fba4d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query DeleteOneRequisition.GetRequisitions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c30d58936515a1bd8b3b632af88fba4d _tmp = new RL_c30d58936515a1bd8b3b632af88fba4d();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query DeleteOneRequisition.GetRequisitions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c30d58936515a1bd8b3b632af88fba4d)_tmp;
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
