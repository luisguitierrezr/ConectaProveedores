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

    public class S4PIServiceGetRequisitionsInput {
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
public S4PIServiceGetRequisitionsInput(string inParamCurrentLocale, int? inParamMaxRecords, int? inParamStartindex, string inParamTableSort, JSONRC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamStartindex = inParamStartindex;
this.inParamTableSort = inParamTableSort;
this.inParamUserApplicationRoles = inParamUserApplicationRoles;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetRequisitionsOutput {
[JsonProperty("List")]
public JSONST_93db82ada2d57fd9d5e68feb0d1d4360Structure[] outParamList;
[JsonProperty("TotalCount")]
public long outParamTotalCount;
public S4PIServiceGetRequisitionsOutput(JSONST_93db82ada2d57fd9d5e68feb0d1d4360Structure[] outParamList, long outParamTotalCount) {
this.outParamList = outParamList;
this.outParamTotalCount = outParamTotalCount;
}

}

[HttpPost()]
[Route("serviceapi/servicegetrequisitions")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetRequisitions", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetRequisitions(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetRequisitionsInput, S4PIServiceGetRequisitionsOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
RL_7bdbdb9aacaab70f408915204de132ea outParamList;
long outParamTotalCount;
S4PIServiceGetRequisitionsInput inputs = serviceActionInput.InputParameters;
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
(outParamList,outParamTotalCount) = await Flows.ActionServiceGetRequisitions(context,inputs.inParamCurrentLocale,inputs.inParamMaxRecords.Value,inputs.inParamStartindex.Value,inputs.inParamTableSort,JSONRC_4eba0035378aebca97affd4e1528379d.ToStructure(inputs.inParamUserApplicationRoles, behaviorsConfiguration),inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetRequisitionsOutput(RL_7bdbdb9aacaab70f408915204de132ea.ToArray(outParamList, (str) => JSONST_93db82ada2d57fd9d5e68feb0d1d4360Structure.FromStructure(str, behaviorsConfiguration)), outParamTotalCount);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetRequisitions : VarsBag {
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

public RL_8365613fe8b9250421c71137e60527cb resListFilter_outParamFilteredList = new RL_8365613fe8b9250421c71137e60527cb();

public RL_8365613fe8b9250421c71137e60527cb queryResGetRequisitionsList_outParamList = new RL_8365613fe8b9250421c71137e60527cb();
public long queryResGetRequisitionsList_outParamCount = 0L;

public RL_8365613fe8b9250421c71137e60527cb resListFilter2_outParamFilteredList = new RL_8365613fe8b9250421c71137e60527cb();

public RL_8365613fe8b9250421c71137e60527cb queryResGetRequisitionsList2_outParamList = new RL_8365613fe8b9250421c71137e60527cb();
public long queryResGetRequisitionsList2_outParamCount = 0L;

public lcvServiceGetRequisitions(string inParamCurrentLocale, int inParamMaxRecords, int inParamStartindex, string inParamTableSort, RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamMaxRecords = inParamMaxRecords;
this.inParamStartindex = inParamStartindex;
this.inParamTableSort = inParamTableSort;
this.inParamUserApplicationRoles = inParamUserApplicationRoles;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetRequisitions : VarsBag {
public RL_7bdbdb9aacaab70f408915204de132ea outParamList = new RL_7bdbdb9aacaab70f408915204de132ea();

public long outParamTotalCount = 0L;

public lcoServiceGetRequisitions() {
}
}
/// <summary>
/// Action <code>ServiceGetRequisitions</code> that represents the Service Studio action
///  <code>ServiceGetRequisitions</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_7bdbdb9aacaab70f408915204de132ea,long)> ActionServiceGetRequisitions(IRequestContext requestContext,string inParamCurrentLocale,int inParamMaxRecords,int inParamStartindex,string inParamTableSort,RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles,string inParami_GetUserId,CancellationToken cancellationToken) {
RL_7bdbdb9aacaab70f408915204de132ea outParamList = default;
long outParamTotalCount = default;
lcoServiceGetRequisitions result = new lcoServiceGetRequisitions();
lcvServiceGetRequisitions localVars = new lcvServiceGetRequisitions(inParamCurrentLocale, inParamMaxRecords, inParamStartindex, inParamTableSort, inParamUserApplicationRoles, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetRequisitions", "65196605-24cf-4994-843a-a1c3cca3cde7"))
using (activitySource.CreateServiceActionActivity("ServiceGetRequisitions")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,(((localVars.inParamCurrentLocale=="")) ? ("es-MX") : (localVars.inParamCurrentLocale)),cancellationToken);

if(((localVars.inParamTableSort==""))) {
// TableSort = "Requisition.Id DESC"
localVars.inParamTableSort="Requisition.Id DESC";
}

if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_OnlyNotApprovedMobile]))))) {
// Query QueryGetRequisitionsList2
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsList2_maxRecords = 0;
int QueryGetRequisitionsList2_startIndex = 0;(localVars.queryResGetRequisitionsList2_outParamList,localVars.queryResGetRequisitionsList2_outParamCount) = await FuncActionServiceGetRequisitions.QueryGetRequisitionsList2(requestContext,QueryGetRequisitionsList2_maxRecords,QueryGetRequisitionsList2_startIndex,IterationMultiplicity.Multiple,localVars.inParami_GetUserId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.inParamUserApplicationRoles.ssAppRolesListText,localVars.inParamUserApplicationRoles.ssTelcelDirectionsListText,localVars.inParamUserApplicationRoles.ssIsCorporativoCxP,localVars.inParamUserApplicationRoles.ssCorporativoRegionId,(await Functions.ActionEncodeSortForSQL(requestContext,localVars.inParamTableSort,cancellationToken)),cancellationToken);

// Iterator = Startindex
localVars.varLcIterator=localVars.inParamStartindex;
// ListFilter2
localVars.resListFilter2_outParamFilteredList = (((RL_8365613fe8b9250421c71137e60527cb)await  localVars.queryResGetRequisitionsList2_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetRequisitionsList2_outParamList.CurrentRowNumber>=localVars.inParamStartindex)&&(localVars.queryResGetRequisitionsList2_outParamList.CurrentRowNumber<(localVars.inParamStartindex+localVars.inParamMaxRecords))), cancellationToken)));

