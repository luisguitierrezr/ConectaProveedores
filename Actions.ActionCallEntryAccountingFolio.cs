namespace ssConectaProveedores;

public partial class Actions {
public class lcvCallEntryAccountingFolio : VarsBag {
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio;
public bool inParamIsResend;
public int inParamOffsetUtc;
public Actions.lcoFolioLogAdd resFolioLogAdd2 =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAddEntry =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioLogAdd resFolioLogAdd4 =  new Actions.lcoFolioLogAdd();
public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetLastFolioApprovalLevel_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetLastFolioApprovalLevel_outParamCount = 0L;

public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate3 =  new Actions.lcoFolioCreateOrUpdate();
public RL_d5c1b2482ff109e80580d8b5fb920193 queryResGetSupplier_outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
public long queryResGetSupplier_outParamCount = 0L;

public RL_547a563833923ab1f4eeebb2aa95ce1a queryResGetLevelsComplementAndAbove_outParamList = new RL_547a563833923ab1f4eeebb2aa95ce1a();
public long queryResGetLevelsComplementAndAbove_outParamCount = 0L;

public Actions.lcoInvoiceCreateOrUpdate resInvoiceCreateOrUpdate2 =  new Actions.lcoInvoiceCreateOrUpdate();
public Actions.lcoFolioApprovalLevelCreateOrUpdate resFolioApprovalLevelCreateOrUpdate4 =  new Actions.lcoFolioApprovalLevelCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAddApprove4 =  new Actions.lcoFolioLogAdd();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate4 =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioLogAdd resFolioLogAddApprove3 =  new Actions.lcoFolioLogAdd();
public RL_52e01c48f1745de5266c16d6fe2c0564 queryResGetFolioApprovalLevelIsInvoiceApproval_outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
public long queryResGetFolioApprovalLevelIsInvoiceApproval_outParamCount = 0L;

public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate2 =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoEntry_CallService resEntry_CallService =  new Actions.lcoEntry_CallService();
public Actions.lcoFolioApprovalCreateOrUpdate resFolioApprovalCreateOrUpdate =  new Actions.lcoFolioApprovalCreateOrUpdate();
public RL_7b3475883ca90ad6eb7fc983e868c456 queryResGetInvoicesByFolioId_outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
public long queryResGetInvoicesByFolioId_outParamCount = 0L;

public Actions.lcoFolioLogAdd resFolioLogAdd3 =  new Actions.lcoFolioLogAdd();
public lcvCallEntryAccountingFolio(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio, bool inParamIsResend, int inParamOffsetUtc) {
this.inParami_Folio = inParami_Folio;
this.inParamIsResend = inParamIsResend;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoCallEntryAccountingFolio : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoCallEntryAccountingFolio() {
}
}
/// <summary>
/// Action <code>CallEntryAccountingFolio</code> that represents the Service Studio action
///  <code>CallEntryAccountingFolio</code> <p> Description: Action that calls after Approve or Resen
/// d Entry, Entry Service and Order Accounting.</p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionCallEntryAccountingFolio(IRequestContext requestContext,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio,bool inParamIsResend,int inParamOffsetUtc,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoCallEntryAccountingFolio result = new lcoCallEntryAccountingFolio();
lcvCallEntryAccountingFolio localVars = new lcvCallEntryAccountingFolio(inParami_Folio, inParamIsResend, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CallEntryAccountingFolio", "b1a5d4d3-efb1-4b98-b938-58c27214926d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CallEntryAccountingFolio", "b1a5d4d3-efb1-4b98-b938-58c27214926d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetInvoicesByFolioId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoicesByFolioId_maxRecords = 1;
if (datasetGetInvoicesByFolioId_maxRecords < 1) datasetGetInvoicesByFolioId_maxRecords = 1;
int datasetGetInvoicesByFolioId_startIndex = 0;(localVars.queryResGetInvoicesByFolioId_outParamList,localVars.queryResGetInvoicesByFolioId_outParamCount) = await FuncActionCallEntryAccountingFolio.datasetGetInvoicesByFolioId(requestContext,datasetGetInvoicesByFolioId_maxRecords,datasetGetInvoicesByFolioId_startIndex,IterationMultiplicity.Never,localVars.inParami_Folio.ssId,cancellationToken);

// Construction?
if(((localVars.queryResGetInvoicesByFolioId_outParamList.Empty&&(localVars.inParami_Folio.ssApprovalProcessTypeId==1)))) {
// i_Folio.FolioStatusId = ApprovedWithoutInvoice
localVars.inParami_Folio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("gO793L3rZ06FTArG1lVjpg"))).ssId;
// FolioCreateOrUpdate3
localVars.resFolioCreateOrUpdate3.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParami_Folio,cancellationToken);

// FolioLogAddApprove4
localVars.resFolioLogAddApprove4.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_Folio.ssId, ssMessage = ((((AppUtils.GetStringResource("+1tbhrU8V0mkyYf3u4m3zw#Value.68060425.1", "Folio")+" ")+localVars.inParami_Folio.ssFolioNumber)+" ")+AppUtils.GetStringResource("+1tbhrU8V0mkyYf3u4m3zw#Value.362903240.1", "updated to Approved Without Invoice status.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// SendEmailSupplier_FolioApproved3
await Actions.ActionSendEmailSupplier_FolioApproved(requestContext,localVars.inParami_Folio.ssId,true,cancellationToken);

} else {
// No invoices?
if((localVars.queryResGetInvoicesByFolioId_outParamList.Empty)) {
// i_Folio.FolioStatusId = Approved
localVars.inParami_Folio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("sjaNMehoxESZWJutqvvRYA"))).ssId;
// FolioCreateOrUpdate2
localVars.resFolioCreateOrUpdate2.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParami_Folio,cancellationToken);

// FolioLogAddApprove3
localVars.resFolioLogAddApprove3.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_Folio.ssId, ssMessage = ((((AppUtils.GetStringResource("k0IPhb+ZjkKFiEBzDCbU+g#Value.68060425.1", "Folio")+" ")+localVars.inParami_Folio.ssFolioNumber)+" ")+AppUtils.GetStringResource("k0IPhb+ZjkKFiEBzDCbU+g#Value.-1625364909.1", "updated to Approved status.")), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// SendEmailSupplier_FolioApproved
await Actions.ActionSendEmailSupplier_FolioApproved(requestContext,localVars.inParami_Folio.ssId,false,cancellationToken);

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
} else {
// HU13046?
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13046]))))) {
// Query datasetGetFolioApprovalLevelIsInvoiceApproval
cancellationToken.ThrowIfCancellationRequested();
int datasetGetFolioApprovalLevelIsInvoiceApproval_maxRecords = 1;
if (datasetGetFolioApprovalLevelIsInvoiceApproval_maxRecords < 1) datasetGetFolioApprovalLevelIsInvoiceApproval_maxRecords = 1;
int datasetGetFolioApprovalLevelIsInvoiceApproval_startIndex = 0;(localVars.queryResGetFolioApprovalLevelIsInvoiceApproval_outParamList,localVars.queryResGetFolioApprovalLevelIsInvoiceApproval_outParamCount) = await FuncActionCallEntryAccountingFolio.datasetGetFolioApprovalLevelIsInvoiceApproval(requestContext,datasetGetFolioApprovalLevelIsInvoiceApproval_maxRecords,datasetGetFolioApprovalLevelIsInvoiceApproval_startIndex,IterationMultiplicity.Never,localVars.inParami_Folio.ssId,cancellationToken);

// Empty?
if((localVars.queryResGetFolioApprovalLevelIsInvoiceApproval_outParamList.Empty)) {
// Query datasetGetSupplier
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSupplier_maxRecords = 1;
if (datasetGetSupplier_maxRecords < 1) datasetGetSupplier_maxRecords = 1;
int datasetGetSupplier_startIndex = 0;(localVars.queryResGetSupplier_outParamList,localVars.queryResGetSupplier_outParamCount) = await FuncActionCallEntryAccountingFolio.datasetGetSupplier(requestContext,datasetGetSupplier_maxRecords,datasetGetSupplier_startIndex,IterationMultiplicity.Never,localVars.inParami_Folio.ssSupplierId,cancellationToken);

// Foregin supplier?
if(((localVars.queryResGetSupplier_outParamList.CurrentRec.ssENSupplier.ssPais!="MX"))) {
// Query datasetGetLastFolioApprovalLevel
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLastFolioApprovalLevel_maxRecords = 1;
if (datasetGetLastFolioApprovalLevel_maxRecords < 1) datasetGetLastFolioApprovalLevel_maxRecords = 1;
int datasetGetLastFolioApprovalLevel_startIndex = 0;(localVars.queryResGetLastFolioApprovalLevel_outParamList,localVars.queryResGetLastFolioApprovalLevel_outParamCount) = await FuncActionCallEntryAccountingFolio.datasetGetLastFolioApprovalLevel(requestContext,datasetGetLastFolioApprovalLevel_maxRecords,datasetGetLastFolioApprovalLevel_startIndex,IterationMultiplicity.Never,localVars.inParami_Folio.ssId,cancellationToken);

// Query datasetGetLevelsComplementAndAbove
cancellationToken.ThrowIfCancellationRequested();
int datasetGetLevelsComplementAndAbove_maxRecords = 999;
if (datasetGetLevelsComplementAndAbove_maxRecords < 1) datasetGetLevelsComplementAndAbove_maxRecords = 1;
int datasetGetLevelsComplementAndAbove_startIndex = 0;(localVars.queryResGetLevelsComplementAndAbove_outParamList,localVars.queryResGetLevelsComplementAndAbove_outParamCount) = await FuncActionCallEntryAccountingFolio.datasetGetLevelsComplementAndAbove(requestContext,datasetGetLevelsComplementAndAbove_maxRecords,datasetGetLevelsComplementAndAbove_startIndex,IterationMultiplicity.Single,localVars.inParami_Folio.ssOrderId,cancellationToken);

// Foreach GetLevelsComplementAndAbove.List
localVars.queryResGetLevelsComplementAndAbove_outParamList.StartIteration();
try {while (!((localVars.queryResGetLevelsComplementAndAbove_outParamList.Eof))) {
// FolioApprovalLevelCreateOrUpdate4
localVars.resFolioApprovalLevelCreateOrUpdate4.outParamId = await Actions.ActionFolioApprovalLevelCreateOrUpdate(requestContext,new EN_56525280d5afaeb9a135e3fb7b34064bEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioApprovalId = localVars.queryResGetLastFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssId, ssLevelNumber = ((localVars.queryResGetLastFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApprovalLevel.ssLevelNumber+localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRowNumber)+1), ssEntraJobTitle = localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRec.ssENEntraRole.ssRoleName, ssEntraRoleId = localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRec.ssENOrderApprovalLevel.ssEntraRoleId, ssAssignedTo = localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRec.ssENOrderApprovalLevel.ssAssignedTo, ssApprovalStatusId = (((localVars.queryResGetLevelsComplementAndAbove_outParamList.CurrentRowNumber==0)) ? ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId) : ((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId)), ssIsInvoiceApproval = true },cancellationToken);

localVars.queryResGetLevelsComplementAndAbove_outParamList.Advance();
}

} finally {
localVars.queryResGetLevelsComplementAndAbove_outParamList.EndIteration();
}

// i_Folio.FolioStatusId = PendingApprovalAccounting
localVars.inParami_Folio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("ZfpLpTdXy0CRfRTjg6qPeA"))).ssId;

