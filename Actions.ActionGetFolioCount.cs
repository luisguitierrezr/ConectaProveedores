namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFolioCount : VarsBag {
/// <summary>
/// Variable <code>IsCorporativoCxP</code> that represents the Service Studio Boolean
///  <code>IsCorporativoCxP</code> <p>Description: IsCorporativoCxP.</p>
/// </summary>
public bool varLcIsCorporativoCxP = false;

/// <summary>
/// Variable <code>AppRoleListText</code> that represents the Service Studio Text
///  <code>AppRoleListText</code> <p>Description: ListText</p>
/// </summary>
public string varLcAppRoleListText = "";

/// <summary>
/// Variable <code>UserRolesList</code> that represents the Service Studio UserRoleCodeList
///  <code>UserRolesList</code> <p>Description: List of User Roles.</p>
/// </summary>
public RL_97ac86b141c7934fd96d3cf71793066e varLcUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

/// <summary>
/// Variable <code>CorporativoRegionId</code> that represents the Service Studio RegionIdentifier
///  <code>CorporativoRegionId</code> <p>Description: Region Identifier.</p>
/// </summary>
public long varLcCorporativoRegionId = 0L;

/// <summary>
/// Variable <code>EntraRolesListText</code> that represents the Service Studio Text
///  <code>EntraRolesListText</code> <p>Description: EntraRolesListText.</p>
/// </summary>
public string varLcEntraRolesListText = "";

public RL_b9107f331631f30bcef7fe9d900d99ae queryResGetUserApplicationRoleTempByConcepts_outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
public long queryResGetUserApplicationRoleTempByConcepts_outParamCount = 0L;

public int resFindIsCorporativoCxP_outParamPosition = 0;

public RL_0b9ed344d44b60e0112a22c99132ee6b queryResGetFoliosCount_outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
public long queryResGetFoliosCount_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public lcvGetFolioCount() {
}
}
public class lcoGetFolioCount : VarsBag {
public RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = new RL_95e11a982864fe07082eb4aea44bdce2();

public lcoGetFolioCount() {
}
}
/// <summary>
/// Action <code>GetFolioCount</code> that represents the Service Studio action
///  <code>GetFolioCount</code> <p> Description: </p>
/// </summary>
public static async Task<RL_95e11a982864fe07082eb4aea44bdce2> ActionGetFolioCount(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = default;
lcoGetFolioCount result = new lcoGetFolioCount();
lcvGetFolioCount localVars = new lcvGetFolioCount();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFolioCount", "8f2d8c32-9df6-42ab-93fd-d0e9ed7476b8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFolioCount", "8f2d8c32-9df6-42ab-93fd-d0e9ed7476b8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionGetFolioCount.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetUserApplicationRoleTempByConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempByConcepts_maxRecords = 0;
int datasetGetUserApplicationRoleTempByConcepts_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList,localVars.queryResGetUserApplicationRoleTempByConcepts_outParamCount) = await FuncActionGetFolioCount.datasetGetUserApplicationRoleTempByConcepts(requestContext,datasetGetUserApplicationRoleTempByConcepts_maxRecords,datasetGetUserApplicationRoleTempByConcepts_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
localVars.varLcUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcUserRolesList,(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_3d56036e64426be06ca36c503a3c39e0 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENApplicationRole.ssId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken)),cancellationToken);

// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// GetUserRegionId
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
localVars.varLcIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// CorporativoRegionId = GetMR00RegionId()
localVars.varLcCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));
// Foreach UserRolesList
localVars.varLcUserRolesList.StartIteration();
try {while (!((localVars.varLcUserRolesList.Eof))) {
// AppRoleListText = AppRoleListText + "," + UserRolesList.Current.ApplicationRoleId
localVars.varLcAppRoleListText=((localVars.varLcAppRoleListText+",")+BuiltInFunction.LongIntegerToText(localVars.varLcUserRolesList.CurrentRec.ssApplicationRoleId));
localVars.varLcUserRolesList.Advance();
}

} finally {
localVars.varLcUserRolesList.EndIteration();
}

