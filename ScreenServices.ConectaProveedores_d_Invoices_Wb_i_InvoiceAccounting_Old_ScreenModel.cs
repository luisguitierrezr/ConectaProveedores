using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public long inParami_RequisitionId;
public bool inParamIsActiveUser;
public bool inParamIsCorp;
public string inParamSupplierNumber;
public decimal varLcl_Iva;
public bool varLcl_ShowImportPopup;
public bool varLcl_ShowApprovalInvoice;
public bool varLcl_ShowCancelInvoice;
public bool varLcl_ShowModifyPopup;
public bool varLcl_IsApproval;
public bool varLcl_IsImport;
public RL_0704e14bc1b3305d76f59d709913c287 varLcl_InvoiceAccountingEntries;
public AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters;
public AggregateRecord<RL_9404dc36b913809894c7e4e44e8e1dd8> ScreenDataSetGetInvoiceRetentionsByInvoiceId;
public AggregateRecord<RL_bf188616de0f0f2f6ca06ba5dba27490> ScreenDataSetGetTaxIndicators;
public AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> ScreenDataSetGetInvoiceApproval;
public AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods;
public AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms;
public AggregateRecord<RL_a675a81d4063c2bba451ee57edc49e99> ScreenDataSetGetInvoiceExtendedById;
public AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> ScreenDataSetGetAccountingAccountsServiceTypes;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public AggregateRecord<RL_ccf70f600f06def33a14ca10a1120a68> ScreenDataSetGetInvoiceAccountingsByInvoiceId;
public AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
public AggregateRecord<RL_948a214f011367826beec566f5df17e6> ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId;
public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_DataActionGetData_Model varLcGetData;
public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_DataActionGetInvoiceAccounting_Model varLcGetInvoiceAccounting;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel(long inParami_InvoiceId, long inParami_RequisitionId, bool inParamIsActiveUser, bool inParamIsCorp, string inParamSupplierNumber, decimal varLcl_Iva, bool varLcl_ShowImportPopup, bool varLcl_ShowApprovalInvoice, bool varLcl_ShowCancelInvoice, bool varLcl_ShowModifyPopup, bool varLcl_IsApproval, bool varLcl_IsImport, RL_0704e14bc1b3305d76f59d709913c287 varLcl_InvoiceAccountingEntries, AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters, AggregateRecord<RL_9404dc36b913809894c7e4e44e8e1dd8> ScreenDataSetGetInvoiceRetentionsByInvoiceId, AggregateRecord<RL_bf188616de0f0f2f6ca06ba5dba27490> ScreenDataSetGetTaxIndicators, AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> ScreenDataSetGetInvoiceApproval, AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods, AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms, AggregateRecord<RL_a675a81d4063c2bba451ee57edc49e99> ScreenDataSetGetInvoiceExtendedById, AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> ScreenDataSetGetAccountingAccountsServiceTypes, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, AggregateRecord<RL_ccf70f600f06def33a14ca10a1120a68> ScreenDataSetGetInvoiceAccountingsByInvoiceId, AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId, AggregateRecord<RL_948a214f011367826beec566f5df17e6> ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_DataActionGetData_Model varLcGetData, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_DataActionGetInvoiceAccounting_Model varLcGetInvoiceAccounting, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_RequisitionId", "IsActiveUser", "IsCorp", "SupplierNumber", "l_Iva", "l_ShowImportPopup", "l_ShowApprovalInvoice", "l_ShowCancelInvoice", "l_ShowModifyPopup", "l_IsApproval", "l_IsImport", "l_InvoiceAccountingEntries", "GetCostCenters", "GetInvoiceRetentionsByInvoiceId", "GetTaxIndicators", "GetInvoiceApproval", "GetPaymentMethods", "GetPaymentTerms", "GetInvoiceExtendedById", "GetAccountingAccountsServiceTypes", "GetRegions", "GetInvoiceAccountingsByInvoiceId", "GetInvoiceExtendedMoreChargesByInvoiceId", "GetInvoiceExtendedTaxsByInvoiceId", "GetData", "GetInvoiceAccounting", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_RequisitionId", "inParamIsActiveUser", "inParamIsCorp", "inParamSupplierNumber", "varLcl_Iva", "varLcl_ShowImportPopup", "varLcl_ShowApprovalInvoice", "varLcl_ShowCancelInvoice", "varLcl_ShowModifyPopup", "varLcl_IsApproval", "varLcl_IsImport", "varLcl_InvoiceAccountingEntries", "ScreenDataSetGetCostCenters", "ScreenDataSetGetInvoiceRetentionsByInvoiceId", "ScreenDataSetGetTaxIndicators", "ScreenDataSetGetInvoiceApproval", "ScreenDataSetGetPaymentMethods", "ScreenDataSetGetPaymentTerms", "ScreenDataSetGetInvoiceExtendedById", "ScreenDataSetGetAccountingAccountsServiceTypes", "ScreenDataSetGetRegions", "ScreenDataSetGetInvoiceAccountingsByInvoiceId", "ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId", "ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId", "varLcGetData", "varLcGetInvoiceAccounting", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParamIsActiveUser = inParamIsActiveUser;
this.inParamIsCorp = inParamIsCorp;
this.inParamSupplierNumber = inParamSupplierNumber;
this.varLcl_Iva = varLcl_Iva;
this.varLcl_ShowImportPopup = varLcl_ShowImportPopup;
this.varLcl_ShowApprovalInvoice = varLcl_ShowApprovalInvoice;
this.varLcl_ShowCancelInvoice = varLcl_ShowCancelInvoice;
this.varLcl_ShowModifyPopup = varLcl_ShowModifyPopup;
this.varLcl_IsApproval = varLcl_IsApproval;
this.varLcl_IsImport = varLcl_IsImport;
this.varLcl_InvoiceAccountingEntries = varLcl_InvoiceAccountingEntries;
this.ScreenDataSetGetCostCenters = ScreenDataSetGetCostCenters;
this.ScreenDataSetGetInvoiceRetentionsByInvoiceId = ScreenDataSetGetInvoiceRetentionsByInvoiceId;
this.ScreenDataSetGetTaxIndicators = ScreenDataSetGetTaxIndicators;
this.ScreenDataSetGetInvoiceApproval = ScreenDataSetGetInvoiceApproval;
this.ScreenDataSetGetPaymentMethods = ScreenDataSetGetPaymentMethods;
this.ScreenDataSetGetPaymentTerms = ScreenDataSetGetPaymentTerms;
this.ScreenDataSetGetInvoiceExtendedById = ScreenDataSetGetInvoiceExtendedById;
this.ScreenDataSetGetAccountingAccountsServiceTypes = ScreenDataSetGetAccountingAccountsServiceTypes;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetInvoiceAccountingsByInvoiceId = ScreenDataSetGetInvoiceAccountingsByInvoiceId;
this.ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId = ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
this.ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId = ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId;
this.varLcGetData = varLcGetData;
this.varLcGetInvoiceAccounting = varLcGetInvoiceAccounting;
this.clientVariables = clientVariables;
}



    
// Query Function "GetCostCenters" G9jaHCeozUKqexgsrCvHVQ of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_ec55ed22dae89075d036f3a863173164,long)> datasetGetCostCenters(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetCostCenters", "1cdad81b-a827-42cd-aa7b-182cac2bc755");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetCostCenters");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.G9jaHCeozUKqexgsrCvHVQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encostcentersap9\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"encostcentersap9\".\"ce_coste\" o6, \"encostcentersap9\".\"cebe\" o7, \"encostcentersap9\".\"denominacion\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM {CostCenterSAP} \"encostcentersap9\"");
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
RL_ec55ed22dae89075d036f3a863173164 outParamList = new RL_ec55ed22dae89075d036f3a863173164();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetCostCenters.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ec55ed22dae89075d036f3a863173164 _tmp = new RL_ec55ed22dae89075d036f3a863173164();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetCostCenters.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ec55ed22dae89075d036f3a863173164)_tmp;
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

