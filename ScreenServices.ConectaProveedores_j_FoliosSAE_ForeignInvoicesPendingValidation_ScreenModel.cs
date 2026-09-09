using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel).Namespace);

    public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_ReInvokeToggler;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatuses;
public AggregateRecord<RL_13a8c992e2340d724ae09e59b85c1da0> ScreenDataSetGetFolioApprovalLevelsByAssignedTo;
public ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_DataActionGetUserData_Model varLcGetUserData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel(string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatuses, AggregateRecord<RL_13a8c992e2340d724ae09e59b85c1da0> ScreenDataSetGetFolioApprovalLevelsByAssignedTo, ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_DataActionGetUserData_Model varLcGetUserData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ColumnJSONVar", "l_CountAfterFetch", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "GetFolioStatuses", "GetFolioApprovalLevelsByAssignedTo", "GetUserData", "ClientVars"}, new string[] {"varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "ScreenDataSetGetFolioStatuses", "ScreenDataSetGetFolioApprovalLevelsByAssignedTo", "varLcGetUserData", "clientVariables"});
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.ScreenDataSetGetFolioStatuses = ScreenDataSetGetFolioStatuses;
this.ScreenDataSetGetFolioApprovalLevelsByAssignedTo = ScreenDataSetGetFolioApprovalLevelsByAssignedTo;
this.varLcGetUserData = varLcGetUserData;
this.clientVariables = clientVariables;
}



    
// Query Function "GetFolioStatuses" rcjXgyQDr0SUo47YQA6Cqg of Action "ForeignInvoicesPendingValidation"
public static async Task<(RL_ba9fc810801f4aabee0bc4ef3685a9dd,long)> datasetGetFolioStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioStatuses", "83d7c8ad-0324-44af-94a3-8ed8400e82aa");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ForeignInvoicesPendingValidation","j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioStatuses");
// Query Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.L51JMaF2s0Oh7rzvGFLnkA/ScreenDataSets.rcjXgyQDr0SUo47YQA6Cqg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliostatus14\".\"id\" o0, \"enfoliostatus14\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {FolioStatus} \"enfoliostatus14\"");
whereBuilder.Append(" WHERE (\"enfoliostatus14\".\"is_active\" = 1) AND ((\"enfoliostatus14\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("ZfpLpTdXy0CRfRTjg6qPeA"))).ssId);
whereBuilder.Append(") OR (\"enfoliostatus14\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("OvBzn51W8EyWJHs2cALRmQ"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"enfoliostatus14\".\"labeles\" ASC ");
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
RL_ba9fc810801f4aabee0bc4ef3685a9dd outParamList = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ba9fc810801f4aabee0bc4ef3685a9dd _tmp = new RL_ba9fc810801f4aabee0bc4ef3685a9dd();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ba9fc810801f4aabee0bc4ef3685a9dd)_tmp;
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

