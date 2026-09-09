using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel).Namespace);

    public bool inParami_IsDisable;
public long inParami_SupplierId;
public long inParami_RequisitionDetailRegionId;
public bool inParami_IsValid;
public bool inParami_IsMandatory;
public bool inParami_IsFilter;
public string varLcl_SupplierSearchText;
public int varLcl_SupplierMaxRecord;
public bool varLcl_IsValid;
public AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers;
public AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel() {
}



    public ConectaProveedores_y_Utils_Wb_SearchSupplierDropdown_ScreenModel(bool inParami_IsDisable, long inParami_SupplierId, long inParami_RequisitionDetailRegionId, bool inParami_IsValid, bool inParami_IsMandatory, bool inParami_IsFilter, string varLcl_SupplierSearchText, int varLcl_SupplierMaxRecord, bool varLcl_IsValid, AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers, AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_IsDisable", "i_SupplierId", "i_RequisitionDetailRegionId", "i_IsValid", "i_IsMandatory", "i_IsFilter", "l_SupplierSearchText", "l_SupplierMaxRecord", "l_IsValid", "GetSuppliers", "GetSupplierById", "ClientVars"}, new string[] {"inParami_IsDisable", "inParami_SupplierId", "inParami_RequisitionDetailRegionId", "inParami_IsValid", "inParami_IsMandatory", "inParami_IsFilter", "varLcl_SupplierSearchText", "varLcl_SupplierMaxRecord", "varLcl_IsValid", "ScreenDataSetGetSuppliers", "ScreenDataSetGetSupplierById", "clientVariables"});
this.inParami_IsDisable = inParami_IsDisable;
this.inParami_SupplierId = inParami_SupplierId;
this.inParami_RequisitionDetailRegionId = inParami_RequisitionDetailRegionId;
this.inParami_IsValid = inParami_IsValid;
this.inParami_IsMandatory = inParami_IsMandatory;
this.inParami_IsFilter = inParami_IsFilter;
this.varLcl_SupplierSearchText = varLcl_SupplierSearchText;
this.varLcl_SupplierMaxRecord = varLcl_SupplierMaxRecord;
this.varLcl_IsValid = varLcl_IsValid;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.ScreenDataSetGetSupplierById = ScreenDataSetGetSupplierById;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_c81aee5ce0504fe68694be6deb703b5e> datasetGetSuppliersReadDbAsync(RC_c81aee5ce0504fe68694be6deb703b5e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetSuppliers" AWDER63WMEWnOhRA0mR0Vg of Action "Wb_SearchSupplierDropdown"
public static async Task<(RL_f647e8c4990b814587d1a017e4c9dd44,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,long qpreSupplier_RegionId2,string qptel_SupplierSearchText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Utils.Wb_SearchSupplierDropdown.GetSuppliers", "47c46001-d6ad-4530-a73a-1440d2647456");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchSupplierDropdown","y_Utils.Wb_SearchSupplierDropdown.GetSuppliers");
// Query Iterations: Multiple
// Refresh Query 9US3P3M6VkyE_q0s_Rg_Rw Iterations: Multiple
// Refresh Query HCXu4j180U6wtGlb6Kt76g Iterations: Multiple
// Refresh Query wAmILYFfWkKGp2z64B2JCQ Iterations: Multiple
// Refresh Query 0y6iMcVl_k+wMZoTT_695w Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.0LSdP7uGNkOGUAkRau0CQA/ScreenDataSets.AWDER63WMEWnOhRA0mR0Vg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"ensupplier119\".\"id\" o13, NULL o14, \"ensupplier119\".\"name\" o15, \"ensupplier119\".\"number\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"ensupplier119\".\"n_ident_fis_1\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier119\" Left JOIN {Region} \"enregion155\" ON (\"ensupplier119\".\"regionid\" = \"enregion155\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qptel_SupplierSearchText != "" && qptel_SupplierSearchText != "" && qptel_SupplierSearchText != "" && qptel_SupplierSearchText != "") {
whereBuilder.Append("(((caseaccent_normalize(\"ensupplier119\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qptel_SupplierSearchText) || '%') collate \"default\")) OR (caseaccent_normalize(\"ensupplier119\".\"number\" collate \"default\") like caseaccent_normalize((('%' || @qptel_SupplierSearchText) || '%') collate \"default\"))) OR (caseaccent_normalize(\"ensupplier119\".\"n_ident_fis_1\" collate \"default\") like caseaccent_normalize((('%' || @qptel_SupplierSearchText) || '%') collate \"default\"))) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptel_SupplierSearchText", DbType.String, qptel_SupplierSearchText);
}
whereBuilder.Append("(((CASE WHEN (@qpreSupplier_RegionId <> 0) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId2);
if (qpreSupplier_RegionId2 != 0) {
whereBuilder.Append("((\"ensupplier119\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier119\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId2);
} else {
whereBuilder.Append("(\"ensupplier119\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 0 END) = 1) OR ((((@qpreSupplier_RegionId1 = @qpreSupplier_RegionId2) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId1);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId2", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier119\".\"regionid\" = @qpreSupplier_RegionId2) AND (\"ensupplier119\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId2", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier119\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier119\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier119\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier119\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier119\".\"regionid\" IS NULL)))");
orderByBuilder.Append(" ORDER BY \"ensupplier119\".\"name\" ASC ");
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
RL_f647e8c4990b814587d1a017e4c9dd44 outParamList = new RL_f647e8c4990b814587d1a017e4c9dd44();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_SearchSupplierDropdown.GetSuppliers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f647e8c4990b814587d1a017e4c9dd44 _tmp = new RL_f647e8c4990b814587d1a017e4c9dd44();
_tmp.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_SearchSupplierDropdown.GetSuppliers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f647e8c4990b814587d1a017e4c9dd44)_tmp;
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

// Query Function "GetSupplierById" zCjZaPvvBESTvwDijiLQ6w of Action "Wb_SearchSupplierDropdown"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("y_Utils.Wb_SearchSupplierDropdown.GetSupplierById", "68d928cc-effb-4404-93bf-00e28e22d0eb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_SearchSupplierDropdown","y_Utils.Wb_SearchSupplierDropdown.GetSupplierById");
// Query Iterations: Never
// Refresh Query lUp6Jx1uGEal3ABwal_qKw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.JAcgewyqEkOMCfBjsT2WtQ/NodesShownInESpaceTree.0LSdP7uGNkOGUAkRau0CQA/ScreenDataSets.zCjZaPvvBESTvwDijiLQ6w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplier120\".\"id\" o0, NULL o1, \"ensupplier120\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier120\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier120\".\"id\" = @qpsuId) AND (\"ensupplier120\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier120\".\"id\" IS NULL)");
}
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query y_Utils.Wb_SearchSupplierDropdown.GetSupplierById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query y_Utils.Wb_SearchSupplierDropdown.GetSupplierById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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
