using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel).Namespace);

    public bool varLcl_IsOpenPopUp;
public AggregateRecord<RL_8ded51402e95dd8f74345a43f441735c> ScreenDataSetGetUserDetails;
public ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Model varLcGetEntraManager;
public ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel() {
}



    public ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel(bool varLcl_IsOpenPopUp, AggregateRecord<RL_8ded51402e95dd8f74345a43f441735c> ScreenDataSetGetUserDetails, ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetEntraManager_Model varLcGetEntraManager, ConectaProveedores_a_Common_WB_InternalUserProfile_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_IsOpenPopUp", "GetUserDetails", "GetEntraManager", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcl_IsOpenPopUp", "ScreenDataSetGetUserDetails", "varLcGetEntraManager", "varLcGetUserApplicationRoles", "clientVariables"});
this.varLcl_IsOpenPopUp = varLcl_IsOpenPopUp;
this.ScreenDataSetGetUserDetails = ScreenDataSetGetUserDetails;
this.varLcGetEntraManager = varLcGetEntraManager;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_3435fb4b7e2feceb28dc5478c72a6c4b> datasetGetUserDetailsReadDbAsync(RC_3435fb4b7e2feceb28dc5478c72a6c4b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENDepartment.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserDetails" qEMhU+yImEe0xdO_R51zuw of Action "WB_InternalUserProfile"
public static async Task<(RL_8ded51402e95dd8f74345a43f441735c,long)> datasetGetUserDetails(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.WB_InternalUserProfile.GetUserDetails", "532143a8-88ec-4798-b4c5-d3bf479d73bb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("WB_InternalUserProfile","a_Common.WB_InternalUserProfile.GetUserDetails");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.fBgMNMZ7Mkm7m9PTTjsWnQ/ScreenDataSets.qEMhU+yImEe0xdO_R51zuw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole45\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"endepartment8\".\"name\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enregion85\".\"name\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enuser153\".\"name\" o28, \"enuser153\".\"email\" o29, NULL o30, NULL o31, NULL o32, \"enuser_extended_internal93\".\"employeenumber\" o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, \"enuser_extended_internal93\".\"jobtitle\" o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, \"enuserextension70\".\"correspondentexternalemail\" o63, NULL o64");
fromBuilder.Append(" FROM (((((({User_Extended_Internal} \"enuser_extended_internal93\" Inner JOIN {Department} \"endepartment8\" ON (\"enuser_extended_internal93\".\"departmentid\" = \"endepartment8\".\"id\"))  Inner JOIN {Region} \"enregion85\" ON (\"enuser_extended_internal93\".\"regionid\" = \"enregion85\".\"id\"))  Right JOIN {User} \"enuser153\" ON (\"enuser153\".\"id\" = \"enuser_extended_internal93\".\"id\"))  Left JOIN {UserApplicationRole} \"enuserapplicationrole20\" ON (\"enuser153\".\"id\" = \"enuserapplicationrole20\".\"userid\"))  Left JOIN {ApplicationRole} \"enapplicationrole45\" ON (\"enuserapplicationrole20\".\"applicationroleid\" = \"enapplicationrole45\".\"id\"))  Left JOIN {UserExtension} \"enuserextension70\" ON (\"enuser153\".\"id\" = \"enuserextension70\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser153\".\"id\" = @qpusUser_Id) AND (\"enuser153\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser153\".\"id\" IS NULL)");
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
RL_8ded51402e95dd8f74345a43f441735c outParamList = new RL_8ded51402e95dd8f74345a43f441735c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserDetailsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.WB_InternalUserProfile.GetUserDetails.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8ded51402e95dd8f74345a43f441735c _tmp = new RL_8ded51402e95dd8f74345a43f441735c();
_tmp.AlternateReadDbMethodAsync = datasetGetUserDetailsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.WB_InternalUserProfile.GetUserDetails.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8ded51402e95dd8f74345a43f441735c)_tmp;
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


    public class lcvGetEntraManager : VarsBag {
public ST_d32097d2629a99529d77b865dae9fb0cStructure resGetUserManager_outParamResponse = new ST_d32097d2629a99529d77b865dae9fb0cStructure();
public ST_38509e9fbd36a9b928c2f4e34a1342aeStructure resGetUserManager_outParamResult = new ST_38509e9fbd36a9b928c2f4e34a1342aeStructure();

public lcvGetEntraManager() {
}
}
public class lcoGetEntraManager : VarsBag {
public string outParamManagerName = "";

public lcoGetEntraManager() {
}
}
/// <summary>
/// Action <code>GetEntraManager</code> that represents the Service Studio action
///  <code>GetEntraManager</code> <p> Description: </p>
/// </summary>
public async Task<string> DataActionGetEntraManager(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamManagerName = default;
lcoGetEntraManager result = new lcoGetEntraManager();
lcvGetEntraManager localVars = new lcvGetEntraManager();
ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetEntraManager", "c2f1cf9d-575c-49db-a120-ebf9d91ddbda"))
using (activitySource.CreateScreenDataActionActivity("WB_InternalUserProfile", "GetEntraManager")){
// GetUserManager
(localVars.resGetUserManager_outParamResponse,localVars.resGetUserManager_outParamResult) = await Actions.ActionGetUserManager(requestContext,(((ScreenDataSetGetUserDetails.List.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail!="")) ? (ScreenDataSetGetUserDetails.List.CurrentRec.ssENUserExtension.ssCorrespondentExternalEmail) : (ScreenDataSetGetUserDetails.List.CurrentRec.ssENUser.ssEmail)),cancellationToken);

// ManagerName = GetUserManager.Response.DisplayName
result.outParamManagerName=localVars.resGetUserManager_outParamResponse.ssDisplayName;
} //close CreateActionActivity using block
} // try