// Query Function "GetInvoiceRetentionsByInvoiceId" KdHhMiSGV0uWMWSbStT9YQ of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceRetentionsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceRetentionsByInvoiceId", "32e1d129-8624-4b57-9631-649b4ad4fd61");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceRetentionsByInvoiceId");
// Query Iterations: Multiple
// Refresh Query W6upSjuMq0S85qovPUF38A Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.KdHhMiSGV0uWMWSbStT9YQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedtax8\".\"id\" o0, \"eninvoiceextendedtax8\".\"invoiceid\" o1, \"eninvoiceextendedtax8\".\"invoicetaxtypeid\" o2, \"eninvoiceextendedtax8\".\"impuesto\" o3, trim_scale(\"eninvoiceextendedtax8\".\"base\"::numeric) o4, trim_scale(\"eninvoiceextendedtax8\".\"tasaocuota\"::numeric) o5, trim_scale(\"eninvoiceextendedtax8\".\"importe\"::numeric) o6, \"eninvoiceextendedtax8\".\"tipofactor\" o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax8\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax8\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax8\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax8\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedtax8\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId);
whereBuilder.Append(") AND ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax8\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax8\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax8\".\"invoiceid\" IS NULL)");
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
RL_9404dc36b913809894c7e4e44e8e1dd8 outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9404dc36b913809894c7e4e44e8e1dd8 _tmp = new RL_9404dc36b913809894c7e4e44e8e1dd8();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9404dc36b913809894c7e4e44e8e1dd8)_tmp;
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

