namespace ssConectaProveedores;

public partial class Actions {
public class lcvRequisitionAccountingRequest : VarsBag {
public long inParami_RequisitionId;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>l_RequestAccountingFinalList</code> that represents the Service Studio TI_POS_InList
///  <code>l_RequestAccountingFinalList</code> <p>Description: </p>
/// </summary>
public RL_c68103fa9d6dc1b51b6298518d880199 varLcl_RequestAccountingFinalList = new RL_c68103fa9d6dc1b51b6298518d880199();

/// <summary>
/// Variable <code>l_RequestAccountingTextList</code> that represents the Service Studio Text2List
///  <code>l_RequestAccountingTextList</code> <p>Description: </p>
/// </summary>
public RLTextList varLcl_RequestAccountingTextList = new RLTextList();

/// <summary>
/// Variable <code>l_RequestAccountingTextList2</code> that represents the Service Studio Text2List
///  <code>l_RequestAccountingTextList2</code> <p>Description: </p>
/// </summary>
public RLTextList varLcl_RequestAccountingTextList2 = new RLTextList();

public ST_35778da666b987b02b8cb887e66647a4Structure resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse = new ST_35778da666b987b02b8cb887e66647a4Structure();

public Actions.lcoRequisitionAccounting_ActivateRetentionsBack resRequisitionAccounting_ActivateRetentionsBack =  new Actions.lcoRequisitionAccounting_ActivateRetentionsBack();
public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public string resString_Join2_outParamText = "";

public Actions.lcoRequisitionAccounting_DeactivateRetentions resRequisitionAccounting_DeactivateRetentions =  new Actions.lcoRequisitionAccounting_DeactivateRetentions();
public string resString_Join_outParamText = "";

public RL_17106260236c729f86b4f7919e212d21 queryResGetRequisitionApprovalsByRequisitionId_outParamList = new RL_17106260236c729f86b4f7919e212d21();
public long queryResGetRequisitionApprovalsByRequisitionId_outParamCount = 0L;

public RL_eb5141ae4756079cd46e163eaf3b6446 queryResGetRequisitionApprovalsByRequisitionId2_outParamList = new RL_eb5141ae4756079cd46e163eaf3b6446();
public long queryResGetRequisitionApprovalsByRequisitionId2_outParamCount = 0L;

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate2 =  new Actions.lcoLogsAccountingCreate();
public Actions.lcoRequisitionLogAdd resRequisitionLogAddApprove =  new Actions.lcoRequisitionLogAdd();
public RL_25486e09ba20acde3d8ef9d3e8a6e625 queryResGetRequisitionContractFilesByRequisitionId_outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
public long queryResGetRequisitionContractFilesByRequisitionId_outParamCount = 0L;

public RL_b18851832343d010b62ce1bd6ac93765 queryResGetRequisitionId_outParamList = new RL_b18851832343d010b62ce1bd6ac93765();
public long queryResGetRequisitionId_outParamCount = 0L;

public lcvRequisitionAccountingRequest(long inParami_RequisitionId, int inParamOffsetUtc) {
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoRequisitionAccountingRequest : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoRequisitionAccountingRequest() {
}
}
/// <summary>
/// Action <code>RequisitionAccountingRequest</code> that represents the Service Studio action
///  <code>RequisitionAccountingRequest</code> <p> Description: Action to request to SAP invoic
/// e accounting.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionRequisitionAccountingRequest(IRequestContext requestContext,long inParami_RequisitionId,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoRequisitionAccountingRequest result = new lcoRequisitionAccountingRequest();
lcvRequisitionAccountingRequest localVars = new lcvRequisitionAccountingRequest(inParami_RequisitionId, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("RequisitionAccountingRequest", "0118a46d-15a3-4036-966f-eca2ec7f3326"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("RequisitionAccountingRequest", "0118a46d-15a3-4036-966f-eca2ec7f3326", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionId_maxRecords = 1;
if (datasetGetRequisitionId_maxRecords < 1) datasetGetRequisitionId_maxRecords = 1;
int datasetGetRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionId_outParamList,localVars.queryResGetRequisitionId_outParamCount) = await FuncActionRequisitionAccountingRequest.datasetGetRequisitionId(requestContext,datasetGetRequisitionId_maxRecords,datasetGetRequisitionId_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetRequisitionApprovalsByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalsByRequisitionId_maxRecords = 1;
if (datasetGetRequisitionApprovalsByRequisitionId_maxRecords < 1) datasetGetRequisitionApprovalsByRequisitionId_maxRecords = 1;
int datasetGetRequisitionApprovalsByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList,localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamCount) = await FuncActionRequisitionAccountingRequest.datasetGetRequisitionApprovalsByRequisitionId(requestContext,datasetGetRequisitionApprovalsByRequisitionId_maxRecords,datasetGetRequisitionApprovalsByRequisitionId_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetRequisitionContractFilesByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionContractFilesByRequisitionId_maxRecords = 1;
if (datasetGetRequisitionContractFilesByRequisitionId_maxRecords < 1) datasetGetRequisitionContractFilesByRequisitionId_maxRecords = 1;
int datasetGetRequisitionContractFilesByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList,localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamCount) = await FuncActionRequisitionAccountingRequest.datasetGetRequisitionContractFilesByRequisitionId(requestContext,datasetGetRequisitionContractFilesByRequisitionId_maxRecords,datasetGetRequisitionContractFilesByRequisitionId_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// Query datasetGetRequisitionApprovalsByRequisitionId2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionApprovalsByRequisitionId2_maxRecords = 1;
if (datasetGetRequisitionApprovalsByRequisitionId2_maxRecords < 1) datasetGetRequisitionApprovalsByRequisitionId2_maxRecords = 1;
int datasetGetRequisitionApprovalsByRequisitionId2_startIndex = 0;(localVars.queryResGetRequisitionApprovalsByRequisitionId2_outParamList,localVars.queryResGetRequisitionApprovalsByRequisitionId2_outParamCount) = await FuncActionRequisitionAccountingRequest.datasetGetRequisitionApprovalsByRequisitionId2(requestContext,datasetGetRequisitionApprovalsByRequisitionId2_maxRecords,datasetGetRequisitionApprovalsByRequisitionId2_startIndex,IterationMultiplicity.Never,localVars.inParami_RequisitionId,cancellationToken);

// RequisitionAccounting_DeactivateRetentions
(localVars.resRequisitionAccounting_DeactivateRetentions.outParamIsSuccess,localVars.resRequisitionAccounting_DeactivateRetentions.outParamMessage,localVars.resRequisitionAccounting_DeactivateRetentions.outParamRetentionsToActivate) = await Actions.ActionRequisitionAccounting_DeactivateRetentions(requestContext,localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCompany.ssExternalId,localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENSupplier.ssNumber,cancellationToken);

// error
if(((!localVars.resRequisitionAccounting_DeactivateRetentions.outParamIsSuccess))) {
// o_Output.IsSuccess = RequisitionAccounting_DeactivateRetentions.IsSuccess
result.outParamo_Output.ssIsSuccess = localVars.resRequisitionAccounting_DeactivateRetentions.outParamIsSuccess;

// o_Output.Message = RequisitionAccounting_DeactivateRetentions.Message
result.outParamo_Output.ssMessage = localVars.resRequisitionAccounting_DeactivateRetentions.outParamMessage;
} else {
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_RequestAccountingTextList,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = "1" }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssId) }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssCreatedOn, "yyyyMMdd") }, new STTextStructure(){ ssValue = "KW" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCurrency.ssCode }, new STTextStructure(){ ssValue = (((localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCurrency.ssCode!=BuiltInFunction.TextToIdentifier ("MXN"))) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (BuiltInFunction.DateTimeToText(localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn)), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = (((localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCurrency.ssCode!=BuiltInFunction.TextToIdentifier ("MXN"))) ? (BuiltInFunction.DecimalToText(localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssNegotiatedExchangeRate)) : ("")) }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssName }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssProjectDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "C" }, new STTextStructure(){ ssValue = "02" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENSupplier.ssNumber }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = BuiltInFunction.DecimalToText(localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionContractFile.ssAmount) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRegion.ssDivisionFI }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays (localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn, BuiltInFunction.TextToInteger (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENPaymentMethods.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionApprovalsByRequisitionId2_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEmployeeNumber }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssProjectDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssBuyDocNumber }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssBuyDocPosition } })),cancellationToken);

