namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserRole : VarsBag {
public string inParami_UserId;
public int inParami_ConceptId;
public bool inParami_AreaUsuaria;
public bool inParami_AreaCxP;
public RL_6baa91071578818b75d38b8795012b73 queryResGetUserApplicationRole_outParamList = new RL_6baa91071578818b75d38b8795012b73();
public long queryResGetUserApplicationRole_outParamCount = 0L;

public RL_137ca0bd922b82f91f39dd017e999a51 queryResGetRoleConcept_outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
public long queryResGetRoleConcept_outParamCount = 0L;

public lcvGetUserRole(string inParami_UserId, int inParami_ConceptId, bool inParami_AreaUsuaria, bool inParami_AreaCxP) {
this.inParami_UserId = inParami_UserId;
this.inParami_ConceptId = inParami_ConceptId;
this.inParami_AreaUsuaria = inParami_AreaUsuaria;
this.inParami_AreaCxP = inParami_AreaCxP;
}
}
public class lcoGetUserRole : VarsBag {
public long outParamo_ApplicationRoleId = 0L;

public lcoGetUserRole() {
}
}
/// <summary>
/// Action <code>GetUserRole</code> that represents the Service Studio action <code>GetUserRole</code>
///  <p> Description: </p>
/// </summary>
public static async Task<long> ActionGetUserRole(IRequestContext requestContext,string inParami_UserId,int inParami_ConceptId,bool inParami_AreaUsuaria,bool inParami_AreaCxP,CancellationToken cancellationToken) {
long outParamo_ApplicationRoleId = default;
lcoGetUserRole result = new lcoGetUserRole();
lcvGetUserRole localVars = new lcvGetUserRole(inParami_UserId, inParami_ConceptId, inParami_AreaUsuaria, inParami_AreaCxP);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserRole", "af0c0825-fb5c-4f4a-a542-c18bc3622844"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserRole", "af0c0825-fb5c-4f4a-a542-c18bc3622844", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// LogMessage
await ExtendedActions.LogMessage(requestContext,((((("UserId: "+localVars.inParami_UserId)+" | i_AreaUsuaria")+(localVars.inParami_AreaUsuaria ? "True" : "False"))+" | i_AreaCxP")+(localVars.inParami_AreaCxP ? "True" : "False")),"REQ",cancellationToken);

// Query datasetGetUserApplicationRole
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRole_maxRecords = 1;
if (datasetGetUserApplicationRole_maxRecords < 1) datasetGetUserApplicationRole_maxRecords = 1;
int datasetGetUserApplicationRole_startIndex = 0;(localVars.queryResGetUserApplicationRole_outParamList,localVars.queryResGetUserApplicationRole_outParamCount) = await FuncActionGetUserRole.datasetGetUserApplicationRole(requestContext,datasetGetUserApplicationRole_maxRecords,datasetGetUserApplicationRole_startIndex,IterationMultiplicity.Never,localVars.inParami_AreaCxP,localVars.inParami_AreaUsuaria,localVars.inParami_ConceptId,localVars.inParami_UserId,cancellationToken);

// Empty
if((localVars.queryResGetUserApplicationRole_outParamList.Empty)) {
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 1;
if (datasetGetRoleConcept_maxRecords < 1) datasetGetRoleConcept_maxRecords = 1;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionGetUserRole.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Never,localVars.inParami_AreaCxP,localVars.inParami_AreaUsuaria,localVars.inParami_ConceptId,localVars.inParami_UserId,cancellationToken);

// o_ApplicationRoleId = GetRoleConcept.List.Current.RoleConcept.ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId;
} else {
// o_ApplicationRoleId = GetUserApplicationRole.List.Current.UserApplicationRole.ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.queryResGetUserApplicationRole_outParamList.CurrentRec.ssENUserApplicationRole.ssApplicationRoleId;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ApplicationRoleId = result.outParamo_ApplicationRoleId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ApplicationRoleId;
}

