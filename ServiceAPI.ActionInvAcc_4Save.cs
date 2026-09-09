using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using OutSystems.HubEdition.RuntimePlatform.Internal;
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Core.Filters;
using OutSystems.RESTService.Runtime.Abstractions.PropertyAttributes;
using ssConectaProveedores.RestRecords;

namespace ssConectaProveedores;

public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

    public class S4PIInvAcc_4SaveInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvAcc_4SaveInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvAcc_4SaveOutput {
[JsonProperty("IsAccountingError")]
public bool outParamIsAccountingError;
[JsonProperty("IsErrorSaving")]
public bool outParamIsErrorSaving;
[JsonProperty("Message")]
public string outParamMessage;
public S4PIInvAcc_4SaveOutput(bool outParamIsAccountingError, bool outParamIsErrorSaving, string outParamMessage) {
this.outParamIsAccountingError = outParamIsAccountingError;
this.outParamIsErrorSaving = outParamIsErrorSaving;
this.outParamMessage = outParamMessage;
}

public bool ShouldSerializeoutParamIsAccountingError() {return (this.outParamIsAccountingError != false);
}
public bool ShouldSerializeoutParamIsErrorSaving() {return (this.outParamIsErrorSaving != true);
}
}

[HttpPost()]
[Route("serviceapi/invacc_4save")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvAcc_4Save", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvAcc_4Save(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvAcc_4SaveInput, S4PIInvAcc_4SaveOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsAccountingError;
bool outParamIsErrorSaving;
string outParamMessage;
S4PIInvAcc_4SaveInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamIsAccountingError,outParamIsErrorSaving,outParamMessage) = await Flows.ActionInvAcc_4Save(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvAcc_4SaveOutput(outParamIsAccountingError, outParamIsErrorSaving, outParamMessage);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvAcc_4Save : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>Response</code> that represents the Service Studio InvoiceAccountingProcessResponse
///  <code>Response</code> <p>Description: </p>
/// </summary>
public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord varLcResponse = new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord();

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public RL_2df25a5fccd9d0f976dc8e12fe39e37c queryResGetInvoiceAccountingProcessById_outParamList = new RL_2df25a5fccd9d0f976dc8e12fe39e37c();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public lcvInvAcc_4Save(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoInvAcc_4Save : VarsBag {
public bool outParamIsAccountingError = false;

public bool outParamIsErrorSaving = true;

public string outParamMessage = "";

public lcoInvAcc_4Save() {
}
}
/// <summary>
/// Action <code>InvAcc_4Save</code> that represents the Service Studio action
///  <code>InvAcc_4Save</code> <p> Description: Save accounting POLIZA</p>
/// </summary>
public static async Task<(bool,bool,string)> ActionInvAcc_4Save(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
bool outParamIsAccountingError = default;
bool outParamIsErrorSaving = default;
string outParamMessage = default;
lcoInvAcc_4Save result = new lcoInvAcc_4Save();
lcvInvAcc_4Save localVars = new lcvInvAcc_4Save(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvAcc_4Save", "483b79f5-5581-4560-ba47-33b6f0875266"))
using (activitySource.CreateServiceActionActivity("InvAcc_4Save")){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvAcc_4Save.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// Response = GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcessResponse
localVars.varLcResponse=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcessResponse;
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "After Call GENERA_POLIZA Invoice ", ssDescription = (((((((localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcessResponse.ssIsSuccess ? "True" : "False")+" // ")+localVars.varLcResponse.ssPO_RESULTADO)+" // ID_POLIZA: ")+localVars.varLcResponse.ssID_POLIZA)+" // TEXTO: ")+localVars.varLcResponse.ssTEXTO), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// error?
if((((!localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcessResponse.ssIsSuccess)&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// Message = Response.PO_RESULTADO
result.outParamMessage=localVars.varLcResponse.ssPO_RESULTADO;

// IsErrorSaving = True
result.outParamIsErrorSaving=true;

// IsAccountingError = True
result.outParamIsAccountingError=true;
} else {
// set ID_POLIZA & TEXTO
// GetInvoiceAccountingProcessById.List.Current.Invoice.ID_POLIZA = Response.ID_POLIZA
localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA = localVars.varLcResponse.ssID_POLIZA;

// GetInvoiceAccountingProcessById.List.Current.Invoice.ID_POLIZA_SAP = If
localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP = (((BuiltInFunction.IndexSC (localVars.varLcResponse.ssTEXTO, "-", 0, false, false)>0)) ? (BuiltInFunction.SubstrSC (localVars.varLcResponse.ssTEXTO, 0, BuiltInFunction.IndexSC (localVars.varLcResponse.ssTEXTO, "-", 0, false, false))) : (localVars.varLcResponse.ssTEXTO));

// GetInvoiceAccountingProcessById.List.Current.Invoice.AccountingDateTime = CurrDateTime
localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssAccountingDateTime = BuiltInFunction.CurrDateTime ();
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// InvoiceDocumentRelationCreate
await Actions.ActionInvoiceDocumentRelationCreate(requestContext,localVars.resInvoiceCreateOrUpdate.outParamId,localVars.varLcResponse.ssID_POLIZA,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP,((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))),cancellationToken);

// Message = Response.PO_RESULTADO
result.outParamMessage=localVars.varLcResponse.ssPO_RESULTADO;

// IsErrorSaving = False
result.outParamIsErrorSaving=false;

// IsAccountingError = False
result.outParamIsAccountingError=false;
}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// Message = "Invoice POLIZA had a problem in its saving. Please contact an administrator."
result.outParamMessage=AppUtils.GetStringResource("A8oyDAHTv0GweQS+3X1K2Q#Value.1838968478.1", "Invoice POLIZA had a problem in its saving. Please contact an administrator.");

// IsErrorSaving = True
result.outParamIsErrorSaving=true;

// IsAccountingError = False
result.outParamIsAccountingError=false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsAccountingError = result.outParamIsAccountingError;
outParamIsErrorSaving = result.outParamIsErrorSaving;
outParamMessage = result.outParamMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsAccountingError,outParamIsErrorSaving,outParamMessage);
}

        public static class FuncActionInvAcc_4Save {
            
private static async Task<RC_5c7aa2d527f88af9496e24408ac97c64> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_5c7aa2d527f88af9496e24408ac97c64 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENInvoiceAccountingProcessResponse.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" rJm4fyKVC0GrAk1KEtuxRA of Action "InvAcc_4Save"
public static async Task<(RL_2df25a5fccd9d0f976dc8e12fe39e37c,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_4Save.GetInvoiceAccountingProcessById", "7fb899ac-9522-410b-ab02-4d4a12dbb144");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_4Save.GetInvoiceAccountingProcessById", "7fb899ac-9522-410b-ab02-4d4a12dbb144", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.9Xk7SIFVYEW6RzO28IdSZg/NodesNotShownInESpaceTree.rJm4fyKVC0GrAk1KEtuxRA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice83\".\"id\" o0, \"eninvoice83\".\"name\" o1, \"eninvoice83\".\"requisitionid\" o2, \"eninvoice83\".\"folioid\" o3, \"eninvoice83\".\"ordermainid\" o4, \"eninvoice83\".\"cfditypeid\" o5, trim_scale(\"eninvoice83\".\"totalamount\"::numeric) o6, \"eninvoice83\".\"currency\" o7, \"eninvoice83\".\"invoicestatusid\" o8, \"eninvoice83\".\"accountingdatetime\" o9, \"eninvoice83\".\"paymentdatetime\" o10, \"eninvoice83\".\"createdon\" o11, \"eninvoice83\".\"createdby\" o12, \"eninvoice83\".\"updatedon\" o13, \"eninvoice83\".\"updatedby\" o14, \"eninvoice83\".\"submittedon\" o15, \"eninvoice83\".\"isnewversion\" o16, \"eninvoice83\".\"id_poliza\" o17, \"eninvoice83\".\"id_poliza_sap\" o18, \"eninvoice83\".\"doc51\" o19, \"eninvoice83\".\"accountingerror\" o20, \"eninvoice83\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice83\".\"amortization\"::numeric) o22, \"eninvoice83\".\"creditnoteinvoiceid\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceaccountingprocessresponse\".\"issuccess\" o34, \"eninvoiceaccountingprocessresponse\".\"id_poliza\" o35, \"eninvoiceaccountingprocessresponse\".\"texto\" o36, \"eninvoiceaccountingprocessresponse\".\"po_resultado\" o37, NULL o38");
fromBuilder.Append(" FROM (({InvoiceAccountingProcess} \"eninvoiceaccountingprocess13\" Left JOIN {InvoiceAccountingProcessResponse} \"eninvoiceaccountingprocessresponse\" ON (\"eninvoiceaccountingprocess13\".\"id\" = \"eninvoiceaccountingprocessresponse\".\"invoiceaccountingprocessid\"))  Left JOIN {Invoice} \"eninvoice83\" ON (\"eninvoiceaccountingprocess13\".\"invoiceid\" = \"eninvoice83\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess13\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess13\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess13\".\"id\" IS NULL)");
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
RL_2df25a5fccd9d0f976dc8e12fe39e37c outParamList = new RL_2df25a5fccd9d0f976dc8e12fe39e37c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, false, false, false, false, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_4Save.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2df25a5fccd9d0f976dc8e12fe39e37c _tmp = new RL_2df25a5fccd9d0f976dc8e12fe39e37c();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_4Save.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2df25a5fccd9d0f976dc8e12fe39e37c)_tmp;
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
