namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceTaxesRetentionRules_ByInvoiceId : VarsBag {
public long inParamInvoiceId;
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate9 =  new Actions.lcoLogsAccountingCreate();
public RL_203255693769e898ae6969552ca60cf6 resListFilterRule4_3_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate8 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate6 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate5 =  new Actions.lcoLogsAccountingCreate();
public RL_203255693769e898ae6969552ca60cf6 queryResGetItemRetentionsByInvoiceId_outParamList = new RL_203255693769e898ae6969552ca60cf6();
public long queryResGetItemRetentionsByInvoiceId_outParamCount = 0L;

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule4_2_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule3_1_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule5_2_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule7_3_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule5_3_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public RL_203255693769e898ae6969552ca60cf6 resListFilterRule3_2_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule4_1_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule3_3_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate10 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate7 =  new Actions.lcoLogsAccountingCreate();
public RL_203255693769e898ae6969552ca60cf6 resListFilterRule7_2_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 queryResGetTrasladosByInvoiceId_outParamList = new RL_203255693769e898ae6969552ca60cf6();
public long queryResGetTrasladosByInvoiceId_outParamCount = 0L;

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule6_2_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule6_1_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate11 =  new Actions.lcoLogsAccountingCreate();
public RL_203255693769e898ae6969552ca60cf6 resListFilterRule1_1_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule7_1_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule5_1_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public RL_203255693769e898ae6969552ca60cf6 resListFilterRule2_1_outParamFilteredList = new RL_203255693769e898ae6969552ca60cf6();

public lcvInvoiceTaxesRetentionRules_ByInvoiceId(long inParamInvoiceId) {
this.inParamInvoiceId = inParamInvoiceId;
}
}
public class lcoInvoiceTaxesRetentionRules_ByInvoiceId : VarsBag {
public RL_725bda958021cd78431a036d1def2d7e outParamRetentionsActivationList = new RL_725bda958021cd78431a036d1def2d7e();

public bool outParamIsToCancel = false;

public lcoInvoiceTaxesRetentionRules_ByInvoiceId() {
}
}
/// <summary>
/// Action <code>InvoiceTaxesRetentionRules_ByInvoiceId</code> that represents the Service Studio
///  action <code>InvoiceTaxesRetentionRules_ByInvoiceId</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_725bda958021cd78431a036d1def2d7e,bool)> ActionInvoiceTaxesRetentionRules_ByInvoiceId(IRequestContext requestContext,long inParamInvoiceId,CancellationToken cancellationToken) {
RL_725bda958021cd78431a036d1def2d7e outParamRetentionsActivationList = default;
bool outParamIsToCancel = default;
lcoInvoiceTaxesRetentionRules_ByInvoiceId result = new lcoInvoiceTaxesRetentionRules_ByInvoiceId();
lcvInvoiceTaxesRetentionRules_ByInvoiceId localVars = new lcvInvoiceTaxesRetentionRules_ByInvoiceId(inParamInvoiceId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceTaxesRetentionRules_ByInvoiceId", "d9e1868b-9e9c-4e2a-9bd1-7cb8723f285c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceTaxesRetentionRules_ByInvoiceId", "d9e1868b-9e9c-4e2a-9bd1-7cb8723f285c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetItemRetentionsByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetItemRetentionsByInvoiceId_maxRecords = 0;
int datasetGetItemRetentionsByInvoiceId_startIndex = 0;(localVars.queryResGetItemRetentionsByInvoiceId_outParamList,localVars.queryResGetItemRetentionsByInvoiceId_outParamCount) = await FuncActionInvoiceTaxesRetentionRules_ByInvoiceId.datasetGetItemRetentionsByInvoiceId(requestContext,datasetGetItemRetentionsByInvoiceId_maxRecords,datasetGetItemRetentionsByInvoiceId_startIndex,IterationMultiplicity.Multiple,localVars.inParamInvoiceId,cancellationToken);

// empty
if((!(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.Empty))) {
// Query datasetGetTrasladosByInvoiceId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTrasladosByInvoiceId_maxRecords = 0;
int datasetGetTrasladosByInvoiceId_startIndex = 0;(localVars.queryResGetTrasladosByInvoiceId_outParamList,localVars.queryResGetTrasladosByInvoiceId_outParamCount) = await FuncActionInvoiceTaxesRetentionRules_ByInvoiceId.datasetGetTrasladosByInvoiceId(requestContext,datasetGetTrasladosByInvoiceId_maxRecords,datasetGetTrasladosByInvoiceId_startIndex,IterationMultiplicity.Multiple,localVars.inParamInvoiceId,cancellationToken);

// ListFilterRule3_1
localVars.resListFilterRule3_1_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.1m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule3_2
localVars.resListFilterRule3_2_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002"), cancellationToken)));

// ListFilterRule3_3
localVars.resListFilterRule3_3_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetTrasladosByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.16m)&&(localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 3
if(((((!localVars.resListFilterRule3_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule3_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule3_3_outParamFilteredList.Empty)))) {
// C1_
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "C1", ssWT_WITHCD = "C1", ssWT_SUBJCT = "X" },cancellationToken);

// R1_
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "R1", ssWT_WITHCD = "R1", ssWT_SUBJCT = "X" },cancellationToken);

