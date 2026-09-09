using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel).Namespace);

    public int varLci_StartIndex;
public string varLci_TableSort;
public bool varLci_ReInvokeToggler;
public string varLci_ColumnsListInJSON;
public AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus;
public AggregateRecord<RL_dee12d8d138188f23c97a0b0c9fde91b> ScreenDataSetGetData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel() {
}



    public ConectaProveedores_k_Deviations_UnsuccessfulEntries_ScreenModel(int varLci_StartIndex, string varLci_TableSort, bool varLci_ReInvokeToggler, string varLci_ColumnsListInJSON, AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus, AggregateRecord<RL_dee12d8d138188f23c97a0b0c9fde91b> ScreenDataSetGetData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_StartIndex", "i_TableSort", "i_ReInvokeToggler", "i_ColumnsListInJSON", "GetFolioStatus", "GetData", "ClientVars"}, new string[] {"varLci_StartIndex", "varLci_TableSort", "varLci_ReInvokeToggler", "varLci_ColumnsListInJSON", "ScreenDataSetGetFolioStatus", "ScreenDataSetGetData", "clientVariables"});
this.varLci_StartIndex = varLci_StartIndex;
this.varLci_TableSort = varLci_TableSort;
this.varLci_ReInvokeToggler = varLci_ReInvokeToggler;
this.varLci_ColumnsListInJSON = varLci_ColumnsListInJSON;
this.ScreenDataSetGetFolioStatus = ScreenDataSetGetFolioStatus;
this.ScreenDataSetGetData = ScreenDataSetGetData;
this.clientVariables = clientVariables;
}



    
// Query Function "GetFolioStatus" USsMppfmx0CJAt9rYampfw of Action "UnsuccessfulEntries"
public static async Task<(RL_ba9fc810801f4aabee0bc4ef3685a9dd,long)> datasetGetFolioStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("k_Deviations.UnsuccessfulEntries.GetFolioStatus", "a60c2b51-e697-40c7-8902-df6b61a9a97f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UnsuccessfulEntries","k_Deviations.UnsuccessfulEntries.GetFolioStatus");
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
selectBuilder.Append("/* /NRWebFlows.kKEGGM6veEOjCw8t4MGOUw/NodesShownInESpaceTree.EQUAgsKbM0af3xgp7hN7CA/ScreenDataSets.USsMppfmx0CJAt9rYampfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliostatus2\".\"id\" o0, \"enfoliostatus2\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {FolioStatus} \"enfoliostatus2\"");
whereBuilder.Append(" WHERE (((\"enfoliostatus2\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId);
whereBuilder.Append(") OR (\"enfoliostatus2\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("hDfRi70FYEOh852aKLpDVA"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus2\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cKaejollq0a9gDFyfLxCKg"))).ssId);
whereBuilder.Append("))");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query k_Deviations.UnsuccessfulEntries.GetFolioStatus.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query k_Deviations.UnsuccessfulEntries.GetFolioStatus.List", cancellationToken: cancellationToken);
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