// String_Join
localVars.resString_Join_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_RequestAccountingTextList, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// ListAppendAll2
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_RequestAccountingTextList2,((RLTextList)(new STTextStructure[] { new STTextStructure(){ ssValue = "2" }, new STTextStructure(){ ssValue = BuiltInFunction.LongIntegerToText(localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssId) }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCompany.ssExternalId }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssCreatedOn, "yyyyMMdd") }, new STTextStructure(){ ssValue = "KW" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCurrency.ssCode }, new STTextStructure(){ ssValue = (((localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCurrency.ssCode!=BuiltInFunction.TextToIdentifier ("MXN"))) ? (BuiltInFunction.FormatDateTime (BuiltInFunction.TextToDate (BuiltInFunction.DateTimeToText(localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn)), "yyyyMMdd")) : ("")) }, new STTextStructure(){ ssValue = (((localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCurrency.ssCode!=BuiltInFunction.TextToIdentifier ("MXN"))) ? (BuiltInFunction.DecimalToText(localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssNegotiatedExchangeRate)) : ("")) }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssName }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssProjectDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "C" }, new STTextStructure(){ ssValue = "03" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENSupplier.ssNumber }, new STTextStructure(){ ssValue = "B" }, new STTextStructure(){ ssValue = BuiltInFunction.DecimalToText(localVars.queryResGetRequisitionContractFilesByRequisitionId_outParamList.CurrentRec.ssENRequisitionContractFile.ssAmount) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRegion.ssDivisionFI }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENPaymentTerms.ssEstructuraDescripcionPROP }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime (BuiltInFunction.AddDays (localVars.queryResGetRequisitionApprovalsByRequisitionId_outParamList.CurrentRec.ssENRequisitionApprovalLevel.ssApprovedOn, BuiltInFunction.TextToInteger (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENPaymentTerms.ssCtd_dias)), "yyyyMMdd") }, new STTextStructure(){ ssValue = BuiltInFunction.FormatDateTime ((await Functions.ActionUTCToLocalTime(requestContext,BuiltInFunction.CurrDateTime (),localVars.inParamOffsetUtc,cancellationToken)), "yyyyMMdd") }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENPaymentMethods.ssExternalId }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENUser.ssName, 0, 50) }, new STTextStructure(){ ssValue = BuiltInFunction.SubstrSC (BuiltInFunction.Replace (localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssProjectDescription, "||", "--"), 0, 50) }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = "" }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssBuyDocNumber }, new STTextStructure(){ ssValue = localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssBuyDocPosition } })),cancellationToken);

