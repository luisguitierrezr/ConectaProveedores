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

    public class S4PIServiceGetFoliosSAEForApprovalMobileInput {
[JsonProperty("CurrentLocale")]
public string inParamCurrentLocale;
[JsonProperty("MaxRecords")]
public int? inParamMaxRecords;
[JsonProperty("Startindex")]
public int? inParamStartindex;
[JsonProperty("TableSort")]
public string inParamTableSort;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceGetFoliosSAEForApprovalMobileInput(string inParamCurrentLocale, int? inParamMaxRecords, int? inParamStartindex, string inParamTableSort, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamStartindex = inParamStartindex;
this.inParamTableSort = inParamTableSort;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetFoliosSAEForApprovalMobileOutput {
[JsonProperty("List")]
public JSONRC_53767e07cc452cace0866f9d42b38a15[] outParamList;
[JsonProperty("TotalCount")]
public long outParamTotalCount;
[JsonProperty("UserRolesList")]
public JSONST_e39617f0f094a322d4157f34fe424dadStructure[] outParamUserRolesList;
[JsonProperty("AppRoleListText")]
public string outParamAppRoleListText;
[JsonProperty("EntraRolesListText")]
public string outParamEntraRolesListText;
[JsonProperty("CanBulkApprove")]
public bool outParamCanBulkApprove;
public S4PIServiceGetFoliosSAEForApprovalMobileOutput(JSONRC_53767e07cc452cace0866f9d42b38a15[] outParamList, long outParamTotalCount, JSONST_e39617f0f094a322d4157f34fe424dadStructure[] outParamUserRolesList, string outParamAppRoleListText, string outParamEntraRolesListText, bool outParamCanBulkApprove) {
this.outParamList = outParamList;
this.outParamTotalCount = outParamTotalCount;
this.outParamUserRolesList = outParamUserRolesList;
this.outParamAppRoleListText = outParamAppRoleListText;
this.outParamEntraRolesListText = outParamEntraRolesListText;
this.outParamCanBulkApprove = outParamCanBulkApprove;
}

}

[HttpPost()]
[Route("serviceapi/servicegetfoliossaeforapprovalmobile")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetFoliosSAEForApprovalMobile", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetFoliosSAEForApprovalMobile(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetFoliosSAEForApprovalMobileInput, S4PIServiceGetFoliosSAEForApprovalMobileOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
RL_6699a4982997a1a4b4e85a3cc869bae4 outParamList;
long outParamTotalCount;
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
string outParamAppRoleListText;
string outParamEntraRolesListText;
bool outParamCanBulkApprove;
S4PIServiceGetFoliosSAEForApprovalMobileInput inputs = serviceActionInput.InputParameters;
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
(outParamList,outParamTotalCount,outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText,outParamCanBulkApprove) = await Flows.ActionServiceGetFoliosSAEForApprovalMobile(context,inputs.inParamCurrentLocale,inputs.inParamMaxRecords.Value,inputs.inParamStartindex.Value,inputs.inParamTableSort,inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetFoliosSAEForApprovalMobileOutput(RL_6699a4982997a1a4b4e85a3cc869bae4.ToArray(outParamList, (str) => JSONRC_53767e07cc452cace0866f9d42b38a15.FromStructure(str, behaviorsConfiguration)), outParamTotalCount, RL_97ac86b141c7934fd96d3cf71793066e.ToArray(outParamUserRolesList, (str) => JSONST_e39617f0f094a322d4157f34fe424dadStructure.FromStructure(str, behaviorsConfiguration)), outParamAppRoleListText, outParamEntraRolesListText, outParamCanBulkApprove);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetFoliosSAEForApprovalMobile : VarsBag {
public string inParamCurrentLocale;
public int inParamMaxRecords;
public int inParamStartindex;
public string inParamTableSort;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>Iterator</code> that represents the Service Studio Integer <code>Iterator</code>
///  <p>Description: </p>
/// </summary>
public int varLcIterator = 0;

public RL_6699a4982997a1a4b4e85a3cc869bae4 queryResGetFoliosSAE_outParamList = new RL_6699a4982997a1a4b4e85a3cc869bae4();
public long queryResGetFoliosSAE_outParamCount = 0L;

public RL_6699a4982997a1a4b4e85a3cc869bae4 resListFilter2_outParamFilteredList = new RL_6699a4982997a1a4b4e85a3cc869bae4();

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public Actions.lcoGetUserEntraRoleName resGetUserEntraRoleName =  new Actions.lcoGetUserEntraRoleName();
public RL_6699a4982997a1a4b4e85a3cc869bae4 resListFilter_outParamFilteredList = new RL_6699a4982997a1a4b4e85a3cc869bae4();

public RL_6699a4982997a1a4b4e85a3cc869bae4 queryResGetFoliosSAE2_outParamList = new RL_6699a4982997a1a4b4e85a3cc869bae4();
public long queryResGetFoliosSAE2_outParamCount = 0L;

public lcvServiceGetFoliosSAEForApprovalMobile(string inParamCurrentLocale, int inParamMaxRecords, int inParamStartindex, string inParamTableSort, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamStartindex = inParamStartindex;
this.inParamTableSort = inParamTableSort;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetFoliosSAEForApprovalMobile : VarsBag {
public RL_6699a4982997a1a4b4e85a3cc869bae4 outParamList = new RL_6699a4982997a1a4b4e85a3cc869bae4();

public long outParamTotalCount = 0L;

public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamAppRoleListText = "";

public string outParamEntraRolesListText = "";

public bool outParamCanBulkApprove = false;

public lcoServiceGetFoliosSAEForApprovalMobile() {
}
}
/// <summary>
/// Action <code>ServiceGetFoliosSAEForApprovalMobile</code> that represents the Service Studio action
///  <code>ServiceGetFoliosSAEForApprovalMobile</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_6699a4982997a1a4b4e85a3cc869bae4,long,RL_97ac86b141c7934fd96d3cf71793066e,string,string,bool)> ActionServiceGetFoliosSAEForApprovalMobile(IRequestContext requestContext,string inParamCurrentLocale,int inParamMaxRecords,int inParamStartindex,string inParamTableSort,string inParami_GetUserId,CancellationToken cancellationToken) {
RL_6699a4982997a1a4b4e85a3cc869bae4 outParamList = default;
long outParamTotalCount = default;
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRoleListText = default;
string outParamEntraRolesListText = default;
bool outParamCanBulkApprove = default;
lcoServiceGetFoliosSAEForApprovalMobile result = new lcoServiceGetFoliosSAEForApprovalMobile();
lcvServiceGetFoliosSAEForApprovalMobile localVars = new lcvServiceGetFoliosSAEForApprovalMobile(inParamCurrentLocale, inParamMaxRecords, inParamStartindex, inParamTableSort, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetFoliosSAEForApprovalMobile", "afc1d6ad-b54c-4a18-acd7-ad85611075f2"))
using (activitySource.CreateServiceActionActivity("ServiceGetFoliosSAEForApprovalMobile")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,(((localVars.inParamCurrentLocale=="")) ? ("es-MX") : (localVars.inParamCurrentLocale)),cancellationToken);

// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionServiceGetFoliosSAEForApprovalMobile.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,localVars.inParami_GetUserId,cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// Foreach GetRoleConcept.List
localVars.queryResGetRoleConcept_outParamList.StartIteration();
try {while (!((localVars.queryResGetRoleConcept_outParamList.Eof))) {
// AppRoleListText = AppRoleListText + "," + GetRoleConcept.List.Current.RoleConcept.ApplicationRoleId
result.outParamAppRoleListText=((result.outParamAppRoleListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId));

// EntraRolesListText = EntraRolesListText + "," + GetRoleConcept.List.Current.User_Extended_Internal.EntraRoleId
result.outParamEntraRolesListText=((result.outParamEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId));
localVars.queryResGetRoleConcept_outParamList.Advance();
}

} finally {
localVars.queryResGetRoleConcept_outParamList.EndIteration();
}

// GetUserEntraRoleName
localVars.resGetUserEntraRoleName.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken);

// CanBulkApprove = Index = -1 and Index = -1
result.outParamCanBulkApprove=((BuiltInFunction.IndexSC (localVars.resGetUserEntraRoleName.outParamo_EntraRoleName, "analista", 0, false, true)==(-1))&&(BuiltInFunction.IndexSC (localVars.resGetUserEntraRoleName.outParamo_EntraRoleName, "jefe", 0, false, true)==(-1)));
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_OnlyNotApprovedMobile]))))) {
// Query datasetGetFoliosSAE2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosSAE2_maxRecords = 0;
int datasetGetFoliosSAE2_startIndex = 0;(localVars.queryResGetFoliosSAE2_outParamList,localVars.queryResGetFoliosSAE2_outParamCount) = await FuncActionServiceGetFoliosSAEForApprovalMobile.datasetGetFoliosSAE2(requestContext,datasetGetFoliosSAE2_maxRecords,datasetGetFoliosSAE2_startIndex,IterationMultiplicity.Multiple,result.outParamAppRoleListText,result.outParamEntraRolesListText,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),(await Functions.ActionGetUserDepartmentId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.inParami_GetUserId,localVars.inParamTableSort,cancellationToken);

// Iterator = Startindex
localVars.varLcIterator=localVars.inParamStartindex;
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_6699a4982997a1a4b4e85a3cc869bae4)await  localVars.queryResGetFoliosSAE2_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetFoliosSAE2_outParamList.CurrentRowNumber>=localVars.inParamStartindex)&&(localVars.queryResGetFoliosSAE2_outParamList.CurrentRowNumber<(localVars.inParamStartindex+localVars.inParamMaxRecords))), cancellationToken)));

