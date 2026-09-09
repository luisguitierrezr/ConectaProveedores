namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetIsCorporativoCxPFromUAR : VarsBag {
public int inParami_ConceptId;
public string inParami_GetUserId;
public RL_e8fb9c349f962da0bba19bd202a05712 queryResIsCorporativoCxP_outParamList = new RL_e8fb9c349f962da0bba19bd202a05712();
public long queryResIsCorporativoCxP_outParamCount = 0L;

public lcvGetIsCorporativoCxPFromUAR(int inParami_ConceptId, string inParami_GetUserId) {
this.inParami_ConceptId = inParami_ConceptId;
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoGetIsCorporativoCxPFromUAR : VarsBag {
public bool outParamo_IsFromCorporativo = false;

public lcoGetIsCorporativoCxPFromUAR() {
}
}
/// <summary>
/// Action <code>GetIsCorporativoCxPFromUAR</code> that represents the Service Studio action
///  <code>GetIsCorporativoCxPFromUAR</code> <p> Description: From UserApplicationRole</p>
/// </summary>
public static async Task<bool> ActionGetIsCorporativoCxPFromUAR(IRequestContext requestContext,int inParami_ConceptId,string inParami_GetUserId,CancellationToken cancellationToken) {
bool outParamo_IsFromCorporativo = default;
lcoGetIsCorporativoCxPFromUAR result = new lcoGetIsCorporativoCxPFromUAR();
lcvGetIsCorporativoCxPFromUAR localVars = new lcvGetIsCorporativoCxPFromUAR(inParami_ConceptId, inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetIsCorporativoCxPFromUAR", "11c9f89f-492c-4dec-b015-c8dfe0995eb9"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetIsCorporativoCxPFromUAR", "11c9f89f-492c-4dec-b015-c8dfe0995eb9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetIsCorporativoCxP
cancellationToken.ThrowIfCancellationRequested();
int datasetIsCorporativoCxP_maxRecords = 1;
if (datasetIsCorporativoCxP_maxRecords < 1) datasetIsCorporativoCxP_maxRecords = 1;
int datasetIsCorporativoCxP_startIndex = 0;(localVars.queryResIsCorporativoCxP_outParamList,localVars.queryResIsCorporativoCxP_outParamCount) = await FuncActionGetIsCorporativoCxPFromUAR.datasetIsCorporativoCxP(requestContext,datasetIsCorporativoCxP_maxRecords,datasetIsCorporativoCxP_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParami_ConceptId,localVars.inParami_GetUserId,cancellationToken);

// o_IsFromCorporativo = notIsCorporativoCxP.List.Empty
result.outParamo_IsFromCorporativo=(!localVars.queryResIsCorporativoCxP_outParamList.Empty);
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsFromCorporativo = result.outParamo_IsFromCorporativo;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsFromCorporativo;
}

public static class FuncActionGetIsCorporativoCxPFromUAR {

private static async Task<RC_82a9276cec67a3d539884db9fd67d1e2> datasetIsCorporativoCxPReadDbAsync(RC_82a9276cec67a3d539884db9fd67d1e2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "IsCorporativoCxP" 2rtzNHEwhE2d6m_OlFtHzQ of Action "GetIsCorporativoCxPFromUAR"
public static async Task<(RL_e8fb9c349f962da0bba19bd202a05712,long)> datasetIsCorporativoCxP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,int qpcoUserApplicationRole_ConceptId,string qpusi_GetUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsCorporativoCxPFromUAR.IsCorporativoCxP", "3473bbda-3071-4d84-9dea-6fce945b47cd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsCorporativoCxPFromUAR.IsCorporativoCxP", "3473bbda-3071-4d84-9dea-6fce945b47cd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.n_jJESxJ7E2wFcjf4JleuQ/NodesNotShownInESpaceTree.2rtzNHEwhE2d6m_OlFtHzQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM (((({User_Extended_Internal} \"enuser_extended_internal6\" Left JOIN {Region} \"enregion4\" ON (\"enuser_extended_internal6\".\"regionid\" = \"enregion4\".\"id\"))  Right JOIN {User} \"enuser12\" ON (\"enuser12\".\"id\" = \"enuser_extended_internal6\".\"id\"))  Left JOIN {UserApplicationRole} \"enuserapplicationrole\" ON (\"enuser12\".\"id\" = \"enuserapplicationrole\".\"userid\"))  Left JOIN {ApplicationRole} \"enapplicationrole2\" ON (\"enuserapplicationrole\".\"applicationroleid\" = \"enapplicationrole2\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser12\".\"id\" = (CASE WHEN (@qpusi_GetUserId <> '') THEN @qpusi_GetUserId ELSE @qpusGetUserId END)) AND (\"enuserapplicationrole\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpusi_GetUserId", DbType.String, qpusi_GetUserId);
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
if (qpcoUserApplicationRole_ConceptId != 0) {
whereBuilder.Append("((\"enuserapplicationrole\".\"conceptid\" = @qpcoUserApplicationRole_ConceptId) AND (\"enuserapplicationrole\".\"conceptid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoUserApplicationRole_ConceptId", DbType.Int32, qpcoUserApplicationRole_ConceptId);
} else {
whereBuilder.Append("(\"enuserapplicationrole\".\"conceptid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enregion4\".\"commissionregion\" = 'R0') AND (\"enapplicationrole2\".\"isareacxp\" = 1)");
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
RL_e8fb9c349f962da0bba19bd202a05712 outParamList = new RL_e8fb9c349f962da0bba19bd202a05712();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetIsCorporativoCxPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsCorporativoCxPFromUAR.IsCorporativoCxP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8fb9c349f962da0bba19bd202a05712 _tmp = new RL_e8fb9c349f962da0bba19bd202a05712();
_tmp.AlternateReadDbMethodAsync = datasetIsCorporativoCxPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsCorporativoCxPFromUAR.IsCorporativoCxP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8fb9c349f962da0bba19bd202a05712)_tmp;
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