private static async Task<RC_4c9ca09958a3ee4cb990399bb84ebebd> datasetGetDataReadDbAsync(RC_4c9ca09958a3ee4cb990399bb84ebebd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetData" TKls_vGaxk6D9f00aoBUaA of Action "UnsuccessfulEntries"
public static async Task<(RL_dee12d8d138188f23c97a0b0c9fde91b,long)> datasetGetData(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpteUnsuccessfulEntries_FolioNumber,int qpfoFolio_FolioStatusId,string qpteUnsuccessfulEntries_OrderNumber,string qpteUnsuccessfulEntries_SAPError,long qpsuSupplier_Id,bool qpboGetIsCorporativo,long qpreOrderMain_DivisionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("k_Deviations.UnsuccessfulEntries.GetData", "fe6ca94c-9af1-4ec6-83f5-fd346a805468");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UnsuccessfulEntries","k_Deviations.UnsuccessfulEntries.GetData");
// Query Iterations: Multiple
// Refresh Query 87wtRcaXVk6NwFTAhghwdw Iterations: Multiple
// Refresh Query GQUvbPqf7U2swerl4TXg2g Iterations: Multiple
// Refresh Query Eq8vovVj1EiRwCp6OzDnbQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.kKEGGM6veEOjCw8t4MGOUw/NodesShownInESpaceTree.EQUAgsKbM0af3xgp7hN7CA/ScreenDataSets.TKls_vGaxk6D9f00aoBUaA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio66\".\"id\" o0, NULL o1, \"enfolio66\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enfolio66\".\"sapentryerror\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfoliostatus3\".\"label\" o21, \"enfoliostatus3\".\"class\" o22, NULL o23, NULL o24, NULL o25, NULL o26, \"eninvoice104\".\"name\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enordermain81\".\"ordernumber\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, \"enregion82\".\"code\" o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, \"ensupplier65\".\"name\" o94, \"ensupplier65\".\"number\" o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119");
fromBuilder.Append(" FROM ((((({Folio} \"enfolio66\" Left JOIN {OrderMain} \"enordermain81\" ON (\"enfolio66\".\"orderid\" = \"enordermain81\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus3\" ON (\"enfolio66\".\"foliostatusid\" = \"enfoliostatus3\".\"id\"))  Left JOIN {Region} \"enregion82\" ON (\"enordermain81\".\"regionid\" = \"enregion82\".\"id\"))  Left JOIN {Invoice} \"eninvoice104\" ON (\"enfolio66\".\"id\" = \"eninvoice104\".\"folioid\"))  Left JOIN {Supplier} \"ensupplier65\" ON (\"enfolio66\".\"supplierid\" = \"ensupplier65\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((@qpboGetIsCorporativo = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain81\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain81\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain81\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(") AND (((\"enfolio66\".\"foliostatusid\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId);
whereBuilder.Append(") OR (\"enfolio66\".\"foliostatusid\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("hDfRi70FYEOh852aKLpDVA"))).ssId);
whereBuilder.Append(")) OR (\"enfolio66\".\"foliostatusid\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cKaejollq0a9gDFyfLxCKg"))).ssId);
whereBuilder.Append(")) AND (NOT (\"enfolio66\".\"isdraft\" = 1)) AND ");
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier65\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier65\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier65\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteUnsuccessfulEntries_OrderNumber != "" && qpteUnsuccessfulEntries_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain81\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteUnsuccessfulEntries_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUnsuccessfulEntries_OrderNumber", DbType.String, qpteUnsuccessfulEntries_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteUnsuccessfulEntries_OrderNumber", DbType.String, qpteUnsuccessfulEntries_OrderNumber);
}
if (qpteUnsuccessfulEntries_FolioNumber != "" && qpteUnsuccessfulEntries_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio66\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteUnsuccessfulEntries_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteUnsuccessfulEntries_FolioNumber", DbType.String, qpteUnsuccessfulEntries_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteUnsuccessfulEntries_FolioNumber", DbType.String, qpteUnsuccessfulEntries_FolioNumber);
}
if (qpfoFolio_FolioStatusId != BuiltInFunction.NullIdentifier()) {
if (qpfoFolio_FolioStatusId != 0) {
whereBuilder.Append("((\"enfolio66\".\"foliostatusid\" = @qpfoFolio_FolioStatusId) AND (\"enfolio66\".\"foliostatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_FolioStatusId", DbType.Int32, qpfoFolio_FolioStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfoFolio_FolioStatusId", DbType.Int32, qpfoFolio_FolioStatusId);
} else {
whereBuilder.Append("(\"enfolio66\".\"foliostatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteUnsuccessfulEntries_SAPError != "" && qpteUnsuccessfulEntries_SAPError != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio66\".\"sapentryerror\" collate \"default\") like caseaccent_normalize((('%' || @qpteUnsuccessfulEntries_SAPError) || '%') collate \"default\"))");
sqlCmd.CreateParameterWithoutReplacements("@qpteUnsuccessfulEntries_SAPError", DbType.String, qpteUnsuccessfulEntries_SAPError);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteUnsuccessfulEntries_SAPError", DbType.String, qpteUnsuccessfulEntries_SAPError);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
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
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_dee12d8d138188f23c97a0b0c9fde91b outParamList = new RL_dee12d8d138188f23c97a0b0c9fde91b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetDataReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query k_Deviations.UnsuccessfulEntries.GetData.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query k_Deviations.UnsuccessfulEntries.GetData.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dee12d8d138188f23c97a0b0c9fde91b _tmp = new RL_dee12d8d138188f23c97a0b0c9fde91b();
_tmp.AlternateReadDbMethodAsync = datasetGetDataReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query k_Deviations.UnsuccessfulEntries.GetData.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dee12d8d138188f23c97a0b0c9fde91b)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query k_Deviations.UnsuccessfulEntries.GetData.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
