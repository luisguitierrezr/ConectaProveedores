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

    public class S4PIInvAcc_2PrepareInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvAcc_2PrepareInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvAcc_2PrepareOutput {
public S4PIInvAcc_2PrepareOutput() {
}

}

[HttpPost()]
[Route("serviceapi/invacc_2prepare")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvAcc_2Prepare", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvAcc_2Prepare(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvAcc_2PrepareInput, S4PIInvAcc_2PrepareOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
S4PIInvAcc_2PrepareInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
await Flows.ActionInvAcc_2Prepare(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvAcc_2PrepareOutput();
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvAcc_2Prepare : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>l_RequestAccountingFinalList</code> that represents the Service Studio TI_POS_InList
///  <code>l_RequestAccountingFinalList</code> <p>Description: Request Accounting Final List.</p>
/// </summary>
public RL_c68103fa9d6dc1b51b6298518d880199 varLcl_RequestAccountingFinalList = new RL_c68103fa9d6dc1b51b6298518d880199();

/// <summary>
/// Variable <code>l_RequestAccountingList</code> that represents the Service Studio Text2List
///  <code>l_RequestAccountingList</code> <p>Description: Request Accounting List.</p>
/// </summary>
public RLTextList varLcl_RequestAccountingList = new RLTextList();

/// <summary>
/// Variable <code>l_RequestAccountingServicesList</code> that represents the Service Studio Text2List
///  <code>l_RequestAccountingServicesList</code> <p>Description: Request Accounting Services List.</p>
/// </summary>
public RLTextList varLcl_RequestAccountingServicesList = new RLTextList();

/// <summary>
/// Variable <code>Count</code> that represents the Service Studio Integer <code>Count</code>
///  <p>Description: </p>
/// </summary>
public int varLcCount = 0;

/// <summary>
/// Variable <code>InvoiceId</code> that represents the Service Studio InvoiceIdentifier
///  <code>InvoiceId</code> <p>Description: Invoice Identifier.</p>
/// </summary>
public long varLcInvoiceId = 0L;

/// <summary>
/// Variable <code>OffsetUtc</code> that represents the Service Studio Integer <code>OffsetUtc</code>
///  <p>Description: </p>
/// </summary>
public int varLcOffsetUtc = 0;

/// <summary>
/// Variable <code>IsEmptyFieldsCase</code> that represents the Service Studio Boolean
///  <code>IsEmptyFieldsCase</code> <p>Description: Used to empty fields if the account is betwee
/// n 1000000000 - 2999999999</p>
/// </summary>
public bool varLcIsEmptyFieldsCase = false;

public RL_4e909af3a15d1687c03c789af38db7ae queryResGetInvoiceAccountingProcessById_outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public string resString_Join_outParamText = "";

public Actions.lcoInvoiceAccountingProcessLinesCreate resInvoiceAccountingProcessLinesCreate =  new Actions.lcoInvoiceAccountingProcessLinesCreate();
public Actions.lcoGetNextMonday resGetDaysTillNextMonday =  new Actions.lcoGetNextMonday();
public RL_bf188616de0f0f2f6ca06ba5dba27490 queryResGetTaxIndicatorById2_outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
public long queryResGetTaxIndicatorById2_outParamCount = 0L;

public RL_216ae81da35dfe5cfaaa600823fb4c79 queryResGetUserExtendedInternalById_outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
public long queryResGetUserExtendedInternalById_outParamCount = 0L;

public RL_6dc54c806e79e3021c958eb2cb6d90be queryResGetInvoiceApprovalsByInvoiceId_outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
public long queryResGetInvoiceApprovalsByInvoiceId_outParamCount = 0L;

public RL_167572037cd88dd5ec827ef4b6fdc32a queryResGetInvoiceById_outParamList = new RL_167572037cd88dd5ec827ef4b6fdc32a();
public long queryResGetInvoiceById_outParamCount = 0L;

public RL_bf188616de0f0f2f6ca06ba5dba27490 queryResGetTaxIndicatorById_outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
public long queryResGetTaxIndicatorById_outParamCount = 0L;

public RL_e547ae2a729a8ddc0c9af52ac3c70a26 queryResGetInvoiceAccountingServicesById_outParamList = new RL_e547ae2a729a8ddc0c9af52ac3c70a26();
public long queryResGetInvoiceAccountingServicesById_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public string resString_Join_Accounting_outParamText = "";

public lcvInvAcc_2Prepare(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
/// <summary>
/// Action <code>InvAcc_2Prepare</code> that represents the Service Studio action
///  <code>InvAcc_2Prepare</code> <p> Description: Prepares the accounting parameters</p>
/// </summary>
public static async Task ActionInvAcc_2Prepare(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
lcvInvAcc_2Prepare localVars = new lcvInvAcc_2Prepare(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvAcc_2Prepare", "15590a84-ca6d-46ee-b862-3082306e6d79"))
using (activitySource.CreateServiceActionActivity("InvAcc_2Prepare")){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvAcc_2Prepare.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// InvoiceId = GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcess.InvoiceId
localVars.varLcInvoiceId=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId;

// OffsetUtc = GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcess.OffsetUtc
localVars.varLcOffsetUtc=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssOffsetUtc;
// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 1;
if (datasetGetInvoiceById_maxRecords < 1) datasetGetInvoiceById_maxRecords = 1;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionInvAcc_2Prepare.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.varLcInvoiceId,cancellationToken);

// Query datasetGetUserExtendedInternalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalById_maxRecords = 0;
int datasetGetUserExtendedInternalById_startIndex = 0;(localVars.queryResGetUserExtendedInternalById_outParamList,localVars.queryResGetUserExtendedInternalById_outParamCount) = await FuncActionInvAcc_2Prepare.datasetGetUserExtendedInternalById(requestContext,datasetGetUserExtendedInternalById_maxRecords,datasetGetUserExtendedInternalById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssSubmissionBy,cancellationToken);

// Query datasetGetInvoiceApprovalsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceApprovalsByInvoiceId_maxRecords = 0;
int datasetGetInvoiceApprovalsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamCount) = await FuncActionInvAcc_2Prepare.datasetGetInvoiceApprovalsByInvoiceId(requestContext,datasetGetInvoiceApprovalsByInvoiceId_maxRecords,datasetGetInvoiceApprovalsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.varLcInvoiceId,cancellationToken);

// Query datasetGetTaxIndicatorById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxIndicatorById_maxRecords = 1;
if (datasetGetTaxIndicatorById_maxRecords < 1) datasetGetTaxIndicatorById_maxRecords = 1;
int datasetGetTaxIndicatorById_startIndex = 0;(localVars.queryResGetTaxIndicatorById_outParamList,localVars.queryResGetTaxIndicatorById_outParamCount) = await FuncActionInvAcc_2Prepare.datasetGetTaxIndicatorById(requestContext,datasetGetTaxIndicatorById_maxRecords,datasetGetTaxIndicatorById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssIvaIndicatorId,cancellationToken);

// GetDaysTillNextMonday
localVars.resGetDaysTillNextMonday.outParamDays = await Actions.ActionGetNextMonday(requestContext,BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn,localVars.varLcOffsetUtc,cancellationToken)), BuiltInFunction.TextToInteger (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias)),cancellationToken);

// ListAppendAllAccounting
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_RequestAccountingList,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = Convert.ToString(1) }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssId) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.varLcOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd") }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? ("KW") : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssTipoComprobante=="E")) ? ("NC") : ("KR")))) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCurrency }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.DecimalToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssNegotiatedExchangeRate)) : ("")) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssFolio }, new STTextStructure(){ ssValue = BuiltInFunction.Replace (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssProjectDescription, "||", "--") }, new STTextStructure(){ ssValue = "C" }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? ("02") : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssTipoComprobante=="E")) ? ("01") : ("02")))) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssSupplierNumber }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssICMEIndicator }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDecimal (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssTotalAmount, 2, ".", ",") }, new STTextStructure(){ ssValue = localVars.queryResGetTaxIndicatorById_outParamList.CurrentRec.ssENTaxIndicator.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssDivision }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn,localVars.varLcOffsetUtc,cancellationToken)), localVars.resGetDaysTillNextMonday.outParamDays), "yyyyMMdd") }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddMonths ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.varLcOffsetUtc,cancellationToken)), 1), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENPaymentMethods.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssFreeText, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssUUID }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" } })),cancellationToken);

