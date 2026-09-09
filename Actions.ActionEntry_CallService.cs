namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallService : VarsBag {
public long inParamFolioId;
public bool inParamIsResend;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>PI_HEADER_EM</code> that represents the Service Studio PI_HEADER_EM
///  <code>PI_HEADER_EM</code> <p>Description: </p>
/// </summary>
public ST_1186519ca5bb238ab9fc7126d4696469Structure varLcPI_HEADER_EM = new ST_1186519ca5bb238ab9fc7126d4696469Structure();

/// <summary>
/// Variable <code>PI_ITEM_EM</code> that represents the Service Studio PI_ITEM_EM4
///  <code>PI_ITEM_EM</code> <p>Description: </p>
/// </summary>
public ST_5f3e5a981bd9e9a45ed03e989538932dStructure varLcPI_ITEM_EM = new ST_5f3e5a981bd9e9a45ed03e989538932dStructure();

/// <summary>
/// Variable <code>PI_HEADER_CECO</code> that represents the Service Studio PI_HEADER_CECO
///  <code>PI_HEADER_CECO</code> <p>Description: </p>
/// </summary>
public ST_b76a29481a19f994f96cb0bc4134fe6dStructure varLcPI_HEADER_CECO = new ST_b76a29481a19f994f96cb0bc4134fe6dStructure();

/// <summary>
/// Variable <code>PI_ITEM_EM_CECO</code> that represents the Service Studio PI_ITEM_EM_CECO
///  <code>PI_ITEM_EM_CECO</code> <p>Description: </p>
/// </summary>
public ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure varLcPI_ITEM_EM_CECO = new ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure();

/// <summary>
/// Variable <code>PI_ITEM_SM_CECO</code> that represents the Service Studio PI_ITEM_SM_CECO
///  <code>PI_ITEM_SM_CECO</code> <p>Description: </p>
/// </summary>
public ST_1241dbde99de907a27732884f6e65ab4Structure varLcPI_ITEM_SM_CECO = new ST_1241dbde99de907a27732884f6e65ab4Structure();

/// <summary>
/// Variable <code>PI_HEADER_MO</code> that represents the Service Studio PI_HEADER_MO
///  <code>PI_HEADER_MO</code> <p>Description: </p>
/// </summary>
public ST_16a23b6e422231c222f34612ecd6c640Structure varLcPI_HEADER_MO = new ST_16a23b6e422231c222f34612ecd6c640Structure();

/// <summary>
/// Variable <code>PI_ITEM_EM_MO</code> that represents the Service Studio PI_ITEM_EM_MO
///  <code>PI_ITEM_EM_MO</code> <p>Description: </p>
/// </summary>
public ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure varLcPI_ITEM_EM_MO = new ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure();

/// <summary>
/// Variable <code>PI_ITEM_SM_MO</code> that represents the Service Studio PI_ITEM_SM_MO
///  <code>PI_ITEM_SM_MO</code> <p>Description: </p>
/// </summary>
public ST_64e1f00088c363cc4d22cb46cb1c9dacStructure varLcPI_ITEM_SM_MO = new ST_64e1f00088c363cc4d22cb46cb1c9dacStructure();

/// <summary>
/// Variable <code>PI_HEADER_RM</code> that represents the Service Studio PI_HEADER_RM
///  <code>PI_HEADER_RM</code> <p>Description: </p>
/// </summary>
public ST_cab398c7a09085084636430b80f5aa0dStructure varLcPI_HEADER_RM = new ST_cab398c7a09085084636430b80f5aa0dStructure();

/// <summary>
/// Variable <code>PI_ITEM_EM_RM</code> that represents the Service Studio PI_ITEM_EM_RM
///  <code>PI_ITEM_EM_RM</code> <p>Description: </p>
/// </summary>
public ST_9689a124a3af07dbe86be1015d9b7bb1Structure varLcPI_ITEM_EM_RM = new ST_9689a124a3af07dbe86be1015d9b7bb1Structure();

/// <summary>
/// Variable <code>PI_ITEM_SM_RM</code> that represents the Service Studio PI_ITEM_SM_RM
///  <code>PI_ITEM_SM_RM</code> <p>Description: </p>
/// </summary>
public ST_145adfa176456c38d3985aa98c524483Structure varLcPI_ITEM_SM_RM = new ST_145adfa176456c38d3985aa98c524483Structure();

public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoEntry_CallService0Blocks resEntry_CallService0Blocks =  new Actions.lcoEntry_CallService0Blocks();
public RL_be0bc7b85db7b39f4a70be07d98b5bef queryResGetFolioItemsByFolioId_outParamList = new RL_be0bc7b85db7b39f4a70be07d98b5bef();
public long queryResGetFolioItemsByFolioId_outParamCount = 0L;

public Actions.lcoEntry_CallService3EM_SM_MO resEM_SM_MO =  new Actions.lcoEntry_CallService3EM_SM_MO();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate5 =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAdd2 =  new Actions.lcoFolioLogAdd();
public Actions.lcoEntry_CallService1EM resEM_COSMOZ =  new Actions.lcoEntry_CallService1EM();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate4 =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate3 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate4 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoEntry_CallService0Rules resEntry_CallService0Rules =  new Actions.lcoEntry_CallService0Rules();
public RL_1f9a243d40703326d9bf7c63586316cd queryResGetInvoicesByFolioId_outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public Actions.lcoEntry_CallService4EM_SM_RM resEM_SM_RM =  new Actions.lcoEntry_CallService4EM_SM_RM();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoGetAlmacenCodeByRegionId resGetAlmacenCodeByRegionId =  new Actions.lcoGetAlmacenCodeByRegionId();
public Actions.lcoFolioLogAdd resFolioLogAdd5 =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAddSAP =  new Actions.lcoFolioLogAdd();
public Actions.lcoEntry_CallService2EM_SM_CECO resEM_SM_CECO =  new Actions.lcoEntry_CallService2EM_SM_CECO();
public lcvEntry_CallService(long inParamFolioId, bool inParamIsResend, int inParamOffsetUtc) {
this.inParamFolioId = inParamFolioId;
this.inParamIsResend = inParamIsResend;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoEntry_CallService : VarsBag {
public string outParamErrorMsg = "";

public string outParamEntry = "";

public string outParamEjercicio = "";

public string outParamEntry_SM = "";

public string outParamEjercicio_SM = "";

public string outParamEntry_221 = "";

public string outParamEjercicio_221 = "";

public string outParamEntry_415 = "";

public string outParamEjercicio_415 = "";

public bool outParamIsWaitingSAP = false;

public bool outParamIsBlocked = false;

public bool outParamIsSuccess = true;

public lcoEntry_CallService() {
}
}
/// <summary>
/// Action <code>Entry_CallService</code> that represents the Service Studio action
///  <code>Entry_CallService</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string,string,string,string,string,string,string,string,bool,bool,bool)> ActionEntry_CallService(IRequestContext requestContext,long inParamFolioId,bool inParamIsResend,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
string outParamEntry = default;
string outParamEjercicio = default;
string outParamEntry_SM = default;
string outParamEjercicio_SM = default;
string outParamEntry_221 = default;
string outParamEjercicio_221 = default;
string outParamEntry_415 = default;
string outParamEjercicio_415 = default;
bool outParamIsWaitingSAP = default;
bool outParamIsBlocked = default;
bool outParamIsSuccess = default;
lcoEntry_CallService result = new lcoEntry_CallService();
lcvEntry_CallService localVars = new lcvEntry_CallService(inParamFolioId, inParamIsResend, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallService", "56b55196-09d5-4283-a7f9-8843ee73af2b"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallService", "56b55196-09d5-4283-a7f9-8843ee73af2b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetFolioItemsByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioItemsByFolioId_maxRecords = 0;
int datasetGetFolioItemsByFolioId_startIndex = 0;(localVars.queryResGetFolioItemsByFolioId_outParamList,localVars.queryResGetFolioItemsByFolioId_outParamCount) = await FuncActionEntry_CallService.datasetGetFolioItemsByFolioId(requestContext,datasetGetFolioItemsByFolioId_maxRecords,datasetGetFolioItemsByFolioId_startIndex,IterationMultiplicity.Multiple,localVars.inParamFolioId,cancellationToken);

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error Entry 06 May 26", ssDescription = ((((((((("Folio Id: "+BuiltInFunction.LongIntegerToText(localVars.inParamFolioId))+" // IsResend: ")+(localVars.inParamIsResend ? "True" : "False"))+" // Cuenta: ")+BuiltInFunction.LongIntegerToText(localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENOrderMainItem.ssGLAccountId))+" // Imp: ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolioItems.ssInputationCode)+" // CurrDate: ")+BuiltInFunction.DateTimeToText((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)))), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("V2dQp85GNEa+KvoKF26LPw"))).ssId },cancellationToken);

if((localVars.queryResGetFolioItemsByFolioId_outParamList.Empty)) {
// RaiseError ErrorSaving
throw new Ex_ErrorSavingUserException (AppUtils.GetStringResource("y99kiFhVVUuGmsGycPQN7A#Message.-1933092183.1", "No data from Folios"));

} else {
// auto entry
if(((!localVars.inParamIsResend))) {
// Entry_CallService0Blocks
localVars.resEntry_CallService0Blocks.outParamIsBlocked = await Actions.ActionEntry_CallService0Blocks(requestContext,localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolioItems.ssInputationCode,localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENOrderMainItem.ssGLAccountId,localVars.inParamOffsetUtc,cancellationToken);

// blocked
if((localVars.resEntry_CallService0Blocks.outParamIsBlocked)) {
// IsBlocked = True
result.outParamIsBlocked=true;

// GetFolioItemsByFolioId.List.Current.Folio.FolioStatusId = PendingEntryRequest
localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cKaejollq0a9gDFyfLxCKg"))).ssId;

// ErrorMsg = "Folio" + " " + GetFolioItemsByFolioId.List.Current.Folio.FolioNumber + " " + "has been updated to Pending Entry Request" + ". " + "Account closure applies to Code" + " " + GetFolioItemsByFolioId.List.Current.FolioItems.InputationCode + " " + "with account" + " " + GetFolioItemsByFolioId.List.Current.AccountingAccounts_ServiceType.CC + "."
result.outParamErrorMsg=(((((((((((((AppUtils.GetStringResource("83XVuwYfX0qfJebFYSkfZQ#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("83XVuwYfX0qfJebFYSkfZQ#Value.1910359558.1", "has been updated to Pending Entry Request"))+". ")+AppUtils.GetStringResource("83XVuwYfX0qfJebFYSkfZQ#Value.324710406.1", "Account closure applies to Code"))+" ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolioItems.ssInputationCode)+" ")+AppUtils.GetStringResource("83XVuwYfX0qfJebFYSkfZQ#Value.1215213779.1", "with account"))+" ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENAccountingAccounts_ServiceType.ssCC)+".");
// FolioCreateOrUpdate4
localVars.resFolioCreateOrUpdate4.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssMessage = (((((((((((((AppUtils.GetStringResource("6hSiM+tnDUW4Vp6Bbg8Dhw#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("6hSiM+tnDUW4Vp6Bbg8Dhw#Value.1910359558.1", "has been updated to Pending Entry Request"))+".")+AppUtils.GetStringResource("6hSiM+tnDUW4Vp6Bbg8Dhw#Value.324710406.1", "Account closure applies to Code"))+" ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolioItems.ssInputationCode)+" ")+AppUtils.GetStringResource("6hSiM+tnDUW4Vp6Bbg8Dhw#Value.1215213779.1", "with account"))+" ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENAccountingAccounts_ServiceType.ssCC)+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

goto RETURN_STATEMENT;

}

}

// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 1;
if (datasetGetInvoicesByFolioId_maxRecords < 1) datasetGetInvoicesByFolioId_maxRecords = 1;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncActionEntry_CallService.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Never,localVars.inParamFolioId,cancellationToken);

// GetAlmacenCodeByRegionId
localVars.resGetAlmacenCodeByRegionId.outParamStoreCode = await Actions.ActionGetAlmacenCodeByRegionId(requestContext,localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENOrderMain.ssRegionId,cancellationToken);

// PI_HEADER_A
// PI_HEADER_EM.PEDIDO = GetFolioItemsByFolioId.List.Current.OrderMain.OrderNumber
localVars.varLcPI_HEADER_EM.ssPEDIDO = localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;

// PI_HEADER_EM.PROVEEDOR = GetFolioItemsByFolioId.List.Current.Supplier.Number
localVars.varLcPI_HEADER_EM.ssPROVEEDOR = localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENSupplier.ssNumber;

// PI_HEADER_EM.NUMERO_FACTURA = GetInvoicesByFolioId.List.Current.Invoice.Name
localVars.varLcPI_HEADER_EM.ssNUMERO_FACTURA = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName;

// PI_HEADER_EM.CARTA_PORTE = ""
localVars.varLcPI_HEADER_EM.ssCARTA_PORTE = "";

// PI_HEADER_EM.TEXTO_CABECERA = GetFolioItemsByFolioId.List.Current.Folio.FolioNumber
localVars.varLcPI_HEADER_EM.ssTEXTO_CABECERA = localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber;

// PI_HEADER_EM.UUID = GetInvoicesByFolioId.List.Current.InvoiceExtended.UUID
localVars.varLcPI_HEADER_EM.ssUUID = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoiceExtended.ssUUID;

// PI_HEADER_EM.FECHA_CONTABILIZACION = FormatDateTime
localVars.varLcPI_HEADER_EM.ssFECHA_CONTABILIZACION = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "dd.MM.yyyy");

// PI_HEADER_EM.FECHA_REGISTRO = FormatDateTime
localVars.varLcPI_HEADER_EM.ssFECHA_REGISTRO = BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoiceExtended.ssFechaEmision), "dd.MM.yyyy");
// PI_HEADER_B, C, D
// PI_HEADER_CECO = PI_HEADER_EM
localVars.varLcPI_HEADER_CECO=(await RecordUtils.ConvertAsync(localVars.varLcPI_HEADER_EM, new ST_b76a29481a19f994f96cb0bc4134fe6dStructure(), async (ST_1186519ca5bb238ab9fc7126d4696469Structure source, ST_b76a29481a19f994f96cb0bc4134fe6dStructure target, CancellationToken cancellationToken) => {
target.ssPEDIDO = source.ssPEDIDO;
target.ssPROVEEDOR = source.ssPROVEEDOR;
target.ssNUMERO_FACTURA = source.ssNUMERO_FACTURA;
target.ssCARTA_PORTE = source.ssCARTA_PORTE;
target.ssTEXTO_CABECERA = localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
target.ssUUID = source.ssUUID;
target.ssFECHA_CONTABILIZACION = source.ssFECHA_CONTABILIZACION;
target.ssFECHA_REGISTRO = source.ssFECHA_REGISTRO;
target.ssVALE_MATERIAL_SM = localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
target.ssTEXTO_CABECERA_SM = localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber;
return target;
}, cancellationToken));

// PI_HEADER_MO = PI_HEADER_CECO
localVars.varLcPI_HEADER_MO=(await RecordUtils.ConvertAsync(localVars.varLcPI_HEADER_CECO, new ST_16a23b6e422231c222f34612ecd6c640Structure(), async (ST_b76a29481a19f994f96cb0bc4134fe6dStructure source, ST_16a23b6e422231c222f34612ecd6c640Structure target, CancellationToken cancellationToken) => {
target.ssPEDIDO = source.ssPEDIDO;
target.ssPROVEEDOR = source.ssPROVEEDOR;
target.ssNUMERO_FACTURA = source.ssNUMERO_FACTURA;
target.ssCARTA_PORTE = source.ssCARTA_PORTE;
target.ssTEXTO_CABECERA = source.ssTEXTO_CABECERA;
target.ssUUID = source.ssUUID;
target.ssFECHA_CONTABILIZACION = source.ssFECHA_CONTABILIZACION;
target.ssFECHA_REGISTRO = source.ssFECHA_REGISTRO;
target.ssVALE_MATERIAL_SM = source.ssVALE_MATERIAL_SM;
target.ssTEXTO_CABECERA_SM = source.ssTEXTO_CABECERA_SM;
return target;
}, cancellationToken));

// PI_HEADER_RM = PI_HEADER_CECO
localVars.varLcPI_HEADER_RM=(await RecordUtils.ConvertAsync(localVars.varLcPI_HEADER_CECO, new ST_cab398c7a09085084636430b80f5aa0dStructure(), async (ST_b76a29481a19f994f96cb0bc4134fe6dStructure source, ST_cab398c7a09085084636430b80f5aa0dStructure target, CancellationToken cancellationToken) => {
target.ssPEDIDO = source.ssPEDIDO;
target.ssPROVEEDOR = source.ssPROVEEDOR;
target.ssNUMERO_FACTURA = source.ssNUMERO_FACTURA;
target.ssCARTA_PORTE = source.ssCARTA_PORTE;
target.ssTEXTO_CABECERA = source.ssTEXTO_CABECERA;
target.ssUUID = source.ssUUID;
target.ssFECHA_CONTABILIZACION = source.ssFECHA_CONTABILIZACION;
target.ssFECHA_REGISTRO = source.ssFECHA_REGISTRO;
target.ssVALE_MATERIAL_SM = source.ssVALE_MATERIAL_SM;
target.ssTEXTO_CABECERA_SM = source.ssTEXTO_CABECERA_SM;
return target;
}, cancellationToken));
// Entry_CallService0Rules
(localVars.resEntry_CallService0Rules.outParamServicio,localVars.resEntry_CallService0Rules.outParamPEP_Pedido,localVars.resEntry_CallService0Rules.outParamPEP_Inserido,localVars.resEntry_CallService0Rules.outParamImputationCode) = await Actions.ActionEntry_CallService0Rules(requestContext,localVars.queryResGetFolioItemsByFolioId_outParamList,cancellationToken);

if(((localVars.resEntry_CallService0Rules.outParamServicio==Convert.ToString(1)))) {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcPI_ITEM_EM.ssItem,(await RL_e2d9cd11480e1409ddda73914c4a2843.ConvertAsync(localVars.queryResGetFolioItemsByFolioId_outParamList, new RL_e2d9cd11480e1409ddda73914c4a2843(), async (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 source, ST_6a8665543a0f720f26db84a82f35885fStructure target, CancellationToken cancellationToken) => {
target.ssPOSICION_PEDIDO = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssMATERIAL = source.ssENOrderMainItem.ssMaterialCode;
target.ssCANTIDAD_ENTRADA = BuiltInFunction.DecimalToText(source.ssENFolioItems.ssInvoiceQtt);
target.ssCENTRO = source.ssENOrderMainItem.ssCenter;
target.ssALMACEN = localVars.resGetAlmacenCodeByRegionId.outParamStoreCode;
target.ssTEXTO_POSICION = ((source.ssENOrderMain.ssOrderNumber+" ")+localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName);
return target;
}, cancellationToken)),cancellationToken);

// LogsAccountingCreate3
localVars.resLogsAccountingCreate3.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error Entry 06 May 26", ssDescription = ((((((((((("PI_ITEM_EM - POSICION: "+localVars.varLcPI_ITEM_EM.ssItem.CurrentRec.ssPOSICION_PEDIDO)+" // MATERIAL: ")+localVars.varLcPI_ITEM_EM.ssItem.CurrentRec.ssMATERIAL)+" // QT_ENTR: ")+localVars.varLcPI_ITEM_EM.ssItem.CurrentRec.ssCANTIDAD_ENTRADA)+" // CENTRO: ")+localVars.varLcPI_ITEM_EM.ssItem.CurrentRec.ssCENTRO)+" // ALMACEN: ")+localVars.varLcPI_ITEM_EM.ssItem.CurrentRec.ssALMACEN)+" // TEXTO_POS: ")+localVars.varLcPI_ITEM_EM.ssItem.CurrentRec.ssTEXTO_POSICION), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("V2dQp85GNEa+KvoKF26LPw"))).ssId },cancellationToken);

// EM_COSMOZ
(localVars.resEM_COSMOZ.outParamEntry,localVars.resEM_COSMOZ.outParamErrorMsg,localVars.resEM_COSMOZ.outParamEjercicio) = await Actions.ActionEntry_CallService1EM(requestContext,new ST_54b441362fa983751bf9575ed6b668beStructure(){ ssPI_HEADER = localVars.varLcPI_HEADER_EM, ssPI_ITEM = localVars.varLcPI_ITEM_EM },localVars.inParamFolioId,cancellationToken);

// ErrorMsg = EM_COSMOZ.ErrorMsg
result.outParamErrorMsg=localVars.resEM_COSMOZ.outParamErrorMsg;

// Entry = EM_COSMOZ.Entry
result.outParamEntry=localVars.resEM_COSMOZ.outParamEntry;

// Ejercicio = EM_COSMOZ.Ejercicio
result.outParamEjercicio=localVars.resEM_COSMOZ.outParamEjercicio;
} else {
if((localVars.resEntry_CallService0Rules.outParamServicio==Convert.ToString(2))) {
// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcPI_ITEM_EM_CECO.ssItem,(await RL_e2d9cd11480e1409ddda73914c4a2843.ConvertAsync(localVars.queryResGetFolioItemsByFolioId_outParamList, new RL_e2d9cd11480e1409ddda73914c4a2843(), async (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 source, ST_6a8665543a0f720f26db84a82f35885fStructure target, CancellationToken cancellationToken) => {
target.ssPOSICION_PEDIDO = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssMATERIAL = source.ssENOrderMainItem.ssMaterialCode;
target.ssCANTIDAD_ENTRADA = BuiltInFunction.DecimalToText(source.ssENFolioItems.ssInvoiceQtt);
target.ssCENTRO = source.ssENOrderMainItem.ssCenter;
target.ssALMACEN = localVars.resGetAlmacenCodeByRegionId.outParamStoreCode;
target.ssTEXTO_POSICION = ((source.ssENOrderMain.ssOrderNumber+" ")+localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName);
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll5
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcPI_ITEM_SM_CECO.ssItem,(await RL_58f0d660c2772ea329be34fddf4b9ec9.ConvertAsync(localVars.queryResGetFolioItemsByFolioId_outParamList, new RL_58f0d660c2772ea329be34fddf4b9ec9(), async (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 source, ST_ab77394b00ae0f5875687584d175cf59Structure target, CancellationToken cancellationToken) => {
target.ssPOSICION_PEDIDO = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssMATERIAL = source.ssENOrderMainItem.ssMaterialCode;
target.ssCANTIDAD_SALIDA = BuiltInFunction.DecimalToText(source.ssENFolioItems.ssInvoiceQtt);
target.ssCENTRO = source.ssENOrderMainItem.ssCenter;
target.ssALMACEN = localVars.resGetAlmacenCodeByRegionId.outParamStoreCode;
target.ssTEXTO_POSICION = ((source.ssENOrderMain.ssOrderNumber+" ")+localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName);
target.ssCUENTA_DE_MAYOR = source.ssENAccountingAccounts_ServiceType.ssCC;
target.ssCENTRO_DE_COSTO = source.ssENCostCenterSAP.ssCe_coste;
return target;
}, cancellationToken)),cancellationToken);

// EM_SM_CECO
(localVars.resEM_SM_CECO.outParamEntry_EM,localVars.resEM_SM_CECO.outParamEntry_SM,localVars.resEM_SM_CECO.outParamErrorMsg,localVars.resEM_SM_CECO.outParamEjercicio_EM,localVars.resEM_SM_CECO.outParamEjercicio_SM,localVars.resEM_SM_CECO.outParamGroupFolio) = await Actions.ActionEntry_CallService2EM_SM_CECO(requestContext,new ST_883584831b34399a326748c4b1ce95c9Structure(){ ssPI_HEADER = localVars.varLcPI_HEADER_CECO, ssPI_ITEM_EM = localVars.varLcPI_ITEM_EM_CECO, ssPI_ITEM_SM = localVars.varLcPI_ITEM_SM_CECO },localVars.inParamFolioId,cancellationToken);

// ErrorMsg = EM_SM_CECO.ErrorMsg
result.outParamErrorMsg=localVars.resEM_SM_CECO.outParamErrorMsg;

// Entry = EM_SM_CECO.Entry_EM
result.outParamEntry=localVars.resEM_SM_CECO.outParamEntry_EM;

// Ejercicio = EM_SM_CECO.Ejercicio_EM
result.outParamEjercicio=localVars.resEM_SM_CECO.outParamEjercicio_EM;

// Entry_SM = EM_SM_CECO.Entry_SM
result.outParamEntry_SM=localVars.resEM_SM_CECO.outParamEntry_SM;

// Ejercicio_SM = EM_SM_CECO.Ejercicio_SM
result.outParamEjercicio_SM=localVars.resEM_SM_CECO.outParamEjercicio_SM;
} else {
if((localVars.resEntry_CallService0Rules.outParamServicio==Convert.ToString(3))) {
// ListAppendAll3
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcPI_ITEM_EM_MO.ssItem,(await RL_4d0d602433bf72956981903b88f22e91.ConvertAsync(localVars.queryResGetFolioItemsByFolioId_outParamList, new RL_4d0d602433bf72956981903b88f22e91(), async (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 source, ST_8367d678111f49d602545a0a640615d6Structure target, CancellationToken cancellationToken) => {
target.ssPOSICION_PEDIDO = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssMATERIAL = source.ssENOrderMainItem.ssMaterialCode;
target.ssCANTIDAD_ENTRADA = BuiltInFunction.DecimalToText(source.ssENFolioItems.ssInvoiceQtt);
target.ssCENTRO = source.ssENOrderMainItem.ssCenter;
target.ssALMACEN = localVars.resGetAlmacenCodeByRegionId.outParamStoreCode;
target.ssTEXTO_POSICION = ((source.ssENOrderMain.ssOrderNumber+" ")+localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName);
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll6
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcPI_ITEM_SM_MO.ssItem,(await RL_3bcfc0997e979683ea6eaec348a88df0.ConvertAsync(localVars.queryResGetFolioItemsByFolioId_outParamList, new RL_3bcfc0997e979683ea6eaec348a88df0(), async (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 source, ST_67da2825930e4cc01dda17107c43d1e6Structure target, CancellationToken cancellationToken) => {
target.ssPOSICION_PEDIDO = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssMATERIAL = source.ssENOrderMainItem.ssMaterialCode;
target.ssCANTIDAD_SALIDA = BuiltInFunction.DecimalToText(source.ssENFolioItems.ssInvoiceQtt);
target.ssCENTRO = source.ssENOrderMainItem.ssCenter;
target.ssALMACEN = localVars.resGetAlmacenCodeByRegionId.outParamStoreCode;
target.ssPEP_EMISOR = source.ssENOrderMainItem.ssPEPElement;
target.ssPEP_RECEPTOR = source.ssENFolioItems.ssPEP;
target.ssTEXTO_POSICION = ((source.ssENOrderMain.ssOrderNumber+" ")+localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName);
target.ssID_SITIO = source.ssENFolioItems.ssPlaceId;
return target;
}, cancellationToken)),cancellationToken);

// EM_SM_MO
(localVars.resEM_SM_MO.outParamEntry_EM,localVars.resEM_SM_MO.outParamEntry_221,localVars.resEM_SM_MO.outParamEntry_415,localVars.resEM_SM_MO.outParamErrorMsg,localVars.resEM_SM_MO.outParamEjercicio,localVars.resEM_SM_MO.outParamEjercicio_221,localVars.resEM_SM_MO.outParamEjercicio_415) = await Actions.ActionEntry_CallService3EM_SM_MO(requestContext,new ST_e88e810a3be3c7b278de1b477e897388Structure(){ ssPI_HEADER = localVars.varLcPI_HEADER_MO, ssPI_ITEM_EM = localVars.varLcPI_ITEM_EM_MO, ssPI_ITEM_SM = localVars.varLcPI_ITEM_SM_MO },localVars.inParamFolioId,cancellationToken);

// ErrorMsg = EM_SM_MO.ErrorMsg
result.outParamErrorMsg=localVars.resEM_SM_MO.outParamErrorMsg;

// Entry = EM_SM_MO.Entry_EM
result.outParamEntry=localVars.resEM_SM_MO.outParamEntry_EM;

// Ejercicio = EM_SM_MO.Ejercicio
result.outParamEjercicio=localVars.resEM_SM_MO.outParamEjercicio;

// Entry_221 = EM_SM_MO.Entry_221
result.outParamEntry_221=localVars.resEM_SM_MO.outParamEntry_221;

// Ejercicio_221 = EM_SM_MO.Ejercicio_221
result.outParamEjercicio_221=localVars.resEM_SM_MO.outParamEjercicio_221;

// Entry_415 = EM_SM_MO.Entry_415
result.outParamEntry_415=localVars.resEM_SM_MO.outParamEntry_415;

// Ejercicio_415 = Ejercicio_415
result.outParamEjercicio_415=result.outParamEjercicio_415;
} else {
if((localVars.resEntry_CallService0Rules.outParamServicio==Convert.ToString(4))) {
// ListAppendAll4
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcPI_ITEM_EM_RM.ssItem,(await RL_14f7fedf363c5e2bd9b617b5d8baba14.ConvertAsync(localVars.queryResGetFolioItemsByFolioId_outParamList, new RL_14f7fedf363c5e2bd9b617b5d8baba14(), async (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 source, ST_121fe028e1d357d74e80a524b7b1ba16Structure target, CancellationToken cancellationToken) => {
target.ssPOSICION_PEDIDO = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssMATERIAL = source.ssENOrderMainItem.ssMaterialCode;
target.ssCANTIDAD_ENTRADA = BuiltInFunction.DecimalToText(source.ssENFolioItems.ssInvoiceQtt);
target.ssCENTRO = source.ssENOrderMainItem.ssCenter;
target.ssALMACEN = localVars.resGetAlmacenCodeByRegionId.outParamStoreCode;
target.ssTEXTO_POSICION = ((source.ssENOrderMain.ssOrderNumber+" ")+localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName);
return target;
}, cancellationToken)),cancellationToken);

// ListAppendAll7
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcPI_ITEM_SM_RM.ssItem,(await RL_943f32302be61b51261512f4da403b2f.ConvertAsync(localVars.queryResGetFolioItemsByFolioId_outParamList, new RL_943f32302be61b51261512f4da403b2f(), async (RC_5a6246801ed2c6cdc40cd9bd72ee2c64 source, ST_c6a30ab803e481b26794961e87468e52Structure target, CancellationToken cancellationToken) => {
target.ssPOSICION_PEDIDO = Convert.ToString(source.ssENOrderMainItem.ssPosition);
target.ssMATERIAL = source.ssENOrderMainItem.ssMaterialCode;
target.ssCANTIDAD_SALIDA = BuiltInFunction.DecimalToText(source.ssENFolioItems.ssInvoiceQtt);
target.ssCENTRO = source.ssENOrderMainItem.ssCenter;
target.ssALMACEN = localVars.resGetAlmacenCodeByRegionId.outParamStoreCode;
target.ssPEP_EMISOR = source.ssENOrderMainItem.ssPEPElement;
target.ssPEP_RECEPTOR = source.ssENFolioItems.ssPEP;
target.ssTEXTO_POSICION = ((source.ssENOrderMain.ssOrderNumber+" ")+localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName);
target.ssID_SITIO = source.ssENFolioItems.ssPlaceId;
return target;
}, cancellationToken)),cancellationToken);

// EM_SM_RM
(localVars.resEM_SM_RM.outParamEntry,localVars.resEM_SM_RM.outParamErrorMsg,localVars.resEM_SM_RM.outParamEjercicio,localVars.resEM_SM_RM.outParamGroupFolio) = await Actions.ActionEntry_CallService4EM_SM_RM(requestContext,new ST_b38fe38940c72474a8e67442651bc995Structure(){ ssPI_HEADER = localVars.varLcPI_HEADER_RM, ssPI_ITEM_EM = localVars.varLcPI_ITEM_EM_RM, ssPI_ITEM_SM = localVars.varLcPI_ITEM_SM_RM },localVars.inParamFolioId,cancellationToken);

// ErrorMsg = EM_SM_RM.ErrorMsg
result.outParamErrorMsg=localVars.resEM_SM_RM.outParamErrorMsg;

// Entry = EM_SM_RM.Entry
result.outParamEntry=localVars.resEM_SM_RM.outParamEntry;

// Ejercicio = EM_SM_RM.Ejercicio
result.outParamEjercicio=localVars.resEM_SM_RM.outParamEjercicio;

// IsWaitingSAP = True
result.outParamIsWaitingSAP=true;
} else {
// ErrorMsg = "Combination of Imputation Code and PEP didn't meet a rule required."
result.outParamErrorMsg=AppUtils.GetStringResource("8W_8ivh6lEaZHmkVUbcdGg#Value.66683714.1", "Combination of Imputation Code and PEP didn't meet a rule required.");
// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call No service", ssDescription = ((((("ImputationCode "+localVars.resEntry_CallService0Rules.outParamImputationCode)+" // PEP Pedido")+localVars.resEntry_CallService0Rules.outParamPEP_Pedido)+" // PEP Inserido ")+localVars.resEntry_CallService0Rules.outParamPEP_Inserido), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

goto RETURN_STATEMENT;

}

}

}

}

// error?
if(((result.outParamErrorMsg!=""))) {
// Folio_Status_Error
// GetFolioItemsByFolioId.List.Current.Folio.FolioStatusId = FailedEntryRequest
localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("QxrbM7PI8EeSs3w6T0KALg"))).ssId;

// GetFolioItemsByFolioId.List.Current.Folio.SAPEntryError = ErrorMsg
localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssSAPEntryError = result.outParamErrorMsg;
// FolioCreateOrUpdate5
localVars.resFolioCreateOrUpdate5.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio,cancellationToken);

// FolioLogAdd5
localVars.resFolioLogAdd5.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssMessage = (AppUtils.GetStringResource("pr+iFFfbz0eB5VioYpBcMQ#Value.1318877506.1", "Entry request has failed")+"!"), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// FolioLogAdd2
localVars.resFolioLogAdd2.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssMessage = (((((AppUtils.GetStringResource("YfAi603Otk6+j5oAjWcL1A#Value.68060425.1", "Folio")+" ")+localVars.queryResGetFolioItemsByFolioId_outParamList.CurrentRec.ssENFolio.ssFolioNumber)+" ")+AppUtils.GetStringResource("YfAi603Otk6+j5oAjWcL1A#Value.-953405950.1", "has been updated to Failed Entry Request status"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

// FolioLogAddSAP
localVars.resFolioLogAddSAP.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamFolioId, ssMessage = result.outParamErrorMsg, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true },cancellationToken);

// SendEmailApprovers_FailedEntry
await Actions.ActionSendEmailApprovers_FailedEntry(requestContext,localVars.inParamFolioId,cancellationToken);

}

}

} //close CreateActionActivity using block
} // try

catch (Ex_ErrorSavingUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// LogsAccountingCreate4
localVars.resLogsAccountingCreate4.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Error Entry 06 May 26", ssDescription = ((("Folio Id: "+BuiltInFunction.LongIntegerToText(localVars.inParamFolioId))+" // IsResend: ")+(localVars.inParamIsResend ? "True" : "False")), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("V2dQp85GNEa+KvoKF26LPw"))).ssId },cancellationToken);

// ErrorMsg = ErrorSaving.ExceptionMessage
result.outParamErrorMsg=ex.Message;

// IsSuccess = False
result.outParamIsSuccess=false;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamEntry = result.outParamEntry;
outParamEjercicio = result.outParamEjercicio;
outParamEntry_SM = result.outParamEntry_SM;
outParamEjercicio_SM = result.outParamEjercicio_SM;
outParamEntry_221 = result.outParamEntry_221;
outParamEjercicio_221 = result.outParamEjercicio_221;
outParamEntry_415 = result.outParamEntry_415;
outParamEjercicio_415 = result.outParamEjercicio_415;
outParamIsWaitingSAP = result.outParamIsWaitingSAP;
outParamIsBlocked = result.outParamIsBlocked;
outParamIsSuccess = result.outParamIsSuccess;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamEntry,outParamEjercicio,outParamEntry_SM,outParamEjercicio_SM,outParamEntry_221,outParamEjercicio_221,outParamEntry_415,outParamEjercicio_415,outParamIsWaitingSAP,outParamIsBlocked,outParamIsSuccess);
}

public static class FuncActionEntry_CallService {

private static async Task<RC_5a6246801ed2c6cdc40cd9bd72ee2c64> datasetGetFolioItemsByFolioIdReadDbAsync(RC_5a6246801ed2c6cdc40cd9bd72ee2c64 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioItems.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetFolioItemsByFolioId" 1IQDJ0sUq0ep+SUHvC2yUw of Action "Entry_CallService"
public static async Task<(RL_be0bc7b85db7b39f4a70be07d98b5bef,long)> datasetGetFolioItemsByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolio_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Entry_CallService.GetFolioItemsByFolioId", "270384d4-144b-47ab-a9f9-2507bc2db253");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Entry_CallService.GetFolioItemsByFolioId", "270384d4-144b-47ab-a9f9-2507bc2db253", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.llG1VtUJg0Kn+YhD7nOvKw/NodesNotShownInESpaceTree.1IQDJ0sUq0ep+SUHvC2yUw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingaccounts_servicetype1\".\"id\" o0, \"enaccountingaccounts_servicetype1\".\"cc\" o1, \"enaccountingaccounts_servicetype1\".\"description\" o2, \"enaccountingaccounts_servicetype1\".\"isactive\" o3, \"enaccountingaccounts_servicetype1\".\"createdby\" o4, \"enaccountingaccounts_servicetype1\".\"createdon\" o5, \"enaccountingaccounts_servicetype1\".\"updatedby\" o6, \"enaccountingaccounts_servicetype1\".\"updatedon\" o7, \"encostcentersap4\".\"id\" o8, \"encostcentersap4\".\"regionid\" o9, \"encostcentersap4\".\"companyid\" o10, \"encostcentersap4\".\"soc_\" o11, \"encostcentersap4\".\"div_\" o12, \"encostcentersap4\".\"area\" o13, \"encostcentersap4\".\"ce_coste\" o14, \"encostcentersap4\".\"cebe\" o15, \"encostcentersap4\".\"denominacion\" o16, \"encostcentersap4\".\"descripcion\" o17, \"encostcentersap4\".\"responsable\" o18, \"encostcentersap4\".\"ceco\" o19, \"encostcentersap4\".\"costesprim_reales_ind_debloq\" o20, \"encostcentersap4\".\"costessecund_reales_ind_debl\" o21, \"encostcentersap4\".\"ingresosreales_ind_debloqueo\" o22, \"encostcentersap4\".\"actualiz_comprom__ind_debloq\" o23, \"encostcentersap4\".\"costesprimariosplan_ind_debl\" o24, \"encostcentersap4\".\"costessecund_plan_ind_debloq\" o25, \"encostcentersap4\".\"ingresosplan_ind_debloqueo_\" o26, \"encostcentersap4\".\"autor\" o27, \"encostcentersap4\".\"createdon\" o28, \"encostcentersap4\".\"createdby\" o29, \"encostcentersap4\".\"updatedon\" o30, \"encostcentersap4\".\"updatedby\" o31, \"encostcentersap4\".\"isactive\" o32, \"enfolio14\".\"id\" o33, \"enfolio14\".\"isdraft\" o34, \"enfolio14\".\"folionumber\" o35, \"enfolio14\".\"canproveedorcancel\" o36, \"enfolio14\".\"orderid\" o37, \"enfolio14\".\"supplierid\" o38, \"enfolio14\".\"companyid\" o39, \"enfolio14\".\"foliostatusid\" o40, trim_scale(\"enfolio14\".\"totalamount\"::numeric) o41, trim_scale(\"enfolio14\".\"totaliva_amount\"::numeric) o42, trim_scale(\"enfolio14\".\"partialamount\"::numeric) o43, \"enfolio14\".\"currencyid\" o44, \"enfolio14\".\"firstapproveruserid\" o45, \"enfolio14\".\"approvalprocesstypeid\" o46, \"enfolio14\".\"sapentryerror\" o47, \"enfolio14\".\"createdby\" o48, \"enfolio14\".\"createdon\" o49, \"enfolio14\".\"updatedby\" o50, \"enfolio14\".\"updatedon\" o51, \"enfolio14\".\"minuteselected\" o52, \"enfolioitems2\".\"id\" o53, \"enfolioitems2\".\"folioid\" o54, \"enfolioitems2\".\"ordermainitemid\" o55, \"enfolioitems2\".\"ordernumber\" o56, \"enfolioitems2\".\"articlenumber\" o57, \"enfolioitems2\".\"description\" o58, \"enfolioitems2\".\"inputationcode\" o59, \"enfolioitems2\".\"deliverydate\" o60, trim_scale(\"enfolioitems2\".\"invoiceqtt\"::numeric) o61, trim_scale(\"enfolioitems2\".\"remainingqtt\"::numeric) o62, trim_scale(\"enfolioitems2\".\"unitprice\"::numeric) o63, trim_scale(\"enfolioitems2\".\"totalprice\"::numeric) o64, trim_scale(\"enfolioitems2\".\"quantity\"::numeric) o65, \"enfolioitems2\".\"deliveryqtt\" o66, \"enfolioitems2\".\"importdelivery\" o67, \"enfolioitems2\".\"pep\" o68, \"enfolioitems2\".\"placeid\" o69, \"enfolioitems2\".\"placename\" o70, \"enorderdetail2\".\"orderid\" o71, \"enorderdetail2\".\"isapprovalfromuserarea\" o72, \"enorderdetail2\".\"projectassetserviceid\" o73, \"enorderdetail2\".\"projectassetservice\" o74, \"enorderdetail2\".\"projectdescription\" o75, \"enorderdetail2\".\"businessvaluecategoryid\" o76, \"enorderdetail2\".\"businessvaluesubcategoryid\" o77, \"enorderdetail2\".\"paymenttermsid\" o78, \"enorderdetail2\".\"paymentmethodid\" o79, trim_scale(\"enorderdetail2\".\"negotiatedexchangerate\"::numeric) o80, \"enorderdetail2\".\"contractstatus\" o81, \"enorderdetail2\".\"dateofcommitment\" o82, \"enorderdetail2\".\"hasdeposit\" o83, \"enorderdetail2\".\"hasinsurance\" o84, \"enorderdetail2\".\"distributionid\" o85, \"enorderdetail2\".\"hasadvancepayment\" o86, trim_scale(\"enorderdetail2\".\"retentionrate\"::numeric) o87, \"enorderdetail2\".\"hasbasedate\" o88, \"enorderdetail2\".\"startbasedate\" o89, \"enorderdetail2\".\"endbasedate\" o90, \"enorderdetail2\".\"contractnumber\" o91, \"enorderdetail2\".\"isretentionapplied\" o92, \"enorderdetail2\".\"frequency\" o93, \"enorderdetail2\".\"period\" o94, \"enorderdetail2\".\"orderretentiontypeid\" o95, \"enorderdetail2\".\"paymentoptionsid\" o96, \"enorderdetail2\".\"paymentwaysid\" o97, \"enorderdetail2\".\"orderscontract\" o98, trim_scale(\"enorderdetail2\".\"contractamount\"::numeric) o99, trim_scale(\"enorderdetail2\".\"contracttarif\"::numeric) o100, \"enorderdetail2\".\"contractsupplier\" o101, \"enorderdetail2\".\"isdependentfromfolios\" o102, \"enorderdetail2\".\"specialapprovalid\" o103, \"enorderdetail2\".\"createdby\" o104, \"enorderdetail2\".\"createdon\" o105, \"enorderdetail2\".\"updatedby\" o106, \"enorderdetail2\".\"updatedon\" o107, \"enorderdetail2\".\"allcontactfilesvalidated\" o108, \"enorderdetail2\".\"hasntrequestdocuments\" o109, \"enordermain25\".\"id\" o110, \"enordermain25\".\"ordernumber\" o111, \"enordermain25\".\"orderdate\" o112, \"enordermain25\".\"orderstatusid\" o113, \"enordermain25\".\"previousorderstatusid\" o114, \"enordermain25\".\"assignmentcode\" o115, \"enordermain25\".\"supplierid\" o116, \"enordermain25\".\"companyid\" o117, \"enordermain25\".\"documenttypeid\" o118, \"enordermain25\".\"currencyid\" o119, \"enordermain25\".\"telceldirectionid\" o120, \"enordermain25\".\"procurementgroup\" o121, \"enordermain25\".\"creatorsapnumber\" o122, \"enordermain25\".\"creatorsapname\" o123, \"enordermain25\".\"country\" o124, \"enordermain25\".\"isdeleted\" o125, \"enordermain25\".\"isreleased\" o126, trim_scale(\"enordermain25\".\"exchangerate\"::numeric) o127, \"enordermain25\".\"sustainabilitycategory\" o128, \"enordermain25\".\"sustainabilitysubcategory\" o129, trim_scale(\"enordermain25\".\"totalamount\"::numeric) o130, \"enordermain25\".\"fromcosmoz\" o131, \"enordermain25\".\"regionid\" o132, \"enordermain25\".\"divisionid\" o133, \"enordermain25\".\"applicant\" o134, \"enordermain25\".\"createdby\" o135, \"enordermain25\".\"createdon\" o136, \"enordermain25\".\"updatedby\" o137, \"enordermain25\".\"updatedon\" o138, \"enordermainitem4\".\"id\" o139, \"enordermainitem4\".\"ordermainid\" o140, \"enordermainitem4\".\"position\" o141, \"enordermainitem4\".\"materialcode\" o142, \"enordermainitem4\".\"materialdescription\" o143, \"enordermainitem4\".\"assigmnentcode\" o144, \"enordermainitem4\".\"documentclassid\" o145, \"enordermainitem4\".\"deliverydate\" o146, trim_scale(\"enordermainitem4\".\"quantity\"::numeric) o147, \"enordermainitem4\".\"unittype\" o148, trim_scale(\"enordermainitem4\".\"unitprice\"::numeric) o149, \"enordermainitem4\".\"basequantity\" o150, \"enordermainitem4\".\"isdeleted\" o151, \"enordermainitem4\".\"isblocked\" o152, \"enordermainitem4\".\"isfinaldelivery\" o153, \"enordermainitem4\".\"glaccountid\" o154, \"enordermainitem4\".\"costcenterid\" o155, \"enordermainitem4\".\"fundscenter\" o156, \"enordermainitem4\".\"fund\" o157, \"enordermainitem4\".\"commitmentitem\" o158, \"enordermainitem4\".\"vatindicator\" o159, \"enordermainitem4\".\"vatprocedure\" o160, trim_scale(\"enordermainitem4\".\"vatrate\"::numeric) o161, \"enordermainitem4\".\"purchaserequisitionnumber\" o162, \"enordermainitem4\".\"purchaserequisitionitemnr\" o163, \"enordermainitem4\".\"regionid\" o164, \"enordermainitem4\".\"center\" o165, \"enordermainitem4\".\"pepelement\" o166, trim_scale(\"enordermainitem4\".\"quantitydelivered\"::numeric) o167, \"enordermainitem4\".\"orderunitofmeasure\" o168, \"enordermainitem4\".\"applicant\" o169, \"enordermainitem4\".\"direction\" o170, \"enordermainitem4\".\"contractnumber\" o171, \"enordermainitem4\".\"contractposition\" o172, \"enordermainitem4\".\"contractstartdate\" o173, \"enordermainitem4\".\"contractenddate\" o174, trim_scale(\"enordermainitem4\".\"contractplannedvalue\"::numeric) o175, \"enordermainitem4\".\"positiontype\" o176, \"enordermainitem4\".\"serialnumberprofile\" o177, \"enordermainitem4\".\"batchmanaged\" o178, \"enordermainitem4\".\"materialtype\" o179, \"enordermainitem4\".\"itemgroup\" o180, \"enordermainitem4\".\"orderrequestcreatorsapnumber\" o181, \"enordermainitem4\".\"ismultipleimputation\" o182, \"enordermainitem4\".\"invoiceusageid\" o183, \"enordermainitem4\".\"ordermainitemstatusid\" o184, \"enordermainitem4\".\"divisionid\" o185, \"enordermainitem4\".\"createdby\" o186, \"enordermainitem4\".\"createdon\" o187, \"enordermainitem4\".\"updatedby\" o188, \"enordermainitem4\".\"updatedon\" o189, \"ensupplier14\".\"id\" o190, \"ensupplier14\".\"tratamiento\" o191, \"ensupplier14\".\"name\" o192, \"ensupplier14\".\"number\" o193, \"ensupplier14\".\"conceptobusq_1_2\" o194, \"ensupplier14\".\"calle_numero\" o195, \"ensupplier14\".\"distrito\" o196, \"ensupplier14\".\"codigopostal_pobl_\" o197, \"ensupplier14\".\"pais\" o198, \"ensupplier14\".\"region_\" o199, \"ensupplier14\".\"idioma\" o200, \"ensupplier14\".\"telefono\" o201, \"ensupplier14\".\"extension\" o202, \"ensupplier14\".\"fax\" o203, \"ensupplier14\".\"cliente\" o204, \"ensupplier14\".\"soc_glasociada\" o205, \"ensupplier14\".\"clavedegrupo\" o206, \"ensupplier14\".\"n_ident_fis_1\" o207, \"ensupplier14\".\"personafisica\" o208, \"ensupplier14\".\"ramo\" o209, \"ensupplier14\".\"grupodeporte\" o210, \"ensupplier14\".\"email\" o211, \"ensupplier14\".\"isactive\" o212, \"ensupplier14\".\"createdon\" o213, \"ensupplier14\".\"createdby\" o214, \"ensupplier14\".\"updatedon\" o215, \"ensupplier14\".\"updatedby\" o216, \"ensupplier14\".\"regionid\" o217");
fromBuilder.Append(" FROM ((((((({Folio} \"enfolio14\" Left JOIN {FolioItems} \"enfolioitems2\" ON (\"enfolio14\".\"id\" = \"enfolioitems2\".\"folioid\"))  Left JOIN {Supplier} \"ensupplier14\" ON (\"enfolio14\".\"supplierid\" = \"ensupplier14\".\"id\"))  Left JOIN {OrderMain} \"enordermain25\" ON (\"enfolio14\".\"orderid\" = \"enordermain25\".\"id\"))  Left JOIN {OrderMainItem} \"enordermainitem4\" ON (\"enfolioitems2\".\"ordermainitemid\" = \"enordermainitem4\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail2\" ON (\"enordermain25\".\"id\" = \"enorderdetail2\".\"orderid\"))  Left JOIN {CostCenterSAP} \"encostcentersap4\" ON (\"enordermainitem4\".\"costcenterid\" = \"encostcentersap4\".\"id\"))  Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype1\" ON (\"enordermainitem4\".\"glaccountid\" = \"enaccountingaccounts_servicetype1\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolio_Id != 0) {
whereBuilder.Append("((\"enfolio14\".\"id\" = @qpfoFolio_Id) AND (\"enfolio14\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolio_Id", DbType.Int64, qpfoFolio_Id);
} else {
whereBuilder.Append("(\"enfolio14\".\"id\" IS NULL)");
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
RL_be0bc7b85db7b39f4a70be07d98b5bef outParamList = new RL_be0bc7b85db7b39f4a70be07d98b5bef();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Entry_CallService.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_be0bc7b85db7b39f4a70be07d98b5bef _tmp = new RL_be0bc7b85db7b39f4a70be07d98b5bef();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioItemsByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Entry_CallService.GetFolioItemsByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_be0bc7b85db7b39f4a70be07d98b5bef)_tmp;
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

private static async Task<RC_b6257dfb536e679f8b7be7b4b56f189b> datasetGetInvoicesByFolioIdReadDbAsync(RC_b6257dfb536e679f8b7be7b4b56f189b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
return rec;
}
// Query Function "GetInvoicesByFolioId" c0oOp0gaRkaJjDu2pIvwCw of Action "Entry_CallService"
public static async Task<(RL_1f9a243d40703326d9bf7c63586316cd,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoInvoice_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("Entry_CallService.GetInvoicesByFolioId", "a70e4a73-1a48-4646-898c-3bb6a48bf00b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("Entry_CallService.GetInvoicesByFolioId", "a70e4a73-1a48-4646-898c-3bb6a48bf00b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.llG1VtUJg0Kn+YhD7nOvKw/NodesNotShownInESpaceTree.c0oOp0gaRkaJjDu2pIvwCw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice18\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"eninvoiceextended5\".\"fechaemision\" o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"eninvoiceextended5\".\"uuid\" o42");
fromBuilder.Append(" FROM ({Invoice} \"eninvoice18\" Left JOIN {InvoiceExtended} \"eninvoiceextended5\" ON (\"eninvoice18\".\"id\" = \"eninvoiceextended5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoInvoice_FolioId != 0) {
whereBuilder.Append("((\"eninvoice18\".\"folioid\" = @qpfoInvoice_FolioId) AND (\"eninvoice18\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoInvoice_FolioId", DbType.Int64, qpfoInvoice_FolioId);
} else {
whereBuilder.Append("(\"eninvoice18\".\"folioid\" IS NULL)");
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
RL_1f9a243d40703326d9bf7c63586316cd outParamList = new RL_1f9a243d40703326d9bf7c63586316cd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query Entry_CallService.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1f9a243d40703326d9bf7c63586316cd _tmp = new RL_1f9a243d40703326d9bf7c63586316cd();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesByFolioIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query Entry_CallService.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1f9a243d40703326d9bf7c63586316cd)_tmp;
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
