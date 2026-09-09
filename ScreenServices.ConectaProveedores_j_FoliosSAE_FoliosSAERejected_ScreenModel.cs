using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel).Namespace);

    public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_ReInvokeToggler;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public AggregateRecord<RL_05510f5a58c68804a13d569cb160e3d1> ScreenDataSetGetFoliosSAE;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_FoliosSAERejected_ScreenModel(string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, AggregateRecord<RL_05510f5a58c68804a13d569cb160e3d1> ScreenDataSetGetFoliosSAE, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ColumnJSONVar", "l_CountAfterFetch", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "GetFoliosSAE", "ClientVars"}, new string[] {"varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "ScreenDataSetGetFoliosSAE", "clientVariables"});
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.ScreenDataSetGetFoliosSAE = ScreenDataSetGetFoliosSAE;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_ba39f6bd3c228aee942545da8b2d8590> datasetGetFoliosSAEReadDbAsync(RC_ba39f6bd3c228aee942545da8b2d8590 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetFoliosSAE" diUL54YSY0mm50P_ONvjEw of Action "FoliosSAERejected"
public static async Task<(RL_05510f5a58c68804a13d569cb160e3d1,long)> datasetGetFoliosSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpteFoliosSAERejected_FolioNumber,string qpteFoliosSAERejected_OrderNumber,long qpsuSupplier_Id,string qptel_TableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosSAERejected.GetFoliosSAE", "e70b2576-1286-4963-a6e7-43ff38dbe313");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosSAERejected","j_FoliosSAE.FoliosSAERejected.GetFoliosSAE");
// Query Iterations: Multiple
// Refresh Query dUWTDHCEyEuulHDj0zmg+A Iterations: Multiple
// Refresh Query qfzO9Spc0kSB7Nl_8G2_gA Iterations: Multiple
// Refresh Query aCkgKqoGRk2noenLzpQX7A Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.I0Cf6ZARqUOc+IzJCqcImw/ScreenDataSets.diUL54YSY0mm50P_ONvjEw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole93\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enfolio119\".\"id\" o6, NULL o7, \"enfolio119\".\"folionumber\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, \"enfolioapprovallevel57\".\"rejectreason\" o54, NULL o55, NULL o56, \"enordermain159\".\"ordernumber\" o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enregion205\".\"code\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, \"ensupplier158\".\"name\" o100, \"ensupplier158\".\"number\" o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, \"enuser253\".\"name\" o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150");
fromBuilder.Append(" FROM (((((((({Folio} \"enfolio119\" Inner JOIN {FolioApproval} \"enfolioapproval60\" ON (\"enfolio119\".\"id\" = \"enfolioapproval60\".\"folioid\"))  Inner JOIN {FolioApprovalLevel} \"enfolioapprovallevel57\" ON (((\"enfolioapproval60\".\"id\" = \"enfolioapprovallevel57\".\"folioapprovalid\") AND (\"enfolioapprovallevel57\".\"rejectreason\" <> '')) AND (\"enfolioapprovallevel57\".\"levelnumber\" = 1)))  Left JOIN {OrderMain} \"enordermain159\" ON (\"enfolio119\".\"orderid\" = \"enordermain159\".\"id\"))  Left JOIN {Region} \"enregion205\" ON (\"enordermain159\".\"regionid\" = \"enregion205\".\"id\"))  Left JOIN {Supplier} \"ensupplier158\" ON (\"enfolio119\".\"supplierid\" = \"ensupplier158\".\"id\"))  Left JOIN {User} \"enuser253\" ON (\"enfolioapprovallevel57\".\"rejectedby\" = \"enuser253\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal148\" ON (\"enuser253\".\"id\" = \"enuser_extended_internal148\".\"id\"))  Left JOIN {EntraRole} \"enentrarole93\" ON (\"enuser_extended_internal148\".\"entraroleid\" = \"enentrarole93\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpteFoliosSAERejected_FolioNumber != "" && qpteFoliosSAERejected_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio119\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFoliosSAERejected_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFoliosSAERejected_FolioNumber", DbType.String, qpteFoliosSAERejected_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFoliosSAERejected_FolioNumber", DbType.String, qpteFoliosSAERejected_FolioNumber);
}
if (qpteFoliosSAERejected_OrderNumber != "" && qpteFoliosSAERejected_OrderNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain159\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFoliosSAERejected_OrderNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFoliosSAERejected_OrderNumber", DbType.String, qpteFoliosSAERejected_OrderNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFoliosSAERejected_OrderNumber", DbType.String, qpteFoliosSAERejected_OrderNumber);
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier158\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier158\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier158\".\"id\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "Region", "User", "FolioApproval", "OrderMain", "Supplier", "FolioApprovalLevel", "Folio", "EntraRole", "User_Extended_Internal" }, new string[] { "ENRegion205", "ENUser253", "ENFolioApproval60", "ENOrderMain159", "ENSupplier158", "ENFolioApprovalLevel57", "ENFolio119", "ENEntraRole93", "ENUser_Extended_Internal148" }, new System.Collections.Generic.Dictionary<string, string>[] { ENRegionEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENUser_Extended_InternalEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio119\".\"id\" DESC ");
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
RL_05510f5a58c68804a13d569cb160e3d1 outParamList = new RL_05510f5a58c68804a13d569cb160e3d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAERejected.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosSAERejected.GetFoliosSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_05510f5a58c68804a13d569cb160e3d1 _tmp = new RL_05510f5a58c68804a13d569cb160e3d1();
_tmp.AlternateReadDbMethodAsync = datasetGetFoliosSAEReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosSAERejected.GetFoliosSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_05510f5a58c68804a13d569cb160e3d1)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosSAERejected.GetFoliosSAE.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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
