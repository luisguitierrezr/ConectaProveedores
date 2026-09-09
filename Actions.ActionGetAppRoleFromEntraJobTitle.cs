namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetAppRoleFromEntraJobTitle : VarsBag {
public string inParami_JobTitle;
public int inParami_ConceptId;
public bool inParami_AreaUsuaria;
public bool inParami_AreaCxP;
public RL_a65d948725cf27ee989fa5314cba00e4 queryResGetRoleConcept_outParamList = new RL_a65d948725cf27ee989fa5314cba00e4();
public long queryResGetRoleConcept_outParamCount = 0L;

public lcvGetAppRoleFromEntraJobTitle(string inParami_JobTitle, int inParami_ConceptId, bool inParami_AreaUsuaria, bool inParami_AreaCxP) {
this.inParami_JobTitle = inParami_JobTitle;
this.inParami_ConceptId = inParami_ConceptId;
this.inParami_AreaUsuaria = inParami_AreaUsuaria;
this.inParami_AreaCxP = inParami_AreaCxP;
}
}
public class lcoGetAppRoleFromEntraJobTitle : VarsBag {
public long outParamo_ApplicationRoleId = 0L;

public string outParamo_RoleName = "";

public lcoGetAppRoleFromEntraJobTitle() {
}
}
/// <summary>
/// Action <code>GetAppRoleFromEntraJobTitle</code> that represents the Service Studio action
///  <code>GetAppRoleFromEntraJobTitle</code> <p> Description: </p>
/// </summary>
public static async Task<(long,string)> ActionGetAppRoleFromEntraJobTitle(IRequestContext requestContext,string inParami_JobTitle,int inParami_ConceptId,bool inParami_AreaUsuaria,bool inParami_AreaCxP,CancellationToken cancellationToken) {
long outParamo_ApplicationRoleId = default;
string outParamo_RoleName = default;
lcoGetAppRoleFromEntraJobTitle result = new lcoGetAppRoleFromEntraJobTitle();
lcvGetAppRoleFromEntraJobTitle localVars = new lcvGetAppRoleFromEntraJobTitle(inParami_JobTitle, inParami_ConceptId, inParami_AreaUsuaria, inParami_AreaCxP);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetAppRoleFromEntraJobTitle", "ae45e946-de51-454b-adc5-a890d6e0c1da"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetAppRoleFromEntraJobTitle", "ae45e946-de51-454b-adc5-a890d6e0c1da", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 1;
if (datasetGetRoleConcept_maxRecords < 1) datasetGetRoleConcept_maxRecords = 1;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionGetAppRoleFromEntraJobTitle.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Never,localVars.inParami_AreaCxP,localVars.inParami_AreaUsuaria,localVars.inParami_ConceptId,localVars.inParami_JobTitle,cancellationToken);

// o_ApplicationRoleId = GetRoleConcept.List.Current.RoleConcept.ApplicationRoleId
result.outParamo_ApplicationRoleId=localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId;

// o_RoleName = GetRoleConcept.List.Current.ApplicationRole.Name
result.outParamo_RoleName=localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENApplicationRole.ssName;
} //close CreateActionActivity using block
} // try

finally {
outParamo_ApplicationRoleId = result.outParamo_ApplicationRoleId;
outParamo_RoleName = result.outParamo_RoleName;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_ApplicationRoleId,outParamo_RoleName);
}

public static class FuncActionGetAppRoleFromEntraJobTitle {

private static async Task<RC_87cc7367398744031899074e30b93bba> datasetGetRoleConceptReadDbAsync(RC_87cc7367398744031899074e30b93bba rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" iSXYxmb5KUeBlG5OUFbYIA of Action "GetAppRoleFromEntraJobTitle"
public static async Task<(RL_a65d948725cf27ee989fa5314cba00e4,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboi_AreaCxP,bool qpboi_AreaUsuaria,int qpcoRoleConcept_ConceptId,string qpteEntraRole_RoleName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetAppRoleFromEntraJobTitle.GetRoleConcept", "c6d82589-f966-4729-8194-6e4e5056d820");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetAppRoleFromEntraJobTitle.GetRoleConcept", "c6d82589-f966-4729-8194-6e4e5056d820", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.RulFrlHeS0WtxaiQ1uDB2g/NodesNotShownInESpaceTree.iSXYxmb5KUeBlG5OUFbYIA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole20\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enroleconcept8\".\"applicationroleid\" o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM (({EntraRole} \"enentrarole27\" Left JOIN {RoleConcept} \"enroleconcept8\" ON (\"enentrarole27\".\"id\" = \"enroleconcept8\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole20\" ON (\"enroleconcept8\".\"applicationroleid\" = \"enapplicationrole20\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpcoRoleConcept_ConceptId != 0) {
whereBuilder.Append("((\"enroleconcept8\".\"conceptid\" = @qpcoRoleConcept_ConceptId) AND (\"enroleconcept8\".\"conceptid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoRoleConcept_ConceptId", DbType.Int32, qpcoRoleConcept_ConceptId);
} else {
whereBuilder.Append("(\"enroleconcept8\".\"conceptid\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboi_AreaUsuaria = 1) THEN \"enapplicationrole20\".\"isareausuaria\" ELSE (CASE WHEN (@qpboi_AreaCxP = 1) THEN \"enapplicationrole20\".\"isareacxp\" ELSE 1 END) END) = 1) AND (caseaccent_normalize(\"enentrarole27\".\"rolename\" collate \"default\") like caseaccent_normalize(@qpteEntraRole_RoleName collate \"default\"))");
sqlCmd.CreateParameterWithoutReplacements("@qpboi_AreaUsuaria", DbType.Boolean, qpboi_AreaUsuaria);
sqlCmd.CreateParameterWithoutReplacements("@qpboi_AreaCxP", DbType.Boolean, qpboi_AreaCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRole_RoleName", DbType.String, qpteEntraRole_RoleName);
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
RL_a65d948725cf27ee989fa5314cba00e4 outParamList = new RL_a65d948725cf27ee989fa5314cba00e4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetAppRoleFromEntraJobTitle.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a65d948725cf27ee989fa5314cba00e4 _tmp = new RL_a65d948725cf27ee989fa5314cba00e4();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetAppRoleFromEntraJobTitle.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a65d948725cf27ee989fa5314cba00e4)_tmp;
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
