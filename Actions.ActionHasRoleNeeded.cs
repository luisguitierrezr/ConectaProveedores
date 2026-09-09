namespace ssConectaProveedores;

public partial class Actions {
public class lcvHasRoleNeeded : VarsBag {
public long inParami_ApplicationRoleId;
public string inParami_ApplicationRoleName;
public string inParami_UserId;
public long inParami_RegionId;
public int inParami_ConceptId;
public RL_ced0d59599ed3766302a17b5ee163aa2 queryResGetRoleConcept_outParamList = new RL_ced0d59599ed3766302a17b5ee163aa2();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_d3ffbc49f09f84f811cf8d55f22672cb queryResGetUserApplicationRole_outParamList = new RL_d3ffbc49f09f84f811cf8d55f22672cb();
public long queryResGetUserApplicationRole_outParamCount = 0L;

public lcvHasRoleNeeded(long inParami_ApplicationRoleId, string inParami_ApplicationRoleName, string inParami_UserId, long inParami_RegionId, int inParami_ConceptId) {
this.inParami_ApplicationRoleId = inParami_ApplicationRoleId;
this.inParami_ApplicationRoleName = inParami_ApplicationRoleName;
this.inParami_UserId = inParami_UserId;
this.inParami_RegionId = inParami_RegionId;
this.inParami_ConceptId = inParami_ConceptId;
}
}
public class lcoHasRoleNeeded : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public string outParamo_UserId = "";

public lcoHasRoleNeeded() {
}
}
/// <summary>
/// Action <code>HasRoleNeeded</code> that represents the Service Studio action
///  <code>HasRoleNeeded</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_046fb53ebbe142526d95e87ef1ae9711Structure,string)> ActionHasRoleNeeded(IRequestContext requestContext,long inParami_ApplicationRoleId,string inParami_ApplicationRoleName,string inParami_UserId,long inParami_RegionId,int inParami_ConceptId,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
string outParamo_UserId = default;
lcoHasRoleNeeded result = new lcoHasRoleNeeded();
lcvHasRoleNeeded localVars = new lcvHasRoleNeeded(inParami_ApplicationRoleId, inParami_ApplicationRoleName, inParami_UserId, inParami_RegionId, inParami_ConceptId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("HasRoleNeeded", "662acba4-393d-457f-a0c2-d68bf86a55a6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("HasRoleNeeded", "662acba4-393d-457f-a0c2-d68bf86a55a6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserApplicationRole
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRole_maxRecords = 1;
if (datasetGetUserApplicationRole_maxRecords < 1) datasetGetUserApplicationRole_maxRecords = 1;
int datasetGetUserApplicationRole_startIndex = 0;(localVars.queryResGetUserApplicationRole_outParamList,localVars.queryResGetUserApplicationRole_outParamCount) = await FuncActionHasRoleNeeded.datasetGetUserApplicationRole(requestContext,datasetGetUserApplicationRole_maxRecords,datasetGetUserApplicationRole_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_RegionId,localVars.inParami_UserId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// Empty
if((localVars.queryResGetUserApplicationRole_outParamList.Empty)) {
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 1;
if (datasetGetRoleConcept_maxRecords < 1) datasetGetRoleConcept_maxRecords = 1;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionHasRoleNeeded.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Never,localVars.inParami_ApplicationRoleId,localVars.inParami_ConceptId,localVars.inParami_RegionId,localVars.inParami_UserId,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment]))),cancellationToken);

// Empty
if((localVars.queryResGetRoleConcept_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "User with role" + " '" + i_ApplicationRoleName + "' " + "not found!"
result.outParamo_Output.ssMessage = ((((AppUtils.GetStringResource("K3ueVgfpkEGwVwnoT_eIhA#Value.915023259.1", "User with role")+" '")+localVars.inParami_ApplicationRoleName)+"' ")+AppUtils.GetStringResource("K3ueVgfpkEGwVwnoT_eIhA#Value.-1536437556.1", "not found!"));
} else {
// o_UserId = GetRoleConcept.List.Current.User.Id
result.outParamo_UserId=localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENUser.ssId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} else {
// o_UserId = GetUserApplicationRole.List.Current.UserApplicationRole.UserId
result.outParamo_UserId=localVars.queryResGetUserApplicationRole_outParamList.CurrentRec.ssENUserApplicationRole.ssUserId;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
outParamo_UserId = result.outParamo_UserId;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Output,outParamo_UserId);
}