// List = ListFilter2.FilteredList
result.outParamList=localVars.resListFilter2_outParamFilteredList;

// TotalCount = GetFoliosSAE2.Count
result.outParamTotalCount=localVars.queryResGetFoliosSAE2_outParamCount;
} else {
// Query datasetGetFoliosSAE
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosSAE_maxRecords = 0;
int datasetGetFoliosSAE_startIndex = 0;(localVars.queryResGetFoliosSAE_outParamList,localVars.queryResGetFoliosSAE_outParamCount) = await FuncActionServiceGetFoliosSAEForApprovalMobile.datasetGetFoliosSAE(requestContext,datasetGetFoliosSAE_maxRecords,datasetGetFoliosSAE_startIndex,IterationMultiplicity.Multiple,result.outParamAppRoleListText,result.outParamEntraRolesListText,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),(await Functions.ActionGetUserDepartmentId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.inParami_GetUserId,localVars.inParamTableSort,cancellationToken);

// Iterator = Startindex
localVars.varLcIterator=localVars.inParamStartindex;
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_6699a4982997a1a4b4e85a3cc869bae4)await  localVars.queryResGetFoliosSAE_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetFoliosSAE_outParamList.CurrentRowNumber>=localVars.inParamStartindex)&&(localVars.queryResGetFoliosSAE_outParamList.CurrentRowNumber<(localVars.inParamStartindex+localVars.inParamMaxRecords))), cancellationToken)));

