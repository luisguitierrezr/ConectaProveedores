using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel).Namespace);

    public long varLcSupplierDetailIdentifier;
public bool varLcViewDetail;
public string varLcRegionSelected;
public int varLcMaxRecords;
public string varLcTableSort;
public int varLcStartIndex;
public RL_dd107351023827897d1e9d4f7246e1d9 varLcL_FACTPENPAG;
public RL_dd107351023827897d1e9d4f7246e1d9 varLcL_FACTPENPAGFiltered;
public int varLcTotalRecords;
public string varLcInvoiceTextNumber;
public DateTime varLcDateTime;
public int varLcl_Tab;
public AggregateRecord<RL_5859a4306a0de95c2b5c534d5cfa7150> ScreenDataSetGetSupplierUserByUserId;
public AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> ScreenDataSetGetSupplierDetailsBySupplierId;
public AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public ConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Model varLcGetSapData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel() {
}



    public ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel(long varLcSupplierDetailIdentifier, bool varLcViewDetail, string varLcRegionSelected, int varLcMaxRecords, string varLcTableSort, int varLcStartIndex, RL_dd107351023827897d1e9d4f7246e1d9 varLcL_FACTPENPAG, RL_dd107351023827897d1e9d4f7246e1d9 varLcL_FACTPENPAGFiltered, int varLcTotalRecords, string varLcInvoiceTextNumber, DateTime varLcDateTime, int varLcl_Tab, AggregateRecord<RL_5859a4306a0de95c2b5c534d5cfa7150> ScreenDataSetGetSupplierUserByUserId, AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> ScreenDataSetGetSupplierDetailsBySupplierId, AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, ConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Model varLcGetSapData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"SupplierDetailIdentifier", "ViewDetail", "RegionSelected", "MaxRecords", "TableSort", "StartIndex", "L_FACTPENPAG", "L_FACTPENPAGFiltered", "TotalRecords", "InvoiceTextNumber", "DateTime", "l_Tab", "GetSupplierUserByUserId", "GetSupplierDetailsBySupplierId", "GetPaymentTerms", "GetRegions", "GetSapData", "ClientVars"}, new string[] {"varLcSupplierDetailIdentifier", "varLcViewDetail", "varLcRegionSelected", "varLcMaxRecords", "varLcTableSort", "varLcStartIndex", "varLcL_FACTPENPAG", "varLcL_FACTPENPAGFiltered", "varLcTotalRecords", "varLcInvoiceTextNumber", "varLcDateTime", "varLcl_Tab", "ScreenDataSetGetSupplierUserByUserId", "ScreenDataSetGetSupplierDetailsBySupplierId", "ScreenDataSetGetPaymentTerms", "ScreenDataSetGetRegions", "varLcGetSapData", "clientVariables"});