// String_Join_Accounting
localVars.resString_Join_Accounting_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_RequestAccountingList, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// ListAppendAccoutningToFinalStruct
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_RequestAccountingFinalList,new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join_Accounting_outParamText },cancellationToken);

// Query datasetGetInvoiceAccountingServicesById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingServicesById_maxRecords = 999999999;
if (datasetGetInvoiceAccountingServicesById_maxRecords < 1) datasetGetInvoiceAccountingServicesById_maxRecords = 1;
int datasetGetInvoiceAccountingServicesById_startIndex = 0;(localVars.queryResGetInvoiceAccountingServicesById_outParamList,localVars.queryResGetInvoiceAccountingServicesById_outParamCount) = await FuncActionInvAcc_2Prepare.datasetGetInvoiceAccountingServicesById(requestContext,datasetGetInvoiceAccountingServicesById_maxRecords,datasetGetInvoiceAccountingServicesById_startIndex,IterationMultiplicity.Single,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssId,cancellationToken);

// Count = 2
localVars.varLcCount=2;
// Foreach GetInvoiceAccountingServicesById.List
localVars.queryResGetInvoiceAccountingServicesById_outParamList.StartIteration();
try {while (!((localVars.queryResGetInvoiceAccountingServicesById_outParamList.Eof))) {
// Query datasetGetTaxIndicatorById2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxIndicatorById2_maxRecords = 1;
if (datasetGetTaxIndicatorById2_maxRecords < 1) datasetGetTaxIndicatorById2_maxRecords = 1;
int datasetGetTaxIndicatorById2_startIndex = 0;(localVars.queryResGetTaxIndicatorById2_outParamList,localVars.queryResGetTaxIndicatorById2_outParamCount) = await FuncActionInvAcc_2Prepare.datasetGetTaxIndicatorById2(requestContext,datasetGetTaxIndicatorById2_maxRecords,datasetGetTaxIndicatorById2_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssIVAIndicatorId,cancellationToken);

// IsEmptyFieldsCase = notGetInvoiceById.List.Current.Requisition.IsAdvanced or GetInvoiceById.List.Current.Requisition.WasAdvWithoutInvoice and TextToLongInteger >= 1000000000 and TextToLongInteger <= 2999999999
localVars.varLcIsEmptyFieldsCase=((((!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced)||localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice)&&(BuiltInFunction.TextToLongInteger (localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssAccount)>=Convert.ToInt64(1000000000)))&&(BuiltInFunction.TextToLongInteger (localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssAccount)<=2999999999L));
// ListAppendAllAccounting2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_RequestAccountingServicesList,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = Convert.ToString(localVars.varLcCount) }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssId) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.varLcOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd") }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? ("KW") : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssTipoComprobante=="E")) ? ("NC") : ("KR")))) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCurrency }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.DecimalToText(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssNegotiatedExchangeRate)) : ("")) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssFolio }, new STTextStructure(){ ssValue = BuiltInFunction.Replace (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssProjectDescription, "||", "--") }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? ("C") : ("A")) }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? ("03") : ((((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssTipoComprobante=="E")) ? ("02") : ("01")))) }, new STTextStructure(){ ssValue = ((((!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced)||localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice)) ? (localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssAccount) : (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceAccounting.ssSupplierNumber)) }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssICME }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDecimal (localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssAmount, 2, ".", ",") }, new STTextStructure(){ ssValue = ((localVars.varLcIsEmptyFieldsCase) ? ("") : (localVars.queryResGetTaxIndicatorById2_outParamList.CurrentRec.ssENTaxIndicator.ssExternalId)) }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENCostCenterSAP.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? ("") : (localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENCostCenterSAP.ssCe_coste)) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssDivision }, new STTextStructure(){ ssValue = ((localVars.varLcIsEmptyFieldsCase) ? ("") : (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP)) }, new STTextStructure(){ ssValue = ((localVars.varLcIsEmptyFieldsCase) ? ("") : (BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetInvoiceApprovalsByInvoiceId_outParamList.CurrentRec.ssENInvoiceApprovalLevel.ssApprovedOn,localVars.varLcOffsetUtc,cancellationToken)), localVars.resGetDaysTillNextMonday.outParamDays), "yyyyMMdd"))) }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.AddMonths ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.varLcOffsetUtc,cancellationToken)), 1), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = ((localVars.varLcIsEmptyFieldsCase) ? ("") : (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENPaymentMethods.ssExternalId)) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENInvoiceAccountingServices.ssFreeText, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENCostCenterSAP.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))) ? (localVars.queryResGetInvoiceAccountingServicesById_outParamList.CurrentRec.ssENCeBeCostCenterSAP.ssCeBe) : ("")) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoiceExtended.ssUUID }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssBuyDocNumber) : ("")) }, new STTextStructure(){ ssValue = (((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssIsAdvanced&&(!localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssWasAdvWithoutInvoice))) ? (Convert.ToString(BuiltInFunction.TextToInteger (localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENRequisition.ssBuyDocPosition))) : ("")) } })),cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_RequestAccountingServicesList, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// Count = Count + 1
localVars.varLcCount=(localVars.varLcCount+1);
// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcl_RequestAccountingServicesList,cancellationToken);

// ListAppendToFinalStruct
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_RequestAccountingFinalList,new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join_outParamText },cancellationToken);

