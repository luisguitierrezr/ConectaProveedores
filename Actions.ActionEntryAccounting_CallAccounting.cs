namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccounting_CallAccounting : VarsBag {
public RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData;
public RL_0dc1085ad4cd06d01dea77860d02de63 inParamFolioItems;
public string inParamDocumentType;
public string inParamIVAIndicator;
public decimal inParamTaxToAdd;
public string inParamPaymentTermDesc;
public int inParamPaymentTermDays;
public string inParamFirstCuenta;
public string inParamSecondCuenta;
public string inParamFirstClave;
public string inParamSecondClave;
public string inParamICME;
public decimal inParamExchangeRate;
public bool inParamIsAnticipo;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>l_AnticiposAccountingFinalList</code> that represents the Service Studio
///  TI_POS_InList <code>l_AnticiposAccountingFinalList</code> <p>Description: </p>
/// </summary>
public RL_c68103fa9d6dc1b51b6298518d880199 varLcl_AnticiposAccountingFinalList = new RL_c68103fa9d6dc1b51b6298518d880199();

/// <summary>
/// Variable <code>l_AnticiposAccountingTextList</code> that represents the Service Studio Text2List
///  <code>l_AnticiposAccountingTextList</code> <p>Description: </p>
/// </summary>
public RLTextList varLcl_AnticiposAccountingTextList = new RLTextList();

/// <summary>
/// Variable <code>Count</code> that represents the Service Studio Integer <code>Count</code>
///  <p>Description: </p>
/// </summary>
public int varLcCount = 2;

public string resString_Join_outParamText = "";

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoGetNextMonday resGetNextMonday =  new Actions.lcoGetNextMonday();
public RL_216ae81da35dfe5cfaaa600823fb4c79 queryResGetUserExtendedInternalById_outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
public long queryResGetUserExtendedInternalById_outParamCount = 0L;

public ST_35778da666b987b02b8cb887e66647a4Structure resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse = new ST_35778da666b987b02b8cb887e66647a4Structure();

public RL_c9f6aa71e71ab2513c8b708a5c8313ba queryResGetFolioSAPDataByFolioId_outParamList = new RL_c9f6aa71e71ab2513c8b708a5c8313ba();
public long queryResGetFolioSAPDataByFolioId_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public string resString_Join2_outParamText = "";

public lcvEntryAccounting_CallAccounting(RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData, RL_0dc1085ad4cd06d01dea77860d02de63 inParamFolioItems, string inParamDocumentType, string inParamIVAIndicator, decimal inParamTaxToAdd, string inParamPaymentTermDesc, int inParamPaymentTermDays, string inParamFirstCuenta, string inParamSecondCuenta, string inParamFirstClave, string inParamSecondClave, string inParamICME, decimal inParamExchangeRate, bool inParamIsAnticipo, int inParamOffsetUtc) {
this.inParamInvoiceData = inParamInvoiceData;
this.inParamFolioItems = inParamFolioItems;
this.inParamDocumentType = inParamDocumentType;
this.inParamIVAIndicator = inParamIVAIndicator;
this.inParamTaxToAdd = inParamTaxToAdd;
this.inParamPaymentTermDesc = inParamPaymentTermDesc;
this.inParamPaymentTermDays = inParamPaymentTermDays;
this.inParamFirstCuenta = inParamFirstCuenta;
this.inParamSecondCuenta = inParamSecondCuenta;
this.inParamFirstClave = inParamFirstClave;
this.inParamSecondClave = inParamSecondClave;
this.inParamICME = inParamICME;
this.inParamExchangeRate = inParamExchangeRate;
this.inParamIsAnticipo = inParamIsAnticipo;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoEntryAccounting_CallAccounting : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoEntryAccounting_CallAccounting() {
}
}
/// <summary>
/// Action <code>EntryAccounting_CallAccounting</code> that represents the Service Studio action
///  <code>EntryAccounting_CallAccounting</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionEntryAccounting_CallAccounting(IRequestContext requestContext,RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData,RL_0dc1085ad4cd06d01dea77860d02de63 inParamFolioItems,string inParamDocumentType,string inParamIVAIndicator,decimal inParamTaxToAdd,string inParamPaymentTermDesc,int inParamPaymentTermDays,string inParamFirstCuenta,string inParamSecondCuenta,string inParamFirstClave,string inParamSecondClave,string inParamICME,decimal inParamExchangeRate,bool inParamIsAnticipo,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoEntryAccounting_CallAccounting result = new lcoEntryAccounting_CallAccounting();
lcvEntryAccounting_CallAccounting localVars = new lcvEntryAccounting_CallAccounting(inParamInvoiceData, inParamFolioItems, inParamDocumentType, inParamIVAIndicator, inParamTaxToAdd, inParamPaymentTermDesc, inParamPaymentTermDays, inParamFirstCuenta, inParamSecondCuenta, inParamFirstClave, inParamSecondClave, inParamICME, inParamExchangeRate, inParamIsAnticipo, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccounting_CallAccounting", "39cf9d59-7957-4964-b2bc-f9cba47af959"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccounting_CallAccounting", "39cf9d59-7957-4964-b2bc-f9cba47af959", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalById_maxRecords = 0;
int datasetGetUserExtendedInternalById_startIndex = 0;(localVars.queryResGetUserExtendedInternalById_outParamList,localVars.queryResGetUserExtendedInternalById_outParamCount) = await FuncActionEntryAccounting_CallAccounting.datasetGetUserExtendedInternalById(requestContext,datasetGetUserExtendedInternalById_maxRecords,datasetGetUserExtendedInternalById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetFolioSAPDataByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioSAPDataByFolioId_maxRecords = 1;
if (datasetGetFolioSAPDataByFolioId_maxRecords < 1) datasetGetFolioSAPDataByFolioId_maxRecords = 1;
int datasetGetFolioSAPDataByFolioId_startIndex = 0;(localVars.queryResGetFolioSAPDataByFolioId_outParamList,localVars.queryResGetFolioSAPDataByFolioId_outParamCount) = await FuncActionEntryAccounting_CallAccounting.datasetGetFolioSAPDataByFolioId(requestContext,datasetGetFolioSAPDataByFolioId_maxRecords,datasetGetFolioSAPDataByFolioId_startIndex,IterationMultiplicity.Never,localVars.inParamFolioItems.CurrentRec.ssENFolioItems.ssFolioId,cancellationToken);

// GetNextMonday
localVars.resGetNextMonday.outParamDays = await Actions.ActionGetNextMonday(requestContext,BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssCreatedOn,localVars.inParamOffsetUtc,cancellationToken)), BuiltInFunction.TextToInteger (Convert.ToString(localVars.inParamPaymentTermDays))),cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_AnticiposAccountingTextList,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = Convert.ToString(1) }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceData.ssENInvoice.ssId) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.inParamDocumentType }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoice.ssCurrency }, new STTextStructure(){ ssValue = (((localVars.inParamInvoiceData.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = BuiltInFunction.DecimalToText(localVars.inParamExchangeRate) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssFolio }, new STTextStructure(){ ssValue = BuiltInFunction.Replace (localVars.inParamInvoiceData.ssENOrderDetail.ssProjectDescription, "||", "--") }, new STTextStructure(){ ssValue = localVars.inParamFirstCuenta }, new STTextStructure(){ ssValue = localVars.inParamFirstClave }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENSupplier.ssNumber }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDecimal ((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal+localVars.inParamTaxToAdd), 2, ".", ",") }, new STTextStructure(){ ssValue = localVars.inParamIVAIndicator }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENRegion.ssDivisionFI }, new STTextStructure(){ ssValue = localVars.inParamPaymentTermDesc }, new STTextStructure(){ ssValue = BuiltInFunction.DateTimeToText(BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,localVars.queryResGetFolioSAPDataByFolioId_outParamList.CurrentRec.ssENFolioSAPData.ssCreatedOn,localVars.inParamOffsetUtc,cancellationToken)), localVars.resGetNextMonday.outParamDays)) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENPaymentMethods.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.inParamInvoiceData.ssENOrderDetail.ssProjectDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssUUID }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENOrderMain.ssOrderNumber }, new STTextStructure(){ ssValue = Convert.ToString(localVars.inParamFolioItems.CurrentRec.ssENOrderMainItem.ssPosition) } })),cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_AnticiposAccountingTextList, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_AnticiposAccountingFinalList,new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join_outParamText },cancellationToken);

// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcl_AnticiposAccountingTextList,cancellationToken);

// Foreach FolioItems
localVars.inParamFolioItems.StartIteration();
try {while (!((localVars.inParamFolioItems.Eof))) {
// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_AnticiposAccountingTextList,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = Convert.ToString(localVars.varLcCount) }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceData.ssENInvoice.ssId) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.inParamDocumentType }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoice.ssCurrency }, new STTextStructure(){ ssValue = (((localVars.inParamInvoiceData.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = BuiltInFunction.DecimalToText(localVars.inParamExchangeRate) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssFolio }, new STTextStructure(){ ssValue = BuiltInFunction.Replace (localVars.inParamFolioItems.CurrentRec.ssENFolioItems.ssDescription, "||", "--") }, new STTextStructure(){ ssValue = localVars.inParamSecondCuenta }, new STTextStructure(){ ssValue = localVars.inParamSecondClave }, new STTextStructure(){ ssValue = ((localVars.inParamIsAnticipo) ? (localVars.inParamInvoiceData.ssENSupplier.ssNumber) : (localVars.inParamFolioItems.CurrentRec.ssENAccountingAccounts_ServiceType.ssCC)) }, new STTextStructure(){ ssValue = localVars.inParamICME }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDecimal (BuiltInFunction.TextToDecimal (localVars.inParamFolioItems.CurrentRec.ssENFolioItems.ssImportdelivery), 2, ".", ",") }, new STTextStructure(){ ssValue = localVars.inParamFolioItems.CurrentRec.ssENOrderMainItem.ssVATIndicator }, new STTextStructure(){ ssValue = localVars.inParamFolioItems.CurrentRec.ssENCostCenterSAP.ssCe_coste }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamFolioItems.CurrentRec.ssENRegion.ssDivisionFI }, new STTextStructure(){ ssValue = localVars.inParamPaymentTermDesc }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), localVars.resGetNextMonday.outParamDays), "yyyyMMdd") }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENPaymentMethods.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.inParamFolioItems.CurrentRec.ssENFolioItems.ssDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssUUID }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENOrderMain.ssOrderNumber }, new STTextStructure(){ ssValue = Convert.ToString(localVars.inParamFolioItems.CurrentRec.ssENOrderMainItem.ssPosition) } })),cancellationToken);

// String_Join2
localVars.resString_Join2_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_AnticiposAccountingTextList, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// ListAppend3
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_AnticiposAccountingFinalList,new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join2_outParamText },cancellationToken);

