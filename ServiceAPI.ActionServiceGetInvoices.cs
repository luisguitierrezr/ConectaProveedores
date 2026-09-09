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

    public class S4PIServiceGetInvoicesInput {
[JsonProperty("CurrentLocale")]
public string inParamCurrentLocale;
[JsonProperty("MaxRecords")]
public int? inParamMaxRecords;
[JsonProperty("Startindex")]
public int? inParamStartindex;
[JsonProperty("TableSort")]
public string inParamTableSort;
[JsonProperty("UserApplicationRoles")]
public JSONRC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceGetInvoicesInput(string inParamCurrentLocale, int? inParamMaxRecords, int? inParamStartindex, string inParamTableSort, JSONRC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamStartindex = inParamStartindex;
this.inParamTableSort = inParamTableSort;
this.inParamUserApplicationRoles = inParamUserApplicationRoles;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetInvoicesOutput {
[JsonProperty("List")]
public JSONRC_acb134934352a9d72fd2cc0509d2f469[] outParamList;
[JsonProperty("TotalCount")]
public long outParamTotalCount;
public S4PIServiceGetInvoicesOutput(JSONRC_acb134934352a9d72fd2cc0509d2f469[] outParamList, long outParamTotalCount) {
this.outParamList = outParamList;
this.outParamTotalCount = outParamTotalCount;
}

}

[HttpPost()]
[Route("serviceapi/servicegetinvoices")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetInvoices", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetInvoices(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetInvoicesInput, S4PIServiceGetInvoicesOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList;
long outParamTotalCount;
S4PIServiceGetInvoicesInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamCurrentLocale == null)) {
validationErrors["CurrentLocale"]=new string[] {"The CurrentLocale mandatory parameter is missing in the request."};
}

if((inputs.inParamMaxRecords == null)) {
validationErrors["MaxRecords"]=new string[] {"The MaxRecords mandatory parameter is missing in the request."};
}

if((inputs.inParamStartindex == null)) {
validationErrors["Startindex"]=new string[] {"The Startindex mandatory parameter is missing in the request."};
}

if((inputs.inParamTableSort == null)) {
validationErrors["TableSort"]=new string[] {"The TableSort mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamList,outParamTotalCount) = await Flows.ActionServiceGetInvoices(context,inputs.inParamCurrentLocale,inputs.inParamMaxRecords.Value,inputs.inParamStartindex.Value,inputs.inParamTableSort,JSONRC_4eba0035378aebca97affd4e1528379d.ToStructure(inputs.inParamUserApplicationRoles, behaviorsConfiguration),inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetInvoicesOutput(RL_c5ca0a80d78493d156f2b1a68d86a831.ToArray(outParamList, (str) => JSONRC_acb134934352a9d72fd2cc0509d2f469.FromStructure(str, behaviorsConfiguration)), outParamTotalCount);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetInvoices : VarsBag {
public string inParamCurrentLocale;
public int inParamMaxRecords;
public int inParamStartindex;
public string inParamTableSort;
public RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>Iterator</code> that represents the Service Studio Integer <code>Iterator</code>
///  <p>Description: </p>
/// </summary>
public int varLcIterator = 0;

public RL_c5ca0a80d78493d156f2b1a68d86a831 resListFilter_outParamFilteredList = new RL_c5ca0a80d78493d156f2b1a68d86a831();

public RL_c5ca0a80d78493d156f2b1a68d86a831 resListFilter2_outParamFilteredList = new RL_c5ca0a80d78493d156f2b1a68d86a831();

public RL_c5ca0a80d78493d156f2b1a68d86a831 queryResGetInvoices_outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();
public long queryResGetInvoices_outParamCount = 0L;

public RL_c5ca0a80d78493d156f2b1a68d86a831 queryResGetInvoices2_outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();
public long queryResGetInvoices2_outParamCount = 0L;

public lcvServiceGetInvoices(string inParamCurrentLocale, int inParamMaxRecords, int inParamStartindex, string inParamTableSort, RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamStartindex = inParamStartindex;
this.inParamTableSort = inParamTableSort;
this.inParamUserApplicationRoles = inParamUserApplicationRoles;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetInvoices : VarsBag {
public RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();

public long outParamTotalCount = 0L;

public lcoServiceGetInvoices() {
}
}
/// <summary>
/// Action <code>ServiceGetInvoices</code> that represents the Service Studio action
///  <code>ServiceGetInvoices</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_c5ca0a80d78493d156f2b1a68d86a831,long)> ActionServiceGetInvoices(IRequestContext requestContext,string inParamCurrentLocale,int inParamMaxRecords,int inParamStartindex,string inParamTableSort,RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles,string inParami_GetUserId,CancellationToken cancellationToken) {
RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList = default;
long outParamTotalCount = default;
lcoServiceGetInvoices result = new lcoServiceGetInvoices();
lcvServiceGetInvoices localVars = new lcvServiceGetInvoices(inParamCurrentLocale, inParamMaxRecords, inParamStartindex, inParamTableSort, inParamUserApplicationRoles, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetInvoices", "a9409617-3544-4e46-a696-23d95bd79a95"))
using (activitySource.CreateServiceActionActivity("ServiceGetInvoices")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,(((localVars.inParamCurrentLocale=="")) ? ("es-MX") : (localVars.inParamCurrentLocale)),cancellationToken);

if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_OnlyNotApprovedMobile]))))) {
// Query datasetGetInvoices2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoices2_maxRecords = 0;
int datasetGetInvoices2_startIndex = 0;(localVars.queryResGetInvoices2_outParamList,localVars.queryResGetInvoices2_outParamCount) = await FuncActionServiceGetInvoices.datasetGetInvoices2(requestContext,datasetGetInvoices2_maxRecords,datasetGetInvoices2_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.inParamTableSort,localVars.inParamUserApplicationRoles.ssAppRolesListText,localVars.inParamUserApplicationRoles.ssCorporativoRegionId,localVars.inParamUserApplicationRoles.ssIsCorporativoCxP,localVars.inParamUserApplicationRoles.ssTelcelDirectionsListText,cancellationToken);

// Iterator = Startindex
localVars.varLcIterator=localVars.inParamStartindex;
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_c5ca0a80d78493d156f2b1a68d86a831)await  localVars.queryResGetInvoices2_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetInvoices2_outParamList.CurrentRowNumber>=localVars.inParamStartindex)&&(localVars.queryResGetInvoices2_outParamList.CurrentRowNumber<(localVars.inParamStartindex+localVars.inParamMaxRecords))), cancellationToken)));

