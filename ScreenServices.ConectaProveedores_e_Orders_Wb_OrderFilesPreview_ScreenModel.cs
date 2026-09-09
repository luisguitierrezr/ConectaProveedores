using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel).Namespace);

    public long inParamOrderRequestFileId;
public bool varLcIsOpenPopupOtherFiles;
public AggregateRecord<RL_d258c3d50d870257794347fdeb7cc218> ScreenDataSetGetOrderRequestFileById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_OrderFilesPreview_ScreenModel(long inParamOrderRequestFileId, bool varLcIsOpenPopupOtherFiles, AggregateRecord<RL_d258c3d50d870257794347fdeb7cc218> ScreenDataSetGetOrderRequestFileById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderRequestFileId", "IsOpenPopupOtherFiles", "GetOrderRequestFileById", "ClientVars"}, new string[] {"inParamOrderRequestFileId", "varLcIsOpenPopupOtherFiles", "ScreenDataSetGetOrderRequestFileById", "clientVariables"});
this.inParamOrderRequestFileId = inParamOrderRequestFileId;
this.varLcIsOpenPopupOtherFiles = varLcIsOpenPopupOtherFiles;
this.ScreenDataSetGetOrderRequestFileById = ScreenDataSetGetOrderRequestFileById;
this.clientVariables = clientVariables;
}



    
// Query Function "GetOrderRequestFileById" Badu4xBBsU2eRwCUT8AFqA of Action "Wb_OrderFilesPreview"
public static async Task<(RL_d258c3d50d870257794347fdeb7cc218,long)> datasetGetOrderRequestFileById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderFilesPreview.GetOrderRequestFileById", "e36ea705-4110-4db1-9e47-00944fc005a8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderFilesPreview","e_Orders.Wb_OrderFilesPreview.GetOrderRequestFileById");
// Query Iterations: Multiple
// Refresh Query lISQzkyikEupW1aHbdddSg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.yw6Fjn+tB0O0jKImtO8JUQ/ScreenDataSets.Badu4xBBsU2eRwCUT8AFqA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enorderrequestfile13\".\"filename\" o3, \"enorderrequestfile13\".\"storageid\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16");
fromBuilder.Append(" FROM {OrderRequestFile} \"enorderrequestfile13\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enorderrequestfile13\".\"id\" = @qporId) AND (\"enorderrequestfile13\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enorderrequestfile13\".\"id\" IS NULL)");
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
RL_d258c3d50d870257794347fdeb7cc218 outParamList = new RL_d258c3d50d870257794347fdeb7cc218();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderFilesPreview.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d258c3d50d870257794347fdeb7cc218 _tmp = new RL_d258c3d50d870257794347fdeb7cc218();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderFilesPreview.GetOrderRequestFileById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d258c3d50d870257794347fdeb7cc218)_tmp;
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
