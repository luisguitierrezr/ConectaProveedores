using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_OrdersToComplement_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_OrdersToComplement_ScreenModel).Namespace);

    public string varLcl_TableSort;
public int varLcl_StartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetOrders;
public int varLcl_CountAfterFetchGetOrders;
public bool varLcl_Loading;
public RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysWithoutAssigmentList;
public RC_b2bab424cbee127fcb27bb237f9cab05 varLcl_ShowAssignPopUp;
public bool varLcl_ShowRejectPopUp;
public bool varLcl_IsSelectAll;
public bool varLcl_IsAnyLineSelected;
public bool varLcIsExecuting;
public RL_e86d03b22fb6d164e868d40e92a28f1a varLcl_OrderList;
public long varLcl_OrderIdToReject;
public AggregateRecord<RL_ae89b43259faf914dcb9547c573c4cd7> ScreenDataSetGetOrdersToComplement;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_OrdersToComplement_ScreenModel() {
}



    public ConectaProveedores_e_Orders_OrdersToComplement_ScreenModel(string varLcl_TableSort, int varLcl_StartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetOrders, int varLcl_CountAfterFetchGetOrders, bool varLcl_Loading, RL_a59fb62a79f0dae5316722bac67c6766 varLcl_DaysWithoutAssigmentList, RC_b2bab424cbee127fcb27bb237f9cab05 varLcl_ShowAssignPopUp, bool varLcl_ShowRejectPopUp, bool varLcl_IsSelectAll, bool varLcl_IsAnyLineSelected, bool varLcIsExecuting, RL_e86d03b22fb6d164e868d40e92a28f1a varLcl_OrderList, long varLcl_OrderIdToReject, AggregateRecord<RL_ae89b43259faf914dcb9547c573c4cd7> ScreenDataSetGetOrdersToComplement, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_TableSort", "l_StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetOrders", "l_CountAfterFetchGetOrders", "l_Loading", "l_DaysWithoutAssigmentList", "l_ShowAssignPopUp", "l_ShowRejectPopUp", "l_IsSelectAll", "l_IsAnyLineSelected", "IsExecuting", "l_OrderList", "l_OrderIdToReject", "GetOrdersToComplement", "ClientVars"}, new string[] {"varLcl_TableSort", "varLcl_StartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetOrders", "varLcl_CountAfterFetchGetOrders", "varLcl_Loading", "varLcl_DaysWithoutAssigmentList", "varLcl_ShowAssignPopUp", "varLcl_ShowRejectPopUp", "varLcl_IsSelectAll", "varLcl_IsAnyLineSelected", "varLcIsExecuting", "varLcl_OrderList", "varLcl_OrderIdToReject", "ScreenDataSetGetOrdersToComplement", "clientVariables"});
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetOrders = varLcl_ColumnJSONVarGetOrders;
this.varLcl_CountAfterFetchGetOrders = varLcl_CountAfterFetchGetOrders;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_DaysWithoutAssigmentList = varLcl_DaysWithoutAssigmentList;
this.varLcl_ShowAssignPopUp = varLcl_ShowAssignPopUp;
this.varLcl_ShowRejectPopUp = varLcl_ShowRejectPopUp;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsAnyLineSelected = varLcl_IsAnyLineSelected;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcl_OrderList = varLcl_OrderList;
this.varLcl_OrderIdToReject = varLcl_OrderIdToReject;
this.ScreenDataSetGetOrdersToComplement = ScreenDataSetGetOrdersToComplement;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_96ee18663de42b81d96c758873824c1f> datasetGetOrdersToComplementReadDbAsync(RC_96ee18663de42b81d96c758873824c1f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssDaysWithoutAssigment = r.ReadInteger(index++, "CurrencyUserOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysWithoutAssigmentCompanySupplierRegionRecord.DaysWithoutAssigment", 0);
rec.ssIsSelected = r.ReadBoolean(index++, "CurrencyUserOrderStatusOrderApprovalOrderMainOrderApprovalLevelIsSelectedDaysWithoutAssigmentCompanySupplierRegionRecord.IsSelected", false);
return rec;
}
// Query Function "GetOrdersToComplement" L2+TIB87006D50gA1qmWaQ of Action "OrdersToComplement"
public static async Task<(RL_ae89b43259faf914dcb9547c573c4cd7,long)> datasetGetOrdersToComplement(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinDaysWithoutAssigment,string qpteOrderToComplement_Number,long qpsuOrderMain_SupplierId,long qpenOrderApprovalLevel_EntraRoleId,long qpreOrderMain_DivisionId,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.OrdersToComplement.GetOrdersToComplement", "20936f2f-3b1f-4ed3-83e7-4800d6a99669");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("OrdersToComplement","e_Orders.OrdersToComplement.GetOrdersToComplement");
// Query Iterations: Multiple
// Refresh Query Oa2VZ59b_06RQELqVE6_oA Iterations: Multiple
// Refresh Query 1RT+73dwyECUJw4PACnqYQ Iterations: Multiple
// Refresh Query XTKhZ3Txu0SmrgeTvbiOIg Iterations: Multiple
// Refresh Query zglpecfR1EKP2cWMlsihVg Iterations: Multiple
// Refresh Query UjB9oqzk1U+xTDSv2PF_3Q Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.oCb85LMP3EuKtCcaNiE97w/ScreenDataSets.L2+TIB87006D50gA1qmWaQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany41\".\"externalid\" o1, \"encompany41\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encurrency21\".\"code\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enorderapprovallevel30\".\"id\" o24, \"enorderapprovallevel30\".\"orderapprovalid\" o25, \"enorderapprovallevel30\".\"levelnumber\" o26, \"enorderapprovallevel30\".\"entraroleid\" o27, \"enorderapprovallevel30\".\"assignedto\" o28, \"enorderapprovallevel30\".\"assignedon\" o29, \"enorderapprovallevel30\".\"approvalstatusid\" o30, \"enorderapprovallevel30\".\"approvedby\" o31, \"enorderapprovallevel30\".\"approvedon\" o32, \"enorderapprovallevel30\".\"rejectedby\" o33, \"enorderapprovallevel30\".\"rejectedon\" o34, \"enorderapprovallevel30\".\"iscomplement\" o35, \"enorderapprovallevel30\".\"isreassigned\" o36, \"enorderapprovallevel30\".\"issubstitutefor\" o37, \"enorderapprovallevel30\".\"tomodifyby\" o38, \"enorderapprovallevel30\".\"tomodifyon\" o39, \"enorderapprovallevel30\".\"wascanceledby\" o40, \"enordermain103\".\"id\" o41, \"enordermain103\".\"ordernumber\" o42, \"enordermain103\".\"orderdate\" o43, \"enordermain103\".\"orderstatusid\" o44, \"enordermain103\".\"previousorderstatusid\" o45, \"enordermain103\".\"assignmentcode\" o46, \"enordermain103\".\"supplierid\" o47, \"enordermain103\".\"companyid\" o48, \"enordermain103\".\"documenttypeid\" o49, \"enordermain103\".\"currencyid\" o50, \"enordermain103\".\"telceldirectionid\" o51, \"enordermain103\".\"procurementgroup\" o52, \"enordermain103\".\"creatorsapnumber\" o53, \"enordermain103\".\"creatorsapname\" o54, \"enordermain103\".\"country\" o55, \"enordermain103\".\"isdeleted\" o56, \"enordermain103\".\"isreleased\" o57, trim_scale(\"enordermain103\".\"exchangerate\"::numeric) o58, \"enordermain103\".\"sustainabilitycategory\" o59, \"enordermain103\".\"sustainabilitysubcategory\" o60, trim_scale(\"enordermain103\".\"totalamount\"::numeric) o61, \"enordermain103\".\"fromcosmoz\" o62, \"enordermain103\".\"regionid\" o63, \"enordermain103\".\"divisionid\" o64, \"enordermain103\".\"applicant\" o65, \"enordermain103\".\"createdby\" o66, \"enordermain103\".\"createdon\" o67, \"enordermain103\".\"updatedby\" o68, \"enordermain103\".\"updatedon\" o69, NULL o70, \"enorderstatus12\".\"label\" o71, \"enorderstatus12\".\"class\" o72, NULL o73, NULL o74, NULL o75, NULL o76, \"enregion129\".\"code\" o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, \"ensupplier101\".\"name\" o91, \"ensupplier101\".\"number\" o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, (date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enordermain103\".\"createdon\" as date)::timestamptz)) \"dayswithoutassigment\", 0 \"isselected\"");
fromBuilder.Append(" FROM ((((({OrderApprovalLevel} \"enorderapprovallevel30\" Left JOIN {OrderApproval} \"enorderapproval31\" ON (\"enorderapprovallevel30\".\"orderapprovalid\" = \"enorderapproval31\".\"id\"))  Left JOIN ((({OrderMain} \"enordermain103\" Left JOIN {OrderStatus} \"enorderstatus12\" ON (\"enordermain103\".\"orderstatusid\" = \"enorderstatus12\".\"id\"))  Left JOIN {Supplier} \"ensupplier101\" ON (\"enordermain103\".\"supplierid\" = \"ensupplier101\".\"id\"))  Left JOIN {Company} \"encompany41\" ON (\"enordermain103\".\"companyid\" = \"encompany41\".\"id\"))  ON (\"enorderapproval31\".\"orderid\" = \"enordermain103\".\"id\"))  Left JOIN {Region} \"enregion129\" ON (\"enordermain103\".\"regionid\" = \"enregion129\".\"id\"))  Left JOIN {User} \"enuser180\" ON (\"enordermain103\".\"createdby\" = \"enuser180\".\"id\"))  Left JOIN {Currency} \"encurrency21\" ON (\"enordermain103\".\"currencyid\" = \"encurrency21\".\"code\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteOrderToComplement_Number != "" && qpteOrderToComplement_Number != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain103\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderToComplement_Number) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderToComplement_Number", DbType.String, qpteOrderToComplement_Number);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderToComplement_Number", DbType.String, qpteOrderToComplement_Number);
}
if (qpinDaysWithoutAssigment != 0) {
whereBuilder.Append("(((@qpinDaysWithoutAssigment = 3) AND ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enordermain103\".\"createdon\" as date)::timestamptz)) >= @qpinDaysWithoutAssigment)) OR ((date_part('day', cast((to_date(@qepCurrdate, 'YYYY-MM-DD')) as date)::timestamptz - cast(\"enordermain103\".\"createdon\" as date)::timestamptz)) = @qpinDaysWithoutAssigment)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinDaysWithoutAssigment", DbType.Int32, qpinDaysWithoutAssigment);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinDaysWithoutAssigment", DbType.Int32, qpinDaysWithoutAssigment);
sqlCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
sqlCountCmd.CreateParameterWithoutReplacements("@qepCurrdate", DbType.String, System.DateTime.UtcNow.ToString("yyyy-MM-dd"));
}
if (qpsuOrderMain_SupplierId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuOrderMain_SupplierId != 0) {
whereBuilder.Append("((\"enordermain103\".\"supplierid\" = @qpsuOrderMain_SupplierId) AND (\"enordermain103\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuOrderMain_SupplierId", DbType.Int64, qpsuOrderMain_SupplierId);
} else {
whereBuilder.Append("(\"enordermain103\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("((\"enordermain103\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append(") AND (\"enorderapprovallevel30\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("bxcfUQnAU0CWvUsA+ZfAjw"))).ssId);
whereBuilder.Append(")) AND ");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderapprovallevel30\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel30\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderapprovallevel30\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain103\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain103\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain103\".\"divisionid\" IS NULL)");
}
if ((qptel_TableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "User", "Supplier", "OrderMain", "OrderApproval", "OrderStatus", "OrderApprovalLevel", "Region", "Company", "Currency" }, new string[] { "ENUser180", "ENSupplier101", "ENOrderMain103", "ENOrderApproval31", "ENOrderStatus12", "ENOrderApprovalLevel30", "ENRegion129", "ENCompany41", "ENCurrency21" }, new System.Collections.Generic.Dictionary<string, string>[] { ENUserEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalEntity.AttributesToDatabaseNamesMap(), ENOrderStatusEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_ae89b43259faf914dcb9547c573c4cd7 outParamList = new RL_ae89b43259faf914dcb9547c573c4cd7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrdersToComplementReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {true, false, false, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersToComplement.GetOrdersToComplement.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.OrdersToComplement.GetOrdersToComplement.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ae89b43259faf914dcb9547c573c4cd7 _tmp = new RL_ae89b43259faf914dcb9547c573c4cd7();
_tmp.AlternateReadDbMethodAsync = datasetGetOrdersToComplementReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.OrdersToComplement.GetOrdersToComplement.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ae89b43259faf914dcb9547c573c4cd7)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query e_Orders.OrdersToComplement.GetOrdersToComplement.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
