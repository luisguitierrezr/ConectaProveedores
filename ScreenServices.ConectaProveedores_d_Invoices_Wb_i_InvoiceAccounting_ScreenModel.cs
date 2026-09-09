using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel).Namespace);

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
public AggregateRecord<RL_9404dc36b913809894c7e4e44e8e1dd8> ScreenDataSetGetInvoiceRetentionsByInvoiceId;
public AggregateRecord<RL_948a214f011367826beec566f5df17e6> ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId;
public AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms;
public AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> ScreenDataSetGetInvoiceApproval;
public AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods;
public AggregateRecord<RL_a675a81d4063c2bba451ee57edc49e99> ScreenDataSetGetInvoiceExtendedById;
public AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public AggregateRecord<RL_bf188616de0f0f2f6ca06ba5dba27490> ScreenDataSetGetTaxIndicators;
public AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
public AggregateRecord<RL_ccf70f600f06def33a14ca10a1120a68> ScreenDataSetGetInvoiceAccountingsByInvoiceId;
public AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> ScreenDataSetGetAccountingAccountsServiceTypes;
public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Model varLcGetData;
public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Model varLcGetInvoiceAccounting;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel(long inParami_InvoiceId, long inParami_RequisitionId, bool inParamIsActiveUser, bool inParamIsCorp, string inParamSupplierNumber, decimal varLcl_Iva, bool varLcl_ShowImportPopup, bool varLcl_ShowApprovalInvoice, bool varLcl_ShowCancelInvoice, bool varLcl_ShowModifyPopup, bool varLcl_IsApproval, bool varLcl_IsImport, RL_0704e14bc1b3305d76f59d709913c287 varLcl_InvoiceAccountingEntries, AggregateRecord<RL_9404dc36b913809894c7e4e44e8e1dd8> ScreenDataSetGetInvoiceRetentionsByInvoiceId, AggregateRecord<RL_948a214f011367826beec566f5df17e6> ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId, AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms, AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> ScreenDataSetGetInvoiceApproval, AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods, AggregateRecord<RL_a675a81d4063c2bba451ee57edc49e99> ScreenDataSetGetInvoiceExtendedById, AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, AggregateRecord<RL_bf188616de0f0f2f6ca06ba5dba27490> ScreenDataSetGetTaxIndicators, AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId, AggregateRecord<RL_ccf70f600f06def33a14ca10a1120a68> ScreenDataSetGetInvoiceAccountingsByInvoiceId, AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> ScreenDataSetGetAccountingAccountsServiceTypes, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetData_Model varLcGetData, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Model varLcGetInvoiceAccounting, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_RequisitionId", "IsActiveUser", "IsCorp", "SupplierNumber", "l_Iva", "l_ShowImportPopup", "l_ShowApprovalInvoice", "l_ShowCancelInvoice", "l_ShowModifyPopup", "l_IsApproval", "l_IsImport", "l_InvoiceAccountingEntries", "GetInvoiceRetentionsByInvoiceId", "GetInvoiceExtendedTaxsByInvoiceId", "GetPaymentTerms", "GetInvoiceApproval", "GetPaymentMethods", "GetInvoiceExtendedById", "GetCostCenters", "GetRegions", "GetTaxIndicators", "GetInvoiceExtendedMoreChargesByInvoiceId", "GetInvoiceAccountingsByInvoiceId", "GetAccountingAccountsServiceTypes", "GetData", "GetSettings", "GetInvoiceAccounting", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_RequisitionId", "inParamIsActiveUser", "inParamIsCorp", "inParamSupplierNumber", "varLcl_Iva", "varLcl_ShowImportPopup", "varLcl_ShowApprovalInvoice", "varLcl_ShowCancelInvoice", "varLcl_ShowModifyPopup", "varLcl_IsApproval", "varLcl_IsImport", "varLcl_InvoiceAccountingEntries", "ScreenDataSetGetInvoiceRetentionsByInvoiceId", "ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId", "ScreenDataSetGetPaymentTerms", "ScreenDataSetGetInvoiceApproval", "ScreenDataSetGetPaymentMethods", "ScreenDataSetGetInvoiceExtendedById", "ScreenDataSetGetCostCenters", "ScreenDataSetGetRegions", "ScreenDataSetGetTaxIndicators", "ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId", "ScreenDataSetGetInvoiceAccountingsByInvoiceId", "ScreenDataSetGetAccountingAccountsServiceTypes", "varLcGetData", "varLcGetSettings", "varLcGetInvoiceAccounting", "clientVariables"});
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
this.ScreenDataSetGetInvoiceRetentionsByInvoiceId = ScreenDataSetGetInvoiceRetentionsByInvoiceId;
this.ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId = ScreenDataSetGetInvoiceExtendedTaxsByInvoiceId;
this.ScreenDataSetGetPaymentTerms = ScreenDataSetGetPaymentTerms;
this.ScreenDataSetGetInvoiceApproval = ScreenDataSetGetInvoiceApproval;
this.ScreenDataSetGetPaymentMethods = ScreenDataSetGetPaymentMethods;
this.ScreenDataSetGetInvoiceExtendedById = ScreenDataSetGetInvoiceExtendedById;
this.ScreenDataSetGetCostCenters = ScreenDataSetGetCostCenters;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.ScreenDataSetGetTaxIndicators = ScreenDataSetGetTaxIndicators;
this.ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId = ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
this.ScreenDataSetGetInvoiceAccountingsByInvoiceId = ScreenDataSetGetInvoiceAccountingsByInvoiceId;
this.ScreenDataSetGetAccountingAccountsServiceTypes = ScreenDataSetGetAccountingAccountsServiceTypes;
this.varLcGetData = varLcGetData;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetInvoiceAccounting = varLcGetInvoiceAccounting;
this.clientVariables = clientVariables;
}



    
// Query Function "GetInvoiceRetentionsByInvoiceId" i+cLCepNukSjwzgz1cBYfw of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceRetentionsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceRetentionsByInvoiceId", "090be78b-4dea-44ba-a3c3-3833d5c0587f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceRetentionsByInvoiceId");
// Query Iterations: Multiple
// Refresh Query LBDAWYmu80SVaRtPrjWQOA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.i+cLCepNukSjwzgz1cBYfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedtax10\".\"id\" o0, \"eninvoiceextendedtax10\".\"invoiceid\" o1, \"eninvoiceextendedtax10\".\"invoicetaxtypeid\" o2, \"eninvoiceextendedtax10\".\"impuesto\" o3, trim_scale(\"eninvoiceextendedtax10\".\"base\"::numeric) o4, trim_scale(\"eninvoiceextendedtax10\".\"tasaocuota\"::numeric) o5, trim_scale(\"eninvoiceextendedtax10\".\"importe\"::numeric) o6, \"eninvoiceextendedtax10\".\"tipofactor\" o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax10\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax10\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax10\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax10\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedtax10\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId);
whereBuilder.Append(") AND ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax10\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax10\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax10\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceExtendedTaxsByInvoiceId" iCdpIMXISEmh9tgLBPRqQA of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_948a214f011367826beec566f5df17e6,long)> datasetGetInvoiceExtendedTaxsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedTaxsByInvoiceId", "20692788-c8c5-4948-a1f6-d80b04f46a40");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedTaxsByInvoiceId");
// Query Iterations: Never
// Refresh Query zHZF0aUNXk+WSmipE8ScXA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.iCdpIMXISEmh9tgLBPRqQA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"eninvoiceextendedtax11\".\"importe\") \"importesum\"");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax11\"");
whereBuilder.Append(" WHERE (\"eninvoiceextendedtax11\".\"impuesto\" = '002') AND (\"eninvoiceextendedtax11\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoiceextendedtax11\".\"tipofactor\" = 'Tasa') AND ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax11\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax11\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax11\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentTerms" Ag9SJnVzjUKCSFdoUt8_TQ of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetPaymentTerms", "26520f02-7375-428d-8248-576852df3f4d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetPaymentTerms");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.Ag9SJnVzjUKCSFdoUt8_TQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms19\".\"id\" o0, \"enpaymentterms19\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms19\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetPaymentTerms.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetPaymentTerms.List", cancellationToken: cancellationToken);
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