// Query Function "GetTaxIndicators" Ung2Tg7ZpE+j9uSXqINMuQ of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicators(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetTaxIndicators", "4e367852-d90e-4fa4-a3f6-e497a8834cb9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetTaxIndicators");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.Ung2Tg7ZpE+j9uSXqINMuQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entaxindicator7\".\"id\" o0, NULL o1, \"entaxindicator7\".\"externalid\" o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator7\"");
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
RL_bf188616de0f0f2f6ca06ba5dba27490 outParamList = new RL_bf188616de0f0f2f6ca06ba5dba27490();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetTaxIndicators.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bf188616de0f0f2f6ca06ba5dba27490 _tmp = new RL_bf188616de0f0f2f6ca06ba5dba27490();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetTaxIndicators.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bf188616de0f0f2f6ca06ba5dba27490)_tmp;
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

private static async Task<RC_eac76b624d2264108f6fbeb95d9d43ba> datasetGetInvoiceApprovalReadDbAsync(RC_eac76b624d2264108f6fbeb95d9d43ba rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApproval" n+TOUeDSY063eRVqlCzAgw of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_d62c1f17f6aae94386bfdb54075ff733,long)> datasetGetInvoiceApproval(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpusGetUserId,long qpsuRequisition_SupplierId,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceApproval", "51cee49f-d2e0-4e63-b779-156a942cc083");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceApproval");
// Query Iterations: Never
// Refresh Query BRkGqhbZD0urKFb42xh5Sw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.n+TOUeDSY063eRVqlCzAgw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"eninvoice116\".\"invoicestatusid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceapprovallevel31\".\"id\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enrequisition95\".\"iscontractpending\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, \"ensupplier82\".\"pais\" o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice116\" Left JOIN {InvoiceApproval} \"eninvoiceapproval31\" ON (\"eninvoice116\".\"id\" = \"eninvoiceapproval31\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel31\" ON (\"eninvoiceapproval31\".\"id\" = \"eninvoiceapprovallevel31\".\"invoiceapprovalid\"))  Left JOIN {Requisition} \"enrequisition95\" ON (\"eninvoice116\".\"requisitionid\" = \"enrequisition95\".\"id\"))  Left JOIN {Supplier} \"ensupplier82\" ON (\"enrequisition95\".\"supplierid\" = \"ensupplier82\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice116\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice116\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice116\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition95\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition95\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition95\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" OR ((\"eninvoiceapprovallevel31\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel31\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel31\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel31\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel31\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel31\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel31\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel31\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel31\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel31\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel31\".\"requesttomodifyby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel31\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel31\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel31\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")))");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel31\".\"levelnumber\" DESC ");
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
RL_d62c1f17f6aae94386bfdb54075ff733 outParamList = new RL_d62c1f17f6aae94386bfdb54075ff733();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceApproval.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d62c1f17f6aae94386bfdb54075ff733 _tmp = new RL_d62c1f17f6aae94386bfdb54075ff733();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceApprovalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceApproval.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d62c1f17f6aae94386bfdb54075ff733)_tmp;
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

// Query Function "GetPaymentMethods" Wd0gZi4_LEqVdrJ+aW+y_w of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_0dcbcba642ca8b22e87f690d4de9d077,long)> datasetGetPaymentMethods(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentMethods", "6620dd59-3f2e-4a2c-9576-b27e696fb2ff");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentMethods");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.Wd0gZi4_LEqVdrJ+aW+y_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentmethods6\".\"id\" o0, \"enpaymentmethods6\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {PaymentMethods} \"enpaymentmethods6\"");
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
RL_0dcbcba642ca8b22e87f690d4de9d077 outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentMethods.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0dcbcba642ca8b22e87f690d4de9d077 _tmp = new RL_0dcbcba642ca8b22e87f690d4de9d077();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentMethods.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0dcbcba642ca8b22e87f690d4de9d077)_tmp;
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

