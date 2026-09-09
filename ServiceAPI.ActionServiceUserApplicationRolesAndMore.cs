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

    public class S4PIServiceUserApplicationRolesAndMoreInput {
[JsonProperty("i_GetUserId")]
public string inParami_GetUserId;
public S4PIServiceUserApplicationRolesAndMoreInput(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}

}

public class S4PIServiceUserApplicationRolesAndMoreOutput {
[JsonProperty("UserRolesList")]
public JSONST_e39617f0f094a322d4157f34fe424dadStructure[] outParamUserRolesList;
[JsonProperty("IsCorporativoCxP")]
public bool outParamIsCorporativoCxP;
[JsonProperty("AppRolesListText")]
public string outParamAppRolesListText;
[JsonProperty("TelcelDirectionsListText")]
public string outParamTelcelDirectionsListText;
[JsonProperty("IsSupervisor")]
public bool outParamIsSupervisor;
[JsonProperty("IsAnalistaCxP")]
public bool outParamIsAnalistaCxP;
[JsonProperty("CorporativoRegionId")]
public long outParamCorporativoRegionId;
[JsonProperty("TelcelDirectionsListTextForQuery")]
public string outParamTelcelDirectionsListTextForQuery;
[JsonProperty("UserDepartmentId")]
public long outParamUserDepartmentId;
[JsonProperty("o_RegionId")]
public long outParamo_RegionId;
[JsonProperty("o_TelcelDirectionId")]
public long outParamo_TelcelDirectionId;
public S4PIServiceUserApplicationRolesAndMoreOutput(JSONST_e39617f0f094a322d4157f34fe424dadStructure[] outParamUserRolesList, bool outParamIsCorporativoCxP, string outParamAppRolesListText, string outParamTelcelDirectionsListText, bool outParamIsSupervisor, bool outParamIsAnalistaCxP, long outParamCorporativoRegionId, string outParamTelcelDirectionsListTextForQuery, long outParamUserDepartmentId, long outParamo_RegionId, long outParamo_TelcelDirectionId) {
this.outParamUserRolesList = outParamUserRolesList;
this.outParamIsCorporativoCxP = outParamIsCorporativoCxP;
this.outParamAppRolesListText = outParamAppRolesListText;
this.outParamTelcelDirectionsListText = outParamTelcelDirectionsListText;
this.outParamIsSupervisor = outParamIsSupervisor;
this.outParamIsAnalistaCxP = outParamIsAnalistaCxP;
this.outParamCorporativoRegionId = outParamCorporativoRegionId;
this.outParamTelcelDirectionsListTextForQuery = outParamTelcelDirectionsListTextForQuery;
this.outParamUserDepartmentId = outParamUserDepartmentId;
this.outParamo_RegionId = outParamo_RegionId;
this.outParamo_TelcelDirectionId = outParamo_TelcelDirectionId;
}

}

