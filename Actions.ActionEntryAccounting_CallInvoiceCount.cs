namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccounting_CallInvoiceCount : VarsBag {
public RL_af9a0ce202ec088a3c6de60c469b7bc6 inParamFolioItems;
public long inParamOrderMainId;
public string inParamOrderNumber;
public RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData;
public decimal inParamTaxToAdd;
public string inParamIVAIndicator;
public decimal inParamExchange;
public string inParamPaymentMethodExternalId;
public string inParamPaymentTermDescrip;
public int inParamPaymentTermDays;
public int inParamOffsetUtc;
public decimal inParamTaxToApply;
/// <summary>
/// Variable <code>Count</code> that represents the Service Studio Integer <code>Count</code>
///  <p>Description: </p>
/// </summary>
public int varLcCount = 1;

/// <summary>
/// Variable <code>TI_ITEM_InList</code> that represents the Service Studio TI_ITEM_InList
///  <code>TI_ITEM_InList</code> <p>Description: </p>
/// </summary>
public RL_1c06eebb48d1b54a899c0d33bdf93a52 varLcTI_ITEM_InList = new RL_1c06eebb48d1b54a899c0d33bdf93a52();

/// <summary>
/// Variable <code>TI_WXD_InList</code> that represents the Service Studio TI_WXD_InList
///  <code>TI_WXD_InList</code> <p>Description: </p>
/// </summary>
public RL_f2d9c802fb1adc89fda1ad392c027309 varLcTI_WXD_InList = new RL_f2d9c802fb1adc89fda1ad392c027309();

/// <summary>
/// Variable <code>TotalFolioValue</code> that represents the Service Studio Decimal
///  <code>TotalFolioValue</code> <p>Description: </p>
/// </summary>
public decimal varLcTotalFolioValue = 0.0M;

/// <summary>
/// Variable <code>PI_BUS_AREA</code> that represents the Service Studio Text <code>PI_BUS_AREA</code>
///  <p>Description: </p>
/// </summary>
public string varLcPI_BUS_AREA = "";

/// <summary>
/// Variable <code>PI_COMP_CODE</code> that represents the Service Studio Text
///  <code>PI_COMP_CODE</code> <p>Description: </p>
/// </summary>
public string varLcPI_COMP_CODE = "";

/// <summary>
/// Variable <code>PI_DB_CR_IND</code> that represents the Service Studio Text
///  <code>PI_DB_CR_IND</code> <p>Description: </p>
/// </summary>
public string varLcPI_DB_CR_IND = "";

/// <summary>
/// Variable <code>PI_GL_ACCOUNT</code> that represents the Service Studio Text
///  <code>PI_GL_ACCOUNT</code> <p>Description: </p>
/// </summary>
public string varLcPI_GL_ACCOUNT = "";

/// <summary>
/// Variable <code>PI_INVOICE_DOC_ITEM</code> that represents the Service Studio Integer
///  <code>PI_INVOICE_DOC_ITEM</code> <p>Description: </p>
/// </summary>
public int varLcPI_INVOICE_DOC_ITEM = 0;

/// <summary>
/// Variable <code>PI_ITEM_AMOUNT</code> that represents the Service Studio Decimal
///  <code>PI_ITEM_AMOUNT</code> <p>Description: </p>
/// </summary>
public decimal varLcPI_ITEM_AMOUNT = 0.0M;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate8 =  new Actions.lcoLogsAccountingCreate();
public RL_c9f6aa71e71ab2513c8b708a5c8313ba queryResGetFolioSAPDataByFolioId_outParamList = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
public long queryResGetFolioSAPDataByFolioId_outParamCount = 0L;

public Actions.lcoGetCustomSettingsAccounting resGetCustomSettingsAccounting =  new Actions.lcoGetCustomSettingsAccounting();
public Actions.lcoEntryAccounting_GetRetentions resEntryAccounting_GetRetentions =  new Actions.lcoEntryAccounting_GetRetentions();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate6 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public RL_a492f6700ed5395e4cd6d4e3942ae398 queryResGetOrderApprovalLevels_outParamList = new RL_a492f6700ed5395e4cd6d4e3942ae398();
public long queryResGetOrderApprovalLevels_outParamCount = 0L;

public ST_926df962559a6c34055113c885aa4885Structure resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse = new ST_926df962559a6c34055113c885aa4885Structure();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate10 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoGetNextMonday resGetNextMonday =  new Actions.lcoGetNextMonday();
public RL_c8bbb75c7d09bde1f237fa0b721125bc queryResGetOrderMainById_outParamList = new RL_c8bbb75c7d09bde1f237fa0b721125bc();
public long queryResGetOrderMainById_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate5 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate9 =  new Actions.lcoLogsAccountingCreate();
public lcvEntryAccounting_CallInvoiceCount(RL_af9a0ce202ec088a3c6de60c469b7bc6 inParamFolioItems, long inParamOrderMainId, string inParamOrderNumber, RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData, decimal inParamTaxToAdd, string inParamIVAIndicator, decimal inParamExchange, string inParamPaymentMethodExternalId, string inParamPaymentTermDescrip, int inParamPaymentTermDays, int inParamOffsetUtc, decimal inParamTaxToApply) {
this.inParamFolioItems = inParamFolioItems;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamOrderNumber = inParamOrderNumber;
this.inParamInvoiceData = inParamInvoiceData;
this.inParamTaxToAdd = inParamTaxToAdd;
this.inParamIVAIndicator = inParamIVAIndicator;
this.inParamExchange = inParamExchange;
this.inParamPaymentMethodExternalId = inParamPaymentMethodExternalId;
this.inParamPaymentTermDescrip = inParamPaymentTermDescrip;
this.inParamPaymentTermDays = inParamPaymentTermDays;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParamTaxToApply = inParamTaxToApply;
}
}
public class lcoEntryAccounting_CallInvoiceCount : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoEntryAccounting_CallInvoiceCount() {
}
}
/// <summary>
/// Action <code>EntryAccounting_CallInvoiceCount</code> that represents the Service Studio action
///  <code>EntryAccounting_CallInvoiceCount</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionEntryAccounting_CallInvoiceCount(IRequestContext requestContext,RL_af9a0ce202ec088a3c6de60c469b7bc6 inParamFolioItems,long inParamOrderMainId,string inParamOrderNumber,RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData,decimal inParamTaxToAdd,string inParamIVAIndicator,decimal inParamExchange,string inParamPaymentMethodExternalId,string inParamPaymentTermDescrip,int inParamPaymentTermDays,int inParamOffsetUtc,decimal inParamTaxToApply,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoEntryAccounting_CallInvoiceCount result = new lcoEntryAccounting_CallInvoiceCount();
lcvEntryAccounting_CallInvoiceCount localVars = new lcvEntryAccounting_CallInvoiceCount(inParamFolioItems, inParamOrderMainId, inParamOrderNumber, inParamInvoiceData, inParamTaxToAdd, inParamIVAIndicator, inParamExchange, inParamPaymentMethodExternalId, inParamPaymentTermDescrip, inParamPaymentTermDays, inParamOffsetUtc, inParamTaxToApply);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccounting_CallInvoiceCount", "3124f8f1-56ec-4184-9939-ecd80d769377"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccounting_CallInvoiceCount", "3124f8f1-56ec-4184-9939-ecd80d769377", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// LogsAccountingCreate6
localVars.resLogsAccountingCreate6.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call_ZMXFFIMF_CONTA_FACTURAS", ssDescription = (((((((((((("RE "+"X")+" // PPD: ")+localVars.inParamInvoiceData.ssENInvoice.ssCurrency)+BuiltInFunction.FormatDateTime (BuiltInFunction.CurrDate (), "dd.MM.yyyy"))+" // PayMethodExtId: ")+localVars.inParamPaymentMethodExternalId)+" // PayTermDescrip: ")+localVars.inParamPaymentTermDescrip)+" // InvoiceExtended.FechaEmission ")+localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision)+" // Com TextToDate() ")+BuiltInFunction.DateToText(BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("q6_YoL3bg0GiY7Qo3Po32Q"))).ssId },cancellationToken);

// Query datasetGetFolioSAPDataByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioSAPDataByFolioId_maxRecords = 1;
if (datasetGetFolioSAPDataByFolioId_maxRecords < 1) datasetGetFolioSAPDataByFolioId_maxRecords = 1;
int datasetGetFolioSAPDataByFolioId_startIndex = 0;(localVars.queryResGetFolioSAPDataByFolioId_outParamList,localVars.queryResGetFolioSAPDataByFolioId_outParamCount) = await FuncActionEntryAccounting_CallInvoiceCount.datasetGetFolioSAPDataByFolioId(requestContext,datasetGetFolioSAPDataByFolioId_maxRecords,datasetGetFolioSAPDataByFolioId_startIndex,IterationMultiplicity.Never,localVars.inParamFolioItems.CurrentRec.ssENFolioItems.ssFolioId,cancellationToken);

// Query datasetGetOrderApprovalLevels
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalLevels_maxRecords = 1;
if (datasetGetOrderApprovalLevels_maxRecords < 1) datasetGetOrderApprovalLevels_maxRecords = 1;
int datasetGetOrderApprovalLevels_startIndex = 0;(localVars.queryResGetOrderApprovalLevels_outParamList,localVars.queryResGetOrderApprovalLevels_outParamCount) = await FuncActionEntryAccounting_CallInvoiceCount.datasetGetOrderApprovalLevels(requestContext,datasetGetOrderApprovalLevels_maxRecords,datasetGetOrderApprovalLevels_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMainId,cancellationToken);