// ListClear2
await ExtendedActions.ListClear(requestContext,localVars.varLcl_AnticiposAccountingTextList,cancellationToken);

// Count = Count + 1
localVars.varLcCount=(localVars.varLcCount+1);
localVars.inParamFolioItems.Advance();
}

} finally {
localVars.inParamFolioItems.EndIteration();
}

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call GENERA_POLIZA _ FCP", ssDescription = ("Tram1 "+localVars.resString_Join_outParamText), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// Call_ZTC_GENERA_POLIZA_GRAL
localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse = await ServiceAPIs.ServiceAPICall_ZTC_GENERA_POLIZA_GRAL(requestContext,new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure(){ ssPI_USUARIO = "STC_CONECTA", ssTI_POS_In = localVars.varLcl_AnticiposAccountingFinalList },cancellationToken);

// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "After Call GENERA_POLIZA _ FCP", ssDescription = ((((localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO+" // ID_POLIZA: ")+localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA)+" // TEXTO: ")+localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// error?
if((((((BuiltInFunction.SubstrSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO, 0, 1)=="E")||(localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA==""))||(BuiltInFunction.SubstrSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssCODIGO, 0, 1)=="E"))&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// o_Output.Message = Call_ZTC_GENERA_POLIZA_GRAL.Response.PO_RESULTADO
result.outParamo_Output.ssMessage = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO;

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;
} else {
// set ID_POLIZA & TEXTO
// InvoiceData.Invoice.ID_POLIZA = Call_ZTC_GENERA_POLIZA_GRAL.Response.TO_RESULTADO_Out.Current.ID_POLIZA
localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA;

// InvoiceData.Invoice.ID_POLIZA_SAP = If
localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA_SAP = (((BuiltInFunction.IndexSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO, "-", 0, false, false)>0)) ? (BuiltInFunction.SubstrSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO, 0, BuiltInFunction.IndexSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO, "-", 0, false, false))) : (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO));

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = Call_ZTC_GENERA_POLIZA_GRAL.Response.PO_RESULTADO
result.outParamo_Output.ssMessage = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO;
// InvoiceCreateOrUpdate
localVars.resInvoiceCreateOrUpdate.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.inParamInvoiceData.ssENInvoice,false,cancellationToken);