[HttpPost()]
[Route("serviceapi/serviceuserapplicationrolesandmore")]
[TypeFilter(typeof(OnRequestFilter))]
[TypeFilter(typeof(OnResponseFilter))]
[RESTServiceAPIMethodPropertiesAttribute(Name = "ServiceUserApplicationRolesAndMore", IsRequestBinary = false, IsResponseBinary = false)]
public async Task<IActionResult> ServiceAPIServiceUserApplicationRolesAndMore(CancellationToken cancellationToken) {return await EndpointAsync<S4PIServiceUserApplicationRolesAndMoreInput, S4PIServiceUserApplicationRolesAndMoreOutput>(static async(serviceActionsApiController, behaviorsConfiguration, serviceActionInput, context, ctx) => {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList;
bool outParamIsCorporativoCxP;
string outParamAppRolesListText;
string outParamTelcelDirectionsListText;
bool outParamIsSupervisor;
bool outParamIsAnalistaCxP;
long outParamCorporativoRegionId;
string outParamTelcelDirectionsListTextForQuery;
long outParamUserDepartmentId;
long outParamo_RegionId;
long outParamo_TelcelDirectionId;
S4PIServiceUserApplicationRolesAndMoreInput inputs = serviceActionInput.InputParameters;
System.Collections.Generic.Dictionary<string,string[]> validationErrors = new System.Collections.Generic.Dictionary<string,string[]>();
if((inputs.inParami_GetUserId == null)) {
validationErrors["i_GetUserId"]=new string[] {"The i_GetUserId mandatory parameter is missing in the request."};
}

if(validationErrors.Any()) {
throw RestExposeErrorsHelper.BadRequest(validationErrors);
}

ctx.ThrowIfCancellationRequested();
(outParamUserRolesList,outParamIsCorporativoCxP,outParamAppRolesListText,outParamTelcelDirectionsListText,outParamIsSupervisor,outParamIsAnalistaCxP,outParamCorporativoRegionId,outParamTelcelDirectionsListTextForQuery,outParamUserDepartmentId,outParamo_RegionId,outParamo_TelcelDirectionId) = await Flows.ActionServiceUserApplicationRolesAndMore(context,inputs.inParami_GetUserId,ctx);

return new S4PIServiceUserApplicationRolesAndMoreOutput(RL_97ac86b141c7934fd96d3cf71793066e.ToArray(outParamUserRolesList, (str) => JSONST_e39617f0f094a322d4157f34fe424dadStructure.FromStructure(str, behaviorsConfiguration)), outParamIsCorporativoCxP, outParamAppRolesListText, outParamTelcelDirectionsListText, outParamIsSupervisor, outParamIsAnalistaCxP, outParamCorporativoRegionId, outParamTelcelDirectionsListTextForQuery, outParamUserDepartmentId, outParamo_RegionId, outParamo_TelcelDirectionId);
}
, cancellationToken);
}



    public partial class Flows {
        public class lcvServiceUserApplicationRolesAndMore : VarsBag {
public string inParami_GetUserId;
public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public int resFindIsCorporativoCxP_outParamPosition = 0;

public Actions.lcoGetUserDepartmentId resGetUserDepartmentId =  new Actions.lcoGetUserDepartmentId();
public int resFindIsSupervisor_outParamPosition = 0;

public int resFindIsAnalistaCxP_outParamPosition = 0;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public Actions.lcoGetUserTelcelDirectionId resGetUserTelcelDirectionId =  new Actions.lcoGetUserTelcelDirectionId();
public lcvServiceUserApplicationRolesAndMore(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoServiceUserApplicationRolesAndMore : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public bool outParamIsCorporativoCxP = false;

public string outParamAppRolesListText = "";

public string outParamTelcelDirectionsListText = "";

public bool outParamIsSupervisor = false;

public bool outParamIsAnalistaCxP = false;

public long outParamCorporativoRegionId = 0L;

public string outParamTelcelDirectionsListTextForQuery = "";

public long outParamUserDepartmentId = 0L;

public long outParamo_RegionId = 0L;

public long outParamo_TelcelDirectionId = 0L;

public lcoServiceUserApplicationRolesAndMore() {
}
}
/// <summary>
/// Action <code>ServiceUserApplicationRolesAndMore</code> that represents the Service Studio action
///  <code>ServiceUserApplicationRolesAndMore</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_97ac86b141c7934fd96d3cf71793066e,bool,string,string,bool,bool,long,string,long,long,long)> ActionServiceUserApplicationRolesAndMore(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
bool outParamIsCorporativoCxP = default;
string outParamAppRolesListText = default;
string outParamTelcelDirectionsListText = default;
bool outParamIsSupervisor = default;
bool outParamIsAnalistaCxP = default;
long outParamCorporativoRegionId = default;
string outParamTelcelDirectionsListTextForQuery = default;
long outParamUserDepartmentId = default;
long outParamo_RegionId = default;
long outParamo_TelcelDirectionId = default;
lcoServiceUserApplicationRolesAndMore result = new lcoServiceUserApplicationRolesAndMore();
lcvServiceUserApplicationRolesAndMore localVars = new lcvServiceUserApplicationRolesAndMore(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServiceActionMetric("ServiceUserApplicationRolesAndMore", "5bd2a501-f1ed-4444-85ec-a556e1521851"))
using (activitySource.CreateServiceActionActivity("ServiceUserApplicationRolesAndMore")){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionServiceUserApplicationRolesAndMore.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),localVars.inParami_GetUserId,cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// GetUserDepartmentId
localVars.resGetUserDepartmentId.outParamo_DepartmentId = await Actions.ActionGetUserDepartmentId(requestContext,"",cancellationToken);

// GetUserRegionId
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

// GetUserTelcelDirectionId
localVars.resGetUserTelcelDirectionId.outParamo_TelcelDirectionId = await Actions.ActionGetUserTelcelDirectionId(requestContext,"",cancellationToken);

// UserDepartmentId = GetUserDepartmentId.o_DepartmentId
result.outParamUserDepartmentId=localVars.resGetUserDepartmentId.outParamo_DepartmentId;

// o_RegionId = GetUserRegionId.o_RegionId
result.outParamo_RegionId=localVars.resGetUserRegionId.outParamo_RegionId;

// o_TelcelDirectionId = GetUserTelcelDirectionId.o_TelcelDirectionId
result.outParamo_TelcelDirectionId=localVars.resGetUserTelcelDirectionId.outParamo_TelcelDirectionId;
// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// FindIsSupervisor
localVars.resFindIsSupervisor_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => (((p.ssENRegion.ssCommissionRegion=="R0")||(p.ssENRegion.ssCommissionRegion=="R9"))&&(BuiltInFunction.IndexSC (p.ssENApplicationRole.ssCode, "SUPERVISOR", 0, false, true)!=(-1))),cancellationToken);

// FindIsAnalistaCxP
localVars.resFindIsAnalistaCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((BuiltInFunction.IndexSC (p.ssENApplicationRole.ssCode, "ANALISTA", 0, false, true)!=(-1))&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// IsSupervisor = FindIsSupervisor.Position <> -1
result.outParamIsSupervisor=(localVars.resFindIsSupervisor_outParamPosition!=(-1));

// CorporativoRegionId = GetMR00RegionId()
result.outParamCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));

