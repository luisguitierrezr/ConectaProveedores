using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvFCP_6SetFinishInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvFCP_6SetFinishInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvFCP_6SetFinishOutput {
public S4PIInvFCP_6SetFinishOutput() {
}

}

[HttpPost()]
[Route("serviceapi/invfcp_6setfinish")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvFCP_6SetFinish", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvFCP_6SetFinish(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvFCP_6SetFinishInput, S4PIInvFCP_6SetFinishOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIInvFCP_6SetFinishInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionInvFCP_6SetFinish(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvFCP_6SetFinishOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvFCP_6SetFinish : VarsBag {
public long inParamInvoiceAccountingProcessId;
public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate2 =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate7 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public RL_9ffab0739d7699671c697b53b449a84f queryResGetInvoiceAccountingProcessById_outParamList = new RL_9ffab0739d7699671c697b53b449a84f();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public Actions.lcoInvoiceAccountingProcessCreateOrUpdate resInvoiceAccountingProcessCreateOrUpdate =  new Actions.lcoInvoiceAccountingProcessCreateOrUpdate();
public Actions.lcoInvoiceAccountingProcess_CheckPending resInvoiceAccountingProcess_CheckPending =  new Actions.lcoInvoiceAccountingProcess_CheckPending();
public lcvInvFCP_6SetFinish(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
/// <summary>
/// Action <code>InvFCP_6SetFinish</code> that represents the Service Studio action
///  <code>InvFCP_6SetFinish</code> <p> Description: </p>
/// </summary>
public static async Task ActionInvFCP_6SetFinish(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
lcvInvFCP_6SetFinish localVars = new lcvInvFCP_6SetFinish(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvFCP_6SetFinish", "fd1c6ead-aef6-449b-aff5-8bef2cbc4802"))
using (activitySource.CreateServiceActionActivity("InvFCP_6SetFinish")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvFCP_6SetFinish.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// set finished
// GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcess.InvoiceProcessStatusId = Finished
localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceProcessStatusId = (ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("b9Zmzw8_MUyampVTkJ_ulw"))).ssId;
// InvoiceAccountingProcessCreateOrUpdate2
localVars.resInvoiceAccountingProcessCreateOrUpdate2.outParamId = await Actions.ActionInvoiceAccountingProcessCreateOrUpdate(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess,cancellationToken);

// ActionTimestampsCreateOrUpdate7
localVars.resActionTimestampsCreateOrUpdate7.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Accounting finished"), ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// InvoiceAccountingProcess_CheckPending
(localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess,localVars.resInvoiceAccountingProcess_CheckPending.outParamIsFCP,localVars.resInvoiceAccountingProcess_CheckPending.outParamIsREQ) = await Actions.ActionInvoiceAccountingProcess_CheckPending(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENOrderMain.ssSupplierId,cancellationToken);

// empty
if((!((localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// set ongoing
// InvoiceAccountingProcess_CheckPending.InvoiceAccountingProcess.InvoiceProcessStatusId = Ongoing
localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess.ssInvoiceProcessStatusId = (ENInvoiceAccountingProcessStatusEntity.GetRecordByKey(ObjectKey.Parse("KTHuhc7_vUeeF0Y6YFaqaw"))).ssId;
// InvoiceAccountingProcessCreateOrUpdate
localVars.resInvoiceAccountingProcessCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingProcessCreateOrUpdate(requestContext,localVars.resInvoiceAccountingProcess_CheckPending.outParamInvoiceAccountingProcess,cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnAccountingProcess", "8360ae77-3601-4901-8642-53ecd6a88912"))
    using (activitySource.CreateTriggerEventActivity("OnAccountingProcess", "8360ae77-3601-4901-8642-53ecd6a88912", "e865635d-2731-475f-aff9-c64f5aaba1a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
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

        public static class FuncActionInvFCP_6SetFinish {
            
private static async Task<RC_ff169b020f7f52f3fee2c054b741a07f> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_ff169b020f7f52f3fee2c054b741a07f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" A6R3zW+CfkWAFcKEci7FjQ of Action "InvFCP_6SetFinish"
public static async Task<(RL_9ffab0739d7699671c697b53b449a84f,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvFCP_6SetFinish.GetInvoiceAccountingProcessById", "cd77a403-826f-457e-8015-c284722ec58d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvFCP_6SetFinish.GetInvoiceAccountingProcessById", "cd77a403-826f-457e-8015-c284722ec58d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.rW4c_faum0Sv9YvvLLxIAg/NodesNotShownInESpaceTree.A6R3zW+CfkWAFcKEci7FjQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoiceaccountingprocess23\".\"id\" o24, \"eninvoiceaccountingprocess23\".\"invoiceid\" o25, \"eninvoiceaccountingprocess23\".\"requisitionid\" o26, \"eninvoiceaccountingprocess23\".\"offsetutc\" o27, \"eninvoiceaccountingprocess23\".\"comment\" o28, \"eninvoiceaccountingprocess23\".\"processnumber\" o29, \"eninvoiceaccountingprocess23\".\"createdon\" o30, \"eninvoiceaccountingprocess23\".\"nexttry\" o31, \"eninvoiceaccountingprocess23\".\"invoiceprocessstatusid\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, \"enordermain77\".\"supplierid\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61");
fromBuilder.Append(" FROM (({InvoiceAccountingProcess} \"eninvoiceaccountingprocess23\" Left JOIN {Invoice} \"eninvoice94\" ON (\"eninvoiceaccountingprocess23\".\"invoiceid\" = \"eninvoice94\".\"id\"))  Left JOIN {OrderMain} \"enordermain77\" ON (\"eninvoice94\".\"ordermainid\" = \"enordermain77\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess23\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess23\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess23\".\"id\" IS NULL)");
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
RL_9ffab0739d7699671c697b53b449a84f outParamList = new RL_9ffab0739d7699671c697b53b449a84f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvFCP_6SetFinish.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9ffab0739d7699671c697b53b449a84f _tmp = new RL_9ffab0739d7699671c697b53b449a84f();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvFCP_6SetFinish.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9ffab0739d7699671c697b53b449a84f)_tmp;
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
