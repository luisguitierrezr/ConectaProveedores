using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel).Namespace);

    public int varLcl_StartIndex;
public int varLcl_MaxRecords;
public bool varLcl_ShowAssignTempRolePopup;
public bool varLcl_ShowConfirmPopup;
public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord varLcl_UserApplicationRoleTemp;
public int varLcl_StartIndexAssigned;
public int varLcl_MaxRecordsAssigned;
public AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> ScreenDataSetGetUserApplicationRoleTempsByUserId;
public AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> ScreenDataSetGetUserApplicationRoleTempsByAssignedBy;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel() {
}



    public ConectaProveedores_a_Common_Wb_TempRoleAssignments_ScreenModel(int varLcl_StartIndex, int varLcl_MaxRecords, bool varLcl_ShowAssignTempRolePopup, bool varLcl_ShowConfirmPopup, EN_20bdea9cf8f17569719f414a83b584b6EntityRecord varLcl_UserApplicationRoleTemp, int varLcl_StartIndexAssigned, int varLcl_MaxRecordsAssigned, AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> ScreenDataSetGetUserApplicationRoleTempsByUserId, AggregateRecord<RL_bb4d6e713cd7ffbd47871f2337312efa> ScreenDataSetGetUserApplicationRoleTempsByAssignedBy, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_StartIndex", "l_MaxRecords", "l_ShowAssignTempRolePopup", "l_ShowConfirmPopup", "l_UserApplicationRoleTemp", "l_StartIndexAssigned", "l_MaxRecordsAssigned", "GetUserApplicationRoleTempsByUserId", "GetUserApplicationRoleTempsByAssignedBy", "ClientVars"}, new string[] {"varLcl_StartIndex", "varLcl_MaxRecords", "varLcl_ShowAssignTempRolePopup", "varLcl_ShowConfirmPopup", "varLcl_UserApplicationRoleTemp", "varLcl_StartIndexAssigned", "varLcl_MaxRecordsAssigned", "ScreenDataSetGetUserApplicationRoleTempsByUserId", "ScreenDataSetGetUserApplicationRoleTempsByAssignedBy", "clientVariables"});
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_MaxRecords = varLcl_MaxRecords;
this.varLcl_ShowAssignTempRolePopup = varLcl_ShowAssignTempRolePopup;
this.varLcl_ShowConfirmPopup = varLcl_ShowConfirmPopup;
this.varLcl_UserApplicationRoleTemp = varLcl_UserApplicationRoleTemp;
this.varLcl_StartIndexAssigned = varLcl_StartIndexAssigned;
this.varLcl_MaxRecordsAssigned = varLcl_MaxRecordsAssigned;
this.ScreenDataSetGetUserApplicationRoleTempsByUserId = ScreenDataSetGetUserApplicationRoleTempsByUserId;
this.ScreenDataSetGetUserApplicationRoleTempsByAssignedBy = ScreenDataSetGetUserApplicationRoleTempsByAssignedBy;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_284d6b812acb53aa55a28cbe2a22b4ca> datasetGetUserApplicationRoleTempsByUserIdReadDbAsync(RC_284d6b812acb53aa55a28cbe2a22b4ca rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRoleStatus.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_AssignedBy.Read( r, ref index);
rec.ssENUser_Revoked.Read( r, ref index);
rec.ssENUserApplicationRoleTemp.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleTempsByUserId" 6_BeNCAftkObjCd9uutQxA of Action "Wb_TempRoleAssignments"
public static async Task<(RL_bb4d6e713cd7ffbd47871f2337312efa,long)> datasetGetUserApplicationRoleTempsByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByUserId", "345ef0eb-1f20-43b6-9b8c-277dbaeb50c4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_TempRoleAssignments","a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByUserId");
// Query Iterations: Multiple
// Refresh Query B_LATCeQl0GDhR0iJcFztg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.Gz5USkp07kylLhJyHDRTpQ/ScreenDataSets.6_BeNCAftkObjCd9uutQxA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enrolestatus\".\"label\" o8, NULL o9, NULL o10, NULL o11, \"enuser157\".\"name\" o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enuser_assignedby\".\"name\" o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enuser_revoked\".\"name\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"enuserapplicationroletemp7\".\"assignedby\" o30, \"enuserapplicationroletemp7\".\"assigneddate\" o31, \"enuserapplicationroletemp7\".\"rolestatusid\" o32, \"enuserapplicationroletemp7\".\"revokedby\" o33, \"enuserapplicationroletemp7\".\"revokeddate\" o34, \"enuserapplicationroletemp7\".\"datefrom\" o35, \"enuserapplicationroletemp7\".\"dateto\" o36, \"enuserapplicationroletemp7\".\"lastupdatedon\" o37, NULL o38, NULL o39");
fromBuilder.Append(" FROM ((((({UserApplicationRoleTemp} \"enuserapplicationroletemp7\" Left JOIN {User} \"enuser157\" ON (\"enuserapplicationroletemp7\".\"userid\" = \"enuser157\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole48\" ON (\"enuserapplicationroletemp7\".\"applicationroleid\" = \"enapplicationrole48\".\"id\"))  Left JOIN {User} \"enuser_revoked\" ON (\"enuserapplicationroletemp7\".\"revokedby\" = \"enuser_revoked\".\"id\"))  Left JOIN {RoleStatus} \"enrolestatus\" ON (\"enuserapplicationroletemp7\".\"rolestatusid\" = \"enrolestatus\".\"id\"))  Left JOIN {User} \"enuser_assignedby\" ON (\"enuserapplicationroletemp7\".\"assignedby\" = \"enuser_assignedby\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp7\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp7\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp7\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuserapplicationroletemp7\".\"id\" DESC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
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
RL_bb4d6e713cd7ffbd47871f2337312efa outParamList = new RL_bb4d6e713cd7ffbd47871f2337312efa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempsByUserIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, false, false, false, false, false, false, false, false, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByUserId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bb4d6e713cd7ffbd47871f2337312efa _tmp = new RL_bb4d6e713cd7ffbd47871f2337312efa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempsByUserIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bb4d6e713cd7ffbd47871f2337312efa)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByUserId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_284d6b812acb53aa55a28cbe2a22b4ca> datasetGetUserApplicationRoleTempsByAssignedByReadDbAsync(RC_284d6b812acb53aa55a28cbe2a22b4ca rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRoleStatus.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_AssignedBy.Read( r, ref index);
rec.ssENUser_Revoked.Read( r, ref index);
rec.ssENUserApplicationRoleTemp.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleTempsByAssignedBy" vL_SYloneEynUeFQMV6DpA of Action "Wb_TempRoleAssignments"
public static async Task<(RL_bb4d6e713cd7ffbd47871f2337312efa,long)> datasetGetUserApplicationRoleTempsByAssignedBy(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_AssignedBy,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByAssignedBy", "62d2bfbc-275a-4c78-a751-e150315e83a4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_TempRoleAssignments","a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByAssignedBy");
// Query Iterations: Multiple
// Refresh Query 94fbn7taj0WZZaRKNNKytA Iterations: Multiple
// Refresh Query wVnxdvSBgUyop39z31ZsxA Iterations: Multiple
// Refresh Query OPkdtTaDY0WMyhrGSdH5Vg Iterations: Multiple
// Refresh Query AYcMb5tMukinfahmxYvZFQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.Gz5USkp07kylLhJyHDRTpQ/ScreenDataSets.vL_SYloneEynUeFQMV6DpA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enrolestatus1\".\"label\" o8, NULL o9, NULL o10, NULL o11, \"enuser158\".\"name\" o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enuser_assignedby1\".\"name\" o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enuser_revoked1\".\"name\" o22, NULL o23, NULL o24, NULL o25, \"enuserapplicationroletemp8\".\"id\" o26, \"enuserapplicationroletemp8\".\"userid\" o27, \"enuserapplicationroletemp8\".\"applicationroleid\" o28, \"enuserapplicationroletemp8\".\"entraroleid\" o29, \"enuserapplicationroletemp8\".\"assignedby\" o30, \"enuserapplicationroletemp8\".\"assigneddate\" o31, \"enuserapplicationroletemp8\".\"rolestatusid\" o32, \"enuserapplicationroletemp8\".\"revokedby\" o33, \"enuserapplicationroletemp8\".\"revokeddate\" o34, \"enuserapplicationroletemp8\".\"datefrom\" o35, \"enuserapplicationroletemp8\".\"dateto\" o36, \"enuserapplicationroletemp8\".\"lastupdatedon\" o37, \"enuserapplicationroletemp8\".\"conceptid\" o38, \"enuserapplicationroletemp8\".\"regiontobeassign\" o39");
fromBuilder.Append(" FROM ((((({UserApplicationRoleTemp} \"enuserapplicationroletemp8\" Left JOIN {User} \"enuser158\" ON (\"enuserapplicationroletemp8\".\"userid\" = \"enuser158\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole49\" ON (\"enuserapplicationroletemp8\".\"applicationroleid\" = \"enapplicationrole49\".\"id\"))  Left JOIN {User} \"enuser_revoked1\" ON (\"enuserapplicationroletemp8\".\"revokedby\" = \"enuser_revoked1\".\"id\"))  Left JOIN {RoleStatus} \"enrolestatus1\" ON (\"enuserapplicationroletemp8\".\"rolestatusid\" = \"enrolestatus1\".\"id\"))  Left JOIN {User} \"enuser_assignedby1\" ON (\"enuserapplicationroletemp8\".\"assignedby\" = \"enuser_assignedby1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_AssignedBy.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp8\".\"assignedby\" = @qpusUserApplicationRoleTemp_AssignedBy) AND (\"enuserapplicationroletemp8\".\"assignedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_AssignedBy", DbType.String, qpusUserApplicationRoleTemp_AssignedBy);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_AssignedBy", DbType.String, qpusUserApplicationRoleTemp_AssignedBy);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp8\".\"assignedby\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enuserapplicationroletemp8\".\"id\" DESC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
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
RL_bb4d6e713cd7ffbd47871f2337312efa outParamList = new RL_bb4d6e713cd7ffbd47871f2337312efa();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempsByAssignedByReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByAssignedBy.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByAssignedBy.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bb4d6e713cd7ffbd47871f2337312efa _tmp = new RL_bb4d6e713cd7ffbd47871f2337312efa();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempsByAssignedByReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByAssignedBy.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bb4d6e713cd7ffbd47871f2337312efa)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query a_Common.Wb_TempRoleAssignments.GetUserApplicationRoleTempsByAssignedBy.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