// Query Function "GetPaymentTerms" uHRGb3UBq0yRNVA0W13m8A of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentTerms", "6f4674b8-0175-4cab-9135-50345b5de6f0");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentTerms");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.uHRGb3UBq0yRNVA0W13m8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms17\".\"id\" o0, \"enpaymentterms17\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms17\"");
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
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentTerms.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetPaymentTerms.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceExtendedById" 7L0AgfwcNkKlHAtUTRfipw of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_a675a81d4063c2bba451ee57edc49e99,long)> datasetGetInvoiceExtendedById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedById", "8100bdec-1cfc-4236-a51c-0b544d17e2a7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedById");
// Query Iterations: Never
// Refresh Query tOK99C+QDEOqgMx4B5eQTA Iterations: Never
// Refresh Query OZ8Ofu5SVE6jgZ2dfXRiZw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.7L0AgfwcNkKlHAtUTRfipw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextended29\".\"id\" o0, \"eninvoiceextended29\".\"version\" o1, \"eninvoiceextended29\".\"folio\" o2, \"eninvoiceextended29\".\"serie\" o3, \"eninvoiceextended29\".\"fechaemision\" o4, \"eninvoiceextended29\".\"formapago\" o5, \"eninvoiceextended29\".\"metodopago\" o6, \"eninvoiceextended29\".\"lugarexpedicion\" o7, trim_scale(\"eninvoiceextended29\".\"subtotal\"::numeric) o8, trim_scale(\"eninvoiceextended29\".\"descuento\"::numeric) o9, trim_scale(\"eninvoiceextended29\".\"totaliva\"::numeric) o10, trim_scale(\"eninvoiceextended29\".\"retenciones\"::numeric) o11, trim_scale(\"eninvoiceextended29\".\"total\"::numeric) o12, \"eninvoiceextended29\".\"tipocomprobante\" o13, \"eninvoiceextended29\".\"moneda\" o14, trim_scale(\"eninvoiceextended29\".\"tipocambio\"::numeric) o15, \"eninvoiceextended29\".\"usocfdi\" o16, \"eninvoiceextended29\".\"exportacion\" o17, \"eninvoiceextended29\".\"uuid\" o18");
fromBuilder.Append(" FROM {InvoiceExtended} \"eninvoiceextended29\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceextended29\".\"id\" = @qpinId) AND (\"eninvoiceextended29\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceextended29\".\"id\" IS NULL)");
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
RL_a675a81d4063c2bba451ee57edc49e99 outParamList = new RL_a675a81d4063c2bba451ee57edc49e99();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a675a81d4063c2bba451ee57edc49e99 _tmp = new RL_a675a81d4063c2bba451ee57edc49e99();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a675a81d4063c2bba451ee57edc49e99)_tmp;
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

// Query Function "GetAccountingAccountsServiceTypes" 1PVMiIQE2Eqc3GIfJ7Lxgg of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_60b4efe2937800b54618ed04c4847a05,long)> datasetGetAccountingAccountsServiceTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetAccountingAccountsServiceTypes", "884cf5d4-0484-4ad8-9cdc-621f27b2f182");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetAccountingAccountsServiceTypes");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.1PVMiIQE2Eqc3GIfJ7Lxgg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingaccounts_servicetype6\".\"cc\" o1, \"enaccountingaccounts_servicetype6\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype6\"");
whereBuilder.Append(" WHERE (\"enaccountingaccounts_servicetype6\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enaccountingaccounts_servicetype6\".\"cc\" ASC ");
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
RL_60b4efe2937800b54618ed04c4847a05 outParamList = new RL_60b4efe2937800b54618ed04c4847a05();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetAccountingAccountsServiceTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_60b4efe2937800b54618ed04c4847a05 _tmp = new RL_60b4efe2937800b54618ed04c4847a05();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetAccountingAccountsServiceTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_60b4efe2937800b54618ed04c4847a05)_tmp;
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

// Query Function "GetRegions" x8BVqDN3hE2L5g5uXiO2hQ of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetRegions", "a855c0c7-7733-4d84-8be6-0e6e5e23b685");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.x8BVqDN3hE2L5g5uXiO2hQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enregion108\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion108\"");
whereBuilder.Append(" WHERE (\"enregion108\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion108\".\"code\" ASC ");
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
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetRegions.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceAccountingsByInvoiceId" 2g5Mq0RZRECCLEq9+ZFyrg of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_ccf70f600f06def33a14ca10a1120a68,long)> datasetGetInvoiceAccountingsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccountingsByInvoiceId", "ab4c0eda-5944-4044-822c-4abdf99172ae");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccountingsByInvoiceId");
// Query Iterations: Never
// Refresh Query bY_ZDx9fikeMT8PTfXuS9g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.2g5Mq0RZRECCLEq9+ZFyrg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, trim_scale(\"eninvoiceaccounting28\".\"totalamount\"::numeric) o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20");
fromBuilder.Append(" FROM {InvoiceAccounting} \"eninvoiceaccounting28\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting28\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceaccounting28\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting28\".\"invoiceid\" IS NULL)");
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
RL_ccf70f600f06def33a14ca10a1120a68 outParamList = new RL_ccf70f600f06def33a14ca10a1120a68();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ccf70f600f06def33a14ca10a1120a68 _tmp = new RL_ccf70f600f06def33a14ca10a1120a68();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ccf70f600f06def33a14ca10a1120a68)_tmp;
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

// Query Function "GetInvoiceExtendedMoreChargesByInvoiceId" rbbj16QYeEy9pxZODUVaxg of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_ef088826c46241557fb82e7c7f21d334,long)> datasetGetInvoiceExtendedMoreChargesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedMoreChargesByInvoiceId", "d7e3b6ad-18a4-4c78-bda7-164e0d455ac6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedMoreChargesByInvoiceId");
// Query Iterations: Multiple
// Refresh Query TTEizSGH40C2vFm5BmtCHg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.rbbj16QYeEy9pxZODUVaxg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedmorecharges4\".\"id\" o0, \"eninvoiceextendedmorecharges4\".\"invoiceid\" o1, \"eninvoiceextendedmorecharges4\".\"nombreconcepto\" o2, trim_scale(\"eninvoiceextendedmorecharges4\".\"value\"::numeric) o3");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges4\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges4\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges4\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges4\".\"invoiceid\" IS NULL)");
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
RL_ef088826c46241557fb82e7c7f21d334 outParamList = new RL_ef088826c46241557fb82e7c7f21d334();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ef088826c46241557fb82e7c7f21d334 _tmp = new RL_ef088826c46241557fb82e7c7f21d334();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ef088826c46241557fb82e7c7f21d334)_tmp;
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