// A6
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "A6", ssWT_WITHCD = "A6", ssWT_SUBJCT = "X" },cancellationToken);

// V6
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "V6", ssWT_WITHCD = "V6", ssWT_SUBJCT = "X" },cancellationToken);

// LogsAccountingCreate7
localVars.resLogsAccountingCreate7.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "3. C1, R1, A6, V6", ssDescription = ((((((((localVars.resListFilterRule3_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule3_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule3_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" | ")+localVars.resListFilterRule3_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule3_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule4_1
localVars.resListFilterRule4_1_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetTrasladosByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.16m)&&(localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// ListFilterRule4_2
localVars.resListFilterRule4_2_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.0125m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule4_3
localVars.resListFilterRule4_3_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota!=0.04m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 4
if(((((!localVars.resListFilterRule4_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule4_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule4_3_outParamFilteredList.Empty)))) {
// F5x2
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "F5", ssWT_WITHCD = "F5", ssWT_SUBJCT = "X" },cancellationToken);

// F6x2
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "F6", ssWT_WITHCD = "F6", ssWT_SUBJCT = "X" },cancellationToken);

// A6x4
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "A6", ssWT_WITHCD = "A6", ssWT_SUBJCT = "X" },cancellationToken);

// V6x4
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "V6", ssWT_WITHCD = "V6", ssWT_SUBJCT = "X" },cancellationToken);

// LogsAccountingCreate8
localVars.resLogsAccountingCreate8.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "4. F5, F6, A6, V6", ssDescription = ((((((((((localVars.resListFilterRule4_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule4_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule4_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule4_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule4_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule4_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule5_1
localVars.resListFilterRule5_1_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetTrasladosByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.08m)&&(localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// ListFilterRule5_2
localVars.resListFilterRule5_2_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.0125m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule5_3
localVars.resListFilterRule5_3_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota!=0.04m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 5
if(((((!localVars.resListFilterRule5_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule5_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule5_3_outParamFilteredList.Empty)))) {
// F5x3
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "F5", ssWT_WITHCD = "F5", ssWT_SUBJCT = "X" },cancellationToken);

// F6x3
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "F6", ssWT_WITHCD = "F6", ssWT_SUBJCT = "X" },cancellationToken);

// B6x5
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "B6", ssWT_WITHCD = "B6", ssWT_SUBJCT = "X" },cancellationToken);

// Y6x5
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "Y6", ssWT_WITHCD = "Y6", ssWT_SUBJCT = "X" },cancellationToken);

// LogsAccountingCreate9
localVars.resLogsAccountingCreate9.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "5. F5, F6, B6, Y6", ssDescription = ((((((((((localVars.resListFilterRule5_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule5_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule5_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule5_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule5_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule5_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule6_1
localVars.resListFilterRule6_1_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.0125m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule6_2
localVars.resListFilterRule6_2_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.04m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 6
if((((!localVars.resListFilterRule6_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule6_2_outParamFilteredList.Empty)))) {
// B1
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "B1", ssWT_WITHCD = "B1", ssWT_SUBJCT = "X" },cancellationToken);

// T1
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "T1", ssWT_WITHCD = "T1", ssWT_SUBJCT = "X" },cancellationToken);

// G7
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "G7", ssWT_WITHCD = "G7", ssWT_SUBJCT = "X" },cancellationToken);

// G8
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "G8", ssWT_WITHCD = "G8", ssWT_SUBJCT = "X" },cancellationToken);

// LogsAccountingCreate10
localVars.resLogsAccountingCreate10.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "6. B1, T1, G7, G8", ssDescription = ((((((localVars.resListFilterRule6_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule6_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule6_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule6_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule7_1
localVars.resListFilterRule7_1_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.1m)&&(localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule7_2
localVars.resListFilterRule7_2_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002"), cancellationToken)));

// ListFilterRule7_3
localVars.resListFilterRule7_3_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetTrasladosByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => ((localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002")&&(localVars.queryResGetTrasladosByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.08m)), cancellationToken)));

// rule 7
if(((((!localVars.resListFilterRule7_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule7_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule7_3_outParamFilteredList.Empty)))) {
// C1
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "C1", ssWT_WITHCD = "C1", ssWT_SUBJCT = "X" },cancellationToken);

// R1
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "R1", ssWT_WITHCD = "R1", ssWT_SUBJCT = "X" },cancellationToken);

// B6
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "B6", ssWT_WITHCD = "B6", ssWT_SUBJCT = "X" },cancellationToken);

// Y6
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "Y6", ssWT_WITHCD = "Y6", ssWT_SUBJCT = "X" },cancellationToken);

// LogsAccountingCreate11
localVars.resLogsAccountingCreate11.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "7. C1, R1, B6, Y6", ssDescription = ((((((((((localVars.resListFilterRule7_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule7_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule7_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule7_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule7_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule7_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule1_1
localVars.resListFilterRule1_1_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="002"), cancellationToken)));

// rule 1
if((((!localVars.resListFilterRule1_1_outParamFilteredList.Empty)&&(localVars.resListFilterRule1_1_outParamFilteredList.Length==localVars.queryResGetItemRetentionsByInvoiceId_outParamList.Length)))) {
// B1x
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "B1", ssWT_WITHCD = "B1", ssWT_SUBJCT = "X" },cancellationToken);

// T1x
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "T1", ssWT_WITHCD = "T1", ssWT_SUBJCT = "X" },cancellationToken);

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "1. B1, T1", ssDescription = localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule2_1
localVars.resListFilterRule2_1_outParamFilteredList = (((RL_203255693769e898ae6969552ca60cf6)await  localVars.queryResGetItemRetentionsByInvoiceId_outParamList.FilterAsync(async (p, cancellationToken) => (localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto=="001"), cancellationToken)));

// rule 2
if((((!localVars.resListFilterRule2_1_outParamFilteredList.Empty)&&(localVars.resListFilterRule2_1_outParamFilteredList.Length==localVars.queryResGetItemRetentionsByInvoiceId_outParamList.Length)))) {
// G5
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "G5", ssWT_WITHCD = "G5", ssWT_SUBJCT = "X" },cancellationToken);

// G6
await ExtendedActions.ListAppend(requestContext,result.outParamRetentionsActivationList,new ST_57edec30140ebe846267970253841d11Structure(){ ssWITHT = "G6", ssWT_WITHCD = "G6", ssWT_SUBJCT = "X" },cancellationToken);

// LogsAccountingCreate6
localVars.resLogsAccountingCreate6.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "2. G5, G6", ssDescription = localVars.queryResGetItemRetentionsByInvoiceId_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// LogsAccountingCreate5
localVars.resLogsAccountingCreate5.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Fin de verificar reglas de retencion", ssDescription = "No es posible identificar las retenciones", ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

// IsToCancel = True
result.outParamIsToCancel=true;
}

}

}

}

}

}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamRetentionsActivationList = result.outParamRetentionsActivationList;
outParamIsToCancel = result.outParamIsToCancel;
} // inner-finally
RETURN_STATEMENT:
return (outParamRetentionsActivationList,outParamIsToCancel);
}

public static class FuncActionInvoiceTaxesRetentionRules_ByInvoiceId {

private static async Task<RC_25d357c844d16eb6579210aff3596f77> datasetGetItemRetentionsByInvoiceIdReadDbAsync(RC_25d357c844d16eb6579210aff3596f77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceExtendedItem.Read( r, ref index);
rec.ssENInvoiceExtendedItemTax.Read( r, ref index);
return rec;
}
// Query Function "GetItemRetentionsByInvoiceId" hvd4METLekqmF8cGr9078w of Action "InvoiceTaxesRetentionRules_ByInvoiceId"
public static async Task<(RL_203255693769e898ae6969552ca60cf6,long)> datasetGetItemRetentionsByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItem_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceTaxesRetentionRules_ByInvoiceId.GetItemRetentionsByInvoiceId", "3078f786-cb44-4a7a-a617-c706afdd3bf3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceTaxesRetentionRules_ByInvoiceId.GetItemRetentionsByInvoiceId", "3078f786-cb44-4a7a-a617-c706afdd3bf3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.i4bh2ZyeKk6b0Xy4cj8oXA/NodesNotShownInESpaceTree.hvd4METLekqmF8cGr9078w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditem2\".\"id\" o0, \"eninvoiceextendeditem2\".\"invoiceid\" o1, \"eninvoiceextendeditem2\".\"productnumber\" o2, \"eninvoiceextendeditem2\".\"description\" o3, \"eninvoiceextendeditem2\".\"materialcode\" o4, \"eninvoiceextendeditem2\".\"quantity\" o5, trim_scale(\"eninvoiceextendeditem2\".\"unityprice\"::numeric) o6, \"eninvoiceextendeditem2\".\"currency\" o7, \"eninvoiceextendeditemtax5\".\"id\" o8, \"eninvoiceextendeditemtax5\".\"invoiceextendeditemid\" o9, \"eninvoiceextendeditemtax5\".\"invoicetaxtypeid\" o10, \"eninvoiceextendeditemtax5\".\"impuesto\" o11, trim_scale(\"eninvoiceextendeditemtax5\".\"base\"::numeric) o12, trim_scale(\"eninvoiceextendeditemtax5\".\"tasaocuota\"::numeric) o13, trim_scale(\"eninvoiceextendeditemtax5\".\"importe\"::numeric) o14, \"eninvoiceextendeditemtax5\".\"tipofactor\" o15");
fromBuilder.Append(" FROM ({InvoiceExtendedItem} \"eninvoiceextendeditem2\" Left JOIN {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax5\" ON (\"eninvoiceextendeditem2\".\"id\" = \"eninvoiceextendeditemtax5\".\"invoiceextendeditemid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItem_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem2\".\"invoiceid\" = @qpinInvoiceExtendedItem_InvoiceId) AND (\"eninvoiceextendeditem2\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItem_InvoiceId", DbType.Int64, qpinInvoiceExtendedItem_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem2\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendeditemtax5\".\"invoicetaxtypeid\" = ");
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
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceTaxesRetentionRules_ByInvoiceId.GetItemRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceTaxesRetentionRules_ByInvoiceId.GetItemRetentionsByInvoiceId.List", cancellationToken: cancellationToken);
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

private static async Task<RC_25d357c844d16eb6579210aff3596f77> datasetGetTrasladosByInvoiceIdReadDbAsync(RC_25d357c844d16eb6579210aff3596f77 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoiceExtendedItem.Read( r, ref index);
rec.ssENInvoiceExtendedItemTax.Read( r, ref index);
return rec;
}
// Query Function "GetTrasladosByInvoiceId" kD_QsUTplkS045FXf8Esvw of Action "InvoiceTaxesRetentionRules_ByInvoiceId"
public static async Task<(RL_203255693769e898ae6969552ca60cf6,long)> datasetGetTrasladosByInvoiceId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItem_InvoiceId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceTaxesRetentionRules_ByInvoiceId.GetTrasladosByInvoiceId", "b1d03f90-e944-4496-b4e3-91577fc12cbf");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceTaxesRetentionRules_ByInvoiceId.GetTrasladosByInvoiceId", "b1d03f90-e944-4496-b4e3-91577fc12cbf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.i4bh2ZyeKk6b0Xy4cj8oXA/NodesNotShownInESpaceTree.kD_QsUTplkS045FXf8Esvw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceextendeditem3\".\"id\" o0, \"eninvoiceextendeditem3\".\"invoiceid\" o1, \"eninvoiceextendeditem3\".\"productnumber\" o2, \"eninvoiceextendeditem3\".\"description\" o3, \"eninvoiceextendeditem3\".\"materialcode\" o4, \"eninvoiceextendeditem3\".\"quantity\" o5, trim_scale(\"eninvoiceextendeditem3\".\"unityprice\"::numeric) o6, \"eninvoiceextendeditem3\".\"currency\" o7, \"eninvoiceextendeditemtax6\".\"id\" o8, \"eninvoiceextendeditemtax6\".\"invoiceextendeditemid\" o9, \"eninvoiceextendeditemtax6\".\"invoicetaxtypeid\" o10, \"eninvoiceextendeditemtax6\".\"impuesto\" o11, trim_scale(\"eninvoiceextendeditemtax6\".\"base\"::numeric) o12, trim_scale(\"eninvoiceextendeditemtax6\".\"tasaocuota\"::numeric) o13, trim_scale(\"eninvoiceextendeditemtax6\".\"importe\"::numeric) o14, \"eninvoiceextendeditemtax6\".\"tipofactor\" o15");
fromBuilder.Append(" FROM ({InvoiceExtendedItem} \"eninvoiceextendeditem3\" Left JOIN {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax6\" ON (\"eninvoiceextendeditem3\".\"id\" = \"eninvoiceextendeditemtax6\".\"invoiceextendeditemid\")) ");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItem_InvoiceId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditem3\".\"invoiceid\" = @qpinInvoiceExtendedItem_InvoiceId) AND (\"eninvoiceextendeditem3\".\"invoiceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItem_InvoiceId", DbType.Int64, qpinInvoiceExtendedItem_InvoiceId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditem3\".\"invoiceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendeditemtax6\".\"invoicetaxtypeid\" = ");
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
RL_203255693769e898ae6969552ca60cf6 outParamList = new RL_203255693769e898ae6969552ca60cf6();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetTrasladosByInvoiceIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceTaxesRetentionRules_ByInvoiceId.GetTrasladosByInvoiceId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_203255693769e898ae6969552ca60cf6 _tmp = new RL_203255693769e898ae6969552ca60cf6();
_tmp.AlternateReadDbMethodAsync = datasetGetTrasladosByInvoiceIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceTaxesRetentionRules_ByInvoiceId.GetTrasladosByInvoiceId.List", cancellationToken: cancellationToken);
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



}


}
