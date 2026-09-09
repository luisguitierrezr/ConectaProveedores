namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccountingInvProcess_GetRetentions : VarsBag {
public long inParamInvoiceAccountingProcessId;
/// <summary>
/// Variable <code>InvoiceAccountingProcess</code> that represents the Service Studio
///  InvoiceAccountingProcess <code>InvoiceAccountingProcess</code> <p>Description: </p>
/// </summary>
public EN_d21666375df829d28ffce8e5e0a3400dEntityRecord varLcInvoiceAccountingProcess = new EN_d21666375df829d28ffce8e5e0a3400dEntityRecord();

/// <summary>
/// Variable <code>InvoiceName</code> that represents the Service Studio Text <code>InvoiceName</code>
///  <p>Description: </p>
/// </summary>
public string varLcInvoiceName = "";

/// <summary>
/// Variable <code>l_StartedOn</code> that represents the Service Studio DateTime
///  <code>l_StartedOn</code> <p>Description: </p>
/// </summary>
public DateTime varLcl_StartedOn = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);

public RL_203255693769e898ae6969552ca60cf6 queryResGetItemRetentionsByInvoiceId_outParamList = new RL_203255693769e898ae6969552ca60cf6();
public long queryResGetItemRetentionsByInvoiceId_outParamCount = 0L;

public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate8 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public RL_4b72a47efbb84d37cf5e3e0ffb46314d resListFilter_outParamFilteredList = new RL_4b72a47efbb84d37cf5e3e0ffb46314d();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate5 =  new Actions.lcoLogsAccountingCreate();
public ST_b29967856499aeaa8c796dc87fe4c6e8Structure resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = new ST_b29967856499aeaa8c796dc87fe4c6e8Structure();

public RL_079c863bfa7218132c4b01aab39a9575 queryResGetInvoiceAccountingProcessById_outParamList = new RL_079c863bfa7218132c4b01aab39a9575();
public long queryResGetInvoiceAccountingProcessById_outParamCount = 0L;

