namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceAccountingInitialCreate : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public string inParamDivision;
public string inParamInvoiceIVA;
public string inParamInvoiceIVAAmount;
public string inParamInvoiceRetentions;
public string inParamInvoiceSubtotal;
public string inParamInvoiceDescuentos;
public string inParamFreeText;
public long inParamRequisitionCostCenterId;
public long inParamRequisitionPaymentMethodId;
public long inParamRequisitionPaymentTermsId;
public string inParamRequisitionSupplierNr;
public string inParamRequisitionTotalAmount;
public bool inParamIsNational;
public bool inParamIsAnticipoWithInv;
/// <summary>
/// Variable <code>l_InvoiceAccounting</code> that represents the Service Studio InvoiceAccounting
///  <code>l_InvoiceAccounting</code> <p>Description: InvoiceAccounting record to create or modify</p>
/// </summary>
public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord varLcl_InvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();

public Actions.lcoInvoiceAccountingCreateOrUpdate resInvoiceAccountingCreateOrUpdate =  new Actions.lcoInvoiceAccountingCreateOrUpdate();
public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount = 0L;

public RL_84dada5f12004775b86c894b55ae9596 queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList = new RL_84dada5f12004775b86c894b55ae9596();
public long queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount = 0L;

public Actions.lcoInvoiceGetIVACodeByTax resInvoiceGetIVACodeByTax =  new Actions.lcoInvoiceGetIVACodeByTax();
public RL_ccf70f600f06def33a14ca10a1120a68 queryResGetInvoiceAccountingsByInvoiceId_outParamList = new RL_ccf70f600f06def33a14ca10a1120a68();
public long queryResGetInvoiceAccountingsByInvoiceId_outParamCount = 0L;

public lcvInvoiceAccountingInitialCreate(long inParamInvoiceId, long inParamRequisitionId, string inParamDivision, string inParamInvoiceIVA, string inParamInvoiceIVAAmount, string inParamInvoiceRetentions, string inParamInvoiceSubtotal, string inParamInvoiceDescuentos, string inParamFreeText, long inParamRequisitionCostCenterId, long inParamRequisitionPaymentMethodId, long inParamRequisitionPaymentTermsId, string inParamRequisitionSupplierNr, string inParamRequisitionTotalAmount, bool inParamIsNational, bool inParamIsAnticipoWithInv) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamDivision = inParamDivision;
this.inParamInvoiceIVA = inParamInvoiceIVA;
this.inParamInvoiceIVAAmount = inParamInvoiceIVAAmount;
this.inParamInvoiceRetentions = inParamInvoiceRetentions;
this.inParamInvoiceSubtotal = inParamInvoiceSubtotal;
this.inParamInvoiceDescuentos = inParamInvoiceDescuentos;
this.inParamFreeText = inParamFreeText;
this.inParamRequisitionCostCenterId = inParamRequisitionCostCenterId;
this.inParamRequisitionPaymentMethodId = inParamRequisitionPaymentMethodId;
this.inParamRequisitionPaymentTermsId = inParamRequisitionPaymentTermsId;
this.inParamRequisitionSupplierNr = inParamRequisitionSupplierNr;
this.inParamRequisitionTotalAmount = inParamRequisitionTotalAmount;
this.inParamIsNational = inParamIsNational;
this.inParamIsAnticipoWithInv = inParamIsAnticipoWithInv;
}
}
/// <summary>
/// Action <code>InvoiceAccountingInitialCreate</code> that represents the Service Studio action
///  <code>InvoiceAccountingInitialCreate</code> <p> Description: Action to Invoice Accountin
/// g Creation.</p>
/// </summary>
public static async Task ActionInvoiceAccountingInitialCreate(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,string inParamDivision,string inParamInvoiceIVA,string inParamInvoiceIVAAmount,string inParamInvoiceRetentions,string inParamInvoiceSubtotal,string inParamInvoiceDescuentos,string inParamFreeText,long inParamRequisitionCostCenterId,long inParamRequisitionPaymentMethodId,long inParamRequisitionPaymentTermsId,string inParamRequisitionSupplierNr,string inParamRequisitionTotalAmount,bool inParamIsNational,bool inParamIsAnticipoWithInv,CancellationToken cancellationToken) {
lcvInvoiceAccountingInitialCreate localVars = new lcvInvoiceAccountingInitialCreate(inParamInvoiceId, inParamRequisitionId, inParamDivision, inParamInvoiceIVA, inParamInvoiceIVAAmount, inParamInvoiceRetentions, inParamInvoiceSubtotal, inParamInvoiceDescuentos, inParamFreeText, inParamRequisitionCostCenterId, inParamRequisitionPaymentMethodId, inParamRequisitionPaymentTermsId, inParamRequisitionSupplierNr, inParamRequisitionTotalAmount, inParamIsNational, inParamIsAnticipoWithInv);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceAccountingInitialCreate", "2f8fc571-4db4-4169-8f0e-900d92014bba"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceAccountingInitialCreate", "2f8fc571-4db4-4169-8f0e-900d92014bba", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceExtendedTaxsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 1;
if (datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords < 1) datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 1;
int datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount) = await FuncActionInvoiceAccountingInitialCreate.datasetGetInvoiceExtendedTaxsByInvoiceId(requestContext,datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords,datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// InvoiceGetIVACodeByTax
(localVars.resInvoiceGetIVACodeByTax.outParamTaxIndicatorId,localVars.resInvoiceGetIVACodeByTax.outParamCode) = await Actions.ActionInvoiceGetIVACodeByTax(requestContext,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedTax,localVars.inParamIsNational,localVars.inParamRequisitionSupplierNr,cancellationToken);

// Query datasetGetInvoiceAccountingsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingsByInvoiceId_maxRecords = 1;
if (datasetGetInvoiceAccountingsByInvoiceId_maxRecords < 1) datasetGetInvoiceAccountingsByInvoiceId_maxRecords = 1;
int datasetGetInvoiceAccountingsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList,localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamCount) = await FuncActionInvoiceAccountingInitialCreate.datasetGetInvoiceAccountingsByInvoiceId(requestContext,datasetGetInvoiceAccountingsByInvoiceId_maxRecords,datasetGetInvoiceAccountingsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// Query datasetGetInvoiceExtendedMoreChargesByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords = 0;
int datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamCount) = await FuncActionInvoiceAccountingInitialCreate.datasetGetInvoiceExtendedMoreChargesByInvoiceId(requestContext,datasetGetInvoiceExtendedMoreChargesByInvoiceId_maxRecords,datasetGetInvoiceExtendedMoreChargesByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceId,cancellationToken);