// EntryAccounting_GetRetentions
localVars.resEntryAccounting_GetRetentions.outParamTI_WXD_InList = await Actions.ActionEntryAccounting_GetRetentions(requestContext,localVars.inParamInvoiceData.ssENInvoice.ssId,cancellationToken);

// TI_WXD_InList = EntryAccounting_GetRetentions.TI_WXD_InList
localVars.varLcTI_WXD_InList=localVars.resEntryAccounting_GetRetentions.outParamTI_WXD_InList;
// GetNextMonday
localVars.resGetNextMonday.outParamDays = await Actions.ActionGetNextMonday(requestContext,BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssCreatedOn,localVars.inParamOffsetUtc,cancellationToken)), localVars.inParamPaymentTermDays),cancellationToken);

// TotalFolioValue = 0
localVars.varLcTotalFolioValue=(((decimal)0));
// Foreach FolioItems
localVars.inParamFolioItems.StartIteration();
try {while (!((localVars.inParamFolioItems.Eof))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,localVars.varLcTI_ITEM_InList,(await RecordUtils.ConvertAsync(localVars.inParamFolioItems.CurrentRec, new ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure(), async (RC_82af454f3893e60efc22cc7344fd4176 source, ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure target, CancellationToken cancellationToken) => {
target.ssINVOICE_DOC_ITEM = localVars.varLcCount;
target.ssPO_NUMBER = localVars.inParamOrderNumber;
target.ssPO_ITEM = source.ssENOrderMainItem.ssPosition;
target.ssREF_DOC = localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_DOCUMENTO_MATERIAL_EM;
target.ssREF_DOC_YEAR = BuiltInFunction.TextToInteger (localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssPO_EJERCICIO_EM);
target.ssREF_DOC_IT = localVars.varLcCount;
target.ssTAX_CODE = source.ssENOrderMainItem.ssVATIndicator;
target.ssITEM_AMOUNT = BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (source.ssENFolioItems.ssTotalPrice, 2, ".", ""));
target.ssQUANTITY = source.ssENFolioItems.ssInvoiceQtt;
target.ssPO_UNIT = source.ssENOrderMainItem.ssOrderUnitOfMeasure;
return target;
}, cancellationToken)),cancellationToken);

