using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel).Namespace);

    public long varLcApplicationRoleIdForAggregate;
public string varLcColumnJSONVar;
public int varLcCountAfterFetch;
public bool varLcIsToEmpty;
public bool varLcLoading;
public bool varLcReInvokeToggler;
public int varLcStartIndex;
public string varLcTableSort;
public AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> ScreenDataSetGetInvoiceStatuses;
public AggregateRecord<RL_1543a4f2af6703945e350e1348a6aecf> ScreenDataSetGetSuppliers;
public AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> ScreenDataSetGetInvoices;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> ScreenDataSetGetInvoicesAllRecords;
public ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel() {
}



    public ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel(long varLcApplicationRoleIdForAggregate, string varLcColumnJSONVar, int varLcCountAfterFetch, bool varLcIsToEmpty, bool varLcLoading, bool varLcReInvokeToggler, int varLcStartIndex, string varLcTableSort, AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> ScreenDataSetGetInvoiceStatuses, AggregateRecord<RL_1543a4f2af6703945e350e1348a6aecf> ScreenDataSetGetSuppliers, AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> ScreenDataSetGetInvoices, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, AggregateRecord<RL_fd60f97a407491778f4e2750fb2d9997> ScreenDataSetGetInvoicesAllRecords, ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_g_Reports_SupplierInvoicesReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"ApplicationRoleIdForAggregate", "ColumnJSONVar", "CountAfterFetch", "IsToEmpty", "Loading", "ReInvokeToggler", "StartIndex", "TableSort", "GetInvoiceStatuses", "GetSuppliers", "GetInvoices", "GetRegions", "GetInvoicesAllRecords", "GetSettings", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcApplicationRoleIdForAggregate", "varLcColumnJSONVar", "varLcCountAfterFetch", "varLcIsToEmpty", "varLcLoading", "varLcReInvokeToggler", "varLcStartIndex", "varLcTableSort", "ScreenDataSetGetInvoiceStatuses", "ScreenDataSetGetSuppliers", "ScreenDataSetGetInvoices", "ScreenDataSetGetRegions", "ScreenDataSetGetInvoicesAllRecords", "varLcGetSettings", "varLcGetUserApplicationRoles", "clientVariables"});
this.varLcApplicationRoleIdForAggregate = varLcApplicationRoleIdForAggregate;
this.varLcColumnJSONVar = varLcColumnJSONVar;
this.varLcCountAfterFetch = varLcCountAfterFetch;
this.varLcIsToEmpty = varLcIsToEmpty;
this.varLcLoading = varLcLoading;
this.varLcReInvokeToggler = varLcReInvokeToggler;
this.varLcStartIndex = varLcStartIndex;
this.varLcTableSort = varLcTableSort;
this.ScreenDataSetGetInvoiceStatuses = ScreenDataSetGetInvoiceStatuses;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.ScreenDataSetGetInvoices = ScreenDataSetGetInvoices;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetInvoicesAllRecords = ScreenDataSetGetInvoicesAllRecords;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
// Query Function "GetInvoiceStatuses" iVI2HT0ff0SLhhW6DoNWqA of Action "SupplierInvoicesReport"
public static async Task<(RL_3262178c68dd5ed5c99ed4279a563975,long)> datasetGetInvoiceStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.SupplierInvoicesReport.GetInvoiceStatuses", "1d365289-1f3d-447f-8b86-15ba0e8356a8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("SupplierInvoicesReport","g_Reports.SupplierInvoicesReport.GetInvoiceStatuses");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/ScreenDataSets.iVI2HT0ff0SLhhW6DoNWqA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicestatus6\".\"id\" o0, \"eninvoicestatus6\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {InvoiceStatus} \"eninvoicestatus6\"");
whereBuilder.Append(" WHERE (\"eninvoicestatus6\".\"is_active\" = 1) AND ((((((\"eninvoicestatus6\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") OR (\"eninvoicestatus6\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Q66zN8rsbUynn1JzTqzCFA"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus6\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("IImA0NKHIEiNrWap8beugQ"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus6\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("ASvPCAkuaEyQ8YlZNO_ZcQ"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus6\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("RteygpK6NkexqZHONe6zkg"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus6\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("4NyjEZqqGEqzQUUvdWYJqw"))).ssId);
whereBuilder.Append("))");
orderByBuilder.Append(" ORDER BY \"eninvoicestatus6\".\"label\" ASC ");
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
RL_3262178c68dd5ed5c99ed4279a563975 outParamList = new RL_3262178c68dd5ed5c99ed4279a563975();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetInvoiceStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3262178c68dd5ed5c99ed4279a563975 _tmp = new RL_3262178c68dd5ed5c99ed4279a563975();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetInvoiceStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3262178c68dd5ed5c99ed4279a563975)_tmp;
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