localVars.queryResGetInvoiceAccountingServicesById_outParamList.Advance();
}

} finally {
localVars.queryResGetInvoiceAccountingServicesById_outParamList.EndIteration();
}

// Foreach l_RequestAccountingFinalList
localVars.varLcl_RequestAccountingFinalList.StartIteration();
try {while (!((localVars.varLcl_RequestAccountingFinalList.Eof))) {
// InvoiceAccountingProcessLinesCreate
localVars.resInvoiceAccountingProcessLinesCreate.outParamId = await Actions.ActionInvoiceAccountingProcessLinesCreate(requestContext,new EN_0d662bdaada5191124d8fca5ffaaf619EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceAccounting_ProcessId = localVars.inParamInvoiceAccountingProcessId, ssParameter = localVars.varLcl_RequestAccountingFinalList.CurrentRec.ssPARAMETRO },cancellationToken);

localVars.varLcl_RequestAccountingFinalList.Advance();
}

} finally {
localVars.varLcl_RequestAccountingFinalList.EndIteration();
}

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ((("Call GENERA_POLIZA Invoice "+BuiltInFunction.LongIntegerToText(localVars.varLcInvoiceId))+" // ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ("Tram1 "+localVars.resString_Join_Accounting_outParamText), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return;
}

        public static class FuncActionInvAcc_2Prepare {
            
// Query Function "GetInvoiceAccountingProcessById" x5goBbbgHUu4mYnv7LtswQ of Action "InvAcc_2Prepare"
public static async Task<(RL_4e909af3a15d1687c03c789af38db7ae,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_2Prepare.GetInvoiceAccountingProcessById", "052898c7-e0b6-4b1d-b899-89efecbb6cc1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_2Prepare.GetInvoiceAccountingProcessById", "052898c7-e0b6-4b1d-b899-89efecbb6cc1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.hApZFW3K7ka4YjCCMG5teQ/NodesNotShownInESpaceTree.x5goBbbgHUu4mYnv7LtswQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceaccountingprocess12\".\"invoiceid\" o1, NULL o2, \"eninvoiceaccountingprocess12\".\"offsetutc\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {InvoiceAccountingProcess} \"eninvoiceaccountingprocess12\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess12\".\"id\" = @qpinId) AND (\"eninvoiceaccountingprocess12\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess12\".\"id\" IS NULL)");
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
RL_4e909af3a15d1687c03c789af38db7ae outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_2Prepare.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_2Prepare.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
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

// Query Function "GetTaxIndicatorById2" NzA5YbZF00mMBZhEbvMndg of Action "InvAcc_2Prepare"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicatorById2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qptaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_2Prepare.GetTaxIndicatorById2", "61393037-45b6-49d3-8c05-98446ef32776");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_2Prepare.GetTaxIndicatorById2", "61393037-45b6-49d3-8c05-98446ef32776", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.hApZFW3K7ka4YjCCMG5teQ/NodesNotShownInESpaceTree.NzA5YbZF00mMBZhEbvMndg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"entaxindicator5\".\"externalid\" o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator5\"");
whereBuilder.Append(" WHERE ");
if (qptaId != 0) {
whereBuilder.Append("((\"entaxindicator5\".\"id\" = @qptaId) AND (\"entaxindicator5\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qptaId", DbType.Int64, qptaId);
} else {
whereBuilder.Append("(\"entaxindicator5\".\"id\" IS NULL)");
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
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_2Prepare.GetTaxIndicatorById2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bf188616de0f0f2f6ca06ba5dba27490 _tmp = new RL_bf188616de0f0f2f6ca06ba5dba27490();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_2Prepare.GetTaxIndicatorById2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bf188616de0f0f2f6ca06ba5dba27490)_tmp;
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

// Query Function "GetUserExtendedInternalById" Srqbk0R46Ee7T_Kn2u3nBA of Action "InvAcc_2Prepare"
public static async Task<(RL_216ae81da35dfe5cfaaa600823fb4c79,long)> datasetGetUserExtendedInternalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_2Prepare.GetUserExtendedInternalById", "939bba4a-7844-47e8-bb4f-f2a7daede704");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_2Prepare.GetUserExtendedInternalById", "939bba4a-7844-47e8-bb4f-f2a7daede704", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.hApZFW3K7ka4YjCCMG5teQ/NodesNotShownInESpaceTree.Srqbk0R46Ee7T_Kn2u3nBA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser_extended_internal87\".\"employeenumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {User_Extended_Internal} \"enuser_extended_internal87\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal87\".\"id\" = @qpusId) AND (\"enuser_extended_internal87\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser_extended_internal87\".\"id\" IS NULL)");
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
RL_216ae81da35dfe5cfaaa600823fb4c79 outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_2Prepare.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_216ae81da35dfe5cfaaa600823fb4c79 _tmp = new RL_216ae81da35dfe5cfaaa600823fb4c79();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_2Prepare.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_216ae81da35dfe5cfaaa600823fb4c79)_tmp;
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

