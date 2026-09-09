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

    public class S4PIInvAcc_1BeginInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvAcc_1BeginInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvAcc_1BeginOutput {
[JsonProperty("IsSuccess")]
public bool outParamIsSuccess;
[JsonProperty("Message")]
public string outParamMessage;
[JsonProperty("CanTryAgain")]
public bool outParamCanTryAgain;
[JsonProperty("IsServiceError")]
public bool outParamIsServiceError;
[JsonProperty("IsAlreadyProcessed")]
public bool outParamIsAlreadyProcessed;
public S4PIInvAcc_1BeginOutput(bool outParamIsSuccess, string outParamMessage, bool outParamCanTryAgain, bool outParamIsServiceError, bool outParamIsAlreadyProcessed) {
this.outParamIsSuccess = outParamIsSuccess;
this.outParamMessage = outParamMessage;
this.outParamCanTryAgain = outParamCanTryAgain;
this.outParamIsServiceError = outParamIsServiceError;
this.outParamIsAlreadyProcessed = outParamIsAlreadyProcessed;
}

public bool ShouldSerializeoutParamIsSuccess() {return (this.outParamIsSuccess != true);
}
public bool ShouldSerializeoutParamIsServiceError() {return (this.outParamIsServiceError != true);
}
public bool ShouldSerializeoutParamIsAlreadyProcessed() {return (this.outParamIsAlreadyProcessed != false);
}
}

