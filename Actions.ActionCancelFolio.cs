namespace ssConectaProveedores;

public partial class Actions {
public class lcvCancelFolio : VarsBag {
public RC_b668eee4846e2937101a51355804499d inParamObject;
public ST_e54bcdc56c6f092fdfed672ad024bfa4Structure inParamFolioReject;
public RL_8430333e95ceffc00def96d8abb01f75 inParamFolioApprovalLevels_List;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>IsAnyCancel</code> that represents the Service Studio Boolean
///  <code>IsAnyCancel</code> <p>Description: </p>
/// </summary>
public bool varLcIsAnyCancel = false;

public Actions.lcoFolioLogAdd resFolioLogAdd =  new Actions.lcoFolioLogAdd();
public Actions.lcoCancelFolioSAEC resCancelFolioSAEC =  new Actions.lcoCancelFolioSAEC();
public Actions.lcoEntry_CallService resEntry_CallService =  new Actions.lcoEntry_CallService();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate2 =  new Actions.lcoFolioCreateOrUpdate();
public Actions.lcoFolioCreateOrUpdate resFolioCreateOrUpdate =  new Actions.lcoFolioCreateOrUpdate();
public lcvCancelFolio(RC_b668eee4846e2937101a51355804499d inParamObject, ST_e54bcdc56c6f092fdfed672ad024bfa4Structure inParamFolioReject, RL_8430333e95ceffc00def96d8abb01f75 inParamFolioApprovalLevels_List, int inParamOffsetUtc) {
this.inParamObject = inParamObject;
this.inParamFolioReject = inParamFolioReject;
this.inParamFolioApprovalLevels_List = inParamFolioApprovalLevels_List;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoCancelFolio : VarsBag {
public string outParamErrorMsg = "";

public lcoCancelFolio() {
}
}
/// <summary>
/// Action <code>CancelFolio</code> that represents the Service Studio action <code>CancelFolio</code>
///  <p> Description: Cancel Folio/Invoice and send notification</p>
/// </summary>
public static async Task<string> ActionCancelFolio(IRequestContext requestContext,RC_b668eee4846e2937101a51355804499d inParamObject,ST_e54bcdc56c6f092fdfed672ad024bfa4Structure inParamFolioReject,RL_8430333e95ceffc00def96d8abb01f75 inParamFolioApprovalLevels_List,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoCancelFolio result = new lcoCancelFolio();
lcvCancelFolio localVars = new lcvCancelFolio(inParamObject, inParamFolioReject, inParamFolioApprovalLevels_List, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("CancelFolio", "4257f0fe-dcb6-4714-bbee-416c8264f1e1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("CancelFolio", "4257f0fe-dcb6-4714-bbee-416c8264f1e1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// RejectInvoice?
if((localVars.inParamFolioReject.ssIsRejectInvoice)) {
// RejectInvoice
await Actions.ActionRejectInvoice(requestContext,localVars.inParamObject.ssENInvoice,cancellationToken);

}

// Invoice?
if((localVars.inParamFolioReject.ssIsCancelInvoice)) {
// ID_POLIZA <> ""
if(((localVars.inParamObject.ssENInvoice.ssID_POLIZA!=""))) {
// RaiseError CancelDocumentBeforeOperation
throw new Ex_CancelDocumentBeforeOperationUserException (AppUtils.GetStringResource("axznT8Jdeku+1rBN_ylN_A#Message.-661495929.1", "You must first cancel the document to release the transaction"));

} else {
// IsAnyCancel = True
localVars.varLcIsAnyCancel=true;
// CancelInvoiceByFolioId
await Actions.ActionCancelInvoiceByFolioId(requestContext,localVars.inParamObject.ssENFolio.ssId,cancellationToken);

// Object.Folio.FolioStatusId = ApprovedWithoutInvoice
localVars.inParamObject.ssENFolio.ssFolioStatusId = (ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("gO793L3rZ06FTArG1lVjpg"))).ssId;
// FolioCreateOrUpdate
localVars.resFolioCreateOrUpdate.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParamObject.ssENFolio,cancellationToken);

}

}

// Folio?
if((localVars.inParamFolioReject.ssIsCancelFolio)) {
// IsAnyCancel = True
localVars.varLcIsAnyCancel=true;
// CancelFolioSAEC
localVars.resCancelFolioSAEC.outParamo_FolioNumber = await Actions.ActionCancelFolioSAEC(requestContext,localVars.inParamObject.ssENFolio.ssId,cancellationToken);

// FolioLogAdd
localVars.resFolioLogAdd.outParamId = await Actions.ActionFolioLogAdd(requestContext,new EN_ef6e162f6b50d0b1f4fc1a1d25cef900EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssFolioId = localVars.inParamObject.ssENFolio.ssId, ssMessage = (((((AppUtils.GetStringResource("U8T6e55ABUGKdgdVjpsO3Q#Value.2195684.1", "Form")+" ")+localVars.resCancelFolioSAEC.outParamo_FolioNumber)+" ")+AppUtils.GetStringResource("U8T6e55ABUGKdgdVjpsO3Q#Value.-1184891580.1", "manually cancelled"))+"."), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssIsError = true, ssIsForSupplier = true },cancellationToken);

}

// Entrada?
if((localVars.inParamFolioReject.ssIsCancelEntry)) {
// ID_POLIZA <> ""
if(((localVars.inParamObject.ssENInvoice.ssID_POLIZA!=""))) {
// RaiseError CancelDocumentBeforeOperation
throw new Ex_CancelDocumentBeforeOperationUserException (AppUtils.GetStringResource("oizwZZMoJEiNaEGDcchztw#Message.-661495929.1", "You must first cancel the document to release the transaction"));

} else {
// IsAnyCancel = True
localVars.varLcIsAnyCancel=true;
// Entry_CallService
(localVars.resEntry_CallService.outParamErrorMsg,localVars.resEntry_CallService.outParamEntry,localVars.resEntry_CallService.outParamEjercicio,localVars.resEntry_CallService.outParamEntry_SM,localVars.resEntry_CallService.outParamEjercicio_SM,localVars.resEntry_CallService.outParamEntry_221,localVars.resEntry_CallService.outParamEjercicio_221,localVars.resEntry_CallService.outParamEntry_415,localVars.resEntry_CallService.outParamEjercicio_415,localVars.resEntry_CallService.outParamIsWaitingSAP,localVars.resEntry_CallService.outParamIsBlocked,localVars.resEntry_CallService.outParamIsSuccess) = await Actions.ActionEntry_CallService(requestContext,localVars.inParamObject.ssENFolio.ssId,false,localVars.inParamOffsetUtc,cancellationToken);

// Object.Folio.FolioStatusId = If
localVars.inParamObject.ssENFolio.ssFolioStatusId = ((localVars.inParamFolioReject.ssIsCancelFolio) ? ((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cklscJNc0UyOgKXGwg51TQ"))).ssId) : ((ENFolioStatusEntity.GetRecordByKey(ObjectKey.Parse("cKaejollq0a9gDFyfLxCKg"))).ssId));

// Object.Folio.CanProveedorCancel = If
localVars.inParamObject.ssENFolio.ssCanProveedorCancel = ((localVars.inParamFolioReject.ssIsCancelFolio) ? (false) : (localVars.inParamObject.ssENFolio.ssCanProveedorCancel));
// FolioCreateOrUpdate2
localVars.resFolioCreateOrUpdate2.outParamId = await Actions.ActionFolioCreateOrUpdate(requestContext,localVars.inParamObject.ssENFolio,cancellationToken);

}

}

// ANYCANCEL?
if((localVars.varLcIsAnyCancel)) {
// SendFolioNotificationToUsers2
await Actions.ActionSendFolioNotificationToUsers(requestContext,(await RLUserList.ConvertAsync(localVars.inParamFolioApprovalLevels_List, new RLUserList(), async (RC_ced013358a82a813f1d9a5108f17ce79 source, ENUserEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken)),(((localVars.inParamFolioReject.ssIsCancelInvoice||localVars.inParamFolioReject.ssIsRejectInvoice)) ? (localVars.inParamObject.ssENInvoice.ssName) : ("")),((localVars.inParamFolioReject.ssIsCancelFolio) ? (localVars.inParamObject.ssENFolio.ssFolioNumber) : ("")),localVars.inParamFolioReject.ssIsCancelInvoice,localVars.inParamFolioReject.ssReason,localVars.inParamFolioReject.ssIsCancelEntry,cancellationToken);

}

} //close CreateActionActivity using block
} // try

catch (Ex_CancelDocumentBeforeOperationUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = CancelDocumentBeforeOperation.ExceptionMessage
result.outParamErrorMsg=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionCancelFolio {



}


}