// Count = Count + 1
localVars.varLcCount=(localVars.varLcCount+1);

// TotalFolioValue = TotalFolioValue + TextToDecimal
localVars.varLcTotalFolioValue=(localVars.varLcTotalFolioValue+BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (localVars.inParamFolioItems.CurrentRec.ssENFolioItems.ssTotalPrice, 2, ".", "")));
localVars.inParamFolioItems.Advance();
}

} finally {
localVars.inParamFolioItems.EndIteration();
}

// LogsAccountingCreate8
localVars.resLogsAccountingCreate8.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call_ZMXFFIMF_CONTA_FACTURAS", ssDescription = (((("Invoice amount:"+BuiltInFunction.DecimalToText(localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal))+"\r\n")+"Folio Invoice: ")+BuiltInFunction.DecimalToText(localVars.varLcTotalFolioValue)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// not same amount?
if(((!(localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal==localVars.varLcTotalFolioValue)))) {
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 0;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncActionEntryAccounting_CallInvoiceCount.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMainId,cancellationToken);

// No order?
if((localVars.queryResGetOrderMainById_outParamList.Empty)) {
// LogsAccountingCreate10
localVars.resLogsAccountingCreate10.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call_ZMXFFIMF_CONTA_FACTURAS", ssDescription = "No order found", ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

goto RETURN_STATEMENT;

} else {
// GetCustomSettingsAccounting
(localVars.resGetCustomSettingsAccounting.outParamPI_DR_CB_IND,localVars.resGetCustomSettingsAccounting.outParamPI_GL_ACCOUNT) = await Actions.ActionGetCustomSettingsAccounting(requestContext,(localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal>localVars.varLcTotalFolioValue),cancellationToken);

// LogsAccountingCreate9
localVars.resLogsAccountingCreate9.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call_ZMXFFIMF_CONTA_FACTURAS", ssDescription = ((((((((((((((((((((((((((((((("PI_BUS_AREA: "+localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENRegion.ssDivisionFI)+"\r\n")+"PI_COMP_CODE: ")+localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENCompany.ssExternalId)+"\r\n")+"PI_DB_CR_IND: ")+localVars.resGetCustomSettingsAccounting.outParamPI_DR_CB_IND)+"\r\n")+"PI_GL_ACCOUNT: ")+localVars.resGetCustomSettingsAccounting.outParamPI_GL_ACCOUNT)+"\r\n")+"PI_INVOICE_DOC_ITEM: ")+Convert.ToString(localVars.varLcTI_ITEM_InList[0].ssPO_ITEM))+"\r\n")+"PI_ITEM_AMOUNT: ")+BuiltInFunction.DecimalToText(BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (((((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal-localVars.varLcTotalFolioValue)>(((decimal)0)))) ? ((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal-localVars.varLcTotalFolioValue)) : (((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal-localVars.varLcTotalFolioValue)*(((decimal)(-1)))))), 2, ".", ""))))+"\r\n")+"Invoice SubTotal: ")+BuiltInFunction.DecimalToText(localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal))+"\r\n")+"TaxToAdd: ")+BuiltInFunction.DecimalToText(localVars.inParamTaxToAdd))+"\r\n")+"TotalFolioValue: ")+BuiltInFunction.DecimalToText(localVars.varLcTotalFolioValue))+"\r\n")+"TaxToapply: ")+BuiltInFunction.DecimalToText(localVars.inParamTaxToApply))+"\r\n")+"InvoiceData.InvoiceExtended.Subtotal - TotalFolioValue")+BuiltInFunction.DecimalToText(((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal+localVars.inParamTaxToAdd)-(localVars.varLcTotalFolioValue*((((decimal)1))+localVars.inParamTaxToApply))))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// PI_BUS_AREA = GetOrderMainById.List.Current.Region.DivisionFI
localVars.varLcPI_BUS_AREA=localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// PI_COMP_CODE = GetOrderMainById.List.Current.Company.ExternalId
localVars.varLcPI_COMP_CODE=localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENCompany.ssExternalId;

// PI_DB_CR_IND = GetCustomSettingsAccounting.PI_DR_CB_IND
localVars.varLcPI_DB_CR_IND=localVars.resGetCustomSettingsAccounting.outParamPI_DR_CB_IND;

// PI_GL_ACCOUNT = GetCustomSettingsAccounting.PI_GL_ACCOUNT
localVars.varLcPI_GL_ACCOUNT=localVars.resGetCustomSettingsAccounting.outParamPI_GL_ACCOUNT;

// PI_INVOICE_DOC_ITEM = TI_ITEM_InList[0].INVOICE_DOC_ITEM
localVars.varLcPI_INVOICE_DOC_ITEM=localVars.varLcTI_ITEM_InList[0].ssINVOICE_DOC_ITEM;

// PI_ITEM_AMOUNT = TextToDecimal
localVars.varLcPI_ITEM_AMOUNT=BuiltInFunction.TextToDecimal (BuiltInFunction.FormatDecimal (BuiltInFunction.Abs (((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal+localVars.inParamTaxToAdd)-(localVars.varLcTotalFolioValue*((((decimal)1))+localVars.inParamTaxToApply)))), 2, ".", ""));
}

}

