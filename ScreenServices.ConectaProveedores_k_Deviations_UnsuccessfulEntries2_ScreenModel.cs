using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel).Namespace);

    public int varLci_StartIndex;
public string varLci_TableSort;
public bool varLci_ReInvokeToggler;
public string varLci_ColumnsListInJSON;
public AggregateRecord<RL_dee12d8d138188f23c97a0b0c9fde91b> ScreenDataSetGetData;
public AggregateRecord<RL_53ee8acf49c9618a86f040a6ab1ebb06> ScreenDataSetGetSuppliers;
public AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel() {
}



    public ConectaProveedores_k_Deviations_UnsuccessfulEntries2_ScreenModel(int varLci_StartIndex, string varLci_TableSort, bool varLci_ReInvokeToggler, string varLci_ColumnsListInJSON, AggregateRecord<RL_dee12d8d138188f23c97a0b0c9fde91b> ScreenDataSetGetData, AggregateRecord<RL_53ee8acf49c9618a86f040a6ab1ebb06> ScreenDataSetGetSuppliers, AggregateRecord<RL_ba9fc810801f4aabee0bc4ef3685a9dd> ScreenDataSetGetFolioStatus, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_StartIndex", "i_TableSort", "i_ReInvokeToggler", "i_ColumnsListInJSON", "GetData", "GetSuppliers", "GetFolioStatus", "ClientVars"}, new string[] {"varLci_StartIndex", "varLci_TableSort", "varLci_ReInvokeToggler", "varLci_ColumnsListInJSON", "ScreenDataSetGetData", "ScreenDataSetGetSuppliers", "ScreenDataSetGetFolioStatus", "clientVariables"});
this.varLci_StartIndex = varLci_StartIndex;
this.varLci_TableSort = varLci_TableSort;
this.varLci_ReInvokeToggler = varLci_ReInvokeToggler;
this.varLci_ColumnsListInJSON = varLci_ColumnsListInJSON;
this.ScreenDataSetGetData = ScreenDataSetGetData;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.ScreenDataSetGetFolioStatus = ScreenDataSetGetFolioStatus;
this.clientVariables = clientVariables;
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
// Query Function "GetData" by5QEQEcC0KPp902NpuzDQ of Action "UnsuccessfulEntries2"
public static async Task<(RL_dee12d8d138188f23c97a0b0c9fde91b,long)> datasetGetData(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("k_Deviations.UnsuccessfulEntries2.GetData", "11502e6f-1c01-420b-8fa7-dd36369bb30d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UnsuccessfulEntries2","k_Deviations.UnsuccessfulEntries2.GetData");
// Query Iterations: Multiple
// Refresh Query Ik77ptJcZUOhwwrV5NV1DQ Iterations: Multiple
// Refresh Query 4XoeU0dOQEy7f_YBeJKSUg Iterations: Multiple
// Refresh Query sG8iiXoGHkafc2KJdfexvg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.kKEGGM6veEOjCw8t4MGOUw/NodesShownInESpaceTree.AysQ2+xVG06J6vn0CfIgdg/ScreenDataSets.by5QEQEcC0KPp902NpuzDQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio67\".\"id\" o0, NULL o1, \"enfolio67\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enfolio67\".\"sapentryerror\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfoliostatus4\".\"label\" o21, \"enfoliostatus4\".\"class\" o22, NULL o23, NULL o24, NULL o25, NULL o26, \"eninvoice105\".\"name\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"enordermain82\".\"ordernumber\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, \"enregion83\".\"code\" o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, \"ensupplier66\".\"name\" o94, \"ensupplier66\".\"number\" o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119");
fromBuilder.Append(" FROM ((((({Folio} \"enfolio67\" Left JOIN {OrderMain} \"enordermain82\" ON (\"enfolio67\".\"orderid\" = \"enordermain82\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus4\" ON (\"enfolio67\".\"foliostatusid\" = \"enfoliostatus4\".\"id\"))  Left JOIN {Region} \"enregion83\" ON (\"enordermain82\".\"regionid\" = \"enregion83\".\"id\"))  Left JOIN {Invoice} \"eninvoice105\" ON (\"enfolio67\".\"id\" = \"eninvoice105\".\"folioid\"))  Left JOIN {Supplier} \"ensupplier66\" ON (\"enfolio67\".\"supplierid\" = \"ensupplier66\".\"id\")) ");
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
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query k_Deviations.UnsuccessfulEntries2.GetData.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query k_Deviations.UnsuccessfulEntries2.GetData.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query k_Deviations.UnsuccessfulEntries2.GetData.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dee12d8d138188f23c97a0b0c9fde91b)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query k_Deviations.UnsuccessfulEntries2.GetData.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

private static async Task<RC_c0133441667bf39f1c8403118864a3c3> datasetGetSuppliersReadDbAsync(RC_c0133441667bf39f1c8403118864a3c3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSupplier.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "IsSelectedSupplierRecord.IsSelected", false);
return rec;
}
// Query Function "GetSuppliers" vy0ve6Z+l0qMMLfePyCYkw of Action "UnsuccessfulEntries2"
public static async Task<(RL_53ee8acf49c9618a86f040a6ab1ebb06,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRegionId,long qpreRegionId1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("k_Deviations.UnsuccessfulEntries2.GetSuppliers", "7b2f2dbf-7ea6-4a97-8c30-b7de3f209893");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UnsuccessfulEntries2","k_Deviations.UnsuccessfulEntries2.GetSuppliers");
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
selectBuilder.Append("/* /NRWebFlows.kKEGGM6veEOjCw8t4MGOUw/NodesShownInESpaceTree.AysQ2+xVG06J6vn0CfIgdg/ScreenDataSets.vy0ve6Z+l0qMMLfePyCYkw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplier67\".\"id\" o0, NULL o1, \"ensupplier67\".\"name\" o2, \"ensupplier67\".\"number\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, 0 \"isselected\"");
fromBuilder.Append(" FROM {Supplier} \"ensupplier67\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((((@qpreRegionId = @qpreRegionId1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId1", DbType.Int64, qpreRegionId);
if (qpreRegionId != 0) {
whereBuilder.Append("((\"ensupplier67\".\"regionid\" = @qpreRegionId1) AND (\"ensupplier67\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId1", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"ensupplier67\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreRegionId1 != 0) {
whereBuilder.Append("((\"ensupplier67\".\"regionid\" = @qpreRegionId) AND (\"ensupplier67\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId1);
} else {
whereBuilder.Append("(\"ensupplier67\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier67\".\"regionid\" IS NULL))");
orderByBuilder.Append(" ORDER BY \"ensupplier67\".\"name\" ASC ");
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
RL_53ee8acf49c9618a86f040a6ab1ebb06 outParamList = new RL_53ee8acf49c9618a86f040a6ab1ebb06();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query k_Deviations.UnsuccessfulEntries2.GetSuppliers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_53ee8acf49c9618a86f040a6ab1ebb06 _tmp = new RL_53ee8acf49c9618a86f040a6ab1ebb06();
_tmp.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query k_Deviations.UnsuccessfulEntries2.GetSuppliers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_53ee8acf49c9618a86f040a6ab1ebb06)_tmp;
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

// Query Function "GetFolioStatus" GUfhpfsSnUqy5KqlDRQWDw of Action "UnsuccessfulEntries2"
public static async Task<(RL_ba9fc810801f4aabee0bc4ef3685a9dd,long)> datasetGetFolioStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("k_Deviations.UnsuccessfulEntries2.GetFolioStatus", "a5e14719-12fb-4a9d-b2e4-aaa50d14160f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("UnsuccessfulEntries2","k_Deviations.UnsuccessfulEntries2.GetFolioStatus");
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
selectBuilder.Append("/* /NRWebFlows.kKEGGM6veEOjCw8t4MGOUw/NodesShownInESpaceTree.AysQ2+xVG06J6vn0CfIgdg/ScreenDataSets.GUfhpfsSnUqy5KqlDRQWDw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfoliostatus5\".\"id\" o0, \"enfoliostatus5\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {FolioStatus} \"enfoliostatus5\"");
whereBuilder.Append(" WHERE (((\"enfoliostatus5\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId);
whereBuilder.Append(") OR (\"enfoliostatus5\".\"id\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("hDfRi70FYEOh852aKLpDVA"))).ssId);
whereBuilder.Append(")) OR (\"enfoliostatus5\".\"id\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query k_Deviations.UnsuccessfulEntries2.GetFolioStatus.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query k_Deviations.UnsuccessfulEntries2.GetFolioStatus.List", cancellationToken: cancellationToken);
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


    

    

}