// List = ListFilter2.FilteredList
result.outParamList=localVars.resListFilter2_outParamFilteredList;

// TotalCount = GetInvoices2.Count
result.outParamTotalCount=localVars.queryResGetInvoices2_outParamCount;
} else {
// Query datasetGetInvoices
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoices_maxRecords = 0;
int datasetGetInvoices_startIndex = 0;(localVars.queryResGetInvoices_outParamList,localVars.queryResGetInvoices_outParamCount) = await FuncActionServiceGetInvoices.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.inParamTableSort,localVars.inParamUserApplicationRoles.ssAppRolesListText,localVars.inParamUserApplicationRoles.ssCorporativoRegionId,localVars.inParamUserApplicationRoles.ssIsCorporativoCxP,localVars.inParamUserApplicationRoles.ssTelcelDirectionsListText,cancellationToken);

// Iterator = Startindex
localVars.varLcIterator=localVars.inParamStartindex;
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_c5ca0a80d78493d156f2b1a68d86a831)await  localVars.queryResGetInvoices_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetInvoices_outParamList.CurrentRowNumber>=localVars.inParamStartindex)&&(localVars.queryResGetInvoices_outParamList.CurrentRowNumber<(localVars.inParamStartindex+localVars.inParamMaxRecords))), cancellationToken)));

// List = ListFilter.FilteredList
result.outParamList=localVars.resListFilter_outParamFilteredList;

