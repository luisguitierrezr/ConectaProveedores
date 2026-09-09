using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_g_Reports_LinesReport_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_g_Reports_LinesReport_ScreenModel).Namespace);

    public long varLcApplicationRoleIdForAggregate;
public string varLcColumnJSONVar;
public int varLcCountAfterFetch;
public bool varLcIsToEmpty;
public bool varLcLoading;
public bool varLcReInvokeToggler;
public int varLcStartIndex;
public string varLcTableSort;
public AggregateRecord<RL_6f578d989bb546e044c5b0b47d17f46f> ScreenDataSetGetInvoices;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public ConectaProveedores_g_Reports_LinesReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_g_Reports_LinesReport_ScreenModel() {
}



    public ConectaProveedores_g_Reports_LinesReport_ScreenModel(long varLcApplicationRoleIdForAggregate, string varLcColumnJSONVar, int varLcCountAfterFetch, bool varLcIsToEmpty, bool varLcLoading, bool varLcReInvokeToggler, int varLcStartIndex, string varLcTableSort, AggregateRecord<RL_6f578d989bb546e044c5b0b47d17f46f> ScreenDataSetGetInvoices, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, ConectaProveedores_g_Reports_LinesReport_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"ApplicationRoleIdForAggregate", "ColumnJSONVar", "CountAfterFetch", "IsToEmpty", "Loading", "ReInvokeToggler", "StartIndex", "TableSort", "GetInvoices", "GetRegions", "GetUserApplicationRoles", "ClientVars"}, new string[] {"varLcApplicationRoleIdForAggregate", "varLcColumnJSONVar", "varLcCountAfterFetch", "varLcIsToEmpty", "varLcLoading", "varLcReInvokeToggler", "varLcStartIndex", "varLcTableSort", "ScreenDataSetGetInvoices", "ScreenDataSetGetRegions", "varLcGetUserApplicationRoles", "clientVariables"});