private static async Task<RC_bdad25a559cd2f146ec69d1aec036546> datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync(RC_bdad25a559cd2f146ec69d1aec036546 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApprovalsByInvoiceId" WZs2wrhLH0WmjZ2iY016wg of Action "InvAcc_2Prepare"
public static async Task<(RL_6dc54c806e79e3021c958eb2cb6d90be,long)> datasetGetInvoiceApprovalsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceApproval_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_2Prepare.GetInvoiceApprovalsByInvoiceId", "c2369b59-4bb8-451f-a68d-9da2634d7ac2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_2Prepare.GetInvoiceApprovalsByInvoiceId", "c2369b59-4bb8-451f-a68d-9da2634d7ac2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.hApZFW3K7ka4YjCCMG5teQ/NodesNotShownInESpaceTree.WZs2wrhLH0WmjZ2iY016wg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"eninvoiceapprovallevel27\".\"approvedon\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34");
fromBuilder.Append(" FROM ({InvoiceApproval} \"eninvoiceapproval26\" Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel27\" ON (\"eninvoiceapproval26\".\"id\" = \"eninvoiceapprovallevel27\".\"invoiceapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceApproval_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceapproval26\".\"invoiceid\" = @qpinInvoiceApproval_InvoiceId) AND (\"eninvoiceapproval26\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceApproval_InvoiceId", DbType.Int64, qpinInvoiceApproval_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceapproval26\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel27\".\"approvedon\"::date <> (date '1900-01-01')::date) AND (NOT (\"eninvoiceapprovallevel27\".\"isaccounting\" = 1))");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel27\".\"levelnumber\" DESC ");
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
RL_6dc54c806e79e3021c958eb2cb6d90be outParamList = new RL_6dc54c806e79e3021c958eb2cb6d90be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_2Prepare.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6dc54c806e79e3021c958eb2cb6d90be _tmp = new RL_6dc54c806e79e3021c958eb2cb6d90be();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_2Prepare.GetInvoiceApprovalsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6dc54c806e79e3021c958eb2cb6d90be)_tmp;
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