// Query Function "GetInvoiceExtendedTaxsByInvoiceId" 1eCE6RB25E6kQ8tGoVFKjQ of Action "Wb_i_InvoiceAccounting_Old"
public static async Task<(RL_948a214f011367826beec566f5df17e6,long)> datasetGetInvoiceExtendedTaxsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedTaxsByInvoiceId", "e984e0d5-7610-4ee4-a443-cb46a1514a8d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting_Old","d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedTaxsByInvoiceId");
// Query Iterations: Never
// Refresh Query FY2B+NGMIUCacYZiyJ_GNA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/ScreenDataSets.1eCE6RB25E6kQ8tGoVFKjQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"eninvoiceextendedtax9\".\"importe\") \"importesum\"");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax9\"");
whereBuilder.Append(" WHERE (\"eninvoiceextendedtax9\".\"impuesto\" = '002') AND (\"eninvoiceextendedtax9\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoiceextendedtax9\".\"tipofactor\" = 'Tasa') AND ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax9\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax9\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax9\".\"invoiceid\" IS NULL)");
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
RL_948a214f011367826beec566f5df17e6 outParamList = new RL_948a214f011367826beec566f5df17e6();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_948a214f011367826beec566f5df17e6 _tmp = new RL_948a214f011367826beec566f5df17e6();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_948a214f011367826beec566f5df17e6)_tmp;
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


    public class lcvGetData : VarsBag {
public RL_b41a8c83e4b5ec52d4ddabd5de41d62b queryResGetItemsByInvoiceId_outParamList = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
public long queryResGetItemsByInvoiceId_outParamCount = 0L;

public RL_b41a8c83e4b5ec52d4ddabd5de41d62b resListFilter_outParamFilteredList = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();

public lcvGetData() {
}
}
public class lcoGetData : VarsBag {
public bool outParamIsAnticipoWithInv = false;

public bool outParamIsLastLevel = false;

public lcoGetData() {
}
}
/// <summary>
/// Action <code>GetData</code> that represents the Service Studio action <code>GetData</code> <p>
///  Description: </p>
/// </summary>
public async Task<(bool,bool)> DataActionGetData(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsAnticipoWithInv = default;
bool outParamIsLastLevel = default;
lcoGetData result = new lcoGetData();
lcvGetData localVars = new lcvGetData();
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetData", "c0a94230-174c-428d-9ae8-427a145128a7"))
using (activitySource.CreateScreenDataActionActivity("Wb_i_InvoiceAccounting_Old", "GetData")){
// Query datasetGetItemsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetItemsByInvoiceId_maxRecords = 1;
if (datasetGetItemsByInvoiceId_maxRecords < 1) datasetGetItemsByInvoiceId_maxRecords = 1;
int datasetGetItemsByInvoiceId_startIndex = 0;(localVars.queryResGetItemsByInvoiceId_outParamList,localVars.queryResGetItemsByInvoiceId_outParamCount) = await FuncDataActionGetData.datasetGetItemsByInvoiceId(requestContext,datasetGetItemsByInvoiceId_maxRecords,datasetGetItemsByInvoiceId_startIndex,IterationMultiplicity.Multiple,inParami_InvoiceId,cancellationToken);

// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_b41a8c83e4b5ec52d4ddabd5de41d62b)await  localVars.queryResGetItemsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceExtendedItem.ssProductNumber=="84111506"), cancellationToken)));

// IsAnticipoWithInv = notListFilter.FilteredList.Empty and GetItemsByInvoiceId.List.Length = ListFilter.FilteredList.Length and GetItemsByInvoiceId.List.Current.InvoiceExtended.TipoComprobante = "I"
result.outParamIsAnticipoWithInv=(((!localVars.resListFilter_outParamFilteredList.Empty)&&(localVars.queryResGetItemsByInvoiceId_outParamList.Length==localVars.resListFilter_outParamFilteredList.Length))&&(localVars.queryResGetItemsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtended.ssTipoComprobante=="I"));

// IsLastLevel = False
result.outParamIsLastLevel=false;
} //close CreateActionActivity using block
} // try

