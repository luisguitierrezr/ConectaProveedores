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

    public class S4PIServiceGetDataForTheHomepageInput {
[JsonProperty("CurrentLocale")]
public string inParamCurrentLocale;
[JsonProperty("UserApplicationRoles")]
public JSONRC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles;
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceGetDataForTheHomepageInput(string inParamCurrentLocale, JSONRC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamUserApplicationRoles = inParamUserApplicationRoles;
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceGetDataForTheHomepageOutput {
[JsonProperty("InvoicesData")]
public long outParamInvoicesData;
[JsonProperty("FoliosData")]
public long outParamFoliosData;
[JsonProperty("RequisitionsData")]
public long outParamRequisitionsData;
public S4PIServiceGetDataForTheHomepageOutput(long outParamInvoicesData, long outParamFoliosData, long outParamRequisitionsData) {
this.outParamInvoicesData = outParamInvoicesData;
this.outParamFoliosData = outParamFoliosData;
this.outParamRequisitionsData = outParamRequisitionsData;
}

}

[HttpPost()]
[Route("serviceapi/servicegetdataforthehomepage")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceGetDataForTheHomepage", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceGetDataForTheHomepage(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceGetDataForTheHomepageInput, S4PIServiceGetDataForTheHomepageOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
long outParamInvoicesData;
long outParamFoliosData;
long outParamRequisitionsData;
S4PIServiceGetDataForTheHomepageInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParamCurrentLocale == null)) {
validationErrors["CurrentLocale"]=new string[] {"The CurrentLocale mandatory parameter is missing in the request."};
}

if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamInvoicesData,outParamFoliosData,outParamRequisitionsData) = await Flows.ActionServiceGetDataForTheHomepage(context,inputs.inParamCurrentLocale,JSONRC_4eba0035378aebca97affd4e1528379d.ToStructure(inputs.inParamUserApplicationRoles, behaviorsConfiguration),inputs.inParami_GetUserId,ctx);