private static async Task<RC_93dc1c8a1fa45d29d89784afc0b5bc8d> datasetGetInvoiceByIdReadDbAsync(RC_93dc1c8a1fa45d29d89784afc0b5bc8d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENPaymentMethods.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" 1ZT900b98k2x1cet7VKbjg of Action "InvAcc_2Prepare"
public static async Task<(RL_167572037cd88dd5ec827ef4b6fdc32a,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_2Prepare.GetInvoiceById", "d3fd94d5-fd46-4df2-b1d5-c7aded529b8e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_2Prepare.GetInvoiceById", "d3fd94d5-fd46-4df2-b1d5-c7aded529b8e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.hApZFW3K7ka4YjCCMG5teQ/NodesNotShownInESpaceTree.1ZT900b98k2x1cet7VKbjg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany15\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"eninvoice81\".\"id\" o11, \"eninvoice81\".\"name\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"eninvoice81\".\"currency\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"eninvoiceaccounting17\".\"id\" o35, NULL o36, \"eninvoiceaccounting17\".\"suppliernumber\" o37, NULL o38, \"eninvoiceaccounting17\".\"freetext\" o39, \"eninvoiceaccounting17\".\"division\" o40, NULL o41, NULL o42, \"eninvoiceaccounting17\".\"ivaindicatorid\" o43, trim_scale(\"eninvoiceaccounting17\".\"totalamount\"::numeric) o44, NULL o45, NULL o46, \"eninvoiceaccounting17\".\"icmeindicator\" o47, NULL o48, NULL o49, \"eninvoiceaccounting17\".\"submissionby\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, \"eninvoiceextended20\".\"folio\" o58, NULL o59, \"eninvoiceextended20\".\"fechaemision\" o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, \"eninvoiceextended20\".\"tipocomprobante\" o69, NULL o70, NULL o71, NULL o72, NULL o73, \"eninvoiceextended20\".\"uuid\" o74, NULL o75, NULL o76, \"enpaymentmethods5\".\"externalid\" o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, \"enpaymentterms12\".\"ctd_dias\" o88, \"enpaymentterms12\".\"estructuradescripcionprop\" o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, \"enrequisition75\".\"projectdescription\" o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, trim_scale(\"enrequisition75\".\"negotiatedexchangerate\"::numeric) o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, \"enrequisition75\".\"wasadvwithoutinvoice\" o142, \"enrequisition75\".\"isadvanced\" o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, \"enrequisition75\".\"buydocnumber\" o151, \"enrequisition75\".\"buydocposition\" o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180");
fromBuilder.Append(" FROM ((((((({Invoice} \"eninvoice81\" Left JOIN {Requisition} \"enrequisition75\" ON (\"eninvoice81\".\"requisitionid\" = \"enrequisition75\".\"id\"))  Left JOIN {Company} \"encompany15\" ON (\"enrequisition75\".\"companyid\" = \"encompany15\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended20\" ON (\"eninvoice81\".\"id\" = \"eninvoiceextended20\".\"id\"))  Left JOIN {Supplier} \"ensupplier50\" ON (\"enrequisition75\".\"supplierid\" = \"ensupplier50\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting17\" ON (\"eninvoice81\".\"id\" = \"eninvoiceaccounting17\".\"invoiceid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods5\" ON (\"eninvoiceaccounting17\".\"paymentmethodid\" = \"enpaymentmethods5\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms12\" ON (\"eninvoiceaccounting17\".\"paymenttermsid\" = \"enpaymentterms12\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice81\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice81\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice81\".\"id\" IS NULL)");
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
RL_167572037cd88dd5ec827ef4b6fdc32a outParamList = new RL_167572037cd88dd5ec827ef4b6fdc32a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true, false, false});
opt[2] = new BitArray(new bool[] {false, true, false, true, false, false, true, true, false, false, true, true, false, true, true, false, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, false, true, true, true, true, true, true, true, true, false, true, true, true, true, false});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, false, false, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_2Prepare.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_167572037cd88dd5ec827ef4b6fdc32a _tmp = new RL_167572037cd88dd5ec827ef4b6fdc32a();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_2Prepare.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_167572037cd88dd5ec827ef4b6fdc32a)_tmp;
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