// Call_ZMXFFIMF_CONTA_FACTURAS
localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse = await ServiceAPIs.ServiceAPICall_ZMXFFIMF_CONTA_FACTURAS(requestContext,new ST_012aef00497ef6b298e25799608b1289Structure(){ ssPI_BUS_AREA = localVars.varLcPI_BUS_AREA, ssPI_COMP_CODE = localVars.varLcPI_COMP_CODE, ssPI_DB_CR_IND = localVars.varLcPI_DB_CR_IND, ssPI_GL_ACCOUNT = localVars.varLcPI_GL_ACCOUNT, ssPI_HEADER = new ST_f4885e4f480f4a52f6c05031eda6ef37Structure(){ ssINVOICE_IND = "X", ssDOC_TYPE = "RE", ssDOC_DATE = BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), ssPSTNG_DATE = BuiltInFunction.DateTimeToDate((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken))), ssREF_DOC_NO = (((localVars.inParamInvoiceData.ssENInvoiceExtended.ssFolio!="")) ? (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFolio) : (BuiltInFunction.SubstrSC (localVars.inParamInvoiceData.ssENInvoiceExtended.ssUUID, (BuiltInFunction.LengthSC (localVars.inParamInvoiceData.ssENInvoiceExtended.ssUUID)-4), 4))), ssCOMP_CODE = localVars.inParamInvoiceData.ssENCompany.ssExternalId, ssGROSS_AMOUNT = (localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal+localVars.inParamTaxToAdd), ssCALC_TAX_IND = "X", ssPMNTTRMS = localVars.inParamPaymentTermDescrip, ssBLINE_DATE = BuiltInFunction.DateTimeToDate(BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssCreatedOn,localVars.inParamOffsetUtc,cancellationToken)), localVars.resGetNextMonday.outParamDays)), ssHEADER_TXT = (((localVars.inParamInvoiceData.ssENProject_Asset_Service.ssDescription!="")) ? (localVars.inParamInvoiceData.ssENProject_Asset_Service.ssDescription) : ("N/A")), ssALLOC_NMBR = localVars.queryResGetOrderApprovalLevels_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber, ssBUS_AREA = localVars.inParamInvoiceData.ssENRegion.ssDivisionFI, ssITEM_TEXT = (((localVars.inParamInvoiceData.ssENOrderDetail.ssProjectDescription!="")) ? (localVars.inParamInvoiceData.ssENOrderDetail.ssProjectDescription) : ("N/A")), ssCURRENCY = localVars.inParamInvoiceData.ssENInvoice.ssCurrency, ssDEL_COSTS_TAXC = localVars.inParamIVAIndicator, ssPYMT_METH = localVars.inParamPaymentMethodExternalId, ssEXCH_RATE = (((localVars.inParamInvoiceData.ssENInvoice.ssCurrency=="MXN")) ? ((((decimal)0))) : (localVars.inParamExchange)) }, ssPI_INVOICE_DOC_ITEM = localVars.varLcPI_INVOICE_DOC_ITEM, ssPI_ITEM_AMOUNT = localVars.varLcPI_ITEM_AMOUNT, ssPI_UUID = localVars.inParamInvoiceData.ssENInvoiceExtended.ssUUID, ssTI_ITEM_In = localVars.varLcTI_ITEM_InList, ssTI_WXD_In = localVars.varLcTI_WXD_InList },cancellationToken);