// String_Join2
localVars.resString_Join2_outParamText = await Actions.ActionString_Join(requestContext,(await RLTextRecordList.ConvertAsync(localVars.varLcl_RequestAccountingTextList2, new RLTextRecordList(), async (STTextStructure source, RCTextRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),"|",cancellationToken);

// ListAppendAllRequestAccountingFinalList
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_RequestAccountingFinalList,((RL_c68103fa9d6dc1b51b6298518d880199)(new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure[] { new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join_outParamText }, new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(){ ssPARAMETRO = localVars.resString_Join2_outParamText } })),cancellationToken);

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call GENERA_POLIZA _ Requisition", ssDescription = ((("Tram1 "+localVars.resString_Join_outParamText)+"\r\nTramFinal ")+localVars.resString_Join2_outParamText), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// Call_ZTC_GENERA_POLIZA_GRAL
localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse = await ServiceAPIs.ServiceAPICall_ZTC_GENERA_POLIZA_GRAL(requestContext,new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure(){ ssPI_USUARIO = "STC_CONECTA", ssTI_POS_In = localVars.varLcl_RequestAccountingFinalList },cancellationToken);

// LogsAccountingCreate2
localVars.resLogsAccountingCreate2.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "After Call GENERA_POLIZA _ Requisition", ssDescription = ((((localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO+" // ID_POLIZA: ")+localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA)+" // TEXTO: ")+localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("KTnl+i02eUSozHPzTg81rA"))).ssId },cancellationToken);

