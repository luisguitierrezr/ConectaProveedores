using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel).Namespace);

    public long inParamOrderFileId;
public bool varLcIsOpenPopupOtherFiles;
public AggregateRecord<RL_1952495fe738735251c431fd1e1fd0f1> ScreenDataSetGetOrderFileById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_OrderFinancialFilesPreview_ScreenModel(long inParamOrderFileId, bool varLcIsOpenPopupOtherFiles, AggregateRecord<RL_1952495fe738735251c431fd1e1fd0f1> ScreenDataSetGetOrderFileById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderFileId", "IsOpenPopupOtherFiles", "GetOrderFileById", "ClientVars"}, new string[] {"inParamOrderFileId", "varLcIsOpenPopupOtherFiles", "ScreenDataSetGetOrderFileById", "clientVariables"});
this.inParamOrderFileId = inParamOrderFileId;
this.varLcIsOpenPopupOtherFiles = varLcIsOpenPopupOtherFiles;
this.ScreenDataSetGetOrderFileById = ScreenDataSetGetOrderFileById;
this.clientVariables = clientVariables;
}



    
// Query Function "GetOrderFileById" ZcB4F0V61kW3qm1XEddt7g of Action "Wb_OrderFinancialFilesPreview"
public static async Task<(RL_1952495fe738735251c431fd1e1fd0f1,long)> datasetGetOrderFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderFinancialFilesPreview.GetOrderFileById", "1778c065-7a45-45d6-b7aa-6d5711d76dee");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderFinancialFilesPreview","e_Orders.Wb_OrderFinancialFilesPreview.GetOrderFileById");
// Query Iterations: Multiple
// Refresh Query MJ7XUFbKckuGoLCnczx7zw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.AzOS4qXVQEC4Nv8v+NwqXA/ScreenDataSets.ZcB4F0V61kW3qm1XEddt7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enorderfile8\".\"filename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enorderfile8\".\"storageid\" o7");
fromBuilder.Append(" FROM {OrderFile} \"enorderfile8\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enorderfile8\".\"id\" = @qporId) AND (\"enorderfile8\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enorderfile8\".\"id\" IS NULL)");
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
RL_1952495fe738735251c431fd1e1fd0f1 outParamList = new RL_1952495fe738735251c431fd1e1fd0f1();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderFinancialFilesPreview.GetOrderFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1952495fe738735251c431fd1e1fd0f1 _tmp = new RL_1952495fe738735251c431fd1e1fd0f1();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderFinancialFilesPreview.GetOrderFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1952495fe738735251c431fd1e1fd0f1)_tmp;
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
