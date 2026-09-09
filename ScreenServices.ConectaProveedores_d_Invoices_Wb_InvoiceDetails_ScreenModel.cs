using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel).Namespace);

    public long inParami_InvoiceId;
public long inParami_RequisitionId;
public bool inParamIsActiveUser;
public bool varLcl_IsBusy;
public bool varLcl_ShowCancelPopup;
public bool varLcl_ShowModifyPopup;
public bool varLcl_ShowApproveInvoice;
public AggregateRecord<RL_84dada5f12004775b86c894b55ae9596> ScreenDataSetGetInvoiceExtendedMoreChargesTotal;
public AggregateRecord<RL_d07e089b14ae41d13cfd90c5313de016> ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId;
public AggregateRecord<RL_cc406982da8c42dd9f44909f6be7c1b9> ScreenDataSetGetInvoiceAccountingByInvoiceId;
public AggregateRecord<RL_ec81b8a47286cf2b9fe9bbf727e9ade3> ScreenDataSetGetInvoiceExtendedById;
public AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
public AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> ScreenDataSetGetInvoiceApproval;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel() {
}



    public ConectaProveedores_d_Invoices_Wb_InvoiceDetails_ScreenModel(long inParami_InvoiceId, long inParami_RequisitionId, bool inParamIsActiveUser, bool varLcl_IsBusy, bool varLcl_ShowCancelPopup, bool varLcl_ShowModifyPopup, bool varLcl_ShowApproveInvoice, AggregateRecord<RL_84dada5f12004775b86c894b55ae9596> ScreenDataSetGetInvoiceExtendedMoreChargesTotal, AggregateRecord<RL_d07e089b14ae41d13cfd90c5313de016> ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId, AggregateRecord<RL_cc406982da8c42dd9f44909f6be7c1b9> ScreenDataSetGetInvoiceAccountingByInvoiceId, AggregateRecord<RL_ec81b8a47286cf2b9fe9bbf727e9ade3> ScreenDataSetGetInvoiceExtendedById, AggregateRecord<RL_ef088826c46241557fb82e7c7f21d334> ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId, AggregateRecord<RL_d62c1f17f6aae94386bfdb54075ff733> ScreenDataSetGetInvoiceApproval, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_InvoiceId", "i_RequisitionId", "IsActiveUser", "l_IsBusy", "l_ShowCancelPopup", "l_ShowModifyPopup", "l_ShowApproveInvoice", "GetInvoiceExtendedMoreChargesTotal", "GetInvoiceExtendedRelationsByInvoiceId", "GetInvoiceAccountingByInvoiceId", "GetInvoiceExtendedById", "GetInvoiceExtendedMoreChargesByInvoiceId", "GetInvoiceApproval", "ClientVars"}, new string[] {"inParami_InvoiceId", "inParami_RequisitionId", "inParamIsActiveUser", "varLcl_IsBusy", "varLcl_ShowCancelPopup", "varLcl_ShowModifyPopup", "varLcl_ShowApproveInvoice", "ScreenDataSetGetInvoiceExtendedMoreChargesTotal", "ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId", "ScreenDataSetGetInvoiceAccountingByInvoiceId", "ScreenDataSetGetInvoiceExtendedById", "ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId", "ScreenDataSetGetInvoiceApproval", "clientVariables"});
this.inParami_InvoiceId = inParami_InvoiceId;
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParamIsActiveUser = inParamIsActiveUser;
this.varLcl_IsBusy = varLcl_IsBusy;
this.varLcl_ShowCancelPopup = varLcl_ShowCancelPopup;
this.varLcl_ShowModifyPopup = varLcl_ShowModifyPopup;
this.varLcl_ShowApproveInvoice = varLcl_ShowApproveInvoice;
this.ScreenDataSetGetInvoiceExtendedMoreChargesTotal = ScreenDataSetGetInvoiceExtendedMoreChargesTotal;
this.ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId = ScreenDataSetGetInvoiceExtendedRelationsByInvoiceId;
this.ScreenDataSetGetInvoiceAccountingByInvoiceId = ScreenDataSetGetInvoiceAccountingByInvoiceId;
this.ScreenDataSetGetInvoiceExtendedById = ScreenDataSetGetInvoiceExtendedById;
this.ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId = ScreenDataSetGetInvoiceExtendedMoreChargesByInvoiceId;
this.ScreenDataSetGetInvoiceApproval = ScreenDataSetGetInvoiceApproval;
this.clientVariables = clientVariables;
}



    
// Query Function "GetInvoiceExtendedMoreChargesTotal" ++gDlMhyiU2TSuk0IRkO3w of Action "Wb_InvoiceDetails"
public static async Task<(RL_84dada5f12004775b86c894b55ae9596,long)> datasetGetInvoiceExtendedMoreChargesTotal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesTotal", "9403e8fb-72c8-4d89-934a-e93421190edf");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetails","d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesTotal");
// Query Iterations: Never
// Refresh Query n4rwzslrE0KBBm8Rnh+GdQ Iterations: Never
// Refresh Query J3yA3S8DoEuCsNSm9A+hQg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.ZbtC51gEQEaOvgwcEuzYww/ScreenDataSets.++gDlMhyiU2TSuk0IRkO3w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"eninvoiceextendedmorecharges6\".\"value\") \"valuesum\"");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges6\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges6\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges6\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges6\".\"invoiceid\" IS NULL)");
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
RL_84dada5f12004775b86c894b55ae9596 outParamList = new RL_84dada5f12004775b86c894b55ae9596();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesTotal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_84dada5f12004775b86c894b55ae9596 _tmp = new RL_84dada5f12004775b86c894b55ae9596();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesTotal.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_84dada5f12004775b86c894b55ae9596)_tmp;
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

