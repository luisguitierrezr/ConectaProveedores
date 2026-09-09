namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetIsCorporativo : VarsBag {
public RL_1543a4f2af6703945e350e1348a6aecf queryResIsCorporativo_outParamList = new RL_1543a4f2af6703945e350e1348a6aecf();
public long queryResIsCorporativo_outParamCount = 0L;

public lcvGetIsCorporativo() {
}
}
public class lcoGetIsCorporativo : VarsBag {
public bool outParamo_IsFromCorporativo = false;

public lcoGetIsCorporativo() {
}
}
/// <summary>
/// Action <code>GetIsCorporativo</code> that represents the Service Studio action
///  <code>GetIsCorporativo</code> <p> Description: From Generic</p>
/// </summary>
public static async Task<bool> ActionGetIsCorporativo(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsFromCorporativo = default;
lcoGetIsCorporativo result = new lcoGetIsCorporativo();
lcvGetIsCorporativo localVars = new lcvGetIsCorporativo();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetIsCorporativo", "72c5f305-bf9b-4313-9928-9484bfe1bea8"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetIsCorporativo", "72c5f305-bf9b-4313-9928-9484bfe1bea8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetIsCorporativo
cancellationToken.ThrowIfCancellationRequested();
int datasetIsCorporativo_maxRecords = 1;
if (datasetIsCorporativo_maxRecords < 1) datasetIsCorporativo_maxRecords = 1;
int datasetIsCorporativo_startIndex = 0;(localVars.queryResIsCorporativo_outParamList,localVars.queryResIsCorporativo_outParamCount) = await FuncActionGetIsCorporativo.datasetIsCorporativo(requestContext,datasetIsCorporativo_maxRecords,datasetIsCorporativo_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// o_IsFromCorporativo = notIsCorporativo.List.Empty
result.outParamo_IsFromCorporativo=(!localVars.queryResIsCorporativo_outParamList.Empty);
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsFromCorporativo = result.outParamo_IsFromCorporativo;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsFromCorporativo;
}

public static class FuncActionGetIsCorporativo {

private static async Task<RC_185879ac9d2186c1424cb37de7de8668> datasetIsCorporativoReadDbAsync(RC_185879ac9d2186c1424cb37de7de8668 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "IsCorporativo" 0i_yMjmW3kCRqSoqjGM66w of Action "GetIsCorporativo"
public static async Task<(RL_1543a4f2af6703945e350e1348a6aecf,long)> datasetIsCorporativo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetIsCorporativo.IsCorporativo", "32f22fd2-9639-40de-91a9-2a2a8c633aeb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetIsCorporativo.IsCorporativo", "32f22fd2-9639-40de-91a9-2a2a8c633aeb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.BfPFcpu_E0OZKJSEv+G+qA/NodesNotShownInESpaceTree.0i_yMjmW3kCRqSoqjGM66w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal42\" Inner JOIN {User} \"enuser72\" ON (\"enuser_extended_internal42\".\"id\" = \"enuser72\".\"id\"))  Inner JOIN {Region} \"enregion32\" ON (\"enuser_extended_internal42\".\"regionid\" = \"enregion32\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser72\".\"id\" = @qpusUser_Id) AND (\"enuser72\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser72\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (caseaccent_normalize(\"enregion32\".\"commissionregion\" collate \"default\") like caseaccent_normalize('R0' collate \"default\"))");
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
RL_1543a4f2af6703945e350e1348a6aecf outParamList = new RL_1543a4f2af6703945e350e1348a6aecf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetIsCorporativoReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetIsCorporativo.IsCorporativo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1543a4f2af6703945e350e1348a6aecf _tmp = new RL_1543a4f2af6703945e350e1348a6aecf();
_tmp.AlternateReadDbMethodAsync = datasetIsCorporativoReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetIsCorporativo.IsCorporativo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1543a4f2af6703945e350e1348a6aecf)_tmp;
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