private static async Task<RC_185879ac9d2186c1424cb37de7de8668> datasetGetSuppliersReadDbAsync(RC_185879ac9d2186c1424cb37de7de8668 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetSuppliers" 8EjpJYdcD0y7lovacjEfXg of Action "SupplierInvoicesReport"
public static async Task<(RL_1543a4f2af6703945e350e1348a6aecf,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.SupplierInvoicesReport.GetSuppliers", "25e948f0-5c87-4c0f-bb96-8bda72311f5e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("SupplierInvoicesReport","g_Reports.SupplierInvoicesReport.GetSuppliers");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/ScreenDataSets.8EjpJYdcD0y7lovacjEfXg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37");
fromBuilder.Append(" FROM (({User_Extended_Internal} \"enuser_extended_internal98\" Inner JOIN {Region} \"enregion88\" ON (\"enuser_extended_internal98\".\"regionid\" = \"enregion88\".\"id\"))  Right JOIN {User} \"enuser162\" ON (\"enuser162\".\"id\" = \"enuser_extended_internal98\".\"id\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize(\"enuser162\".\"name\" collate \"default\") like caseaccent_normalize('%marketing%' collate \"default\"))");
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
RL_1543a4f2af6703945e350e1348a6aecf outParamList = new RL_1543a4f2af6703945e350e1348a6aecf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetSuppliers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1543a4f2af6703945e350e1348a6aecf _tmp = new RL_1543a4f2af6703945e350e1348a6aecf();
_tmp.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetSuppliers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1543a4f2af6703945e350e1348a6aecf)_tmp;
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

private static async Task<RC_d69e4e199c0b5f039f18c7b39fbe84d8> datasetGetInvoicesReadDbAsync(RC_d69e4e199c0b5f039f18c7b39fbe84d8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoices" 015OZSRbbUyuUXh0C4_Kyg of Action "SupplierInvoicesReport"
public static async Task<(RL_fd60f97a407491778f4e2750fb2d9997,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdaInvReport48_DateFrom,DateTime qpdaInvReport48_DateTo,string qpteInvReport48_InvoiceName,int qpinInvoice_InvoiceStatusId,long qpreRequisition_RegionId,long qpsuSupplier_Id,int qpinOffsetUtc,bool qpboIsToEmpty,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.SupplierInvoicesReport.GetInvoices", "654e5ed3-5b24-4c6d-ae51-78740b8fcaca");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("SupplierInvoicesReport","g_Reports.SupplierInvoicesReport.GetInvoices");
// Query Iterations: Multiple
// Refresh Query Z5uubW9nLUuyA0nth3Yogg Iterations: Multiple
// Refresh Query Fh9cqdX0Dk6AUNZEZoXdmQ Iterations: Multiple
// Refresh Query BD4HVkkiPUKbwt5GQoxM0g Iterations: Multiple
// Refresh Query TtjVYQ1gUk6Dt7vqKcr+7w Iterations: Multiple
// Refresh Query c76CUZKGFEa4T0R5n0kAYw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/ScreenDataSets.015OZSRbbUyuUXh0C4_Kyg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice106\".\"id\" o0, \"eninvoice106\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoice106\".\"totalamount\"::numeric) o6, NULL o7, NULL o8, NULL o9, NULL o10, \"eninvoice106\".\"createdon\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"eninvoicestatus7\".\"label\" o46, \"eninvoicestatus7\".\"class\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, \"enpaymentterms14\".\"ctd_dias\" o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, \"enregion89\".\"divisionfi\" o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, \"enrequisition85\".\"name\" o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, \"ensupplier69\".\"name\" o136, \"ensupplier69\".\"number\" o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161");
fromBuilder.Append(" FROM (((((({Requisition} \"enrequisition85\" Inner JOIN {Invoice} \"eninvoice106\" ON (\"eninvoice106\".\"requisitionid\" = \"enrequisition85\".\"id\"))  Left JOIN {Supplier} \"ensupplier69\" ON (\"enrequisition85\".\"supplierid\" = \"ensupplier69\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus7\" ON (\"eninvoice106\".\"invoicestatusid\" = \"eninvoicestatus7\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting20\" ON (\"eninvoice106\".\"id\" = \"eninvoiceaccounting20\".\"invoiceid\"))  Left JOIN {PaymentTerms} \"enpaymentterms14\" ON (\"eninvoiceaccounting20\".\"paymenttermsid\" = \"enpaymentterms14\".\"id\"))  Left JOIN {Region} \"enregion89\" ON (\"enrequisition85\".\"regionid\" = \"enregion89\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (NOT (@qpboIsToEmpty = 1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
if (qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition85\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition85\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition85\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteInvReport48_InvoiceName != "" && qpteInvReport48_InvoiceName != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice106\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvReport48_InvoiceName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvReport48_InvoiceName", DbType.String, qpteInvReport48_InvoiceName);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteInvReport48_InvoiceName", DbType.String, qpteInvReport48_InvoiceName);
}
if (qpinInvoice_InvoiceStatusId != BuiltInFunction.NullIdentifier()) {
if (qpinInvoice_InvoiceStatusId != 0) {
whereBuilder.Append("((\"eninvoice106\".\"invoicestatusid\" = @qpinInvoice_InvoiceStatusId) AND (\"eninvoice106\".\"invoicestatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
} else {
whereBuilder.Append("(\"eninvoice106\".\"invoicestatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier69\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier69\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier69\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaInvReport48_DateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice106\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaInvReport48_DateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvReport48_DateFrom", DbType.DateTime, qpdaInvReport48_DateFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaInvReport48_DateFrom", DbType.DateTime, qpdaInvReport48_DateFrom);
}
if (qpdaInvReport48_DateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice106\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaInvReport48_DateTo)");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvReport48_DateTo", DbType.DateTime, qpdaInvReport48_DateTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaInvReport48_DateTo", DbType.DateTime, qpdaInvReport48_DateTo);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "InvoiceAccounting", "Region", "PaymentTerms", "Requisition", "Supplier", "InvoiceStatus", "Invoice" }, new string[] { "ENInvoiceAccounting20", "ENRegion89", "ENPaymentTerms14", "ENRequisition85", "ENSupplier69", "ENInvoiceStatus7", "ENInvoice106" }, new System.Collections.Generic.Dictionary<string, string>[] { ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENPaymentTermsEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"eninvoice106\".\"createdon\" DESC ");
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
RL_fd60f97a407491778f4e2750fb2d9997 outParamList = new RL_fd60f97a407491778f4e2750fb2d9997();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.SupplierInvoicesReport.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fd60f97a407491778f4e2750fb2d9997 _tmp = new RL_fd60f97a407491778f4e2750fb2d9997();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fd60f97a407491778f4e2750fb2d9997)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.SupplierInvoicesReport.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetRegions" 9tpSg4gIvU6UIhFiV8W6pA of Action "SupplierInvoicesReport"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.SupplierInvoicesReport.GetRegions", "8352daf6-0888-4ebd-9422-116257c5baa4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("SupplierInvoicesReport","g_Reports.SupplierInvoicesReport.GetRegions");
// Query Iterations: Multiple
// Refresh Query ePLU8qS49Ea2k0la3FrXPw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/ScreenDataSets.9tpSg4gIvU6UIhFiV8W6pA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion90\".\"id\" o0, NULL o1, \"enregion90\".\"name\" o2, \"enregion90\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion90\"");
whereBuilder.Append(" WHERE (\"enregion90\".\"isactive\" = 1) AND (\"enregion90\".\"isfsp\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion90\".\"code\" ASC ");
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
opt[0] = new BitArray(new bool[] {false, true, false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetRegions.List", cancellationToken: cancellationToken);
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

private static async Task<RC_d69e4e199c0b5f039f18c7b39fbe84d8> datasetGetInvoicesAllRecordsReadDbAsync(RC_d69e4e199c0b5f039f18c7b39fbe84d8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesAllRecords" UEyE7C+Hj02BSIBV+FgKOg of Action "SupplierInvoicesReport"
public static async Task<(RL_fd60f97a407491778f4e2750fb2d9997,long)> datasetGetInvoicesAllRecords(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,DateTime qpdaInvReport48_DateFrom,DateTime qpdaInvReport48_DateTo,string qpteInvReport48_InvoiceName,int qpinInvoice_InvoiceStatusId,long qpreRequisition_RegionId,long qpsuSupplier_Id,int qpinOffsetUtc,bool qpboIsToEmpty,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.SupplierInvoicesReport.GetInvoicesAllRecords", "ec844c50-872f-4d8f-8148-8055f8580a3a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("SupplierInvoicesReport","g_Reports.SupplierInvoicesReport.GetInvoicesAllRecords");
// Query Iterations: Single
// Refresh Query 9eVzQn5OzU22lDY1No0dhw Iterations: Single
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/ScreenDataSets.UEyE7C+Hj02BSIBV+FgKOg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice107\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161");
fromBuilder.Append(" FROM (((((({Requisition} \"enrequisition86\" Inner JOIN {Invoice} \"eninvoice107\" ON (\"eninvoice107\".\"requisitionid\" = \"enrequisition86\".\"id\"))  Left JOIN {Supplier} \"ensupplier70\" ON (\"enrequisition86\".\"supplierid\" = \"ensupplier70\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus8\" ON (\"eninvoice107\".\"invoicestatusid\" = \"eninvoicestatus8\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting21\" ON (\"eninvoice107\".\"id\" = \"eninvoiceaccounting21\".\"invoiceid\"))  Left JOIN {PaymentTerms} \"enpaymentterms15\" ON (\"eninvoiceaccounting21\".\"paymenttermsid\" = \"enpaymentterms15\".\"id\"))  Left JOIN {Region} \"enregion91\" ON (\"enrequisition86\".\"regionid\" = \"enregion91\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (NOT (@qpboIsToEmpty = 1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
if (qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition86\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition86\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition86\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteInvReport48_InvoiceName != "" && qpteInvReport48_InvoiceName != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice107\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteInvReport48_InvoiceName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteInvReport48_InvoiceName", DbType.String, qpteInvReport48_InvoiceName);
}
if (qpinInvoice_InvoiceStatusId != BuiltInFunction.NullIdentifier()) {
if (qpinInvoice_InvoiceStatusId != 0) {
whereBuilder.Append("((\"eninvoice107\".\"invoicestatusid\" = @qpinInvoice_InvoiceStatusId) AND (\"eninvoice107\".\"invoicestatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_InvoiceStatusId", DbType.Int32, qpinInvoice_InvoiceStatusId);
} else {
whereBuilder.Append("(\"eninvoice107\".\"invoicestatusid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier70\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier70\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier70\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaInvReport48_DateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice107\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaInvReport48_DateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvReport48_DateFrom", DbType.DateTime, qpdaInvReport48_DateFrom);
}
if (qpdaInvReport48_DateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice107\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaInvReport48_DateTo)");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaInvReport48_DateTo", DbType.DateTime, qpdaInvReport48_DateTo);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Region", "PaymentTerms", "Invoice", "InvoiceAccounting", "InvoiceStatus", "Requisition", "Supplier" }, new string[] { "ENRegion91", "ENPaymentTerms15", "ENInvoice107", "ENInvoiceAccounting21", "ENInvoiceStatus8", "ENRequisition86", "ENSupplier70" }, new System.Collections.Generic.Dictionary<string, string>[] { ENRegionEntity.AttributesToDatabaseNamesMap(), ENPaymentTermsEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"eninvoice107\".\"createdon\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_fd60f97a407491778f4e2750fb2d9997 outParamList = new RL_fd60f97a407491778f4e2750fb2d9997();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesAllRecordsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetInvoicesAllRecords.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fd60f97a407491778f4e2750fb2d9997 _tmp = new RL_fd60f97a407491778f4e2750fb2d9997();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesAllRecordsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetInvoicesAllRecords.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fd60f97a407491778f4e2750fb2d9997)_tmp;
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


    public class lcoGetSettings : VarsBag {
public bool outParamo_IsActiveDEV_C01 = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsActiveDEV_C01 = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "41e5bf45-bac9-4efc-a329-7ef681ba4309"))
using (activitySource.CreateScreenDataActionActivity("SupplierInvoicesReport", "GetSettings")){
// o_IsActiveDEV_C01 = IsActiveDEV_C01
result.outParamo_IsActiveDEV_C01=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_C01])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsActiveDEV_C01 = result.outParamo_IsActiveDEV_C01;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsActiveDEV_C01;
}
public class lcvGetUserApplicationRoles : VarsBag {
public RL_a628f44fbe3d61a818adba8c3d848715 queryResGetUserRoles_outParamList = new RL_a628f44fbe3d61a818adba8c3d848715();
public long queryResGetUserRoles_outParamCount = 0L;

public RL_84bdfe424d1eb0223fc2b8cfa9bb96be queryResGetSupplierUsersByUserId_outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
public long queryResGetSupplierUsersByUserId_outParamCount = 0L;

public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionCorp_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionCorp_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public bool outParamIsAuditor = false;

public long outParamSupplierId = 0L;

public long outParamUserRegion = 0L;

public bool outParamIsAllRegions = false;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,bool,long,long,bool)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
bool outParamIsAuditor = default;
long outParamSupplierId = default;
long outParamUserRegion = default;
bool outParamIsAllRegions = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_g_Reports_SupplierInvoicesReport_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "a92622c4-4b3e-4ae9-b273-3dd116c83b93"))
using (activitySource.CreateScreenDataActionActivity("SupplierInvoicesReport", "GetUserApplicationRoles")){
// Query QueryGetUserRoles
cancellationToken.ThrowIfCancellationRequested();
int QueryGetUserRoles_maxRecords = 0;
int QueryGetUserRoles_startIndex = 0;(localVars.queryResGetUserRoles_outParamList,localVars.queryResGetUserRoles_outParamCount) = await FuncDataActionGetUserApplicationRoles.QueryGetUserRoles(requestContext,QueryGetUserRoles_maxRecords,QueryGetUserRoles_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),2,3,cancellationToken);

// empty?
if((localVars.queryResGetUserRoles_outParamList.Empty)) {
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 1;
if (datasetGetRoleConcept_maxRecords < 1) datasetGetRoleConcept_maxRecords = 1;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Single,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENEntraRole.ssRoleName;
target.ssCode = source.ssENApplicationRole.ssCode;
return target;
}, cancellationToken));
} else {
// UserRolesList = GetUserRoles.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetUserRoles_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_0a3f9d90df8bd7c726f88030e3651410 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
}

// IsAuditor = CheckTelcelUserAuditorRole()
result.outParamIsAuditor=(await Functions.ssCheckTelcelUserAuditorRole(requestContext,"",cancellationToken));
// GetUserRegionId
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

// Query datasetGetRegionCorp
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRegionCorp_maxRecords = 1;
if (datasetGetRegionCorp_maxRecords < 1) datasetGetRegionCorp_maxRecords = 1;
int datasetGetRegionCorp_startIndex = 0;(localVars.queryResGetRegionCorp_outParamList,localVars.queryResGetRegionCorp_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRegionCorp(requestContext,datasetGetRegionCorp_maxRecords,datasetGetRegionCorp_startIndex,IterationMultiplicity.Never,cancellationToken);

// UserRegion = GetUserRegionId.o_RegionId
result.outParamUserRegion=localVars.resGetUserRegionId.outParamo_RegionId;

// IsAllRegions = UserRegion = NullIdentifier or UserRegion = GetRegionCorp.List.Current.Region.Id
result.outParamIsAllRegions=((result.outParamUserRegion==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))||(result.outParamUserRegion==localVars.queryResGetRegionCorp_outParamList.CurrentRec.ssENRegion.ssId));
// Query datasetGetSupplierUsersByUserId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplierUsersByUserId_maxRecords = 1;
if (datasetGetSupplierUsersByUserId_maxRecords < 1) datasetGetSupplierUsersByUserId_maxRecords = 1;
int datasetGetSupplierUsersByUserId_startIndex = 0;(localVars.queryResGetSupplierUsersByUserId_outParamList,localVars.queryResGetSupplierUsersByUserId_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetSupplierUsersByUserId(requestContext,datasetGetSupplierUsersByUserId_maxRecords,datasetGetSupplierUsersByUserId_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// SupplierId = GetSupplierUsersByUserId.List.Current.SupplierUser.SupplierId
result.outParamSupplierId=localVars.queryResGetSupplierUsersByUserId_outParamList.CurrentRec.ssENSupplierUser.ssSupplierId;
} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamIsAuditor = result.outParamIsAuditor;
outParamSupplierId = result.outParamSupplierId;
outParamUserRegion = result.outParamUserRegion;
outParamIsAllRegions = result.outParamIsAllRegions;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamIsAuditor,outParamSupplierId,outParamUserRegion,outParamIsAllRegions);
}


    public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetUserRoles" TA1FGaIDsk2ulvhr9fmazA of Action "GetUserApplicationRoles"
