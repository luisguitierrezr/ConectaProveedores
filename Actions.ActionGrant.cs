namespace ssConectaProveedores;

public partial class Actions {
public class lcvGrant : VarsBag {
public string inParamEmail;
public RL_84bdfe424d1eb0223fc2b8cfa9bb96be queryResGetSupplierUserByEmail_outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
public long queryResGetSupplierUserByEmail_outParamCount = 0L;

public RL_8430333e95ceffc00def96d8abb01f75 queryResGetUsersByEmail_outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
public long queryResGetUsersByEmail_outParamCount = 0L;

public lcvGrant(string inParamEmail) {
this.inParamEmail = inParamEmail;
}
}
/// <summary>
/// Action <code>Grant</code> that represents the Service Studio action <code>Grant</code> <p>
///  Description: Action to grant ConectaProveedoresRole basic Role</p>
/// </summary>
public static async Task ActionGrant(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
lcvGrant localVars = new lcvGrant(inParamEmail);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Grant", "3c34c91b-7989-476c-a9fb-a977f6f1e7ef"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Grant", "3c34c91b-7989-476c-a9fb-a977f6f1e7ef", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUsersByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUsersByEmail_maxRecords = 1;
if (datasetGetUsersByEmail_maxRecords < 1) datasetGetUsersByEmail_maxRecords = 1;
int datasetGetUsersByEmail_startIndex = 0;(localVars.queryResGetUsersByEmail_outParamList,localVars.queryResGetUsersByEmail_outParamCount) = await FuncActionGrant.datasetGetUsersByEmail(requestContext,datasetGetUsersByEmail_maxRecords,datasetGetUsersByEmail_startIndex,IterationMultiplicity.Never,localVars.inParamEmail,cancellationToken);

if(((!localVars.queryResGetUsersByEmail_outParamList.Empty))) {
// GrantConectaProveedoresRole
await ExtendedActions.GrantConectaProveedoresRole(requestContext,localVars.queryResGetUsersByEmail_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

// ServiceGrantRequisiciones
await ServiceAPIs.ServiceAPIServiceGrantRequisiciones(requestContext,localVars.queryResGetUsersByEmail_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

// Query datasetGetSupplierUserByEmail
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierUserByEmail_maxRecords = 1;
if (datasetGetSupplierUserByEmail_maxRecords < 1) datasetGetSupplierUserByEmail_maxRecords = 1;
int datasetGetSupplierUserByEmail_startIndex = 0;(localVars.queryResGetSupplierUserByEmail_outParamList,localVars.queryResGetSupplierUserByEmail_outParamCount) = await FuncActionGrant.datasetGetSupplierUserByEmail(requestContext,datasetGetSupplierUserByEmail_maxRecords,datasetGetSupplierUserByEmail_startIndex,IterationMultiplicity.Never,localVars.queryResGetUsersByEmail_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

// ServiceRevokeProveedores
await ServiceAPIs.ServiceAPIServiceRevokeProveedores(requestContext,localVars.queryResGetUsersByEmail_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

// found SupplierUser?
if(((!localVars.queryResGetSupplierUserByEmail_outParamList.Empty))) {
// ServiceGrantProveedores
await ServiceAPIs.ServiceAPIServiceGrantProveedores(requestContext,localVars.queryResGetUsersByEmail_outParamList.CurrentRec.ssENUser.ssId,cancellationToken);

}

// ServiceGrantFolios
await ServiceAPIs.ServiceAPIServiceGrantFolios(requestContext,BuiltInFunction.GetUserId (),cancellationToken);

// ServiceGrantPedidos
await ServiceAPIs.ServiceAPIServiceGrantPedidos(requestContext,BuiltInFunction.GetUserId (),cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionGrant {

// Query Function "GetSupplierUserByEmail" PA56mz_K+Eydo75vGX50uQ of Action "Grant"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUserByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Grant.GetSupplierUserByEmail", "9b7a0e3c-ca3f-4cf8-9da3-be6f197e74b9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Grant.GetSupplierUserByEmail", "9b7a0e3c-ca3f-4cf8-9da3-be6f197e74b9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.G8k0PIl5bEep+6l39vHn7w/NodesNotShownInESpaceTree.PA56mz_K+Eydo75vGX50uQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser3\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser3\".\"userid\" = @qpusUserId) AND (\"ensupplieruser3\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"ensupplieruser3\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"ensupplieruser3\".\"name\" ASC ");
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
RL_84bdfe424d1eb0223fc2b8cfa9bb96be outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Grant.GetSupplierUserByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84bdfe424d1eb0223fc2b8cfa9bb96be _tmp = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Grant.GetSupplierUserByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84bdfe424d1eb0223fc2b8cfa9bb96be)_tmp;
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

// Query Function "GetUsersByEmail" r8lN1DWtKE+g11ZsnL9lJQ of Action "Grant"
public static async Task<(RL_8430333e95ceffc00def96d8abb01f75,long)> datasetGetUsersByEmail(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpemEmail,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Grant.GetUsersByEmail", "d44dc9af-ad35-4f28-a0d7-566c9cbf6525");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Grant.GetUsersByEmail", "d44dc9af-ad35-4f28-a0d7-566c9cbf6525", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.G8k0PIl5bEep+6l39vHn7w/NodesNotShownInESpaceTree.r8lN1DWtKE+g11ZsnL9lJQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser42\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {User} \"enuser42\"");
whereBuilder.Append(" WHERE (\"enuser42\".\"email\" = @qpemEmail)");
orderByBuilder.Append(" ORDER BY \"enuser42\".\"name\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpemEmail", DbType.String, qpemEmail);
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
RL_8430333e95ceffc00def96d8abb01f75 outParamList = new RL_8430333e95ceffc00def96d8abb01f75();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Grant.GetUsersByEmail.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8430333e95ceffc00def96d8abb01f75 _tmp = new RL_8430333e95ceffc00def96d8abb01f75();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Grant.GetUsersByEmail.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8430333e95ceffc00def96d8abb01f75)_tmp;
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