this.varLcApplicationRoleIdForAggregate = varLcApplicationRoleIdForAggregate;
this.varLcColumnJSONVar = varLcColumnJSONVar;
this.varLcCountAfterFetch = varLcCountAfterFetch;
this.varLcIsToEmpty = varLcIsToEmpty;
this.varLcLoading = varLcLoading;
this.varLcReInvokeToggler = varLcReInvokeToggler;
this.varLcStartIndex = varLcStartIndex;
this.varLcTableSort = varLcTableSort;
this.ScreenDataSetGetInvoices = ScreenDataSetGetInvoices;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_aa8eac9e200aee33e0be6438a23c61c3> datasetGetInvoicesReadDbAsync(RC_aa8eac9e200aee33e0be6438a23c61c3 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCurrency.Read( r, ref index);
rec.ssENDepartment.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoicePoliza.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENManagement.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetInvoices" +qQw6fYCwESp1e2vMtXlmQ of Action "LinesReport"
public static async Task<(RL_6f578d989bb546e044c5b0b47d17f46f,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpinOffsetUtc,DateTime qpdaReport62_DateFrom,DateTime qpdaReport62_DateTo,long qpreRequisition_RegionId,long qpsuSupplier_Id,bool qpboIsToEmpty,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.LinesReport.GetInvoices", "e930a4fa-02f6-44c0-a9d5-edaf32d5e599");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("LinesReport","g_Reports.LinesReport.GetInvoices");
// Query Iterations: Multiple
// Refresh Query W_nuG_rBD0uiuBOpz88ZVA Iterations: Multiple
// Refresh Query jDGuw3YRWEy1lh32bHWV7A Iterations: Multiple
// Refresh Query zMTNJ3KyQkaz0cx5DQU4fQ Iterations: Multiple
// Refresh Query PZSfpffnAUSQ7nO9o__EDw Iterations: Multiple
// Refresh Query xCsG7ZhbR0ykImfB5E8BCg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.lbzXMrrOC0+lzuKF1JvgVg/ScreenDataSets.+qQw6fYCwESp1e2vMtXlmQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency9\".\"code\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"endepartment9\".\"name\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"eninvoice108\".\"name\" o13, NULL o14, NULL o15, NULL o16, NULL o17, trim_scale(\"eninvoice108\".\"totalamount\"::numeric) o18, NULL o19, NULL o20, NULL o21, NULL o22, \"eninvoice108\".\"createdon\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, trim_scale(\"eninvoiceextended23\".\"tipocambio\"::numeric) o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, \"eninvoicepoliza3\".\"polizasap\" o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, \"eninvoicepoliza3\".\"createdon\" o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, \"enmanagement1\".\"name\" o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, \"enpaymentterms16\".\"ctd_dias\" o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, \"enregion96\".\"name\" o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, \"ensupplier71\".\"name\" o183, \"ensupplier71\".\"number\" o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, \"enuser164\".\"name\" o210, NULL o211, NULL o212, NULL o213, NULL o214, \"enuser_extended_internal100\".\"employeenumber\" o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, NULL o226, NULL o227, NULL o228, NULL o229, NULL o230, NULL o231, NULL o232, \"enuser_extended_internal100\".\"telceldireccion\" o233");
fromBuilder.Append(" FROM ((((((((((((({Invoice} \"eninvoice108\" Inner JOIN {Requisition} \"enrequisition87\" ON (\"eninvoice108\".\"requisitionid\" = \"enrequisition87\".\"id\"))  Left JOIN {Supplier} \"ensupplier71\" ON (\"enrequisition87\".\"supplierid\" = \"ensupplier71\".\"id\"))  Left JOIN {Region} \"enregion96\" ON (\"enrequisition87\".\"regionid\" = \"enregion96\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus9\" ON (\"eninvoice108\".\"invoicestatusid\" = \"eninvoicestatus9\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting22\" ON (\"eninvoice108\".\"id\" = \"eninvoiceaccounting22\".\"invoiceid\"))  Left JOIN {User} \"enuser164\" ON (\"eninvoiceaccounting22\".\"submissionby\" = \"enuser164\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal100\" ON (\"enuser164\".\"id\" = \"enuser_extended_internal100\".\"id\"))  Inner JOIN {Department} \"endepartment9\" ON (\"enuser_extended_internal100\".\"departmentid\" = \"endepartment9\".\"id\"))  Left JOIN {Currency} \"encurrency9\" ON (\"enrequisition87\".\"currencyid\" = \"encurrency9\".\"code\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended23\" ON (\"eninvoice108\".\"id\" = \"eninvoiceextended23\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms16\" ON (\"eninvoiceaccounting22\".\"paymenttermsid\" = \"enpaymentterms16\".\"id\"))  Left JOIN {InvoicePoliza} \"eninvoicepoliza3\" ON (\"eninvoice108\".\"id\" = \"eninvoicepoliza3\".\"id\"))  Left JOIN {Management} \"enmanagement1\" ON (\"enuser_extended_internal100\".\"managementid\" = \"enmanagement1\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (NOT (@qpboIsToEmpty = 1)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboIsToEmpty", DbType.Boolean, qpboIsToEmpty);
if (qpreRequisition_RegionId != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition87\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition87\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition87\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier71\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier71\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier71\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaReport62_DateFrom != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice108\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) >= @qpdaReport62_DateFrom) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaReport62_DateFrom", DbType.DateTime, qpdaReport62_DateFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaReport62_DateFrom", DbType.DateTime, qpdaReport62_DateFrom);
}
if (qpdaReport62_DateTo != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice108\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) <= @qpdaReport62_DateTo)");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaReport62_DateTo", DbType.DateTime, qpdaReport62_DateTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaReport62_DateTo", DbType.DateTime, qpdaReport62_DateTo);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "Currency", "InvoiceStatus", "Department", "PaymentTerms", "InvoiceExtended", "InvoiceAccounting", "Supplier", "User", "Management", "Invoice", "InvoicePoliza", "Region", "User_Extended_Internal", "Requisition" }, new string[] { "ENCurrency9", "ENInvoiceStatus9", "ENDepartment9", "ENPaymentTerms16", "ENInvoiceExtended23", "ENInvoiceAccounting22", "ENSupplier71", "ENUser164", "ENManagement1", "ENInvoice108", "ENInvoicePoliza3", "ENRegion96", "ENUser_Extended_Internal100", "ENRequisition87" }, new System.Collections.Generic.Dictionary<string, string>[] { ENCurrencyEntity.AttributesToDatabaseNamesMap(), ENInvoiceStatusEntity.AttributesToDatabaseNamesMap(), ENDepartmentEntity.AttributesToDatabaseNamesMap(), ENPaymentTermsEntity.AttributesToDatabaseNamesMap(), ENInvoiceExtendedEntity.AttributesToDatabaseNamesMap(), ENInvoiceAccountingEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENUserEntity.AttributesToDatabaseNamesMap(), ENManagementEntity.AttributesToDatabaseNamesMap(), ENInvoiceEntity.AttributesToDatabaseNamesMap(), ENInvoicePolizaEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENUser_Extended_InternalEntity.AttributesToDatabaseNamesMap(), ENRequisitionEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"eninvoice108\".\"createdon\" DESC ");
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
RL_6f578d989bb546e044c5b0b47d17f46f outParamList = new RL_6f578d989bb546e044c5b0b47d17f46f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[14];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, false});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true});
opt[8] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
opt[9] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true});
opt[13] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.LinesReport.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.LinesReport.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6f578d989bb546e044c5b0b47d17f46f _tmp = new RL_6f578d989bb546e044c5b0b47d17f46f();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.LinesReport.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6f578d989bb546e044c5b0b47d17f46f)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query g_Reports.LinesReport.GetInvoices.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetRegions" p9NB8FY_OkW_FGMXA8W6DQ of Action "LinesReport"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("g_Reports.LinesReport.GetRegions", "f041d3a7-3f56-453a-bf14-631703c5ba0d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("LinesReport","g_Reports.LinesReport.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.lbzXMrrOC0+lzuKF1JvgVg/ScreenDataSets.p9NB8FY_OkW_FGMXA8W6DQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion97\".\"id\" o0, NULL o1, \"enregion97\".\"name\" o2, NULL o3, \"enregion97\".\"centrortp\" o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion97\"");
whereBuilder.Append(" WHERE (\"enregion97\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion97\".\"centrortp\" ASC ");
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
opt[0] = new BitArray(new bool[] {false, true, false, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.LinesReport.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.LinesReport.GetRegions.List", cancellationToken: cancellationToken);
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


    public class lcvGetUserApplicationRoles : VarsBag {
public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_a628f44fbe3d61a818adba8c3d848715 queryResGetUserRoles_outParamList = new RL_a628f44fbe3d61a818adba8c3d848715();
public long queryResGetUserRoles_outParamCount = 0L;

public RL_84bdfe424d1eb0223fc2b8cfa9bb96be queryResGetSupplierUsersByUserId_outParamList = new RL_84bdfe424d1eb0223fc2b8cfa9bb96be();
public long queryResGetSupplierUsersByUserId_outParamCount = 0L;

public RL_5d3a02aa993c7474297e33d992f39ad0 queryResGetRegionCorp_outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
public long queryResGetRegionCorp_outParamCount = 0L;

public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public bool outParamIsAuditor = false;

public long outParamUserRegion = 0L;

public long outParamUserSupplier = 0L;

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
long outParamUserRegion = default;
long outParamUserSupplier = default;
bool outParamIsAllRegions = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_g_Reports_LinesReport_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "d9e10fab-6865-44dc-9dc8-de1c9954981a"))
using (activitySource.CreateScreenDataActionActivity("LinesReport", "GetUserApplicationRoles")){
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

// UserSupplier = GetSupplierUsersByUserId.List.Current.SupplierUser.SupplierId
result.outParamUserSupplier=localVars.queryResGetSupplierUsersByUserId_outParamList.CurrentRec.ssENSupplierUser.ssSupplierId;
} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamIsAuditor = result.outParamIsAuditor;
outParamUserRegion = result.outParamUserRegion;
outParamUserSupplier = result.outParamUserSupplier;
outParamIsAllRegions = result.outParamIsAllRegions;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamIsAuditor,outParamUserRegion,outParamUserSupplier,outParamIsAllRegions);
}


    public static class FuncDataActionGetUserApplicationRoles {

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
// Query Function "GetRoleConcept" Y_cBCquPuE+DGZPd30W_PA of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.LinesReport.GetUserApplicationRoles.GetRoleConcept", "0a01f763-8fab-4fb8-8319-93dddf45bf3c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.LinesReport.GetUserApplicationRoles.GetRoleConcept", "0a01f763-8fab-4fb8-8319-93dddf45bf3c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.lbzXMrrOC0+lzuKF1JvgVg/DataActions.qw_h2WVo3ESdyN4cmVSYGg/NodesNotShownInESpaceTree.Y_cBCquPuE+DGZPd30W_PA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole51\".\"code\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enentrarole49\".\"rolename\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept19\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal101\" Inner JOIN {User} \"enuser165\" ON (\"enuser_extended_internal101\".\"id\" = \"enuser165\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole49\" ON (\"enuser_extended_internal101\".\"jobtitle\" = \"enentrarole49\".\"rolename\"))  Left JOIN {Region} \"enregion98\" ON (\"enuser_extended_internal101\".\"regionid\" = \"enregion98\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept19\" ON (\"enentrarole49\".\"id\" = \"enroleconcept19\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole51\" ON (\"enroleconcept19\".\"applicationroleid\" = \"enapplicationrole51\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser165\".\"id\" = @qpusUser_Id) AND (\"enuser165\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser165\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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

// Query Function "GetUserRoles" sRSDJo+Y1U61sV8abGMJMg of Action "GetUserApplicationRoles"
public static async Task<(RL_a628f44fbe3d61a818adba8c3d848715,long)> QueryGetUserRoles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,int qproRoleStatusActiveId,int qpcoConceptFsP,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("g_Reports.LinesReport.GetUserApplicationRoles.GetUserRoles", "268314b1-988f-4ed5-b5b1-5f1a6c630932");
using var queryActivity = activitySource.CreateSqlQueryActivity("g_Reports.LinesReport.GetUserApplicationRoles.GetUserRoles", "268314b1-988f-4ed5-b5b1-5f1a6c630932", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetUserRoles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a628f44fbe3d61a818adba8c3d848715)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetUserRoles in GetUserApplicationRoles in LinesReport in g_Reports in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in LinesReport in g_Reports in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetUserRoles in GetUserApplicationRoles in LinesReport in g_Reports in ConectaProveedores (SELECT       uar.ApplicationRoleId,      ar.Name,      ar.Code,      0  FROM {UserApplicationRole} uar  JOIN {ApplicationRole} ar ON uar.ApplicationRoleId = ar.Id  JOIN {RoleConcept} rc ON rc.ApplicationRoleId = ar.Id  WHERE uar.UserId = @UserId    AND uar.RoleStatusId = @RoleStatusActiveId    AND uar.ConceptId = @ConceptFsP    UNION    SELECT       uat.ApplicationRoleId,      ar.Name,      ar.Code,      1  FROM {UserApplicationRoleTemp} uat  JOIN {ApplicationRole} ar ON uat.ApplicationRoleId = ar.Id  WHERE uat.UserId = @UserId    AND uat.RoleStatusId = @RoleStatusActiveId    AND uat.ConceptId = @ConceptFsP): " + aqExcep.Message));
}
}
}