// List = ListFilter2.FilteredList
result.outParamList=(await RL_7bdbdb9aacaab70f408915204de132ea.ConvertAsync(localVars.resListFilter2_outParamFilteredList, new RL_7bdbdb9aacaab70f408915204de132ea(), async (RC_c4f3f57be4398f0d8a99656890ed9dae source, ST_93db82ada2d57fd9d5e68feb0d1d4360Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// TotalCount = GetRequisitionsList2.Count
result.outParamTotalCount=localVars.queryResGetRequisitionsList2_outParamCount;
} else {
// Query QueryGetRequisitionsList
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsList_maxRecords = 0;
int QueryGetRequisitionsList_startIndex = 0;(localVars.queryResGetRequisitionsList_outParamList,localVars.queryResGetRequisitionsList_outParamCount) = await FuncActionServiceGetRequisitions.QueryGetRequisitionsList(requestContext,QueryGetRequisitionsList_maxRecords,QueryGetRequisitionsList_startIndex,IterationMultiplicity.Multiple,localVars.inParami_GetUserId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.inParamUserApplicationRoles.ssAppRolesListText,localVars.inParamUserApplicationRoles.ssTelcelDirectionsListText,localVars.inParamUserApplicationRoles.ssIsCorporativoCxP,localVars.inParamUserApplicationRoles.ssCorporativoRegionId,(await Functions.ActionEncodeSortForSQL(requestContext,localVars.inParamTableSort,cancellationToken)),cancellationToken);

// Iterator = Startindex
localVars.varLcIterator=localVars.inParamStartindex;
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_8365613fe8b9250421c71137e60527cb)await  localVars.queryResGetRequisitionsList_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetRequisitionsList_outParamList.CurrentRowNumber>=localVars.inParamStartindex)&&(localVars.queryResGetRequisitionsList_outParamList.CurrentRowNumber<(localVars.inParamStartindex+localVars.inParamMaxRecords))), cancellationToken)));

