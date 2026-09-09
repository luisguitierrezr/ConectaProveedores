namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccountingInvProcess_F43 : VarsBag {
public long inParamInvoiceAccountingProcessId;
public decimal inParamExchangeRate;
/// <summary>
/// Variable <code>IsAnticipo</code> that represents the Service Studio Boolean <code>IsAnticipo</code>
///  <p>Description: </p>
/// </summary>
public bool varLcIsAnticipo = false;

/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

/// <summary>
/// Variable <code>ConceptPayTermDays</code> that represents the Service Studio Integer
///  <code>ConceptPayTermDays</code> <p>Description: </p>
/// </summary>
public int varLcConceptPayTermDays = 0;

public ST_b29967856499aeaa8c796dc87fe4c6e8Structure resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount = 0L;

public RL_4e909af3a15d1687c03c789af38db7ae queryResGetInvoiceAccountingProcessById_outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public RL_0dc1085ad4cd06d01dea77860d02de63 queryResGetFolioItemsByOrderMainId_outParamList = new RL_0dc1085ad4cd06d01dea77860d02de63();
public long queryResGetFolioItemsByOrderMainId_outParamCount = 0L;

public RL_9404dc36b913809894c7e4e44e8e1dd8 queryResGetTaxToAdd_outParamList = new RL_9404dc36b913809894c7e4e44e8e1dd8();
public long queryResGetTaxToAdd_outParamCount = 0L;

public Actions.lcoGetOrderK012 resGetOrderK012 =  new Actions.lcoGetOrderK012();
public Actions.lcoEntryAccountingInvProcess_GetRetentions resEntryAccountingInvProcess_GetRetentions =  new Actions.lcoEntryAccountingInvProcess_GetRetentions();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate4 =  new Actions.lcoLogsAccountingCreate();
public RL_b323e0bdf1fec18079c1034e78738762 queryResGetOrderAccConceptById_outParamList = new RL_b323e0bdf1fec18079c1034e78738762();
public long queryResGetOrderAccConceptById_outParamCount = 0L;

public Actions.lcoEntryAccounting_CallAccounting_Order resEntryAccounting_CallAccounting_Order =  new Actions.lcoEntryAccounting_CallAccounting_Order();
public Actions.lcoGetPaymentTermSpecial resGetPaymentTermSpecial =  new Actions.lcoGetPaymentTermSpecial();
public Actions.lcoInvoiceGetIVACodeByTax resInvoiceGetIVACodeByTax =  new Actions.lcoInvoiceGetIVACodeByTax();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate5 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoEntryAccounting_CallAccounting resEntryAccounting_CallAccounting =  new Actions.lcoEntryAccounting_CallAccounting();
public RL_72bc9c8db8dc80bec32b40b958e9af79 queryResGetInvoiceById_outParamList = new RL_72bc9c8db8dc80bec32b40b958e9af79();
public long queryResGetInvoiceById_outParamCount = 0L;

public lcvEntryAccountingInvProcess_F43(long inParamInvoiceAccountingProcessId, decimal inParamExchangeRate) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
this.inParamExchangeRate = inParamExchangeRate;
}
}
public class lcoEntryAccountingInvProcess_F43 : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public lcoEntryAccountingInvProcess_F43() {
}
}
/// <summary>
/// Action <code>EntryAccountingInvProcess_F43</code> that represents the Service Studio action
///  <code>EntryAccountingInvProcess_F43</code> <p> Description: </p>
/// </summary>
public static async Task<(bool,string)> ActionEntryAccountingInvProcess_F43(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,decimal inParamExchangeRate,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
lcoEntryAccountingInvProcess_F43 result = new lcoEntryAccountingInvProcess_F43();
lcvEntryAccountingInvProcess_F43 localVars = new lcvEntryAccountingInvProcess_F43(inParamInvoiceAccountingProcessId, inParamExchangeRate);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccountingInvProcess_F43", "25f685ad-6361-44be-962f-f637115c953c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccountingInvProcess_F43", "25f685ad-6361-44be-962f-f637115c953c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionEntryAccountingInvProcess_F43.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// EntryAccountingInvProcess_GetRetentions
(localVars.resEntryAccountingInvProcess_GetRetentions.outParamIsSuccess,localVars.resEntryAccountingInvProcess_GetRetentions.outParamMessage,localVars.resEntryAccountingInvProcess_GetRetentions.outParamCanTryAgain,localVars.resEntryAccountingInvProcess_GetRetentions.outParamIsServiceError,localVars.resEntryAccountingInvProcess_GetRetentions.outParamRetentionsCall2List) = await Actions.ActionEntryAccountingInvProcess_GetRetentions(requestContext,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// Query datasetGetInvoiceById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceById_maxRecords = 0;
int datasetGetInvoiceById_startIndex = 0;(localVars.queryResGetInvoiceById_outParamList,localVars.queryResGetInvoiceById_outParamCount) = await FuncActionEntryAccountingInvProcess_F43.datasetGetInvoiceById(requestContext,datasetGetInvoiceById_maxRecords,datasetGetInvoiceById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// Query datasetGetOrderAccConceptById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccConceptById_maxRecords = 1;
if (datasetGetOrderAccConceptById_maxRecords < 1) datasetGetOrderAccConceptById_maxRecords = 1;
int datasetGetOrderAccConceptById_startIndex = 0;(localVars.queryResGetOrderAccConceptById_outParamList,localVars.queryResGetOrderAccConceptById_outParamCount) = await FuncActionEntryAccountingInvProcess_F43.datasetGetOrderAccConceptById(requestContext,datasetGetOrderAccConceptById_maxRecords,datasetGetOrderAccConceptById_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssOrderAccConceptsID,cancellationToken);

// GetPaymentTermSpecial
localVars.resGetPaymentTermSpecial.outParamId = await Actions.ActionGetPaymentTermSpecial(requestContext,cancellationToken);

// IsAnticipo = GetOrderAccConceptById.List.Current.OrderAccConcepts.AccountingDataTypeId = Anticipo
localVars.varLcIsAnticipo=(localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAccountingDataTypeId==8);

// ConceptPayTermDays = If
localVars.varLcConceptPayTermDays=(((localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssPaymentTermId!=localVars.resGetPaymentTermSpecial.outParamId)) ? (BuiltInFunction.TextToInteger (localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias)) : (localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssPaymentTermCustomDays));
// Query datasetGetInvoiceExtendedTaxsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 1;
if (datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords < 1) datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords = 1;
int datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex = 0;(localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamCount) = await FuncActionEntryAccountingInvProcess_F43.datasetGetInvoiceExtendedTaxsByInvoiceId(requestContext,datasetGetInvoiceExtendedTaxsByInvoiceId_maxRecords,datasetGetInvoiceExtendedTaxsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// GetOrderK012
(localVars.resGetOrderK012.outParamPaymentTermsDesc,localVars.resGetOrderK012.outParamPaymentTermDays) = await Actions.ActionGetOrderK012(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENOrderMain.ssId,cancellationToken);

// InvoiceGetIVACodeByTax
(localVars.resInvoiceGetIVACodeByTax.outParamTaxIndicatorId,localVars.resInvoiceGetIVACodeByTax.outParamCode) = await Actions.ActionInvoiceGetIVACodeByTax(requestContext,localVars.queryResGetInvoiceExtendedTaxsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedTax,(localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssPais=="MX"),localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssNumber,cancellationToken);

// Query datasetGetTaxToAdd
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTaxToAdd_maxRecords = 1;
if (datasetGetTaxToAdd_maxRecords < 1) datasetGetTaxToAdd_maxRecords = 1;
int datasetGetTaxToAdd_startIndex = 0;(localVars.queryResGetTaxToAdd_outParamList,localVars.queryResGetTaxToAdd_outParamCount) = await FuncActionEntryAccountingInvProcess_F43.datasetGetTaxToAdd(requestContext,datasetGetTaxToAdd_maxRecords,datasetGetTaxToAdd_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,cancellationToken);

// no folio
if(((localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// EntryAccounting_CallAccounting_Order
localVars.resEntryAccounting_CallAccounting_Order.outParamo_Output = await Actions.ActionEntryAccounting_CallAccounting_Order(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec,((localVars.varLcIsAnticipo) ? ("KW") : ("NC")),localVars.resInvoiceGetIVACodeByTax.outParamCode,localVars.queryResGetTaxToAdd_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssImporte,(((localVars.resGetOrderK012.outParamPaymentTermsDesc!="")) ? (localVars.resGetOrderK012.outParamPaymentTermsDesc) : (localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP)),(((localVars.resGetOrderK012.outParamPaymentTermsDesc!="")) ? (30) : (localVars.varLcConceptPayTermDays)),"C",((localVars.varLcIsAnticipo) ? ("C") : ("A")),((localVars.varLcIsAnticipo) ? ("02") : ("01")),((localVars.varLcIsAnticipo) ? ("03") : ("02")),((localVars.varLcIsAnticipo) ? ((((localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAdvancePaymentTypeId==2)) ? ("B") : ("A"))) : ("")),localVars.inParamExchangeRate,localVars.varLcIsAnticipo,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssOffsetUtc,cancellationToken);

// IsSuccess = EntryAccounting_CallAccounting_Order.o_Output.IsSuccess
result.outParamIsSuccess=localVars.resEntryAccounting_CallAccounting_Order.outParamo_Output.ssIsSuccess;

// Message = EntryAccounting_CallAccounting_Order.o_Output.Message
result.outParamMessage=localVars.resEntryAccounting_CallAccounting_Order.outParamo_Output.ssMessage;
} else {
// Query datasetGetFolioItemsByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByOrderMainId_maxRecords = 0;
int datasetGetFolioItemsByOrderMainId_startIndex = 0;(localVars.queryResGetFolioItemsByOrderMainId_outParamList,localVars.queryResGetFolioItemsByOrderMainId_outParamCount) = await FuncActionEntryAccountingInvProcess_F43.datasetGetFolioItemsByOrderMainId(requestContext,datasetGetFolioItemsByOrderMainId_maxRecords,datasetGetFolioItemsByOrderMainId_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssFolioId,cancellationToken);

// EntryAccounting_CallAccounting
localVars.resEntryAccounting_CallAccounting.outParamo_Output = await Actions.ActionEntryAccounting_CallAccounting(requestContext,localVars.queryResGetInvoiceById_outParamList.CurrentRec,localVars.queryResGetFolioItemsByOrderMainId_outParamList,((localVars.varLcIsAnticipo) ? ("KW") : ("NC")),localVars.resInvoiceGetIVACodeByTax.outParamCode,localVars.queryResGetTaxToAdd_outParamList.CurrentRec.ssENInvoiceExtendedTax.ssImporte,(((localVars.resGetOrderK012.outParamPaymentTermsDesc!="")) ? (localVars.resGetOrderK012.outParamPaymentTermsDesc) : (localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP)),(((localVars.resGetOrderK012.outParamPaymentTermsDesc!="")) ? (30) : (localVars.varLcConceptPayTermDays)),"C",((localVars.varLcIsAnticipo) ? ("C") : ("A")),((localVars.varLcIsAnticipo) ? ("02") : ("01")),((localVars.varLcIsAnticipo) ? ("03") : ("02")),(((localVars.queryResGetOrderAccConceptById_outParamList.CurrentRec.ssENOrderAccConcepts.ssAdvancePaymentTypeId==2)) ? ("B") : ("A")),localVars.inParamExchangeRate,localVars.varLcIsAnticipo,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssOffsetUtc,cancellationToken);

// IsSuccess = EntryAccounting_CallAccounting.o_Output.IsSuccess
result.outParamIsSuccess=localVars.resEntryAccounting_CallAccounting.outParamo_Output.ssIsSuccess;

// Message = EntryAccounting_CallAccounting.o_Output.Message
result.outParamMessage=localVars.resEntryAccounting_CallAccounting.outParamo_Output.ssMessage;
}

// has retentions
if(((!localVars.resEntryAccountingInvProcess_GetRetentions.outParamRetentionsCall2List.Empty))) {
// LogsAccountingCreate4
localVars.resLogsAccountingCreate4.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("FCP After Contab - RetentionsInvoice "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ((((("PI_BUKRS "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENCompany.ssExternalId)+" // PI_VENDORNO ")+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssNumber)+"// RETENCION 1 ")+localVars.resEntryAccountingInvProcess_GetRetentions.outParamRetentionsCall2List.CurrentRec.ssWITHT), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// Call_ZMXFFIMF_INSERT_UPDROV2
localVars.resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_INSERT_UPDROV(requestContext,new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(){ ssPI_BUKRS = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENCompany.ssExternalId, ssPI_VENDORNO = localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENSupplier.ssNumber, ssTI_RETENCIONES_In = localVars.resEntryAccountingInvProcess_GetRetentions.outParamRetentionsCall2List },cancellationToken);

// ActionTimestampsCreateOrUpdate5
localVars.resActionTimestampsCreateOrUpdate5.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Reset retentions"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("FCP After Contab - RetentionsInvoice "+localVars.queryResGetInvoiceById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = (((((!result.outParamIsSuccess)) ? ("Error") : ("Ok"))+" // RESPUESTA ")+BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV2_outParamResponse.ssPO_RESPUESTA, 0, 50)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "Error in SAP services. Please contact an administrator."
result.outParamMessage=AppUtils.GetStringResource("ulhPt6GrzEeeR4jqB+QHWw#Value.1410737295.1", "Error in SAP services. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage);
}

public static class FuncActionEntryAccountingInvProcess_F43 {

// Query Function "GetInvoiceExtendedTaxsByInvoiceId" ax_IC2Vv7kOchK7Eb5afgw of Action "EntryAccountingInvProcess_F43"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetInvoiceExtendedTaxsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_F43.GetInvoiceExtendedTaxsByInvoiceId", "0bc81f6b-6f65-43ee-9c84-aec46f969f83");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_F43.GetInvoiceExtendedTaxsByInvoiceId", "0bc81f6b-6f65-43ee-9c84-aec46f969f83", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.rYX2JWFjvkSWL_Y3EVyVPA/NodesNotShownInESpaceTree.ax_IC2Vv7kOchK7Eb5afgw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendedtax\".\"id\" o0, \"eninvoiceextendedtax\".\"invoiceid\" o1, \"eninvoiceextendedtax\".\"invoicetaxtypeid\" o2, \"eninvoiceextendedtax\".\"impuesto\" o3, trim_scale(\"eninvoiceextendedtax\".\"base\"::numeric) o4, trim_scale(\"eninvoiceextendedtax\".\"tasaocuota\"::numeric) o5, trim_scale(\"eninvoiceextendedtax\".\"importe\"::numeric) o6, \"eninvoiceextendedtax\".\"tipofactor\" o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendedtax\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId);
whereBuilder.Append(")");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_F43.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_F43.GetInvoiceExtendedTaxsByInvoiceId.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceAccountingProcessById" PgjJIbSfHEKEZgWXaBWXfw of Action "EntryAccountingInvProcess_F43"
public static async Task<(RL_4e909af3a15d1687c03c789af38db7ae,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_F43.GetInvoiceAccountingProcessById", "21c9083e-9fb4-421c-8466-05976815977f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_F43.GetInvoiceAccountingProcessById", "21c9083e-9fb4-421c-8466-05976815977f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.rYX2JWFjvkSWL_Y3EVyVPA/NodesNotShownInESpaceTree.PgjJIbSfHEKEZgWXaBWXfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoiceaccountingprocess\".\"invoiceid\" o1, NULL o2, \"eninvoiceaccountingprocess\".\"offsetutc\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {InvoiceAccountingProcess} \"eninvoiceaccountingprocess\"");
whereBuilder.Append(" WHERE ");
if (qpinId != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess\".\"id\" = @qpinId) AND (\"eninvoiceaccountingprocess\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinId", DbType.Int64, qpinId);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess\".\"id\" IS NULL)");
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
RL_4e909af3a15d1687c03c789af38db7ae outParamList = new RL_4e909af3a15d1687c03c789af38db7ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_F43.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4e909af3a15d1687c03c789af38db7ae _tmp = new RL_4e909af3a15d1687c03c789af38db7ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_F43.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4e909af3a15d1687c03c789af38db7ae)_tmp;
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

private static async Task<RC_082bf66064d5a51dc7db708fe5577120> datasetGetFolioItemsByOrderMainIdReadDbAsync(RC_082bf66064d5a51dc7db708fe5577120 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByOrderMainId" PS_6PxvHFki7_c9JWwVHHw of Action "EntryAccountingInvProcess_F43"
public static async Task<(RL_0dc1085ad4cd06d01dea77860d02de63,long)> datasetGetFolioItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioItems_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_F43.GetFolioItemsByOrderMainId", "3ffa2f3d-c71b-4816-bbfd-cf495b05471f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_F43.GetFolioItemsByOrderMainId", "3ffa2f3d-c71b-4816-bbfd-cf495b05471f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.rYX2JWFjvkSWL_Y3EVyVPA/NodesNotShownInESpaceTree.PS_6PxvHFki7_c9JWwVHHw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingaccounts_servicetype\".\"id\" o0, \"enaccountingaccounts_servicetype\".\"cc\" o1, \"enaccountingaccounts_servicetype\".\"description\" o2, \"enaccountingaccounts_servicetype\".\"isactive\" o3, \"enaccountingaccounts_servicetype\".\"createdby\" o4, \"enaccountingaccounts_servicetype\".\"createdon\" o5, \"enaccountingaccounts_servicetype\".\"updatedby\" o6, \"enaccountingaccounts_servicetype\".\"updatedon\" o7, \"encostcentersap\".\"id\" o8, \"encostcentersap\".\"regionid\" o9, \"encostcentersap\".\"companyid\" o10, \"encostcentersap\".\"soc_\" o11, \"encostcentersap\".\"div_\" o12, \"encostcentersap\".\"area\" o13, \"encostcentersap\".\"ce_coste\" o14, \"encostcentersap\".\"cebe\" o15, \"encostcentersap\".\"denominacion\" o16, \"encostcentersap\".\"descripcion\" o17, \"encostcentersap\".\"responsable\" o18, \"encostcentersap\".\"ceco\" o19, \"encostcentersap\".\"costesprim_reales_ind_debloq\" o20, \"encostcentersap\".\"costessecund_reales_ind_debl\" o21, \"encostcentersap\".\"ingresosreales_ind_debloqueo\" o22, \"encostcentersap\".\"actualiz_comprom__ind_debloq\" o23, \"encostcentersap\".\"costesprimariosplan_ind_debl\" o24, \"encostcentersap\".\"costessecund_plan_ind_debloq\" o25, \"encostcentersap\".\"ingresosplan_ind_debloqueo_\" o26, \"encostcentersap\".\"autor\" o27, \"encostcentersap\".\"createdon\" o28, \"encostcentersap\".\"createdby\" o29, \"encostcentersap\".\"updatedon\" o30, \"encostcentersap\".\"updatedby\" o31, \"encostcentersap\".\"isactive\" o32, \"enfolioitems1\".\"id\" o33, \"enfolioitems1\".\"folioid\" o34, \"enfolioitems1\".\"ordermainitemid\" o35, \"enfolioitems1\".\"ordernumber\" o36, \"enfolioitems1\".\"articlenumber\" o37, \"enfolioitems1\".\"description\" o38, \"enfolioitems1\".\"inputationcode\" o39, \"enfolioitems1\".\"deliverydate\" o40, trim_scale(\"enfolioitems1\".\"invoiceqtt\"::numeric) o41, trim_scale(\"enfolioitems1\".\"remainingqtt\"::numeric) o42, trim_scale(\"enfolioitems1\".\"unitprice\"::numeric) o43, trim_scale(\"enfolioitems1\".\"totalprice\"::numeric) o44, trim_scale(\"enfolioitems1\".\"quantity\"::numeric) o45, \"enfolioitems1\".\"deliveryqtt\" o46, \"enfolioitems1\".\"importdelivery\" o47, \"enfolioitems1\".\"pep\" o48, \"enfolioitems1\".\"placeid\" o49, \"enfolioitems1\".\"placename\" o50, \"enordermainitem2\".\"id\" o51, \"enordermainitem2\".\"ordermainid\" o52, \"enordermainitem2\".\"position\" o53, \"enordermainitem2\".\"materialcode\" o54, \"enordermainitem2\".\"materialdescription\" o55, \"enordermainitem2\".\"assigmnentcode\" o56, \"enordermainitem2\".\"documentclassid\" o57, \"enordermainitem2\".\"deliverydate\" o58, trim_scale(\"enordermainitem2\".\"quantity\"::numeric) o59, \"enordermainitem2\".\"unittype\" o60, trim_scale(\"enordermainitem2\".\"unitprice\"::numeric) o61, \"enordermainitem2\".\"basequantity\" o62, \"enordermainitem2\".\"isdeleted\" o63, \"enordermainitem2\".\"isblocked\" o64, \"enordermainitem2\".\"isfinaldelivery\" o65, \"enordermainitem2\".\"glaccountid\" o66, \"enordermainitem2\".\"costcenterid\" o67, \"enordermainitem2\".\"fundscenter\" o68, \"enordermainitem2\".\"fund\" o69, \"enordermainitem2\".\"commitmentitem\" o70, \"enordermainitem2\".\"vatindicator\" o71, \"enordermainitem2\".\"vatprocedure\" o72, trim_scale(\"enordermainitem2\".\"vatrate\"::numeric) o73, \"enordermainitem2\".\"purchaserequisitionnumber\" o74, \"enordermainitem2\".\"purchaserequisitionitemnr\" o75, \"enordermainitem2\".\"regionid\" o76, \"enordermainitem2\".\"center\" o77, \"enordermainitem2\".\"pepelement\" o78, trim_scale(\"enordermainitem2\".\"quantitydelivered\"::numeric) o79, \"enordermainitem2\".\"orderunitofmeasure\" o80, \"enordermainitem2\".\"applicant\" o81, \"enordermainitem2\".\"direction\" o82, \"enordermainitem2\".\"contractnumber\" o83, \"enordermainitem2\".\"contractposition\" o84, \"enordermainitem2\".\"contractstartdate\" o85, \"enordermainitem2\".\"contractenddate\" o86, trim_scale(\"enordermainitem2\".\"contractplannedvalue\"::numeric) o87, \"enordermainitem2\".\"positiontype\" o88, \"enordermainitem2\".\"serialnumberprofile\" o89, \"enordermainitem2\".\"batchmanaged\" o90, \"enordermainitem2\".\"materialtype\" o91, \"enordermainitem2\".\"itemgroup\" o92, \"enordermainitem2\".\"orderrequestcreatorsapnumber\" o93, \"enordermainitem2\".\"ismultipleimputation\" o94, \"enordermainitem2\".\"invoiceusageid\" o95, \"enordermainitem2\".\"ordermainitemstatusid\" o96, \"enordermainitem2\".\"divisionid\" o97, \"enordermainitem2\".\"createdby\" o98, \"enordermainitem2\".\"createdon\" o99, \"enordermainitem2\".\"updatedby\" o100, \"enordermainitem2\".\"updatedon\" o101, \"enregion6\".\"id\" o102, \"enregion6\".\"code\" o103, \"enregion6\".\"name\" o104, \"enregion6\".\"divisionfi\" o105, \"enregion6\".\"centrortp\" o106, \"enregion6\".\"commissionregion\" o107, \"enregion6\".\"isactive\" o108, \"enregion6\".\"createdon\" o109, \"enregion6\".\"createdby\" o110, \"enregion6\".\"updatedon\" o111, \"enregion6\".\"updatedby\" o112, \"enregion6\".\"isfsp\" o113, \"enregion6\".\"isfcp\" o114");
fromBuilder.Append(" FROM (((({FolioItems} \"enfolioitems1\" Left JOIN {OrderMainItem} \"enordermainitem2\" ON (\"enfolioitems1\".\"ordermainitemid\" = \"enordermainitem2\".\"id\"))  Left JOIN {Region} \"enregion6\" ON (\"enordermainitem2\".\"divisionid\" = \"enregion6\".\"id\"))  Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype\" ON (\"enordermainitem2\".\"glaccountid\" = \"enaccountingaccounts_servicetype\".\"id\"))  Left JOIN {CostCenterSAP} \"encostcentersap\" ON (\"enordermainitem2\".\"costcenterid\" = \"encostcentersap\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioItems_FolioId != 0) {
whereBuilder.Append("((\"enfolioitems1\".\"folioid\" = @qpfoFolioItems_FolioId) AND (\"enfolioitems1\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioItems_FolioId", DbType.Int64, qpfoFolioItems_FolioId);
} else {
whereBuilder.Append("(\"enfolioitems1\".\"folioid\" IS NULL)");
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
RL_0dc1085ad4cd06d01dea77860d02de63 outParamList = new RL_0dc1085ad4cd06d01dea77860d02de63();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_F43.GetFolioItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0dc1085ad4cd06d01dea77860d02de63 _tmp = new RL_0dc1085ad4cd06d01dea77860d02de63();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_F43.GetFolioItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0dc1085ad4cd06d01dea77860d02de63)_tmp;
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

// Query Function "GetTaxToAdd" B1NVScrNDEiT+n0Yvps_Xw of Action "EntryAccountingInvProcess_F43"
public static async Task<(RL_9404dc36b913809894c7e4e44e8e1dd8,long)> datasetGetTaxToAdd(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_F43.GetTaxToAdd", "49555307-cdca-480c-93fa-7d18be9b3f5f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_F43.GetTaxToAdd", "49555307-cdca-480c-93fa-7d18be9b3f5f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.rYX2JWFjvkSWL_Y3EVyVPA/NodesNotShownInESpaceTree.B1NVScrNDEiT+n0Yvps_Xw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, trim_scale(\"eninvoiceextendedtax1\".\"importe\"::numeric) o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedTax} \"eninvoiceextendedtax1\"");
whereBuilder.Append(" WHERE (\"eninvoiceextendedtax1\".\"impuesto\" = '002') AND (\"eninvoiceextendedtax1\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("jP_W+pSpRESLV3Fw0NPgPQ"))).ssId);
whereBuilder.Append(") AND (\"eninvoiceextendedtax1\".\"tipofactor\" = 'Tasa') AND ");
if (qpinInvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendedtax1\".\"invoiceid\" = @qpinInvoiceId) AND (\"eninvoiceextendedtax1\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceId", DbType.Int64, qpinInvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendedtax1\".\"invoiceid\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_F43.GetTaxToAdd.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_F43.GetTaxToAdd.List", cancellationToken: cancellationToken);
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

private static async Task<RC_fba480f5c1b92eb8b15d33020b0023b5> datasetGetOrderAccConceptByIdReadDbAsync(RC_fba480f5c1b92eb8b15d33020b0023b5 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAdvancePaymentType.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
return rec;
}
// Query Function "GetOrderAccConceptById" WwExlrbFFUyIYpy6zKQXWg of Action "EntryAccountingInvProcess_F43"
public static async Task<(RL_b323e0bdf1fec18079c1034e78738762,long)> datasetGetOrderAccConceptById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConcepts_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_F43.GetOrderAccConceptById", "9631015b-c5b6-4c15-8862-9cbacca4175a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_F43.GetOrderAccConceptById", "9631015b-c5b6-4c15-8862-9cbacca4175a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.rYX2JWFjvkSWL_Y3EVyVPA/NodesNotShownInESpaceTree.WwExlrbFFUyIYpy6zKQXWg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enorderaccconcepts\".\"accountingdatatypeid\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enorderaccconcepts\".\"paymenttermid\" o12, \"enorderaccconcepts\".\"paymenttermcustomdays\" o13, NULL o14, \"enorderaccconcepts\".\"advancepaymenttypeid\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enpaymentterms2\".\"ctd_dias\" o22, \"enpaymentterms2\".\"estructuradescripcionprop\" o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28");
fromBuilder.Append(" FROM (({OrderAccConcepts} \"enorderaccconcepts\" Left JOIN {PaymentTerms} \"enpaymentterms2\" ON (\"enorderaccconcepts\".\"paymenttermid\" = \"enpaymentterms2\".\"id\"))  Left JOIN {AdvancePaymentType} \"enadvancepaymenttype\" ON (\"enorderaccconcepts\".\"advancepaymenttypeid\" = \"enadvancepaymenttype\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderAccConcepts_Id != 0) {
whereBuilder.Append("((\"enorderaccconcepts\".\"id\" = @qporOrderAccConcepts_Id) AND (\"enorderaccconcepts\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConcepts_Id", DbType.Int64, qporOrderAccConcepts_Id);
} else {
whereBuilder.Append("(\"enorderaccconcepts\".\"id\" IS NULL)");
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
RL_b323e0bdf1fec18079c1034e78738762 outParamList = new RL_b323e0bdf1fec18079c1034e78738762();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, false, false, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_F43.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b323e0bdf1fec18079c1034e78738762 _tmp = new RL_b323e0bdf1fec18079c1034e78738762();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderAccConceptByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_F43.GetOrderAccConceptById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b323e0bdf1fec18079c1034e78738762)_tmp;
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

private static async Task<RC_bd42fd4399da47c92c88d912cd87df67> datasetGetInvoiceByIdReadDbAsync(RC_bd42fd4399da47c92c88d912cd87df67 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENOrderAccounting.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENPaymentMethods.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceById" Swln9dRoeECzhHvAU4pfyA of Action "EntryAccountingInvProcess_F43"
public static async Task<(RL_72bc9c8db8dc80bec32b40b958e9af79,long)> datasetGetInvoiceById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoice_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_F43.GetInvoiceById", "f567094b-68d4-4078-b384-7bc0538a5fc8");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_F43.GetInvoiceById", "f567094b-68d4-4078-b384-7bc0538a5fc8", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.rYX2JWFjvkSWL_Y3EVyVPA/NodesNotShownInESpaceTree.Swln9dRoeECzhHvAU4pfyA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany1\".\"id\" o0, \"encompany1\".\"externalid\" o1, \"encompany1\".\"description\" o2, \"encompany1\".\"rfc\" o3, \"encompany1\".\"postalcode\" o4, \"encompany1\".\"cyaimport\" o5, \"encompany1\".\"fspuse\" o6, \"encompany1\".\"createdon\" o7, \"encompany1\".\"createdby\" o8, \"encompany1\".\"updatedon\" o9, \"encompany1\".\"updatedby\" o10, \"eninvoice6\".\"id\" o11, \"eninvoice6\".\"name\" o12, \"eninvoice6\".\"requisitionid\" o13, \"eninvoice6\".\"folioid\" o14, \"eninvoice6\".\"ordermainid\" o15, \"eninvoice6\".\"cfditypeid\" o16, trim_scale(\"eninvoice6\".\"totalamount\"::numeric) o17, \"eninvoice6\".\"currency\" o18, \"eninvoice6\".\"invoicestatusid\" o19, \"eninvoice6\".\"accountingdatetime\" o20, \"eninvoice6\".\"paymentdatetime\" o21, \"eninvoice6\".\"createdon\" o22, \"eninvoice6\".\"createdby\" o23, \"eninvoice6\".\"updatedon\" o24, \"eninvoice6\".\"updatedby\" o25, \"eninvoice6\".\"submittedon\" o26, \"eninvoice6\".\"isnewversion\" o27, \"eninvoice6\".\"id_poliza\" o28, \"eninvoice6\".\"id_poliza_sap\" o29, \"eninvoice6\".\"doc51\" o30, \"eninvoice6\".\"accountingerror\" o31, \"eninvoice6\".\"orderaccconceptsid\" o32, trim_scale(\"eninvoice6\".\"amortization\"::numeric) o33, \"eninvoice6\".\"creditnoteinvoiceid\" o34, \"eninvoiceextended2\".\"id\" o35, \"eninvoiceextended2\".\"version\" o36, \"eninvoiceextended2\".\"folio\" o37, \"eninvoiceextended2\".\"serie\" o38, \"eninvoiceextended2\".\"fechaemision\" o39, \"eninvoiceextended2\".\"formapago\" o40, \"eninvoiceextended2\".\"metodopago\" o41, \"eninvoiceextended2\".\"lugarexpedicion\" o42, trim_scale(\"eninvoiceextended2\".\"subtotal\"::numeric) o43, trim_scale(\"eninvoiceextended2\".\"descuento\"::numeric) o44, trim_scale(\"eninvoiceextended2\".\"totaliva\"::numeric) o45, trim_scale(\"eninvoiceextended2\".\"retenciones\"::numeric) o46, trim_scale(\"eninvoiceextended2\".\"total\"::numeric) o47, \"eninvoiceextended2\".\"tipocomprobante\" o48, \"eninvoiceextended2\".\"moneda\" o49, trim_scale(\"eninvoiceextended2\".\"tipocambio\"::numeric) o50, \"eninvoiceextended2\".\"usocfdi\" o51, \"eninvoiceextended2\".\"exportacion\" o52, \"eninvoiceextended2\".\"uuid\" o53, \"enorderaccounting\".\"id\" o54, \"enorderaccounting\".\"orderid\" o55, \"enorderaccounting\".\"hasestim_equal_agrepaym_depr\" o56, \"enorderaccounting\".\"hassettlement_depr\" o57, \"enorderaccounting\".\"hascreditnote_depr\" o58, \"enorderaccounting\".\"hasvoucher_depr\" o59, \"enorderaccounting\".\"hasspecialpostdeliveryauth\" o60, \"enorderaccounting\".\"specialpostdeliveryauthid\" o61, trim_scale(\"enorderaccounting\".\"amount_deprec\"::numeric) o62, \"enorderaccounting\".\"currencyid_deprec\" o63, \"enorderaccounting\".\"paymentmethodid_deprec\" o64, \"enorderaccounting\".\"paymenttermid_deprec\" o65, trim_scale(\"enorderaccounting\".\"negociatedexchangerateacc\"::numeric) o66, \"enorderaccounting\".\"exchangeratecomment\" o67, \"enorderaccounting\".\"evidencefileid\" o68, \"enorderaccounting\".\"hascontract\" o69, \"enorderaccounting\".\"hasrepse\" o70, \"enorderaccounting\".\"haspaymentsupplement\" o71, \"enorderaccounting\".\"hasnoticeofpaymentsuspension\" o72, \"enorderdetail1\".\"orderid\" o73, \"enorderdetail1\".\"isapprovalfromuserarea\" o74, \"enorderdetail1\".\"projectassetserviceid\" o75, \"enorderdetail1\".\"projectassetservice\" o76, \"enorderdetail1\".\"projectdescription\" o77, \"enorderdetail1\".\"businessvaluecategoryid\" o78, \"enorderdetail1\".\"businessvaluesubcategoryid\" o79, \"enorderdetail1\".\"paymenttermsid\" o80, \"enorderdetail1\".\"paymentmethodid\" o81, trim_scale(\"enorderdetail1\".\"negotiatedexchangerate\"::numeric) o82, \"enorderdetail1\".\"contractstatus\" o83, \"enorderdetail1\".\"dateofcommitment\" o84, \"enorderdetail1\".\"hasdeposit\" o85, \"enorderdetail1\".\"hasinsurance\" o86, \"enorderdetail1\".\"distributionid\" o87, \"enorderdetail1\".\"hasadvancepayment\" o88, trim_scale(\"enorderdetail1\".\"retentionrate\"::numeric) o89, \"enorderdetail1\".\"hasbasedate\" o90, \"enorderdetail1\".\"startbasedate\" o91, \"enorderdetail1\".\"endbasedate\" o92, \"enorderdetail1\".\"contractnumber\" o93, \"enorderdetail1\".\"isretentionapplied\" o94, \"enorderdetail1\".\"frequency\" o95, \"enorderdetail1\".\"period\" o96, \"enorderdetail1\".\"orderretentiontypeid\" o97, \"enorderdetail1\".\"paymentoptionsid\" o98, \"enorderdetail1\".\"paymentwaysid\" o99, \"enorderdetail1\".\"orderscontract\" o100, trim_scale(\"enorderdetail1\".\"contractamount\"::numeric) o101, trim_scale(\"enorderdetail1\".\"contracttarif\"::numeric) o102, \"enorderdetail1\".\"contractsupplier\" o103, \"enorderdetail1\".\"isdependentfromfolios\" o104, \"enorderdetail1\".\"specialapprovalid\" o105, \"enorderdetail1\".\"createdby\" o106, \"enorderdetail1\".\"createdon\" o107, \"enorderdetail1\".\"updatedby\" o108, \"enorderdetail1\".\"updatedon\" o109, \"enorderdetail1\".\"allcontactfilesvalidated\" o110, \"enorderdetail1\".\"hasntrequestdocuments\" o111, \"enordermain9\".\"id\" o112, \"enordermain9\".\"ordernumber\" o113, \"enordermain9\".\"orderdate\" o114, \"enordermain9\".\"orderstatusid\" o115, \"enordermain9\".\"previousorderstatusid\" o116, \"enordermain9\".\"assignmentcode\" o117, \"enordermain9\".\"supplierid\" o118, \"enordermain9\".\"companyid\" o119, \"enordermain9\".\"documenttypeid\" o120, \"enordermain9\".\"currencyid\" o121, \"enordermain9\".\"telceldirectionid\" o122, \"enordermain9\".\"procurementgroup\" o123, \"enordermain9\".\"creatorsapnumber\" o124, \"enordermain9\".\"creatorsapname\" o125, \"enordermain9\".\"country\" o126, \"enordermain9\".\"isdeleted\" o127, \"enordermain9\".\"isreleased\" o128, trim_scale(\"enordermain9\".\"exchangerate\"::numeric) o129, \"enordermain9\".\"sustainabilitycategory\" o130, \"enordermain9\".\"sustainabilitysubcategory\" o131, trim_scale(\"enordermain9\".\"totalamount\"::numeric) o132, \"enordermain9\".\"fromcosmoz\" o133, \"enordermain9\".\"regionid\" o134, \"enordermain9\".\"divisionid\" o135, \"enordermain9\".\"applicant\" o136, \"enordermain9\".\"createdby\" o137, \"enordermain9\".\"createdon\" o138, \"enordermain9\".\"updatedby\" o139, \"enordermain9\".\"updatedon\" o140, \"enpaymentmethods1\".\"id\" o141, \"enpaymentmethods1\".\"description\" o142, \"enpaymentmethods1\".\"externalid\" o143, \"enpaymentmethods1\".\"isfcp\" o144, \"enpaymentmethods1\".\"createdon\" o145, \"enpaymentmethods1\".\"createdby\" o146, \"enpaymentmethods1\".\"updatedon\" o147, \"enpaymentmethods1\".\"updatedby\" o148, \"enpaymentmethods1\".\"isactive\" o149, \"enproject_asset_service\".\"id\" o150, \"enproject_asset_service\".\"description\" o151, \"enproject_asset_service\".\"isothers\" o152, \"enproject_asset_service\".\"createdon\" o153, \"enproject_asset_service\".\"createdby\" o154, \"enproject_asset_service\".\"updatedon\" o155, \"enproject_asset_service\".\"updatedby\" o156, \"enregion7\".\"id\" o157, \"enregion7\".\"code\" o158, \"enregion7\".\"name\" o159, \"enregion7\".\"divisionfi\" o160, \"enregion7\".\"centrortp\" o161, \"enregion7\".\"commissionregion\" o162, \"enregion7\".\"isactive\" o163, \"enregion7\".\"createdon\" o164, \"enregion7\".\"createdby\" o165, \"enregion7\".\"updatedon\" o166, \"enregion7\".\"updatedby\" o167, \"enregion7\".\"isfsp\" o168, \"enregion7\".\"isfcp\" o169, \"ensupplier5\".\"id\" o170, \"ensupplier5\".\"tratamiento\" o171, \"ensupplier5\".\"name\" o172, \"ensupplier5\".\"number\" o173, \"ensupplier5\".\"conceptobusq_1_2\" o174, \"ensupplier5\".\"calle_numero\" o175, \"ensupplier5\".\"distrito\" o176, \"ensupplier5\".\"codigopostal_pobl_\" o177, \"ensupplier5\".\"pais\" o178, \"ensupplier5\".\"region_\" o179, \"ensupplier5\".\"idioma\" o180, \"ensupplier5\".\"telefono\" o181, \"ensupplier5\".\"extension\" o182, \"ensupplier5\".\"fax\" o183, \"ensupplier5\".\"cliente\" o184, \"ensupplier5\".\"soc_glasociada\" o185, \"ensupplier5\".\"clavedegrupo\" o186, \"ensupplier5\".\"n_ident_fis_1\" o187, \"ensupplier5\".\"personafisica\" o188, \"ensupplier5\".\"ramo\" o189, \"ensupplier5\".\"grupodeporte\" o190, \"ensupplier5\".\"email\" o191, \"ensupplier5\".\"isactive\" o192, \"ensupplier5\".\"createdon\" o193, \"ensupplier5\".\"createdby\" o194, \"ensupplier5\".\"updatedon\" o195, \"ensupplier5\".\"updatedby\" o196, \"ensupplier5\".\"regionid\" o197");
fromBuilder.Append(" FROM ((((((((({Invoice} \"eninvoice6\" Left JOIN {InvoiceExtended} \"eninvoiceextended2\" ON (\"eninvoice6\".\"id\" = \"eninvoiceextended2\".\"id\"))  Left JOIN {OrderMain} \"enordermain9\" ON (\"eninvoice6\".\"ordermainid\" = \"enordermain9\".\"id\"))  Left JOIN {Company} \"encompany1\" ON (\"enordermain9\".\"companyid\" = \"encompany1\".\"id\"))  Left JOIN {Supplier} \"ensupplier5\" ON (\"enordermain9\".\"supplierid\" = \"ensupplier5\".\"id\"))  Left JOIN {Region} \"enregion7\" ON (\"enordermain9\".\"regionid\" = \"enregion7\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail1\" ON (\"enordermain9\".\"id\" = \"enorderdetail1\".\"orderid\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service\" ON (\"enorderdetail1\".\"projectassetserviceid\" = \"enproject_asset_service\".\"id\"))  Left JOIN {OrderAccounting} \"enorderaccounting\" ON (\"enordermain9\".\"id\" = \"enorderaccounting\".\"orderid\"))  Left JOIN {PaymentMethods} \"enpaymentmethods1\" ON (\"enorderdetail1\".\"paymentmethodid\" = \"enpaymentmethods1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoice_Id != 0) {
whereBuilder.Append("((\"eninvoice6\".\"id\" = @qpinInvoice_Id) AND (\"eninvoice6\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoice_Id", DbType.Int64, qpinInvoice_Id);
} else {
whereBuilder.Append("(\"eninvoice6\".\"id\" IS NULL)");
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
RL_72bc9c8db8dc80bec32b40b958e9af79 outParamList = new RL_72bc9c8db8dc80bec32b40b958e9af79();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[9] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_F43.GetInvoiceById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_72bc9c8db8dc80bec32b40b958e9af79 _tmp = new RL_72bc9c8db8dc80bec32b40b958e9af79();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_F43.GetInvoiceById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_72bc9c8db8dc80bec32b40b958e9af79)_tmp;
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
