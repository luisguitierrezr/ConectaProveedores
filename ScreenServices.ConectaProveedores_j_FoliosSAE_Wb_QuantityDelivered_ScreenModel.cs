using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel).Namespace);

    public long inParamOrderMainItemID;
public AggregateRecord<RL_f09a54b116410a7027db4eb30998df1e> ScreenDataSetGetFolioItemsByOrderMainItemId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_QuantityDelivered_ScreenModel(long inParamOrderMainItemID, AggregateRecord<RL_f09a54b116410a7027db4eb30998df1e> ScreenDataSetGetFolioItemsByOrderMainItemId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderMainItemID", "GetFolioItemsByOrderMainItemId", "ClientVars"}, new string[] {"inParamOrderMainItemID", "ScreenDataSetGetFolioItemsByOrderMainItemId", "clientVariables"});
this.inParamOrderMainItemID = inParamOrderMainItemID;
this.ScreenDataSetGetFolioItemsByOrderMainItemId = ScreenDataSetGetFolioItemsByOrderMainItemId;
this.clientVariables = clientVariables;
}



    
// Query Function "GetFolioItemsByOrderMainItemId" 538rmhQ7NkKC+C9bF2uiRg of Action "Wb_QuantityDelivered"
public static async Task<(RL_f09a54b116410a7027db4eb30998df1e,long)> datasetGetFolioItemsByOrderMainItemId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_QuantityDelivered.GetFolioItemsByOrderMainItemId", "9a2b7fe7-3b14-4236-82f8-2f5b176ba246");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_QuantityDelivered","j_FoliosSAE.Wb_QuantityDelivered.GetFolioItemsByOrderMainItemId");
// Query Iterations: Never
// Refresh Query AZNks4GDLUiz4YLBuE+D2g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.x4huPY3FHkemOfyhwUjU7g/ScreenDataSets.538rmhQ7NkKC+C9bF2uiRg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"enfolioitems13\".\"invoiceqtt\") \"invoiceqttsum\"");
fromBuilder.Append(" FROM {FolioItems} \"enfolioitems13\"");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItemId != 0) {
whereBuilder.Append("((\"enfolioitems13\".\"ordermainitemid\" = @qporOrderMainItemId) AND (\"enfolioitems13\".\"ordermainitemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItemId", DbType.Int64, qporOrderMainItemId);
} else {
whereBuilder.Append("(\"enfolioitems13\".\"ordermainitemid\" IS NULL)");
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
RL_f09a54b116410a7027db4eb30998df1e outParamList = new RL_f09a54b116410a7027db4eb30998df1e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_QuantityDelivered.GetFolioItemsByOrderMainItemId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f09a54b116410a7027db4eb30998df1e _tmp = new RL_f09a54b116410a7027db4eb30998df1e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_QuantityDelivered.GetFolioItemsByOrderMainItemId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f09a54b116410a7027db4eb30998df1e)_tmp;
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