private static async Task<RC_f71d1ebfeb3771da2f91490300d5ded2> datasetGetFolioApprovalLevelsByAssignedToReadDbAsync(RC_f71d1ebfeb3771da2f91490300d5ded2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevelsByAssignedTo" e+xQ8reGakivQYjOxhFiYg of Action "ForeignInvoicesPendingValidation"
public static async Task<(RL_13a8c992e2340d724ae09e59b85c1da0,long)> datasetGetFolioApprovalLevelsByAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,int qpfoFolio_FolioStatusId,string qpusFolioApprovalLevel_AssignedTo,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioApprovalLevelsByAssignedTo", "f250ec7b-86b7-486a-af41-88cec6116262");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("ForeignInvoicesPendingValidation","j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioApprovalLevelsByAssignedTo");
// Query Iterations: Multiple
// Refresh Query srY3YVGkmk+F7cFY_K74fA Iterations: Multiple
// Refresh Query mvUbcuCxrEuQK0TX+uYRXA Iterations: Multiple
// Refresh Query glIeOMZTCky_i7pi6U0k1Q Iterations: Multiple
// Refresh Query qtFVcTEgLU62xg2O2abMcQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.L51JMaF2s0Oh7rzvGFLnkA/ScreenDataSets.e+xQ8reGakivQYjOxhFiYg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapprovalstatus32\".\"class\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enapprovalstatus32\".\"labeles\" o9, \"encurrency45\".\"code\" o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enfolio86\".\"id\" o15, NULL o16, \"enfolio86\".\"folionumber\" o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, trim_scale(\"enfolio86\".\"totalamount\"::numeric) o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, \"enfoliostatus15\".\"class\" o67, NULL o68, NULL o69, \"enfoliostatus15\".\"labeles\" o70, NULL o71, \"enordermain128\".\"ordernumber\" o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, \"enregion182\".\"code\" o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, \"ensupplier134\".\"name\" o115, \"ensupplier134\".\"number\" o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140");
fromBuilder.Append(" FROM (((((((({FolioApprovalLevel} \"enfolioapprovallevel45\" Left JOIN {FolioApproval} \"enfolioapproval49\" ON (\"enfolioapprovallevel45\".\"folioapprovalid\" = \"enfolioapproval49\".\"id\"))  Left JOIN {Folio} \"enfolio86\" ON (\"enfolioapproval49\".\"folioid\" = \"enfolio86\".\"id\"))  Left JOIN {Supplier} \"ensupplier134\" ON (\"enfolio86\".\"supplierid\" = \"ensupplier134\".\"id\"))  Left JOIN {OrderMain} \"enordermain128\" ON (\"enfolio86\".\"orderid\" = \"enordermain128\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus15\" ON (\"enfolio86\".\"foliostatusid\" = \"enfoliostatus15\".\"id\"))  Left JOIN {Region} \"enregion182\" ON (\"enordermain128\".\"divisionid\" = \"enregion182\".\"id\"))  Left JOIN {Currency} \"encurrency45\" ON (\"enfolio86\".\"currencyid\" = \"encurrency45\".\"code\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus32\" ON (\"enfolioapprovallevel45\".\"approvalstatusid\" = \"enapprovalstatus32\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel45\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel45\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enfolioapprovallevel45\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel45\".\"isinvoiceapproval\" = 1) AND (((\"enfolioapprovallevel45\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") OR (\"enfolioapprovallevel45\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rm4bAZ7dOEqgMcZKM9wLxg"))).ssId);
whereBuilder.Append(")) OR (\"enfolioapprovallevel45\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
whereBuilder.Append(")) AND ");
if (qpfoFolio_FolioStatusId != BuiltInFunction.NullIdentifier()) {
if (qpfoFolio_FolioStatusId != 0) {
whereBuilder.Append("((\"enfolio86\".\"foliostatusid\" = @qpfoFolio_FolioStatusId) AND (\"enfolio86\".\"foliostatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_FolioStatusId", DbType.Int32, qpfoFolio_FolioStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolio_FolioStatusId", DbType.Int32, qpfoFolio_FolioStatusId);
} else {
whereBuilder.Append("(\"enfolio86\".\"foliostatusid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "ApprovalStatus", "FolioStatus", "Region", "OrderMain", "FolioApproval", "Currency", "Folio", "FolioApprovalLevel", "Supplier" }, new string[] { "ENApprovalStatus32", "ENFolioStatus15", "ENRegion182", "ENOrderMain128", "ENFolioApproval49", "ENCurrency45", "ENFolio86", "ENFolioApprovalLevel45", "ENSupplier134" }, new System.Collections.Generic.Dictionary<string, string>[] { ENApprovalStatusEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolioapprovallevel45\".\"id\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
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
RL_13a8c992e2340d724ae09e59b85c1da0 outParamList = new RL_13a8c992e2340d724ae09e59b85c1da0();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsByAssignedToReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, false});
opt[6] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioApprovalLevelsByAssignedTo.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_13a8c992e2340d724ae09e59b85c1da0 _tmp = new RL_13a8c992e2340d724ae09e59b85c1da0();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsByAssignedToReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_13a8c992e2340d724ae09e59b85c1da0)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.ForeignInvoicesPendingValidation.GetFolioApprovalLevelsByAssignedTo.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


    public class lcvGetUserData : VarsBag {
public Actions.lcoGetIsUserCxP resGetIsUserCxP =  new Actions.lcoGetIsUserCxP();
public lcvGetUserData() {
}
}
public class lcoGetUserData : VarsBag {
public bool outParamo_IsUserCxP = false;

public lcoGetUserData() {
}
}
/// <summary>
/// Action <code>GetUserData</code> that represents the Service Studio action <code>GetUserData</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetUserData(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsUserCxP = default;
lcoGetUserData result = new lcoGetUserData();
lcvGetUserData localVars = new lcvGetUserData();
ConectaProveedores_j_FoliosSAE_ForeignInvoicesPendingValidation_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserData", "ec5c8bca-b61c-4d60-a50e-defa1f958393"))
using (activitySource.CreateScreenDataActionActivity("ForeignInvoicesPendingValidation", "GetUserData")){
// GetIsUserCxP
localVars.resGetIsUserCxP.outParamo_Value = await Actions.ActionGetIsUserCxP(requestContext,cancellationToken);

// o_IsUserCxP = GetIsUserCxP.o_Value
result.outParamo_IsUserCxP=localVars.resGetIsUserCxP.outParamo_Value;
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsUserCxP = result.outParamo_IsUserCxP;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsUserCxP;
}


    public static class FuncDataActionGetUserData {
}


}