public static async Task<(RL_a628f44fbe3d61a818adba8c3d848715,long)> QueryGetUserRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,int qproRoleStatusActiveId,int qpcoConceptFsP,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetUserRoles", "19450d4c-03a2-4db2-ae96-f86bf5f99acc");
using var queryActivity = activitySource.CreateSqlQueryActivity("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetUserRoles", "19450d4c-03a2-4db2-ae96-f86bf5f99acc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityUserApplicationRole = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRole");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityRoleConcept = AppUtils.Instance.RuntimeEntityReplace("RoleConcept");
string entityUserApplicationRoleTemp = AppUtils.Instance.RuntimeEntityReplace("UserApplicationRoleTemp");
sqlCmd.CreateParameter("@qpusUserId", DbType.String, qpusUserId);
sqlCmd.CreateParameter("@qproRoleStatusActiveId", DbType.Int32, qproRoleStatusActiveId);
sqlCmd.CreateParameter("@qpcoConceptFsP", DbType.Int32, qpcoConceptFsP);
string sql = "";
string advSql = "SELECT  \n    uar.ApplicationRoleId, \n    ar.Name, \n    ar.Code, \n    0 \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRole,"") + " uar \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uar.ApplicationRoleId = ar.Id \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRoleConcept,"") + " rc ON rc.ApplicationRoleId = ar.Id \nWHERE uar.UserId = @qpusUserId \n  AND uar.RoleStatusId = @qproRoleStatusActiveId \n  AND uar.ConceptId = @qpcoConceptFsP \n \nUNION \n \nSELECT  \n    uat.ApplicationRoleId, \n    ar.Name, \n    ar.Code, \n    1 \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUserApplicationRoleTemp,"") + " uat \nJOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ar ON uat.ApplicationRoleId = ar.Id \nWHERE uat.UserId = @qpusUserId \n  AND uat.RoleStatusId = @qproRoleStatusActiveId \n  AND uat.ConceptId = @qpcoConceptFsP";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_a628f44fbe3d61a818adba8c3d848715 outParamList = new RL_a628f44fbe3d61a818adba8c3d848715();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a628f44fbe3d61a818adba8c3d848715 _tmp = new RL_a628f44fbe3d61a818adba8c3d848715();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a628f44fbe3d61a818adba8c3d848715)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetUserRoles in GetUserApplicationRoles in SupplierInvoicesReport in g_Reports in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in SupplierInvoicesReport in g_Reports in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in SupplierInvoicesReport in g_Reports in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message));
}
}
}