// Query Function "GetInvoiceExtendedRelationsByInvoiceId" ECB7z9Mh8k+rJ3Ej4sHppw of Action "Wb_InvoiceDetails"
public static async Task<(RL_d07e089b14ae41d13cfd90c5313de016,long)> datasetGetInvoiceExtendedRelationsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedRelationsByInvoiceId", "cf7b2010-21d3-4ff2-ab27-7123e2c1e9a7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetails","d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedRelationsByInvoiceId");
// Query Iterations: Multiple
// Refresh Query zvtz3rjrdUGKN5aqBo+wXQ Iterations: Multiple
// Refresh Query BKL+vwbk2028VKqnP3jaFA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.ZbtC51gEQEaOvgwcEuzYww/ScreenDataSets.ECB7z9Mh8k+rJ3Ej4sHppw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoiceextendedrelations2\".\"tiporelacion\" o2, \"eninvoiceextendedrelations2\".\"uuidrelacionado\" o3, \"eninvoiceextendedrelations2\".\"foliorelacionado\" o4");
fromBuilder.Append(" FROM {InvoiceExtendedRelations} \"eninvoiceextendedrelations2\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedrelations2\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedrelations2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedrelations2\".\"invoiceid\" IS NULL)");
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
RL_d07e089b14ae41d13cfd90c5313de016 outParamList = new RL_d07e089b14ae41d13cfd90c5313de016();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedRelationsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d07e089b14ae41d13cfd90c5313de016 _tmp = new RL_d07e089b14ae41d13cfd90c5313de016();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedRelationsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d07e089b14ae41d13cfd90c5313de016)_tmp;
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
// Query Function "GetInvoiceAccountingByInvoiceId" 6X4Q1BOSHkS6KGyg_owEzQ of Action "Wb_InvoiceDetails"
public static async Task<(RL_cc406982da8c42dd9f44909f6be7c1b9,long)> datasetGetInvoiceAccountingByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccounting_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetails.GetInvoiceAccountingByInvoiceId", "d4107ee9-9213-441e-ba28-6ca0fe8c04cd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetails","d_Invoices.Wb_InvoiceDetails.GetInvoiceAccountingByInvoiceId");
// Query Iterations: Never
// Refresh Query mV2yEYZ050yaVcYbYesZkQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.ZbtC51gEQEaOvgwcEuzYww/ScreenDataSets.6X4Q1BOSHkS6KGyg_owEzQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"eninvoiceaccounting34\".\"submissionby\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47");
fromBuilder.Append(" FROM ((({InvoiceAccounting} \"eninvoiceaccounting34\" Left JOIN {PaymentMethods} \"enpaymentmethods10\" ON (\"eninvoiceaccounting34\".\"paymentmethodid\" = \"enpaymentmethods10\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms21\" ON (\"eninvoiceaccounting34\".\"paymenttermsid\" = \"enpaymentterms21\".\"id\"))  Left JOIN {TaxIndicator} \"entaxindicator13\" ON (\"eninvoiceaccounting34\".\"ivaindicatorid\" = \"entaxindicator13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccounting_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting34\".\"invoiceid\" = @qpinInvoiceAccounting_InvoiceId) AND (\"eninvoiceaccounting34\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccounting_InvoiceId", DbType.Int64, qpinInvoiceAccounting_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting34\".\"invoiceid\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceAccountingByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceAccountingByInvoiceId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_2c7478516bbd3eed6a35183496a9f500> datasetGetInvoiceExtendedByIdReadDbAsync(RC_2c7478516bbd3eed6a35183496a9f500 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceExtendedCartaPorte.Read( r, ref index);
rec.ssENInvoiceExtendedIssuer.Read( r, ref index);
rec.ssENInvoiceExtendedReceiver.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceExtendedById" ujJd2nPGREmTREjYEcCrlA of Action "Wb_InvoiceDetails"
public static async Task<(RL_ec81b8a47286cf2b9fe9bbf727e9ade3,long)> datasetGetInvoiceExtendedById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpinInvoiceExtended_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedById", "da5d32ba-c673-4944-9344-48d811c0ab94");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetails","d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedById");
// Query Iterations: Never
// Refresh Query HTZsURmF00OQ1RtRDgsczg Iterations: Never
// Refresh Query H6SyK1Z44EetLUWzBxU7_g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.ZbtC51gEQEaOvgwcEuzYww/ScreenDataSets.ujJd2nPGREmTREjYEcCrlA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice128\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"eninvoice128\".\"invoicestatusid\" o8, NULL o9, NULL o10, NULL o11, \"eninvoice128\".\"createdby\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"eninvoice128\".\"id_poliza_sap\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, \"eninvoiceextended33\".\"version\" o46, \"eninvoiceextended33\".\"folio\" o47, \"eninvoiceextended33\".\"serie\" o48, \"eninvoiceextended33\".\"fechaemision\" o49, \"eninvoiceextended33\".\"formapago\" o50, \"eninvoiceextended33\".\"metodopago\" o51, \"eninvoiceextended33\".\"lugarexpedicion\" o52, trim_scale(\"eninvoiceextended33\".\"subtotal\"::numeric) o53, trim_scale(\"eninvoiceextended33\".\"descuento\"::numeric) o54, trim_scale(\"eninvoiceextended33\".\"totaliva\"::numeric) o55, trim_scale(\"eninvoiceextended33\".\"retenciones\"::numeric) o56, trim_scale(\"eninvoiceextended33\".\"total\"::numeric) o57, \"eninvoiceextended33\".\"tipocomprobante\" o58, \"eninvoiceextended33\".\"moneda\" o59, trim_scale(\"eninvoiceextended33\".\"tipocambio\"::numeric) o60, \"eninvoiceextended33\".\"usocfdi\" o61, \"eninvoiceextended33\".\"exportacion\" o62, NULL o63, NULL o64, \"eninvoiceextendedcartaporte1\".\"descripcion\" o65, trim_scale(\"eninvoiceextendedcartaporte1\".\"valormercancia\"::numeric) o66, \"eninvoiceextendedcartaporte1\".\"centroatencion\" o67, \"eninvoiceextendedcartaporte1\".\"calle\" o68, \"eninvoiceextendedcartaporte1\".\"numeroexterior\" o69, \"eninvoiceextendedcartaporte1\".\"codigopostal\" o70, NULL o71, \"eninvoiceextendedissuer1\".\"rfc\" o72, \"eninvoiceextendedissuer1\".\"nombre\" o73, \"eninvoiceextendedissuer1\".\"regimenfiscal\" o74, \"eninvoiceextendedissuer1\".\"codigopostal\" o75, NULL o76, \"eninvoiceextendedreceiver1\".\"rfc\" o77, \"eninvoiceextendedreceiver1\".\"nombre\" o78, \"eninvoiceextendedreceiver1\".\"regimenfiscal\" o79, \"eninvoiceextendedreceiver1\".\"codigopostal\" o80");
fromBuilder.Append(" FROM ((((({Invoice} \"eninvoice128\" Inner JOIN {InvoiceExtended} \"eninvoiceextended33\" ON (\"eninvoiceextended33\".\"id\" = \"eninvoice128\".\"id\"))  Left JOIN {InvoiceExtendedIssuer} \"eninvoiceextendedissuer1\" ON (\"eninvoice128\".\"id\" = \"eninvoiceextendedissuer1\".\"id\"))  Left JOIN {InvoiceExtendedReceiver} \"eninvoiceextendedreceiver1\" ON (\"eninvoice128\".\"id\" = \"eninvoiceextendedreceiver1\".\"id\"))  Left JOIN {InvoiceExtendedCartaPorte} \"eninvoiceextendedcartaporte1\" ON (\"eninvoice128\".\"id\" = \"eninvoiceextendedcartaporte1\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting35\" ON (\"eninvoice128\".\"id\" = \"eninvoiceaccounting35\".\"invoiceid\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoiceExtended_Id != 0) {
whereBuilder.Append("((\"eninvoiceextended33\".\"id\" = @qpinInvoiceExtended_Id) AND (\"eninvoiceextended33\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtended_Id", DbType.Int64, qpinInvoiceExtended_Id);
} else {
whereBuilder.Append("(\"eninvoiceextended33\".\"id\" IS NULL)");
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
RL_ec81b8a47286cf2b9fe9bbf727e9ade3 outParamList = new RL_ec81b8a47286cf2b9fe9bbf727e9ade3();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceExtendedByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, true, false, true, true, true, true, true, false, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, false, false, false});
opt[2] = new BitArray(new bool[] {true, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {true, false, false, false, false});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ec81b8a47286cf2b9fe9bbf727e9ade3 _tmp = new RL_ec81b8a47286cf2b9fe9bbf727e9ade3();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceExtendedByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ec81b8a47286cf2b9fe9bbf727e9ade3)_tmp;
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