public static class FuncActionHasRoleNeeded {

private static async Task<RC_54a9ab3ba99fc61632c4ed43afcfc260> datasetGetRoleConceptReadDbAsync(RC_54a9ab3ba99fc61632c4ed43afcfc260 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" sQUpYgjlHUqYXb9XEN5c2Q of Action "HasRoleNeeded"
public static async Task<(RL_ced0d59599ed3766302a17b5ee163aa2,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapRoleConcept_ApplicationRoleId,int qpcoRoleConcept_ConceptId,long qpreRegion_Id,string qpusUser_Id,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HasRoleNeeded.GetRoleConcept", "622905b1-e508-4a1d-985d-bf5710de5cd9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HasRoleNeeded.GetRoleConcept", "622905b1-e508-4a1d-985d-bf5710de5cd9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pMsqZj05f0WgwtaL+GpVpg/NodesNotShownInESpaceTree.sQUpYgjlHUqYXb9XEN5c2Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, \"enuser67\".\"id\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50");
fromBuilder.Append(" FROM ((((({User} \"enuser67\" Inner JOIN {User_Extended_Internal} \"enuser_extended_internal39\" ON (\"enuser_extended_internal39\".\"id\" = \"enuser67\".\"id\"))  Left JOIN {Region} \"enregion24\" ON (\"enuser_extended_internal39\".\"regionid\" = \"enregion24\".\"id\"))  Left JOIN {EntraRole} \"enentrarole14\" ON (\"enuser_extended_internal39\".\"entraroleid\" = \"enentrarole14\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept3\" ON (\"enentrarole14\".\"id\" = \"enroleconcept3\".\"entraroleid\"))  Left JOIN {UserExtension} \"enuserextension35\" ON (\"enuser67\".\"id\" = \"enuserextension35\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpusUser_Id <> '') THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser67\".\"id\" = @qpusUser_Id) AND (\"enuser67\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser67\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) AND ");
if (qpcoRoleConcept_ConceptId != 0) {
whereBuilder.Append("((\"enroleconcept3\".\"conceptid\" = @qpcoRoleConcept_ConceptId) AND (\"enroleconcept3\".\"conceptid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoRoleConcept_ConceptId", DbType.Int32, qpcoRoleConcept_ConceptId);
} else {
whereBuilder.Append("(\"enroleconcept3\".\"conceptid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpapRoleConcept_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enroleconcept3\".\"applicationroleid\" = @qpapRoleConcept_ApplicationRoleId) AND (\"enroleconcept3\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRoleConcept_ApplicationRoleId", DbType.Int64, qpapRoleConcept_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enroleconcept3\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpreRegion_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion24\".\"id\" = @qpreRegion_Id) AND (\"enregion24\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion24\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension35\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_ced0d59599ed3766302a17b5ee163aa2 outParamList = new RL_ced0d59599ed3766302a17b5ee163aa2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HasRoleNeeded.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ced0d59599ed3766302a17b5ee163aa2 _tmp = new RL_ced0d59599ed3766302a17b5ee163aa2();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HasRoleNeeded.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ced0d59599ed3766302a17b5ee163aa2)_tmp;
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

private static async Task<RC_b1aef7e4555afd67b6953fcc571f18a7> datasetGetUserApplicationRoleReadDbAsync(RC_b1aef7e4555afd67b6953fcc571f18a7 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRole" m545xGK5d0+RPRzrIyDoqw of Action "HasRoleNeeded"
public static async Task<(RL_d3ffbc49f09f84f811cf8d55f22672cb,long)> datasetGetUserApplicationRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpapUserApplicationRole_ApplicationRoleId,long qpreRegion_Id,string qpusUserApplicationRole_UserId,bool qpboIsDevEnvironment,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("HasRoleNeeded.GetUserApplicationRole", "c4399e9b-b962-4f77-913d-1ceb2320e8ab");
using var queryActivity = activitySource.CreateAggregateQueryActivity("HasRoleNeeded.GetUserApplicationRole", "c4399e9b-b962-4f77-913d-1ceb2320e8ab", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pMsqZj05f0WgwtaL+GpVpg/NodesNotShownInESpaceTree.m545xGK5d0+RPRzrIyDoqw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, \"enuserapplicationrole9\".\"userid\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM ((({UserApplicationRole} \"enuserapplicationrole9\" Left JOIN {Region} \"enregion25\" ON ((Upper((trim(\"enuserapplicationrole9\".\"regiontobeassign\")))) = \"enregion25\".\"commissionregion\"))  Left JOIN {User} \"enuser68\" ON (\"enuserapplicationrole9\".\"userid\" = \"enuser68\".\"id\"))  Left JOIN {UserExtension} \"enuserextension36\" ON (\"enuser68\".\"id\" = \"enuserextension36\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpapUserApplicationRole_ApplicationRoleId != 0) {
whereBuilder.Append("((\"enuserapplicationrole9\".\"applicationroleid\" = @qpapUserApplicationRole_ApplicationRoleId) AND (\"enuserapplicationrole9\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapUserApplicationRole_ApplicationRoleId", DbType.Int64, qpapUserApplicationRole_ApplicationRoleId);
} else {
whereBuilder.Append("(\"enuserapplicationrole9\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationrole9\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND ((CASE WHEN (@qpreRegion_Id <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion25\".\"id\" = @qpreRegion_Id) AND (\"enregion25\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion25\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) AND ((CASE WHEN (@qpusUserApplicationRole_UserId <> '') THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRole_UserId", DbType.String, qpusUserApplicationRole_UserId);
if ((qpusUserApplicationRole_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationrole9\".\"userid\" = @qpusUserApplicationRole_UserId) AND (\"enuserapplicationrole9\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRole_UserId", DbType.String, qpusUserApplicationRole_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationrole9\".\"userid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) AND ((CASE WHEN (@qpboIsDevEnvironment = 1) THEN (CASE WHEN (\"enuserextension36\".\"correspondentexternalemail\" <> '') THEN 1 ELSE 0 END) ELSE 1 END) = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDevEnvironment", DbType.Boolean, qpboIsDevEnvironment);
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
RL_d3ffbc49f09f84f811cf8d55f22672cb outParamList = new RL_d3ffbc49f09f84f811cf8d55f22672cb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query HasRoleNeeded.GetUserApplicationRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d3ffbc49f09f84f811cf8d55f22672cb _tmp = new RL_d3ffbc49f09f84f811cf8d55f22672cb();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query HasRoleNeeded.GetUserApplicationRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d3ffbc49f09f84f811cf8d55f22672cb)_tmp;
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