// Foreach GetUserApplicationRoleTempByConcepts.List
localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList.Eof))) {
// EntraRolesListText = EntraRolesListText + "," + GetUserApplicationRoleTempByConcepts.List.Current.UserApplicationRoleTemp.EntraRoleId
localVars.varLcEntraRolesListText=((localVars.varLcEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList.CurrentRec.ssENUserApplicationRoleTemp.ssEntraRoleId));
localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList.Advance();
}

} finally {
localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList.EndIteration();
}

// Query QueryGetFoliosCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetFoliosCount_maxRecords = 0;
int QueryGetFoliosCount_startIndex = 0;(localVars.queryResGetFoliosCount_outParamList,localVars.queryResGetFoliosCount_outParamCount) = await FuncActionGetFolioCount.QueryGetFoliosCount(requestContext,QueryGetFoliosCount_maxRecords,QueryGetFoliosCount_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.varLcAppRoleListText,localVars.varLcEntraRolesListText,localVars.varLcIsCorporativoCxP,(await Functions.ActionGetUserDepartmentId(requestContext,"",cancellationToken)),cancellationToken);

// HomepageKPI = GetFoliosCount.List
result.outParamHomepageKPI=(await RL_95e11a982864fe07082eb4aea44bdce2.ConvertAsync(localVars.queryResGetFoliosCount_outParamList, new RL_95e11a982864fe07082eb4aea44bdce2(), async (RC_073e413c5402df3d82c2d65d0628594a source, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamHomepageKPI = result.outParamHomepageKPI;
} // inner-finally
RETURN_STATEMENT:
return outParamHomepageKPI;
}

public static class FuncActionGetFolioCount {

private static async Task<RC_3d56036e64426be06ca36c503a3c39e0> datasetGetUserApplicationRoleTempByConceptsReadDbAsync(RC_3d56036e64426be06ca36c503a3c39e0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUserApplicationRoleTemp.Read( r, ref index);
rec.ssENUserApplicationRoleTempByConcept.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleTempByConcepts" 3rmlZjoOpUal4Ik+o_QNJg of Action "GetFolioCount"
public static async Task<(RL_b9107f331631f30bcef7fe9d900d99ae,long)> datasetGetUserApplicationRoleTempByConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolioCount.GetUserApplicationRoleTempByConcepts", "66a5b9de-0e3a-46a5-a5e0-893ea3f40d26");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolioCount.GetUserApplicationRoleTempByConcepts", "66a5b9de-0e3a-46a5-a5e0-893ea3f40d26", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mowtj_adq0KT_dDp7XR2uA/NodesNotShownInESpaceTree.3rmlZjoOpUal4Ik+o_QNJg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole15\".\"id\" o0, \"enapplicationrole15\".\"code\" o1, \"enapplicationrole15\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enuserapplicationroletemp4\".\"entraroleid\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM (({UserApplicationRoleTempByConcept} \"enuserapplicationroletempbyconcept2\" Left JOIN {UserApplicationRoleTemp} \"enuserapplicationroletemp4\" ON (\"enuserapplicationroletempbyconcept2\".\"userapplicationroletempid\" = \"enuserapplicationroletemp4\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole15\" ON (\"enuserapplicationroletempbyconcept2\".\"applicationroleid\" = \"enapplicationrole15\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp4\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp4\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp4\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp4\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enuserapplicationroletempbyconcept2\".\"conceptid\" = ");
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
RL_b9107f331631f30bcef7fe9d900d99ae outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempByConceptsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolioCount.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b9107f331631f30bcef7fe9d900d99ae _tmp = new RL_b9107f331631f30bcef7fe9d900d99ae();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempByConceptsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolioCount.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b9107f331631f30bcef7fe9d900d99ae)_tmp;
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

// Query Function "GetFoliosCount" h21fnN0uAU6bVJe7P88L7Q of Action "GetFolioCount"
public static async Task<(RL_0b9ed344d44b60e0112a22c99132ee6b,long)> QueryGetFoliosCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,int qpapi_NotApprovedStatus,long qprei_RegionId,string qpteAppRoleListText,string qpteEntraRolesListText,bool qpboIsCorporativoCxP,long qpdeGetUserDepartmentId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetFolioCount.GetFoliosCount", "9c5f6d87-2edd-4e01-9b54-97bb3fcf0bed");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetFolioCount.GetFoliosCount", "9c5f6d87-2edd-4e01-9b54-97bb3fcf0bed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityFolioApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("FolioApprovalLevel");
string entityFolioApproval = AppUtils.Instance.RuntimeEntityReplace("FolioApproval");
string entityFolio = AppUtils.Instance.RuntimeEntityReplace("Folio");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityOrderMain = AppUtils.Instance.RuntimeEntityReplace("OrderMain");
sqlCmd.CreateParameter("@qpapi_NotApprovedStatus", DbType.Int32, qpapi_NotApprovedStatus);
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameter("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
sqlCmd.CreateParameter("@qprei_RegionId", DbType.Int64, qprei_RegionId);
sqlCmd.CreateParameter("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameter("@qpdeGetUserDepartmentId", DbType.Int64, qpdeGetUserDepartmentId);
string sql = "";
string advSql = "SELECT  \n    COUNT(fal.Id) AS ApprovalCount, \n    asl.Label AS ApprovalStatusLabel \nFROM \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApprovalLevel,"") + " fal \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolioApproval,"") + " fa ON fal.FolioApprovalId = fa.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityFolio,"") + " fol ON fa.FolioId = fol.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " asl ON fal.ApprovalStatusId = asl.Id \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityOrderMain,"") + " ord ON ord.Id = fol.OrderId \nWHERE \n    ( \n        fal.ApprovalStatusId = @qpapi_NotApprovedStatus \n        AND \n            ( \n                fal.AssignedTo IS NOT NULL \n                AND fal.AssignedTo = @qpusGetUserId \n            ) \n            OR \n            ( \n                fal.AssignedTo IS NULL \n                AND \n                ( \n                    STRPOS(@qpteAppRoleListText, CAST(fal.ApplicationRoleId AS TEXT)) <> 0 OR \n                    STRPOS(@qpteEntraRolesListText, CAST(fal.EntraRoleId AS TEXT)) <> 0 \n                ) \n                AND \n                (ord.DivisionId = @qprei_RegionId OR fa.RegionId = @qprei_RegionId OR @qpboIsCorporativoCxP = 1) \n                AND \n                (fal.DepartmentId IS NULL OR fal.DepartmentId = @qpdeGetUserDepartmentId) \n            ) \n    ) \nGROUP BY \n    asl.Label, \n    asl.\"order\" \nORDER BY  \n    asl.\"order\" ASC;";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b9ed344d44b60e0112a22c99132ee6b outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolioCount.GetFoliosCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b9ed344d44b60e0112a22c99132ee6b _tmp = new RL_0b9ed344d44b60e0112a22c99132ee6b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolioCount.GetFoliosCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b9ed344d44b60e0112a22c99132ee6b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetFoliosCount in GetFolioCount in ConectaProveedores (SELECT       COUNT(fal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {FolioApprovalLevel} fal  INNER JOIN {FolioApproval} fa ON fal.FolioApprovalId = fa.Id  INNER JOIN {Folio} fol ON fa.FolioId = fol.Id  INNER JOIN {ApprovalStatus} asl ON fal.ApprovalStatusId = asl.Id  INNER JOIN {OrderMain} ord ON ord.Id = fol.OrderId  WHERE      (          fal.ApprovalStatusId = @i_NotApprovedStatus          AND              (                  fal.AssignedTo IS NOT NULL                  AND fal.AssignedTo = @GetUserId              )              OR              (                  fal.AssignedTo IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST(fal.ApplicationRoleId AS TEXT)) <> 0 OR                      STRPOS(@EntraRolesListText, CAST(fal.EntraRoleId AS TEXT)) <> 0                  )                  AND                  (ord.DivisionId = @i_RegionId OR fa.RegionId = @i_RegionId OR @IsCorporativoCxP = 1)                  AND   ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetFoliosCount in GetFolioCount in ConectaProveedores (SELECT       COUNT(fal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {FolioApprovalLevel} fal  INNER JOIN {FolioApproval} fa ON fal.FolioApprovalId = fa.Id  INNER JOIN {Folio} fol ON fa.FolioId = fol.Id  INNER JOIN {ApprovalStatus} asl ON fal.ApprovalStatusId = asl.Id  INNER JOIN {OrderMain} ord ON ord.Id = fol.OrderId  WHERE      (          fal.ApprovalStatusId = @i_NotApprovedStatus          AND              (                  fal.AssignedTo IS NOT NULL                  AND fal.AssignedTo = @GetUserId              )              OR              (                  fal.AssignedTo IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST(fal.ApplicationRoleId AS TEXT)) <> 0 OR                      STRPOS(@EntraRolesListText, CAST(fal.EntraRoleId AS TEXT)) <> 0                  )                  AND                  (ord.DivisionId = @i_RegionId OR fa.RegionId = @i_RegionId OR @IsCorporativoCxP = 1)                  AND   ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetFoliosCount in GetFolioCount in ConectaProveedores (SELECT       COUNT(fal.Id) AS ApprovalCount,      asl.Label AS ApprovalStatusLabel  FROM      {FolioApprovalLevel} fal  INNER JOIN {FolioApproval} fa ON fal.FolioApprovalId = fa.Id  INNER JOIN {Folio} fol ON fa.FolioId = fol.Id  INNER JOIN {ApprovalStatus} asl ON fal.ApprovalStatusId = asl.Id  INNER JOIN {OrderMain} ord ON ord.Id = fol.OrderId  WHERE      (          fal.ApprovalStatusId = @i_NotApprovedStatus          AND              (                  fal.AssignedTo IS NOT NULL                  AND fal.AssignedTo = @GetUserId              )              OR              (                  fal.AssignedTo IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST(fal.ApplicationRoleId AS TEXT)) <> 0 OR                      STRPOS(@EntraRolesListText, CAST(fal.EntraRoleId AS TEXT)) <> 0                  )                  AND                  (ord.DivisionId = @i_RegionId OR fa.RegionId = @i_RegionId OR @IsCorporativoCxP = 1)                  AND   ...): " + aqExcep.Message));
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
// Query Function "GetRoleConcept" W311ykCVX0WPSqgW0OzVDA of Action "GetFolioCount"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetFolioCount.GetRoleConcept", "ca757d5b-9540-455f-8f4a-a816d0ecd50c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetFolioCount.GetRoleConcept", "ca757d5b-9540-455f-8f4a-a816d0ecd50c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Mowtj_adq0KT_dDp7XR2uA/NodesNotShownInESpaceTree.W311ykCVX0WPSqgW0OzVDA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole16\".\"code\" o1, \"enapplicationrole16\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole16\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion37\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept7\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal53\" Inner JOIN {User} \"enuser86\" ON (\"enuser_extended_internal53\".\"id\" = \"enuser86\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole24\" ON (\"enuser_extended_internal53\".\"jobtitle\" = \"enentrarole24\".\"rolename\"))  Left JOIN {Region} \"enregion37\" ON (\"enuser_extended_internal53\".\"regionid\" = \"enregion37\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept7\" ON (\"enentrarole24\".\"id\" = \"enroleconcept7\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole16\" ON (\"enroleconcept7\".\"applicationroleid\" = \"enapplicationrole16\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser86\".\"id\" = @qpusUser_Id) AND (\"enuser86\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser86\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept7\".\"conceptid\" = ");
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
opt[2] = new BitArray(new bool[] {true, false, false, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetFolioCount.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetFolioCount.GetRoleConcept.List", cancellationToken: cancellationToken);
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