private static async Task<RC_eac76b624d2264108f6fbeb95d9d43ba> datasetGetInvoiceApprovalReadDbAsync(RC_eac76b624d2264108f6fbeb95d9d43ba rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApproval" XKPfO8Qcv0eFSCWfH4ZEHQ of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_d62c1f17f6aae94386bfdb54075ff733,long)> datasetGetInvoiceApproval(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpusGetUserId,long qpsuRequisition_SupplierId,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceApproval", "3bdfa35c-1cc4-47bf-8548-259f1f86441d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceApproval");
// Query Iterations: Never
// Refresh Query 7ttFlMOh8UOH4I4KvyeLYA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.XKPfO8Qcv0eFSCWfH4ZEHQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"eninvoice119\".\"invoicestatusid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceapprovallevel34\".\"id\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, \"enrequisition98\".\"iscontractpending\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, \"ensupplier85\".\"pais\" o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice119\" Left JOIN {InvoiceApproval} \"eninvoiceapproval34\" ON (\"eninvoice119\".\"id\" = \"eninvoiceapproval34\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel34\" ON (\"eninvoiceapproval34\".\"id\" = \"eninvoiceapprovallevel34\".\"invoiceapprovalid\"))  Left JOIN {Requisition} \"enrequisition98\" ON (\"eninvoice119\".\"requisitionid\" = \"enrequisition98\".\"id\"))  Left JOIN {Supplier} \"ensupplier85\" ON (\"enrequisition98\".\"supplierid\" = \"ensupplier85\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice119\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice119\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice119\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition98\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition98\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition98\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" OR ((\"eninvoiceapprovallevel34\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel34\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel34\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel34\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel34\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel34\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel34\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel34\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel34\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel34\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel34\".\"requesttomodifyby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel34\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel34\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel34\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")))");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel34\".\"levelnumber\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceApproval.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceApproval.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentMethods" wPfOU6dDi0K7EgRKxFscTw of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_0dcbcba642ca8b22e87f690d4de9d077,long)> datasetGetPaymentMethods(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetPaymentMethods", "53cef7c0-43a7-428b-bb12-044ac45b1c4f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetPaymentMethods");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.wPfOU6dDi0K7EgRKxFscTw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentmethods8\".\"id\" o0, \"enpaymentmethods8\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {PaymentMethods} \"enpaymentmethods8\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetPaymentMethods.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetPaymentMethods.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceExtendedById" 92QJZopDX0qLmqhHXKUpsg of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_a675a81d4063c2bba451ee57edc49e99,long)> datasetGetInvoiceExtendedById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedById", "660964f7-438a-4a5f-8b9a-a8475ca529b2");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedById");
// Query Iterations: Never
// Refresh Query ktFAolvRckG4FII+48DORg Iterations: Never
// Refresh Query mIIdZ+unt0y_Gy7saZu7dw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.92QJZopDX0qLmqhHXKUpsg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextended31\".\"id\" o0, \"eninvoiceextended31\".\"version\" o1, \"eninvoiceextended31\".\"folio\" o2, \"eninvoiceextended31\".\"serie\" o3, \"eninvoiceextended31\".\"fechaemision\" o4, \"eninvoiceextended31\".\"formapago\" o5, \"eninvoiceextended31\".\"metodopago\" o6, \"eninvoiceextended31\".\"lugarexpedicion\" o7, trim_scale(\"eninvoiceextended31\".\"subtotal\"::numeric) o8, trim_scale(\"eninvoiceextended31\".\"descuento\"::numeric) o9, trim_scale(\"eninvoiceextended31\".\"totaliva\"::numeric) o10, trim_scale(\"eninvoiceextended31\".\"retenciones\"::numeric) o11, trim_scale(\"eninvoiceextended31\".\"total\"::numeric) o12, \"eninvoiceextended31\".\"tipocomprobante\" o13, \"eninvoiceextended31\".\"moneda\" o14, trim_scale(\"eninvoiceextended31\".\"tipocambio\"::numeric) o15, \"eninvoiceextended31\".\"usocfdi\" o16, \"eninvoiceextended31\".\"exportacion\" o17, \"eninvoiceextended31\".\"uuid\" o18");
fromBuilder.Append(" FROM {InvoiceExtended} \"eninvoiceextended31\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceextended31\".\"id\" = @qpinId) AND (\"eninvoiceextended31\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceextended31\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
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

// Query Function "GetCostCenters" 4qoTaHruA0OpNZhSVIMsrA of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_ec55ed22dae89075d036f3a863173164,long)> datasetGetCostCenters(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetCostCenters", "6813aae2-ee7a-4303-a935-985254832cac");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetCostCenters");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.4qoTaHruA0OpNZhSVIMsrA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encostcentersap11\".\"id\" o0, \"encostcentersap11\".\"regionid\" o1, \"encostcentersap11\".\"companyid\" o2, \"encostcentersap11\".\"soc_\" o3, \"encostcentersap11\".\"div_\" o4, \"encostcentersap11\".\"area\" o5, \"encostcentersap11\".\"ce_coste\" o6, \"encostcentersap11\".\"cebe\" o7, \"encostcentersap11\".\"denominacion\" o8, \"encostcentersap11\".\"descripcion\" o9, \"encostcentersap11\".\"responsable\" o10, \"encostcentersap11\".\"ceco\" o11, \"encostcentersap11\".\"costesprim_reales_ind_debloq\" o12, \"encostcentersap11\".\"costessecund_reales_ind_debl\" o13, \"encostcentersap11\".\"ingresosreales_ind_debloqueo\" o14, \"encostcentersap11\".\"actualiz_comprom__ind_debloq\" o15, \"encostcentersap11\".\"costesprimariosplan_ind_debl\" o16, \"encostcentersap11\".\"costessecund_plan_ind_debloq\" o17, \"encostcentersap11\".\"ingresosplan_ind_debloqueo_\" o18, \"encostcentersap11\".\"autor\" o19, \"encostcentersap11\".\"createdon\" o20, \"encostcentersap11\".\"createdby\" o21, \"encostcentersap11\".\"updatedon\" o22, \"encostcentersap11\".\"updatedby\" o23, \"encostcentersap11\".\"isactive\" o24");
fromBuilder.Append(" FROM {CostCenterSAP} \"encostcentersap11\"");
whereBuilder.Append(" WHERE (\"encostcentersap11\".\"isactive\" = 1)");
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
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetCostCenters.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetCostCenters.List", cancellationToken: cancellationToken);
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

// Query Function "GetRegions" 76l+i735_kGPyqjorWiXiQ of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetRegions", "8b7ea9ef-f9bd-41fe-8fca-a8e8ad689789");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.76l+i735_kGPyqjorWiXiQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enregion112\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion112\"");
whereBuilder.Append(" WHERE (\"enregion112\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enregion112\".\"code\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetRegions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetRegions.List", cancellationToken: cancellationToken);
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

// Query Function "GetTaxIndicators" 7JqP0FctbEC9rHgNo2HKSw of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_bf188616de0f0f2f6ca06ba5dba27490,long)> datasetGetTaxIndicators(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetTaxIndicators", "d08f9aec-2d57-406c-bdac-780da361ca4b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetTaxIndicators");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.7JqP0FctbEC9rHgNo2HKSw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"entaxindicator10\".\"id\" o0, NULL o1, \"entaxindicator10\".\"externalid\" o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {TaxIndicator} \"entaxindicator10\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetTaxIndicators.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetTaxIndicators.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceExtendedMoreChargesByInvoiceId" vr2N1fqIBE2E2JsywIoOMg of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_ef088826c46241557fb82e7c7f21d334,long)> datasetGetInvoiceExtendedMoreChargesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedMoreChargesByInvoiceId", "d58dbdbe-88fa-4d04-84d8-9b32c08a0e32");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedMoreChargesByInvoiceId");
// Query Iterations: Multiple
// Refresh Query nFQd2lj2oEC8lHMJy23MXQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.vr2N1fqIBE2E2JsywIoOMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedmorecharges5\".\"id\" o0, \"eninvoiceextendedmorecharges5\".\"invoiceid\" o1, \"eninvoiceextendedmorecharges5\".\"nombreconcepto\" o2, trim_scale(\"eninvoiceextendedmorecharges5\".\"value\"::numeric) o3");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges5\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges5\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges5\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges5\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceAccountingsByInvoiceId" QlPy4_U+FUuHPEtgKj2Eyw of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_ccf70f600f06def33a14ca10a1120a68,long)> datasetGetInvoiceAccountingsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccountingsByInvoiceId", "e3f25342-3ef5-4b15-873c-4b602a3d84cb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccountingsByInvoiceId");
// Query Iterations: Never
// Refresh Query DslSxXPrlkS5xKlyGcvydQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.QlPy4_U+FUuHPEtgKj2Eyw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, trim_scale(\"eninvoiceaccounting32\".\"totalamount\"::numeric) o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20");
fromBuilder.Append(" FROM {InvoiceAccounting} \"eninvoiceaccounting32\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting32\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceaccounting32\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting32\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetAccountingAccountsServiceTypes" e1F45ki7N0OpBsgFNi0Hvg of Action "Wb_i_InvoiceAccounting"
public static async Task<(RL_60b4efe2937800b54618ed04c4847a05,long)> datasetGetAccountingAccountsServiceTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetAccountingAccountsServiceTypes", "e678517b-bb48-4337-a906-c805362d07be");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_i_InvoiceAccounting","d_Invoices.Wb_i_InvoiceAccounting.GetAccountingAccountsServiceTypes");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/ScreenDataSets.e1F45ki7N0OpBsgFNi0Hvg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingaccounts_servicetype8\".\"cc\" o1, \"enaccountingaccounts_servicetype8\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype8\"");
whereBuilder.Append(" WHERE (\"enaccountingaccounts_servicetype8\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enaccountingaccounts_servicetype8\".\"cc\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetAccountingAccountsServiceTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetAccountingAccountsServiceTypes.List", cancellationToken: cancellationToken);
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


    public class lcvGetData : VarsBag {
public RL_b41a8c83e4b5ec52d4ddabd5de41d62b resListFilter_outParamFilteredList = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();

public RL_b41a8c83e4b5ec52d4ddabd5de41d62b queryResGetItemsByInvoiceId_outParamList = new RL_b41a8c83e4b5ec52d4ddabd5de41d62b();
public long queryResGetItemsByInvoiceId_outParamCount = 0L;

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
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetData", "1385bf50-7587-49de-b1b3-a69e8909b039"))
using (activitySource.CreateScreenDataActionActivity("Wb_i_InvoiceAccounting", "GetData")){
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
public class lcoGetSettings : VarsBag {
public bool outParamIsActiveDEV_CostCentersNonActive = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsActiveDEV_CostCentersNonActive = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "86ff2445-6fc2-46c9-81ea-c1fc6c6d0fbb"))
using (activitySource.CreateScreenDataActionActivity("Wb_i_InvoiceAccounting", "GetSettings")){
// IsActiveDEV_CostCentersNonActive = IsActiveDEV_CostCentersNonActive
result.outParamIsActiveDEV_CostCentersNonActive=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_CostCentersNonActive])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsActiveDEV_CostCentersNonActive = result.outParamIsActiveDEV_CostCentersNonActive;
} // inner-finally
RETURN_STATEMENT:
return outParamIsActiveDEV_CostCentersNonActive;
}
public class lcvGetInvoiceAccounting : VarsBag {
public RL_d55212981ba3c49c0fb66324f6a1411a queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList = new RL_d55212981ba3c49c0fb66324f6a1411a();
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
ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetInvoiceAccounting", "90914a1f-f0d1-4f98-8388-85d007cb3615"))
using (activitySource.CreateScreenDataActionActivity("Wb_i_InvoiceAccounting", "GetInvoiceAccounting")){
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
await ExtendedActions.ListAppendAll(requestContext,result.outParamo_List,(await RL_c31399d0d7c776731653a069ba32283a.ConvertAsync(localVars.queryResGetInvoiceAccountingServicesByInvoiceAccounting_outParamList, new RL_c31399d0d7c776731653a069ba32283a(), async (RC_3a3d5d4cc50f8572263073b452541424 source, ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure target, CancellationToken cancellationToken) => {
target.ssAccountingAccounts_ServiceType = source.ssENAccountingAccounts_ServiceType.ssDescription;
target.ssCostCenterSAP = source.ssENCostCenterSAP.ssCe_coste;
target.ssBeneficiaryCenterSAP = source.ssENCeBeCostCenterSAP.ssCe_coste;
target.ssHideAccountingFields = true;
target.ssInvoiceAccounting.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());
target.ssInvoiceAccountingServices = source.ssENInvoiceAccountingServices;
target.ssCostCenter = source.ssENCostCenterSAP;
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
// Query Function "GetItemsByInvoiceId" 0fyi4h2t6ES7Pv_pq3TZJg of Action "GetData"
public static async Task<(RL_b41a8c83e4b5ec52d4ddabd5de41d62b,long)> datasetGetItemsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItem_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetData.GetItemsByInvoiceId", "e2a2fcd1-ad1d-44e8-bb3e-ffe9ab74d926");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_i_InvoiceAccounting.GetData.GetItemsByInvoiceId", "e2a2fcd1-ad1d-44e8-bb3e-ffe9ab74d926", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/DataActions.UL+FE4d13kmxs6aeiQmwOQ/NodesNotShownInESpaceTree.0fyi4h2t6ES7Pv_pq3TZJg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, \"eninvoiceextended32\".\"tipocomprobante\" o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"eninvoiceextendeditem9\".\"productnumber\" o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26");
fromBuilder.Append(" FROM ({InvoiceExtended} \"eninvoiceextended32\" Inner JOIN {InvoiceExtendedItem} \"eninvoiceextendeditem9\" ON (\"eninvoiceextended32\".\"id\" = \"eninvoiceextendeditem9\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItem_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem9\".\"invoiceid\" = @qpinInvoiceExtendedItem_InvoiceId) AND (\"eninvoiceextendeditem9\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItem_InvoiceId", DbType.Int64, qpinInvoiceExtendedItem_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem9\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetData.GetItemsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetData.GetItemsByInvoiceId.List", cancellationToken: cancellationToken);
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
public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetInvoiceAccounting {

private static async Task<RC_3a3d5d4cc50f8572263073b452541424> datasetGetInvoiceAccountingServicesByInvoiceAccountingReadDbAsync(RC_3a3d5d4cc50f8572263073b452541424 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCeBeCostCenterSAP.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENInvoiceAccountingServices.Read( r, ref index);
rec.ssENTaxIndicator.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingServicesByInvoiceAccounting" YcAXAuPQYkuIRzGWh6utEA of Action "GetInvoiceAccounting"
public static async Task<(RL_d55212981ba3c49c0fb66324f6a1411a,long)> datasetGetInvoiceAccountingServicesByInvoiceAccounting(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingServices_InvoiceAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting", "0217c061-d0e3-4b62-8847-319687abad10");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting", "0217c061-d0e3-4b62-8847-319687abad10", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/DataActions.H0qRkNHwmE+DiIXQB8s2FQ/NodesNotShownInESpaceTree.YcAXAuPQYkuIRzGWh6utEA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enaccountingaccounts_servicetype9\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"encebecostcentersap2\".\"ce_coste\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, \"encostcentersap12\".\"id\" o33, \"encostcentersap12\".\"regionid\" o34, \"encostcentersap12\".\"companyid\" o35, \"encostcentersap12\".\"soc_\" o36, \"encostcentersap12\".\"div_\" o37, \"encostcentersap12\".\"area\" o38, \"encostcentersap12\".\"ce_coste\" o39, \"encostcentersap12\".\"cebe\" o40, \"encostcentersap12\".\"denominacion\" o41, \"encostcentersap12\".\"descripcion\" o42, \"encostcentersap12\".\"responsable\" o43, \"encostcentersap12\".\"ceco\" o44, \"encostcentersap12\".\"costesprim_reales_ind_debloq\" o45, \"encostcentersap12\".\"costessecund_reales_ind_debl\" o46, \"encostcentersap12\".\"ingresosreales_ind_debloqueo\" o47, \"encostcentersap12\".\"actualiz_comprom__ind_debloq\" o48, \"encostcentersap12\".\"costesprimariosplan_ind_debl\" o49, \"encostcentersap12\".\"costessecund_plan_ind_debloq\" o50, \"encostcentersap12\".\"ingresosplan_ind_debloqueo_\" o51, \"encostcentersap12\".\"autor\" o52, \"encostcentersap12\".\"createdon\" o53, \"encostcentersap12\".\"createdby\" o54, \"encostcentersap12\".\"updatedon\" o55, \"encostcentersap12\".\"updatedby\" o56, \"encostcentersap12\".\"isactive\" o57, \"eninvoiceaccountingservices8\".\"id\" o58, \"eninvoiceaccountingservices8\".\"invoiceaccountingid\" o59, \"eninvoiceaccountingservices8\".\"servicetypeid\" o60, \"eninvoiceaccountingservices8\".\"account\" o61, \"eninvoiceaccountingservices8\".\"costcenterid\" o62, \"eninvoiceaccountingservices8\".\"cebecostcenterid\" o63, trim_scale(\"eninvoiceaccountingservices8\".\"amount\"::numeric) o64, \"eninvoiceaccountingservices8\".\"iva_old\" o65, \"eninvoiceaccountingservices8\".\"ivaindicatorid\" o66, \"eninvoiceaccountingservices8\".\"buydocnumber\" o67, \"eninvoiceaccountingservices8\".\"buydocposition\" o68, \"eninvoiceaccountingservices8\".\"freetext\" o69, \"eninvoiceaccountingservices8\".\"division\" o70, \"eninvoiceaccountingservices8\".\"icme\" o71, NULL o72, NULL o73, \"entaxindicator11\".\"externalid\" o74, NULL o75, NULL o76, NULL o77, NULL o78");
fromBuilder.Append(" FROM (((({InvoiceAccountingServices} \"eninvoiceaccountingservices8\" Left JOIN {CostCenterSAP} \"encostcentersap12\" ON (\"eninvoiceaccountingservices8\".\"costcenterid\" = \"encostcentersap12\".\"id\"))  Left JOIN {CostCenterSAP} \"encebecostcentersap2\" ON (\"eninvoiceaccountingservices8\".\"cebecostcenterid\" = \"encebecostcentersap2\".\"id\"))  Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype9\" ON (\"eninvoiceaccountingservices8\".\"servicetypeid\" = \"enaccountingaccounts_servicetype9\".\"id\"))  Left JOIN {TaxIndicator} \"entaxindicator11\" ON (\"eninvoiceaccountingservices8\".\"ivaindicatorid\" = \"entaxindicator11\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingServices_InvoiceAccountingId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingservices8\".\"invoiceaccountingid\" = @qpinInvoiceAccountingServices_InvoiceAccountingId) AND (\"eninvoiceaccountingservices8\".\"invoiceaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingServices_InvoiceAccountingId", DbType.Int64, qpinInvoiceAccountingServices_InvoiceAccountingId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingservices8\".\"invoiceaccountingid\" IS NULL)");
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
RL_d55212981ba3c49c0fb66324f6a1411a outParamList = new RL_d55212981ba3c49c0fb66324f6a1411a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingServicesByInvoiceAccountingReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d55212981ba3c49c0fb66324f6a1411a _tmp = new RL_d55212981ba3c49c0fb66324f6a1411a();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingServicesByInvoiceAccountingReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingServicesByInvoiceAccounting.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d55212981ba3c49c0fb66324f6a1411a)_tmp;
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
// Query Function "GetInvoiceAccountingByInvoiceId" gb6Bfbk_xUeMwuRO8rIIlg of Action "GetInvoiceAccounting"
public static async Task<(RL_cc406982da8c42dd9f44909f6be7c1b9,long)> datasetGetInvoiceAccountingByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccounting_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId", "7d81be81-3fb9-47c5-8cc2-e44ef2b20896");
using var queryActivity = activitySource.CreateAggregateQueryActivity("d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId", "7d81be81-3fb9-47c5-8cc2-e44ef2b20896", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.0K7HM1qOFESNbk2hxYIDZw/DataActions.H0qRkNHwmE+DiIXQB8s2FQ/NodesNotShownInESpaceTree.gb6Bfbk_xUeMwuRO8rIIlg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccounting33\".\"id\" o0, \"eninvoiceaccounting33\".\"invoiceid\" o1, \"eninvoiceaccounting33\".\"suppliernumber\" o2, \"eninvoiceaccounting33\".\"servicetypeid\" o3, \"eninvoiceaccounting33\".\"freetext\" o4, \"eninvoiceaccounting33\".\"division\" o5, trim_scale(\"eninvoiceaccounting33\".\"ivaamount\"::numeric) o6, \"eninvoiceaccounting33\".\"iva_old\" o7, \"eninvoiceaccounting33\".\"ivaindicatorid\" o8, trim_scale(\"eninvoiceaccounting33\".\"totalamount\"::numeric) o9, \"eninvoiceaccounting33\".\"paymentmethodid\" o10, \"eninvoiceaccounting33\".\"paymenttermsid\" o11, \"eninvoiceaccounting33\".\"icmeindicator\" o12, \"eninvoiceaccounting33\".\"createdby\" o13, \"eninvoiceaccounting33\".\"createdon\" o14, \"eninvoiceaccounting33\".\"submissionby\" o15, \"eninvoiceaccounting33\".\"submissionon\" o16, \"eninvoiceaccounting33\".\"servicecalledby\" o17, \"eninvoiceaccounting33\".\"servicecalledon\" o18, \"eninvoiceaccounting33\".\"buydocnumber\" o19, \"eninvoiceaccounting33\".\"buydocposition\" o20, NULL o21, \"enpaymentmethods9\".\"description\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"enpaymentterms20\".\"description\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"entaxindicator12\".\"externalid\" o43, NULL o44, NULL o45, NULL o46, NULL o47");
fromBuilder.Append(" FROM ((({InvoiceAccounting} \"eninvoiceaccounting33\" Left JOIN {PaymentMethods} \"enpaymentmethods9\" ON (\"eninvoiceaccounting33\".\"paymentmethodid\" = \"enpaymentmethods9\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms20\" ON (\"eninvoiceaccounting33\".\"paymenttermsid\" = \"enpaymentterms20\".\"id\"))  Left JOIN {TaxIndicator} \"entaxindicator12\" ON (\"eninvoiceaccounting33\".\"ivaindicatorid\" = \"entaxindicator12\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccounting_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting33\".\"invoiceid\" = @qpinInvoiceAccounting_InvoiceId) AND (\"eninvoiceaccounting33\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccounting_InvoiceId", DbType.Int64, qpinInvoiceAccounting_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting33\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_i_InvoiceAccounting.GetInvoiceAccounting.GetInvoiceAccountingByInvoiceId.List", cancellationToken: cancellationToken);
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
