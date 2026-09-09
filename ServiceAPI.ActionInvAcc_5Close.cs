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

    public class S4PIInvAcc_5CloseInput {
[JsonProperty("InvoiceAccountingProcessId")]
public long? inParamInvoiceAccountingProcessId;
public S4PIInvAcc_5CloseInput(long? inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}

}

public class S4PIInvAcc_5CloseOutput {
[JsonProperty("IsServiceError")]
public bool outParamIsServiceError;
[JsonProperty("IsError")]
public bool outParamIsError;
[JsonProperty("Message")]
public string outParamMessage;
public S4PIInvAcc_5CloseOutput(bool outParamIsServiceError, bool outParamIsError, string outParamMessage) {
this.outParamIsServiceError = outParamIsServiceError;
this.outParamIsError = outParamIsError;
this.outParamMessage = outParamMessage;
}

public bool ShouldSerializeoutParamIsServiceError() {return (this.outParamIsServiceError != false);
}
public bool ShouldSerializeoutParamIsError() {return (this.outParamIsError != false);
}
}

[HttpPost()]
[Route("serviceapi/invacc_5close")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "InvAcc_5Close", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIInvAcc_5Close(CancellationToken cancellationToken) {return await EndpointAsync<S4PIInvAcc_5CloseInput, S4PIInvAcc_5CloseOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
bool outParamIsServiceError;
bool outParamIsError;
string outParamMessage;
S4PIInvAcc_5CloseInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamInvoiceAccountingProcessId == null)) {
validationErrors["InvoiceAccountingProcessId"]=new string[] {"The InvoiceAccountingProcessId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamIsServiceError,outParamIsError,outParamMessage) = await Flows.ActionInvAcc_5Close(context,inputs.inParamInvoiceAccountingProcessId.Value,ctx);

return new S4PIInvAcc_5CloseOutput(outParamIsServiceError, outParamIsError, outParamMessage);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvInvAcc_5Close : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>Response</code> that represents the Service Studio InvoiceAccountingProcessResponse
///  <code>Response</code> <p>Description: </p>
/// </summary>
public EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord varLcResponse = new EN_e91123b36c7b071a4454698bbf50e4bcEntityRecord();

/// <summary>
/// Variable <code>RetentionsList</code> that represents the Service Studio TI_RETENCIONES_In3List
///  <code>RetentionsList</code> <p>Description: </p>
/// </summary>
public RL_725bda958021cd78431a036d1def2d7e varLcRetentionsList = new RL_725bda958021cd78431a036d1def2d7e();

/// <summary>
/// Variable <code>InvoiceName</code> that represents the Service Studio Text <code>InvoiceName</code>
///  <p>Description: </p>
/// </summary>
public string varLcInvoiceName = "";

/// <summary>
/// Variable <code>Society</code> that represents the Service Studio Text <code>Society</code>
///  <p>Description: </p>
/// </summary>
public string varLcSociety = "";

/// <summary>
/// Variable <code>SupplierNumber</code> that represents the Service Studio Text
///  <code>SupplierNumber</code> <p>Description: </p>
/// </summary>
public string varLcSupplierNumber = "";

/// <summary>
/// Variable <code>RegionFI</code> that represents the Service Studio Text <code>RegionFI</code>
///  <p>Description: </p>
/// </summary>
public string varLcRegionFI = "";

/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate7 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public ST_b29967856499aeaa8c796dc87fe4c6e8Structure resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();

public RL_e62ece2f731d9d568d38eaab7d6db3fb queryResGetProcessById_outParamList = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
public long queryResGetProcessById_outParamCount = 0L;

public RL_d8257fba7f427e1268305606412dd313 queryResGetProcessRetentionsById_outParamList = new RL_d8257fba7f427e1268305606412dd313();
public long queryResGetProcessRetentionsById_outParamCount = 0L;

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate5 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public RL_c523bce2fb9ae799ea203ce8adb1c163 queryResGetProcessResponse_outParamList = new RL_c523bce2fb9ae799ea203ce8adb1c163();
public long queryResGetProcessResponse_outParamCount = 0L;

public Actions.lcoUploadInvoiceFiles_ValidationServices resUploadInvoiceFiles_XMLValidationsPAC2 =  new Actions.lcoUploadInvoiceFiles_ValidationServices();
public RL_00a03f803f0d49826089181417370afb queryResGetXMLInvoiceFileById_outParamList = new RL_00a03f803f0d49826089181417370afb();
public long queryResGetXMLInvoiceFileById_outParamCount = 0L;

public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate4 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate6 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public lcvInvAcc_5Close(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoInvAcc_5Close : VarsBag {
public bool outParamIsServiceError = false;

public bool outParamIsError = false;

public string outParamMessage = "";

public lcoInvAcc_5Close() {
}
}
/// <summary>
/// Action <code>InvAcc_5Close</code> that represents the Service Studio action
///  <code>InvAcc_5Close</code> <p> Description: Call Retentions and PAC services</p>
/// </summary>
public static async Task<(bool,bool,string)> ActionInvAcc_5Close(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
bool outParamIsServiceError = default;
bool outParamIsError = default;
string outParamMessage = default;
lcoInvAcc_5Close result = new lcoInvAcc_5Close();
lcvInvAcc_5Close localVars = new lcvInvAcc_5Close(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("InvAcc_5Close", "60121b3c-a25e-42e5-a866-6871b9decf4c"))
using (activitySource.CreateServiceActionActivity("InvAcc_5Close")){
// Query datasetGetProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessById_maxRecords = 1;
if (datasetGetProcessById_maxRecords < 1) datasetGetProcessById_maxRecords = 1;
int datasetGetProcessById_startIndex = 0;(localVars.queryResGetProcessById_outParamList,localVars.queryResGetProcessById_outParamCount) = await FuncActionInvAcc_5Close.datasetGetProcessById(requestContext,datasetGetProcessById_maxRecords,datasetGetProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// Query datasetGetProcessRetentionsById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessRetentionsById_maxRecords = 0;
int datasetGetProcessRetentionsById_startIndex = 0;(localVars.queryResGetProcessRetentionsById_outParamList,localVars.queryResGetProcessRetentionsById_outParamCount) = await FuncActionInvAcc_5Close.datasetGetProcessRetentionsById(requestContext,datasetGetProcessRetentionsById_maxRecords,datasetGetProcessRetentionsById_startIndex,IterationMultiplicity.Single,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// Query datasetGetProcessResponse
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessResponse_maxRecords = 0;
int datasetGetProcessResponse_startIndex = 0;(localVars.queryResGetProcessResponse_outParamList,localVars.queryResGetProcessResponse_outParamCount) = await FuncActionInvAcc_5Close.datasetGetProcessResponse(requestContext,datasetGetProcessResponse_maxRecords,datasetGetProcessResponse_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// InvoiceName = GetProcessById.List.Current.InvoiceAccountingProcess.InvoiceId
localVars.varLcInvoiceName=BuiltInFunction.LongIntegerToText(localVars.queryResGetProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId);

// Society = GetProcessById.List.Current.Company.ExternalId
localVars.varLcSociety=localVars.queryResGetProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// SupplierNumber = GetProcessById.List.Current.Supplier.Number
localVars.varLcSupplierNumber=localVars.queryResGetProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber;

// RegionFI = GetProcessById.List.Current.Region.DivisionFI
localVars.varLcRegionFI=localVars.queryResGetProcessById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// RetentionsList = GetProcessRetentionsById.List
localVars.varLcRetentionsList=(await RL_725bda958021cd78431a036d1def2d7e.ConvertAsync(localVars.queryResGetProcessRetentionsById_outParamList, new RL_725bda958021cd78431a036d1def2d7e(), async (RC_572bb5931fdd9ca097b2d3800101c49b source, ST_57edec30140ebe846267970253841d11Structure target, CancellationToken cancellationToken) => {
target.ssWITHT = source.ssENInvoiceAccountingProcessRetentions.ssWITHT;
target.ssWT_WITHCD = source.ssENInvoiceAccountingProcessRetentions.ssWT_WITHCD;
target.ssWT_SUBJCT = source.ssENInvoiceAccountingProcessRetentions.ssWT_SUBJCT;
return target;
}, cancellationToken));

// Response = GetProcessResponse.List.Current.InvoiceAccountingProcessResponse
localVars.varLcResponse=localVars.queryResGetProcessResponse_outParamList.CurrentRec.ssENInvoiceAccountingProcessResponse;
// has retentions
if(((!localVars.queryResGetProcessRetentionsById_outParamList.Empty))) {
// LogsAccountingCreate4
localVars.resLogsAccountingCreate4.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("After Contab - RetentionsInvoice "+localVars.varLcInvoiceName), ssDescription = ((((("PI_BUKRS "+localVars.varLcSociety)+" // PI_VENDORNO ")+localVars.varLcSupplierNumber)+"// RETENCION 1 ")+localVars.queryResGetProcessRetentionsById_outParamList.CurrentRec.ssENInvoiceAccountingProcessRetentions.ssWITHT), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// Call_ZMXFFIMF_INSERT_UPDROV2
localVars.resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_INSERT_UPDROV(requestContext,new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(){ ssPI_BUKRS = localVars.varLcSociety, ssPI_VENDORNO = localVars.varLcSupplierNumber, ssTI_RETENCIONES_In = localVars.varLcRetentionsList },cancellationToken);

// ActionTimestampsCreateOrUpdate5
localVars.resActionTimestampsCreateOrUpdate5.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Reset retentions"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// IsError = Index < 0
result.outParamIsError=(BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse.ssPO_RESPUESTA, "S -", 0, false, false)<0);

// Message = Call_ZMXFFIMF_INSERT_UPDROV2.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse.ssPO_RESPUESTA;
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("After Contab - RetentionsInvoice "+localVars.varLcInvoiceName), ssDescription = ((((result.outParamIsError) ? ("Error") : ("Ok"))+" // RESPUESTA ")+BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse.ssPO_RESPUESTA, 0, 50)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

}

// contab error without msg
if(((((!localVars.varLcResponse.ssIsSuccess)&&(localVars.queryResGetProcessResponse_outParamList.CurrentRec.ssENInvoiceAccountingProcessResponse.ssPO_RESULTADO==""))&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// IsServiceError = True
result.outParamIsServiceError=true;
} else {
// IsError = notResponse.IsSuccess
result.outParamIsError=(!localVars.varLcResponse.ssIsSuccess);

// Message = Response.PO_RESULTADO
result.outParamMessage=localVars.varLcResponse.ssPO_RESULTADO;
// contab error?
if((!((((BuiltInFunction.SubstrSC (localVars.varLcResponse.ssPO_RESULTADO, 0, 1)=="E")||(localVars.varLcResponse.ssID_POLIZA==""))||(BuiltInFunction.SubstrSC (localVars.varLcResponse.ssCODIGO, 0, 1)=="E"))))) {
// Query datasetGetXMLInvoiceFileById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetXMLInvoiceFileById_maxRecords = 1;
if (datasetGetXMLInvoiceFileById_maxRecords < 1) datasetGetXMLInvoiceFileById_maxRecords = 1;
int datasetGetXMLInvoiceFileById_startIndex = 0;(localVars.queryResGetXMLInvoiceFileById_outParamList,localVars.queryResGetXMLInvoiceFileById_outParamCount) = await FuncActionInvAcc_5Close.datasetGetXMLInvoiceFileById(requestContext,datasetGetXMLInvoiceFileById_maxRecords,datasetGetXMLInvoiceFileById_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessById_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// foreigner
if((!(localVars.queryResGetXMLInvoiceFileById_outParamList.Empty))) {
// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.queryResGetXMLInvoiceFileById_outParamList.CurrentRec.ssENInvoiceFile.ssStorageId,cancellationToken);

// ActionTimestampsCreateOrUpdate6
localVars.resActionTimestampsCreateOrUpdate6.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Get xml from storage"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// UploadInvoiceFiles_XMLValidationsPAC2
localVars.resUploadInvoiceFiles_XMLValidationsPAC2.outParamErrorMsg = await Actions.ActionUploadInvoiceFiles_ValidationServices(requestContext,true,localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename,localVars.varLcSupplierNumber,localVars.varLcRegionFI,localVars.varLcSociety,cancellationToken);

// ActionTimestampsCreateOrUpdate7
localVars.resActionTimestampsCreateOrUpdate7.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - PAC Validations"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsServiceError = result.outParamIsServiceError;
outParamIsError = result.outParamIsError;
outParamMessage = result.outParamMessage;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsServiceError,outParamIsError,outParamMessage);
}

        public static class FuncActionInvAcc_5Close {
            
private static async Task<RC_fed31beb7af18398732c8010e2ffd34a> datasetGetProcessByIdReadDbAsync(RC_fed31beb7af18398732c8010e2ffd34a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetProcessById" HZ8KSass70qS71kKN0EsJA of Action "InvAcc_5Close"
public static async Task<(RL_e62ece2f731d9d568d38eaab7d6db3fb,long)> datasetGetProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_5Close.GetProcessById", "490a9f1d-2cab-4aef-92ef-590a37412c24");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_5Close.GetProcessById", "490a9f1d-2cab-4aef-92ef-590a37412c24", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.PBsSYF6i5UKoZmhxud7PTA/NodesNotShownInESpaceTree.HZ8KSass70qS71kKN0EsJA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany16\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"eninvoice84\".\"id\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"eninvoiceaccountingprocess14\".\"invoiceid\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enregion69\".\"divisionfi\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, \"ensupplier52\".\"number\" o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142");
fromBuilder.Append(" FROM ((((({InvoiceAccountingProcess} \"eninvoiceaccountingprocess14\" Left JOIN {Invoice} \"eninvoice84\" ON (\"eninvoiceaccountingprocess14\".\"invoiceid\" = \"eninvoice84\".\"id\"))  Left JOIN {Requisition} \"enrequisition77\" ON (\"eninvoice84\".\"requisitionid\" = \"enrequisition77\".\"id\"))  Left JOIN {Region} \"enregion69\" ON (\"enrequisition77\".\"regionid\" = \"enregion69\".\"id\"))  Left JOIN {Supplier} \"ensupplier52\" ON (\"enrequisition77\".\"supplierid\" = \"ensupplier52\".\"id\"))  Left JOIN {Company} \"encompany16\" ON (\"enrequisition77\".\"companyid\" = \"encompany16\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess14\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess14\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess14\".\"id\" IS NULL)");
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
outParamList.AlternateReadDbMethodAsync = datasetGetProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_5Close.GetProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e62ece2f731d9d568d38eaab7d6db3fb _tmp = new RL_e62ece2f731d9d568d38eaab7d6db3fb();
_tmp.AlternateReadDbMethodAsync = datasetGetProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_5Close.GetProcessById.List", cancellationToken: cancellationToken);
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

// Query Function "GetProcessRetentionsById" uT9cXE3KCkCrjrkwhBG2fg of Action "InvAcc_5Close"
public static async Task<(RL_d8257fba7f427e1268305606412dd313,long)> datasetGetProcessRetentionsById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcessId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_5Close.GetProcessRetentionsById", "5c5c3fb9-ca4d-400a-ab8e-b9308411b67e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_5Close.GetProcessRetentionsById", "5c5c3fb9-ca4d-400a-ab8e-b9308411b67e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.PBsSYF6i5UKoZmhxud7PTA/NodesNotShownInESpaceTree.uT9cXE3KCkCrjrkwhBG2fg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoiceaccountingprocessretentions\".\"witht\" o2, \"eninvoiceaccountingprocessretentions\".\"wt_withcd\" o3, \"eninvoiceaccountingprocessretentions\".\"wt_subjct\" o4");
fromBuilder.Append(" FROM {InvoiceAccountingProcessRetentions} \"eninvoiceaccountingprocessretentions\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcessId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocessretentions\".\"invoiceaccountingprocessid\" = @qpinInvoiceAccountingProcessId) AND (\"eninvoiceaccountingprocessretentions\".\"invoiceaccountingprocessid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcessId", DbType.Int64, qpinInvoiceAccountingProcessId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocessretentions\".\"invoiceaccountingprocessid\" IS NULL)");
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
RL_d8257fba7f427e1268305606412dd313 outParamList = new RL_d8257fba7f427e1268305606412dd313();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_5Close.GetProcessRetentionsById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d8257fba7f427e1268305606412dd313 _tmp = new RL_d8257fba7f427e1268305606412dd313();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_5Close.GetProcessRetentionsById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d8257fba7f427e1268305606412dd313)_tmp;
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

// Query Function "GetProcessResponse" PRyEcTzxXE+seVSzJtl8ug of Action "InvAcc_5Close"
public static async Task<(RL_c523bce2fb9ae799ea203ce8adb1c163,long)> datasetGetProcessResponse(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcessId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_5Close.GetProcessResponse", "71841c3d-f13c-4f5c-ac79-54b326d97cba");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_5Close.GetProcessResponse", "71841c3d-f13c-4f5c-ac79-54b326d97cba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.PBsSYF6i5UKoZmhxud7PTA/NodesNotShownInESpaceTree.PRyEcTzxXE+seVSzJtl8ug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceaccountingprocessresponse1\".\"issuccess\" o1, \"eninvoiceaccountingprocessresponse1\".\"id_poliza\" o2, NULL o3, \"eninvoiceaccountingprocessresponse1\".\"po_resultado\" o4, \"eninvoiceaccountingprocessresponse1\".\"codigo\" o5");
fromBuilder.Append(" FROM {InvoiceAccountingProcessResponse} \"eninvoiceaccountingprocessresponse1\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcessId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocessresponse1\".\"invoiceaccountingprocessid\" = @qpinInvoiceAccountingProcessId) AND (\"eninvoiceaccountingprocessresponse1\".\"invoiceaccountingprocessid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcessId", DbType.Int64, qpinInvoiceAccountingProcessId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocessresponse1\".\"invoiceaccountingprocessid\" IS NULL)");
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
RL_c523bce2fb9ae799ea203ce8adb1c163 outParamList = new RL_c523bce2fb9ae799ea203ce8adb1c163();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, true, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_5Close.GetProcessResponse.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c523bce2fb9ae799ea203ce8adb1c163 _tmp = new RL_c523bce2fb9ae799ea203ce8adb1c163();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_5Close.GetProcessResponse.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c523bce2fb9ae799ea203ce8adb1c163)_tmp;
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

// Query Function "GetXMLInvoiceFileById" mJcri1I6g02Z0z28_QYYdQ of Action "InvAcc_5Close"
public static async Task<(RL_00a03f803f0d49826089181417370afb,long)> datasetGetXMLInvoiceFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvAcc_5Close.GetXMLInvoiceFileById", "8b2b9798-3a52-4d83-99d3-3dbcfd061875");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvAcc_5Close.GetXMLInvoiceFileById", "8b2b9798-3a52-4d83-99d3-3dbcfd061875", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.PBsSYF6i5UKoZmhxud7PTA/NodesNotShownInESpaceTree.mJcri1I6g02Z0z28_QYYdQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, \"eninvoicefile27\".\"storageid\" o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceFile} \"eninvoicefile27\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoicefile27\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoicefile27\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoicefile27\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (NOT (\"eninvoicefile27\".\"isextra\" = 1)) AND (((CASE WHEN char_length(caseaccent_normalize('.xml' collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize('.xml' collate \"default\") in caseaccent_normalize((Lower(\"eninvoicefile27\".\"filename\")) collate \"default\"))-1) END)) <> (-1))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvAcc_5Close.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvAcc_5Close.GetXMLInvoiceFileById.List", cancellationToken: cancellationToken);
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

        }
    }
}