// InvoiceDocumentRelationCreate
await Actions.ActionInvoiceDocumentRelationCreate(requestContext,localVars.inParamInvoiceData.ssENInvoice.ssId,localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA,localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA_SAP,((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))),cancellationToken);

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
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("w4UUf63aok+9M4IY4AMd2Q#Value.1410737295.1", "Error in SAP services. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionEntryAccounting_CallAccounting {

// Query Function "GetUserExtendedInternalById" 4NOtcD4hWEKMEof7bdRFtg of Action "EntryAccounting_CallAccounting"
public static async Task<(RL_216ae81da35dfe5cfaaa600823fb4c79,long)> datasetGetUserExtendedInternalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CallAccounting.GetUserExtendedInternalById", "70add3e0-213e-4258-8c12-87fb6dd445b6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CallAccounting.GetUserExtendedInternalById", "70add3e0-213e-4258-8c12-87fb6dd445b6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.WZ3POVd5ZEmyvPnLpHr5WQ/NodesNotShownInESpaceTree.4NOtcD4hWEKMEof7bdRFtg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser_extended_internal25\".\"employeenumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {User_Extended_Internal} \"enuser_extended_internal25\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal25\".\"id\" = @qpusId) AND (\"enuser_extended_internal25\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser_extended_internal25\".\"id\" IS NULL)");
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
RL_216ae81da35dfe5cfaaa600823fb4c79 outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CallAccounting.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_216ae81da35dfe5cfaaa600823fb4c79 _tmp = new RL_216ae81da35dfe5cfaaa600823fb4c79();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CallAccounting.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_216ae81da35dfe5cfaaa600823fb4c79)_tmp;
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

// Query Function "GetFolioSAPDataByFolioId" sUc4hH6KtEuvFPyu3SuiXg of Action "EntryAccounting_CallAccounting"
public static async Task<(RL_c9f6aa71e71ab2513c8b708a5c8313ba,long)> datasetGetFolioSAPDataByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CallAccounting.GetFolioSAPDataByFolioId", "843847b1-8a7e-4bb4-af14-fcaedd2ba25e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CallAccounting.GetFolioSAPDataByFolioId", "843847b1-8a7e-4bb4-af14-fcaedd2ba25e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.WZ3POVd5ZEmyvPnLpHr5WQ/NodesNotShownInESpaceTree.sUc4hH6KtEuvFPyu3SuiXg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enfoliosapdata2\".\"createdon\" o14");
fromBuilder.Append(" FROM {FolioSAPData} \"enfoliosapdata2\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"enfoliosapdata2\".\"folioid\" = @qpfoFolioId) AND (\"enfoliosapdata2\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"enfoliosapdata2\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfoliosapdata2\".\"id\" DESC ");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CallAccounting.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CallAccounting.GetFolioSAPDataByFolioId.List", cancellationToken: cancellationToken);
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



}


}