// l_InvoiceAccounting.InvoiceId = InvoiceId
localVars.varLcl_InvoiceAccounting.ssInvoiceId = localVars.inParamInvoiceId;

// l_InvoiceAccounting.SupplierNumber = RequisitionSupplierNr
localVars.varLcl_InvoiceAccounting.ssSupplierNumber = localVars.inParamRequisitionSupplierNr;

// l_InvoiceAccounting.FreeText = FreeText
localVars.varLcl_InvoiceAccounting.ssFreeText = localVars.inParamFreeText;

// l_InvoiceAccounting.Division = Division
localVars.varLcl_InvoiceAccounting.ssDivision = localVars.inParamDivision;

// l_InvoiceAccounting.IvaAmount = TextToDecimal
localVars.varLcl_InvoiceAccounting.ssIvaAmount = BuiltInFunction.TextToDecimal (localVars.inParamInvoiceIVA);

// l_InvoiceAccounting.TotalAmount = TextToDecimal + TextToDecimal - TextToDecimal + TextToDecimal + GetInvoiceExtendedMoreChargesByInvoiceId.List.Current.ValueSum
localVars.varLcl_InvoiceAccounting.ssTotalAmount = ((((BuiltInFunction.TextToDecimal (localVars.inParamInvoiceSubtotal)+BuiltInFunction.TextToDecimal (localVars.inParamInvoiceIVAAmount))-BuiltInFunction.TextToDecimal (localVars.inParamInvoiceDescuentos))+BuiltInFunction.TextToDecimal (localVars.inParamInvoiceRetentions))+localVars.queryResGetInvoiceExtendedMoreChargesByInvoiceId_outParamList.CurrentRec.ssValueSum);

// l_InvoiceAccounting.PaymentMethodId = RequisitionPaymentMethodId
localVars.varLcl_InvoiceAccounting.ssPaymentMethodId = localVars.inParamRequisitionPaymentMethodId;

// l_InvoiceAccounting.PaymentTermsId = RequisitionPaymentTermsId
localVars.varLcl_InvoiceAccounting.ssPaymentTermsId = localVars.inParamRequisitionPaymentTermsId;

// l_InvoiceAccounting.ICMEIndicator = ""
localVars.varLcl_InvoiceAccounting.ssICMEIndicator = "";

// l_InvoiceAccounting.IvaIndicatorId = InvoiceGetIVACodeByTax.TaxIndicatorId
localVars.varLcl_InvoiceAccounting.ssIvaIndicatorId = localVars.resInvoiceGetIVACodeByTax.outParamTaxIndicatorId;