// o_Output.IsSuccess = Substr = "S" and Index <> -1
result.outParamo_Output.ssIsSuccess = ((BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA, 0, 1)=="S")&&(BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA, "56", 0, false, false)!=(-1)));

// o_Output.Message = Call_ZMXFFIMF_CONTA_FACTURAS.Response.PE_RESPUESTA
result.outParamo_Output.ssMessage = localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA;
// LogsAccountingCreate5
localVars.resLogsAccountingCreate5.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call_ZMXFFIMF_CONTA_FACTURAS", ssDescription = localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// error?
if((!((!result.outParamo_Output.ssIsSuccess)))) {
// set ID_POLIZA & TEXTO
// InvoiceData.Invoice.ID_POLIZA = InvoiceData.Invoice.Id
localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA = BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceData.ssENInvoice.ssId);

// InvoiceData.Invoice.ID_POLIZA_SAP = Substr
localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA_SAP = BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA, BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA, "56", 0, false, false), 10);

// InvoiceData.Invoice.Doc51 = Substr
localVars.inParamInvoiceData.ssENInvoice.ssDoc51 = BuiltInFunction.SubstrSC (localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA, BuiltInFunction.IndexSC (localVars.resCall_ZMXFFIMF_CONTA_FACTURAS_outParamResponse.ssPE_RESPUESTA, "51", 0, false, false), 10);
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.inParamInvoiceData.ssENInvoice,false,cancellationToken);

// InvoiceDocumentRelationCreate
await Actions.ActionInvoiceDocumentRelationCreate(requestContext,localVars.inParamInvoiceData.ssENInvoice.ssId,BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceData.ssENInvoice.ssId),localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA_SAP,((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))),cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Error in SAP services. Please contact an administrator."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("FFIQO1ZfUEiYISGE0yHxWQ#Value.1410737295.1", "Error in SAP services. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionEntryAccounting_CallInvoiceCount {

// Query Function "GetFolioSAPDataByFolioId" 4egED1P4NkugYl6N5jRzZw of Action "EntryAccounting_CallInvoiceCount"
public static async Task<(RL_c9f6aa71e71ab2513c8b708a5c8313ba,long)> datasetGetFolioSAPDataByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CallInvoiceCount.GetFolioSAPDataByFolioId", "0f04e8e1-f853-4b36-a062-5e8de6347367");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CallInvoiceCount.GetFolioSAPDataByFolioId", "0f04e8e1-f853-4b36-a062-5e8de6347367", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.8fgkMexWhEGZOezYDXaTdw/NodesNotShownInESpaceTree.4egED1P4NkugYl6N5jRzZw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enfoliosapdata1\".\"po_documento_material_em\" o3, NULL o4, NULL o5, NULL o6, \"enfoliosapdata1\".\"po_ejercicio_em\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enfoliosapdata1\".\"createdon\" o14");
fromBuilder.Append(" FROM {FolioSAPData} \"enfoliosapdata1\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliosapdata1\".\"folioid\" = @qpfoFolioId) AND (\"enfoliosapdata1\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliosapdata1\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliosapdata1\".\"id\" DESC ");
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
RL_c9f6aa71e71ab2513c8b708a5c8313ba outParamList = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, false, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CallInvoiceCount.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c9f6aa71e71ab2513c8b708a5c8313ba _tmp = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CallInvoiceCount.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c9f6aa71e71ab2513c8b708a5c8313ba)_tmp;
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

