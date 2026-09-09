namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceTaxesRetentionRules_ByItem : VarsBag {
public long inParamInvoiceExtendedItemId;
public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule5_1_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate10 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate9 =  new Actions.lcoLogsAccountingCreate();
public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule4_2_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule6_2_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule4_1_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule1_1_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule6_1_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule5_2_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule3_3_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule2_1_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule3_1_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate7 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate8 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate11 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate6 =  new Actions.lcoLogsAccountingCreate();
public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule3_2_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae queryResGetRetentionsByItem_outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
public long queryResGetRetentionsByItem_outParamCount = 0L;

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule7_3_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule5_3_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae queryResGetTrasladosByItem_outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
public long queryResGetTrasladosByItem_outParamCount = 0L;

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule7_2_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule7_1_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public RL_5b975f6376260cc87a4dc39e570700ae resListFilterRule4_3_outParamFilteredList = new RL_5b975f6376260cc87a4dc39e570700ae();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate5 =  new Actions.lcoLogsAccountingCreate();
public lcvInvoiceTaxesRetentionRules_ByItem(long inParamInvoiceExtendedItemId) {
this.inParamInvoiceExtendedItemId = inParamInvoiceExtendedItemId;
}
}
public class lcoInvoiceTaxesRetentionRules_ByItem : VarsBag {
public RL_f2d9c802fb1adc89fda1ad392c027309 outParamTI_WXD_InList = new RL_f2d9c802fb1adc89fda1ad392c027309();

public bool outParamIsToCancel = false;

public lcoInvoiceTaxesRetentionRules_ByItem() {
}
}
/// <summary>
/// Action <code>InvoiceTaxesRetentionRules_ByItem</code> that represents the Service Studio action
///  <code>InvoiceTaxesRetentionRules_ByItem</code> <p> Description: </p>
/// </summary>
public static async Task<(RL_f2d9c802fb1adc89fda1ad392c027309,bool)> ActionInvoiceTaxesRetentionRules_ByItem(IRequestContext requestContext,long inParamInvoiceExtendedItemId,CancellationToken cancellationToken) {
RL_f2d9c802fb1adc89fda1ad392c027309 outParamTI_WXD_InList = default;
bool outParamIsToCancel = default;
lcoInvoiceTaxesRetentionRules_ByItem result = new lcoInvoiceTaxesRetentionRules_ByItem();
lcvInvoiceTaxesRetentionRules_ByItem localVars = new lcvInvoiceTaxesRetentionRules_ByItem(inParamInvoiceExtendedItemId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceTaxesRetentionRules_ByItem", "2fa077f2-07a3-43b2-9792-7fb3a49b0aa1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceTaxesRetentionRules_ByItem", "2fa077f2-07a3-43b2-9792-7fb3a49b0aa1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRetentionsByItem
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRetentionsByItem_maxRecords = 0;
int datasetGetRetentionsByItem_startIndex = 0;(localVars.queryResGetRetentionsByItem_outParamList,localVars.queryResGetRetentionsByItem_outParamCount) = await FuncActionInvoiceTaxesRetentionRules_ByItem.datasetGetRetentionsByItem(requestContext,datasetGetRetentionsByItem_maxRecords,datasetGetRetentionsByItem_startIndex,IterationMultiplicity.Multiple,localVars.inParamInvoiceExtendedItemId,cancellationToken);

// empty
if((!(localVars.queryResGetRetentionsByItem_outParamList.Empty))) {
// Query datasetGetTrasladosByItem
cancellationToken.ThrowIfCancellationRequested();
int datasetGetTrasladosByItem_maxRecords = 0;
int datasetGetTrasladosByItem_startIndex = 0;(localVars.queryResGetTrasladosByItem_outParamList,localVars.queryResGetTrasladosByItem_outParamCount) = await FuncActionInvoiceTaxesRetentionRules_ByItem.datasetGetTrasladosByItem(requestContext,datasetGetTrasladosByItem_maxRecords,datasetGetTrasladosByItem_startIndex,IterationMultiplicity.Multiple,localVars.inParamInvoiceExtendedItemId,cancellationToken);

// ListFilterRule3_1
localVars.resListFilterRule3_1_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.1m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule3_2
localVars.resListFilterRule3_2_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceExtendedItemTax.ssImpuesto=="002"), cancellationToken)));