// RequisitionAccounting_ActivateRetentionsBack
(localVars.resRequisitionAccounting_ActivateRetentionsBack.outParamIsSuccess,localVars.resRequisitionAccounting_ActivateRetentionsBack.outParamMessage) = await Actions.ActionRequisitionAccounting_ActivateRetentionsBack(requestContext,localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENCompany.ssExternalId,localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENSupplier.ssNumber,localVars.resRequisitionAccounting_DeactivateRetentions.outParamRetentionsToActivate,cancellationToken);

// error?
if(((((BuiltInFunction.SubstrSC (localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO, 0, 2)=="E-")||(localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA==""))&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipAccountingError]))))))) {
// o_Output.Message = Call_ZTC_GENERA_POLIZA_GRAL.Response.PO_RESULTADO
result.outParamo_Output.ssMessage = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO;

// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;
} else {
// set ID_POLIZA
// Call_ZTC_GENERA_POLIZA_GRAL.Response.TO_RESULTADO_Out.Current.ID_POLIZA = Call_ZTC_GENERA_POLIZA_GRAL.Response.TO_RESULTADO_Out.Current.ID_POLIZA
localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssID_POLIZA;
// RequisitionLogAddApprove
localVars.resRequisitionLogAddApprove.outParamId = await Actions.ActionRequisitionLogAdd(requestContext,new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssRequisitionId = localVars.inParami_RequisitionId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = ((((((AppUtils.GetStringResource("ffeWQ9hzBEOolr86RoAaOQ#Value.2063792252.1", "Requisition")+" ")+localVars.queryResGetRequisitionId_outParamList.CurrentRec.ssENRequisition.ssName)+" ")+AppUtils.GetStringResource("ffeWQ9hzBEOolr86RoAaOQ#Value.-458750088.1", "accounting had success. -"))+" ")+localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssTO_RESULTADO_Out.CurrentRec.ssTEXTO) },cancellationToken);

// o_Output.Message = Call_ZTC_GENERA_POLIZA_GRAL.Response.PO_RESULTADO
result.outParamo_Output.ssMessage = localVars.resCall_ZTC_GENERA_POLIZA_GRAL_outParamResponse.ssPO_RESULTADO;

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
}

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

// o_Output.Message = "Error in contabilization service. Please contact an administrator."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("WwwaXmj7WEqBpjFoHMIFVg#Value.1045336240.1", "Error in contabilization service. Please contact an administrator.");
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionRequisitionAccountingRequest {

private static async Task<RC_7a202946b9c9ade4fc5b7dc7c07f3279> datasetGetRequisitionApprovalsByRequisitionIdReadDbAsync(RC_7a202946b9c9ade4fc5b7dc7c07f3279 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalsByRequisitionId" RgH4fSN+TkaAHgwL4hq0+Q of Action "RequisitionAccountingRequest"
public static async Task<(RL_17106260236c729f86b4f7919e212d21,long)> datasetGetRequisitionApprovalsByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId", "7df80146-7e23-464e-801e-0c0be21ab4f9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId", "7df80146-7e23-464e-801e-0c0be21ab4f9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.baQYAaMVNkCWb+yi7H8zJg/NodesNotShownInESpaceTree.RgH4fSN+TkaAHgwL4hq0+Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, \"enrequisitionapprovallevel\".\"approvedon\" o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35");
fromBuilder.Append(" FROM ({RequisitionApproval} \"enrequisitionapproval\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel\" ON (\"enrequisitionapproval\".\"id\" = \"enrequisitionapprovallevel\".\"requisitionapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel\".\"approvedon\"::date <> (date '1900-01-01')::date)");
orderByBuilder.Append(" ORDER BY \"enrequisitionapproval\".\"maxlevel\" DESC ");
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
RL_17106260236c729f86b4f7919e212d21 outParamList = new RL_17106260236c729f86b4f7919e212d21();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalsByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_17106260236c729f86b4f7919e212d21 _tmp = new RL_17106260236c729f86b4f7919e212d21();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalsByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_17106260236c729f86b4f7919e212d21)_tmp;
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