// TotalCount = GetInvoices.Count
result.outParamTotalCount=localVars.queryResGetInvoices_outParamCount;
}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamTotalCount = result.outParamTotalCount;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamTotalCount);
}

        public static class FuncActionServiceGetInvoices {
            
private static async Task<RC_acb134934352a9d72fd2cc0509d2f469> datasetGetInvoicesReadDbAsync(RC_acb134934352a9d72fd2cc0509d2f469 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssDontShowAction = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetInvoices" _hUBzHkyBEuxEumxJecwhg of Action "ServiceGetInvoices"
public static async Task<(RL_c5ca0a80d78493d156f2b1a68d86a831,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,long qpreGetUserRegionId,bool qpboIsSegmentationCorporativo,string qpteTableSort,string qpteAppRolesListText,long qpreCorporativoRegionId,bool qpboIsCorporativoCxP,string qpteTelcelDirectionsListText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetInvoices.GetInvoices", "cc0115fe-3279-4b04-b112-e9b125e73086");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetInvoices.GetInvoices", "cc0115fe-3279-4b04-b112-e9b125e73086", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /ServiceAPIMethods.F5ZAqUQ1Rk6mliPZW9ealQ/NodesNotShownInESpaceTree._hUBzHkyBEuxEumxJecwhg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole41\".\"id\" o0, \"enapplicationrole41\".\"code\" o1, \"enapplicationrole41\".\"name\" o2, \"enapplicationrole41\".\"isactive\" o3, \"enapplicationrole41\".\"isareausuaria\" o4, \"enapplicationrole41\".\"isareacxp\" o5, \"enapplicationrole41\".\"canbulkapprovefolios\" o6, \"enapprovalstatus5\".\"id\" o7, \"enapprovalstatus5\".\"label\" o8, \"enapprovalstatus5\".\"class\" o9, \"enapprovalstatus5\".\"order\" o10, \"enapprovalstatus5\".\"is_active\" o11, \"enapprovalstatus5\".\"iscya\" o12, \"enapprovalstatus5\".\"iscyaapproval\" o13, \"enapprovalstatus5\".\"isreq\" o14, \"enapprovalstatus5\".\"isinv\" o15, \"enapprovalstatus5\".\"labeles\" o16, \"encompany19\".\"id\" o17, \"encompany19\".\"externalid\" o18, \"encompany19\".\"description\" o19, \"encompany19\".\"rfc\" o20, \"encompany19\".\"postalcode\" o21, \"encompany19\".\"cyaimport\" o22, \"encompany19\".\"fspuse\" o23, \"encompany19\".\"createdon\" o24, \"encompany19\".\"createdby\" o25, \"encompany19\".\"updatedon\" o26, \"encompany19\".\"updatedby\" o27, \"eninvoice90\".\"id\" o28, \"eninvoice90\".\"name\" o29, \"eninvoice90\".\"requisitionid\" o30, \"eninvoice90\".\"folioid\" o31, \"eninvoice90\".\"ordermainid\" o32, \"eninvoice90\".\"cfditypeid\" o33, trim_scale(\"eninvoice90\".\"totalamount\"::numeric) o34, \"eninvoice90\".\"currency\" o35, \"eninvoice90\".\"invoicestatusid\" o36, \"eninvoice90\".\"accountingdatetime\" o37, \"eninvoice90\".\"paymentdatetime\" o38, \"eninvoice90\".\"createdon\" o39, \"eninvoice90\".\"createdby\" o40, \"eninvoice90\".\"updatedon\" o41, \"eninvoice90\".\"updatedby\" o42, \"eninvoice90\".\"submittedon\" o43, \"eninvoice90\".\"isnewversion\" o44, \"eninvoice90\".\"id_poliza\" o45, \"eninvoice90\".\"id_poliza_sap\" o46, \"eninvoice90\".\"doc51\" o47, \"eninvoice90\".\"accountingerror\" o48, \"eninvoice90\".\"orderaccconceptsid\" o49, trim_scale(\"eninvoice90\".\"amortization\"::numeric) o50, \"eninvoice90\".\"creditnoteinvoiceid\" o51, \"eninvoiceaccounting18\".\"id\" o52, \"eninvoiceaccounting18\".\"invoiceid\" o53, \"eninvoiceaccounting18\".\"suppliernumber\" o54, \"eninvoiceaccounting18\".\"servicetypeid\" o55, \"eninvoiceaccounting18\".\"freetext\" o56, \"eninvoiceaccounting18\".\"division\" o57, trim_scale(\"eninvoiceaccounting18\".\"ivaamount\"::numeric) o58, \"eninvoiceaccounting18\".\"iva_old\" o59, \"eninvoiceaccounting18\".\"ivaindicatorid\" o60, trim_scale(\"eninvoiceaccounting18\".\"totalamount\"::numeric) o61, \"eninvoiceaccounting18\".\"paymentmethodid\" o62, \"eninvoiceaccounting18\".\"paymenttermsid\" o63, \"eninvoiceaccounting18\".\"icmeindicator\" o64, \"eninvoiceaccounting18\".\"createdby\" o65, \"eninvoiceaccounting18\".\"createdon\" o66, \"eninvoiceaccounting18\".\"submissionby\" o67, \"eninvoiceaccounting18\".\"submissionon\" o68, \"eninvoiceaccounting18\".\"servicecalledby\" o69, \"eninvoiceaccounting18\".\"servicecalledon\" o70, \"eninvoiceaccounting18\".\"buydocnumber\" o71, \"eninvoiceaccounting18\".\"buydocposition\" o72, \"eninvoiceapproval27\".\"id\" o73, \"eninvoiceapproval27\".\"invoiceid\" o74, \"eninvoiceapproval27\".\"aprovalprocessid\" o75, \"eninvoiceapproval27\".\"processtypecode\" o76, \"eninvoiceapproval27\".\"approvalprocessversion\" o77, \"eninvoiceapproval27\".\"currentlevel\" o78, \"eninvoiceapproval27\".\"maxlevel\" o79, \"eninvoiceapproval27\".\"startedon\" o80, \"eninvoiceapproval27\".\"finishedon\" o81, \"eninvoiceapproval27\".\"hasstartedaccounting\" o82, \"eninvoiceapprovallevel28\".\"id\" o83, \"eninvoiceapprovallevel28\".\"invoiceapprovalid\" o84, \"eninvoiceapprovallevel28\".\"levelnumber\" o85, \"eninvoiceapprovallevel28\".\"assignedto\" o86, \"eninvoiceapprovallevel28\".\"applicationroleid\" o87, \"eninvoiceapprovallevel28\".\"entrajobtitle\" o88, \"eninvoiceapprovallevel28\".\"departmentid\" o89, \"eninvoiceapprovallevel28\".\"managementid\" o90, \"eninvoiceapprovallevel28\".\"subdirectionid\" o91, \"eninvoiceapprovallevel28\".\"entraroleid\" o92, \"eninvoiceapprovallevel28\".\"approvalstatusid\" o93, \"eninvoiceapprovallevel28\".\"canbefirstapprover\" o94, \"eninvoiceapprovallevel28\".\"selectsnextapprover\" o95, \"eninvoiceapprovallevel28\".\"selectsfirstapprover\" o96, \"eninvoiceapprovallevel28\".\"isaccounting\" o97, \"eninvoiceapprovallevel28\".\"isstartaccounting\" o98, \"eninvoiceapprovallevel28\".\"approvedby\" o99, \"eninvoiceapprovallevel28\".\"approvedon\" o100, \"eninvoiceapprovallevel28\".\"requesttomodifyby\" o101, \"eninvoiceapprovallevel28\".\"requesttomodifyon\" o102, \"eninvoiceapprovallevel28\".\"canceledby\" o103, \"eninvoiceapprovallevel28\".\"canceledon\" o104, \"eninvoiceapprovallevel28\".\"needscontract_deprec\" o105, \"eninvoiceapprovallevel28\".\"isreassigned\" o106, \"eninvoiceapprovallevel28\".\"issubstitutefor\" o107, \"eninvoicestatus4\".\"id\" o108, \"eninvoicestatus4\".\"label\" o109, \"eninvoicestatus4\".\"class\" o110, \"eninvoicestatus4\".\"order\" o111, \"eninvoicestatus4\".\"is_active\" o112, \"eninvoicestatus4\".\"isinaccounting\" o113, \"eninvoicestatus4\".\"labeles\" o114, \"enproject_asset_service5\".\"id\" o115, \"enproject_asset_service5\".\"description\" o116, \"enproject_asset_service5\".\"isothers\" o117, \"enproject_asset_service5\".\"createdon\" o118, \"enproject_asset_service5\".\"createdby\" o119, \"enproject_asset_service5\".\"updatedon\" o120, \"enproject_asset_service5\".\"updatedby\" o121, \"enregion72\".\"id\" o122, \"enregion72\".\"code\" o123, \"enregion72\".\"name\" o124, \"enregion72\".\"divisionfi\" o125, \"enregion72\".\"centrortp\" o126, \"enregion72\".\"commissionregion\" o127, \"enregion72\".\"isactive\" o128, \"enregion72\".\"createdon\" o129, \"enregion72\".\"createdby\" o130, \"enregion72\".\"updatedon\" o131, \"enregion72\".\"updatedby\" o132, \"enregion72\".\"isfsp\" o133, \"enregion72\".\"isfcp\" o134, \"enrequisition79\".\"id\" o135, \"enrequisition79\".\"name\" o136, \"enrequisition79\".\"counter\" o137, \"enrequisition79\".\"requisitionstatusid\" o138, \"enrequisition79\".\"supplierid\" o139, \"enrequisition79\".\"regionid\" o140, \"enrequisition79\".\"accountingregionid\" o141, \"enrequisition79\".\"applicantid\" o142, \"enrequisition79\".\"maxdatefinishcapture\" o143, \"enrequisition79\".\"projectassetserviceid\" o144, \"enrequisition79\".\"projectassetservice\" o145, \"enrequisition79\".\"projectdescription\" o146, \"enrequisition79\".\"frequencyid\" o147, \"enrequisition79\".\"issustainability\" o148, \"enrequisition79\".\"sustainabilityid\" o149, \"enrequisition79\".\"businessvaluecategoryid\" o150, \"enrequisition79\".\"businessvaluesubcategoryid\" o151, trim_scale(\"enrequisition79\".\"totalamount\"::numeric) o152, \"enrequisition79\".\"currencyid\" o153, \"enrequisition79\".\"distributionid\" o154, \"enrequisition79\".\"costcenterid\" o155, \"enrequisition79\".\"hascontract\" o156, \"enrequisition79\".\"iscontractpending\" o157, \"enrequisition79\".\"hasdeposit\" o158, \"enrequisition79\".\"hasinsurance\" o159, \"enrequisition79\".\"hasadvancepayment\" o160, \"enrequisition79\".\"accountingservicetypeid_depr\" o161, \"enrequisition79\".\"servicedescription_deprec\" o162, \"enrequisition79\".\"invoiceusageid_deprec\" o163, \"enrequisition79\".\"serviceformatid\" o164, \"enrequisition79\".\"companyid\" o165, trim_scale(\"enrequisition79\".\"retentionrate\"::numeric) o166, trim_scale(\"enrequisition79\".\"negotiatedexchangerate\"::numeric) o167, \"enrequisition79\".\"paymentmethodid\" o168, \"enrequisition79\".\"paymenttermsid\" o169, \"enrequisition79\".\"isautomaticaccounting\" o170, \"enrequisition79\".\"createdby\" o171, \"enrequisition79\".\"createdon\" o172, \"enrequisition79\".\"updatedon\" o173, \"enrequisition79\".\"updatedby\" o174, \"enrequisition79\".\"createdbyapplicationrole\" o175, \"enrequisition79\".\"dateofcommitment\" o176, \"enrequisition79\".\"hascontractfileuploaded\" o177, \"enrequisition79\".\"hasupdateddateofcommitment\" o178, \"enrequisition79\".\"submittedon\" o179, \"enrequisition79\".\"isdonation\" o180, \"enrequisition79\".\"advwithoutinvoice\" o181, \"enrequisition79\".\"wasadvwithoutinvoice\" o182, \"enrequisition79\".\"isadvanced\" o183, \"enrequisition79\".\"documenttypeid\" o184, \"enrequisition79\".\"iscreatedbyanassistente\" o185, \"enrequisition79\".\"telceldirectionid\" o186, \"enrequisition79\".\"hasmultiupload\" o187, \"enrequisition79\".\"accountingdate\" o188, \"enrequisition79\".\"paymentoptionsid\" o189, \"enrequisition79\".\"paymentwaysid\" o190, \"enrequisition79\".\"buydocnumber\" o191, \"enrequisition79\".\"buydocposition\" o192, \"ensupplier55\".\"id\" o193, \"ensupplier55\".\"tratamiento\" o194, \"ensupplier55\".\"name\" o195, \"ensupplier55\".\"number\" o196, \"ensupplier55\".\"conceptobusq_1_2\" o197, \"ensupplier55\".\"calle_numero\" o198, \"ensupplier55\".\"distrito\" o199, \"ensupplier55\".\"codigopostal_pobl_\" o200, \"ensupplier55\".\"pais\" o201, \"ensupplier55\".\"region_\" o202, \"ensupplier55\".\"idioma\" o203, \"ensupplier55\".\"telefono\" o204, \"ensupplier55\".\"extension\" o205, \"ensupplier55\".\"fax\" o206, \"ensupplier55\".\"cliente\" o207, \"ensupplier55\".\"soc_glasociada\" o208, \"ensupplier55\".\"clavedegrupo\" o209, \"ensupplier55\".\"n_ident_fis_1\" o210, \"ensupplier55\".\"personafisica\" o211, \"ensupplier55\".\"ramo\" o212, \"ensupplier55\".\"grupodeporte\" o213, \"ensupplier55\".\"email\" o214, \"ensupplier55\".\"isactive\" o215, \"ensupplier55\".\"createdon\" o216, \"ensupplier55\".\"createdby\" o217, \"ensupplier55\".\"updatedon\" o218, \"ensupplier55\".\"updatedby\" o219, \"ensupplier55\".\"regionid\" o220, \"enuser146\".\"id\" o221, \"enuser146\".\"name\" o222, \"enuser146\".\"email\" o223, \"enuser146\".\"photourl\" o224, \"enuser146\".\"username\" o225, (CASE WHEN (\"eninvoiceapprovallevel28\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition79\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition79\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition79\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" OR (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition79\".\"accountingregionid\" = @qpreGetUserRegionId) AND (\"enrequisition79\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition79\".\"accountingregionid\" IS NULL)");
}
selectBuilder.Append(" AND (\"enrequisition79\".\"accountingregionid\" IS NOT NULL))) THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((((((({Invoice} \"eninvoice90\" Left JOIN {InvoiceApproval} \"eninvoiceapproval27\" ON (\"eninvoice90\".\"id\" = \"eninvoiceapproval27\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel28\" ON ((\"eninvoiceapprovallevel28\".\"invoiceapprovalid\" = \"eninvoiceapproval27\".\"id\") AND ((\"eninvoiceapprovallevel28\".\"approvalstatusid\" <> ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel28\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel28\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel28\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel28\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((CASE WHEN char_length(caseaccent_normalize(cast(\"eninvoiceapprovallevel28\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"eninvoiceapprovallevel28\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRolesListText collate \"default\"))-1) END)) <> (-1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel28\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel28\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel28\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel28\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel28\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel28\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel28\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel28\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel28\".\"canceledby\" IS NULL)");
}
fromBuilder.Append("))))  Inner JOIN {Requisition} \"enrequisition79\" ON (\"eninvoice90\".\"requisitionid\" = \"enrequisition79\".\"id\"))  Left JOIN {Supplier} \"ensupplier55\" ON (\"enrequisition79\".\"supplierid\" = \"ensupplier55\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus4\" ON (\"eninvoice90\".\"invoicestatusid\" = \"eninvoicestatus4\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole41\" ON (\"eninvoiceapprovallevel28\".\"applicationroleid\" = \"enapplicationrole41\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus5\" ON (\"eninvoiceapprovallevel28\".\"approvalstatusid\" = \"enapprovalstatus5\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting18\" ON (\"eninvoice90\".\"id\" = \"eninvoiceaccounting18\".\"invoiceid\"))  Left JOIN {Region} \"enregion72\" ON (\"enrequisition79\".\"regionid\" = \"enregion72\".\"id\"))  Left JOIN {Company} \"encompany19\" ON (\"enrequisition79\".\"companyid\" = \"encompany19\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service5\" ON (\"enrequisition79\".\"projectassetserviceid\" = \"enproject_asset_service5\".\"id\"))  Left JOIN {User} \"enuser146\" ON (\"eninvoiceapprovallevel28\".\"assignedto\" = \"enuser146\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoice90\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") AND ((CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpboIsSegmentationCorporativo = 1) THEN (CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpteTelcelDirectionsListText = '') THEN 1 ELSE (CASE WHEN ((((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition79\".\"regionid\" = @qpreCorporativoRegionId) AND (\"enrequisition79\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition79\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition79\".\"accountingregionid\" = @qpreCorporativoRegionId) AND (\"enrequisition79\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition79\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition79\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition79\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition79\".\"regionid\" <> @qpreCorporativoRegionId) OR (\"enrequisition79\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition79\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel28\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel28\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel28\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) ELSE 1 END) ELSE 1 END) ELSE (CASE WHEN ((");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enrequisition79\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition79\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enrequisition79\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel28\".\"id\" IS NOT NULL)) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel28\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel28\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel28\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"eninvoicestatus4\".\"isinaccounting\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "InvoiceStatus", "Supplier", "Invoice", "Project_Asset_Service", "InvoiceApproval", "Company", "InvoiceAccounting", "Requisition", "ApprovalStatus", "ApplicationRole", "Region", "InvoiceApprovalLevel", "User" }, new string[] { "ENInvoiceStatus4", "ENSupplier55", "ENInvoice90", "ENProject_Asset_Service5", "ENInvoiceApproval27", "ENCompany19", "ENInvoiceAccounting18", "ENRequisition79", "ENApprovalStatus5", "ENApplicationRole41", "ENRegion72", "ENInvoiceApprovalLevel28", "ENUser146" }, new System.Collections.Generic.Dictionary<string, string>[] { ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENProject_Asset_ServiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceApprovalEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENInvoiceApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enregion72\".\"code\" ASC ");
orderByColumns.Add("\"enapprovalstatus5\".\"order\" ASC ");
orderByColumns.Add("\"eninvoice90\".\"createdon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[13];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[9] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[10] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[11] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[12] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetInvoices.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetInvoices.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5ca0a80d78493d156f2b1a68d86a831 _tmp = new RL_c5ca0a80d78493d156f2b1a68d86a831();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetInvoices.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5ca0a80d78493d156f2b1a68d86a831)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetInvoices.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_acb134934352a9d72fd2cc0509d2f469> datasetGetInvoices2ReadDbAsync(RC_acb134934352a9d72fd2cc0509d2f469 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssDontShowAction = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetInvoices2" ZnVI67MrJUK__j0_LdhSPw of Action "ServiceGetInvoices"
public static async Task<(RL_c5ca0a80d78493d156f2b1a68d86a831,long)> datasetGetInvoices2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,long qpreGetUserRegionId,bool qpboIsSegmentationCorporativo,string qpteTableSort,string qpteAppRolesListText,long qpreCorporativoRegionId,bool qpboIsCorporativoCxP,string qpteTelcelDirectionsListText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetInvoices.GetInvoices2", "eb487566-2bb3-4225-bffe-3d3f2dd8523f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetInvoices.GetInvoices2", "eb487566-2bb3-4225-bffe-3d3f2dd8523f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /ServiceAPIMethods.F5ZAqUQ1Rk6mliPZW9ealQ/NodesNotShownInESpaceTree.ZnVI67MrJUK__j0_LdhSPw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole42\".\"id\" o0, \"enapplicationrole42\".\"code\" o1, \"enapplicationrole42\".\"name\" o2, \"enapplicationrole42\".\"isactive\" o3, \"enapplicationrole42\".\"isareausuaria\" o4, \"enapplicationrole42\".\"isareacxp\" o5, \"enapplicationrole42\".\"canbulkapprovefolios\" o6, \"enapprovalstatus6\".\"id\" o7, \"enapprovalstatus6\".\"label\" o8, \"enapprovalstatus6\".\"class\" o9, \"enapprovalstatus6\".\"order\" o10, \"enapprovalstatus6\".\"is_active\" o11, \"enapprovalstatus6\".\"iscya\" o12, \"enapprovalstatus6\".\"iscyaapproval\" o13, \"enapprovalstatus6\".\"isreq\" o14, \"enapprovalstatus6\".\"isinv\" o15, \"enapprovalstatus6\".\"labeles\" o16, \"encompany20\".\"id\" o17, \"encompany20\".\"externalid\" o18, \"encompany20\".\"description\" o19, \"encompany20\".\"rfc\" o20, \"encompany20\".\"postalcode\" o21, \"encompany20\".\"cyaimport\" o22, \"encompany20\".\"fspuse\" o23, \"encompany20\".\"createdon\" o24, \"encompany20\".\"createdby\" o25, \"encompany20\".\"updatedon\" o26, \"encompany20\".\"updatedby\" o27, \"eninvoice91\".\"id\" o28, \"eninvoice91\".\"name\" o29, \"eninvoice91\".\"requisitionid\" o30, \"eninvoice91\".\"folioid\" o31, \"eninvoice91\".\"ordermainid\" o32, \"eninvoice91\".\"cfditypeid\" o33, trim_scale(\"eninvoice91\".\"totalamount\"::numeric) o34, \"eninvoice91\".\"currency\" o35, \"eninvoice91\".\"invoicestatusid\" o36, \"eninvoice91\".\"accountingdatetime\" o37, \"eninvoice91\".\"paymentdatetime\" o38, \"eninvoice91\".\"createdon\" o39, \"eninvoice91\".\"createdby\" o40, \"eninvoice91\".\"updatedon\" o41, \"eninvoice91\".\"updatedby\" o42, \"eninvoice91\".\"submittedon\" o43, \"eninvoice91\".\"isnewversion\" o44, \"eninvoice91\".\"id_poliza\" o45, \"eninvoice91\".\"id_poliza_sap\" o46, \"eninvoice91\".\"doc51\" o47, \"eninvoice91\".\"accountingerror\" o48, \"eninvoice91\".\"orderaccconceptsid\" o49, trim_scale(\"eninvoice91\".\"amortization\"::numeric) o50, \"eninvoice91\".\"creditnoteinvoiceid\" o51, \"eninvoiceaccounting19\".\"id\" o52, \"eninvoiceaccounting19\".\"invoiceid\" o53, \"eninvoiceaccounting19\".\"suppliernumber\" o54, \"eninvoiceaccounting19\".\"servicetypeid\" o55, \"eninvoiceaccounting19\".\"freetext\" o56, \"eninvoiceaccounting19\".\"division\" o57, trim_scale(\"eninvoiceaccounting19\".\"ivaamount\"::numeric) o58, \"eninvoiceaccounting19\".\"iva_old\" o59, \"eninvoiceaccounting19\".\"ivaindicatorid\" o60, trim_scale(\"eninvoiceaccounting19\".\"totalamount\"::numeric) o61, \"eninvoiceaccounting19\".\"paymentmethodid\" o62, \"eninvoiceaccounting19\".\"paymenttermsid\" o63, \"eninvoiceaccounting19\".\"icmeindicator\" o64, \"eninvoiceaccounting19\".\"createdby\" o65, \"eninvoiceaccounting19\".\"createdon\" o66, \"eninvoiceaccounting19\".\"submissionby\" o67, \"eninvoiceaccounting19\".\"submissionon\" o68, \"eninvoiceaccounting19\".\"servicecalledby\" o69, \"eninvoiceaccounting19\".\"servicecalledon\" o70, \"eninvoiceaccounting19\".\"buydocnumber\" o71, \"eninvoiceaccounting19\".\"buydocposition\" o72, \"eninvoiceapproval28\".\"id\" o73, \"eninvoiceapproval28\".\"invoiceid\" o74, \"eninvoiceapproval28\".\"aprovalprocessid\" o75, \"eninvoiceapproval28\".\"processtypecode\" o76, \"eninvoiceapproval28\".\"approvalprocessversion\" o77, \"eninvoiceapproval28\".\"currentlevel\" o78, \"eninvoiceapproval28\".\"maxlevel\" o79, \"eninvoiceapproval28\".\"startedon\" o80, \"eninvoiceapproval28\".\"finishedon\" o81, \"eninvoiceapproval28\".\"hasstartedaccounting\" o82, \"eninvoiceapprovallevel29\".\"id\" o83, \"eninvoiceapprovallevel29\".\"invoiceapprovalid\" o84, \"eninvoiceapprovallevel29\".\"levelnumber\" o85, \"eninvoiceapprovallevel29\".\"assignedto\" o86, \"eninvoiceapprovallevel29\".\"applicationroleid\" o87, \"eninvoiceapprovallevel29\".\"entrajobtitle\" o88, \"eninvoiceapprovallevel29\".\"departmentid\" o89, \"eninvoiceapprovallevel29\".\"managementid\" o90, \"eninvoiceapprovallevel29\".\"subdirectionid\" o91, \"eninvoiceapprovallevel29\".\"entraroleid\" o92, \"eninvoiceapprovallevel29\".\"approvalstatusid\" o93, \"eninvoiceapprovallevel29\".\"canbefirstapprover\" o94, \"eninvoiceapprovallevel29\".\"selectsnextapprover\" o95, \"eninvoiceapprovallevel29\".\"selectsfirstapprover\" o96, \"eninvoiceapprovallevel29\".\"isaccounting\" o97, \"eninvoiceapprovallevel29\".\"isstartaccounting\" o98, \"eninvoiceapprovallevel29\".\"approvedby\" o99, \"eninvoiceapprovallevel29\".\"approvedon\" o100, \"eninvoiceapprovallevel29\".\"requesttomodifyby\" o101, \"eninvoiceapprovallevel29\".\"requesttomodifyon\" o102, \"eninvoiceapprovallevel29\".\"canceledby\" o103, \"eninvoiceapprovallevel29\".\"canceledon\" o104, \"eninvoiceapprovallevel29\".\"needscontract_deprec\" o105, \"eninvoiceapprovallevel29\".\"isreassigned\" o106, \"eninvoiceapprovallevel29\".\"issubstitutefor\" o107, \"eninvoicestatus5\".\"id\" o108, \"eninvoicestatus5\".\"label\" o109, \"eninvoicestatus5\".\"class\" o110, \"eninvoicestatus5\".\"order\" o111, \"eninvoicestatus5\".\"is_active\" o112, \"eninvoicestatus5\".\"isinaccounting\" o113, \"eninvoicestatus5\".\"labeles\" o114, \"enproject_asset_service6\".\"id\" o115, \"enproject_asset_service6\".\"description\" o116, \"enproject_asset_service6\".\"isothers\" o117, \"enproject_asset_service6\".\"createdon\" o118, \"enproject_asset_service6\".\"createdby\" o119, \"enproject_asset_service6\".\"updatedon\" o120, \"enproject_asset_service6\".\"updatedby\" o121, \"enregion73\".\"id\" o122, \"enregion73\".\"code\" o123, \"enregion73\".\"name\" o124, \"enregion73\".\"divisionfi\" o125, \"enregion73\".\"centrortp\" o126, \"enregion73\".\"commissionregion\" o127, \"enregion73\".\"isactive\" o128, \"enregion73\".\"createdon\" o129, \"enregion73\".\"createdby\" o130, \"enregion73\".\"updatedon\" o131, \"enregion73\".\"updatedby\" o132, \"enregion73\".\"isfsp\" o133, \"enregion73\".\"isfcp\" o134, \"enrequisition80\".\"id\" o135, \"enrequisition80\".\"name\" o136, \"enrequisition80\".\"counter\" o137, \"enrequisition80\".\"requisitionstatusid\" o138, \"enrequisition80\".\"supplierid\" o139, \"enrequisition80\".\"regionid\" o140, \"enrequisition80\".\"accountingregionid\" o141, \"enrequisition80\".\"applicantid\" o142, \"enrequisition80\".\"maxdatefinishcapture\" o143, \"enrequisition80\".\"projectassetserviceid\" o144, \"enrequisition80\".\"projectassetservice\" o145, \"enrequisition80\".\"projectdescription\" o146, \"enrequisition80\".\"frequencyid\" o147, \"enrequisition80\".\"issustainability\" o148, \"enrequisition80\".\"sustainabilityid\" o149, \"enrequisition80\".\"businessvaluecategoryid\" o150, \"enrequisition80\".\"businessvaluesubcategoryid\" o151, trim_scale(\"enrequisition80\".\"totalamount\"::numeric) o152, \"enrequisition80\".\"currencyid\" o153, \"enrequisition80\".\"distributionid\" o154, \"enrequisition80\".\"costcenterid\" o155, \"enrequisition80\".\"hascontract\" o156, \"enrequisition80\".\"iscontractpending\" o157, \"enrequisition80\".\"hasdeposit\" o158, \"enrequisition80\".\"hasinsurance\" o159, \"enrequisition80\".\"hasadvancepayment\" o160, \"enrequisition80\".\"accountingservicetypeid_depr\" o161, \"enrequisition80\".\"servicedescription_deprec\" o162, \"enrequisition80\".\"invoiceusageid_deprec\" o163, \"enrequisition80\".\"serviceformatid\" o164, \"enrequisition80\".\"companyid\" o165, trim_scale(\"enrequisition80\".\"retentionrate\"::numeric) o166, trim_scale(\"enrequisition80\".\"negotiatedexchangerate\"::numeric) o167, \"enrequisition80\".\"paymentmethodid\" o168, \"enrequisition80\".\"paymenttermsid\" o169, \"enrequisition80\".\"isautomaticaccounting\" o170, \"enrequisition80\".\"createdby\" o171, \"enrequisition80\".\"createdon\" o172, \"enrequisition80\".\"updatedon\" o173, \"enrequisition80\".\"updatedby\" o174, \"enrequisition80\".\"createdbyapplicationrole\" o175, \"enrequisition80\".\"dateofcommitment\" o176, \"enrequisition80\".\"hascontractfileuploaded\" o177, \"enrequisition80\".\"hasupdateddateofcommitment\" o178, \"enrequisition80\".\"submittedon\" o179, \"enrequisition80\".\"isdonation\" o180, \"enrequisition80\".\"advwithoutinvoice\" o181, \"enrequisition80\".\"wasadvwithoutinvoice\" o182, \"enrequisition80\".\"isadvanced\" o183, \"enrequisition80\".\"documenttypeid\" o184, \"enrequisition80\".\"iscreatedbyanassistente\" o185, \"enrequisition80\".\"telceldirectionid\" o186, \"enrequisition80\".\"hasmultiupload\" o187, \"enrequisition80\".\"accountingdate\" o188, \"enrequisition80\".\"paymentoptionsid\" o189, \"enrequisition80\".\"paymentwaysid\" o190, \"enrequisition80\".\"buydocnumber\" o191, \"enrequisition80\".\"buydocposition\" o192, \"ensupplier56\".\"id\" o193, \"ensupplier56\".\"tratamiento\" o194, \"ensupplier56\".\"name\" o195, \"ensupplier56\".\"number\" o196, \"ensupplier56\".\"conceptobusq_1_2\" o197, \"ensupplier56\".\"calle_numero\" o198, \"ensupplier56\".\"distrito\" o199, \"ensupplier56\".\"codigopostal_pobl_\" o200, \"ensupplier56\".\"pais\" o201, \"ensupplier56\".\"region_\" o202, \"ensupplier56\".\"idioma\" o203, \"ensupplier56\".\"telefono\" o204, \"ensupplier56\".\"extension\" o205, \"ensupplier56\".\"fax\" o206, \"ensupplier56\".\"cliente\" o207, \"ensupplier56\".\"soc_glasociada\" o208, \"ensupplier56\".\"clavedegrupo\" o209, \"ensupplier56\".\"n_ident_fis_1\" o210, \"ensupplier56\".\"personafisica\" o211, \"ensupplier56\".\"ramo\" o212, \"ensupplier56\".\"grupodeporte\" o213, \"ensupplier56\".\"email\" o214, \"ensupplier56\".\"isactive\" o215, \"ensupplier56\".\"createdon\" o216, \"ensupplier56\".\"createdby\" o217, \"ensupplier56\".\"updatedon\" o218, \"ensupplier56\".\"updatedby\" o219, \"ensupplier56\".\"regionid\" o220, \"enuser147\".\"id\" o221, \"enuser147\".\"name\" o222, \"enuser147\".\"email\" o223, \"enuser147\".\"photourl\" o224, \"enuser147\".\"username\" o225, (CASE WHEN (\"eninvoiceapprovallevel29\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition80\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition80\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition80\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" OR (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition80\".\"accountingregionid\" = @qpreGetUserRegionId) AND (\"enrequisition80\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition80\".\"accountingregionid\" IS NULL)");
}
selectBuilder.Append(" AND (\"enrequisition80\".\"accountingregionid\" IS NOT NULL))) THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((((((({Invoice} \"eninvoice91\" Left JOIN {InvoiceApproval} \"eninvoiceapproval28\" ON (\"eninvoice91\".\"id\" = \"eninvoiceapproval28\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel29\" ON ((\"eninvoiceapprovallevel29\".\"invoiceapprovalid\" = \"eninvoiceapproval28\".\"id\") AND ((\"eninvoiceapprovallevel29\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel29\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel29\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel29\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel29\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((CASE WHEN char_length(caseaccent_normalize(cast(\"eninvoiceapprovallevel29\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"eninvoiceapprovallevel29\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRolesListText collate \"default\"))-1) END)) <> (-1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel29\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel29\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel29\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel29\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel29\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel29\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel29\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel29\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel29\".\"canceledby\" IS NULL)");
}
fromBuilder.Append("))))  Inner JOIN {Requisition} \"enrequisition80\" ON (\"eninvoice91\".\"requisitionid\" = \"enrequisition80\".\"id\"))  Left JOIN {Supplier} \"ensupplier56\" ON (\"enrequisition80\".\"supplierid\" = \"ensupplier56\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus5\" ON (\"eninvoice91\".\"invoicestatusid\" = \"eninvoicestatus5\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole42\" ON (\"eninvoiceapprovallevel29\".\"applicationroleid\" = \"enapplicationrole42\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus6\" ON (\"eninvoiceapprovallevel29\".\"approvalstatusid\" = \"enapprovalstatus6\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting19\" ON (\"eninvoice91\".\"id\" = \"eninvoiceaccounting19\".\"invoiceid\"))  Left JOIN {Region} \"enregion73\" ON (\"enrequisition80\".\"regionid\" = \"enregion73\".\"id\"))  Left JOIN {Company} \"encompany20\" ON (\"enrequisition80\".\"companyid\" = \"encompany20\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service6\" ON (\"enrequisition80\".\"projectassetserviceid\" = \"enproject_asset_service6\".\"id\"))  Left JOIN {User} \"enuser147\" ON (\"eninvoiceapprovallevel29\".\"assignedto\" = \"enuser147\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoice91\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") AND ((CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpboIsSegmentationCorporativo = 1) THEN (CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpteTelcelDirectionsListText = '') THEN 1 ELSE (CASE WHEN ((((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition80\".\"regionid\" = @qpreCorporativoRegionId) AND (\"enrequisition80\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition80\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition80\".\"accountingregionid\" = @qpreCorporativoRegionId) AND (\"enrequisition80\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition80\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition80\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition80\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition80\".\"regionid\" <> @qpreCorporativoRegionId) OR (\"enrequisition80\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition80\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel29\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel29\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel29\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) ELSE 1 END) ELSE 1 END) ELSE (CASE WHEN ((");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enrequisition80\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition80\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enrequisition80\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel29\".\"id\" IS NOT NULL)) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel29\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel29\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel29\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"eninvoicestatus5\".\"isinaccounting\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "User", "InvoiceStatus", "Project_Asset_Service", "InvoiceApproval", "Invoice", "ApprovalStatus", "Requisition", "Company", "ApplicationRole", "Supplier", "Region", "InvoiceApprovalLevel", "InvoiceAccounting" }, new string[] { "ENUser147", "ENInvoiceStatus5", "ENProject_Asset_Service6", "ENInvoiceApproval28", "ENInvoice91", "ENApprovalStatus6", "ENRequisition80", "ENCompany20", "ENApplicationRole42", "ENSupplier56", "ENRegion73", "ENInvoiceApprovalLevel29", "ENInvoiceAccounting19" }, new System.Collections.Generic.Dictionary<string, string>[] { ENUserEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENProject_Asset_ServiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceApprovalEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENInvoiceApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enregion73\".\"code\" ASC ");
orderByColumns.Add("\"enapprovalstatus6\".\"order\" ASC ");
orderByColumns.Add("\"eninvoice91\".\"createdon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoices2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[13];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[9] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[10] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[11] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[12] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetInvoices.GetInvoices2.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetInvoices.GetInvoices2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5ca0a80d78493d156f2b1a68d86a831 _tmp = new RL_c5ca0a80d78493d156f2b1a68d86a831();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoices2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetInvoices.GetInvoices2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5ca0a80d78493d156f2b1a68d86a831)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetInvoices.GetInvoices2.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
}
