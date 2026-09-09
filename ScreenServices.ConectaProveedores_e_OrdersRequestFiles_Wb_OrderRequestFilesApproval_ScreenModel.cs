using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel).Namespace);

    public long inParami_OrderId;
public string varLcl_ColumnJSONVar;
public bool varLcl_ReInvokeToggler;
public int varLcl_CountAfterFetch;
public int varLcl_StartIndex;
public string varLcTableSort;
public bool varLcShowHideOrdReqFileRejectPopup;
public long varLcl_OrderRequestFileApprovalLevelId;
public AggregateRecord<RL_973c3440756f350a5cffc50d9d6bb1d9> ScreenDataSetGetOrderRequestFileApprovalLevels;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel() {
}



    public ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_ScreenModel(long inParami_OrderId, string varLcl_ColumnJSONVar, bool varLcl_ReInvokeToggler, int varLcl_CountAfterFetch, int varLcl_StartIndex, string varLcTableSort, bool varLcShowHideOrdReqFileRejectPopup, long varLcl_OrderRequestFileApprovalLevelId, AggregateRecord<RL_973c3440756f350a5cffc50d9d6bb1d9> ScreenDataSetGetOrderRequestFileApprovalLevels, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "l_ColumnJSONVar", "l_ReInvokeToggler", "l_CountAfterFetch", "l_StartIndex", "TableSort", "ShowHideOrdReqFileRejectPopup", "l_OrderRequestFileApprovalLevelId", "GetOrderRequestFileApprovalLevels", "ClientVars"}, new string[] {"inParami_OrderId", "varLcl_ColumnJSONVar", "varLcl_ReInvokeToggler", "varLcl_CountAfterFetch", "varLcl_StartIndex", "varLcTableSort", "varLcShowHideOrdReqFileRejectPopup", "varLcl_OrderRequestFileApprovalLevelId", "ScreenDataSetGetOrderRequestFileApprovalLevels", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcTableSort = varLcTableSort;
this.varLcShowHideOrdReqFileRejectPopup = varLcShowHideOrdReqFileRejectPopup;
this.varLcl_OrderRequestFileApprovalLevelId = varLcl_OrderRequestFileApprovalLevelId;
this.ScreenDataSetGetOrderRequestFileApprovalLevels = ScreenDataSetGetOrderRequestFileApprovalLevels;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_0a31a39e5189fa78e8cbab87cf47752b> datasetGetOrderRequestFileApprovalLevelsReadDbAsync(RC_0a31a39e5189fa78e8cbab87cf47752b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderRequestFile.Read( r, ref index);
rec.ssENOrderRequestFileApproval.Read( r, ref index);
rec.ssENOrderRequestFileApprovalLevel.Read( r, ref index);
rec.ssENStorage.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderRequestFileApprovalLevels" j7cFXOG5Ik6btmk0dn6t1w of Action "Wb_OrderRequestFilesApproval"
public static async Task<(RL_973c3440756f350a5cffc50d9d6bb1d9,long)> datasetGetOrderRequestFileApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenOrderRequestFileApprovalLevel_EntraRoleId,string qpusOrderRequestFileApprovalLevel_AssignedTo,long qpreOrderMain_DivisionId,long qporOrderMain_Id,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels", "5c05b78f-b9e1-4e22-9bb6-6934767eadd7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderRequestFilesApproval","e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels");
// Query Iterations: Multiple
// Refresh Query orM99wK+KESigoes+YwLZg Iterations: Multiple
// Refresh Query 5CMRpAPH6UaKQpjvbDJNaw Iterations: Multiple
// Refresh Query nC4pslcbtEWfVF3+guQQ0g Iterations: Multiple
// Refresh Query Nud39E+_dESb38Q8Jh0sjw Iterations: Multiple
// Refresh Query tc5GXZHLWEKhiG5MHvCIuA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.QVuy0_xq1k6uAfJb8WCO0A/NodesShownInESpaceTree.uoraln29kECcCzEppI9ilg/ScreenDataSets.j7cFXOG5Ik6btmk0dn6t1w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapprovalstatus29\".\"label\" o1, \"enapprovalstatus29\".\"class\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"eninvoice141\".\"id\" o16, \"eninvoice141\".\"name\" o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"eninvoice141\".\"invoicestatusid\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, \"eninvoicestatus19\".\"label\" o41, \"eninvoicestatus19\".\"class\" o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enordermain120\".\"id\" o47, \"enordermain120\".\"ordernumber\" o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, \"enorderrequestfile16\".\"invoiceid\" o78, \"enorderrequestfile16\".\"filename\" o79, \"enorderrequestfile16\".\"storageid\" o80, \"enorderrequestfile16\".\"description\" o81, NULL o82, \"enorderrequestfile16\".\"isapproved\" o83, \"enorderrequestfile16\".\"isrejected\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, \"enorderrequestfileapprovallevel6\".\"id\" o99, NULL o100, NULL o101, NULL o102, NULL o103, \"enorderrequestfileapprovallevel6\".\"approvalstatusid\" o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, \"enstorage32\".\"size\" o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135");
fromBuilder.Append(" FROM ((((((((({OrderRequestFile} \"enorderrequestfile16\" Inner JOIN {OrderMain} \"enordermain120\" ON (\"enorderrequestfile16\".\"orderid\" = \"enordermain120\".\"id\"))  Right JOIN {OrderRequestFileApproval} \"enorderrequestfileapproval7\" ON (\"enorderrequestfileapproval7\".\"orderrequestfileid\" = \"enorderrequestfile16\".\"id\"))  Right JOIN {OrderRequestFileApprovalLevel} \"enorderrequestfileapprovallevel6\" ON (\"enorderrequestfileapprovallevel6\".\"orderrequestfileapprovalid\" = \"enorderrequestfileapproval7\".\"id\"))  Left JOIN {EntraRole} \"enentrarole71\" ON (\"enorderrequestfileapprovallevel6\".\"entraroleid\" = \"enentrarole71\".\"id\"))  Left JOIN {User} \"enuser212\" ON (\"enorderrequestfileapprovallevel6\".\"assignedto\" = \"enuser212\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus29\" ON (\"enorderrequestfileapprovallevel6\".\"approvalstatusid\" = \"enapprovalstatus29\".\"id\"))  Left JOIN {Storage} \"enstorage32\" ON (\"enorderrequestfile16\".\"storageid\" = \"enstorage32\".\"id\"))  Left JOIN {Invoice} \"eninvoice141\" ON (\"enorderrequestfile16\".\"invoiceid\" = \"eninvoice141\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus19\" ON (\"eninvoice141\".\"invoicestatusid\" = \"eninvoicestatus19\".\"id\")) ");
whereBuilder.Append(" WHERE (");
if ((qpusOrderRequestFileApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enorderrequestfileapprovallevel6\".\"assignedto\" = @qpusOrderRequestFileApprovalLevel_AssignedTo) AND (\"enorderrequestfileapprovallevel6\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusOrderRequestFileApprovalLevel_AssignedTo", DbType.String, qpusOrderRequestFileApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusOrderRequestFileApprovalLevel_AssignedTo", DbType.String, qpusOrderRequestFileApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enorderrequestfileapprovallevel6\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR (((\"enorderrequestfileapprovallevel6\".\"assignedto\" IS NULL) AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain120\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain120\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain120\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(") AND ");
if (qpenOrderRequestFileApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderrequestfileapprovallevel6\".\"entraroleid\" = @qpenOrderRequestFileApprovalLevel_EntraRoleId) AND (\"enorderrequestfileapprovallevel6\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderRequestFileApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderRequestFileApprovalLevel_EntraRoleId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpenOrderRequestFileApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderRequestFileApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderrequestfileapprovallevel6\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
if (qporOrderMain_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain120\".\"id\" = @qporOrderMain_Id) AND (\"enordermain120\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain120\".\"id\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "OrderRequestFile", "EntraRole", "OrderMain", "Storage", "User", "Invoice", "InvoiceStatus", "OrderRequestFileApproval", "ApprovalStatus", "OrderRequestFileApprovalLevel" }, new string[] { "ENOrderRequestFile16", "ENEntraRole71", "ENOrderMain120", "ENStorage32", "ENUser212", "ENInvoice141", "ENInvoiceStatus19", "ENOrderRequestFileApproval7", "ENApprovalStatus29", "ENOrderRequestFileApprovalLevel6" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderRequestFileEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENStorageEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENOrderRequestFileApprovalEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENOrderRequestFileApprovalLevelEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_973c3440756f350a5cffc50d9d6bb1d9 outParamList = new RL_973c3440756f350a5cffc50d9d6bb1d9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderRequestFileApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, true, true, false, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, false, false, false, true, false, false, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_973c3440756f350a5cffc50d9d6bb1d9 _tmp = new RL_973c3440756f350a5cffc50d9d6bb1d9();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderRequestFileApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_973c3440756f350a5cffc50d9d6bb1d9)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.GetOrderRequestFileApprovalLevels.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