// Query Function "GetTaxIndicatorById" KUXZ2dhz5Euv_zsoej8tNQ of Action "InvAcc_2Prepare"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicatorById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qptaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_2Prepare.GetTaxIndicatorById", "d9d94529-73d8-4be4-afff-3b287a3f2d35");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_2Prepare.GetTaxIndicatorById", "d9d94529-73d8-4be4-afff-3b287a3f2d35", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.hApZFW3K7ka4YjCCMG5teQ/NodesNotShownInESpaceTree.KUXZ2dhz5Euv_zsoej8tNQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"entaxindicator6\".\"externalid\" o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator6\"");
whereBuilder.Append(" WHERE ");
if (qptaId != 0) {
whereBuilder.Append("((\"entaxindicator6\".\"id\" = @qptaId) AND (\"entaxindicator6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qptaId", DbType.Int64, qptaId);
} else {
whereBuilder.Append("(\"entaxindicator6\".\"id\" IS NULL)");
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
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_2Prepare.GetTaxIndicatorById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bf188616de0f0f2f6ca06ba5dba27490 _tmp = new RL_bf188616de0f0f2f6ca06ba5dba27490();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_2Prepare.GetTaxIndicatorById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bf188616de0f0f2f6ca06ba5dba27490)_tmp;
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