public ST_24353ddcec93ac51b13ce9ab94fe4001Structure resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse = new ST_24353ddcec93ac51b13ce9ab94fe4001Structure();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate6 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate9 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate4 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoActionTimestampsCreateOrUpdate resActionTimestampsCreateOrUpdate7 =  new Actions.lcoActionTimestampsCreateOrUpdate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoInvoiceTaxesRetentionRulesReset resInvoiceTaxesRetentionRulesReset =  new Actions.lcoInvoiceTaxesRetentionRulesReset();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public lcvEntryAccountingInvProcess_GetRetentions(long inParamInvoiceAccountingProcessId) {
this.inParamInvoiceAccountingProcessId = inParamInvoiceAccountingProcessId;
}
}
public class lcoEntryAccountingInvProcess_GetRetentions : VarsBag {
public bool outParamIsSuccess = true;

public string outParamMessage = "";

public bool outParamCanTryAgain = false;

public bool outParamIsServiceError = true;

public RL_725bda958021cd78431a036d1def2d7e outParamRetentionsCall2List = new RL_725bda958021cd78431a036d1def2d7e();

public lcoEntryAccountingInvProcess_GetRetentions() {
}
}
/// <summary>
/// Action <code>EntryAccountingInvProcess_GetRetentions</code> that represents the Service Studio
///  action <code>EntryAccountingInvProcess_GetRetentions</code> <p> Description: Call the service
/// s before accounting</p>
/// </summary>
public static async Task<(bool,string,bool,bool,RL_725bda958021cd78431a036d1def2d7e)> ActionEntryAccountingInvProcess_GetRetentions(IRequestContext requestContext,long inParamInvoiceAccountingProcessId,CancellationToken cancellationToken) {
bool outParamIsSuccess = default;
string outParamMessage = default;
bool outParamCanTryAgain = default;
bool outParamIsServiceError = default;
RL_725bda958021cd78431a036d1def2d7e outParamRetentionsCall2List = default;
lcoEntryAccountingInvProcess_GetRetentions result = new lcoEntryAccountingInvProcess_GetRetentions();
lcvEntryAccountingInvProcess_GetRetentions localVars = new lcvEntryAccountingInvProcess_GetRetentions(inParamInvoiceAccountingProcessId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccountingInvProcess_GetRetentions", "e2aca7b1-d7fa-49b8-b1c9-9e92124b2d90"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccountingInvProcess_GetRetentions", "e2aca7b1-d7fa-49b8-b1c9-9e92124b2d90", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ActionTimestampsCreateOrUpdate9
localVars.resActionTimestampsCreateOrUpdate9.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Accounting started"), ssStartedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// SetCurrentLocale
await ExtendedActions.SetCurrentLocale(requestContext,"es-MX",cancellationToken);

// Query datasetGetInvoiceAccountingProcessById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoiceAccountingProcessById_maxRecords = 1;
if (datasetGetInvoiceAccountingProcessById_maxRecords < 1) datasetGetInvoiceAccountingProcessById_maxRecords = 1;
int datasetGetInvoiceAccountingProcessById_startIndex = 0;(localVars.queryResGetInvoiceAccountingProcessById_outParamList,localVars.queryResGetInvoiceAccountingProcessById_outParamCount) = await FuncActionEntryAccountingInvProcess_GetRetentions.datasetGetInvoiceAccountingProcessById(requestContext,datasetGetInvoiceAccountingProcessById_maxRecords,datasetGetInvoiceAccountingProcessById_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceAccountingProcessId,cancellationToken);

// IsSuccess = True
result.outParamIsSuccess=true;

// InvoiceAccountingProcess = GetInvoiceAccountingProcessById.List.Current.InvoiceAccountingProcess
localVars.varLcInvoiceAccountingProcess=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess;

// CanTryAgain = InvoiceAccountingProcess.NextTry < 3
result.outParamCanTryAgain=(localVars.varLcInvoiceAccountingProcess.ssNextTry<3);

// InvoiceName = GetInvoiceAccountingProcessById.List.Current.Invoice.Name
localVars.varLcInvoiceName=localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName;

// InvoiceAccountingProcess.NextTry = InvoiceAccountingProcess.NextTry + 1
localVars.varLcInvoiceAccountingProcess.ssNextTry = (localVars.varLcInvoiceAccountingProcess.ssNextTry+1);
// LogsAccountingCreate4
localVars.resLogsAccountingCreate4.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("FCP Before Contab - Retentions Invoice "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ("SUPPLIER COUNTRY: "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssPais), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// foreigner
if((!((localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssPais!="MX")))) {
// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// Query datasetGetItemRetentionsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetItemRetentionsByInvoiceId_maxRecords = 1;
if (datasetGetItemRetentionsByInvoiceId_maxRecords < 1) datasetGetItemRetentionsByInvoiceId_maxRecords = 1;
int datasetGetItemRetentionsByInvoiceId_startIndex = 0;(localVars.queryResGetItemRetentionsByInvoiceId_outParamList,localVars.queryResGetItemRetentionsByInvoiceId_outParamCount) = await FuncActionEntryAccountingInvProcess_GetRetentions.datasetGetItemRetentionsByInvoiceId(requestContext,datasetGetItemRetentionsByInvoiceId_maxRecords,datasetGetItemRetentionsByInvoiceId_startIndex,IterationMultiplicity.Never,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssId,cancellationToken);

// LogsAccountingCreate5
localVars.resLogsAccountingCreate5.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("FCP Before Contab - Retentions Invoice "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ("HAS RETENTIONS: "+((!localVars.queryResGetItemRetentionsByInvoiceId_outParamList.Empty) ? "True" : "False")), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// Call_ZMXFAPMF_CONSUL_RETENPROV
localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFAPMF_CONSUL_RETENPROV(requestContext,new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure(){ ssPI_BUKRS = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId, ssPI_VENDORNO = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber },cancellationToken);

// ActionTimestampsCreateOrUpdate7
localVars.resActionTimestampsCreateOrUpdate7.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Get active retentions"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// consult error?
if((((localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssPO_RESPUESTA=="")&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = Call_ZMXFAPMF_CONSUL_RETENPROV.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssPO_RESPUESTA;
} else {
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_4b72a47efbb84d37cf5e3e0ffb46314d)await  localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out.FilterAsync(async (p, cancellationToken) => (p.ssWT_SUBJCT=="X"), cancellationToken)));

// empty
if((!((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.Empty&&localVars.resListFilter_outParamFilteredList.Empty)))) {
// InvoiceTaxesRetentionRulesReset
(localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List,localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List,localVars.resInvoiceTaxesRetentionRulesReset.outParamIsToCancel) = await Actions.ActionInvoiceTaxesRetentionRulesReset(requestContext,localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoiceAccountingProcess.ssInvoiceId,(await RL_725bda958021cd78431a036d1def2d7e.ConvertAsync(localVars.resCall_ZMXFAPMF_CONSUL_RETENPROV_outParamResponse.ssTI_RETENCIONES_Out, new RL_725bda958021cd78431a036d1def2d7e(), async (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure source, ST_57edec30140ebe846267970253841d11Structure target, CancellationToken cancellationToken) => {
target.ssWITHT = source.ssWITHT;
target.ssWT_WITHCD = source.ssWT_WITHCD;
target.ssWT_SUBJCT = source.ssWT_SUBJCT;
return target;
}, cancellationToken)),cancellationToken);

// retentions cancel?
if((localVars.resInvoiceTaxesRetentionRulesReset.outParamIsToCancel)) {
// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "INVALID RETENTIONS"
result.outParamMessage=AppUtils.GetStringResource("WuIEZ9rtd0yfoXQ5YvbdwQ#Value.164728574.1", "INVALID RETENTIONS");

// CanTryAgain = False
result.outParamCanTryAgain=false;

// IsServiceError = False
result.outParamIsServiceError=false;
} else {
// LogsAccountingCreate6
localVars.resLogsAccountingCreate6.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("FCP Before Contab - Retentions Invoice "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ("Nr Retentions to call: "+Convert.ToString(localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List.Length)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// has retentions
if(((!localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List.Empty))) {
// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("FCP Before Contab - Retentions Invoice "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ((((("PI_BUKRS "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId)+" // PI_VENDORNO ")+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber)+"// RETENCION 1 ")+localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List.CurrentRec.ssWITHT), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// l_StartedOn = CurrDateTime
localVars.varLcl_StartedOn=BuiltInFunction.CurrDateTime ();
// Call_ZMXFFIMF_INSERT_UPDROV
localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_INSERT_UPDROV(requestContext,new ST_90ad61a7b6c3b8dc6db7b1d64798236bStructure(){ ssPI_BUKRS = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENCompany.ssExternalId, ssPI_VENDORNO = localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENSupplier.ssNumber, ssTI_RETENCIONES_In = localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall1List },cancellationToken);

// ActionTimestampsCreateOrUpdate8
localVars.resActionTimestampsCreateOrUpdate8.outParamId = await Actions.ActionActionTimestampsCreateOrUpdate(requestContext,new EN_b22d64c90281d09a316b6f4502a74326EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssDescription = (("FCP ProcessId: "+BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceAccountingProcessId))+" - Call active retentions"), ssStartedOn = localVars.varLcl_StartedOn, ssFinishedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// IsSuccess = Index <> -1
result.outParamIsSuccess=(BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, "S -", 0, false, false)!=(-1));

// Message = Call_ZMXFFIMF_INSERT_UPDROV.Response.PO_RESPUESTA
result.outParamMessage=localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA;
// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = ("FCP Before Contab - Retentions Invoice "+localVars.queryResGetInvoiceAccountingProcessById_outParamList.CurrentRec.ssENInvoice.ssName), ssDescription = ("RESPUESTA "+BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_INSERT_UPDROV_outParamResponse.ssPO_RESPUESTA, 0, 50)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

}

// IsSuccess = IsSuccess or IsActiveSkipAccountingError
result.outParamIsSuccess=(result.outParamIsSuccess||((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))));
// activation error?
if((!((!result.outParamIsSuccess)))) {
// RetentionsCall2List = InvoiceTaxesRetentionRulesReset.RetentionsCall2List
result.outParamRetentionsCall2List=localVars.resInvoiceTaxesRetentionRulesReset.outParamRetentionsCall2List;
}

}

}

}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler

// IsSuccess = False
result.outParamIsSuccess=false;

// Message = "Error in contabilization service. Please contact an administrator."
result.outParamMessage=AppUtils.GetStringResource("P29zeogNOUmPIwL09brNIQ#Value.1045336240.1", "Error in contabilization service. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamIsSuccess = result.outParamIsSuccess;
outParamMessage = result.outParamMessage;
outParamCanTryAgain = result.outParamCanTryAgain;
outParamIsServiceError = result.outParamIsServiceError;
outParamRetentionsCall2List = result.outParamRetentionsCall2List;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamIsSuccess,outParamMessage,outParamCanTryAgain,outParamIsServiceError,outParamRetentionsCall2List);
}

public static class FuncActionEntryAccountingInvProcess_GetRetentions {

private static async Task<RC_25d357c844d16eb6579210aff3596f77> datasetGetItemRetentionsByInvoiceIdReadDbAsync(RC_25d357c844d16eb6579210aff3596f77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceExtendedItem.Read( r, ref index);
rec.ssENInvoiceExtendedItemTax.Read( r, ref index);
return rec;
}
// Query Function "GetItemRetentionsByInvoiceId" xbVPJmC3L0maiKXfk6jMbw of Action "EntryAccountingInvProcess_GetRetentions"
public static async Task<(RL_203255693769e898ae6969552ca60cf6,long)> datasetGetItemRetentionsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItem_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_GetRetentions.GetItemRetentionsByInvoiceId", "264fb5c5-b760-492f-9a88-a5df93a8cc6f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_GetRetentions.GetItemRetentionsByInvoiceId", "264fb5c5-b760-492f-9a88-a5df93a8cc6f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.saes4vrXuEmxyZ6SEkstkA/NodesNotShownInESpaceTree.xbVPJmC3L0maiKXfk6jMbw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15");
fromBuilder.Append(" FROM ({InvoiceExtendedItem} \"eninvoiceextendeditem4\" Left JOIN {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax7\" ON (\"eninvoiceextendeditem4\".\"id\" = \"eninvoiceextendeditemtax7\".\"invoiceextendeditemid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItem_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem4\".\"invoiceid\" = @qpinInvoiceExtendedItem_InvoiceId) AND (\"eninvoiceextendeditem4\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItem_InvoiceId", DbType.Int64, qpinInvoiceExtendedItem_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem4\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendeditemtax7\".\"invoicetaxtypeid\" = ");
whereBuilder.Append((ENInvoiceTaxTypeEntity.GetRecordByKey(ObjectKey.Parse("j+r6kWcflkqOJAI7RtHJBQ"))).ssId);
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
RL_203255693769e898ae6969552ca60cf6 outParamList = new RL_203255693769e898ae6969552ca60cf6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetItemRetentionsByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_GetRetentions.GetItemRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_203255693769e898ae6969552ca60cf6 _tmp = new RL_203255693769e898ae6969552ca60cf6();
_tmp.AlternateReadDbMethodAsync = datasetGetItemRetentionsByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_GetRetentions.GetItemRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_203255693769e898ae6969552ca60cf6)_tmp;
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

private static async Task<RC_dd31a6c81d63b4e265f3c3d56e3eabb8> datasetGetInvoiceAccountingProcessByIdReadDbAsync(RC_dd31a6c81d63b4e265f3c3d56e3eabb8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccountingProcess.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetInvoiceAccountingProcessById" 27zugvN8b0WEVgAuoXQVEw of Action "EntryAccountingInvProcess_GetRetentions"
public static async Task<(RL_079c863bfa7218132c4b01aab39a9575,long)> datasetGetInvoiceAccountingProcessById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceAccountingProcess_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccountingInvProcess_GetRetentions.GetInvoiceAccountingProcessById", "82eebcdb-7cf3-456f-8456-002ea1741513");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccountingInvProcess_GetRetentions.GetInvoiceAccountingProcessById", "82eebcdb-7cf3-456f-8456-002ea1741513", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.saes4vrXuEmxyZ6SEkstkA/NodesNotShownInESpaceTree.27zugvN8b0WEVgAuoXQVEw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany13\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"eninvoice68\".\"id\" o11, \"eninvoice68\".\"name\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, \"eninvoiceaccountingprocess8\".\"invoiceid\" o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceaccountingprocess8\".\"nexttry\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, \"ensupplier46\".\"number\" o76, NULL o77, NULL o78, NULL o79, NULL o80, \"ensupplier46\".\"pais\" o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100");
fromBuilder.Append(" FROM (((({InvoiceAccountingProcess} \"eninvoiceaccountingprocess8\" Left JOIN {Invoice} \"eninvoice68\" ON (\"eninvoiceaccountingprocess8\".\"invoiceid\" = \"eninvoice68\".\"id\"))  Left JOIN {OrderMain} \"enordermain58\" ON (\"eninvoice68\".\"ordermainid\" = \"enordermain58\".\"id\"))  Left JOIN {Supplier} \"ensupplier46\" ON (\"enordermain58\".\"supplierid\" = \"ensupplier46\".\"id\"))  Left JOIN {Company} \"encompany13\" ON (\"enordermain58\".\"companyid\" = \"encompany13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceAccountingProcess_Id != 0) {
whereBuilder.Append("((\"eninvoiceaccountingprocess8\".\"id\" = @qpinInvoiceAccountingProcess_Id) AND (\"eninvoiceaccountingprocess8\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceAccountingProcess_Id", DbType.Int64, qpinInvoiceAccountingProcess_Id);
} else {
whereBuilder.Append("(\"eninvoiceaccountingprocess8\".\"id\" IS NULL)");
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
RL_079c863bfa7218132c4b01aab39a9575 outParamList = new RL_079c863bfa7218132c4b01aab39a9575();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccountingInvProcess_GetRetentions.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_079c863bfa7218132c4b01aab39a9575 _tmp = new RL_079c863bfa7218132c4b01aab39a9575();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoiceAccountingProcessByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccountingInvProcess_GetRetentions.GetInvoiceAccountingProcessById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_079c863bfa7218132c4b01aab39a9575)_tmp;
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