// Query Function "GetInvoiceExtendedMoreChargesByInvoiceId" 8dh634CQ40GLh1pj3Q+kMA of Action "Wb_InvoiceDetails"
public static async Task<(RL_ef088826c46241557fb82e7c7f21d334,long)> datasetGetInvoiceExtendedMoreChargesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesByInvoiceId", "df7ad8f1-9080-41e3-8b87-5a63dd0fa430");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetails","d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesByInvoiceId");
// Query Iterations: Multiple
// Refresh Query 3kc09Zq7YUGKn2UEr3MwVw Iterations: Multiple
// Refresh Query cWa84FJhvUGevh4xDglBSA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.ZbtC51gEQEaOvgwcEuzYww/ScreenDataSets.8dh634CQ40GLh1pj3Q+kMA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"eninvoiceextendedmorecharges7\".\"nombreconcepto\" o2, trim_scale(\"eninvoiceextendedmorecharges7\".\"value\"::numeric) o3");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges7\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges7\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges7\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges7\".\"invoiceid\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_eac76b624d2264108f6fbeb95d9d43ba> datasetGetInvoiceApprovalReadDbAsync(RC_eac76b624d2264108f6fbeb95d9d43ba rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceApproval" vqez9XcbEE6njurngjSlyQ of Action "Wb_InvoiceDetails"
public static async Task<(RL_d62c1f17f6aae94386bfdb54075ff733,long)> datasetGetInvoiceApproval(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpusGetUserId,long qpsuRequisition_SupplierId,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("d_Invoices.Wb_InvoiceDetails.GetInvoiceApproval", "f5b3a7be-1b77-4e10-a78e-eae78234a5c9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_InvoiceDetails","d_Invoices.Wb_InvoiceDetails.GetInvoiceApproval");
// Query Iterations: Never
// Refresh Query WK+Ccbn1sEqJAYlYiuyXtg Iterations: Never
// Refresh Query Nn1pyqqZ6E+QiUbhk5nWWw Iterations: Never
// Refresh Query iFH9gLnNa0WFnvAV4roEKg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.22FlLU0LEUOaUFO_6iGXPQ/NodesShownInESpaceTree.ZbtC51gEQEaOvgwcEuzYww/ScreenDataSets.vqez9XcbEE6njurngjSlyQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"eninvoiceapproval40\".\"currentlevel\" o29, \"eninvoiceapproval40\".\"maxlevel\" o30, NULL o31, NULL o32, \"eninvoiceapproval40\".\"hasstartedaccounting\" o33, \"eninvoiceapprovallevel39\".\"id\" o34, NULL o35, NULL o36, \"eninvoiceapprovallevel39\".\"assignedto\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, \"ensupplier87\".\"pais\" o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice129\" Left JOIN {InvoiceApproval} \"eninvoiceapproval40\" ON (\"eninvoice129\".\"id\" = \"eninvoiceapproval40\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel39\" ON (\"eninvoiceapproval40\".\"id\" = \"eninvoiceapprovallevel39\".\"invoiceapprovalid\"))  Left JOIN {Requisition} \"enrequisition104\" ON (\"eninvoice129\".\"requisitionid\" = \"enrequisition104\".\"id\"))  Left JOIN {Supplier} \"ensupplier87\" ON (\"enrequisition104\".\"supplierid\" = \"ensupplier87\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice129\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice129\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice129\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (");
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition104\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition104\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition104\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" OR ((\"eninvoiceapprovallevel39\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel39\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel39\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel39\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel39\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE 1 END) = 1) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel39\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel39\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel39\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel39\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel39\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel39\".\"requesttomodifyby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel39\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel39\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel39\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")))");
orderByBuilder.Append(" ORDER BY \"eninvoiceapprovallevel39\".\"levelnumber\" DESC ");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, false, false, true, true, false});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceApproval.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query d_Invoices.Wb_InvoiceDetails.GetInvoiceApproval.List", cancellationToken: cancellationToken);
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


    

    

}