finally {
outParamIsAnticipoWithInv = result.outParamIsAnticipoWithInv;
outParamIsLastLevel = result.outParamIsLastLevel;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsAnticipoWithInv,outParamIsLastLevel);
}
public class lcvGetInvoiceAccounting : VarsBag {
public RL_ab678aaff30585e5160f5c8982d816c7 queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList = new RL_ab678aaff30585e5160f5c8982d816c7();
public long queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamCount = 0L;

public RL_cc406982da8c42dd9f44909f6be7c1b9 queryResGetInvoiceAccountingByInvoiceId_outParamList = new RL_cc406982da8c42dd9f44909f6be7c1b9();
public long queryResGetInvoiceAccountingByInvoiceId_outParamCount = 0L;

public lcvGetInvoiceAccounting() {
}
}
public class lcoGetInvoiceAccounting : VarsBag {
public RL_c31399d0d7c776731653a069ba32283a outParamo_List = new RL_c31399d0d7c776731653a069ba32283a();

public long outParamo_InvoiceAccountingId = 0L;

public lcoGetInvoiceAccounting() {
}
}
/// <summary>
/// Action <code>GetInvoiceAccounting</code> that represents the Service Studio action
///  <code>GetInvoiceAccounting</code> <p> Description: Query to fetch invoice accoutning services an
/// d cost centers.</p>
/// </summary>
public async Task<(RL_c31399d0d7c776731653a069ba32283a,long)> DataActionGetInvoiceAccounting(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_c31399d0d7c776731653a069ba32283a outParamo_List = default;
long outParamo_InvoiceAccountingId = default;
lcoGetInvoiceAccounting result = new lcoGetInvoiceAccounting();
lcvGetInvoiceAccounting localVars = new lcvGetInvoiceAccounting();
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoiceAccounting", "d17a060c-f041-4bdb-babe-1a189f6b682e"))
using (activitySource.CreateScreenDataActionActivity("Wb_i_InvoiceAccounting_Old", "GetInvoiceAccounting")){
// Query datasetGetInvoiceAccountingByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingByInvoiceId_maxRecords = 1;
if (datasetGetInvoiceAccountingByInvoiceId_maxRecords < 1) datasetGetInvoiceAccountingByInvoiceId_maxRecords = 1;
int datasetGetInvoiceAccountingByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList,localVars.queryResGetInvoiceAccountingByInvoiceId_outParamCount) = await FuncDataActionGetInvoiceAccounting.datasetGetInvoiceAccountingByInvoiceId(requestContext,datasetGetInvoiceAccountingByInvoiceId_maxRecords,datasetGetInvoiceAccountingByInvoiceId_startIndex,IterationMultiplicity.Never,inParami_InvoiceId,cancellationToken);

// ListAppendAccounting
await ExtendedActions.ListAppend(requestContext,result.outParamo_List,new ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure(){ ssHideServicesFields = true, ssInvoiceAccounting = localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting, ssIVAIndicator = localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENTaxIndicator.ssExternalId, ssPaymentMethod = localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENPaymentMethods.ssDescription, ssPaymentTerm = localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENPaymentTerms.ssDescription, ssBuyDocNumber = localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssBuyDocNumber, ssBuyDocPosition = localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssBuyDocPosition },cancellationToken);

// Query datasetGetInvoiceAccountingServicesByInvoiceAccounting
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords = 99999;
if (datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords < 1) datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords = 1;
int datasetGetInvoiceAccountingServicesByInvoiceAccounting_startIndex = 0;(localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList,localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamCount) = await FuncDataActionGetInvoiceAccounting.datasetGetInvoiceAccountingServicesByInvoiceAccounting(requestContext,datasetGetInvoiceAccountingServicesByInvoiceAccounting_maxRecords,datasetGetInvoiceAccountingServicesByInvoiceAccounting_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssId,cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_List,(await RL_c31399d0d7c776731653a069ba32283a.ConvertAsync(localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList, new RL_c31399d0d7c776731653a069ba32283a(), async (RC_ca28323a4fc03670541dd65eaae03cf2 source, ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure target, CancellationToken cancellationToken) => {
target.ssAccountingAccounts_ServiceType = source.ssENAccountingAccounts_ServiceType.ssDescription;
target.ssCostCenterSAP = source.ssENCostCenterSAP.ssDescripcion;
target.ssBeneficiaryCenterSAP = ("CeBe "+source.ssENCostCenterSAP.ssCeBe);
target.ssHideAccountingFields = true;
target.ssInvoiceAccounting.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssInvoiceAccountingServices = source.ssENInvoiceAccountingServices;
target.ssIVAIndicator = source.ssENTaxIndicator.ssExternalId;
target.ssBuyDocNumber = source.ssENInvoiceAccountingServices.ssBuyDocNumber;
target.ssBuyDocPosition = source.ssENInvoiceAccountingServices.ssBuyDocPosition;
return target;
}, cancellationToken)),cancellationToken);

// o_InvoiceAccountingId = GetInvoiceAccountingByInvoiceId.List.Current.InvoiceAccounting.Id
result.outParamo_InvoiceAccountingId=localVars.queryResGetInvoiceAccountingByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssId;
} //close CreateActionActivity using block
} // try