// Query Function "GetSupplierUsersByUserId" 1Ol2JIT9C0KzXy6FFHb5DA of Action "GetUserApplicationRoles"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUsersByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "2476e9d4-fd84-420b-b35f-2e851476f90c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "2476e9d4-fd84-420b-b35f-2e851476f90c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/DataActions.xCImqT5L6Uqycz3RFsg7kw/NodesNotShownInESpaceTree.1Ol2JIT9C0KzXy6FFHb5DA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser15\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser15\".\"userid\" = @qpusUserId) AND (\"ensupplieruser15\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"ensupplieruser15\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"ensupplieruser15\".\"name\" ASC ");
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
RL_84bdfe424d1eb0223fc2b8cfa9bb96be outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84bdfe424d1eb0223fc2b8cfa9bb96be _tmp = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84bdfe424d1eb0223fc2b8cfa9bb96be)_tmp;
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

// Query Function "GetRegionCorp" R2D+L2wDyUO0vvcs+Mpbqw of Action "GetUserApplicationRoles"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionCorp(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRegionCorp", "2ffe6047-036c-43c9-b4be-f72cf8ca5bab");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRegionCorp", "2ffe6047-036c-43c9-b4be-f72cf8ca5bab", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/DataActions.xCImqT5L6Uqycz3RFsg7kw/NodesNotShownInESpaceTree.R2D+L2wDyUO0vvcs+Mpbqw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion92\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion92\"");
whereBuilder.Append(" WHERE (\"enregion92\".\"isactive\" = 1) AND (\"enregion92\".\"centrortp\" = 'MX00')");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
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

