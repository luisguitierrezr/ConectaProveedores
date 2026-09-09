namespace ssConectaProveedores;

public partial class Actions {
public class lcvLastApproverGerenteJefeOrdersFill : VarsBag {
public Actions.lcoOrderApprovalCreateOrUpdate resOrderApprovalCreateOrUpdate =  new Actions.lcoOrderApprovalCreateOrUpdate();
public Actions.lcoGetLastAppoverGerenteJefe resGetLastAppoverGerenteJefe =  new Actions.lcoGetLastAppoverGerenteJefe();
public RL_4ff1b710be996e0ae107a46588f5914b queryResGetOrderMains_outParamList = new RL_4ff1b710be996e0ae107a46588f5914b();
public long queryResGetOrderMains_outParamCount = 0L;

public lcvLastApproverGerenteJefeOrdersFill() {
}
}
/// <summary>
/// Action <code>LastApproverGerenteJefeOrdersFill</code> that represents the Service Studio action
///  <code>LastApproverGerenteJefeOrdersFill</code> <p> Description: Action to Fill Last Approve
/// r Gerente Jefe Orders.</p>
/// </summary>
public static async Task ActionLastApproverGerenteJefeOrdersFill(IRequestContext requestContext,CancellationToken cancellationToken) {
lcvLastApproverGerenteJefeOrdersFill localVars = new lcvLastApproverGerenteJefeOrdersFill();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("LastApproverGerenteJefeOrdersFill", "5ede9e58-a687-4520-8606-f3d7176325b4"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("LastApproverGerenteJefeOrdersFill", "5ede9e58-a687-4520-8606-f3d7176325b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderMains
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMains_maxRecords = 999999999;
if (datasetGetOrderMains_maxRecords < 1) datasetGetOrderMains_maxRecords = 1;
int datasetGetOrderMains_startIndex = 0;(localVars.queryResGetOrderMains_outParamList,localVars.queryResGetOrderMains_outParamCount) = await FuncActionLastApproverGerenteJefeOrdersFill.datasetGetOrderMains(requestContext,datasetGetOrderMains_maxRecords,datasetGetOrderMains_startIndex,IterationMultiplicity.Single,cancellationToken);

// Foreach GetOrderMains.List
localVars.queryResGetOrderMains_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderMains_outParamList.Eof))) {
// GetLastAppoverGerenteJefe
(localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelGerente_CxP,localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelJefe_CxP) = await Actions.ActionGetLastAppoverGerenteJefe(requestContext,localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// LastApproverGerenteJefe
// GetOrderMains.List.Current.OrderApproval.LastApproverPuestodelGerente = GetLastAppoverGerenteJefe.o_LastApproverPuestodelGerente_CxP
localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderApproval.ssLastApproverPuestodelGerente = localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelGerente_CxP;

// GetOrderMains.List.Current.OrderApproval.LastApproverPuestodelJefe = GetLastAppoverGerenteJefe.o_LastApproverPuestodelJefe_CxP
localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderApproval.ssLastApproverPuestodelJefe = localVars.resGetLastAppoverGerenteJefe.outParamo_LastApproverPuestodelJefe_CxP;
// OrderApprovalCreateOrUpdate
localVars.resOrderApprovalCreateOrUpdate.outParamId = await Actions.ActionOrderApprovalCreateOrUpdate(requestContext,localVars.queryResGetOrderMains_outParamList.CurrentRec.ssENOrderApproval,cancellationToken);

// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

localVars.queryResGetOrderMains_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderMains_outParamList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionLastApproverGerenteJefeOrdersFill {

private static async Task<RC_158d774b1951665b144a20e40b8bb511> datasetGetOrderMainsReadDbAsync(RC_158d774b1951665b144a20e40b8bb511 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMains" wfFRqsxiW0KyUCK5xt+niQ of Action "LastApproverGerenteJefeOrdersFill"
public static async Task<(RL_4ff1b710be996e0ae107a46588f5914b,long)> datasetGetOrderMains(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("LastApproverGerenteJefeOrdersFill.GetOrderMains", "aa51f1c1-62cc-425b-b250-22b9c6dfa789");
using var queryActivity = activitySource.CreateAggregateQueryActivity("LastApproverGerenteJefeOrdersFill.GetOrderMains", "aa51f1c1-62cc-425b-b250-22b9c6dfa789", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.WJ7eXoemIEWGBvPXF2MltA/NodesNotShownInESpaceTree.wfFRqsxiW0KyUCK5xt+niQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval8\".\"id\" o0, \"enorderapproval8\".\"orderid\" o1, \"enorderapproval8\".\"currentlevel\" o2, \"enorderapproval8\".\"maxlevel\" o3, \"enorderapproval8\".\"startedon\" o4, \"enorderapproval8\".\"finishedon\" o5, \"enorderapproval8\".\"lastapproverpuestodelgerente\" o6, \"enorderapproval8\".\"lastapproverpuestodeljefe\" o7, \"enordermain28\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36");
fromBuilder.Append(" FROM ({OrderMain} \"enordermain28\" Left JOIN {OrderApproval} \"enorderapproval8\" ON (\"enordermain28\".\"id\" = \"enorderapproval8\".\"orderid\")) ");
whereBuilder.Append(" WHERE (\"enordermain28\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("0+H9br0_XEGSD61CF1frPg"))).ssId);
whereBuilder.Append(") AND ((\"enorderapproval8\".\"lastapproverpuestodelgerente\" = '') OR (\"enorderapproval8\".\"lastapproverpuestodeljefe\" = ''))");
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
RL_4ff1b710be996e0ae107a46588f5914b outParamList = new RL_4ff1b710be996e0ae107a46588f5914b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query LastApproverGerenteJefeOrdersFill.GetOrderMains.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4ff1b710be996e0ae107a46588f5914b _tmp = new RL_4ff1b710be996e0ae107a46588f5914b();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query LastApproverGerenteJefeOrdersFill.GetOrderMains.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4ff1b710be996e0ae107a46588f5914b)_tmp;
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
