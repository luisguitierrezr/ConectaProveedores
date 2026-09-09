namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetUserTelcelDirectionId : VarsBag {
public string inParami_GetUserId;
public RL_605921a60a3ac4dd1382c185e90bacac queryResGetUserTelcelDireccion_outParamList = new RL_605921a60a3ac4dd1382c185e90bacac();
public long queryResGetUserTelcelDireccion_outParamCount = 0L;

public lcvGetUserTelcelDirectionId(string inParami_GetUserId) {
this.inParami_GetUserId = inParami_GetUserId;
}
}
public class lcoGetUserTelcelDirectionId : VarsBag {
public long outParamo_TelcelDirectionId = 0L;

public lcoGetUserTelcelDirectionId() {
}
}
/// <summary>
/// Action <code>GetUserTelcelDirectionId</code> that represents the Service Studio action
///  <code>GetUserTelcelDirectionId</code> <p> Description: Action to get Telcel Direccion Id fro
/// m logged user</p>
/// </summary>
public static async Task<long> ActionGetUserTelcelDirectionId(IRequestContext requestContext,string inParami_GetUserId,CancellationToken cancellationToken) {
long outParamo_TelcelDirectionId = default;
lcoGetUserTelcelDirectionId result = new lcoGetUserTelcelDirectionId();
lcvGetUserTelcelDirectionId localVars = new lcvGetUserTelcelDirectionId(inParami_GetUserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetUserTelcelDirectionId", "4994144a-f824-4c8d-9d45-31329cff2a11"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetUserTelcelDirectionId", "4994144a-f824-4c8d-9d45-31329cff2a11", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserTelcelDireccion
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserTelcelDireccion_maxRecords = 1;
if (datasetGetUserTelcelDireccion_maxRecords < 1) datasetGetUserTelcelDireccion_maxRecords = 1;
int datasetGetUserTelcelDireccion_startIndex = 0;(localVars.queryResGetUserTelcelDireccion_outParamList,localVars.queryResGetUserTelcelDireccion_outParamCount) = await FuncActionGetUserTelcelDirectionId.datasetGetUserTelcelDireccion(requestContext,datasetGetUserTelcelDireccion_maxRecords,datasetGetUserTelcelDireccion_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),localVars.inParami_GetUserId,cancellationToken);

// o_TelcelDirectionId = GetUserTelcelDireccion.List.Current.TelcelDirectionId
result.outParamo_TelcelDirectionId=localVars.queryResGetUserTelcelDireccion_outParamList.CurrentRec.ssTelcelDirectionId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_TelcelDirectionId = result.outParamo_TelcelDirectionId;
} // inner-finally
RETURN_STATEMENT:
return outParamo_TelcelDirectionId;
}

public static class FuncActionGetUserTelcelDirectionId {

// Query Function "GetUserTelcelDireccion" ngS9pwc+BU2d9wY1KosB1g of Action "GetUserTelcelDirectionId"
public static async Task<(RL_605921a60a3ac4dd1382c185e90bacac,long)> datasetGetUserTelcelDireccion(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,string qpusi_GetUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetUserTelcelDirectionId.GetUserTelcelDireccion", "a7bd049e-3e07-4d05-9df7-06352a8b01d6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetUserTelcelDirectionId.GetUserTelcelDireccion", "a7bd049e-3e07-4d05-9df7-06352a8b01d6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ShSUSST4jUydRTEynP8qEQ/NodesNotShownInESpaceTree.ngS9pwc+BU2d9wY1KosB1g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enuser_extended_internal30\".\"telceldirectionid\" \"telceldirectionid\"");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal30\" Inner JOIN {User} \"enuser48\" ON (\"enuser_extended_internal30\".\"id\" = \"enuser48\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuser48\".\"id\" = (CASE WHEN (@qpusi_GetUserId <> '') THEN @qpusi_GetUserId ELSE @qpusGetUserId END))");
groupByBuilder.Append(" GROUP BY \"enuser_extended_internal30\".\"telceldirectionid\"");
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
RL_605921a60a3ac4dd1382c185e90bacac outParamList = new RL_605921a60a3ac4dd1382c185e90bacac();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetUserTelcelDirectionId.GetUserTelcelDireccion.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_605921a60a3ac4dd1382c185e90bacac _tmp = new RL_605921a60a3ac4dd1382c185e90bacac();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetUserTelcelDirectionId.GetUserTelcelDireccion.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_605921a60a3ac4dd1382c185e90bacac)_tmp;
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