private static async Task<RC_6d4a92ad9e5239e9c12dd070f5b17d69> datasetGetRoleConceptReadDbAsync(RC_6d4a92ad9e5239e9c12dd070f5b17d69 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" nkc9TjYuDUi6iMznN1uElg of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRoleConcept", "4e3d479e-2e36-480d-ba88-cce7375b8496");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRoleConcept", "4e3d479e-2e36-480d-ba88-cce7375b8496", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.0ca2CAZkt0in9tusiQ2DSQ/DataActions.xCImqT5L6Uqycz3RFsg7kw/NodesNotShownInESpaceTree.nkc9TjYuDUi6iMznN1uElg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole50\".\"code\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enentrarole48\".\"rolename\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept18\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal99\" Inner JOIN {User} \"enuser163\" ON (\"enuser_extended_internal99\".\"id\" = \"enuser163\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole48\" ON (\"enuser_extended_internal99\".\"jobtitle\" = \"enentrarole48\".\"rolename\"))  Left JOIN {Region} \"enregion93\" ON (\"enuser_extended_internal99\".\"regionid\" = \"enregion93\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept18\" ON (\"enentrarole48\".\"id\" = \"enroleconcept18\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole50\" ON (\"enroleconcept18\".\"applicationroleid\" = \"enapplicationrole50\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser163\".\"id\" = @qpusUser_Id) AND (\"enuser163\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser163\".\"id\" IS NULL)");
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
RL_721bdfcca4a4edbce82baece8dfe837b outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_721bdfcca4a4edbce82baece8dfe837b _tmp = new RL_721bdfcca4a4edbce82baece8dfe837b();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.SupplierInvoicesReport.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_721bdfcca4a4edbce82baece8dfe837b)_tmp;
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
