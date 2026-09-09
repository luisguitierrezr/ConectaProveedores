namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntryAccounting_CallAccounting_Order : VarsBag {
public RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData;
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

public string resString_Join2_outParamText = "";

public RL_68685adfd889e1cc20ee9267e233e63b queryResGetOrderMainItemsByOrderMainId_outParamList = new RL_68685adfd889e1cc20ee9267e233e63b();
public long queryResGetOrderMainItemsByOrderMainId_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public RL_216ae81da35dfe5cfaaa600823fb4c79 queryResGetUserExtendedInternalById_outParamList = new RL_216ae81da35dfe5cfaaa600823fb4c79();
public long queryResGetUserExtendedInternalById_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate =  new Actions.lcoInvoiceCreateOrUpdate();
public ST_35778da666b987b02b8cb887e66647a4Structure resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse = new ST_35778da666b987b02b8cb887e66647a4Structure();

public Actions.lcoGetNextMonday resGetNextMonday =  new Actions.lcoGetNextMonday();
public string resString_Join_outParamText = "";

public lcvEntryAccounting_CallAccounting_Order(RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData, string inParamDocumentType, string inParamIVAIndicator, decimal inParamTaxToAdd, string inParamPaymentTermDesc, int inParamPaymentTermDays, string inParamFirstCuenta, string inParamSecondCuenta, string inParamFirstClave, string inParamSecondClave, string inParamICME, decimal inParamExchangeRate, bool inParamIsAnticipo, int inParamOffsetUtc) {
this.inParamInvoiceData = inParamInvoiceData;
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
public class lcoEntryAccounting_CallAccounting_Order : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoEntryAccounting_CallAccounting_Order() {
}
}
/// <summary>
/// Action <code>EntryAccounting_CallAccounting_Order</code> that represents the Service Studio action
///  <code>EntryAccounting_CallAccounting_Order</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionEntryAccounting_CallAccounting_Order(IRequestContext requestContext,RC_bd42fd4399da47c92c88d912cd87df67 inParamInvoiceData,string inParamDocumentType,string inParamIVAIndicator,decimal inParamTaxToAdd,string inParamPaymentTermDesc,int inParamPaymentTermDays,string inParamFirstCuenta,string inParamSecondCuenta,string inParamFirstClave,string inParamSecondClave,string inParamICME,decimal inParamExchangeRate,bool inParamIsAnticipo,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoEntryAccounting_CallAccounting_Order result = new lcoEntryAccounting_CallAccounting_Order();
lcvEntryAccounting_CallAccounting_Order localVars = new lcvEntryAccounting_CallAccounting_Order(inParamInvoiceData, inParamDocumentType, inParamIVAIndicator, inParamTaxToAdd, inParamPaymentTermDesc, inParamPaymentTermDays, inParamFirstCuenta, inParamSecondCuenta, inParamFirstClave, inParamSecondClave, inParamICME, inParamExchangeRate, inParamIsAnticipo, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("EntryAccounting_CallAccounting_Order", "ded6f882-bbff-4c9d-99cb-975a7164a8bf"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("EntryAccounting_CallAccounting_Order", "ded6f882-bbff-4c9d-99cb-975a7164a8bf", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetUserExtendedInternalById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserExtendedInternalById_maxRecords = 0;
int datasetGetUserExtendedInternalById_startIndex = 0;(localVars.queryResGetUserExtendedInternalById_outParamList,localVars.queryResGetUserExtendedInternalById_outParamCount) = await FuncActionEntryAccounting_CallAccounting_Order.datasetGetUserExtendedInternalById(requestContext,datasetGetUserExtendedInternalById_maxRecords,datasetGetUserExtendedInternalById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetOrderMainItemsByOrderMainId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainItemsByOrderMainId_maxRecords = 1;
if (datasetGetOrderMainItemsByOrderMainId_maxRecords < 1) datasetGetOrderMainItemsByOrderMainId_maxRecords = 1;
int datasetGetOrderMainItemsByOrderMainId_startIndex = 0;(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList,localVars.queryResGetOrderMainItemsByOrderMainId_outParamCount) = await FuncActionEntryAccounting_CallAccounting_Order.datasetGetOrderMainItemsByOrderMainId(requestContext,datasetGetOrderMainItemsByOrderMainId_maxRecords,datasetGetOrderMainItemsByOrderMainId_startIndex,IterationMultiplicity.Never,localVars.inParamInvoiceData.ssENOrderMain.ssId,cancellationToken);

// GetNextMonday
localVars.resGetNextMonday.outParamDays = await Actions.ActionGetNextMonday(requestContext,BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), BuiltInFunction.TextToInteger (Convert.ToString(localVars.inParamPaymentTermDays))),cancellationToken);

// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_AnticiposAccountingTextList,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = Convert.ToString(1) }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceData.ssENInvoice.ssId) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.inParamDocumentType }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoice.ssCurrency }, new STTextStructure(){ ssValue = (((localVars.inParamInvoiceData.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = BuiltInFunction.DecimalToText(localVars.inParamExchangeRate) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssFolio }, new STTextStructure(){ ssValue = BuiltInFunction.Replace (localVars.inParamInvoiceData.ssENOrderDetail.ssProjectDescription, "||", "--") }, new STTextStructure(){ ssValue = localVars.inParamFirstCuenta }, new STTextStructure(){ ssValue = localVars.inParamFirstClave }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENSupplier.ssNumber }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDecimal ((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal+localVars.inParamTaxToAdd), 2, ".", ",") }, new STTextStructure(){ ssValue = localVars.inParamIVAIndicator }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENRegion.ssDivisionFI }, new STTextStructure(){ ssValue = localVars.inParamPaymentTermDesc }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), localVars.resGetNextMonday.outParamDays), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), localVars.resGetNextMonday.outParamDays), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENPaymentMethods.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.inParamInvoiceData.ssENOrderDetail.ssProjectDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssUUID }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENOrderMain.ssOrderNumber }, new STTextStructure(){ ssValue = Convert.ToString(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssPosition) } })),cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_AnticiposAccountingTextList, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// ListAppend2
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_AnticiposAccountingFinalList,new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join_outParamText },cancellationToken);

// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcl_AnticiposAccountingTextList,cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_AnticiposAccountingTextList,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = Convert.ToString(2) }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.inParamInvoiceData.ssENInvoice.ssId) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.inParamDocumentType }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoice.ssCurrency }, new STTextStructure(){ ssValue = (((localVars.inParamInvoiceData.ssENInvoice.ssCurrency!="MXN")) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.inParamInvoiceData.ssENInvoiceExtended.ssFechaEmision), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = BuiltInFunction.DecimalToText(localVars.inParamExchangeRate) }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssFolio }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.inParamInvoiceData.ssENOrderDetail.ssProjectDescription, "||", "--"), 0, 450) }, new STTextStructure(){ ssValue = localVars.inParamSecondCuenta }, new STTextStructure(){ ssValue = localVars.inParamSecondClave }, new STTextStructure(){ ssValue = ((localVars.inParamIsAnticipo) ? (localVars.inParamInvoiceData.ssENSupplier.ssNumber) : (localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENAccountingAccounts_ServiceType.ssCC)) }, new STTextStructure(){ ssValue = localVars.inParamICME }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDecimal ((localVars.inParamInvoiceData.ssENInvoiceExtended.ssSubtotal+localVars.inParamTaxToAdd), 2, ".", ",") }, new STTextStructure(){ ssValue = localVars.inParamIVAIndicator }, new STTextStructure(){ ssValue = localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENCostCenterSAP.ssCe_coste }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENRegion.ssDivisionFI }, new STTextStructure(){ ssValue = localVars.inParamPaymentTermDesc }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), localVars.resGetNextMonday.outParamDays), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), localVars.resGetNextMonday.outParamDays), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENPaymentMethods.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetUserExtendedInternalById_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssMaterialDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENInvoiceExtended.ssUUID }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.inParamInvoiceData.ssENOrderMain.ssOrderNumber }, new STTextStructure(){ ssValue = Convert.ToString(localVars.queryResGetOrderMainItemsByOrderMainId_outParamList.CurrentRec.ssENOrderMainItem.ssPosition) } })),cancellationToken);

// String_Join2
localVars.resString_Join2_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_AnticiposAccountingTextList, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// ListAppend3
await ExtendedActions.ListAppend(requestContext,localVars.varLcl_AnticiposAccountingFinalList,new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join2_outParamText },cancellationToken);

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
await Actions.ActionInvoiceDocumentRelationCreate(requestContext,localVars.inParamInvoiceData.ssENInvoice.ssId,localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA,localVars.inParamInvoiceData.ssENInvoice.ssID_POLIZA_SAP,((((string)AppUtils.SiteProperties[SitePropertiesModel.spInvoiceWithNoContractTable]))),cancellationToken);

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
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("SWfsbNhBcEyDfhURyeky7Q#Value.1410737295.1", "Error in SAP services. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionEntryAccounting_CallAccounting_Order {

private static async Task<RC_34d74f643477f98fc1cbb3375068d112> datasetGetOrderMainItemsByOrderMainIdReadDbAsync(RC_34d74f643477f98fc1cbb3375068d112 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainItemsByOrderMainId" 2LyPK0Ieh0qmCNGpKZF28A of Action "EntryAccounting_CallAccounting_Order"
public static async Task<(RL_68685adfd889e1cc20ee9267e233e63b,long)> datasetGetOrderMainItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CallAccounting_Order.GetOrderMainItemsByOrderMainId", "2b8fbcd8-1e42-4a87-a608-d1a9299176f0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CallAccounting_Order.GetOrderMainItemsByOrderMainId", "2b8fbcd8-1e42-4a87-a608-d1a9299176f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gvjW3v+7nUyZy5dacWSovw/NodesNotShownInESpaceTree.2LyPK0Ieh0qmCNGpKZF28A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingaccounts_servicetype3\".\"cc\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"encostcentersap6\".\"ce_coste\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, \"enordermainitem13\".\"position\" o35, NULL o36, \"enordermainitem13\".\"materialdescription\" o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, \"enregion54\".\"divisionfi\" o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96");
fromBuilder.Append(" FROM ((({OrderMainItem} \"enordermainitem13\" Left JOIN {Region} \"enregion54\" ON (\"enordermainitem13\".\"divisionid\" = \"enregion54\".\"id\"))  Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype3\" ON (\"enordermainitem13\".\"glaccountid\" = \"enaccountingaccounts_servicetype3\".\"id\"))  Left JOIN {CostCenterSAP} \"encostcentersap6\" ON (\"enordermainitem13\".\"costcenterid\" = \"encostcentersap6\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem13\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem13\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem13\".\"ordermainid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enordermainitem13\".\"position\" ASC ");
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
RL_68685adfd889e1cc20ee9267e233e63b outParamList = new RL_68685adfd889e1cc20ee9267e233e63b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CallAccounting_Order.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_68685adfd889e1cc20ee9267e233e63b _tmp = new RL_68685adfd889e1cc20ee9267e233e63b();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CallAccounting_Order.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_68685adfd889e1cc20ee9267e233e63b)_tmp;
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