this.varLcSupplierDetailIdentifier = varLcSupplierDetailIdentifier;
this.varLcViewDetail = varLcViewDetail;
this.varLcRegionSelected = varLcRegionSelected;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcL_FACTPENPAG = varLcL_FACTPENPAG;
this.varLcL_FACTPENPAGFiltered = varLcL_FACTPENPAGFiltered;
this.varLcTotalRecords = varLcTotalRecords;
this.varLcInvoiceTextNumber = varLcInvoiceTextNumber;
this.varLcDateTime = varLcDateTime;
this.varLcl_Tab = varLcl_Tab;
this.ScreenDataSetGetSupplierUserByUserId = ScreenDataSetGetSupplierUserByUserId;
this.ScreenDataSetGetSupplierDetailsBySupplierId = ScreenDataSetGetSupplierDetailsBySupplierId;
this.ScreenDataSetGetPaymentTerms = ScreenDataSetGetPaymentTerms;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.varLcGetSapData = varLcGetSapData;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_3f6ba4c81bcd03d8108335ecd7631ff4> datasetGetSupplierUserByUserIdReadDbAsync(RC_3f6ba4c81bcd03d8108335ecd7631ff4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierUserByUserId" SqazC6NpvEeaBXgG8Jbl1A of Action "AccountStatus"
public static async Task<(RL_5859a4306a0de95c2b5c534d5cfa7150,long)> datasetGetSupplierUserByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusSupplierUser_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Proveedor.AccountStatus.GetSupplierUserByUserId", "0bb3a64a-69a3-47bc-9a05-7806f096e5d4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("AccountStatus","c_Proveedor.AccountStatus.GetSupplierUserByUserId");
// Query Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.pfFZlu2+fEewFmDjpr1vYg/ScreenDataSets.SqazC6NpvEeaBXgG8Jbl1A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"ensupplier107\".\"id\" o13, NULL o14, \"ensupplier107\".\"name\" o15, \"ensupplier107\".\"number\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, \"ensupplier107\".\"n_ident_fis_1\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55");
fromBuilder.Append(" FROM (({Supplier} \"ensupplier107\" Left JOIN {Region} \"enregion132\" ON (\"ensupplier107\".\"regionid\" = \"enregion132\".\"id\"))  Inner JOIN {SupplierUser} \"ensupplieruser24\" ON (\"ensupplier107\".\"id\" = \"ensupplieruser24\".\"supplierid\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusSupplierUser_UserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser24\".\"userid\" = @qpusSupplierUser_UserId) AND (\"ensupplieruser24\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusSupplierUser_UserId", DbType.String, qpusSupplierUser_UserId);
} else {
whereBuilder.Append("(\"ensupplieruser24\".\"userid\" IS NULL)");
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
RL_5859a4306a0de95c2b5c534d5cfa7150 outParamList = new RL_5859a4306a0de95c2b5c534d5cfa7150();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierUserByUserIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.AccountStatus.GetSupplierUserByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5859a4306a0de95c2b5c534d5cfa7150 _tmp = new RL_5859a4306a0de95c2b5c534d5cfa7150();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierUserByUserIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.AccountStatus.GetSupplierUserByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5859a4306a0de95c2b5c534d5cfa7150)_tmp;
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

private static async Task<RC_5df7bb5aa64fe06d5d087faa4a2fd561> datasetGetSupplierDetailsBySupplierIdReadDbAsync(RC_5df7bb5aa64fe06d5d087faa4a2fd561 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENSupplierDetail.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierDetailsBySupplierId" pifKKVIxcE+QujAq_wPMMw of Action "AccountStatus"
public static async Task<(RL_3c0fa01b89994c3e2eaed82b259c3f66,long)> datasetGetSupplierDetailsBySupplierId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierDetail_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Proveedor.AccountStatus.GetSupplierDetailsBySupplierId", "29ca27a6-3152-4f70-90ba-302aff03cc33");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("AccountStatus","c_Proveedor.AccountStatus.GetSupplierDetailsBySupplierId");
// Query Iterations: Multiple
// Refresh Query bAmEXQiqmkKp1oV28tSHRw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.pfFZlu2+fEewFmDjpr1vYg/ScreenDataSets.pifKKVIxcE+QujAq_wPMMw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany43\".\"id\" o0, NULL o1, \"encompany43\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36");
fromBuilder.Append(" FROM ({SupplierDetail} \"ensupplierdetail4\" Left JOIN {Company} \"encompany43\" ON (\"ensupplierdetail4\".\"sociedadeid\" = \"encompany43\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierDetail_SupplierId != 0) {
whereBuilder.Append("((\"ensupplierdetail4\".\"supplierid\" = @qpsuSupplierDetail_SupplierId) AND (\"ensupplierdetail4\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierDetail_SupplierId", DbType.Int64, qpsuSupplierDetail_SupplierId);
} else {
whereBuilder.Append("(\"ensupplierdetail4\".\"supplierid\" IS NULL)");
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
RL_3c0fa01b89994c3e2eaed82b259c3f66 outParamList = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierDetailsBySupplierIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.AccountStatus.GetSupplierDetailsBySupplierId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c0fa01b89994c3e2eaed82b259c3f66 _tmp = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierDetailsBySupplierIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.AccountStatus.GetSupplierDetailsBySupplierId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c0fa01b89994c3e2eaed82b259c3f66)_tmp;
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

// Query Function "GetPaymentTerms" 1bRtnB0MgEm0v5Rv0hsE1w of Action "AccountStatus"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Proveedor.AccountStatus.GetPaymentTerms", "9c6db4d5-0c1d-4980-b4bf-946fd21b04d7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("AccountStatus","c_Proveedor.AccountStatus.GetPaymentTerms");
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
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.pfFZlu2+fEewFmDjpr1vYg/ScreenDataSets.1bRtnB0MgEm0v5Rv0hsE1w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms28\".\"id\" o0, \"enpaymentterms28\".\"description\" o1, \"enpaymentterms28\".\"clcta\" o2, \"enpaymentterms28\".\"classfecha\" o3, \"enpaymentterms28\".\"ctd_dias\" o4, \"enpaymentterms28\".\"estructuradescripcionprop\" o5, \"enpaymentterms28\".\"isspecial\" o6, \"enpaymentterms28\".\"createdon\" o7, \"enpaymentterms28\".\"createdby\" o8, \"enpaymentterms28\".\"updatedon\" o9, \"enpaymentterms28\".\"updatedby\" o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms28\"");
orderByBuilder.Append(" ORDER BY \"enpaymentterms28\".\"description\" ASC ");
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
RL_375b9dd8c8b0d6d7bccf4d550f48644d outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.AccountStatus.GetPaymentTerms.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_375b9dd8c8b0d6d7bccf4d550f48644d _tmp = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.AccountStatus.GetPaymentTerms.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_375b9dd8c8b0d6d7bccf4d550f48644d)_tmp;
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

