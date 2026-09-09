namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveOrderRequestFiles : VarsBag {
public long inParami_OrderId;
public RL_9d3b4c4e80b371ac0dc01854afca347a inParamSource;
public RL_39842304b010e66ad38d0f73c466d0e1 queryResGetOrderRequestFilesByOrderId_outParamList = new RL_39842304b010e66ad38d0f73c466d0e1();
public long queryResGetOrderRequestFilesByOrderId_outParamCount = 0L;

public int resListIndexOf_outParamPosition = 0;

public Actions.lcoOrderRequestFileCreateOrUpdate resOrderRequestFileCreateOrUpdate =  new Actions.lcoOrderRequestFileCreateOrUpdate();
public lcvSaveOrderRequestFiles(long inParami_OrderId, RL_9d3b4c4e80b371ac0dc01854afca347a inParamSource) {
this.inParami_OrderId = inParami_OrderId;
this.inParamSource = inParamSource;
}
}
/// <summary>
/// Action <code>SaveOrderRequestFiles</code> that represents the Service Studio action
///  <code>SaveOrderRequestFiles</code> <p> Description: Save OrderRequestFiles</p>
/// </summary>
public static async Task ActionSaveOrderRequestFiles(IRequestContext requestContext,long inParami_OrderId,RL_9d3b4c4e80b371ac0dc01854afca347a inParamSource,CancellationToken cancellationToken) {
lcvSaveOrderRequestFiles localVars = new lcvSaveOrderRequestFiles(inParami_OrderId, inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveOrderRequestFiles", "3c0de1c8-19c1-487d-8c0c-e13f320aa7cf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveOrderRequestFiles", "3c0de1c8-19c1-487d-8c0c-e13f320aa7cf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetOrderRequestFilesByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderRequestFilesByOrderId_maxRecords = 0;
int datasetGetOrderRequestFilesByOrderId_startIndex = 0;(localVars.queryResGetOrderRequestFilesByOrderId_outParamList,localVars.queryResGetOrderRequestFilesByOrderId_outParamCount) = await FuncActionSaveOrderRequestFiles.datasetGetOrderRequestFilesByOrderId(requestContext,datasetGetOrderRequestFilesByOrderId_maxRecords,datasetGetOrderRequestFilesByOrderId_startIndex,IterationMultiplicity.Single,localVars.inParami_OrderId,cancellationToken);

// Foreach GetOrderRequestFilesByOrderId.List
localVars.queryResGetOrderRequestFilesByOrderId_outParamList.StartIteration();
try {while (!((localVars.queryResGetOrderRequestFilesByOrderId_outParamList.Eof))) {
// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.inParamSource,async (p, cancellationToken) => (p.ssOrderRequestFile.ssId==localVars.queryResGetOrderRequestFilesByOrderId_outParamList.CurrentRec.ssENOrderRequestFile.ssId),cancellationToken);

if(((localVars.resListIndexOf_outParamPosition==(-1)))) {
// DeleteOrderRequestFile
await ExtendedActions.DeleteOrderRequestFile(requestContext,localVars.queryResGetOrderRequestFilesByOrderId_outParamList.CurrentRec.ssENOrderRequestFile.ssId,cancellationToken);

}

localVars.queryResGetOrderRequestFilesByOrderId_outParamList.Advance();
}

} finally {
localVars.queryResGetOrderRequestFilesByOrderId_outParamList.EndIteration();
}

// Foreach Source
localVars.inParamSource.StartIteration();
try {while (!((localVars.inParamSource.Eof))) {
// OrderRequestFileCreateOrUpdate
localVars.resOrderRequestFileCreateOrUpdate.outParamId = await Actions.ActionOrderRequestFileCreateOrUpdate(requestContext,localVars.inParamSource.CurrentRec.ssOrderRequestFile,cancellationToken);

localVars.inParamSource.Advance();
}

} finally {
localVars.inParamSource.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionSaveOrderRequestFiles {

private static async Task<RC_8c4427441293dc27b4cc40905a444588> datasetGetOrderRequestFilesByOrderIdReadDbAsync(RC_8c4427441293dc27b4cc40905a444588 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetOrderRequestFilesByOrderId" g593DDBU4kuB0yb3wM3iLg of Action "SaveOrderRequestFiles"
public static async Task<(RL_39842304b010e66ad38d0f73c466d0e1,long)> datasetGetOrderRequestFilesByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderRequestFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveOrderRequestFiles.GetOrderRequestFilesByOrderId", "0c779f83-5430-4be2-81d3-26f7c0cde22e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveOrderRequestFiles.GetOrderRequestFilesByOrderId", "0c779f83-5430-4be2-81d3-26f7c0cde22e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.yOENPMEZfUiMDOE_Mgqnzw/NodesNotShownInESpaceTree.g593DDBU4kuB0yb3wM3iLg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enorderrequestfile3\".\"id\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73");
fromBuilder.Append(" FROM (({OrderRequestFile} \"enorderrequestfile3\" Inner JOIN {OrderMain} \"enordermain18\" ON (\"enorderrequestfile3\".\"orderid\" = \"enordermain18\".\"id\"))  Inner JOIN {Supplier} \"ensupplier9\" ON (\"enordermain18\".\"supplierid\" = \"ensupplier9\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderRequestFile_OrderId != 0) {
whereBuilder.Append("((\"enorderrequestfile3\".\"orderid\" = @qporOrderRequestFile_OrderId) AND (\"enorderrequestfile3\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderRequestFile_OrderId", DbType.Int64, qporOrderRequestFile_OrderId);
} else {
whereBuilder.Append("(\"enorderrequestfile3\".\"orderid\" IS NULL)");
}
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
RL_39842304b010e66ad38d0f73c466d0e1 outParamList = new RL_39842304b010e66ad38d0f73c466d0e1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRequestFilesByOrderIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveOrderRequestFiles.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39842304b010e66ad38d0f73c466d0e1 _tmp = new RL_39842304b010e66ad38d0f73c466d0e1();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRequestFilesByOrderIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveOrderRequestFiles.GetOrderRequestFilesByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39842304b010e66ad38d0f73c466d0e1)_tmp;
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
