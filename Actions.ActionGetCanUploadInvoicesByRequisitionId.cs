namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetCanUploadInvoicesByRequisitionId : VarsBag {
public long inParami_RequisitionId;
public RL_30636074d08fd7e7f28d138ca9feb3da queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamList = new RL_30636074d08fd7e7f28d138ca9feb3da();
public long queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamCount = 0L;

public lcvGetCanUploadInvoicesByRequisitionId(long inParami_RequisitionId) {
this.inParami_RequisitionId = inParami_RequisitionId;
}
}
public class lcoGetCanUploadInvoicesByRequisitionId : VarsBag {
public bool outParami_CanUpload = false;

public lcoGetCanUploadInvoicesByRequisitionId() {
}
}
/// <summary>
/// Action <code>GetCanUploadInvoicesByRequisitionId</code> that represents the Service Studio action
///  <code>GetCanUploadInvoicesByRequisitionId</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionGetCanUploadInvoicesByRequisitionId(IRequestContext requestContext,long inParami_RequisitionId,CancellationToken cancellationToken) {
bool outParami_CanUpload = default;
lcoGetCanUploadInvoicesByRequisitionId result = new lcoGetCanUploadInvoicesByRequisitionId();
lcvGetCanUploadInvoicesByRequisitionId localVars = new lcvGetCanUploadInvoicesByRequisitionId(inParami_RequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetCanUploadInvoicesByRequisitionId", "2779b5ba-f797-4092-8712-795a450b0759"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetCanUploadInvoicesByRequisitionId", "2779b5ba-f797-4092-8712-795a450b0759", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords = 1;
if (datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords < 1) datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords = 1;
int datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_startIndex = 0;(localVars.queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamList,localVars.queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamCount) = await FuncActionGetCanUploadInvoicesByRequisitionId.datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId(requestContext,datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords,datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),localVars.inParami_RequisitionId,cancellationToken);

// i_CanUpload = notGetSpecialWorkflowUploadPuestoesByEntraRoleId.List.Empty
result.outParami_CanUpload=(!localVars.queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamList.Empty);
} //close CreateActionActivity using block
} // try

finally {
outParami_CanUpload = result.outParami_CanUpload;
} // inner-finally
RETURN_STATEMENT:
return outParami_CanUpload;
}

public static class FuncActionGetCanUploadInvoicesByRequisitionId {

private static async Task<RC_f8a6a0591753be81aad5115c1222bf32> datasetGetSpecialWorkflowUploadPuestoesByEntraRoleIdReadDbAsync(RC_f8a6a0591753be81aad5115c1222bf32 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENSpecialWorkflows.Read( r, ref index);
rec.ssENSpecialWorkflowUploadPuestos.Read( r, ref index);
return rec;
}
// Query Function "GetSpecialWorkflowUploadPuestoesByEntraRoleId" cnWYC43emE2o8V0uztUMtg of Action "GetCanUploadInvoicesByRequisitionId"
public static async Task<(RL_30636074d08fd7e7f28d138ca9feb3da,long)> datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenSpecialWorkflowUploadPuestos_EntraRoleId,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetCanUploadInvoicesByRequisitionId.GetSpecialWorkflowUploadPuestoesByEntraRoleId", "0b987572-de8d-4d98-a8f1-5d2eced50cb6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetCanUploadInvoicesByRequisitionId.GetSpecialWorkflowUploadPuestoesByEntraRoleId", "0b987572-de8d-4d98-a8f1-5d2eced50cb6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.urV5J5f3kkCHEnlaRQsHWQ/NodesNotShownInESpaceTree.cnWYC43emE2o8V0uztUMtg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38");
fromBuilder.Append(" FROM ((({RequisitionApproval} \"enrequisitionapproval5\" Inner JOIN {ApprovalProcess} \"enapprovalprocess2\" ON (\"enrequisitionapproval5\".\"aprovalprocessid\" = \"enapprovalprocess2\".\"id\"))  Left JOIN {SpecialWorkflows} \"enspecialworkflows\" ON (\"enapprovalprocess2\".\"specialworkflowid\" = \"enspecialworkflows\".\"id\"))  Left JOIN {SpecialWorkflowUploadPuestos} \"enspecialworkflowuploadpuestos\" ON (\"enspecialworkflows\".\"id\" = \"enspecialworkflowuploadpuestos\".\"specialworkflowid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval5\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval5\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval5\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenSpecialWorkflowUploadPuestos_EntraRoleId != 0) {
whereBuilder.Append("((\"enspecialworkflowuploadpuestos\".\"entraroleid\" = @qpenSpecialWorkflowUploadPuestos_EntraRoleId) AND (\"enspecialworkflowuploadpuestos\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenSpecialWorkflowUploadPuestos_EntraRoleId", DbType.Int64, qpenSpecialWorkflowUploadPuestos_EntraRoleId);
} else {
whereBuilder.Append("(\"enspecialworkflowuploadpuestos\".\"entraroleid\" IS NULL)");
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
RL_30636074d08fd7e7f28d138ca9feb3da outParamList = new RL_30636074d08fd7e7f28d138ca9feb3da();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSpecialWorkflowUploadPuestoesByEntraRoleIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetCanUploadInvoicesByRequisitionId.GetSpecialWorkflowUploadPuestoesByEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_30636074d08fd7e7f28d138ca9feb3da _tmp = new RL_30636074d08fd7e7f28d138ca9feb3da();
_tmp.AlternateReadDbMethodAsync = datasetGetSpecialWorkflowUploadPuestoesByEntraRoleIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetCanUploadInvoicesByRequisitionId.GetSpecialWorkflowUploadPuestoesByEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_30636074d08fd7e7f28d138ca9feb3da)_tmp;
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
