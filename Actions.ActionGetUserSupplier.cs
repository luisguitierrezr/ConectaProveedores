namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserSupplier : VarsBag {
public string inParami_GetUserId;
public RL_84bdfe424d1eb0223fc2b8cfa9bb96be queryResGetSupplierUsersByUserId_outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
public long queryResGetSupplierUsersByUserId_outParamCount = 0L;

public lcvGetUserSupplier(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoGetUserSupplier : VarsBag {
public long outParamo_SupplierId = 0L;

public lcoGetUserSupplier() {
}
}
/// <summary>
/// Action <code>GetUserSupplier</code> that represents the Service Studio action
///  <code>GetUserSupplier</code> <p> Description: Action to get SupplierId from current user</p>
/// </summary>
public static async Task<long> ActionGetUserSupplier(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_SupplierId = default;
lcoGetUserSupplier result = new lcoGetUserSupplier();
lcvGetUserSupplier localVars = new lcvGetUserSupplier(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserSupplier", "d6f04859-c133-4f31-b897-9b0ba954d949"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserSupplier", "d6f04859-c133-4f31-b897-9b0ba954d949", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetSupplierUsersByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierUsersByUserId_maxRecords = 1;
if (datasetGetSupplierUsersByUserId_maxRecords < 1) datasetGetSupplierUsersByUserId_maxRecords = 1;
int datasetGetSupplierUsersByUserId_startIndex = 0;(localVars.queryResGetSupplierUsersByUserId_outParamList,localVars.queryResGetSupplierUsersByUserId_outParamCount) = await FuncActionGetUserSupplier.datasetGetSupplierUsersByUserId(requestContext,datasetGetSupplierUsersByUserId_maxRecords,datasetGetSupplierUsersByUserId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParami_GetUserId,cancellationToken);

// o_SupplierId = GetSupplierUsersByUserId.List.Current.SupplierUser.SupplierId
result.outParamo_SupplierId=localVars.queryResGetSupplierUsersByUserId_outParamList.CurrentRec.ssENSupplierUser.ssSupplierId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_SupplierId = result.outParamo_SupplierId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_SupplierId;
}

public static class FuncActionGetUserSupplier {

// Query Function "GetSupplierUsersByUserId" QeexLNDWVU6bSdp7UHVvAw of Action "GetUserSupplier"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUsersByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,string qpusi_GetUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserSupplier.GetSupplierUsersByUserId", "2cb1e741-d6d0-4e55-9b49-da7b50756f03");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserSupplier.GetSupplierUsersByUserId", "2cb1e741-d6d0-4e55-9b49-da7b50756f03", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.WUjw1jPBMU+4l5sLqVTZSQ/NodesNotShownInESpaceTree.QeexLNDWVU6bSdp7UHVvAw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"ensupplieruser13\".\"supplierid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser13\"");
whereBuilder.Append(" WHERE (\"ensupplieruser13\".\"userid\" = (CASE WHEN (@qpusi_GetUserId <> '') THEN @qpusi_GetUserId ELSE @qpusGetUserId END)) AND (\"ensupplieruser13\".\"isactive\" = 1)");
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
RL_84bdfe424d1eb0223fc2b8cfa9bb96be outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserSupplier.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserSupplier.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
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



}


}