public static class FuncActionGetUserRole {

private static async Task<RC_c2921a936d592680b8275006015423c4> datasetGetUserApplicationRoleReadDbAsync(RC_c2921a936d592680b8275006015423c4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRole" Zg1Cy8WkMkq5j828QXF4PA of Action "GetUserRole"
public static async Task<(RL_6baa91071578818b75d38b8795012b73,long)> datasetGetUserApplicationRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboi_AreaCxP,bool qpboi_AreaUsuaria,int qpcoUserApplicationRole_ConceptId,string qpusUserApplicationRole_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserRole.GetUserApplicationRole", "cb420d66-a4c5-4a32-b98f-cdbc4171783c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserRole.GetUserApplicationRole", "cb420d66-a4c5-4a32-b98f-cdbc4171783c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.JQgMr1z7Sk+lQsGLw2IoRA/NodesNotShownInESpaceTree.Zg1Cy8WkMkq5j828QXF4PA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enuserapplicationrole10\".\"applicationroleid\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM ({UserApplicationRole} \"enuserapplicationrole10\" Left JOIN {ApplicationRole} \"enapplicationrole21\" ON (\"enuserapplicationrole10\".\"applicationroleid\" = \"enapplicationrole21\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuserapplicationrole10\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND ");
if ((qpusUserApplicationRole_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationrole10\".\"userid\" = @qpusUserApplicationRole_UserId) AND (\"enuserapplicationrole10\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRole_UserId", DbType.String, qpusUserApplicationRole_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationrole10\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpcoUserApplicationRole_ConceptId != BuiltInFunction.NullIdentifier()) {
if (qpcoUserApplicationRole_ConceptId != 0) {
whereBuilder.Append("((\"enuserapplicationrole10\".\"conceptid\" = @qpcoUserApplicationRole_ConceptId) AND (\"enuserapplicationrole10\".\"conceptid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoUserApplicationRole_ConceptId", DbType.Int32, qpcoUserApplicationRole_ConceptId);
} else {
whereBuilder.Append("(\"enuserapplicationrole10\".\"conceptid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((CASE WHEN (@qpboi_AreaUsuaria = 1) THEN \"enapplicationrole21\".\"isareausuaria\" ELSE (CASE WHEN (@qpboi_AreaCxP = 1) THEN \"enapplicationrole21\".\"isareacxp\" ELSE 1 END) END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboi_AreaUsuaria", DbType.Boolean, qpboi_AreaUsuaria);
sqlCmd.CreateParameterWithoutReplacements("@qpboi_AreaCxP", DbType.Boolean, qpboi_AreaCxP);
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
RL_6baa91071578818b75d38b8795012b73 outParamList = new RL_6baa91071578818b75d38b8795012b73();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserRole.GetUserApplicationRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6baa91071578818b75d38b8795012b73 _tmp = new RL_6baa91071578818b75d38b8795012b73();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserRole.GetUserApplicationRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6baa91071578818b75d38b8795012b73)_tmp;
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

private static async Task<RC_7b8200225d1e3acafed4d42f9fce9055> datasetGetRoleConceptReadDbAsync(RC_7b8200225d1e3acafed4d42f9fce9055 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" EdUAzc3c60uTYNP0u+DJYQ of Action "GetUserRole"
public static async Task<(RL_137ca0bd922b82f91f39dd017e999a51,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboi_AreaCxP,bool qpboi_AreaUsuaria,int qpcoRoleConcept_ConceptId,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserRole.GetRoleConcept", "cd00d511-dccd-4beb-9360-d3f4bbe0c961");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserRole.GetRoleConcept", "cd00d511-dccd-4beb-9360-d3f4bbe0c961", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.JQgMr1z7Sk+lQsGLw2IoRA/NodesNotShownInESpaceTree.EdUAzc3c60uTYNP0u+DJYQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enroleconcept9\".\"applicationroleid\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41");
fromBuilder.Append(" FROM (((({User_Extended_Internal} \"enuser_extended_internal60\" Inner JOIN {User} \"enuser99\" ON (\"enuser_extended_internal60\".\"id\" = \"enuser99\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole28\" ON (\"enuser_extended_internal60\".\"jobtitle\" = \"enentrarole28\".\"rolename\"))  Left JOIN {RoleConcept} \"enroleconcept9\" ON (\"enentrarole28\".\"id\" = \"enroleconcept9\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole22\" ON (\"enroleconcept9\".\"applicationroleid\" = \"enapplicationrole22\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser99\".\"id\" = @qpusUser_Id) AND (\"enuser99\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser99\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpcoRoleConcept_ConceptId != 0) {
whereBuilder.Append("((\"enroleconcept9\".\"conceptid\" = @qpcoRoleConcept_ConceptId) AND (\"enroleconcept9\".\"conceptid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoRoleConcept_ConceptId", DbType.Int32, qpcoRoleConcept_ConceptId);
} else {
whereBuilder.Append("(\"enroleconcept9\".\"conceptid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboi_AreaUsuaria = 1) THEN \"enapplicationrole22\".\"isareausuaria\" ELSE (CASE WHEN (@qpboi_AreaCxP = 1) THEN \"enapplicationrole22\".\"isareacxp\" ELSE 1 END) END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboi_AreaUsuaria", DbType.Boolean, qpboi_AreaUsuaria);
sqlCmd.CreateParameterWithoutReplacements("@qpboi_AreaCxP", DbType.Boolean, qpboi_AreaCxP);
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
RL_137ca0bd922b82f91f39dd017e999a51 outParamList = new RL_137ca0bd922b82f91f39dd017e999a51();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserRole.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_137ca0bd922b82f91f39dd017e999a51 _tmp = new RL_137ca0bd922b82f91f39dd017e999a51();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserRole.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_137ca0bd922b82f91f39dd017e999a51)_tmp;
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