// IsAnalistaCxP = FindIsAnalistaCxP.Position <> -1
result.outParamIsAnalistaCxP=(localVars.resFindIsAnalistaCxP_outParamPosition!=(-1));
// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// AppRolesListText = AppRolesListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamAppRolesListText=((result.outParamAppRolesListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
result.outParamUserRolesList.Advance();
}

} finally {
result.outParamUserRolesList.EndIteration();
}

if((result.outParamIsCorporativoCxP)) {
// Query datasetGetSegmentAccGroupTelcelDirectionsByDepartment
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords = 0;
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncActionServiceUserApplicationRolesAndMore.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,"",cancellationToken)),cancellationToken);

// Foreach GetSegmentAccGroupTelcelDirectionsByDepartment.List
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.StartIteration();
try {while (!((localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Eof))) {
// TelcelDirectionsListText = TelcelDirectionsListText + "," + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId + ","
result.outParamTelcelDirectionsListText=(((result.outParamTelcelDirectionsListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId))+",");

// TelcelDirectionsListTextForQuery = TelcelDirectionsListTextForQuery + ", " + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId
result.outParamTelcelDirectionsListTextForQuery=((result.outParamTelcelDirectionsListTextForQuery+", ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId));
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Advance();
}

} finally {
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.EndIteration();
}

// TelcelDirectionsListTextForQuery = Substr
result.outParamTelcelDirectionsListTextForQuery=BuiltInFunction.SubstrSC (result.outParamTelcelDirectionsListTextForQuery, 1, BuiltInFunction.LengthSC (result.outParamTelcelDirectionsListTextForQuery));
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
outParamAppRolesListText = result.outParamAppRolesListText;
outParamTelcelDirectionsListText = result.outParamTelcelDirectionsListText;
outParamIsSupervisor = result.outParamIsSupervisor;
outParamIsAnalistaCxP = result.outParamIsAnalistaCxP;
outParamCorporativoRegionId = result.outParamCorporativoRegionId;
outParamTelcelDirectionsListTextForQuery = result.outParamTelcelDirectionsListTextForQuery;
outParamUserDepartmentId = result.outParamUserDepartmentId;
outParamo_RegionId = result.outParamo_RegionId;
outParamo_TelcelDirectionId = result.outParamo_TelcelDirectionId;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamIsCorporativoCxP,outParamAppRolesListText,outParamTelcelDirectionsListText,outParamIsSupervisor,outParamIsAnalistaCxP,outParamCorporativoRegionId,outParamTelcelDirectionsListTextForQuery,outParamUserDepartmentId,outParamo_RegionId,outParamo_TelcelDirectionId);
}

        public static class FuncActionServiceUserApplicationRolesAndMore {
            
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
// Query Function "GetRoleConcept" PKGFkpz2qU2j4pVxAg_nzg of Action "ServiceUserApplicationRolesAndMore"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,string qpusi_GetUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceUserApplicationRolesAndMore.GetRoleConcept", "9285a13c-f69c-4da9-a3e2-9571020fe7ce");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceUserApplicationRolesAndMore.GetRoleConcept", "9285a13c-f69c-4da9-a3e2-9571020fe7ce", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.AaXSW+3xRESF7KVW4VIYUQ/NodesNotShownInESpaceTree.PKGFkpz2qU2j4pVxAg_nzg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole40\".\"code\" o1, \"enapplicationrole40\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole40\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion68\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept15\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal88\" Inner JOIN {User} \"enuser145\" ON (\"enuser_extended_internal88\".\"id\" = \"enuser145\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole43\" ON (\"enuser_extended_internal88\".\"jobtitle\" = \"enentrarole43\".\"rolename\"))  Left JOIN {Region} \"enregion68\" ON (\"enuser_extended_internal88\".\"regionid\" = \"enregion68\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept15\" ON (\"enentrarole43\".\"id\" = \"enroleconcept15\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole40\" ON (\"enroleconcept15\".\"applicationroleid\" = \"enapplicationrole40\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser145\".\"id\" = (CASE WHEN (@qpusi_GetUserId <> '') THEN @qpusi_GetUserId ELSE @qpusGetUserId END)) AND (\"enroleconcept15\".\"conceptid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
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
opt[2] = new BitArray(new bool[] {true, false, false, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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

private static async Task<RC_dbac6e35b37e102dd601262a956066d2> datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync(RC_dbac6e35b37e102dd601262a956066d2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
return rec;
}
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" 4WQvqGQ5_kSHxxKIXOvl2Q of Action "ServiceUserApplicationRolesAndMore"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ServiceUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "a82f64e1-3964-44fe-87c7-12885cebe5d9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ServiceUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "a82f64e1-3964-44fe-87c7-12885cebe5d9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /ServiceAPIMethods.AaXSW+3xRESF7KVW4VIYUQ/NodesNotShownInESpaceTree.4WQvqGQ5_kSHxxKIXOvl2Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir4\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup4\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir4\" ON (\"ensegmentaccgroup4\".\"id\" = \"ensegmentaccgrouptelceldir4\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((trim(\"ensegmentaccgroup4\".\"groupname\")) collate \"default\") like caseaccent_normalize(@qpteSegmentAccGroup_GroupName collate \"default\")) AND (\"ensegmentaccgroup4\".\"isactive\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteSegmentAccGroup_GroupName", DbType.String, qpteSegmentAccGroup_GroupName);
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
RL_4b6f9359ce9887bc6f37c96ecf62266d outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ServiceUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4b6f9359ce9887bc6f37c96ecf62266d _tmp = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
_tmp.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ServiceUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4b6f9359ce9887bc6f37c96ecf62266d)_tmp;
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