// Query Function "GetUserExtendedInternalById" Lle7iLssAEaeM+xy6Fc_yg of Action "EntryAccounting_CallAccounting_Order"
public static async Task<(RL_216ae81da35dfe5cfaaa600823fb4c79,long)> datasetGetUserExtendedInternalById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("EntryAccounting_CallAccounting_Order.GetUserExtendedInternalById", "88bb572e-2cbb-4600-9e33-ec72e8573fca");
using var queryActivity = activitySource.CreateAggregateQueryActivity("EntryAccounting_CallAccounting_Order.GetUserExtendedInternalById", "88bb572e-2cbb-4600-9e33-ec72e8573fca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.gvjW3v+7nUyZy5dacWSovw/NodesNotShownInESpaceTree.Lle7iLssAEaeM+xy6Fc_yg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enuser_extended_internal73\".\"employeenumber\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19");
fromBuilder.Append(" FROM {User_Extended_Internal} \"enuser_extended_internal73\"");
whereBuilder.Append(" WHERE ");
if ((qpusId.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal73\".\"id\" = @qpusId) AND (\"enuser_extended_internal73\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusId", DbType.String, qpusId);
} else {
whereBuilder.Append("(\"enuser_extended_internal73\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query EntryAccounting_CallAccounting_Order.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query EntryAccounting_CallAccounting_Order.GetUserExtendedInternalById.List", cancellationToken: cancellationToken);
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



}


}
