using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_AllOrders_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_AllOrders_ScreenModel).Namespace);

    public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public AggregateRecord<RL_823234b28f8a1e65f461ac57ab48bc32> ScreenDataSetGetOrderMain;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_AllOrders_ScreenModel() {
}



    public ConectaProveedores_e_Orders_AllOrders_ScreenModel(string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, AggregateRecord<RL_823234b28f8a1e65f461ac57ab48bc32> ScreenDataSetGetOrderMain, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"TableSort", "StartIndex", "MaxRecords", "GetOrderMain", "ClientVars"}, new string[] {"varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "ScreenDataSetGetOrderMain", "clientVariables"});
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.ScreenDataSetGetOrderMain = ScreenDataSetGetOrderMain;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_cbbe4b608ba4cd678dd3afd544ca547e> datasetGetOrderMainReadDbAsync(RC_cbbe4b608ba4cd678dd3afd544ca547e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMain" HhdCeCXGB06BnA7QNbrn6Q of Action "AllOrders"
public static async Task<(RL_823234b28f8a1e65f461ac57ab48bc32,long)> datasetGetOrderMain(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.AllOrders.GetOrderMain", "7842171e-c625-4e07-819c-0ed035bae7e9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("AllOrders","e_Orders.AllOrders.GetOrderMain");
// Query Iterations: Multiple
// Refresh Query Jkl+j5k140CKy8n3bkyiNw Iterations: Multiple
// Refresh Query 1pN+2INuQEqAigRu35RNVw Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.5kGMr7CBCUuIlrim2YDGbw/ScreenDataSets.HhdCeCXGB06BnA7QNbrn6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany38\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"enordermain98\".\"id\" o11, \"enordermain98\".\"ordernumber\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, \"enorderstatus8\".\"label\" o41, NULL o42, NULL o43, NULL o44, NULL o45");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain98\" Left JOIN {OrderStatus} \"enorderstatus8\" ON (\"enordermain98\".\"orderstatusid\" = \"enorderstatus8\".\"id\"))  Left JOIN {Company} \"encompany38\" ON (\"enordermain98\".\"companyid\" = \"encompany38\".\"id\")) ");
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Company", "OrderMain", "OrderStatus" }, new string[] { "ENCompany38", "ENOrderMain98", "ENOrderStatus8" }, new System.Collections.Generic.Dictionary<string, string>[] { ENCompanyEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
} else {
orderByBuilder.Append(" ORDER BY 1 ASC");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_823234b28f8a1e65f461ac57ab48bc32 outParamList = new RL_823234b28f8a1e65f461ac57ab48bc32();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.AllOrders.GetOrderMain.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.AllOrders.GetOrderMain.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_823234b28f8a1e65f461ac57ab48bc32 _tmp = new RL_823234b28f8a1e65f461ac57ab48bc32();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.AllOrders.GetOrderMain.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_823234b28f8a1e65f461ac57ab48bc32)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.AllOrders.GetOrderMain.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