// List = ListFilter.FilteredList
result.outParamList=(await RL_7bdbdb9aacaab70f408915204de132ea.ConvertAsync(localVars.resListFilter_outParamFilteredList, new RL_7bdbdb9aacaab70f408915204de132ea(), async (RC_c4f3f57be4398f0d8a99656890ed9dae source, ST_93db82ada2d57fd9d5e68feb0d1d4360Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// TotalCount = GetRequisitionsList.Count
result.outParamTotalCount=localVars.queryResGetRequisitionsList_outParamCount;
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

        public static class FuncActionServiceGetRequisitions {
            
// Query Function "GetRequisitionsList" bQpPQCCd2Emry7lqmchNww of Action "ServiceGetRequisitions"
public static async Task<(RL_8365613fe8b9250421c71137e60527cb,long)> QueryGetRequisitionsList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("ServiceGetRequisitions.GetRequisitionsList", "404f0a6d-9d20-49d8-abcb-b96a99c84dc3");
using var queryActivity = activitySource.CreateSqlQueryActivity("ServiceGetRequisitions.GetRequisitionsList", "404f0a6d-9d20-49d8-abcb-b96a99c84dc3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCountCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCmd.CreateParameter("@qpapApprovalStatusPending", DbType.Int32, qpapApprovalStatusPending);
sqlCountCmd.CreateParameter("@qpapApprovalStatusPending", DbType.Int32, qpapApprovalStatusPending);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCountCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCountCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCountCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCountCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
sqlCountCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
string sql = "";
string advSql = "SELECT  \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"class\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + ", \nCOALESCE(User_Applicant.\"name\", '') AS UserApplicantName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"advwithoutinvoice\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isaccounting\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscontractpending\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontractfileuploaded\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approveasareausuaria\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + ", \nCOALESCE(UpdatedBy.\"name\", '') AS UserUpdatedByName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedon\"") + ", \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " IS NULL \n    OR \n    ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " <> @qpusGetUserId \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n            AND STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) = 0 \n        ) \n    ) \n) AS DontShowAction \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \nORDER BY  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteTableSort)) + "";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
AppUtils.Instance.CheckForSelectStatement(sql);
string sqlCount = "SELECT COUNT(*) FROM ( ";
sqlCount += sql;
sqlCount += ") as result ";
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_8365613fe8b9250421c71137e60527cb outParamList = new RL_8365613fe8b9250421c71137e60527cb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetRequisitions.GetRequisitionsList.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8365613fe8b9250421c71137e60527cb _tmp = new RL_8365613fe8b9250421c71137e60527cb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8365613fe8b9250421c71137e60527cb)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetRequisitions.GetRequisitionsList.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsList in ServiceGetRequisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[LabelES],  {RequisitionStatus}.[Class],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[LabelES],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {R ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in ServiceGetRequisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[LabelES],  {RequisitionStatus}.[Class],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[LabelES],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {R ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in ServiceGetRequisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[LabelES],  {RequisitionStatus}.[Class],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[LabelES],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {R ...): " + aqExcep.Message));
}
}
}
}

// Query Function "GetRequisitionsList2" 2UUespAwmEW4YxkGa402Lw of Action "ServiceGetRequisitions"
public static async Task<(RL_8365613fe8b9250421c71137e60527cb,long)> QueryGetRequisitionsList2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusNotApproved,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("ServiceGetRequisitions.GetRequisitionsList2", "b21e45d9-3090-4598-b863-19066b8d362f");
using var queryActivity = activitySource.CreateSqlQueryActivity("ServiceGetRequisitions.GetRequisitionsList2", "b21e45d9-3090-4598-b863-19066b8d362f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCountCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCountCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCmd.CreateParameter("@qpapApprovalStatusNotApproved", DbType.Int32, qpapApprovalStatusNotApproved);
sqlCountCmd.CreateParameter("@qpapApprovalStatusNotApproved", DbType.Int32, qpapApprovalStatusNotApproved);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCountCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCountCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCountCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCountCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
sqlCountCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCountCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
string sql = "";
string advSql = "SELECT  \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"class\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + ", \nCOALESCE(User_Applicant.\"name\", '') AS UserApplicantName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"advwithoutinvoice\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isaccounting\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscontractpending\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontractfileuploaded\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approveasareausuaria\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + ", \nCOALESCE(UpdatedBy.\"name\", '') AS UserUpdatedByName, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedon\"") + ", \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " IS NULL \n    OR \n    ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " <> @qpusGetUserId \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n            AND STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) = 0 \n        ) \n    ) \n) AS DontShowAction \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " = @qpapApprovalStatusNotApproved \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \nORDER BY  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qpteTableSort)) + "";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
AppUtils.Instance.CheckForSelectStatement(sql);
string sqlCount = "SELECT COUNT(*) FROM ( ";
sqlCount += sql;
sqlCount += ") as result ";
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_8365613fe8b9250421c71137e60527cb outParamList = new RL_8365613fe8b9250421c71137e60527cb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetRequisitions.GetRequisitionsList2.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetRequisitions.GetRequisitionsList2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8365613fe8b9250421c71137e60527cb _tmp = new RL_8365613fe8b9250421c71137e60527cb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetRequisitions.GetRequisitionsList2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8365613fe8b9250421c71137e60527cb)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetRequisitions.GetRequisitionsList2.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsList2 in ServiceGetRequisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[LabelES],  {RequisitionStatus}.[Class],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[LabelES],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {R ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList2 in ServiceGetRequisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[LabelES],  {RequisitionStatus}.[Class],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[LabelES],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {R ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList2 in ServiceGetRequisitions in ConectaProveedores (SELECT   {Requisition}.[Id],  {RequisitionApprovalLevel}.[Id],  {Requisition}.[Name],  {Requisition}.[RequisitionStatusId],  {RequisitionStatus}.[LabelES],  {RequisitionStatus}.[Class],  {ApprovalStatus}.[Id],  {ApprovalStatus}.[LabelES],  {ApprovalStatus}.[Class],  {Requisition}.[ApplicantId],  COALESCE(User_Applicant.[Name], '') AS UserApplicantName,  {Project_Asset_Service}.[Description],  {Supplier}.[Name],  {Supplier}.[Number],  {Requisition}.[RegionId],  {Region}.[Code],  {Requisition}.[TotalAmount],  {Currency}.[Code],  {CostCenterSAP}.[Denominacion],  {Company}.[Description],  {Requisition}.[AdvWithoutInvoice],  {RequisitionApprovalLevel}.[IsAccounting],  {Requisition}.[AccountingRegionId],  {RequisitionApprovalLevel}.[AssignedTo],  {Requisition}.[IsContractPending],  {Requisition}.[HasContractFileUploaded],  {RequisitionApprovalLevel}.[ApproveAsAreaUsuaria],  {Requisition}.[CreatedOn],  COALESCE(UpdatedBy.[Name], '') AS UserUpdatedByName,  {Requisition}.[UpdatedOn],  (      {R ...): " + aqExcep.Message));
}
}
}
}

        }
    }
}