// GetLastFolioApprovalLevel.List.Current.FolioApproval.CurrentLevel = GetLastFolioApprovalLevel.List.Current.FolioApproval.CurrentLevel + 1
localVars.queryResGetLastFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel = (localVars.queryResGetLastFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval.ssCurrentLevel+1);
// FolioApprovalCreateOrUpdate
localVars.resFolioApprovalCreateOrUpdate.outParamId = await Actions.ActionFolioApprovalCreateOrUpdate(requestContext,localVars.queryResGetLastFolioApprovalLevel_outParamList.CurrentRec.ssENFolioApproval,cancellationToken);

// FolioCreateOrUpdate4
localVars.resFolioCreateOrUpdate4.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParami_Folio,cancellationToken);

// FolioLogAdd3
localVars.resFolioLogAdd3.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_Folio.ssId, ssMessage = ((((("Folio"+" ")+localVars.inParami_Folio.ssFolioNumber)+" ")+AppUtils.GetStringResource("YxnVxH5TxEeZk_95crVayQ#Value.-748838405.1", "has been updated to Pending Approval Accounting status"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnSendFolioNextApproverEmail", "736b6d94-5536-4c24-9a2c-fba004e267e9"))
    using (activitySource.CreateTriggerEventActivity("OnSendFolioNextApproverEmail", "736b6d94-5536-4c24-9a2c-fba004e267e9", "a3d02dd1-e313-409d-837e-fd413ba4d509", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload() {inParami_FolioId = localVars.inParami_Folio.ssId};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

goto RETURN_STATEMENT;

}

}

}

// FolioLogAddEntry
localVars.resFolioLogAddEntry.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_Folio.ssId, ssMessage = ((localVars.inParamIsResend) ? ((((((AppUtils.GetStringResource("9d1gE2Xr6k2fWLtduHtRdA#Value.68060425.1", "Folio")+" ")+localVars.inParami_Folio.ssFolioNumber)+" ")+AppUtils.GetStringResource("9d1gE2Xr6k2fWLtduHtRdA#Value.996253436.1", "resend entry has been manually requested"))+".")) : ((((((AppUtils.GetStringResource("9d1gE2Xr6k2fWLtduHtRdA#Value.68060425.2", "Folio")+" ")+localVars.inParami_Folio.ssFolioNumber)+" ")+AppUtils.GetStringResource("9d1gE2Xr6k2fWLtduHtRdA#Value.290968447.1", "an entry request has been submitted"))+"."))), ssCreatedBy = ((localVars.inParamIsResend) ? (BuiltInFunction.GetUserId ()) : (BuiltInFunction.NullTextIdentifier ())), ssCreatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// Entry_CallService
(localVars.resEntry_CallService.outParamErrorMsg,localVars.resEntry_CallService.outParamEntry,localVars.resEntry_CallService.outParamEjercicio,localVars.resEntry_CallService.outParamEntry_SM,localVars.resEntry_CallService.outParamEjercicio_SM,localVars.resEntry_CallService.outParamEntry_221,localVars.resEntry_CallService.outParamEjercicio_221,localVars.resEntry_CallService.outParamEntry_415,localVars.resEntry_CallService.outParamEjercicio_415,localVars.resEntry_CallService.outParamIsWaitingSAP,localVars.resEntry_CallService.outParamIsBlocked,localVars.resEntry_CallService.outParamIsSuccess) = await Actions.ActionEntry_CallService(requestContext,localVars.inParami_Folio.ssId,localVars.inParamIsResend,localVars.inParamOffsetUtc,cancellationToken);

// blocked?
if((localVars.resEntry_CallService.outParamIsBlocked)) {
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = Entry_CallService.ErrorMsg
result.outParamo_Output.ssMessage = localVars.resEntry_CallService.outParamErrorMsg;
} else {
// error?
if(((localVars.resEntry_CallService.outParamErrorMsg!=""))) {
// o_Output
// o_Output.IsSuccess = Entry_CallService.IsSuccess
result.outParamo_Output.ssIsSuccess = localVars.resEntry_CallService.outParamIsSuccess;

// o_Output.Message = "Entry request has failed" + " - " + Entry_CallService.ErrorMsg
result.outParamo_Output.ssMessage = ((AppUtils.GetStringResource("_Cgqod3dyEyfvM26LdjN0g#Value.1318877506.1", "Entry request has failed")+" - ")+localVars.resEntry_CallService.outParamErrorMsg);
} else {
// FolioLogAdd2
localVars.resFolioLogAdd2.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_Folio.ssId, ssMessage = ((((((((((AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.82896606.1", "The entry was supplemented with the number")+" ")+localVars.resEntry_CallService.outParamEntry)+" ")+AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.397926069.1", "and the year"))+" ")+localVars.resEntry_CallService.outParamEjercicio)+".")+(((localVars.resEntry_CallService.outParamEntry_SM!="")) ? ((((((((AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.1670744509.1", "Exit document")+" ")+localVars.resEntry_CallService.outParamEntry_SM)+" ")+AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.-1428174155.1", "of the year"))+" ")+localVars.resEntry_CallService.outParamEjercicio_SM)+".")) : ("")))+(((localVars.resEntry_CallService.outParamEntry_221!="")) ? (((((((AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.639611150.1", "Exit document 221")+" ")+localVars.resEntry_CallService.outParamEntry_221)+" ")+AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.-1323725813.1", "of the year "))+localVars.resEntry_CallService.outParamEjercicio_221)+".")) : ("")))+(((localVars.resEntry_CallService.outParamEntry_415!="")) ? (((((((AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.639613045.1", "Exit document 415")+" ")+localVars.resEntry_CallService.outParamEntry_415)+" ")+AppUtils.GetStringResource("E9B6Q2EqUkKzQyLna0MySQ#Value.-1323725813.2", "of the year "))+localVars.resEntry_CallService.outParamEjercicio_415)+".")) : (""))), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsForSupplier = true },cancellationToken);

// SendEmailSupplier_FolioApproved2
await Actions.ActionSendEmailSupplier_FolioApproved(requestContext,localVars.inParami_Folio.ssId,false,cancellationToken);

// o_Output.Message = "Entry succesfully done. Accounting process has started in background."
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("pjin9_PGakSpEOjPv0xwTQ#Value.-1837130786.1", "Entry succesfully done. Accounting process has started in background.");

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// is sap wait
if((localVars.resEntry_CallService.outParamIsWaitingSAP)) {
// o_Output.Message = "Entry succesfully done. Invoice stays pending accounting"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("k7h1Rix5qkOgdPWcR6u_lQ#Value.-468950561.1", "Entry succesfully done. Invoice stays pending accounting");

// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// Set Contabilization pending
// GetInvoicesByFolioId.List.Current.Invoice.InvoiceStatusId = PendingAccounting
localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssInvoiceStatusId = (ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("J4p4BoSeP06EZmvoJ_ofhg"))).ssId;
// InvoiceCreateOrUpdate2
localVars.resInvoiceCreateOrUpdate2.outParamId = await Actions.ActionInvoiceCreateOrUpdate(requestContext,localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice,false,cancellationToken);

// FolioLogAdd4
localVars.resFolioLogAdd4.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParami_Folio.ssId, ssMessage = (((((AppUtils.GetStringResource("NF1WEBHAbkKKPfRYk6Z6ow#Value.68060425.1", "Folio")+" ")+localVars.inParami_Folio.ssFolioNumber)+" ")+AppUtils.GetStringResource("NF1WEBHAbkKKPfRYk6Z6ow#Value.-1253054353.1", "Accounting stays pending accounting"))+"."), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = false, ssIsForSupplier = true },cancellationToken);

{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnGenerateInvoiceReport", "627dd520-8c5d-41e7-9b9d-000d13eff449"))
    using (activitySource.CreateTriggerEventActivity("OnGenerateInvoiceReport", "627dd520-8c5d-41e7-9b9d-000d13eff449", "87d51710-2b55-47b8-bf1b-f39d8d936a60", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnGenerateInvoiceReportPayload() {inParamInvoiceId = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId,inParamInvoiceName = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnGenerateInvoiceReport", "87d51710-2b55-47b8-bf1b-f39d8d936a60", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

} else {
{
    using (AppHealthProvider.CreateGlobalEventTriggerMetric("OnGenerateInvoiceReport2", "66f2554f-3417-4473-912a-e7bb7d67ca9b"))
    using (activitySource.CreateTriggerEventActivity("OnGenerateInvoiceReport2", "66f2554f-3417-4473-912a-e7bb7d67ca9b", "87d51710-2b55-47b8-bf1b-f39d8d936a60", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")) {
        var input = new EventPayloads.GlobalEventOnGenerateInvoiceReportPayload() {inParamInvoiceId = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId,inParamInvoiceName = localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssName};

        var eventPublisher = ServiceLocator.GetService<IEventPublisher>();
        await eventPublisher.PublishEventAsync("OnGenerateInvoiceReport", "87d51710-2b55-47b8-bf1b-f39d8d936a60", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828", input, cancellationToken);
    }
}

// InvoiceAccountingProcess_Create
await Actions.ActionInvoiceAccountingProcess_Create(requestContext,localVars.queryResGetInvoicesByFolioId_outParamList.CurrentRec.ssENInvoice.ssId,"",true,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamOffsetUtc,cancellationToken);

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

// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = AllException.ExceptionMessage
result.outParamo_Output.ssMessage = ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamo_Output = result.outParamo_Output;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionCallEntryAccountingFolio {

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetLastFolioApprovalLevelReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLastFolioApprovalLevel" yPLgIwBV50SvXunCvF5unA of Action "CallEntryAccountingFolio"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetLastFolioApprovalLevel(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CallEntryAccountingFolio.GetLastFolioApprovalLevel", "23e0f2c8-5500-44e7-af5e-e9c2bc5e6e9c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CallEntryAccountingFolio.GetLastFolioApprovalLevel", "23e0f2c8-5500-44e7-af5e-e9c2bc5e6e9c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.09SlsbHvmEu5OFjCchSSbQ/NodesNotShownInESpaceTree.yPLgIwBV50SvXunCvF5unA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfolioapproval24\".\"id\" o0, \"enfolioapproval24\".\"folioid\" o1, \"enfolioapproval24\".\"approvalprocessid\" o2, \"enfolioapproval24\".\"processtypecode\" o3, \"enfolioapproval24\".\"approvalprocessversion\" o4, \"enfolioapproval24\".\"currentlevel\" o5, \"enfolioapproval24\".\"maxlevel\" o6, \"enfolioapproval24\".\"startedon\" o7, \"enfolioapproval24\".\"finishedon\" o8, \"enfolioapproval24\".\"regionid\" o9, NULL o10, NULL o11, \"enfolioapprovallevel23\".\"levelnumber\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval24\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel23\" ON (\"enfolioapproval24\".\"id\" = \"enfolioapprovallevel23\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval24\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval24\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval24\".\"folioid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enfolioapprovallevel23\".\"levelnumber\" DESC ");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLastFolioApprovalLevelReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CallEntryAccountingFolio.GetLastFolioApprovalLevel.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetLastFolioApprovalLevelReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CallEntryAccountingFolio.GetLastFolioApprovalLevel.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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

// Query Function "GetSupplier" YQVgL3tx0EOBypD+roSIXQ of Action "CallEntryAccountingFolio"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplier(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CallEntryAccountingFolio.GetSupplier", "2f600561-717b-43d0-81ca-90feae84885d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CallEntryAccountingFolio.GetSupplier", "2f600561-717b-43d0-81ca-90feae84885d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.09SlsbHvmEu5OFjCchSSbQ/NodesNotShownInESpaceTree.YQVgL3tx0EOBypD+roSIXQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"ensupplier28\".\"pais\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier28\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier28\".\"id\" = @qpsuId) AND (\"ensupplier28\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier28\".\"id\" IS NULL)");
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
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CallEntryAccountingFolio.GetSupplier.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CallEntryAccountingFolio.GetSupplier.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
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

private static async Task<RC_cb3079de01243d5d6995c7751ddd690b> datasetGetLevelsComplementAndAboveReadDbAsync(RC_cb3079de01243d5d6995c7751ddd690b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetLevelsComplementAndAbove" VE7xMeSKLE2QZNz7ahmSxg of Action "CallEntryAccountingFolio"
public static async Task<(RL_547a563833923ab1f4eeebb2aa95ce1a,long)> datasetGetLevelsComplementAndAbove(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CallEntryAccountingFolio.GetLevelsComplementAndAbove", "31f14e54-8ae4-4d2c-9064-dcfb6a1992c6");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CallEntryAccountingFolio.GetLevelsComplementAndAbove", "31f14e54-8ae4-4d2c-9064-dcfb6a1992c6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
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
selectBuilder.Append("/* /UserActions.09SlsbHvmEu5OFjCchSSbQ/NodesNotShownInESpaceTree.VE7xMeSKLE2QZNz7ahmSxg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole29\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"enorderapprovallevel11\".\"entraroleid\" o17, \"enorderapprovallevel11\".\"assignedto\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30");
fromBuilder.Append(" FROM (({OrderApprovalLevel} \"enorderapprovallevel11\" Left JOIN {EntraRole} \"enentrarole29\" ON (\"enorderapprovallevel11\".\"entraroleid\" = \"enentrarole29\".\"id\"))  Left JOIN {OrderApproval} \"enorderapproval12\" ON (\"enorderapprovallevel11\".\"orderapprovalid\" = \"enorderapproval12\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderapprovallevel11\".\"levelnumber\" >= 2) AND ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval12\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval12\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval12\".\"orderid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel11\".\"levelnumber\" ASC ");
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
RL_547a563833923ab1f4eeebb2aa95ce1a outParamList = new RL_547a563833923ab1f4eeebb2aa95ce1a();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetLevelsComplementAndAboveReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CallEntryAccountingFolio.GetLevelsComplementAndAbove.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_547a563833923ab1f4eeebb2aa95ce1a _tmp = new RL_547a563833923ab1f4eeebb2aa95ce1a();
_tmp.AlternateReadDbMethodAsync = datasetGetLevelsComplementAndAboveReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CallEntryAccountingFolio.GetLevelsComplementAndAbove.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_547a563833923ab1f4eeebb2aa95ce1a)_tmp;
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

private static async Task<RC_131b941598d8581e5466dbb966f5f0a8> datasetGetFolioApprovalLevelIsInvoiceApprovalReadDbAsync(RC_131b941598d8581e5466dbb966f5f0a8 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetFolioApprovalLevelIsInvoiceApproval" gpRihyenakOcS2FWBRV9aQ of Action "CallEntryAccountingFolio"
public static async Task<(RL_52e01c48f1745de5266c16d6fe2c0564,long)> datasetGetFolioApprovalLevelIsInvoiceApproval(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioApproval_FolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CallEntryAccountingFolio.GetFolioApprovalLevelIsInvoiceApproval", "87629482-a727-436a-9c4b-615605157d69");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CallEntryAccountingFolio.GetFolioApprovalLevelIsInvoiceApproval", "87629482-a727-436a-9c4b-615605157d69", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.09SlsbHvmEu5OFjCchSSbQ/NodesNotShownInESpaceTree.gpRihyenakOcS2FWBRV9aQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29");
fromBuilder.Append(" FROM ({FolioApproval} \"enfolioapproval25\" Left JOIN {FolioApprovalLevel} \"enfolioapprovallevel24\" ON (\"enfolioapproval25\".\"id\" = \"enfolioapprovallevel24\".\"folioapprovalid\")) ");
whereBuilder.Append(" WHERE ");
if (qpfoFolioApproval_FolioId != 0) {
whereBuilder.Append("((\"enfolioapproval25\".\"folioid\" = @qpfoFolioApproval_FolioId) AND (\"enfolioapproval25\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioApproval_FolioId", DbType.Int64, qpfoFolioApproval_FolioId);
} else {
whereBuilder.Append("(\"enfolioapproval25\".\"folioid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enfolioapprovallevel24\".\"isinvoiceapproval\" = 1)");
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
RL_52e01c48f1745de5266c16d6fe2c0564 outParamList = new RL_52e01c48f1745de5266c16d6fe2c0564();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelIsInvoiceApprovalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CallEntryAccountingFolio.GetFolioApprovalLevelIsInvoiceApproval.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52e01c48f1745de5266c16d6fe2c0564 _tmp = new RL_52e01c48f1745de5266c16d6fe2c0564();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelIsInvoiceApprovalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CallEntryAccountingFolio.GetFolioApprovalLevelIsInvoiceApproval.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52e01c48f1745de5266c16d6fe2c0564)_tmp;
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

// Query Function "GetInvoicesByFolioId" WA+HzHIY3UCaR7ghtDO8iA of Action "CallEntryAccountingFolio"
public static async Task<(RL_7b3475883ca90ad6eb7fc983e868c456,long)> datasetGetInvoicesByFolioId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpfoFolioId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("CallEntryAccountingFolio.GetInvoicesByFolioId", "cc870f58-1872-40dd-9a47-b821b433bc88");
using var queryActivity = activitySource.CreateAggregateQueryActivity("CallEntryAccountingFolio.GetInvoicesByFolioId", "cc870f58-1872-40dd-9a47-b821b433bc88", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.09SlsbHvmEu5OFjCchSSbQ/NodesNotShownInESpaceTree.WA+HzHIY3UCaR7ghtDO8iA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoice47\".\"id\" o0, \"eninvoice47\".\"name\" o1, \"eninvoice47\".\"requisitionid\" o2, \"eninvoice47\".\"folioid\" o3, \"eninvoice47\".\"ordermainid\" o4, \"eninvoice47\".\"cfditypeid\" o5, trim_scale(\"eninvoice47\".\"totalamount\"::numeric) o6, \"eninvoice47\".\"currency\" o7, \"eninvoice47\".\"invoicestatusid\" o8, \"eninvoice47\".\"accountingdatetime\" o9, \"eninvoice47\".\"paymentdatetime\" o10, \"eninvoice47\".\"createdon\" o11, \"eninvoice47\".\"createdby\" o12, \"eninvoice47\".\"updatedon\" o13, \"eninvoice47\".\"updatedby\" o14, \"eninvoice47\".\"submittedon\" o15, \"eninvoice47\".\"isnewversion\" o16, \"eninvoice47\".\"id_poliza\" o17, \"eninvoice47\".\"id_poliza_sap\" o18, \"eninvoice47\".\"doc51\" o19, \"eninvoice47\".\"accountingerror\" o20, \"eninvoice47\".\"orderaccconceptsid\" o21, trim_scale(\"eninvoice47\".\"amortization\"::numeric) o22, \"eninvoice47\".\"creditnoteinvoiceid\" o23");
fromBuilder.Append(" FROM {Invoice} \"eninvoice47\"");
whereBuilder.Append(" WHERE ");
if (qpfoFolioId != 0) {
whereBuilder.Append("((\"eninvoice47\".\"folioid\" = @qpfoFolioId) AND (\"eninvoice47\".\"folioid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfoFolioId", DbType.Int64, qpfoFolioId);
} else {
whereBuilder.Append("(\"eninvoice47\".\"folioid\" IS NULL)");
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
RL_7b3475883ca90ad6eb7fc983e868c456 outParamList = new RL_7b3475883ca90ad6eb7fc983e868c456();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query CallEntryAccountingFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7b3475883ca90ad6eb7fc983e868c456 _tmp = new RL_7b3475883ca90ad6eb7fc983e868c456();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query CallEntryAccountingFolio.GetInvoicesByFolioId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7b3475883ca90ad6eb7fc983e868c456)_tmp;
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