private static async Task<RC_cc1082e7aa3de11fcab84972ca526b53> datasetGetRequisitionApprovalsByRequisitionId2ReadDbAsync(RC_cc1082e7aa3de11fcab84972ca526b53 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionApprovalsByRequisitionId2" mrkbnmTfBkm_Cw1CngI0Jg of Action "RequisitionAccountingRequest"
public static async Task<(RL_eb5141ae4756079cd46e163eaf3b6446,long)> datasetGetRequisitionApprovalsByRequisitionId2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionApproval_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId2", "9e1bb99a-df64-4906-bf0b-0d429e023426");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId2", "9e1bb99a-df64-4906-bf0b-0d429e023426", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.baQYAaMVNkCWb+yi7H8zJg/NodesNotShownInESpaceTree.mrkbnmTfBkm_Cw1CngI0Jg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, \"enuser_extended_internal\".\"employeenumber\" o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60");
fromBuilder.Append(" FROM ((({RequisitionApproval} \"enrequisitionapproval1\" Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel1\" ON (\"enrequisitionapproval1\".\"id\" = \"enrequisitionapprovallevel1\".\"requisitionapprovalid\"))  Left JOIN {User} \"enuser\" ON (\"enrequisitionapprovallevel1\".\"assignedto\" = \"enuser\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal\" ON (\"enuser\".\"id\" = \"enuser_extended_internal\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionApproval_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionapproval1\".\"requisitionid\" = @qpreRequisitionApproval_RequisitionId) AND (\"enrequisitionapproval1\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionApproval_RequisitionId", DbType.Int64, qpreRequisitionApproval_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionapproval1\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionapprovallevel1\".\"isstartaccounting\" = 1)");
orderByBuilder.Append(" ORDER BY \"enrequisitionapproval1\".\"maxlevel\" DESC ");
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
RL_eb5141ae4756079cd46e163eaf3b6446 outParamList = new RL_eb5141ae4756079cd46e163eaf3b6446();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalsByRequisitionId2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_eb5141ae4756079cd46e163eaf3b6446 _tmp = new RL_eb5141ae4756079cd46e163eaf3b6446();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionApprovalsByRequisitionId2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RequisitionAccountingRequest.GetRequisitionApprovalsByRequisitionId2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eb5141ae4756079cd46e163eaf3b6446)_tmp;
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

// Query Function "GetRequisitionContractFilesByRequisitionId" qPmZ8Cj_WEqOBhiUPT+2MQ of Action "RequisitionAccountingRequest"
public static async Task<(RL_25486e09ba20acde3d8ef9d3e8a6e625,long)> datasetGetRequisitionContractFilesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RequisitionAccountingRequest.GetRequisitionContractFilesByRequisitionId", "f099f9a8-ff28-4a58-8e06-18943d3fb631");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RequisitionAccountingRequest.GetRequisitionContractFilesByRequisitionId", "f099f9a8-ff28-4a58-8e06-18943d3fb631", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.baQYAaMVNkCWb+yi7H8zJg/NodesNotShownInESpaceTree.qPmZ8Cj_WEqOBhiUPT+2MQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, trim_scale(\"enrequisitioncontractfile\".\"amount\"::numeric) o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {RequisitionContractFile} \"enrequisitioncontractfile\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitioncontractfile\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("O7ktjb0qHUO1JVHd3pyUOA"))).ssId);
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
RL_25486e09ba20acde3d8ef9d3e8a6e625 outParamList = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RequisitionAccountingRequest.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_25486e09ba20acde3d8ef9d3e8a6e625 _tmp = new RL_25486e09ba20acde3d8ef9d3e8a6e625();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RequisitionAccountingRequest.GetRequisitionContractFilesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_25486e09ba20acde3d8ef9d3e8a6e625)_tmp;
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