// l_InvoiceAccounting.Id = GetInvoiceAccountingsByInvoiceId.List.Current.InvoiceAccounting.Id
localVars.varLcl_InvoiceAccounting.ssId = localVars.queryResGetInvoiceAccountingsByInvoiceId_outParamList.CurrentRec.ssENInvoiceAccounting.ssId;
// InvoiceAccountingCreateOrUpdate
localVars.resInvoiceAccountingCreateOrUpdate.outParamId = await Actions.ActionInvoiceAccountingCreateOrUpdate(requestContext,localVars.varLcl_InvoiceAccounting,cancellationToken);

// InvoiceAccountingServicesCreate
await Actions.ActionInvoiceAccountingInitialCreate_Serv(requestContext,localVars.resInvoiceAccountingCreateOrUpdate.outParamId,localVars.inParamRequisitionId,localVars.inParamRequisitionCostCenterId,localVars.inParamRequisitionTotalAmount,localVars.varLcl_InvoiceAccounting.ssTotalAmount,localVars.inParamDivision,localVars.inParamFreeText,localVars.resInvoiceGetIVACodeByTax.outParamTaxIndicatorId,localVars.inParamIsAnticipoWithInv,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceAccountingInitialCreate {

// Query Function "GetInvoiceExtendedTaxsByInvoiceId" xZnEe2c+CEiUxshZKOF1aA of Action "InvoiceAccountingInitialCreate"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceExtendedTaxsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingInitialCreate.GetInvoiceExtendedTaxsByInvoiceId", "7bc499c5-3e67-4808-94c6-c85928e17568");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingInitialCreate.GetInvoiceExtendedTaxsByInvoiceId", "7bc499c5-3e67-4808-94c6-c85928e17568", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ccWPL7RNaUGPDpANkgFLug/NodesNotShownInESpaceTree.xZnEe2c+CEiUxshZKOF1aA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedtax2\".\"id\" o0, \"eninvoiceextendedtax2\".\"invoiceid\" o1, \"eninvoiceextendedtax2\".\"invoicetaxtypeid\" o2, \"eninvoiceextendedtax2\".\"impuesto\" o3, trim_scale(\"eninvoiceextendedtax2\".\"base\"::numeric) o4, trim_scale(\"eninvoiceextendedtax2\".\"tasaocuota\"::numeric) o5, trim_scale(\"eninvoiceextendedtax2\".\"importe\"::numeric) o6, \"eninvoiceextendedtax2\".\"tipofactor\" o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax2\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax2\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax2\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedtax2\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoiceextendedtax2\".\"tipofactor\" = 'Tasa')");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingInitialCreate.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingInitialCreate.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceExtendedMoreChargesByInvoiceId" ZQxT2HmQhEuxc9Yp1bkTgQ of Action "InvoiceAccountingInitialCreate"
public static async Task<(RL_84dada5f12004775b86c894b55ae9596,long)> datasetGetInvoiceExtendedMoreChargesByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingInitialCreate.GetInvoiceExtendedMoreChargesByInvoiceId", "d8530c65-9079-4b84-b173-d629d5b91381");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingInitialCreate.GetInvoiceExtendedMoreChargesByInvoiceId", "d8530c65-9079-4b84-b173-d629d5b91381", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ccWPL7RNaUGPDpANkgFLug/NodesNotShownInESpaceTree.ZQxT2HmQhEuxc9Yp1bkTgQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT Sum(\"eninvoiceextendedmorecharges\".\"value\") \"valuesum\"");
fromBuilder.Append(" FROM {InvoiceExtendedMoreCharges} \"eninvoiceextendedmorecharges\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedmorecharges\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedmorecharges\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedmorecharges\".\"invoiceid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingInitialCreate.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingInitialCreate.GetInvoiceExtendedMoreChargesByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceAccountingsByInvoiceId" Id+a7owCS0uedAV+vFfTtA of Action "InvoiceAccountingInitialCreate"
public static async Task<(RL_ccf70f600f06def33a14ca10a1120a68,long)> datasetGetInvoiceAccountingsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceAccountingInitialCreate.GetInvoiceAccountingsByInvoiceId", "ee9adf21-028c-4b4b-9e74-057ebc57d3b4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceAccountingInitialCreate.GetInvoiceAccountingsByInvoiceId", "ee9adf21-028c-4b4b-9e74-057ebc57d3b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.ccWPL7RNaUGPDpANkgFLug/NodesNotShownInESpaceTree.Id+a7owCS0uedAV+vFfTtA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceaccounting2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20");
fromBuilder.Append(" FROM {InvoiceAccounting} \"eninvoiceaccounting2\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceaccounting2\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceaccounting2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceaccounting2\".\"invoiceid\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceAccountingInitialCreate.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceAccountingInitialCreate.GetInvoiceAccountingsByInvoiceId.List", cancellationToken: cancellationToken);
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



}


}