// ListFilterRule3_3
localVars.resListFilterRule3_3_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetTrasladosByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.16m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 3
if(((((!localVars.resListFilterRule3_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule3_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule3_3_outParamFilteredList.Empty)))) {
// C1_
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "C1", ssWI_TAX_CODE = "C1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// R1_
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "R1", ssWI_TAX_CODE = "R1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// A6
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "A6", ssWI_TAX_CODE = "A6", ssWI_TAX_BASE = localVars.resListFilterRule3_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// V6
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "V6", ssWI_TAX_CODE = "V6", ssWI_TAX_BASE = localVars.resListFilterRule3_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// LogsAccountingCreate7
localVars.resLogsAccountingCreate7.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "3. C1, R1, A6, V6", ssDescription = ((((((((localVars.resListFilterRule3_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule3_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule3_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" | ")+localVars.resListFilterRule3_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule3_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule4_1
localVars.resListFilterRule4_1_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetTrasladosByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.16m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// ListFilterRule4_2
localVars.resListFilterRule4_2_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.0125m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule4_3
localVars.resListFilterRule4_3_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota!=0.04m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 4
if(((((!localVars.resListFilterRule4_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule4_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule4_3_outParamFilteredList.Empty)))) {
// F5x2
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "F5", ssWI_TAX_CODE = "F5", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// F6x2
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "F6", ssWI_TAX_CODE = "F6", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// A6x4
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "A6", ssWI_TAX_CODE = "A6", ssWI_TAX_BASE = localVars.resListFilterRule4_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// V6x4
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "V6", ssWI_TAX_CODE = "V6", ssWI_TAX_BASE = localVars.resListFilterRule4_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// LogsAccountingCreate8
localVars.resLogsAccountingCreate8.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "4. F5, F6, A6, V6", ssDescription = ((((((((((localVars.resListFilterRule4_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule4_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule4_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule4_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule4_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule4_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule5_1
localVars.resListFilterRule5_1_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetTrasladosByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.08m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// ListFilterRule5_2
localVars.resListFilterRule5_2_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.0125m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule5_3
localVars.resListFilterRule5_3_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota!=0.04m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 5
if(((((!localVars.resListFilterRule5_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule5_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule5_3_outParamFilteredList.Empty)))) {
// F5x3
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "F5", ssWI_TAX_CODE = "F5", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// F6x3
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "F6", ssWI_TAX_CODE = "F6", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// B6x5
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "B6", ssWI_TAX_CODE = "B6", ssWI_TAX_BASE = localVars.resListFilterRule5_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// Y6x5
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "Y6", ssWI_TAX_CODE = "Y6", ssWI_TAX_BASE = localVars.resListFilterRule5_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// LogsAccountingCreate9
localVars.resLogsAccountingCreate9.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "5. F5, F6, B6, Y6", ssDescription = ((((((((((localVars.resListFilterRule5_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule5_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule5_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule5_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule5_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule5_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule6_1
localVars.resListFilterRule6_1_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.0125m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule6_2
localVars.resListFilterRule6_2_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.04m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="002")), cancellationToken)));

// rule 6
if((((!localVars.resListFilterRule6_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule6_2_outParamFilteredList.Empty)))) {
// B1
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "B1", ssWI_TAX_CODE = "B1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// T1
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "T1", ssWI_TAX_CODE = "T1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// G7
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "G7", ssWI_TAX_CODE = "G7", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// G8
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "G8", ssWI_TAX_CODE = "G8", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// LogsAccountingCreate10
localVars.resLogsAccountingCreate10.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "6. B1, T1, G7, G8", ssDescription = ((((((localVars.resListFilterRule6_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule6_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule6_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule6_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule7_1
localVars.resListFilterRule7_1_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.1m)&&(p.ssENInvoiceExtendedItemTax.ssImpuesto=="001")), cancellationToken)));

// ListFilterRule7_2
localVars.resListFilterRule7_2_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceExtendedItemTax.ssImpuesto=="002"), cancellationToken)));

// ListFilterRule7_3
localVars.resListFilterRule7_3_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetTrasladosByItem_outParamList.FilterAsync(async (p, cancellationToken) => ((p.ssENInvoiceExtendedItemTax.ssImpuesto=="002")&&(p.ssENInvoiceExtendedItemTax.ssTasaOCuota==0.08m)), cancellationToken)));

// rule 7
if(((((!localVars.resListFilterRule7_1_outParamFilteredList.Empty)&&(!localVars.resListFilterRule7_2_outParamFilteredList.Empty))&&(!localVars.resListFilterRule7_3_outParamFilteredList.Empty)))) {
// C1
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "C1", ssWI_TAX_CODE = "C1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// R1
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "R1", ssWI_TAX_CODE = "R1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// B6
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "B6", ssWI_TAX_CODE = "B6", ssWI_TAX_BASE = localVars.resListFilterRule7_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// Y6
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "Y6", ssWI_TAX_CODE = "Y6", ssWI_TAX_BASE = localVars.resListFilterRule7_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImporte },cancellationToken);

// LogsAccountingCreate11
localVars.resLogsAccountingCreate11.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "7. C1, R1, B6, Y6", ssDescription = ((((((((((localVars.resListFilterRule7_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule7_1_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule7_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule7_2_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota))+" | ")+localVars.resListFilterRule7_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto)+" - ")+BuiltInFunction.DecimalToText(localVars.resListFilterRule7_3_outParamFilteredList.CurrentRec.ssENInvoiceExtendedItemTax.ssTasaOCuota)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule1_1
localVars.resListFilterRule1_1_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceExtendedItemTax.ssImpuesto=="002"), cancellationToken)));

// rule 1
if((((!localVars.resListFilterRule1_1_outParamFilteredList.Empty)&&(localVars.resListFilterRule1_1_outParamFilteredList.Length==localVars.queryResGetRetentionsByItem_outParamList.Length)))) {
// B1x
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "B1", ssWI_TAX_CODE = "B1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// T1x
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "T1", ssWI_TAX_CODE = "T1", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "1. B1, T1", ssDescription = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

} else {
// ListFilterRule2_1
localVars.resListFilterRule2_1_outParamFilteredList = (((RL_5b975f6376260cc87a4dc39e570700ae)await  localVars.queryResGetRetentionsByItem_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENInvoiceExtendedItemTax.ssImpuesto=="001"), cancellationToken)));

// rule 2
if((((!localVars.resListFilterRule2_1_outParamFilteredList.Empty)&&(localVars.resListFilterRule2_1_outParamFilteredList.Length==localVars.queryResGetRetentionsByItem_outParamList.Length)))) {
// G5
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "G5", ssWI_TAX_CODE = "G5", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// G6
await ExtendedActions.ListAppend(requestContext,result.outParamTI_WXD_InList,new ST_a8dbb50321f7e9ee99b69f05907922f9Structure(){ ssWI_TAX_TYPE = "G6", ssWI_TAX_CODE = "G6", ssWI_TAX_BASE = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssBase },cancellationToken);

// LogsAccountingCreate6
localVars.resLogsAccountingCreate6.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "2. G5, G6", ssDescription = localVars.queryResGetRetentionsByItem_outParamList.CurrentRec.ssENInvoiceExtendedItemTax.ssImpuesto, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("MrwNippcb0yd3p9+9UP4UQ"))).ssId },cancellationToken);

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
outParamTI_WXD_InList = result.outParamTI_WXD_InList;
outParamIsToCancel = result.outParamIsToCancel;
} // inner-finally
RETURN_STATEMENT:
return (outParamTI_WXD_InList,outParamIsToCancel);
}

public static class FuncActionInvoiceTaxesRetentionRules_ByItem {

// Query Function "GetRetentionsByItem" 53CLcZMOjUm1KFeI4FbR3w of Action "InvoiceTaxesRetentionRules_ByItem"
public static async Task<(RL_5b975f6376260cc87a4dc39e570700ae,long)> datasetGetRetentionsByItem(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceTaxesRetentionRules_ByItem.GetRetentionsByItem", "718b70e7-0e93-498d-b528-5788e056d1df");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceTaxesRetentionRules_ByItem.GetRetentionsByItem", "718b70e7-0e93-498d-b528-5788e056d1df", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.8negL6MHskOXkn+zpJsKoQ/NodesNotShownInESpaceTree.53CLcZMOjUm1KFeI4FbR3w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"eninvoiceextendeditemtax\".\"impuesto\" o3, trim_scale(\"eninvoiceextendeditemtax\".\"base\"::numeric) o4, trim_scale(\"eninvoiceextendeditemtax\".\"tasaocuota\"::numeric) o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItemId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditemtax\".\"invoiceextendeditemid\" = @qpinInvoiceExtendedItemId) AND (\"eninvoiceextendeditemtax\".\"invoiceextendeditemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItemId", DbType.Int64, qpinInvoiceExtendedItemId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditemtax\".\"invoiceextendeditemid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendeditemtax\".\"invoicetaxtypeid\" = ");
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
RL_5b975f6376260cc87a4dc39e570700ae outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceTaxesRetentionRules_ByItem.GetRetentionsByItem.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5b975f6376260cc87a4dc39e570700ae _tmp = new RL_5b975f6376260cc87a4dc39e570700ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceTaxesRetentionRules_ByItem.GetRetentionsByItem.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5b975f6376260cc87a4dc39e570700ae)_tmp;
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

// Query Function "GetTrasladosByItem" abhwmb7zZEu3ALIwXTPoTw of Action "InvoiceTaxesRetentionRules_ByItem"
public static async Task<(RL_5b975f6376260cc87a4dc39e570700ae,long)> datasetGetTrasladosByItem(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpinInvoiceExtendedItemId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("InvoiceTaxesRetentionRules_ByItem.GetTrasladosByItem", "9970b869-f3be-4b64-b700-b2305d33e84f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("InvoiceTaxesRetentionRules_ByItem.GetTrasladosByItem", "9970b869-f3be-4b64-b700-b2305d33e84f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.8negL6MHskOXkn+zpJsKoQ/NodesNotShownInESpaceTree.abhwmb7zZEu3ALIwXTPoTw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"eninvoiceextendeditemtax1\".\"impuesto\" o3, NULL o4, trim_scale(\"eninvoiceextendeditemtax1\".\"tasaocuota\"::numeric) o5, trim_scale(\"eninvoiceextendeditemtax1\".\"importe\"::numeric) o6, NULL o7");
fromBuilder.Append(" FROM {InvoiceExtendedItemTax} \"eninvoiceextendeditemtax1\"");
whereBuilder.Append(" WHERE ");
if (qpinInvoiceExtendedItemId != 0) {
whereBuilder.Append("((\"eninvoiceextendeditemtax1\".\"invoiceextendeditemid\" = @qpinInvoiceExtendedItemId) AND (\"eninvoiceextendeditemtax1\".\"invoiceextendeditemid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceExtendedItemId", DbType.Int64, qpinInvoiceExtendedItemId);
} else {
whereBuilder.Append("(\"eninvoiceextendeditemtax1\".\"invoiceextendeditemid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceextendeditemtax1\".\"invoicetaxtypeid\" = ");
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
RL_5b975f6376260cc87a4dc39e570700ae outParamList = new RL_5b975f6376260cc87a4dc39e570700ae();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, false, false, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query InvoiceTaxesRetentionRules_ByItem.GetTrasladosByItem.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5b975f6376260cc87a4dc39e570700ae _tmp = new RL_5b975f6376260cc87a4dc39e570700ae();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query InvoiceTaxesRetentionRules_ByItem.GetTrasladosByItem.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5b975f6376260cc87a4dc39e570700ae)_tmp;
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