finally {
outParamManagerName = result.outParamManagerName;
} // inner-finally
RETURN_STATEMENT:
return outParamManagerName;
}
public class lcvGetUserApplicationRoles : VarsBag {
public RL_a628f44fbe3d61a818adba8c3d848715 queryResGetUserRoles_outParamList = new RL_a628f44fbe3d61a818adba8c3d848715();
public long queryResGetUserRoles_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<RL_97ac86b141c7934fd96d3cf71793066e> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_a_Common_WB_InternalUserProfile_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "c69733f8-4d2d-4b60-85cb-703ab2becba7"))
using (activitySource.CreateScreenDataActionActivity("WB_InternalUserProfile", "GetUserApplicationRoles")){
// Query QueryGetUserRoles
cancellationToken.ThrowIfCancellationRequested();
int QueryGetUserRoles_maxRecords = 0;
int QueryGetUserRoles_startIndex = 0;(localVars.queryResGetUserRoles_outParamList,localVars.queryResGetUserRoles_outParamCount) = await FuncDataActionGetUserApplicationRoles.QueryGetUserRoles(requestContext,QueryGetUserRoles_maxRecords,QueryGetUserRoles_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),2,cancellationToken);

if((localVars.queryResGetUserRoles_outParamList.Empty)) {
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Single,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
return target;
}, cancellationToken));
} else {
// UserRolesList = GetUserRoles.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetUserRoles_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_0a3f9d90df8bd7c726f88030e3651410 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
} // inner-finally
RETURN_STATEMENT:
return outParamUserRolesList;
}


    public static class FuncDataActionGetEntraManager {
}
public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetUserRoles" p3zu3QtBKE+2J5hzEGgo8Q of Action "GetUserApplicationRoles"
public static async Task<(RL_a628f44fbe3d61a818adba8c3d848715,long)> QueryGetUserRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,int qproRoleStatusActiveId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetUserRoles", "ddee7ca7-410b-4f28-b627-9873106828f1");
using var queryActivity = activitySource.CreateSqlQueryActivity("a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetUserRoles", "ddee7ca7-410b-4f28-b627-9873106828f1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityUserApplicationRole = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRole");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityUserApplicationRoleTemp = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRoleTemp");
sqlCmd.CreateParameter("@qpusUserId", DbType.String, qpusUserId);
sqlCmd.CreateParameter("@qproRoleStatusActiveId", DbType.Int32, qproRoleStatusActiveId);
string sql = "";
string advSql = "SELECT  \n    uar.ApplicationRoleId, \n    ar.Name, \n    ar.Code, \n    0 \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRole,"") + " uar \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uar.ApplicationRoleId = ar.Id \nWHERE uar.UserId = @qpusUserId \n  AND uar.RoleStatusId = @qproRoleStatusActiveId \n \nUNION \n \nSELECT  \n    uat.ApplicationRoleId, \n    ar.Name, \n    ar.Code, \n    0 \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRoleTemp,"") + " uat \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uat.ApplicationRoleId = ar.Id \nWHERE uat.UserId = @qpusUserId \n  AND uat.RoleStatusId = @qproRoleStatusActiveId";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_a628f44fbe3d61a818adba8c3d848715 outParamList = new RL_a628f44fbe3d61a818adba8c3d848715();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a628f44fbe3d61a818adba8c3d848715 _tmp = new RL_a628f44fbe3d61a818adba8c3d848715();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a628f44fbe3d61a818adba8c3d848715)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetUserRoles in GetUserApplicationRoles in WB_InternalUserProfile in a_Common in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in WB_InternalUserProfile in a_Common in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in WB_InternalUserProfile in a_Common in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId): " + aqExcep.Message));
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
// Query Function "GetRoleConcept" rLF95Kf4o0WqqLKhrhX55Q of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetRoleConcept", "e47db1ac-f8a7-45a3-aaa8-b2a1ae15f9e5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetRoleConcept", "e47db1ac-f8a7-45a3-aaa8-b2a1ae15f9e5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.fBgMNMZ7Mkm7m9PTTjsWnQ/DataActions.+DOXxi1NYEuFy3A6sr7Lpw/NodesNotShownInESpaceTree.rLF95Kf4o0WqqLKhrhX55Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole46\".\"code\" o1, \"enapplicationrole46\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept17\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal94\" Inner JOIN {User} \"enuser154\" ON (\"enuser_extended_internal94\".\"id\" = \"enuser154\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole46\" ON (\"enuser_extended_internal94\".\"jobtitle\" = \"enentrarole46\".\"rolename\"))  Left JOIN {Region} \"enregion86\" ON (\"enuser_extended_internal94\".\"regionid\" = \"enregion86\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept17\" ON (\"enentrarole46\".\"id\" = \"enroleconcept17\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole46\" ON (\"enroleconcept17\".\"applicationroleid\" = \"enapplicationrole46\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser154\".\"id\" = @qpusUser_Id) AND (\"enuser154\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser154\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept17\".\"conceptid\" = ");
whereBuilder.Append(3
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
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.WB_InternalUserProfile.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
}


}