private static async Task<RC_c300d864ed706a5a026b7eea8a29e521> datasetGetRequisitionIdReadDbAsync(RC_c300d864ed706a5a026b7eea8a29e521 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENPaymentMethods.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionId" yO7w8+MnKUOJpDOwXEB5EA of Action "RequisitionAccountingRequest"
public static async Task<(RL_b18851832343d010b62ce1bd6ac93765,long)> datasetGetRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("RequisitionAccountingRequest.GetRequisitionId", "f3f0eec8-27e3-4329-89a4-33b05c407910");
using var queryActivity = activitySource.CreateAggregateQueryActivity("RequisitionAccountingRequest.GetRequisitionId", "f3f0eec8-27e3-4329-89a4-33b05c407910", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.baQYAaMVNkCWb+yi7H8zJg/NodesNotShownInESpaceTree.yO7w8+MnKUOJpDOwXEB5EA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"encompany\".\"externalid\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, \"encurrency\".\"code\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enpaymentmethods\".\"externalid\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, \"enpaymentterms\".\"ctd_dias\" o29, \"enpaymentterms\".\"estructuradescripcionprop\" o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, \"enregion\".\"divisionfi\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enrequisition\".\"id\" o49, \"enrequisition\".\"name\" o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, \"enrequisition\".\"projectdescription\" o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, trim_scale(\"enrequisition\".\"negotiatedexchangerate\"::numeric) o81, NULL o82, NULL o83, NULL o84, NULL o85, \"enrequisition\".\"createdon\" o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, \"enrequisition\".\"buydocnumber\" o105, \"enrequisition\".\"buydocposition\" o106, NULL o107, NULL o108, NULL o109, \"ensupplier\".\"number\" o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, \"enuser1\".\"name\" o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159");
fromBuilder.Append(" FROM (((((((({Requisition} \"enrequisition\" Left JOIN {Company} \"encompany\" ON (\"enrequisition\".\"companyid\" = \"encompany\".\"id\"))  Left JOIN {Currency} \"encurrency\" ON (\"enrequisition\".\"currencyid\" = \"encurrency\".\"code\"))  Left JOIN {Region} \"enregion\" ON (\"enrequisition\".\"regionid\" = \"enregion\".\"id\"))  Left JOIN {User} \"enuser1\" ON (\"enrequisition\".\"createdby\" = \"enuser1\".\"id\"))  Left JOIN {User_Extended_Internal} \"enuser_extended_internal1\" ON (\"enuser1\".\"id\" = \"enuser_extended_internal1\".\"id\"))  Left JOIN {Supplier} \"ensupplier\" ON (\"enrequisition\".\"supplierid\" = \"ensupplier\".\"id\"))  Left JOIN {PaymentMethods} \"enpaymentmethods\" ON (\"enrequisition\".\"paymentmethodid\" = \"enpaymentmethods\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms\" ON (\"enrequisition\".\"paymenttermsid\" = \"enpaymentterms\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition\".\"id\" IS NULL)");
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
RL_b18851832343d010b62ce1bd6ac93765 outParamList = new RL_b18851832343d010b62ce1bd6ac93765();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[9];
opt[0] = new BitArray(new bool[] {false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, false, false, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query RequisitionAccountingRequest.GetRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b18851832343d010b62ce1bd6ac93765 _tmp = new RL_b18851832343d010b62ce1bd6ac93765();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query RequisitionAccountingRequest.GetRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b18851832343d010b62ce1bd6ac93765)_tmp;
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
