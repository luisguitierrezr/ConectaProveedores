using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel).Namespace);

    public string varLcl_ColumnJSONVar;
public bool varLcl_ReInvokeToggler;
public int varLcl_CountAfterFetch;
public int varLcl_StartIndex;
public string varLcTableSort;
public AggregateRecord<RL_ef17ec11e9847e3aee2e73d3f7420983> ScreenDataSetGetOrderRequestFileApprovalLevels;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel() {
}



    public ConectaProveedores_e_OrdersRequestFiles_OrderRequestFilesApproval_ScreenModel(string varLcl_ColumnJSONVar, bool varLcl_ReInvokeToggler, int varLcl_CountAfterFetch, int varLcl_StartIndex, string varLcTableSort, AggregateRecord<RL_ef17ec11e9847e3aee2e73d3f7420983> ScreenDataSetGetOrderRequestFileApprovalLevels, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ColumnJSONVar", "l_ReInvokeToggler", "l_CountAfterFetch", "l_StartIndex", "TableSort", "GetOrderRequestFileApprovalLevels", "ClientVars"}, new string[] {"varLcl_ColumnJSONVar", "varLcl_ReInvokeToggler", "varLcl_CountAfterFetch", "varLcl_StartIndex", "varLcTableSort", "ScreenDataSetGetOrderRequestFileApprovalLevels", "clientVariables"});
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcTableSort = varLcTableSort;
this.ScreenDataSetGetOrderRequestFileApprovalLevels = ScreenDataSetGetOrderRequestFileApprovalLevels;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_6fe7a87544f5e670c064f35599cfc737> datasetGetOrderRequestFileApprovalLevelsReadDbAsync(RC_6fe7a87544f5e670c064f35599cfc737 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssClass = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Class", "");
rec.ssCode = r.ReadEntityReferenceText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Code", "");
rec.ssDescription = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Description", "");
rec.ssId = r.ReadEntityReferenceLongInteger(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Id", 0L);
rec.ssLabel = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Label", "");
rec.ssOrderDate = r.ReadDate(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.OrderDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
rec.ssOrderNumber = r.ReadText(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.OrderNumber", "");
rec.ssTotalAmount = r.ReadCurrency(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.TotalAmount", 0.0M);
rec.ssCount = r.ReadLongInteger(index++, "CodeIdClassDescriptionLabelOrderNumberOrderDateCountTotalAmountRecord.Count", 0L);
return rec;
}
// Query Function "GetOrderRequestFileApprovalLevels" XJugZDDURkqUM2FCJIzrGw of Action "OrderRequestFilesApproval"
public static async Task<(RL_ef17ec11e9847e3aee2e73d3f7420983,long)> datasetGetOrderRequestFileApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenOrderRequestFileApprovalLevel_EntraRoleId,string qpusOrderRequestFileApprovalLevel_AssignedTo,long qpreOrderMain_DivisionId,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_OrdersRequestFiles.OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels", "64a09b5c-d430-4a46-9433-6142248ceb1b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrderRequestFilesApproval","e_OrdersRequestFiles.OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels");
// Query Iterations: Multiple
// Refresh Query M04LyUqElUWauHS0LmIjTg Iterations: Multiple
// Refresh Query +rbdrVc9HUmfBlqpfptBGA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.QVuy0_xq1k6uAfJb8WCO0A/NodesShownInESpaceTree.BODqIdZP_EyluCtKvJ1QGw/ScreenDataSets.XJugZDDURkqUM2FCJIzrGw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderstatus17\".\"class\" \"class\", \"encurrency35\".\"code\" \"code\", \"encompany61\".\"description\" \"description\", \"enordermain119\".\"id\" \"id\", \"enorderstatus17\".\"label\" \"label\", \"enordermain119\".\"orderdate\" \"orderdate\", \"enordermain119\".\"ordernumber\" \"ordernumber\", \"enordermain119\".\"totalamount\" \"totalamount\", Count(\"enorderrequestfileapprovallevel5\".\"id\") \"count\"");
fromBuilder.Append(" FROM ((((({OrderRequestFileApprovalLevel} \"enorderrequestfileapprovallevel5\" Left JOIN {OrderRequestFileApproval} \"enorderrequestfileapproval6\" ON (\"enorderrequestfileapprovallevel5\".\"orderrequestfileapprovalid\" = \"enorderrequestfileapproval6\".\"id\"))  Left JOIN (((({OrderRequestFile} \"enorderrequestfile15\" Inner JOIN {OrderMain} \"enordermain119\" ON (\"enorderrequestfile15\".\"orderid\" = \"enordermain119\".\"id\"))  Left JOIN {Company} \"encompany61\" ON (\"enordermain119\".\"companyid\" = \"encompany61\".\"id\"))  Left JOIN {OrderStatus} \"enorderstatus17\" ON (\"enordermain119\".\"orderstatusid\" = \"enorderstatus17\".\"id\"))  Left JOIN {Currency} \"encurrency35\" ON (\"enordermain119\".\"currencyid\" = \"encurrency35\".\"code\"))  ON (\"enorderrequestfileapproval6\".\"orderrequestfileid\" = \"enorderrequestfile15\".\"id\"))  Left JOIN {EntraRole} \"enentrarole70\" ON (\"enorderrequestfileapprovallevel5\".\"entraroleid\" = \"enentrarole70\".\"id\"))  Left JOIN {User} \"enuser211\" ON (\"enorderrequestfileapprovallevel5\".\"assignedto\" = \"enuser211\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus28\" ON (\"enorderrequestfileapprovallevel5\".\"approvalstatusid\" = \"enapprovalstatus28\".\"id\")) ");
whereBuilder.Append(" WHERE (");
if ((qpusOrderRequestFileApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enorderrequestfileapprovallevel5\".\"assignedto\" = @qpusOrderRequestFileApprovalLevel_AssignedTo) AND (\"enorderrequestfileapprovallevel5\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusOrderRequestFileApprovalLevel_AssignedTo", DbType.String, qpusOrderRequestFileApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusOrderRequestFileApprovalLevel_AssignedTo", DbType.String, qpusOrderRequestFileApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enorderrequestfileapprovallevel5\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR (((\"enorderrequestfileapprovallevel5\".\"assignedto\" IS NULL) AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain119\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain119\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain119\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(") AND ");
if (qpenOrderRequestFileApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderrequestfileapprovallevel5\".\"entraroleid\" = @qpenOrderRequestFileApprovalLevel_EntraRoleId) AND (\"enorderrequestfileapprovallevel5\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderRequestFileApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderRequestFileApprovalLevel_EntraRoleId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpenOrderRequestFileApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderRequestFileApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderrequestfileapprovallevel5\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(")) AND (\"enorderrequestfileapprovallevel5\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(")");
groupByBuilder.Append(" GROUP BY \"encurrency35\".\"code\", \"encompany61\".\"description\", \"enordermain119\".\"totalamount\", \"enorderstatus17\".\"label\", \"enordermain119\".\"ordernumber\", \"enordermain119\".\"id\", \"enordermain119\".\"orderdate\", \"enorderstatus17\".\"class\"");
orderByBuilder.Append(" ORDER BY 1 ASC");
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
sqlCount = "SELECT COUNT(1) FROM (SELECT 1 as cnt " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString() + ") cnt";
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_ef17ec11e9847e3aee2e73d3f7420983 outParamList = new RL_ef17ec11e9847e3aee2e73d3f7420983();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRequestFileApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_OrdersRequestFiles.OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_OrdersRequestFiles.OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ef17ec11e9847e3aee2e73d3f7420983 _tmp = new RL_ef17ec11e9847e3aee2e73d3f7420983();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRequestFileApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_OrdersRequestFiles.OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ef17ec11e9847e3aee2e73d3f7420983)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_OrdersRequestFiles.OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
