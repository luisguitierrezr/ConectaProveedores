namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_ExtraCreditNote : VarsBag {
public long inParamCreditNoteInvoiceId;
public long inParamOrderMainId;
public long inParamFolioId;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamCreditNoteFilesList;
public bool inParamIsModify;
public long inParamOrderAccConceptsID;
public int inParamOffsetUtc;
public bool inParamIsConstruction;
public Actions.lcoUploadInvoiceFiles_1National resUploadInvoiceFiles_1National =  new Actions.lcoUploadInvoiceFiles_1National();
public Actions.lcoUploadInvoiceFiles_0AddData resUploadInvoiceFiles_0AddData =  new Actions.lcoUploadInvoiceFiles_0AddData();
public lcvUploadInvoiceFiles_ExtraCreditNote(long inParamCreditNoteInvoiceId, long inParamOrderMainId, long inParamFolioId, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamCreditNoteFilesList, bool inParamIsModify, long inParamOrderAccConceptsID, int inParamOffsetUtc, bool inParamIsConstruction) {
this.inParamCreditNoteInvoiceId = inParamCreditNoteInvoiceId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFolioId = inParamFolioId;
this.inParamCreditNoteFilesList = inParamCreditNoteFilesList;
this.inParamIsModify = inParamIsModify;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParamIsConstruction = inParamIsConstruction;
}
}
public class lcoUploadInvoiceFiles_ExtraCreditNote : VarsBag {
public string outParamErrorMsg = "";

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();

public lcoUploadInvoiceFiles_ExtraCreditNote() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_ExtraCreditNote</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_ExtraCreditNote</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_d1d0320db36efbb094ad0082361435a0EntityRecord,EN_f81a3d226103fd013068b8763798067aEntityRecord)> ActionUploadInvoiceFiles_ExtraCreditNote(IRequestContext requestContext,long inParamCreditNoteInvoiceId,long inParamOrderMainId,long inParamFolioId,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamCreditNoteFilesList,bool inParamIsModify,long inParamOrderAccConceptsID,int inParamOffsetUtc,bool inParamIsConstruction,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = default;
EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = default;
lcoUploadInvoiceFiles_ExtraCreditNote result = new lcoUploadInvoiceFiles_ExtraCreditNote();
lcvUploadInvoiceFiles_ExtraCreditNote localVars = new lcvUploadInvoiceFiles_ExtraCreditNote(inParamCreditNoteInvoiceId, inParamOrderMainId, inParamFolioId, inParamCreditNoteFilesList, inParamIsModify, inParamOrderAccConceptsID, inParamOffsetUtc, inParamIsConstruction);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_ExtraCreditNote", "b5122cb3-7f65-4837-9325-cdaab1a8f303"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_ExtraCreditNote", "b5122cb3-7f65-4837-9325-cdaab1a8f303", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// empty
if((!(localVars.inParamCreditNoteFilesList.Empty))) {
// UploadInvoiceFiles_0AddData
localVars.resUploadInvoiceFiles_0AddData.outParamUploadValidationData = await Actions.ActionUploadInvoiceFiles_0AddData(requestContext,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamFolioId,localVars.inParamOrderMainId,cancellationToken);

// UploadInvoiceFiles_1National
(localVars.resUploadInvoiceFiles_1National.outParamErrorMsg,localVars.resUploadInvoiceFiles_1National.outParamo_Invoice,localVars.resUploadInvoiceFiles_1National.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles_1National.outParamClaveProdServ,localVars.resUploadInvoiceFiles_1National.outParamTipoComprobante,localVars.resUploadInvoiceFiles_1National.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles_1National(requestContext,localVars.inParamCreditNoteInvoiceId,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),Convert.ToInt64(BuiltInFunction.NullIdentifier ()),true,localVars.inParamCreditNoteFilesList,new RL_7b4ceb84b6a1255d3a42c8932279bc3c(),false,localVars.resUploadInvoiceFiles_0AddData.outParamUploadValidationData,false,localVars.inParamIsModify,(((decimal)0)),localVars.inParamOrderAccConceptsID,5,0.0M,Convert.ToInt64(BuiltInFunction.NullIdentifier ()),localVars.inParamOffsetUtc,localVars.inParamIsConstruction,0,cancellationToken);

// ErrorMsg = UploadInvoiceFiles_1National.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_1National.outParamErrorMsg;

// o_Invoice = UploadInvoiceFiles_1National.o_Invoice
result.outParamo_Invoice=localVars.resUploadInvoiceFiles_1National.outParamo_Invoice;

// o_InvoiceExtended = UploadInvoiceFiles_1National.o_InvoiceExtended
result.outParamo_InvoiceExtended=localVars.resUploadInvoiceFiles_1National.outParamo_InvoiceExtended;
}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamo_Invoice = result.outParamo_Invoice;
outParamo_InvoiceExtended = result.outParamo_InvoiceExtended;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamo_Invoice,outParamo_InvoiceExtended);
}

public static class FuncActionUploadInvoiceFiles_ExtraCreditNote {



}


}