// Query Function "GetSupplierUsersByUserId" yu4NffuYVUSPd8VA52_2+A of Action "GetUserApplicationRoles"
public static async Task<(RL_84bdfe424d1eb0223fc2b8cfa9bb96be,long)> datasetGetSupplierUsersByUserId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.LinesReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "7d0deeca-98fb-4455-8f77-c540e76ff6f8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.LinesReport.GetUserApplicationRoles.GetSupplierUsersByUserId", "7d0deeca-98fb-4455-8f77-c540e76ff6f8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.lbzXMrrOC0+lzuKF1JvgVg/DataActions.qw_h2WVo3ESdyN4cmVSYGg/NodesNotShownInESpaceTree.yu4NffuYVUSPd8VA52_2+A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"ensupplieruser17\".\"supplierid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14");
fromBuilder.Append(" FROM {SupplierUser} \"ensupplieruser17\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser17\".\"userid\" = @qpusUserId) AND (\"ensupplieruser17\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"ensupplieruser17\".\"userid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"ensupplieruser17\".\"name\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetSupplierUsersByUserId.List", cancellationToken: cancellationToken);
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

// Query Function "GetRegionCorp" Lp6qvI30EE6mYKkpwz3XJA of Action "GetUserApplicationRoles"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegionCorp(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("g_Reports.LinesReport.GetUserApplicationRoles.GetRegionCorp", "bcaa9e2e-f48d-4e10-a660-a929c33dd724");
using var queryActivity = activitySource.CreateAggregateQueryActivity("g_Reports.LinesReport.GetUserApplicationRoles.GetRegionCorp", "bcaa9e2e-f48d-4e10-a660-a929c33dd724", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.BM45GkAQfUyFUQyknhK0HA/NodesShownInESpaceTree.lbzXMrrOC0+lzuKF1JvgVg/DataActions.qw_h2WVo3ESdyN4cmVSYGg/NodesNotShownInESpaceTree.Lp6qvI30EE6mYKkpwz3XJA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enregion99\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion99\"");
whereBuilder.Append(" WHERE (\"enregion99\".\"isactive\" = 1) AND (\"enregion99\".\"centrortp\" = 'MX00')");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query g_Reports.LinesReport.GetUserApplicationRoles.GetRegionCorp.List", cancellationToken: cancellationToken);
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


}