[HttpPost()]
[Route("serviceapi/invacc_1begin")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvAcc_1Begin", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvAcc_1Begin(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvAcc_1BeginInput, S4PIInvAcc_1BeginOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsSuccess;
string outParamMessage;
bool outParamCanTryAgain;
bool outParamIsServiceError;
bool outParamIsAlreadyProcessed;
S4PIInvAcc_1BeginInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamIsSuccess,outParamMessage,outParamCanTryAgain,outParamIsServiceError,outParamIsAlreadyProcessed) = await Flows.ActionInvAcc_1Begin(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvAcc_1BeginOutput(outParamIsSuccess, outParamMessage, outParamCanTryAgain, outParamIsServiceError, outParamIsAlreadyProcessed);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvAcc_1Begin : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>InvoiceAccountingProcess</code> that represents the Service Studio
///  InvoiceAccountingProcess <code>InvoiceAccountingProcess</code> <p>Description: </p>
/// </summary>
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord varLcInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();

/// <summary>
/// Variable <code>InvoiceName</code> that represents the Service Studio Text <code>InvoiceName</code>
///  <p>Description: </p>
/// </summary>
public string varLcInvoiceName = "";

/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public RL_00a03f803f0d49826089181417370afb queryResGetXMLInvoiceFileById_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetXMLInvoiceFileById_outParamCount = 0L;

public Actions.lcoInvoiceAccountingProcessRetentionsCreate resInvoiceAccountingProcessRetentionsCreate =  new Actions.lcoInvoiceAccountingProcessRetentionsCreate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate8 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public ST_24353ddcec93ac51b13ce9ab94fe4001Structure resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse = new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate5 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate7 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate9 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate10 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoInvoiceTaxesRetentionRulesReset resInvoiceTaxesRetentionRulesReset =  new Actions.lcoInvoiceTaxesRetentionRulesReset();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate6 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public RL_4b72a47efbb84d37cf5e3e0ffb46314d resListFilter_outParamFilteredList = new RL_4b72a47efbb84d37cf5e3e0ffb46314d();

public RL_e62ece2f731d9d568d38eaab7d6db3fb queryResGetInvoiceAccountingProcessById_outParamList = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public ST_b29967856499aeaa8c796dc87fe4c6e8Structure resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();

public RL_203255693769e898ae6969552ca60cf6 queryResGetItemRetentionsByInvoiceId_outParamList = new RL_203255693769e898ae6969552ca60cf6();
public long queryResGetItemRetentionsByInvoiceId_outParamCount = 0L;

public Actions.lcoUploadInvoiceFiles_ValidationServices resUploadInvoiceFiles_XMLValidationsPAC =  new Actions.lcoUploadInvoiceFiles_ValidationServices();
public lcvInvAcc_1Begin(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoInvAcc_1Begin : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public bool outParamCanTryAgain = false;

public bool outParamIsServiceError = true;

public bool outParamIsAlreadyProcessed = false;

public lcoInvAcc_1Begin() {
}
}
/// <summary>
/// Action <code>InvAcc_1Begin</code> that represents the Service Studio action
///  <code>InvAcc_1Begin</code> <p> Description: Call the services before accounting</p>
/// </summary>
public static async Task<(bool,string,bool,bool,bool)> ActionInvAcc_1Begin(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
bool outParamCanTryAgain = default;
bool outParamIsServiceError = default;
bool outParamIsAlreadyProcessed = default;
lcoInvAcc_1Begin result = new lcoInvAcc_1Begin();
lcvInvAcc_1Begin localVars = new lcvInvAcc_1Begin(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvAcc_1Begin", "94b52d8e-9cf5-4925-bba5-b9364b51e278"))
using (activitySource.CreateServiceActionActivity("InvAcc_1Begin")){
// ActionTimestampsCreateOrUpdate9
localVars.resActionTimestampsCreateOrUpdate9.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Accounting started"), ssStartedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionInvAcc_1Begin.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// IsSuccess = True
result.outParamIsSuccess=true;

// InvoiceAccountingProcess = GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcess
localVars.varLcInvoiceAccountingProcess=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess;

// CanTryAgain = InvoiceAccountingProcess.NextTry < 3
result.outParamCanTryAgain=(localVars.varLcInvoiceAccountingProcess.ssNextTry<3);

// InvoiceName = GetInvoiceAccountingProcessById.List.Current.Invoice.Name
localVars.varLcInvoiceName=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName;

// InvoiceAccountingProcess.NextTry = InvoiceAccountingProcess.NextTry + 1
localVars.varLcInvoiceAccountingProcess.ssNextTry = (localVars.varLcInvoiceAccountingProcess.ssNextTry+1);
// already processed
if(((localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssID_POLIZA_SAP!=""))) {
// IsAlreadyProcessed = True
result.outParamIsAlreadyProcessed=true;

// IsSuccess = False
result.outParamIsSuccess=false;

// CanTryAgain = False
result.outParamCanTryAgain=false;

// Message = "Invoice accounting already processed"
result.outParamMessage=AppUtils.GetStringResource("hH0UoYYdCkekP9Zw7z75Sw#Value.-810956562.1", "Invoice accounting already processed");
} else {
// foreigner
if((!((localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX")))) {
// ActionTimestampsCreateOrUpdate10
localVars.resActionTimestampsCreateOrUpdate10.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = ((("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" | Invoice: ")+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// Query datasetGetXMLInvoiceFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetXMLInvoiceFileById_maxRecords = 1;
if (datasetGetXMLInvoiceFileById_maxRecords < 1) datasetGetXMLInvoiceFileById_maxRecords = 1;
int datasetGetXMLInvoiceFileById_startIndex = 0;(localVars.queryResGetXMLInvoiceFileById_outParamList,localVars.queryResGetXMLInvoiceFileById_outParamCount) = await FuncActionInvAcc_1Begin.datasetGetXMLInvoiceFileById(requestContext,datasetGetXMLInvoiceFileById_maxRecords,datasetGetXMLInvoiceFileById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.queryResGetXMLInvoiceFileById_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

// file error?
if((BinaryContentUtils.AreBothBinariesNull(localVars.resServiceStorageGetFile_outParamo_File, BuiltInFunction.NullBinary ()))) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "ERROR FETCHING INVOICE FILE"
result.outParamMessage=AppUtils.GetStringResource("9G6hR2S13kSqx8WnJp_SSg#Value.-1310476113.1", "ERROR FETCHING INVOICE FILE");

// CanTryAgain = False
result.outParamCanTryAgain=false;
} else {
// ActionTimestampsCreateOrUpdate5
localVars.resActionTimestampsCreateOrUpdate5.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Get xml from storage"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// UploadInvoiceFiles_XMLValidationsPAC
localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg = await Actions.ActionUploadInvoiceFiles_ValidationServices(requestContext,false,localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENRegion.ssDivisionFI,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId,cancellationToken);

// ActionTimestampsCreateOrUpdate6
localVars.resActionTimestampsCreateOrUpdate6.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - PAC validations"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// cfdi error?
if((((localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg!="")&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = UploadInvoiceFiles_XMLValidationsPAC.ErrorMsg
result.outParamMessage=localVars.resUploadInvoiceFiles_XMLValidationsPAC.outParamErrorMsg;
// InvoiceAccountingProcess_TryAgain
await Actions.ActionInvoiceAccountingProcess_TryAgain(requestContext,localVars.varLcInvoiceAccountingProcess.ssInvoiceId,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName,localVars.varLcInvoiceAccountingProcess,result.outParamMessage,cancellationToken);

} else {
// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// Query datasetGetItemRetentionsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetItemRetentionsByInvoiceId_maxRecords = 1;
if (datasetGetItemRetentionsByInvoiceId_maxRecords < 1) datasetGetItemRetentionsByInvoiceId_maxRecords = 1;
int datasetGetItemRetentionsByInvoiceId_startIndex = 0;(localVars.queryResGetItemRetentionsByInvoiceId_outParamList,localVars.queryResGetItemRetentionsByInvoiceId_outParamCount) = await FuncActionInvAcc_1Begin.datasetGetItemRetentionsByInvoiceId(requestContext,datasetGetItemRetentionsByInvoiceId_maxRecords,datasetGetItemRetentionsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// Call_ZMXFAPMF_CONSUL_RETENPROV
localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFAPMF_CONSUL_RETENPROV(requestContext,new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure(){ ssPI_BUKRS = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId, ssPI_VENDORNO = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber },cancellationToken);

// ActionTimestampsCreateOrUpdate7
localVars.resActionTimestampsCreateOrUpdate7.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Get active retentions"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// consult error?
if((((localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssPO_RESPUESTA=="")&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = Call_ZMXFAPMF_CONSUL_RETENPROV.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssPO_RESPUESTA;
// InvoiceAccountingProcess_TryAgain2
await Actions.ActionInvoiceAccountingProcess_TryAgain(requestContext,localVars.varLcInvoiceAccountingProcess.ssInvoiceId,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName,localVars.varLcInvoiceAccountingProcess,result.outParamMessage,cancellationToken);

} else {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_4b72a47efbb84d37cf5e3e0ffb46314d)await  localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.FilterAsync(async (p, cancellationToken) => (p.ssWT_SUBJCT=="X"), cancellationToken)));

// empty
if((!((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.Empty&&localVars.resListFilter_outParamFilteredList.Empty)))) {
// InvoiceTaxesRetentionRulesReset
(localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List,localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List,localVars.resInvoiceTaxesRetentionRulesReset.outParamIsToCancel) = await Actions.ActionInvoiceTaxesRetentionRulesReset(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,(await RL_725bda958021cd78431a036d1def2d7e.ConvertAsync(localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out, new RL_725bda958021cd78431a036d1def2d7e(), async (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure source, ST_57edec30140ebe846267970253841d11Structure target, CancellationToken cancellationToken) => {
target.ssWITHT = source.ssWITHT;
target.ssWT_WITHCD = source.ssWT_WITHCD;
target.ssWT_SUBJCT = source.ssWT_SUBJCT;
return target;
}, cancellationToken)),cancellationToken);

// retentions error?
if((localVars.resInvoiceTaxesRetentionRulesReset.outParamIsToCancel)) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "INVALID RETENTIONS"
result.outParamMessage=AppUtils.GetStringResource("T8Shg6t60UetZxZMDMrO6A#Value.164728574.1", "INVALID RETENTIONS");

// CanTryAgain = False
result.outParamCanTryAgain=false;

// IsServiceError = False
result.outParamIsServiceError=false;
} else {
// has retentions
if(((!localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List.Empty))) {
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("Before Contab - Retentions Invoice "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ((((("PI_BUKRS "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId)+" // PI_VENDORNO ")+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber)+"// RETENCION 1 ")+localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List.CurrentRec.ssWITHT), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// Call_ZMXFFIMF_INSERT_UPDROV
localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_INSERT_UPDROV(requestContext,new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(){ ssPI_BUKRS = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId, ssPI_VENDORNO = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber, ssTI_RETENCIONES_In = localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List },cancellationToken);

// ActionTimestampsCreateOrUpdate8
localVars.resActionTimestampsCreateOrUpdate8.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Call active retentions"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// IsSuccess = Index <> -1
result.outParamIsSuccess=(BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, "S -", 0, false, false)!=(-1));

// Message = Call_ZMXFFIMF_INSERT_UPDROV.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA;
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("Before Contab - Retentions Invoice "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ("RESPUESTA "+BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, 0, 50)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

}

// IsSuccess = IsSuccess or IsActiveSkipAccountingError
result.outParamIsSuccess=(result.outParamIsSuccess||((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))));
// activation error?
if(((!result.outParamIsSuccess))) {
// InvoiceAccountingProcess_TryAgain3
await Actions.ActionInvoiceAccountingProcess_TryAgain(requestContext,localVars.varLcInvoiceAccountingProcess.ssInvoiceId,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName,localVars.varLcInvoiceAccountingProcess,result.outParamMessage,cancellationToken);

} else {
// Foreach InvoiceTaxesRetentionRulesReset.RetentionsCall2List
localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List.StartIteration();
try {while (!((localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List.Eof))) {
// InvoiceAccountingProcessRetentionsCreate
localVars.resInvoiceAccountingProcessRetentionsCreate.outParamId = await Actions.ActionInvoiceAccountingProcessRetentionsCreate(requestContext,new EN_b5a4fdb73161852bf014862cdc591a06EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssInvoiceAccountingProcessId = localVars.inParamInvoiceAccountingProcessId, ssWITHT = localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List.CurrentRec.ssWITHT, ssWT_WITHCD = localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List.CurrentRec.ssWT_WITHCD, ssWT_SUBJCT = localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List.CurrentRec.ssWT_SUBJCT },cancellationToken);

localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List.Advance();
}

} finally {
localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List.EndIteration();
}

}

}

}

}

}

}

}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "Error in contabilization service. Please contact an administrator."
result.outParamMessage=AppUtils.GetStringResource("MS4YKVUC2EWURmt9wFEnFw#Value.1045336240.1", "Error in contabilization service. Please contact an administrator.");
// InvoiceAccountingProcess_TryAgain4
await Actions.ActionInvoiceAccountingProcess_TryAgain(requestContext,localVars.varLcInvoiceAccountingProcess.ssInvoiceId,localVars.varLcInvoiceName,localVars.varLcInvoiceAccountingProcess,result.outParamMessage,cancellationToken);

goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
outParamCanTryAgain = result.outParamCanTryAgain;
outParamIsServiceError = result.outParamIsServiceError;
outParamIsAlreadyProcessed = result.outParamIsAlreadyProcessed;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage,outParamCanTryAgain,outParamIsServiceError,outParamIsAlreadyProcessed);
}

        public static class FuncActionInvAcc_1Begin {
            
// Query Function "GetXMLInvoiceFileById" O3auCIwBv0m+JNEihDN1Zw of Action "InvAcc_1Begin"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetXMLInvoiceFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_1Begin.GetXMLInvoiceFileById", "08ae763b-018c-49bf-be24-d12284337567");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_1Begin.GetXMLInvoiceFileById", "08ae763b-018c-49bf-be24-d12284337567", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.ji21lPWcJUm7pbk2S1HieA/NodesNotShownInESpaceTree.O3auCIwBv0m+JNEihDN1Zw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile29\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile29\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile29\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile29\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile29\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (\"eninvoicefile29\".\"isextra\" = 1)) AND (((CASE WHEN char_length(caseaccent_normalize('.xml' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('.xml' collate \"default\") in caseaccent_normalize((Lower(\"eninvoicefile29\".\"filename\")) collate \"default\"))-1) END)) <> (-1))");
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
RL_00a03f803f0d49826089181417370afb outParamList = new RL_00a03f803f0d49826089181417370afb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_1Begin.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_00a03f803f0d49826089181417370afb _tmp = new RL_00a03f803f0d49826089181417370afb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_1Begin.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_00a03f803f0d49826089181417370afb)_tmp;
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

private static async Task<RC_fed31beb7af18398732c8010e2ffd34a> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_fed31beb7af18398732c8010e2ffd34a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" nVj9sIQ9u0e+6q_KEZZpKA of Action "InvAcc_1Begin"
public static async Task<(RL_e62ece2f731d9d568d38eaab7d6db3fb,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_1Begin.GetInvoiceAccountingProcessById", "b0fd589d-3d84-47bb-beea-afca11966928");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_1Begin.GetInvoiceAccountingProcessById", "b0fd589d-3d84-47bb-beea-afca11966928", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.ji21lPWcJUm7pbk2S1HieA/NodesNotShownInESpaceTree.nVj9sIQ9u0e+6q_KEZZpKA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany18\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"eninvoice89\".\"id\" o11, \"eninvoice89\".\"name\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"eninvoice89\".\"id_poliza_sap\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"eninvoiceaccountingprocess18\".\"id\" o35, \"eninvoiceaccountingprocess18\".\"invoiceid\" o36, \"eninvoiceaccountingprocess18\".\"requisitionid\" o37, \"eninvoiceaccountingprocess18\".\"offsetutc\" o38, \"eninvoiceaccountingprocess18\".\"comment\" o39, \"eninvoiceaccountingprocess18\".\"processnumber\" o40, \"eninvoiceaccountingprocess18\".\"createdon\" o41, \"eninvoiceaccountingprocess18\".\"nexttry\" o42, \"eninvoiceaccountingprocess18\".\"invoiceprocessstatusid\" o43, NULL o44, NULL o45, NULL o46, \"enregion71\".\"divisionfi\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, \"ensupplier54\".\"number\" o118, NULL o119, NULL o120, NULL o121, NULL o122, \"ensupplier54\".\"pais\" o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142");
fromBuilder.Append(" FROM ((((({InvoiceAccountingProcess} \"eninvoiceaccountingprocess18\" Left JOIN {Invoice} \"eninvoice89\" ON (\"eninvoiceaccountingprocess18\".\"invoiceid\" = \"eninvoice89\".\"id\"))  Left JOIN {Requisition} \"enrequisition78\" ON (\"eninvoice89\".\"requisitionid\" = \"enrequisition78\".\"id\"))  Left JOIN {Supplier} \"ensupplier54\" ON (\"enrequisition78\".\"supplierid\" = \"ensupplier54\".\"id\"))  Left JOIN {Region} \"enregion71\" ON (\"enrequisition78\".\"regionid\" = \"enregion71\".\"id\"))  Left JOIN {Company} \"encompany18\" ON (\"enrequisition78\".\"companyid\" = \"encompany18\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess18\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess18\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess18\".\"id\" IS NULL)");
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
RL_e62ece2f731d9d568d38eaab7d6db3fb outParamList = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_1Begin.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e62ece2f731d9d568d38eaab7d6db3fb _tmp = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_1Begin.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e62ece2f731d9d568d38eaab7d6db3fb)_tmp;
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

private static async Task<RC_25d357c844d16eb6579210aff3596f77> datasetGetItemRetentionsByInvoiceIdReadDbAsync(RC_25d357c844d16eb6579210aff3596f77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceExtendedItem.Read( r, ref index);
rec.ssENInvoiceExtendedItemTax.Read( r, ref index);
return rec;
}
// Query Function "GetItemRetentionsByInvoiceId" qARb2fPTUkOa2Qff7Ydw8A of Action "InvAcc_1Begin"
public static async Task<(RL_203255693769e898ae6969552ca60cf6,long)> datasetGetItemRetentionsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItem_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_1Begin.GetItemRetentionsByInvoiceId", "d95b04a8-d3f3-4352-9ad9-07dfed8770f0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_1Begin.GetItemRetentionsByInvoiceId", "d95b04a8-d3f3-4352-9ad9-07dfed8770f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.ji21lPWcJUm7pbk2S1HieA/NodesNotShownInESpaceTree.qARb2fPTUkOa2Qff7Ydw8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15");
fromBuilder.Append(" FROM ({InvoiceExtendedItem} \"eninvoiceextendeditem7\" Left JOIN {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax8\" ON (\"eninvoiceextendeditem7\".\"id\" = \"eninvoiceextendeditemtax8\".\"invoiceextendeditemid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItem_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem7\".\"invoiceid\" = @qpinInvoiceExtendedItem_InvoiceId) AND (\"eninvoiceextendeditem7\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItem_InvoiceId", DbType.Int64, qpinInvoiceExtendedItem_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem7\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendeditemtax8\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId);
whereBuilder.Append(")");
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
RL_203255693769e898ae6969552ca60cf6 outParamList = new RL_203255693769e898ae6969552ca60cf6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetItemRetentionsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_1Begin.GetItemRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_203255693769e898ae6969552ca60cf6 _tmp = new RL_203255693769e898ae6969552ca60cf6();
_tmp.AlternateReadDbMethodAsync = datasetGetItemRetentionsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_1Begin.GetItemRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_203255693769e898ae6969552ca60cf6)_tmp;
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