finally {
outParamo_List = result.outParamo_List;
outParamo_InvoiceAccountingId = result.outParamo_InvoiceAccountingId;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_List,outParamo_InvoiceAccountingId);
}


    public static class FuncDataActionGetData {

private static async Task<RC_53d17e5a9f6c0fdb10660d26c96f84cc> datasetGetItemsByInvoiceIdReadDbAsync(RC_53d17e5a9f6c0fdb10660d26c96f84cc rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceExtendedItem.Read( r, ref index);
return rec;
}
// Query Function "GetItemsByInvoiceId" v_m8NP0x20i5Cg2JhSRseg of Action "GetData"
public static async Task<(RL_b41a8c83e4b5ec52d4ddabd5de41d62b,long)> datasetGetItemsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItem_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetData.GetItemsByInvoiceId", "34bcf9bf-31fd-48db-b90a-0d8985246c7a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_i_InvoiceAccounting_Old.GetData.GetItemsByInvoiceId", "34bcf9bf-31fd-48db-b90a-0d8985246c7a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/DataActions.MEKpwEwXjUKa6EJ6FFEopw/NodesNotShownInESpaceTree.v_m8NP0x20i5Cg2JhSRseg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"eninvoiceextended30\".\"tipocomprobante\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"eninvoiceextendeditem8\".\"productnumber\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26");
fromBuilder.Append(" FROM ({InvoiceExtended} \"eninvoiceextended30\" Inner JOIN {InvoiceExtendedItem} \"eninvoiceextendeditem8\" ON (\"eninvoiceextended30\".\"id\" = \"eninvoiceextendeditem8\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItem_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem8\".\"invoiceid\" = @qpinInvoiceExtendedItem_InvoiceId) AND (\"eninvoiceextendeditem8\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItem_InvoiceId", DbType.Int64, qpinInvoiceExtendedItem_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem8\".\"invoiceid\" IS NULL)");
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
RL_b41a8c83e4b5ec52d4ddabd5de41d62b outParamList = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetItemsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetData.GetItemsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b41a8c83e4b5ec52d4ddabd5de41d62b _tmp = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
_tmp.AlternateReadDbMethodAsync = datasetGetItemsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetData.GetItemsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b41a8c83e4b5ec52d4ddabd5de41d62b)_tmp;
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
public static class FuncDataActionGetInvoiceAccounting {

private static async Task<RC_ca28323a4fc03670541dd65eaae03cf2> datasetGetInvoiceAccountingServicesByInvoiceAccountingReadDbAsync(RC_ca28323a4fc03670541dd65eaae03cf2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENInvoiceAccountingServices.Read( r, ref index);
rec.ssENTaxIndicator.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingServicesByInvoiceAccounting" SGfPEFHWmkqYBjZ5vQ5dyg of Action "GetInvoiceAccounting"
public static async Task<(RL_ab678aaff30585e5160f5c8982d816c7,long)> datasetGetInvoiceAccountingServicesByInvoiceAccounting(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingServices_InvoiceAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting", "10cf6748-d651-4a9a-9806-3679bd0e5dca");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting", "10cf6748-d651-4a9a-9806-3679bd0e5dca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/DataActions.DAZ60UHw20u6vhoYn2toLg/NodesNotShownInESpaceTree.SGfPEFHWmkqYBjZ5vQ5dyg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enaccountingaccounts_servicetype7\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"encostcentersap10\".\"cebe\" o15, NULL o16, \"encostcentersap10\".\"descripcion\" o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"eninvoiceaccountingservices7\".\"id\" o33, \"eninvoiceaccountingservices7\".\"invoiceaccountingid\" o34, \"eninvoiceaccountingservices7\".\"servicetypeid\" o35, \"eninvoiceaccountingservices7\".\"account\" o36, \"eninvoiceaccountingservices7\".\"costcenterid\" o37, \"eninvoiceaccountingservices7\".\"cebecostcenterid\" o38, trim_scale(\"eninvoiceaccountingservices7\".\"amount\"::numeric) o39, \"eninvoiceaccountingservices7\".\"iva_old\" o40, \"eninvoiceaccountingservices7\".\"ivaindicatorid\" o41, \"eninvoiceaccountingservices7\".\"buydocnumber\" o42, \"eninvoiceaccountingservices7\".\"buydocposition\" o43, \"eninvoiceaccountingservices7\".\"freetext\" o44, \"eninvoiceaccountingservices7\".\"division\" o45, \"eninvoiceaccountingservices7\".\"icme\" o46, NULL o47, NULL o48, \"entaxindicator8\".\"externalid\" o49, NULL o50, NULL o51, NULL o52, NULL o53");
fromBuilder.Append(" FROM ((({InvoiceAccountingServices} \"eninvoiceaccountingservices7\" Left JOIN {CostCenterSAP} \"encostcentersap10\" ON (\"eninvoiceaccountingservices7\".\"costcenterid\" = \"encostcentersap10\".\"id\"))  Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype7\" ON (\"eninvoiceaccountingservices7\".\"servicetypeid\" = \"enaccountingaccounts_servicetype7\".\"id\"))  Left JOIN {TaxIndicator} \"entaxindicator8\" ON (\"eninvoiceaccountingservices7\".\"ivaindicatorid\" = \"entaxindicator8\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingServices_InvoiceAccountingId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingservices7\".\"invoiceaccountingid\" = @qpinInvoiceAccountingServices_InvoiceAccountingId) AND (\"eninvoiceaccountingservices7\".\"invoiceaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingServices_InvoiceAccountingId", DbType.Int64, qpinInvoiceAccountingServices_InvoiceAccountingId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingservices7\".\"invoiceaccountingid\" IS NULL)");
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
RL_ab678aaff30585e5160f5c8982d816c7 outParamList = new RL_ab678aaff30585e5160f5c8982d816c7();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingServicesByInvoiceAccountingReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ab678aaff30585e5160f5c8982d816c7 _tmp = new RL_ab678aaff30585e5160f5c8982d816c7();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingServicesByInvoiceAccountingReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ab678aaff30585e5160f5c8982d816c7)_tmp;
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

private static async Task<RC_f925a49e2decb9ca9ea463dccae74847> datasetGetInvoiceAccountingByInvoiceIdReadDbAsync(RC_f925a49e2decb9ca9ea463dccae74847 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENPaymentMethods.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENTaxIndicator.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingByInvoiceId" oPLeIVWvNUCNRU6aRxZR+A of Action "GetInvoiceAccounting"
public static async Task<(RL_cc406982da8c42dd9f44909f6be7c1b9,long)> datasetGetInvoiceAccountingByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccounting_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId", "21def2a0-af55-4035-8d45-4e9a471651f8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId", "21def2a0-af55-4035-8d45-4e9a471651f8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.eufsBIYK90igcaGuHvlDeA/DataActions.DAZ60UHw20u6vhoYn2toLg/NodesNotShownInESpaceTree.oPLeIVWvNUCNRU6aRxZR+A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccounting29\".\"id\" o0, \"eninvoiceaccounting29\".\"invoiceid\" o1, \"eninvoiceaccounting29\".\"suppliernumber\" o2, \"eninvoiceaccounting29\".\"servicetypeid\" o3, \"eninvoiceaccounting29\".\"freetext\" o4, \"eninvoiceaccounting29\".\"division\" o5, trim_scale(\"eninvoiceaccounting29\".\"ivaamount\"::numeric) o6, \"eninvoiceaccounting29\".\"iva_old\" o7, \"eninvoiceaccounting29\".\"ivaindicatorid\" o8, trim_scale(\"eninvoiceaccounting29\".\"totalamount\"::numeric) o9, \"eninvoiceaccounting29\".\"paymentmethodid\" o10, \"eninvoiceaccounting29\".\"paymenttermsid\" o11, \"eninvoiceaccounting29\".\"icmeindicator\" o12, \"eninvoiceaccounting29\".\"createdby\" o13, \"eninvoiceaccounting29\".\"createdon\" o14, \"eninvoiceaccounting29\".\"submissionby\" o15, \"eninvoiceaccounting29\".\"submissionon\" o16, \"eninvoiceaccounting29\".\"servicecalledby\" o17, \"eninvoiceaccounting29\".\"servicecalledon\" o18, \"eninvoiceaccounting29\".\"buydocnumber\" o19, \"eninvoiceaccounting29\".\"buydocposition\" o20, NULL o21, \"enpaymentmethods7\".\"description\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"enpaymentterms18\".\"description\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"entaxindicator9\".\"externalid\" o43, NULL o44, NULL o45, NULL o46, NULL o47");
fromBuilder.Append(" FROM ((({InvoiceAccounting} \"eninvoiceaccounting29\" Left JOIN {PaymentMethods} \"enpaymentmethods7\" ON (\"eninvoiceaccounting29\".\"paymentmethodid\" = \"enpaymentmethods7\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms18\" ON (\"eninvoiceaccounting29\".\"paymenttermsid\" = \"enpaymentterms18\".\"id\"))  Left JOIN {TaxIndicator} \"entaxindicator9\" ON (\"eninvoiceaccounting29\".\"ivaindicatorid\" = \"entaxindicator9\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccounting_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting29\".\"invoiceid\" = @qpinInvoiceAccounting_InvoiceId) AND (\"eninvoiceaccounting29\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccounting_InvoiceId", DbType.Int64, qpinInvoiceAccounting_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting29\".\"invoiceid\" IS NULL)");
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
RL_cc406982da8c42dd9f44909f6be7c1b9 outParamList = new RL_cc406982da8c42dd9f44909f6be7c1b9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cc406982da8c42dd9f44909f6be7c1b9 _tmp = new RL_cc406982da8c42dd9f44909f6be7c1b9();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting_Old.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cc406982da8c42dd9f44909f6be7c1b9)_tmp;
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