private static async Task<RC_8e50aadd5c1e05d0be3f2d234221ec50> datasetGetOrderApprovalLevelsReadDbAsync(RC_8e50aadd5c1e05d0be3f2d234221ec50 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalLevels" q9grfRmS+UCgdnCX68u_3g of Action "EntryAccounting_CallInvoiceCount"
public static async Task<(RL_a492f6700ed5395e4cd6d4e3942ae398,long)> datasetGetOrderApprovalLevels(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CallInvoiceCount.GetOrderApprovalLevels", "7d2bd8ab-9219-40f9-a076-7097ebcbbfde");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CallInvoiceCount.GetOrderApprovalLevels", "7d2bd8ab-9219-40f9-a076-7097ebcbbfde", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.8fgkMexWhEGZOezYDXaTdw/NodesNotShownInESpaceTree.q9grfRmS+UCgdnCX68u_3g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, \"enuser_extended_internal20\".\"employeenumber\" o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49");
fromBuilder.Append(" FROM ((({OrderApproval} \"enorderapproval3\" Left JOIN {OrderApprovalLevel} \"enorderapprovallevel3\" ON (\"enorderapprovallevel3\".\"orderapprovalid\" = \"enorderapproval3\".\"id\"))  Left JOIN {User} \"enuser32\" ON (\"enorderapprovallevel3\".\"assignedto\" = \"enuser32\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal20\" ON (\"enuser32\".\"id\" = \"enuser_extended_internal20\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval3\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval3\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval3\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderapprovallevel3\".\"iscomplement\" = 1)");
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
RL_a492f6700ed5395e4cd6d4e3942ae398 outParamList = new RL_a492f6700ed5395e4cd6d4e3942ae398();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CallInvoiceCount.GetOrderApprovalLevels.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a492f6700ed5395e4cd6d4e3942ae398 _tmp = new RL_a492f6700ed5395e4cd6d4e3942ae398();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CallInvoiceCount.GetOrderApprovalLevels.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a492f6700ed5395e4cd6d4e3942ae398)_tmp;
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

private static async Task<RC_71c861973e22846762035e2ce8e6ef99> datasetGetOrderMainByIdReadDbAsync(RC_71c861973e22846762035e2ce8e6ef99 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainById" ovxk0RITZ0C+gKHlg7oAkQ of Action "EntryAccounting_CallInvoiceCount"
public static async Task<(RL_c8bbb75c7d09bde1f237fa0b721125bc,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CallInvoiceCount.GetOrderMainById", "d164fca2-1312-4067-be80-a1e583ba0091");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CallInvoiceCount.GetOrderMainById", "d164fca2-1312-4067-be80-a1e583ba0091", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.8fgkMexWhEGZOezYDXaTdw/NodesNotShownInESpaceTree.ovxk0RITZ0C+gKHlg7oAkQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany2\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, \"enregion9\".\"divisionfi\" o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain12\" Inner JOIN {Company} \"encompany2\" ON (\"enordermain12\".\"companyid\" = \"encompany2\".\"id\"))  Inner JOIN {Region} \"enregion9\" ON (\"enordermain12\".\"regionid\" = \"enregion9\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain12\".\"id\" = @qporOrderMain_Id) AND (\"enordermain12\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain12\".\"id\" IS NULL)");
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
RL_c8bbb75c7d09bde1f237fa0b721125bc outParamList = new RL_c8bbb75c7d09bde1f237fa0b721125bc();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CallInvoiceCount.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c8bbb75c7d09bde1f237fa0b721125bc _tmp = new RL_c8bbb75c7d09bde1f237fa0b721125bc();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CallInvoiceCount.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c8bbb75c7d09bde1f237fa0b721125bc)_tmp;
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
