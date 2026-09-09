using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel).Namespace);

    public long inParamOrderId;
public string varLcTableSort;
public int varLcStartIndex;
public bool varLcl_ReInvokeToggler;
public string varLcl_ColumnJSONVarGetFolios;
public long varLcl_FolioIdSelectedToCancel;
public bool varLcl_ShowCancellationConfirmPopup;
public AggregateRecord<RL_fbe5076a8f56e344f72f9258ea487c5d> ScreenDataSetGetFoliosBySupplierId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel(long inParamOrderId, string varLcTableSort, int varLcStartIndex, bool varLcl_ReInvokeToggler, string varLcl_ColumnJSONVarGetFolios, long varLcl_FolioIdSelectedToCancel, bool varLcl_ShowCancellationConfirmPopup, AggregateRecord<RL_fbe5076a8f56e344f72f9258ea487c5d> ScreenDataSetGetFoliosBySupplierId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"OrderId", "TableSort", "StartIndex", "l_ReInvokeToggler", "l_ColumnJSONVarGetFolios", "l_FolioIdSelectedToCancel", "l_ShowCancellationConfirmPopup", "GetFoliosBySupplierId", "ClientVars"}, new string[] {"inParamOrderId", "varLcTableSort", "varLcStartIndex", "varLcl_ReInvokeToggler", "varLcl_ColumnJSONVarGetFolios", "varLcl_FolioIdSelectedToCancel", "varLcl_ShowCancellationConfirmPopup", "ScreenDataSetGetFoliosBySupplierId", "clientVariables"});
this.inParamOrderId = inParamOrderId;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_ColumnJSONVarGetFolios = varLcl_ColumnJSONVarGetFolios;
this.varLcl_FolioIdSelectedToCancel = varLcl_FolioIdSelectedToCancel;
this.varLcl_ShowCancellationConfirmPopup = varLcl_ShowCancellationConfirmPopup;
this.ScreenDataSetGetFoliosBySupplierId = ScreenDataSetGetFoliosBySupplierId;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_def4a4b06f199364b3c4464c2355286a> datasetGetFoliosBySupplierIdReadDbAsync(RC_def4a4b06f199364b3c4464c2355286a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcessType.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetFoliosBySupplierId" UsvhY9g+t06_EqTEXoie7g of Action "Wb_FolioSAE_Proveedor"
public static async Task<(RL_fbe5076a8f56e344f72f9258ea487c5d,long)> datasetGetFoliosBySupplierId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusSupplierUser_UserId,long qporOrderMain_Id,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_FolioSAE_Proveedor.GetFoliosBySupplierId", "63e1cb52-3ed8-4eb7-bf12-a4c45e889eee");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_FolioSAE_Proveedor","j_FoliosSAE.Wb_FolioSAE_Proveedor.GetFoliosBySupplierId");
// Query Iterations: Multiple
// Refresh Query kacdy6VPaUC16LZ+IhQSgA Iterations: Multiple
// Refresh Query 2WvIYiP+QE2Y7vl89trLIQ Iterations: Multiple
// Refresh Query XDM1TRJ4j0C1Zx7EGHmb6Q Iterations: Multiple
// Refresh Query wuYjnp3EDUmBIb1IKTNMjw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.BagkxqAVokSRoUsTW0m8bA/ScreenDataSets.UsvhY9g+t06_EqTEXoie7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapprovalprocesstype5\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"encompany70\".\"description\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"encurrency53\".\"code\" o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enfolio118\".\"id\" o21, NULL o22, \"enfolio118\".\"folionumber\" o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enfolio118\".\"foliostatusid\" o28, trim_scale(\"enfolio118\".\"totalamount\"::numeric) o29, trim_scale(\"enfolio118\".\"totaliva_amount\"::numeric) o30, NULL o31, NULL o32, NULL o33, \"enfolio118\".\"approvalprocesstypeid\" o34, NULL o35, NULL o36, \"enfolio118\".\"createdon\" o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enfoliostatus25\".\"label\" o42, \"enfoliostatus25\".\"class\" o43, NULL o44, NULL o45, NULL o46, \"enordermain158\".\"id\" o47, \"enordermain158\".\"ordernumber\" o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, \"enuser250\".\"name\" o120, \"enuser250\".\"email\" o121, NULL o122, NULL o123");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio118\" Inner JOIN {OrderMain} \"enordermain158\" ON (\"enfolio118\".\"orderid\" = \"enordermain158\".\"id\"))  Inner JOIN {Supplier} \"ensupplier157\" ON (\"enfolio118\".\"supplierid\" = \"ensupplier157\".\"id\"))  Left JOIN {Currency} \"encurrency53\" ON (\"enfolio118\".\"currencyid\" = \"encurrency53\".\"code\"))  Left JOIN {FolioStatus} \"enfoliostatus25\" ON (\"enfolio118\".\"foliostatusid\" = \"enfoliostatus25\".\"id\"))  Left JOIN {User} \"enuser250\" ON (\"enfolio118\".\"createdby\" = \"enuser250\".\"id\"))  Left JOIN {Company} \"encompany70\" ON (\"enfolio118\".\"companyid\" = \"encompany70\".\"id\"))  Left JOIN {SupplierUser} \"ensupplieruser28\" ON (\"ensupplier157\".\"id\" = \"ensupplieruser28\".\"supplierid\"))  Left JOIN {ApprovalProcessType} \"enapprovalprocesstype5\" ON (\"enfolio118\".\"approvalprocesstypeid\" = \"enapprovalprocesstype5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusSupplierUser_UserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser28\".\"userid\" = @qpusSupplierUser_UserId) AND (\"ensupplieruser28\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusSupplierUser_UserId", DbType.String, qpusSupplierUser_UserId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusSupplierUser_UserId", DbType.String, qpusSupplierUser_UserId);
} else {
whereBuilder.Append("(\"ensupplieruser28\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qporOrderMain_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain158\".\"id\" = @qporOrderMain_Id) AND (\"enordermain158\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain158\".\"id\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "ApprovalProcessType", "Folio", "User", "FolioStatus", "OrderMain", "Company", "SupplierUser", "Supplier", "Currency" }, new string[] { "ENApprovalProcessType5", "ENFolio118", "ENUser250", "ENFolioStatus25", "ENOrderMain158", "ENCompany70", "ENSupplierUser28", "ENSupplier157", "ENCurrency53" }, new System.Collections.Generic.Dictionary<string, string>[] { ENApprovalProcessTypeEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENCompanyEntity.AttributesToDatabaseNamesMap(), ENSupplierUserEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENCurrencyEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio118\".\"id\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_fbe5076a8f56e344f72f9258ea487c5d outParamList = new RL_fbe5076a8f56e344f72f9258ea487c5d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosBySupplierIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, false, true, true, true, true, false, false, false, true, true, true, false, true, true, false, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.Wb_FolioSAE_Proveedor.GetFoliosBySupplierId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_FolioSAE_Proveedor.GetFoliosBySupplierId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fbe5076a8f56e344f72f9258ea487c5d _tmp = new RL_fbe5076a8f56e344f72f9258ea487c5d();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosBySupplierIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_FolioSAE_Proveedor.GetFoliosBySupplierId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fbe5076a8f56e344f72f9258ea487c5d)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.Wb_FolioSAE_Proveedor.GetFoliosBySupplierId.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
