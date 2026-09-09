namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingProcess_Create : VarsBag {
public long inParamInvoiceId;
public string inParamComment;
public bool inParamIsFCP;
public long inParamRequisitionId;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>SupplierId</code> that represents the Service Studio SupplierIdentifier
///  <code>SupplierId</code> <p>Description: </p>
/// </summary>
public long varLcSupplierId = 0L;

public Actions.lcoInvoiceAccountingProcess_Create_Req resInvoiceAccountingProcess_Create_Req =  new Actions.lcoInvoiceAccountingProcess_Create_Req();
public RL_4e909af3a15d1687c03c789af38db7ae queryResGetInvoiceAccountingProcessesByInvoiceId_outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
public long queryResGetInvoiceAccountingProcessesByInvoiceId_outParamCount = 0L;

public Actions.lcoInvoiceAccounting_ProcessCreate resInvoiceAccounting_ProcessCreate =  new Actions.lcoInvoiceAccounting_ProcessCreate();
public Actions.lcoInvoiceAccountingProcess_Create_Inv resInvoiceAccountingProcess_Create_Inv =  new Actions.lcoInvoiceAccountingProcess_Create_Inv();
public Actions.lcoInvoiceAccountingProcess_CheckOngoing resInvoiceAccountingProcess_CheckOngoing =  new Actions.lcoInvoiceAccountingProcess_CheckOngoing();
public lcvInvoiceAccountingProcess_Create(long inParamInvoiceId, string inParamComment, bool inParamIsFCP, long inParamRequisitionId, int inParamOffsetUtc) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamComment = inParamComment;
this.inParamIsFCP = inParamIsFCP;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
/// <summary>
/// Action <code>InvoiceAccountingProcess_Create</code> that represents the Service Studio action
///  <code>InvoiceAccountingProcess_Create</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvoiceAccountingProcess_Create(IRequestContext requestContext,long inParamInvoiceId,string inParamComment,bool inParamIsFCP,long inParamRequisitionId,int inParamOffsetUtc,CancellationToken cancellationToken) {
lcvInvoiceAccountingProcess_Create localVars = new lcvInvoiceAccountingProcess_Create(inParamInvoiceId, inParamComment, inParamIsFCP, inParamRequisitionId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingProcess_Create", "e40b2c67-8df6-4197-a514-5ac09e368352"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingProcess_Create", "e40b2c67-8df6-4197-a514-5ac09e368352", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// is requisition
if(((localVars.inParamRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// InvoiceAccountingProcess_Create_Req
localVars.resInvoiceAccountingProcess_Create_Req.outParamSupplierId = await Actions.ActionInvoiceAccountingProcess_Create_Req(requestContext,localVars.inParamRequisitionId,cancellationToken);

// SupplierId = InvoiceAccountingProcess_Create_Req.SupplierId
localVars.varLcSupplierId=localVars.resInvoiceAccountingProcess_Create_Req.outParamSupplierId;
} else {
// InvoiceAccountingProcess_Create_Inv
localVars.resInvoiceAccountingProcess_Create_Inv.outParamSupplierId = await Actions.ActionInvoiceAccountingProcess_Create_Inv(requestContext,localVars.inParamInvoiceId,localVars.inParamIsFCP,cancellationToken);

// SupplierId = InvoiceAccountingProcess_Create_Inv.SupplierId
localVars.varLcSupplierId=localVars.resInvoiceAccountingProcess_Create_Inv.outParamSupplierId;
}

// Query datasetGetInvoiceAccountingProcessesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessesByInvoiceId_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessesByInvoiceId_maxRecords < 1) datasetGetInvoiceAccountingProcessesByInvoiceId_maxRecords = 1;
int datasetGetInvoiceAccountingProcessesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessesByInvoiceId_outParamList,localVars.queryResGetInvoiceAccountingProcessesByInvoiceId_outParamCount) = await FuncActionInvoiceAccountingProcess_Create.datasetGetInvoiceAccountingProcessesByInvoiceId(requestContext,datasetGetInvoiceAccountingProcessesByInvoiceId_maxRecords,datasetGetInvoiceAccountingProcessesByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// InvoiceAccountingProcess_CheckOngoing
(localVars.resInvoiceAccountingProcess_CheckOngoing.outParamIsOngoing,localVars.resInvoiceAccountingProcess_CheckOngoing.outParamInvoiceAccountingProcessId) = await Actions.ActionInvoiceAccountingProcess_CheckOngoing(requestContext,localVars.varLcSupplierId,cancellationToken);

// InvoiceAccounting_ProcessCreate
localVars.resInvoiceAccounting_ProcessCreate.outParamId = await Actions.ActionInvoiceAccounting_ProcessCreate(requestContext,new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceId = localVars.inParamInvoiceId, ssRequisitionId = localVars.inParamRequisitionId, ssOffsetUtc = localVars.inParamOffsetUtc, ssComment = localVars.inParamComment, ssProcessNumber = (1+localVars.queryResGetInvoiceAccountingProcessesByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssProcessNumber), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssNextTry = 1, ssInvoiceProcessStatusId = ((localVars.resInvoiceAccountingProcess_CheckOngoing.outParamIsOngoing) ? ((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("Tc6389H3X0+sBfcYBvMR1g"))).ssId) : ((ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"))).ssId)) },cancellationToken);

// is ongoing
if((!(localVars.resInvoiceAccountingProcess_CheckOngoing.outParamIsOngoing))) {
{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnAccountingProcess", "cbb9d05e-cad2-4316-b259-50b4e1cc913a"))
    using (activitySource.CreateTriggerEventActivity("OnAccountingProcess", "cbb9d05e-cad2-4316-b259-50b4e1cc913a", "e865635d-2731-475f-aff9-c64f5aaba1a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnAccountingProcessPayload() {inParamInvoiceAccountingProcessId = localVars.resInvoiceAccounting_ProcessCreate.outParamId,inParamIsFCP = localVars.inParamIsFCP,inParamIsREQ = (localVars.inParamRequisitionId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnAccountingProcess", "e865635d-2731-475f-aff9-c64f5aaba1a6", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceAccountingProcess_Create {

// Query Function "GetInvoiceAccountingProcessesByInvoiceId" Wq4RjUASJkKeIeUtAou_Fw of Action "InvoiceAccountingProcess_Create"
public static async Task<(RL_4e909af3a15d1687c03c789af38db7ae,long)> datasetGetInvoiceAccountingProcessesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingProcess_Create.GetInvoiceAccountingProcessesByInvoiceId", "8d11ae5a-1240-4226-9e21-e52d028bbf17");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingProcess_Create.GetInvoiceAccountingProcessesByInvoiceId", "8d11ae5a-1240-4226-9e21-e52d028bbf17", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ZywL5PaNl0GlFFrAnjaDUg/NodesNotShownInESpaceTree.Wq4RjUASJkKeIeUtAou_Fw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoiceaccountingprocess9\".\"processnumber\" o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {InvoiceAccountingProcess} \"eninvoiceaccountingprocess9\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess9\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceaccountingprocess9\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess9\".\"invoiceid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"eninvoiceaccountingprocess9\".\"processnumber\" DESC ");
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
RL_4e909af3a15d1687c03c789af38db7ae outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingProcess_Create.GetInvoiceAccountingProcessesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4e909af3a15d1687c03c789af38db7ae _tmp = new RL_4e909af3a15d1687c03c789af38db7ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingProcess_Create.GetInvoiceAccountingProcessesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4e909af3a15d1687c03c789af38db7ae)_tmp;
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
