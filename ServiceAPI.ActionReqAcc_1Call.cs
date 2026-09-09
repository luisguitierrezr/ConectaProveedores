using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;


namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIReqAcc_1CallInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIReqAcc_1CallInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIReqAcc_1CallOutput {
[JsonProperty("IsSuccess")]
public bool outParamIsSuccess;
[JsonProperty("Message")]
public string outParamMessage;
[JsonProperty("IsAlreadyProcessed")]
public bool outParamIsAlreadyProcessed;
public S4PIReqAcc_1CallOutput(bool outParamIsSuccess, string outParamMessage, bool outParamIsAlreadyProcessed) {
this.outParamIsSuccess = outParamIsSuccess;
this.outParamMessage = outParamMessage;
this.outParamIsAlreadyProcessed = outParamIsAlreadyProcessed;
}

public bool ShouldSerializeoutParamIsSuccess() {return (this.outParamIsSuccess != true);
}
public bool ShouldSerializeoutParamIsAlreadyProcessed() {return (this.outParamIsAlreadyProcessed != false);
}
}

[HttpPost()]
[Route("serviceapi/reqacc_1call")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ReqAcc_1Call", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIReqAcc_1Call(CancellationToken cancellationToken) {return await EndpointAsync<S4PIReqAcc_1CallInput, S4PIReqAcc_1CallOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsSuccess;
string outParamMessage;
bool outParamIsAlreadyProcessed;
S4PIReqAcc_1CallInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamIsSuccess,outParamMessage,outParamIsAlreadyProcessed) = await Flows.ActionReqAcc_1Call(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIReqAcc_1CallOutput(outParamIsSuccess, outParamMessage, outParamIsAlreadyProcessed);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvReqAcc_1Call : VarsBag {
public long inParamInvoiceAccountingProcessId;
public RL_1f29ea5eecd22814d7aa42b51c318df6 queryResGetInvoiceAccountingProcessById_outParamList = new RL_1f29ea5eecd22814d7aa42b51c318df6();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public Actions.lcoRequisitionAccountingRequest_OnSuccess resRequisitionAccountingRequest_OnSuccess =  new Actions.lcoRequisitionAccountingRequest_OnSuccess();
public Actions.lcoRequisitionAccountingRequest resRequisitionAccountingRequest =  new Actions.lcoRequisitionAccountingRequest();
public lcvReqAcc_1Call(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoReqAcc_1Call : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public bool outParamIsAlreadyProcessed = false;

public lcoReqAcc_1Call() {
}
}
/// <summary>
/// Action <code>ReqAcc_1Call</code> that represents the Service Studio action
///  <code>ReqAcc_1Call</code> <p> Description: Call the services before accounting</p>
/// </summary>
public static async Task<(bool,string,bool)> ActionReqAcc_1Call(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
bool outParamIsAlreadyProcessed = default;
lcoReqAcc_1Call result = new lcoReqAcc_1Call();
lcvReqAcc_1Call localVars = new lcvReqAcc_1Call(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ReqAcc_1Call", "e5a8ff21-21e4-4fd0-844a-b00ccc24eb75"))
using (activitySource.CreateServiceActionActivity("ReqAcc_1Call")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionReqAcc_1Call.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// already processed
if(((localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENRequisition.ssRequisitionStatusId==(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("Mh9oh8XO1EONnOOs1HKCZA"))).ssId))) {
// IsAlreadyProcessed = True
result.outParamIsAlreadyProcessed=true;

// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "Accounting already processed"
result.outParamMessage=AppUtils.GetStringResource("KdGOQ5QmqEqTG+C54CPObw#Value.1095012571.1", "Accounting already processed");
} else {
// RequisitionAccountingRequest
localVars.resRequisitionAccountingRequest.outParamo_Output = await Actions.ActionRequisitionAccountingRequest(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENRequisition.ssId,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssOffsetUtc,cancellationToken);

// error
if((!((!localVars.resRequisitionAccountingRequest.outParamo_Output.ssIsSuccess)))) {
// RequisitionAccountingRequest_OnSuccess
localVars.resRequisitionAccountingRequest_OnSuccess.outParamo_Output = await Actions.ActionRequisitionAccountingRequest_OnSuccess(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssRequisitionId,cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
outParamIsAlreadyProcessed = result.outParamIsAlreadyProcessed;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage,outParamIsAlreadyProcessed);
}

        public static class FuncActionReqAcc_1Call {
            
private static async Task<RC_9dfd6227e2aee0cfdd29670cc2646476> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_9dfd6227e2aee0cfdd29670cc2646476 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" dxb4o94WdkyCmvRQeie4QQ of Action "ReqAcc_1Call"
public static async Task<(RL_1f29ea5eecd22814d7aa42b51c318df6,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ReqAcc_1Call.GetInvoiceAccountingProcessById", "a3f81677-16de-4c76-829a-f4507a27b841");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ReqAcc_1Call.GetInvoiceAccountingProcessById", "a3f81677-16de-4c76-829a-f4507a27b841", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.If+o5eQh0E+ESrAMzCTrdQ/NodesNotShownInESpaceTree.dxb4o94WdkyCmvRQeie4QQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"eninvoiceaccountingprocess22\".\"requisitionid\" o13, \"eninvoiceaccountingprocess22\".\"offsetutc\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"enrequisition84\".\"id\" o33, NULL o34, NULL o35, \"enrequisition84\".\"requisitionstatusid\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118");
fromBuilder.Append(" FROM (((({InvoiceAccountingProcess} \"eninvoiceaccountingprocess22\" Left JOIN {Requisition} \"enrequisition84\" ON (\"eninvoiceaccountingprocess22\".\"requisitionid\" = \"enrequisition84\".\"id\"))  Left JOIN {Supplier} \"ensupplier59\" ON (\"enrequisition84\".\"supplierid\" = \"ensupplier59\".\"id\"))  Left JOIN {Region} \"enregion77\" ON (\"enrequisition84\".\"regionid\" = \"enregion77\".\"id\"))  Left JOIN {Company} \"encompany21\" ON (\"enrequisition84\".\"companyid\" = \"encompany21\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess22\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess22\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess22\".\"id\" IS NULL)");
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
RL_1f29ea5eecd22814d7aa42b51c318df6 outParamList = new RL_1f29ea5eecd22814d7aa42b51c318df6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ReqAcc_1Call.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f29ea5eecd22814d7aa42b51c318df6 _tmp = new RL_1f29ea5eecd22814d7aa42b51c318df6();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ReqAcc_1Call.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f29ea5eecd22814d7aa42b51c318df6)_tmp;
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
