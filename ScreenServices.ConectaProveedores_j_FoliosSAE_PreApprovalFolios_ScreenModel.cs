using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel).Namespace);

    public string varLcTableSort;
public int varLcStartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVar;
public AggregateRecord<RL_e9c01eb22ad9114f17ae2b674328008c> ScreenDataSetGetPreApprovalFolios;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_PreApprovalFolios_ScreenModel(string varLcTableSort, int varLcStartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVar, AggregateRecord<RL_e9c01eb22ad9114f17ae2b674328008c> ScreenDataSetGetPreApprovalFolios, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"TableSort", "StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVar", "GetPreApprovalFolios", "GetRegions", "ClientVars"}, new string[] {"varLcTableSort", "varLcStartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVar", "ScreenDataSetGetPreApprovalFolios", "ScreenDataSetGetRegions", "clientVariables"});
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.ScreenDataSetGetPreApprovalFolios = ScreenDataSetGetPreApprovalFolios;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_e2b9f65e0c0c00d0e673b5a8e6e47435> datasetGetPreApprovalFoliosReadDbAsync(RC_e2b9f65e0c0c00d0e673b5a8e6e47435 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioExtended.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetPreApprovalFolios" pTKdaVPYskKGbydwa8e0DA of Action "PreApprovalFolios"
public static async Task<(RL_e9c01eb22ad9114f17ae2b674328008c,long)> datasetGetPreApprovalFolios(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,DateTime qpdaPreApprovalFolios_CreatedOn,string qptePreApprovalFolios_FolioNumber,string qptePreApprovalFolios_OrderNumber,long qpreRegion_Id,long qpsuSupplier_Id,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolios.GetPreApprovalFolios", "699d32a5-d853-42b2-866f-27706bc7b40c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolios","j_FoliosSAE.PreApprovalFolios.GetPreApprovalFolios");
// Query Iterations: Multiple
// Refresh Query CGlPZt_w8Uec4wEXY6gzTA Iterations: Multiple
// Refresh Query J9puBFV8C0SdZOtJPTzpvg Iterations: Multiple
// Refresh Query lhi36ki4Zk6M6cDFZe7ZNw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.8fkaRTyD_UCsOeQlnEPg2g/ScreenDataSets.pTKdaVPYskKGbydwa8e0DA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolio91\".\"id\" o0, NULL o1, \"enfolio91\".\"folionumber\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enfoliostatus18\".\"label\" o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"eninvoice152\".\"name\" o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, \"enordermain132\".\"ordernumber\" o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, \"ensupplier138\".\"name\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127");
fromBuilder.Append(" FROM (((((({Folio} \"enfolio91\" Left JOIN {FolioExtended} \"enfolioextended1\" ON (\"enfolio91\".\"id\" = \"enfolioextended1\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus18\" ON (\"enfolio91\".\"foliostatusid\" = \"enfoliostatus18\".\"id\"))  Left JOIN {OrderMain} \"enordermain132\" ON (\"enfolio91\".\"orderid\" = \"enordermain132\".\"id\"))  Left JOIN {Supplier} \"ensupplier138\" ON (\"enfolio91\".\"supplierid\" = \"ensupplier138\".\"id\"))  Left JOIN {Invoice} \"eninvoice152\" ON (\"enfolio91\".\"id\" = \"eninvoice152\".\"folioid\"))  Left JOIN {Region} \"enregion185\" ON (\"enordermain132\".\"regionid\" = \"enregion185\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qptePreApprovalFolios_FolioNumber != "" && qptePreApprovalFolios_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio91\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qptePreApprovalFolios_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptePreApprovalFolios_FolioNumber", DbType.String, qptePreApprovalFolios_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qptePreApprovalFolios_FolioNumber", DbType.String, qptePreApprovalFolios_FolioNumber);
}
if (qptePreApprovalFolios_OrderNumber != "" && qptePreApprovalFolios_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain132\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qptePreApprovalFolios_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptePreApprovalFolios_OrderNumber", DbType.String, qptePreApprovalFolios_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qptePreApprovalFolios_OrderNumber", DbType.String, qptePreApprovalFolios_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier138\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier138\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier138\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaPreApprovalFolios_CreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"enfolio91\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaPreApprovalFolios_CreatedOn) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaPreApprovalFolios_CreatedOn", DbType.DateTime, qpdaPreApprovalFolios_CreatedOn);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaPreApprovalFolios_CreatedOn", DbType.DateTime, qpdaPreApprovalFolios_CreatedOn);
}
if (qpreRegion_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion185\".\"id\" = @qpreRegion_Id) AND (\"enregion185\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion185\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
whereBuilder.Append("(@qpboCheckUserSession = 1) AND (\"enfolio91\".\"foliostatusid\" = ");
whereBuilder.Append((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("sjaNMehoxESZWJutqvvRYA"))).ssId);
whereBuilder.Append(")");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if ((qpteTableSort.Trim()!="")) {
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "FolioExtended", "Invoice", "OrderMain", "Folio", "FolioStatus", "Region", "Supplier" }, new string[] { "ENFolioExtended1", "ENInvoice152", "ENOrderMain132", "ENFolio91", "ENFolioStatus18", "ENRegion185", "ENSupplier138" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioExtendedEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_e9c01eb22ad9114f17ae2b674328008c outParamList = new RL_e9c01eb22ad9114f17ae2b674328008c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetPreApprovalFoliosReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.PreApprovalFolios.GetPreApprovalFolios.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolios.GetPreApprovalFolios.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e9c01eb22ad9114f17ae2b674328008c _tmp = new RL_e9c01eb22ad9114f17ae2b674328008c();
_tmp.AlternateReadDbMethodAsync = datasetGetPreApprovalFoliosReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolios.GetPreApprovalFolios.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e9c01eb22ad9114f17ae2b674328008c)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.PreApprovalFolios.GetPreApprovalFolios.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetRegions" rE7LmEI_q0KAvM9PR784Ug of Action "PreApprovalFolios"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.PreApprovalFolios.GetRegions", "98cb4eac-3f42-42ab-80bc-cf4f47bf3852");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("PreApprovalFolios","j_FoliosSAE.PreApprovalFolios.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.8fkaRTyD_UCsOeQlnEPg2g/ScreenDataSets.rE7LmEI_q0KAvM9PR784Ug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion186\".\"id\" o0, NULL o1, \"enregion186\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion186\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (\"enregion186\".\"isactive\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.PreApprovalFolios.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.PreApprovalFolios.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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
