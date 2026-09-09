namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoice_ManualCall : VarsBag {
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess;
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoiceById_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoiceById_outParamCount = 0L;

public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public lcvInvoice_ManualCall(EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess) {
this.inParamInvoiceAccountingProcess = inParamInvoiceAccountingProcess;
}
}
/// <summary>
/// Action <code>Invoice_ManualCall</code> that represents the Service Studio action
///  <code>Invoice_ManualCall</code> <p> Description: Set Process as Finished and check if there is an
/// y Pending process for the same supplier</p>
/// </summary>
public static async Task ActionInvoice_ManualCall(IRequestContext requestContext,EN_d21666375df829d28ffce8e5e0a3400dEntityRecord inParamInvoiceAccountingProcess,CancellationToken cancellationToken) {
lcvInvoice_ManualCall localVars = new lcvInvoice_ManualCall(inParamInvoiceAccountingProcess);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Invoice_ManualCall", "39640ddb-40a8-42c9-baeb-95510a8e4707"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Invoice_ManualCall", "39640ddb-40a8-42c9-baeb-95510a8e4707", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvoice_ManualCall.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// set ongoing
// InvoiceAccountingProcess.InvoiceProcessStatusId = Ongoing
localVars.inParamInvoiceAccountingProcess.ssInvoiceProcessStatusId = (ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"))).ssId;
// InvoiceAccountingProcessCreateOrUpdate
localVars.resInvoiceAccountingProcessCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingProcessCreateOrUpdate(requestContext,localVars.inParamInvoiceAccountingProcess,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnAccountingProcess", "8015605d-bbf7-4589-b0ea-090f86ea1294"))
    using (activitySource.CreateTriggerEventActivity("OnAccountingProcess", "8015605d-bbf7-4589-b0ea-090f86ea1294", "e865635d-2731-475f-aff9-c64f5aaba1a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnAccountingProcessPayload() {inParamInvoiceAccountingProcessId = localVars.resInvoiceAccountingProcessCreateOrUpdate.outParamId,inParamIsFCP = (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssOrderMainId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())),inParamIsREQ = false};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnAccountingProcess", "e865635d-2731-475f-aff9-c64f5aaba1a6", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoice_ManualCall {

// Query Function "GetInvoiceById" IWncSHTC4EmbVF2H8zi1bw of Action "Invoice_ManualCall"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Invoice_ManualCall.GetInvoiceById", "48dc6921-c274-49e0-9b54-5d87f338b56f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Invoice_ManualCall.GetInvoiceById", "48dc6921-c274-49e0-9b54-5d87f338b56f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.2w1kOahAyUK665VRCo5HBw/NodesNotShownInESpaceTree.IWncSHTC4EmbVF2H8zi1bw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, \"eninvoice13\".\"ordermainid\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice13\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoice13\".\"id\" = @qpinId) AND (\"eninvoice13\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoice13\".\"id\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Invoice_ManualCall.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Invoice_ManualCall.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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