return new S4PIServiceGetDataForTheHomepageOutput(outParamInvoicesData, outParamFoliosData, outParamRequisitionsData);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceGetDataForTheHomepage : VarsBag {
public string inParamCurrentLocale;
public RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles;
public string inParami_GetUserId;
/// <summary>
/// Variable <code>UserRolesList</code> that represents the Service Studio UserRoleCodeList
///  <code>UserRolesList</code> <p>Description: List of User Roles</p>
/// </summary>
public RL_97ac86b141c7934fd96d3cf71793066e varLcUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

/// <summary>
/// Variable <code>AppRoleListText</code> that represents the Service Studio Text
///  <code>AppRoleListText</code> <p>Description: ListText</p>
/// </summary>
public string varLcAppRoleListText = "";

/// <summary>
/// Variable <code>EntraRolesListText</code> that represents the Service Studio Text
///  <code>EntraRolesListText</code> <p>Description: </p>
/// </summary>
public string varLcEntraRolesListText = "";

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public Actions.lcoGetUserEntraRoleName resGetUserEntraRoleName =  new Actions.lcoGetUserEntraRoleName();
public RL_11e68f59508e412eaf5b78801dd06b0e queryResGetInvoices_outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
public long queryResGetInvoices_outParamCount = 0L;

public RL_1f3e9ea72dc7b010c56ee9146ee277c5 queryResGetRequisitions_outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
public long queryResGetRequisitions_outParamCount = 0L;

public RL_11e68f59508e412eaf5b78801dd06b0e queryResGetFoliosSAE_outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
public long queryResGetFoliosSAE_outParamCount = 0L;

public lcvServiceGetDataForTheHomepage(string inParamCurrentLocale, RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles, string inParami_GetUserId) {
this.inParamCurrentLocale = inParamCurrentLocale;
this.inParamUserApplicationRoles = inParamUserApplicationRoles;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceGetDataForTheHomepage : VarsBag {
public long outParamInvoicesData = 0L;

public long outParamFoliosData = 0L;

public long outParamRequisitionsData = 0L;

public lcoServiceGetDataForTheHomepage() {
}
}
/// <summary>
/// Action <code>ServiceGetDataForTheHomepage</code> that represents the Service Studio action
///  <code>ServiceGetDataForTheHomepage</code> <p> Description: </p>
/// </summary>
public static async Task<(long,long,long)> ActionServiceGetDataForTheHomepage(IRequestContext requestContext,string inParamCurrentLocale,RC_4eba0035378aebca97affd4e1528379d inParamUserApplicationRoles,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamInvoicesData = default;
long outParamFoliosData = default;
long outParamRequisitionsData = default;
lcoServiceGetDataForTheHomepage result = new lcoServiceGetDataForTheHomepage();
lcvServiceGetDataForTheHomepage localVars = new lcvServiceGetDataForTheHomepage(inParamCurrentLocale, inParamUserApplicationRoles, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceGetDataForTheHomepage", "13cf3f17-bcd4-4c94-9262-750954933228"))
using (activitySource.CreateServiceActionActivity("ServiceGetDataForTheHomepage")){
// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,(((localVars.inParamCurrentLocale=="")) ? ("es-MX") : (localVars.inParamCurrentLocale)),cancellationToken);

// Query datasetGetInvoices
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoices_maxRecords = 0;
int datasetGetInvoices_startIndex = 0;(localVars.queryResGetInvoices_outParamList,localVars.queryResGetInvoices_outParamCount) = await FuncActionServiceGetDataForTheHomepage.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.inParami_GetUserId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.inParamUserApplicationRoles.ssAppRolesListText,localVars.inParamUserApplicationRoles.ssCorporativoRegionId,localVars.inParamUserApplicationRoles.ssIsCorporativoCxP,localVars.inParamUserApplicationRoles.ssTelcelDirectionsListText,cancellationToken);

// InvoicesData = GetInvoices.List.Current.Count
result.outParamInvoicesData=localVars.queryResGetInvoices_outParamList.CurrentRec.ssCount;
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionServiceGetDataForTheHomepage.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,localVars.inParami_GetUserId,cancellationToken);

// UserRolesList = GetRoleConcept.List
localVars.varLcUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
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
localVars.varLcAppRoleListText=((localVars.varLcAppRoleListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId));

// EntraRolesListText = EntraRolesListText + "," + GetRoleConcept.List.Current.User_Extended_Internal.EntraRoleId
localVars.varLcEntraRolesListText=((localVars.varLcEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId));
localVars.queryResGetRoleConcept_outParamList.Advance();
}

} finally {
localVars.queryResGetRoleConcept_outParamList.EndIteration();
}

// GetUserEntraRoleName
localVars.resGetUserEntraRoleName.outParamo_EntraRoleName = await Actions.ActionGetUserEntraRoleName(requestContext,"",cancellationToken);

// Query datasetGetFoliosSAE
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFoliosSAE_maxRecords = 0;
int datasetGetFoliosSAE_startIndex = 0;(localVars.queryResGetFoliosSAE_outParamList,localVars.queryResGetFoliosSAE_outParamCount) = await FuncActionServiceGetDataForTheHomepage.datasetGetFoliosSAE(requestContext,datasetGetFoliosSAE_maxRecords,datasetGetFoliosSAE_startIndex,IterationMultiplicity.Never,localVars.varLcAppRoleListText,localVars.varLcEntraRolesListText,(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken)),(await Functions.ActionGetUserDepartmentId(requestContext,"",cancellationToken)),(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.inParami_GetUserId,cancellationToken);

// Query datasetGetRequisitions
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitions_maxRecords = 0;
int datasetGetRequisitions_startIndex = 0;(localVars.queryResGetRequisitions_outParamList,localVars.queryResGetRequisitions_outParamCount) = await FuncActionServiceGetDataForTheHomepage.datasetGetRequisitions(requestContext,datasetGetRequisitions_maxRecords,datasetGetRequisitions_startIndex,IterationMultiplicity.Never,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.inParami_GetUserId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.inParamUserApplicationRoles.ssAppRolesListText,localVars.inParamUserApplicationRoles.ssCorporativoRegionId,localVars.inParamUserApplicationRoles.ssIsCorporativoCxP,localVars.inParamUserApplicationRoles.ssTelcelDirectionsListText,cancellationToken);

// FoliosData = GetFoliosSAE.List.Current.Count
result.outParamFoliosData=localVars.queryResGetFoliosSAE_outParamList.CurrentRec.ssCount;

// RequisitionsData = GetRequisitions.Count
result.outParamRequisitionsData=localVars.queryResGetRequisitions_outParamCount;
} //close CreateActionActivity using block
} // try