// Query Function "GetRegions" RH10qo7EI0uU5mKR8+Ks6Q of Action "AccountStatus"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Proveedor.AccountStatus.GetRegions", "aa747d44-c48e-4b23-94e6-6291f3e2ace9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("AccountStatus","c_Proveedor.AccountStatus.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.pfFZlu2+fEewFmDjpr1vYg/ScreenDataSets.RH10qo7EI0uU5mKR8+Ks6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enregion133\".\"name\" o2, \"enregion133\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion133\"");
whereBuilder.Append(" WHERE (\"enregion133\".\"isactive\" = 1)");
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
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.AccountStatus.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.AccountStatus.GetRegions.List", cancellationToken: cancellationToken);
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


    public class lcvGetSapData : VarsBag {
public ST_382afa1d8361f400b6ea03403d75e294Structure resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse = new ST_382afa1d8361f400b6ea03403d75e294Structure();

public RL_3c0fa01b89994c3e2eaed82b259c3f66 queryResGetCompanyById_outParamList = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
public long queryResGetCompanyById_outParamCount = 0L;

public lcvGetSapData() {
}
}
public class lcoGetSapData : VarsBag {
public ST_382afa1d8361f400b6ea03403d75e294Structure outParamList = new ST_382afa1d8361f400b6ea03403d75e294Structure();

public decimal outParamTotalenmonedanacional = (((decimal)0));

public decimal outParamImportetotaldefacturasmonedaextranjera = (((decimal)0));

public decimal outParamTotalenmonedanacional2 = (((decimal)0));

public decimal outParamImportetotaldefacturasmonedaextranjera2 = (((decimal)0));

public lcoGetSapData() {
}
}
/// <summary>
/// Action <code>GetSapData</code> that represents the Service Studio action <code>GetSapData</code>
///  <p> Description: </p>
/// </summary>
public async Task<(ST_382afa1d8361f400b6ea03403d75e294Structure,decimal,decimal,decimal,decimal)> DataActionGetSapData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_382afa1d8361f400b6ea03403d75e294Structure outParamList = default;
decimal outParamTotalenmonedanacional = default;
decimal outParamImportetotaldefacturasmonedaextranjera = default;
decimal outParamTotalenmonedanacional2 = default;
decimal outParamImportetotaldefacturasmonedaextranjera2 = default;
lcoGetSapData result = new lcoGetSapData();
lcvGetSapData localVars = new lcvGetSapData();
ConectaProveedores_c_Proveedor_AccountStatus_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSapData", "348661b4-d574-4b39-83be-367eeae8286f"))
using (activitySource.CreateScreenDataActionActivity("AccountStatus", "GetSapData")){
// Query datasetGetCompanyById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetCompanyById_maxRecords = 0;
int datasetGetCompanyById_startIndex = 0;(localVars.queryResGetCompanyById_outParamList,localVars.queryResGetCompanyById_outParamCount) = await FuncDataActionGetSapData.datasetGetCompanyById(requestContext,datasetGetCompanyById_maxRecords,datasetGetCompanyById_startIndex,IterationMultiplicity.Never,varLcSupplierDetailIdentifier,cancellationToken);

// Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXMIMMF_ESTD_CUENTA_COSMOZ(requestContext,new ST_f53a6d7e4b5e7b5abd0fc13c8d53eb8dStructure(){ ssI_ACREEDOR = ScreenDataSetGetSupplierUserByUserId.List.CurrentRec.ssENSupplier.ssNumber, ssI_ANTICIPOS_HIGH = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechaanticiposfin)))==2)) ? (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechaanticiposfin))) : (("0"+Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechaanticiposfin)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechaanticiposfin)))==2)) ? (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechaanticiposfin))) : (("0"+Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechaanticiposfin))))))+".")+Convert.ToString(BuiltInFunction.Year (model.clientVariables.ssSupplier_Fechaanticiposfin))), ssI_ANTICIPOS_LOW = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechaanticiposinicio)))==2)) ? (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechaanticiposinicio))) : (("0"+Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechaanticiposinicio)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechaanticiposinicio)))==2)) ? (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechaanticiposinicio))) : (("0"+Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechaanticiposinicio))))))+".")+Convert.ToString(BuiltInFunction.Year (model.clientVariables.ssSupplier_Fechaanticiposinicio))), ssI_F_PARTABIE = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechapartidasabiertas)))==2)) ? (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechapartidasabiertas))) : (("0"+Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechapartidasabiertas)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechapartidasabiertas)))==2)) ? (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechapartidasabiertas))) : (("0"+Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechapartidasabiertas))))))+".")+Convert.ToString(BuiltInFunction.Year (model.clientVariables.ssSupplier_Fechapartidasabiertas))), ssI_PCOMP_HIGH = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechacompensadasfin)))==2)) ? (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechacompensadasfin))) : (("0"+Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechacompensadasfin)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechacompensadasfin)))==2)) ? (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechacompensadasfin))) : (("0"+Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechacompensadasfin))))))+".")+Convert.ToString(BuiltInFunction.Year (model.clientVariables.ssSupplier_Fechacompensadasfin))), ssI_PCOMP_LOW = (((((((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechacompensadasinicio)))==2)) ? (Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechacompensadasinicio))) : (("0"+Convert.ToString(BuiltInFunction.Day (model.clientVariables.ssSupplier_Fechacompensadasinicio)))))+".")+(((BuiltInFunction.LengthSC (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechacompensadasinicio)))==2)) ? (Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechacompensadasinicio))) : (("0"+Convert.ToString(BuiltInFunction.Month (model.clientVariables.ssSupplier_Fechacompensadasinicio))))))+".")+Convert.ToString(BuiltInFunction.Year (model.clientVariables.ssSupplier_Fechacompensadasinicio))), ssI_REGION = varLcRegionSelected, ssI_SOCIEDAD = localVars.queryResGetCompanyById_outParamList.CurrentRec.ssENCompany.ssExternalId },cancellationToken);

// Foreach Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FACT_PEN_PAG_Out
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.StartIteration();
try {while (!((localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.Eof))) {
// Totalenmonedanacional = Totalenmonedanacional + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FACT_PEN_PAG_Out.Current.WRBT2
result.outParamTotalenmonedanacional=(result.outParamTotalenmonedanacional+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT2);

// Importetotaldefacturasmonedaextranjera = Importetotaldefacturasmonedaextranjera + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FACT_PEN_PAG_Out.Current.WRBT3
result.outParamImportetotaldefacturasmonedaextranjera=(result.outParamImportetotaldefacturasmonedaextranjera+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT3);
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.Advance();
}

} finally {
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FACT_PEN_PAG_Out.EndIteration();
}

// Foreach Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FAC_PAG_Out
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.StartIteration();
try {while (!((localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.Eof))) {
// Totalenmonedanacional2 = Totalenmonedanacional2 + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FAC_PAG_Out.Current.WRBT2
result.outParamTotalenmonedanacional2=(result.outParamTotalenmonedanacional2+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.CurrentRec.ssWRBT2);

// Importetotaldefacturasmonedaextranjera2 = Importetotaldefacturasmonedaextranjera2 + Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response.T_FAC_PAG_Out.Current.WRBT3
result.outParamImportetotaldefacturasmonedaextranjera2=(result.outParamImportetotaldefacturasmonedaextranjera2+localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.CurrentRec.ssWRBT3);
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.Advance();
}

} finally {
localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse.ssT_FAC_PAG_Out.EndIteration();
}

// List = Call_ZMXMIMMF_ESTD_CUENTA_COSMOZ.Response
result.outParamList=localVars.resCall_ZMXMIMMF_ESTD_CUENTA_COSMOZ_outParamResponse;
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
outParamTotalenmonedanacional = result.outParamTotalenmonedanacional;
outParamImportetotaldefacturasmonedaextranjera = result.outParamImportetotaldefacturasmonedaextranjera;
outParamTotalenmonedanacional2 = result.outParamTotalenmonedanacional2;
outParamImportetotaldefacturasmonedaextranjera2 = result.outParamImportetotaldefacturasmonedaextranjera2;
} // inner-finally
RETURN_STATEMENT:
return (outParamList,outParamTotalenmonedanacional,outParamImportetotaldefacturasmonedaextranjera,outParamTotalenmonedanacional2,outParamImportetotaldefacturasmonedaextranjera2);
}


    public static class FuncDataActionGetSapData {

private static async Task<RC_5df7bb5aa64fe06d5d087faa4a2fd561> datasetGetCompanyByIdReadDbAsync(RC_5df7bb5aa64fe06d5d087faa4a2fd561 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENSupplierDetail.Read( r, ref index);
return rec;
}
// Query Function "GetCompanyById" deGHjlTsmEGbxU1po+Y2ug of Action "GetSapData"
public static async Task<(RL_3c0fa01b89994c3e2eaed82b259c3f66,long)> datasetGetCompanyById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpcoSupplierDetail_SociedadeId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Proveedor.AccountStatus.GetSapData.GetCompanyById", "8e87e175-ec54-4198-9bc5-4d69a3e636ba");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Proveedor.AccountStatus.GetSapData.GetCompanyById", "8e87e175-ec54-4198-9bc5-4d69a3e636ba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.C1VQREl4LUakdtWZ9kDRuQ/NodesShownInESpaceTree.pfFZlu2+fEewFmDjpr1vYg/DataActions.tGGGNHTVOUuDvjZ+6ugobw/NodesNotShownInESpaceTree.deGHjlTsmEGbxU1po+Y2ug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany44\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36");
fromBuilder.Append(" FROM ({SupplierDetail} \"ensupplierdetail5\" Left JOIN {Company} \"encompany44\" ON (\"ensupplierdetail5\".\"sociedadeid\" = \"encompany44\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpcoSupplierDetail_SociedadeId != 0) {
whereBuilder.Append("((\"ensupplierdetail5\".\"sociedadeid\" = @qpcoSupplierDetail_SociedadeId) AND (\"ensupplierdetail5\".\"sociedadeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoSupplierDetail_SociedadeId", DbType.Int64, qpcoSupplierDetail_SociedadeId);
} else {
whereBuilder.Append("(\"ensupplierdetail5\".\"sociedadeid\" IS NULL)");
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
RL_3c0fa01b89994c3e2eaed82b259c3f66 outParamList = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCompanyByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Proveedor.AccountStatus.GetSapData.GetCompanyById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c0fa01b89994c3e2eaed82b259c3f66 _tmp = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
_tmp.AlternateReadDbMethodAsync = datasetGetCompanyByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Proveedor.AccountStatus.GetSapData.GetCompanyById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c0fa01b89994c3e2eaed82b259c3f66)_tmp;
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