// List = ListFilter.FilteredList
result.outParamList=localVars.resListFilter_outParamFilteredList;

// TotalCount = GetFoliosSAE.Count
result.outParamTotalCount=localVars.queryResGetFoliosSAE_outParamCount;
}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamTotalCount = result.outParamTotalCount;
outParamUserRolesList = result.outParamUserRolesList;
outParamAppRoleListText = result.outParamAppRoleListText;
outParamEntraRolesListText = result.outParamEntraRolesListText;
outParamCanBulkApprove = result.outParamCanBulkApprove;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamTotalCount,outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText,outParamCanBulkApprove);
}

        public static class FuncActionServiceGetFoliosSAEForApprovalMobile {
            
private static async Task<RC_53767e07cc452cace0866f9d42b38a15> datasetGetFoliosSAEReadDbAsync(RC_53767e07cc452cace0866f9d42b38a15 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssCanApprove = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.CanApprove", false);
rec.ssDontShowAction = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetFoliosSAE" 11vcHL6+vk2VgC65+OmEsA of Action "ServiceGetFoliosSAEForApprovalMobile"
public static async Task<(RL_6699a4982997a1a4b4e85a3cc869bae4,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteAppRoleListText,string qpteEntraRolesListText,bool qpboGetIsCorporativo,long qpdeFolioApprovalLevel_DepartmentId,long qpreGetUserRegionId,string qpusFolioApprovalLevel_AssignedTo,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE", "1cdc5bd7-bebe-4dbe-9580-2eb9f8e984b0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE", "1cdc5bd7-bebe-4dbe-9580-2eb9f8e984b0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.rdbBr0y1GEqs162FYRB18g/NodesNotShownInESpaceTree.11vcHL6+vk2VgC65+OmEsA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus7\".\"id\" o0, \"enapprovalstatus7\".\"label\" o1, \"enapprovalstatus7\".\"class\" o2, \"enapprovalstatus7\".\"order\" o3, \"enapprovalstatus7\".\"is_active\" o4, \"enapprovalstatus7\".\"iscya\" o5, \"enapprovalstatus7\".\"iscyaapproval\" o6, \"enapprovalstatus7\".\"isreq\" o7, \"enapprovalstatus7\".\"isinv\" o8, \"enapprovalstatus7\".\"labeles\" o9, \"encurrency6\".\"code\" o10, \"encurrency6\".\"name\" o11, \"encurrency6\".\"symbol\" o12, \"encurrency6\".\"minorunitdecimals\" o13, \"encurrency6\".\"isactive\" o14, \"enfolio63\".\"id\" o15, \"enfolio63\".\"isdraft\" o16, \"enfolio63\".\"folionumber\" o17, \"enfolio63\".\"canproveedorcancel\" o18, \"enfolio63\".\"orderid\" o19, \"enfolio63\".\"supplierid\" o20, \"enfolio63\".\"companyid\" o21, \"enfolio63\".\"foliostatusid\" o22, trim_scale(\"enfolio63\".\"totalamount\"::numeric) o23, trim_scale(\"enfolio63\".\"totaliva_amount\"::numeric) o24, trim_scale(\"enfolio63\".\"partialamount\"::numeric) o25, \"enfolio63\".\"currencyid\" o26, \"enfolio63\".\"firstapproveruserid\" o27, \"enfolio63\".\"approvalprocesstypeid\" o28, \"enfolio63\".\"sapentryerror\" o29, \"enfolio63\".\"createdby\" o30, \"enfolio63\".\"createdon\" o31, \"enfolio63\".\"updatedby\" o32, \"enfolio63\".\"updatedon\" o33, \"enfolio63\".\"minuteselected\" o34, \"enfolioapproval35\".\"id\" o35, \"enfolioapproval35\".\"folioid\" o36, \"enfolioapproval35\".\"approvalprocessid\" o37, \"enfolioapproval35\".\"processtypecode\" o38, \"enfolioapproval35\".\"approvalprocessversion\" o39, \"enfolioapproval35\".\"currentlevel\" o40, \"enfolioapproval35\".\"maxlevel\" o41, \"enfolioapproval35\".\"startedon\" o42, \"enfolioapproval35\".\"finishedon\" o43, \"enfolioapproval35\".\"regionid\" o44, \"enfolioapprovallevel32\".\"id\" o45, \"enfolioapprovallevel32\".\"folioapprovalid\" o46, \"enfolioapprovallevel32\".\"levelnumber\" o47, \"enfolioapprovallevel32\".\"applicationroleid\" o48, \"enfolioapprovallevel32\".\"entrajobtitle\" o49, \"enfolioapprovallevel32\".\"entraroleid\" o50, \"enfolioapprovallevel32\".\"departmentid\" o51, \"enfolioapprovallevel32\".\"assignedto\" o52, \"enfolioapprovallevel32\".\"approvalstatusid\" o53, \"enfolioapprovallevel32\".\"ismandatory\" o54, \"enfolioapprovallevel32\".\"isreassigned\" o55, \"enfolioapprovallevel32\".\"approvedby\" o56, \"enfolioapprovallevel32\".\"approvedon\" o57, \"enfolioapprovallevel32\".\"canceledby\" o58, \"enfolioapprovallevel32\".\"canceledon\" o59, \"enfolioapprovallevel32\".\"rejectedby\" o60, \"enfolioapprovallevel32\".\"rejectedon\" o61, \"enfolioapprovallevel32\".\"issubstitutefor\" o62, \"enfolioapprovallevel32\".\"rejectreason\" o63, \"enfolioapprovallevel32\".\"isinvoiceapproval\" o64, \"enfoliostatus\".\"id\" o65, \"enfoliostatus\".\"label\" o66, \"enfoliostatus\".\"class\" o67, \"enfoliostatus\".\"order\" o68, \"enfoliostatus\".\"is_active\" o69, \"enfoliostatus\".\"labeles\" o70, \"enordermain75\".\"id\" o71, \"enordermain75\".\"ordernumber\" o72, \"enordermain75\".\"orderdate\" o73, \"enordermain75\".\"orderstatusid\" o74, \"enordermain75\".\"previousorderstatusid\" o75, \"enordermain75\".\"assignmentcode\" o76, \"enordermain75\".\"supplierid\" o77, \"enordermain75\".\"companyid\" o78, \"enordermain75\".\"documenttypeid\" o79, \"enordermain75\".\"currencyid\" o80, \"enordermain75\".\"telceldirectionid\" o81, \"enordermain75\".\"procurementgroup\" o82, \"enordermain75\".\"creatorsapnumber\" o83, \"enordermain75\".\"creatorsapname\" o84, \"enordermain75\".\"country\" o85, \"enordermain75\".\"isdeleted\" o86, \"enordermain75\".\"isreleased\" o87, trim_scale(\"enordermain75\".\"exchangerate\"::numeric) o88, \"enordermain75\".\"sustainabilitycategory\" o89, \"enordermain75\".\"sustainabilitysubcategory\" o90, trim_scale(\"enordermain75\".\"totalamount\"::numeric) o91, \"enordermain75\".\"fromcosmoz\" o92, \"enordermain75\".\"regionid\" o93, \"enordermain75\".\"divisionid\" o94, \"enordermain75\".\"applicant\" o95, \"enordermain75\".\"createdby\" o96, \"enordermain75\".\"createdon\" o97, \"enordermain75\".\"updatedby\" o98, \"enordermain75\".\"updatedon\" o99, \"enregion74\".\"id\" o100, \"enregion74\".\"code\" o101, \"enregion74\".\"name\" o102, \"enregion74\".\"divisionfi\" o103, \"enregion74\".\"centrortp\" o104, \"enregion74\".\"commissionregion\" o105, \"enregion74\".\"isactive\" o106, \"enregion74\".\"createdon\" o107, \"enregion74\".\"createdby\" o108, \"enregion74\".\"updatedon\" o109, \"enregion74\".\"updatedby\" o110, \"enregion74\".\"isfsp\" o111, \"enregion74\".\"isfcp\" o112, \"ensupplier57\".\"id\" o113, \"ensupplier57\".\"tratamiento\" o114, \"ensupplier57\".\"name\" o115, \"ensupplier57\".\"number\" o116, \"ensupplier57\".\"conceptobusq_1_2\" o117, \"ensupplier57\".\"calle_numero\" o118, \"ensupplier57\".\"distrito\" o119, \"ensupplier57\".\"codigopostal_pobl_\" o120, \"ensupplier57\".\"pais\" o121, \"ensupplier57\".\"region_\" o122, \"ensupplier57\".\"idioma\" o123, \"ensupplier57\".\"telefono\" o124, \"ensupplier57\".\"extension\" o125, \"ensupplier57\".\"fax\" o126, \"ensupplier57\".\"cliente\" o127, \"ensupplier57\".\"soc_glasociada\" o128, \"ensupplier57\".\"clavedegrupo\" o129, \"ensupplier57\".\"n_ident_fis_1\" o130, \"ensupplier57\".\"personafisica\" o131, \"ensupplier57\".\"ramo\" o132, \"ensupplier57\".\"grupodeporte\" o133, \"ensupplier57\".\"email\" o134, \"ensupplier57\".\"isactive\" o135, \"ensupplier57\".\"createdon\" o136, \"ensupplier57\".\"createdby\" o137, \"ensupplier57\".\"updatedon\" o138, \"ensupplier57\".\"updatedby\" o139, \"ensupplier57\".\"regionid\" o140, (CASE WHEN (((\"enfolioapprovallevel32\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enfolioapprovallevel32\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(")) AND ((\"enfolio63\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(") OR (\"enfolio63\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"canapprove\", (CASE WHEN (\"enfolioapprovallevel32\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain75\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain75\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain75\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio63\" Left JOIN {FolioApproval} \"enfolioapproval35\" ON (\"enfolio63\".\"id\" = \"enfolioapproval35\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel32\" ON (\"enfolioapproval35\".\"id\" = \"enfolioapprovallevel32\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain75\" ON (\"enfolio63\".\"orderid\" = \"enordermain75\".\"id\"))  Left JOIN {Region} \"enregion74\" ON (\"enordermain75\".\"regionid\" = \"enregion74\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus\" ON (\"enfolio63\".\"foliostatusid\" = \"enfoliostatus\".\"id\"))  Left JOIN {Supplier} \"ensupplier57\" ON (\"enfolio63\".\"supplierid\" = \"ensupplier57\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus7\" ON (\"enfolioapprovallevel32\".\"approvalstatusid\" = \"enapprovalstatus7\".\"id\"))  Left JOIN {Currency} \"encurrency6\" ON (\"enfolio63\".\"currencyid\" = \"encurrency6\".\"code\")) ");
whereBuilder.Append(" WHERE (((\"enfolioapprovallevel32\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") OR (\"enfolioapprovallevel32\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
whereBuilder.Append(")) AND ((CASE WHEN (\"enfolioapprovallevel32\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel32\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel32\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enfolioapprovallevel32\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel32\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel32\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel32\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel32\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain75\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain75\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain75\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval35\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval35\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval35\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel32\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel32\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel32\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel32\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"enfolio63\".\"id\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "FolioApproval", "Supplier", "Folio", "FolioStatus", "OrderMain", "Currency", "ApprovalStatus", "Region", "FolioApprovalLevel" }, new string[] { "ENFolioApproval35", "ENSupplier57", "ENFolio63", "ENFolioStatus", "ENOrderMain75", "ENCurrency6", "ENApprovalStatus7", "ENRegion74", "ENFolioApprovalLevel32" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_6699a4982997a1a4b4e85a3cc869bae4 outParamList = new RL_6699a4982997a1a4b4e85a3cc869bae4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6699a4982997a1a4b4e85a3cc869bae4 _tmp = new RL_6699a4982997a1a4b4e85a3cc869bae4();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6699a4982997a1a4b4e85a3cc869bae4)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_6d4a92ad9e5239e9c12dd070f5b17d69> datasetGetRoleConceptReadDbAsync(RC_6d4a92ad9e5239e9c12dd070f5b17d69 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" CzT1oKe0Q0CeR7L9EPmXlA of Action "ServiceGetFoliosSAEForApprovalMobile"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetFoliosSAEForApprovalMobile.GetRoleConcept", "a0f5340b-b4a7-4043-9e47-b2fd10f99794");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetFoliosSAEForApprovalMobile.GetRoleConcept", "a0f5340b-b4a7-4043-9e47-b2fd10f99794", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /ServiceAPIMethods.rdbBr0y1GEqs162FYRB18g/NodesNotShownInESpaceTree.CzT1oKe0Q0CeR7L9EPmXlA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole43\".\"code\" o1, \"enapplicationrole43\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept16\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal89\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal89\" Inner JOIN {User} \"enuser148\" ON (\"enuser_extended_internal89\".\"id\" = \"enuser148\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole44\" ON (\"enuser_extended_internal89\".\"jobtitle\" = \"enentrarole44\".\"rolename\"))  Left JOIN {Region} \"enregion75\" ON (\"enuser_extended_internal89\".\"regionid\" = \"enregion75\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept16\" ON (\"enentrarole44\".\"id\" = \"enroleconcept16\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole43\" ON (\"enroleconcept16\".\"applicationroleid\" = \"enapplicationrole43\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser148\".\"id\" = @qpusUser_Id) AND (\"enuser148\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser148\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept16\".\"conceptid\" = ");
whereBuilder.Append(2
);
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
RL_721bdfcca4a4edbce82baece8dfe837b outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetFoliosSAEForApprovalMobile.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_721bdfcca4a4edbce82baece8dfe837b _tmp = new RL_721bdfcca4a4edbce82baece8dfe837b();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetFoliosSAEForApprovalMobile.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_721bdfcca4a4edbce82baece8dfe837b)_tmp;
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

private static async Task<RC_53767e07cc452cace0866f9d42b38a15> datasetGetFoliosSAE2ReadDbAsync(RC_53767e07cc452cace0866f9d42b38a15 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssCanApprove = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.CanApprove", false);
rec.ssDontShowAction = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "CurrencyFolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainCanApproveDontShowActionIsSelectedIsUserFromThisRegionSupplierRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetFoliosSAE2" C75M+Fva_ECci0UGpLKh6g of Action "ServiceGetFoliosSAEForApprovalMobile"
public static async Task<(RL_6699a4982997a1a4b4e85a3cc869bae4,long)> datasetGetFoliosSAE2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteAppRoleListText,string qpteEntraRolesListText,bool qpboGetIsCorporativo,long qpdeFolioApprovalLevel_DepartmentId,long qpreGetUserRegionId,string qpusFolioApprovalLevel_AssignedTo,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE2", "f84cbe0b-da5b-40fc-9c8b-4506a4b2a1ea");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE2", "f84cbe0b-da5b-40fc-9c8b-4506a4b2a1ea", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.rdbBr0y1GEqs162FYRB18g/NodesNotShownInESpaceTree.C75M+Fva_ECci0UGpLKh6g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus8\".\"id\" o0, \"enapprovalstatus8\".\"label\" o1, \"enapprovalstatus8\".\"class\" o2, \"enapprovalstatus8\".\"order\" o3, \"enapprovalstatus8\".\"is_active\" o4, \"enapprovalstatus8\".\"iscya\" o5, \"enapprovalstatus8\".\"iscyaapproval\" o6, \"enapprovalstatus8\".\"isreq\" o7, \"enapprovalstatus8\".\"isinv\" o8, \"enapprovalstatus8\".\"labeles\" o9, \"encurrency7\".\"code\" o10, \"encurrency7\".\"name\" o11, \"encurrency7\".\"symbol\" o12, \"encurrency7\".\"minorunitdecimals\" o13, \"encurrency7\".\"isactive\" o14, \"enfolio64\".\"id\" o15, \"enfolio64\".\"isdraft\" o16, \"enfolio64\".\"folionumber\" o17, \"enfolio64\".\"canproveedorcancel\" o18, \"enfolio64\".\"orderid\" o19, \"enfolio64\".\"supplierid\" o20, \"enfolio64\".\"companyid\" o21, \"enfolio64\".\"foliostatusid\" o22, trim_scale(\"enfolio64\".\"totalamount\"::numeric) o23, trim_scale(\"enfolio64\".\"totaliva_amount\"::numeric) o24, trim_scale(\"enfolio64\".\"partialamount\"::numeric) o25, \"enfolio64\".\"currencyid\" o26, \"enfolio64\".\"firstapproveruserid\" o27, \"enfolio64\".\"approvalprocesstypeid\" o28, \"enfolio64\".\"sapentryerror\" o29, \"enfolio64\".\"createdby\" o30, \"enfolio64\".\"createdon\" o31, \"enfolio64\".\"updatedby\" o32, \"enfolio64\".\"updatedon\" o33, \"enfolio64\".\"minuteselected\" o34, \"enfolioapproval36\".\"id\" o35, \"enfolioapproval36\".\"folioid\" o36, \"enfolioapproval36\".\"approvalprocessid\" o37, \"enfolioapproval36\".\"processtypecode\" o38, \"enfolioapproval36\".\"approvalprocessversion\" o39, \"enfolioapproval36\".\"currentlevel\" o40, \"enfolioapproval36\".\"maxlevel\" o41, \"enfolioapproval36\".\"startedon\" o42, \"enfolioapproval36\".\"finishedon\" o43, \"enfolioapproval36\".\"regionid\" o44, \"enfolioapprovallevel33\".\"id\" o45, \"enfolioapprovallevel33\".\"folioapprovalid\" o46, \"enfolioapprovallevel33\".\"levelnumber\" o47, \"enfolioapprovallevel33\".\"applicationroleid\" o48, \"enfolioapprovallevel33\".\"entrajobtitle\" o49, \"enfolioapprovallevel33\".\"entraroleid\" o50, \"enfolioapprovallevel33\".\"departmentid\" o51, \"enfolioapprovallevel33\".\"assignedto\" o52, \"enfolioapprovallevel33\".\"approvalstatusid\" o53, \"enfolioapprovallevel33\".\"ismandatory\" o54, \"enfolioapprovallevel33\".\"isreassigned\" o55, \"enfolioapprovallevel33\".\"approvedby\" o56, \"enfolioapprovallevel33\".\"approvedon\" o57, \"enfolioapprovallevel33\".\"canceledby\" o58, \"enfolioapprovallevel33\".\"canceledon\" o59, \"enfolioapprovallevel33\".\"rejectedby\" o60, \"enfolioapprovallevel33\".\"rejectedon\" o61, \"enfolioapprovallevel33\".\"issubstitutefor\" o62, \"enfolioapprovallevel33\".\"rejectreason\" o63, \"enfolioapprovallevel33\".\"isinvoiceapproval\" o64, \"enfoliostatus1\".\"id\" o65, \"enfoliostatus1\".\"label\" o66, \"enfoliostatus1\".\"class\" o67, \"enfoliostatus1\".\"order\" o68, \"enfoliostatus1\".\"is_active\" o69, \"enfoliostatus1\".\"labeles\" o70, \"enordermain76\".\"id\" o71, \"enordermain76\".\"ordernumber\" o72, \"enordermain76\".\"orderdate\" o73, \"enordermain76\".\"orderstatusid\" o74, \"enordermain76\".\"previousorderstatusid\" o75, \"enordermain76\".\"assignmentcode\" o76, \"enordermain76\".\"supplierid\" o77, \"enordermain76\".\"companyid\" o78, \"enordermain76\".\"documenttypeid\" o79, \"enordermain76\".\"currencyid\" o80, \"enordermain76\".\"telceldirectionid\" o81, \"enordermain76\".\"procurementgroup\" o82, \"enordermain76\".\"creatorsapnumber\" o83, \"enordermain76\".\"creatorsapname\" o84, \"enordermain76\".\"country\" o85, \"enordermain76\".\"isdeleted\" o86, \"enordermain76\".\"isreleased\" o87, trim_scale(\"enordermain76\".\"exchangerate\"::numeric) o88, \"enordermain76\".\"sustainabilitycategory\" o89, \"enordermain76\".\"sustainabilitysubcategory\" o90, trim_scale(\"enordermain76\".\"totalamount\"::numeric) o91, \"enordermain76\".\"fromcosmoz\" o92, \"enordermain76\".\"regionid\" o93, \"enordermain76\".\"divisionid\" o94, \"enordermain76\".\"applicant\" o95, \"enordermain76\".\"createdby\" o96, \"enordermain76\".\"createdon\" o97, \"enordermain76\".\"updatedby\" o98, \"enordermain76\".\"updatedon\" o99, \"enregion76\".\"id\" o100, \"enregion76\".\"code\" o101, \"enregion76\".\"name\" o102, \"enregion76\".\"divisionfi\" o103, \"enregion76\".\"centrortp\" o104, \"enregion76\".\"commissionregion\" o105, \"enregion76\".\"isactive\" o106, \"enregion76\".\"createdon\" o107, \"enregion76\".\"createdby\" o108, \"enregion76\".\"updatedon\" o109, \"enregion76\".\"updatedby\" o110, \"enregion76\".\"isfsp\" o111, \"enregion76\".\"isfcp\" o112, \"ensupplier58\".\"id\" o113, \"ensupplier58\".\"tratamiento\" o114, \"ensupplier58\".\"name\" o115, \"ensupplier58\".\"number\" o116, \"ensupplier58\".\"conceptobusq_1_2\" o117, \"ensupplier58\".\"calle_numero\" o118, \"ensupplier58\".\"distrito\" o119, \"ensupplier58\".\"codigopostal_pobl_\" o120, \"ensupplier58\".\"pais\" o121, \"ensupplier58\".\"region_\" o122, \"ensupplier58\".\"idioma\" o123, \"ensupplier58\".\"telefono\" o124, \"ensupplier58\".\"extension\" o125, \"ensupplier58\".\"fax\" o126, \"ensupplier58\".\"cliente\" o127, \"ensupplier58\".\"soc_glasociada\" o128, \"ensupplier58\".\"clavedegrupo\" o129, \"ensupplier58\".\"n_ident_fis_1\" o130, \"ensupplier58\".\"personafisica\" o131, \"ensupplier58\".\"ramo\" o132, \"ensupplier58\".\"grupodeporte\" o133, \"ensupplier58\".\"email\" o134, \"ensupplier58\".\"isactive\" o135, \"ensupplier58\".\"createdon\" o136, \"ensupplier58\".\"createdby\" o137, \"ensupplier58\".\"updatedon\" o138, \"ensupplier58\".\"updatedby\" o139, \"ensupplier58\".\"regionid\" o140, (CASE WHEN (((\"enfolioapprovallevel33\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enfolioapprovallevel33\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
selectBuilder.Append(")) AND ((\"enfolio64\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OLAtbBHfEkWbS1oUJ_NMaQ"))).ssId);
selectBuilder.Append(") OR (\"enfolio64\".\"foliostatusid\" = ");
selectBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("vQbNAb5X2kaiyrG3Zsu2KA"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"canapprove\", (CASE WHEN (\"enfolioapprovallevel33\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain76\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain76\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain76\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio64\" Left JOIN {FolioApproval} \"enfolioapproval36\" ON (\"enfolio64\".\"id\" = \"enfolioapproval36\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel33\" ON (\"enfolioapproval36\".\"id\" = \"enfolioapprovallevel33\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain76\" ON (\"enfolio64\".\"orderid\" = \"enordermain76\".\"id\"))  Left JOIN {Region} \"enregion76\" ON (\"enordermain76\".\"regionid\" = \"enregion76\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus1\" ON (\"enfolio64\".\"foliostatusid\" = \"enfoliostatus1\".\"id\"))  Left JOIN {Supplier} \"ensupplier58\" ON (\"enfolio64\".\"supplierid\" = \"ensupplier58\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus8\" ON (\"enfolioapprovallevel33\".\"approvalstatusid\" = \"enapprovalstatus8\".\"id\"))  Left JOIN {Currency} \"encurrency7\" ON (\"enfolio64\".\"currencyid\" = \"encurrency7\".\"code\")) ");
whereBuilder.Append(" WHERE ((\"enfolioapprovallevel33\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") AND ((CASE WHEN (\"enfolioapprovallevel33\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel33\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel33\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enfolioapprovallevel33\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel33\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel33\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel33\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel33\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain76\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain76\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain76\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval36\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval36\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval36\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel33\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel33\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel33\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel33\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"enfolio64\".\"id\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Folio", "FolioStatus", "ApprovalStatus", "FolioApproval", "OrderMain", "Region", "Supplier", "FolioApprovalLevel", "Currency" }, new string[] { "ENFolio64", "ENFolioStatus1", "ENApprovalStatus8", "ENFolioApproval36", "ENOrderMain76", "ENRegion76", "ENSupplier58", "ENFolioApprovalLevel33", "ENCurrency7" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_6699a4982997a1a4b4e85a3cc869bae4 outParamList = new RL_6699a4982997a1a4b4e85a3cc869bae4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAE2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE2.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6699a4982997a1a4b4e85a3cc869bae4 _tmp = new RL_6699a4982997a1a4b4e85a3cc869bae4();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAE2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6699a4982997a1a4b4e85a3cc869bae4)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetFoliosSAEForApprovalMobile.GetFoliosSAE2.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
