using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvAcc_7SetFinishInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvAcc_7SetFinishInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvAcc_7SetFinishOutput {
public S4PIInvAcc_7SetFinishOutput() {
}

}

[HttpPost()]
[Route("serviceapi/invacc_7setfinish")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvAcc_7SetFinish", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvAcc_7SetFinish(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvAcc_7SetFinishInput, S4PIInvAcc_7SetFinishOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIInvAcc_7SetFinishInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionInvAcc_7SetFinish(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvAcc_7SetFinishOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvAcc_7SetFinish : VarsBag {
public long inParamInvoiceAccountingProcessId;
public Actions.lcoInvoiceAccountingProcess_CheckPending resInvoiceAccountingProcess_CheckPending =  new Actions.lcoInvoiceAccountingProcess_CheckPending();
public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate2 =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public RL_e1821cde66da1d9e887529d6d8944d88 queryResGetInvoiceAccountingProcessById_outParamList = new RL_e1821cde66da1d9e887529d6d8944d88();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate7 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public lcvInvAcc_7SetFinish(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
/// <summary>
/// Action <code>InvAcc_7SetFinish</code> that represents the Service Studio action
///  <code>InvAcc_7SetFinish</code> <p> Description: Set Process as Finished and check if there is an
/// y Pending process for the same supplier</p>
/// </summary>
public static async Task ActionInvAcc_7SetFinish(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
lcvInvAcc_7SetFinish localVars = new lcvInvAcc_7SetFinish(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvAcc_7SetFinish", "aaf84419-76f2-4a53-8008-22d369d28a5b"))
using (activitySource.CreateServiceActionActivity("InvAcc_7SetFinish")){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 0;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvAcc_7SetFinish.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

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
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnAccountingProcess", "e8a2a813-67c4-43f0-a18f-1bedac52826d"))
    using (activitySource.CreateTriggerEventActivity("OnAccountingProcess", "e8a2a813-67c4-43f0-a18f-1bedac52826d", "e865635d-2731-475f-aff9-c64f5aaba1a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
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

        public static class FuncActionInvAcc_7SetFinish {
            
private static async Task<RC_93712ae8022b855afd9826482f80eceb> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_93712ae8022b855afd9826482f80eceb rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" kwRFzqpy2UGioJ0fBVp_Tw of Action "InvAcc_7SetFinish"
public static async Task<(RL_e1821cde66da1d9e887529d6d8944d88,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_7SetFinish.GetInvoiceAccountingProcessById", "ce450493-72aa-41d9-a2a0-9d1f055a7f4f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_7SetFinish.GetInvoiceAccountingProcessById", "ce450493-72aa-41d9-a2a0-9d1f055a7f4f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.GUT4qvJ2U0qACCLTadKKWw/NodesNotShownInESpaceTree.kwRFzqpy2UGioJ0fBVp_Tw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceaccountingprocess19\".\"id\" o24, \"eninvoiceaccountingprocess19\".\"invoiceid\" o25, \"eninvoiceaccountingprocess19\".\"requisitionid\" o26, \"eninvoiceaccountingprocess19\".\"offsetutc\" o27, \"eninvoiceaccountingprocess19\".\"comment\" o28, \"eninvoiceaccountingprocess19\".\"processnumber\" o29, \"eninvoiceaccountingprocess19\".\"createdon\" o30, \"eninvoiceaccountingprocess19\".\"nexttry\" o31, \"eninvoiceaccountingprocess19\".\"invoiceprocessstatusid\" o32, NULL o33, NULL o34, NULL o35, NULL o36, \"enrequisition81\".\"supplierid\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90");
fromBuilder.Append(" FROM (({InvoiceAccountingProcess} \"eninvoiceaccountingprocess19\" Left JOIN {Invoice} \"eninvoice92\" ON (\"eninvoiceaccountingprocess19\".\"invoiceid\" = \"eninvoice92\".\"id\"))  Left JOIN {Requisition} \"enrequisition81\" ON (\"eninvoice92\".\"requisitionid\" = \"enrequisition81\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess19\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess19\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess19\".\"id\" IS NULL)");
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
RL_e1821cde66da1d9e887529d6d8944d88 outParamList = new RL_e1821cde66da1d9e887529d6d8944d88();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_7SetFinish.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e1821cde66da1d9e887529d6d8944d88 _tmp = new RL_e1821cde66da1d9e887529d6d8944d88();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_7SetFinish.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e1821cde66da1d9e887529d6d8944d88)_tmp;
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