private static async Task<RC_e940773abf7f42dc9da3bb03219b8c23> datasetGetInvoiceAccountingServicesByIdReadDbAsync(RC_e940773abf7f42dc9da3bb03219b8c23 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCeBeCostCenterSAP.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENInvoiceAccountingServices.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingServicesById" yyTO6O72JkivSX2uwixjxw of Action "InvAcc_2Prepare"
public static async Task<(RL_e547ae2a729a8ddc0c9af52ac3c70a26,long)> datasetGetInvoiceAccountingServicesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingServices_InvoiceAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_2Prepare.GetInvoiceAccountingServicesById", "e8ce24cb-f6ee-4826-af49-7daec22c63c7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_2Prepare.GetInvoiceAccountingServicesById", "e8ce24cb-f6ee-4826-af49-7daec22c63c7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.hApZFW3K7ka4YjCCMG5teQ/NodesNotShownInESpaceTree.yyTO6O72JkivSX2uwixjxw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"encebecostcentersap1\".\"cebe\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"encostcentersap7\".\"id\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, \"encostcentersap7\".\"ce_coste\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, \"eninvoiceaccountingservices5\".\"account\" o61, NULL o62, NULL o63, trim_scale(\"eninvoiceaccountingservices5\".\"amount\"::numeric) o64, NULL o65, \"eninvoiceaccountingservices5\".\"ivaindicatorid\" o66, NULL o67, NULL o68, \"eninvoiceaccountingservices5\".\"freetext\" o69, \"eninvoiceaccountingservices5\".\"division\" o70, \"eninvoiceaccountingservices5\".\"icme\" o71");
fromBuilder.Append(" FROM ((({InvoiceAccountingServices} \"eninvoiceaccountingservices5\" Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype4\" ON (\"eninvoiceaccountingservices5\".\"servicetypeid\" = \"enaccountingaccounts_servicetype4\".\"id\"))  Left JOIN {CostCenterSAP} \"encostcentersap7\" ON (\"eninvoiceaccountingservices5\".\"costcenterid\" = \"encostcentersap7\".\"id\"))  Left JOIN {CostCenterSAP} \"encebecostcentersap1\" ON (\"eninvoiceaccountingservices5\".\"cebecostcenterid\" = \"encebecostcentersap1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingServices_InvoiceAccountingId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingservices5\".\"invoiceaccountingid\" = @qpinInvoiceAccountingServices_InvoiceAccountingId) AND (\"eninvoiceaccountingservices5\".\"invoiceaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingServices_InvoiceAccountingId", DbType.Int64, qpinInvoiceAccountingServices_InvoiceAccountingId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingservices5\".\"invoiceaccountingid\" IS NULL)");
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
RL_e547ae2a729a8ddc0c9af52ac3c70a26 outParamList = new RL_e547ae2a729a8ddc0c9af52ac3c70a26();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingServicesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, false, true, false, true, true, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_2Prepare.GetInvoiceAccountingServicesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e547ae2a729a8ddc0c9af52ac3c70a26 _tmp = new RL_e547ae2a729a8ddc0c9af52ac3c70a26();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingServicesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_2Prepare.GetInvoiceAccountingServicesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e547ae2a729a8ddc0c9af52ac3c70a26)_tmp;
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