finally {
outParamInvoicesData = result.outParamInvoicesData;
outParamFoliosData = result.outParamFoliosData;
outParamRequisitionsData = result.outParamRequisitionsData;
} // inner-finally
RETURN_STATEMENT:
return (outParamInvoicesData,outParamFoliosData,outParamRequisitionsData);
}

        public static class FuncActionServiceGetDataForTheHomepage {
            
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
// Query Function "GetRoleConcept" BXR4GZHb7kqUmwSIngXj+g of Action "ServiceGetDataForTheHomepage"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetDataForTheHomepage.GetRoleConcept", "19787405-db91-4aee-949b-04889e05e3fa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetDataForTheHomepage.GetRoleConcept", "19787405-db91-4aee-949b-04889e05e3fa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.Fz_PE9S8lEySYnUJVJMyKA/NodesNotShownInESpaceTree.BXR4GZHb7kqUmwSIngXj+g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole38\".\"code\" o1, \"enapplicationrole38\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept14\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal86\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal86\" Inner JOIN {User} \"enuser143\" ON (\"enuser_extended_internal86\".\"id\" = \"enuser143\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole42\" ON (\"enuser_extended_internal86\".\"jobtitle\" = \"enentrarole42\".\"rolename\"))  Left JOIN {Region} \"enregion66\" ON (\"enuser_extended_internal86\".\"regionid\" = \"enregion66\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept14\" ON (\"enentrarole42\".\"id\" = \"enroleconcept14\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole38\" ON (\"enroleconcept14\".\"applicationroleid\" = \"enapplicationrole38\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser143\".\"id\" = @qpusUser_Id) AND (\"enuser143\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser143\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept14\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetDataForTheHomepage.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetDataForTheHomepage.GetRoleConcept.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoices" XfANuKKMXk61HPuFfGquJA of Action "ServiceGetDataForTheHomepage"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_RegionId,string qpusi_GetUserId,bool qpboIsSegmentationCorporativo,string qpteAppRolesListText,long qpreCorporativoRegionId,bool qpboIsCorporativoCxP,string qpteTelcelDirectionsListText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetDataForTheHomepage.GetInvoices", "b80df05d-8ca2-4e5e-b51c-fb857c6aae24");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetDataForTheHomepage.GetInvoices", "b80df05d-8ca2-4e5e-b51c-fb857c6aae24", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.Fz_PE9S8lEySYnUJVJMyKA/NodesNotShownInESpaceTree.XfANuKKMXk61HPuFfGquJA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"eninvoice80\".\"id\") \"count\"");
fromBuilder.Append(" FROM ((((((({Invoice} \"eninvoice80\" Left JOIN {InvoiceApproval} \"eninvoiceapproval25\" ON (\"eninvoice80\".\"id\" = \"eninvoiceapproval25\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel26\" ON ((\"eninvoiceapprovallevel26\".\"invoiceapprovalid\" = \"eninvoiceapproval25\".\"id\") AND ((\"eninvoiceapprovallevel26\".\"approvalstatusid\" <> ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel26\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel26\".\"assignedto\" = @qpusi_GetUserId) AND (\"eninvoiceapprovallevel26\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel26\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((CASE WHEN char_length(caseaccent_normalize(cast(\"eninvoiceapprovallevel26\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"eninvoiceapprovallevel26\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRolesListText collate \"default\"))-1) END)) <> (-1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel26\".\"approvedby\" = @qpusi_GetUserId) AND (\"eninvoiceapprovallevel26\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel26\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel26\".\"requesttomodifyby\" = @qpusi_GetUserId) AND (\"eninvoiceapprovallevel26\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel26\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel26\".\"canceledby\" = @qpusi_GetUserId) AND (\"eninvoiceapprovallevel26\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel26\".\"canceledby\" IS NULL)");
}
fromBuilder.Append("))))  Left JOIN {ApplicationRole} \"enapplicationrole39\" ON (\"eninvoiceapprovallevel26\".\"applicationroleid\" = \"enapplicationrole39\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus3\" ON (\"eninvoiceapprovallevel26\".\"approvalstatusid\" = \"enapprovalstatus3\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting16\" ON (\"eninvoice80\".\"id\" = \"eninvoiceaccounting16\".\"invoiceid\"))  Left JOIN {User} \"enuser144\" ON (\"eninvoiceapprovallevel26\".\"assignedto\" = \"enuser144\".\"id\"))  Left JOIN {Requisition} \"enrequisition73\" ON (\"eninvoice80\".\"requisitionid\" = \"enrequisition73\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoice80\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") AND ((CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpboIsSegmentationCorporativo = 1) THEN (CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpteTelcelDirectionsListText = '') THEN 1 ELSE (CASE WHEN ((((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition73\".\"regionid\" = @qpreCorporativoRegionId) AND (\"enrequisition73\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition73\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition73\".\"accountingregionid\" = @qpreCorporativoRegionId) AND (\"enrequisition73\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition73\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition73\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition73\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition73\".\"regionid\" <> @qpreCorporativoRegionId) OR (\"enrequisition73\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition73\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusi_GetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel26\".\"assignedto\" = @qpusi_GetUserId) AND (\"eninvoiceapprovallevel26\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel26\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) ELSE 1 END) ELSE 1 END) ELSE (CASE WHEN ((");
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition73\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition73\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition73\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel26\".\"id\" IS NOT NULL)) OR ");
if ((qpusi_GetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel26\".\"assignedto\" = @qpusi_GetUserId) AND (\"eninvoiceapprovallevel26\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel26\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1) AND (\"enapprovalstatus3\".\"id\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
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
RL_11e68f59508e412eaf5b78801dd06b0e outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetDataForTheHomepage.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_11e68f59508e412eaf5b78801dd06b0e _tmp = new RL_11e68f59508e412eaf5b78801dd06b0e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetDataForTheHomepage.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_11e68f59508e412eaf5b78801dd06b0e)_tmp;
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

private static async Task<RC_11c2ac4c5bdce01960ee8371ad40d262> datasetGetRequisitionsReadDbAsync(RC_11c2ac4c5bdce01960ee8371ad40d262 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitions" vhRr7nbr50ioU_OLfDCzWQ of Action "ServiceGetDataForTheHomepage"
public static async Task<(RL_1f3e9ea72dc7b010c56ee9146ee277c5,long)> datasetGetRequisitions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_RegionId,string qpusi_GetUserId,bool qpboIsSegmentationCorporativo,string qpteAppRolesListText,long qpreRequisition_RegionId1,bool qpboIsCorporativoCxP,string qpteTelcelDirectionsListText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetDataForTheHomepage.GetRequisitions", "ee6b14be-eb76-48e7-a853-f38b7c30b359");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetDataForTheHomepage.GetRequisitions", "ee6b14be-eb76-48e7-a853-f38b7c30b359", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
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
selectBuilder.Append("/* /ServiceAPIMethods.Fz_PE9S8lEySYnUJVJMyKA/NodesNotShownInESpaceTree.vhRr7nbr50ioU_OLfDCzWQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93");
fromBuilder.Append(" FROM (({Requisition} \"enrequisition74\" Left JOIN {RequisitionApproval} \"enrequisitionapproval25\" ON (\"enrequisitionapproval25\".\"requisitionid\" = \"enrequisition74\".\"id\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel22\" ON ((\"enrequisitionapprovallevel22\".\"requisitionapprovalid\" = \"enrequisitionapproval25\".\"id\") AND ((\"enrequisitionapprovallevel22\".\"approvalstatusid\" <> ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"enrequisitionapprovallevel22\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel22\".\"assignedto\" = @qpusi_GetUserId) AND (\"enrequisitionapprovallevel22\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel22\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((CASE WHEN char_length(caseaccent_normalize(cast(\"enrequisitionapprovallevel22\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enrequisitionapprovallevel22\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRolesListText collate \"default\"))-1) END)) <> (-1)) OR (@qpboIsCorporativoCxP = 1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel22\".\"approvedby\" = @qpusi_GetUserId) AND (\"enrequisitionapprovallevel22\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel22\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel22\".\"requesttomodifyby\" = @qpusi_GetUserId) AND (\"enrequisitionapprovallevel22\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel22\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusi_GetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel22\".\"canceledby\" = @qpusi_GetUserId) AND (\"enrequisitionapprovallevel22\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel22\".\"canceledby\" IS NULL)");
}
fromBuilder.Append(")))) ");
whereBuilder.Append(" WHERE ((((((((NOT (@qpboIsSegmentationCorporativo = 1)) OR (NOT (@qpboIsCorporativoCxP = 1))) OR (@qpteTelcelDirectionsListText = '')) OR (");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreRequisition_RegionId1 != 0) {
whereBuilder.Append("((\"enrequisition74\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition74\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId1);
} else {
whereBuilder.Append("(\"enrequisition74\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition74\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition74\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1)))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreRequisition_RegionId1 != 0) {
whereBuilder.Append("((\"enrequisition74\".\"regionid\" <> @qpreRequisition_RegionId) OR (\"enrequisition74\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId1);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId1);
} else {
whereBuilder.Append("(\"enrequisition74\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusi_GetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel22\".\"assignedto\" = @qpusi_GetUserId) AND (\"enrequisitionapprovallevel22\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel22\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") AND (((");
if ((qpusi_GetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisition74\".\"applicantid\" = @qpusi_GetUserId) AND (\"enrequisition74\".\"applicantid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
whereBuilder.Append("(\"enrequisition74\".\"applicantid\" IS NULL)");
}
whereBuilder.Append(" OR ((\"enrequisition74\".\"requisitionstatusid\" <> ");
whereBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId);
whereBuilder.Append(") AND ((@qpboIsCorporativoCxP = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition74\".\"regionid\" = @qpreRequisition_RegionId1) AND (\"enrequisition74\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId1", DbType.Int64, qpreRequisition_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId1", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition74\".\"regionid\" IS NULL)");
}
whereBuilder.Append("))) OR ");
if ((qpusi_GetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel22\".\"assignedto\" = @qpusi_GetUserId) AND (\"enrequisitionapprovallevel22\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel22\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboIsCorporativoCxP = 1))) AND (((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
if ((qpusi_GetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisition74\".\"applicantid\" = @qpusi_GetUserId) AND (\"enrequisition74\".\"applicantid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
whereBuilder.Append("(\"enrequisition74\".\"applicantid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if ((qpusi_GetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel22\".\"assignedto\" = @qpusi_GetUserId) AND (\"enrequisitionapprovallevel22\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel22\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") OR (");
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition74\".\"regionid\" = @qpreRequisition_RegionId1) AND (\"enrequisition74\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId1", DbType.Int64, qpreRequisition_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId1", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition74\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel22\".\"id\" IS NOT NULL))) OR (@qpboIsCorporativoCxP = 1))) AND (\"enrequisitionapprovallevel22\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
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
RL_1f3e9ea72dc7b010c56ee9146ee277c5 outParamList = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetDataForTheHomepage.GetRequisitions.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetDataForTheHomepage.GetRequisitions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f3e9ea72dc7b010c56ee9146ee277c5 _tmp = new RL_1f3e9ea72dc7b010c56ee9146ee277c5();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetDataForTheHomepage.GetRequisitions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f3e9ea72dc7b010c56ee9146ee277c5)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query ServiceGetDataForTheHomepage.GetRequisitions.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetFoliosSAE" l3FP88Tu0EeFnS8x85jdGA of Action "ServiceGetDataForTheHomepage"
public static async Task<(RL_11e68f59508e412eaf5b78801dd06b0e,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteAppRoleListText,string qpteEntraRolesListText,bool qpboGetIsCorporativo,long qpdeFolioApprovalLevel_DepartmentId,long qpreGetUserRegionId,string qpusFolioApprovalLevel_AssignedTo,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceGetDataForTheHomepage.GetFoliosSAE", "f34f7197-eec4-47d0-859d-2f31f398dd18");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceGetDataForTheHomepage.GetFoliosSAE", "f34f7197-eec4-47d0-859d-2f31f398dd18", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.Fz_PE9S8lEySYnUJVJMyKA/NodesNotShownInESpaceTree.l3FP88Tu0EeFnS8x85jdGA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Count(\"enfolio60\".\"id\") \"count\"");
fromBuilder.Append(" FROM (((({Folio} \"enfolio60\" Left JOIN {FolioApproval} \"enfolioapproval34\" ON (\"enfolio60\".\"id\" = \"enfolioapproval34\".\"folioid\"))  Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel31\" ON (\"enfolioapproval34\".\"id\" = \"enfolioapprovallevel31\".\"folioapprovalid\"))  Left JOIN {OrderMain} \"enordermain70\" ON (\"enfolio60\".\"orderid\" = \"enordermain70\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus4\" ON (\"enfolioapprovallevel31\".\"approvalstatusid\" = \"enapprovalstatus4\".\"id\")) ");
whereBuilder.Append(" WHERE (((\"enfolioapprovallevel31\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") OR (\"enfolioapprovallevel31\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
whereBuilder.Append(")) AND ((CASE WHEN (\"enfolioapprovallevel31\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel31\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel31\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enfolioapprovallevel31\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel31\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel31\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel31\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel31\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain70\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain70\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain70\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval34\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval34\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval34\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (@qpboGetIsCorporativo = 1))) AND ((\"enfolioapprovallevel31\".\"departmentid\" IS NULL) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel31\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel31\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel31\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1)) AND (\"enapprovalstatus4\".\"id\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
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
RL_11e68f59508e412eaf5b78801dd06b0e outParamList = new RL_11e68f59508e412eaf5b78801dd06b0e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceGetDataForTheHomepage.GetFoliosSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_11e68f59508e412eaf5b78801dd06b0e _tmp = new RL_11e68f59508e412eaf5b78801dd06b0e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceGetDataForTheHomepage.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_11e68f59508e412eaf5b78801dd06b0e)_tmp;
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
