using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIReqAcc_2SetFinishInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIReqAcc_2SetFinishInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIReqAcc_2SetFinishOutput {
public S4PIReqAcc_2SetFinishOutput() {
}

}

[HttpPost()]
[Route("serviceapi/reqacc_2setfinish")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ReqAcc_2SetFinish", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIReqAcc_2SetFinish(CancellationToken cancellationToken) {return await EndpointAsync<S4PIReqAcc_2SetFinishInput, S4PIReqAcc_2SetFinishOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIReqAcc_2SetFinishInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionReqAcc_2SetFinish(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIReqAcc_2SetFinishOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvReqAcc_2SetFinish : VarsBag {
public long inParamInvoiceAccountingProcessId;
public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate2 =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public RL_00bd7d2e1d6477607f48fdc5409b4a65 queryResGetInvoiceAccountingProcessById_outParamList = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public Actions.lcoInvoiceAccountingProcess_CheckPending resInvoiceAccountingProcess_CheckPending =  new Actions.lcoInvoiceAccountingProcess_CheckPending();
public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate7 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public lcvReqAcc_2SetFinish(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
/// <summary>
/// Action <code>ReqAcc_2SetFinish</code> that represents the Service Studio action
///  <code>ReqAcc_2SetFinish</code> <p> Description: Set Process as Finished and check if there is an
/// y Pending process for the same supplier</p>
/// </summary>
public static async Task ActionReqAcc_2SetFinish(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
lcvReqAcc_2SetFinish localVars = new lcvReqAcc_2SetFinish(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ReqAcc_2SetFinish", "e1b60a3f-af1e-4e99-bf8d-00cf63b54a74"))
using (activitySource.CreateServiceActionActivity("ReqAcc_2SetFinish")){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 0;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionReqAcc_2SetFinish.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// set finished
// GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcess.InvoiceProcessStatusId = Finished
localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId = (ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("b9Zmzw8_MUyampVTkJ_ulw"))).ssId;
// InvoiceAccountingProcessCreateOrUpdate2
localVars.resInvoiceAccountingProcessCreateOrUpdate2.outParamId = await Actions.ActionInvoiceAccountingProcessCreateOrUpdate(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess,cancellationToken);

// ActionTimestampsCreateOrUpdate7
localVars.resActionTimestampsCreateOrUpdate7.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Accounting finished"), ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// InvoiceAccountingProcess_CheckPending
(localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess,localVars.resInvoiceAccountingProcess_CheckPending.outParamIsFCP,localVars.resInvoiceAccountingProcess_CheckPending.outParamIsREQ) = await Actions.ActionInvoiceAccountingProcess_CheckPending(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENRequisition.ssSupplierId,cancellationToken);

// empty
if((!((localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// set ongoing
// InvoiceAccountingProcess_CheckPending.InvoiceAccountingProcess.InvoiceProcessStatusId = Ongoing
localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess.ssInvoiceProcessStatusId = (ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"))).ssId;
// InvoiceAccountingProcessCreateOrUpdate
localVars.resInvoiceAccountingProcessCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingProcessCreateOrUpdate(requestContext,localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnAccountingProcess", "ccde210d-cbb1-4265-9217-f73dae9fcb54"))
    using (activitySource.CreateTriggerEventActivity("OnAccountingProcess", "ccde210d-cbb1-4265-9217-f73dae9fcb54", "e865635d-2731-475f-aff9-c64f5aaba1a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnAccountingProcessPayload() {inParamInvoiceAccountingProcessId = localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess.ssId,inParamIsFCP = localVars.resInvoiceAccountingProcess_CheckPending.outParamIsFCP,inParamIsREQ = localVars.resInvoiceAccountingProcess_CheckPending.outParamIsREQ};

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

        public static class FuncActionReqAcc_2SetFinish {
            
private static async Task<RC_bf8addab42f215a7fe4584fe7162ae78> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_bf8addab42f215a7fe4584fe7162ae78 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" vYZHPt80yUWf4dAPZgg2Yw of Action "ReqAcc_2SetFinish"
public static async Task<(RL_00bd7d2e1d6477607f48fdc5409b4a65,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ReqAcc_2SetFinish.GetInvoiceAccountingProcessById", "3e4786bd-34df-45c9-9fe1-d00f66083663");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ReqAcc_2SetFinish.GetInvoiceAccountingProcessById", "3e4786bd-34df-45c9-9fe1-d00f66083663", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.Pwq24R6vmU6_jQDPY7VKdA/NodesNotShownInESpaceTree.vYZHPt80yUWf4dAPZgg2Yw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccountingprocess21\".\"id\" o0, \"eninvoiceaccountingprocess21\".\"invoiceid\" o1, \"eninvoiceaccountingprocess21\".\"requisitionid\" o2, \"eninvoiceaccountingprocess21\".\"offsetutc\" o3, \"eninvoiceaccountingprocess21\".\"comment\" o4, \"eninvoiceaccountingprocess21\".\"processnumber\" o5, \"eninvoiceaccountingprocess21\".\"createdon\" o6, \"eninvoiceaccountingprocess21\".\"nexttry\" o7, \"eninvoiceaccountingprocess21\".\"invoiceprocessstatusid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, \"enrequisition83\".\"supplierid\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66");
fromBuilder.Append(" FROM ({InvoiceAccountingProcess} \"eninvoiceaccountingprocess21\" Left JOIN {Requisition} \"enrequisition83\" ON (\"eninvoiceaccountingprocess21\".\"requisitionid\" = \"enrequisition83\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess21\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess21\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess21\".\"id\" IS NULL)");
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
RL_00bd7d2e1d6477607f48fdc5409b4a65 outParamList = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ReqAcc_2SetFinish.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00bd7d2e1d6477607f48fdc5409b4a65 _tmp = new RL_00bd7d2e1d6477607f48fdc5409b4a65();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ReqAcc_2SetFinish.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00bd7d2e1d6477607f48fdc5409b4a65)_tmp;
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
}
