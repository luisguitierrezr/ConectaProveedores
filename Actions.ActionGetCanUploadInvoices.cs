namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetCanUploadInvoices : VarsBag {
public RL_15d34ef3d5d1659033627e8c01970200 queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamList = new RL_15d34ef3d5d1659033627e8c01970200();
public long queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamCount = 0L;

public lcvGetCanUploadInvoices() {
}
}
public class lcoGetCanUploadInvoices : VarsBag {
public bool outParami_CanUpload = false;

public lcoGetCanUploadInvoices() {
}
}
/// <summary>
/// Action <code>GetCanUploadInvoices</code> that represents the Service Studio action
///  <code>GetCanUploadInvoices</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionGetCanUploadInvoices(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParami_CanUpload = default;
lcoGetCanUploadInvoices result = new lcoGetCanUploadInvoices();
lcvGetCanUploadInvoices localVars = new lcvGetCanUploadInvoices();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetCanUploadInvoices", "6c14e77b-83b9-4637-9cfb-f61bff3b4286"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetCanUploadInvoices", "6c14e77b-83b9-4637-9cfb-f61bff3b4286", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords = 1;
if (datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords < 1) datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords = 1;
int datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_startIndex = 0;(localVars.queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamList,localVars.queryResGetSpecialWorkflowUploadPuestoesByEntraRoleId_outParamCount) = await FuncActionGetCanUploadInvoices.datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId(requestContext,datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_maxRecords,datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserEntraRoleId(requestContext,BuiltInFunction.GetUserId (),cancellationToken)),cancellationToken);

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

public static class FuncActionGetCanUploadInvoices {

private static async Task<RC_0a46451d8756128c280ededf206b35a5> datasetGetSpecialWorkflowUploadPuestoesByEntraRoleIdReadDbAsync(RC_0a46451d8756128c280ededf206b35a5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENSpecialWorkflows.Read( r, ref index);
rec.ssENSpecialWorkflowUploadPuestos.Read( r, ref index);
return rec;
}
// Query Function "GetSpecialWorkflowUploadPuestoesByEntraRoleId" XBJfrRMasEKtyixAIRHlXg of Action "GetCanUploadInvoices"
public static async Task<(RL_15d34ef3d5d1659033627e8c01970200,long)> datasetGetSpecialWorkflowUploadPuestoesByEntraRoleId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenSpecialWorkflowUploadPuestos_EntraRoleId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetCanUploadInvoices.GetSpecialWorkflowUploadPuestoesByEntraRoleId", "ad5f125c-1a13-42b0-adca-2c402111e55e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetCanUploadInvoices.GetSpecialWorkflowUploadPuestoesByEntraRoleId", "ad5f125c-1a13-42b0-adca-2c402111e55e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.e+cUbLmDN0ac+_Yb_ztChg/NodesNotShownInESpaceTree.XBJfrRMasEKtyixAIRHlXg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess8\" Left JOIN {SpecialWorkflows} \"enspecialworkflows1\" ON (\"enapprovalprocess8\".\"specialworkflowid\" = \"enspecialworkflows1\".\"id\"))  Left JOIN {SpecialWorkflowUploadPuestos} \"enspecialworkflowuploadpuestos1\" ON (\"enspecialworkflows1\".\"id\" = \"enspecialworkflowuploadpuestos1\".\"specialworkflowid\")) ");
whereBuilder.Append(" WHERE ");
if (qpenSpecialWorkflowUploadPuestos_EntraRoleId != 0) {
whereBuilder.Append("((\"enspecialworkflowuploadpuestos1\".\"entraroleid\" = @qpenSpecialWorkflowUploadPuestos_EntraRoleId) AND (\"enspecialworkflowuploadpuestos1\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenSpecialWorkflowUploadPuestos_EntraRoleId", DbType.Int64, qpenSpecialWorkflowUploadPuestos_EntraRoleId);
} else {
whereBuilder.Append("(\"enspecialworkflowuploadpuestos1\".\"entraroleid\" IS NULL)");
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
RL_15d34ef3d5d1659033627e8c01970200 outParamList = new RL_15d34ef3d5d1659033627e8c01970200();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSpecialWorkflowUploadPuestoesByEntraRoleIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetCanUploadInvoices.GetSpecialWorkflowUploadPuestoesByEntraRoleId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_15d34ef3d5d1659033627e8c01970200 _tmp = new RL_15d34ef3d5d1659033627e8c01970200();
_tmp.AlternateReadDbMethodAsync = datasetGetSpecialWorkflowUploadPuestoesByEntraRoleIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetCanUploadInvoices.GetSpecialWorkflowUploadPuestoesByEntraRoleId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_15d34ef3d5d1659033627e8c01970200)_tmp;
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
