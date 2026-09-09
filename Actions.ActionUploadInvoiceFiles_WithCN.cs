namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_WithCN : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamOrderMainId;
public long inParamFolioId;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamCreditNoteFilesList;
public bool inParamIgnoreCreation;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign;
public decimal inParamInvoicesSum;
public bool inParamIsModify;
public bool inParamIsStartApproval;
public int inParamAccountingDataTypeId;
public long inParamOrderAccConceptsID;
public decimal inParamImportAnticipo;
public long inParamCreditNoteInvoiceId;
public int inParamOffsetUtc;
public bool inParamIsConstruction;
public Actions.lcoUploadInvoiceFiles resUploadInvoiceFiles =  new Actions.lcoUploadInvoiceFiles();
public Actions.lcoUploadInvoiceFiles_ExtraCreditNote resUploadInvoiceFiles_ExtraCreditNote =  new Actions.lcoUploadInvoiceFiles_ExtraCreditNote();
public lcvUploadInvoiceFiles_WithCN(long inParamInvoiceId, long inParamRequisitionId, long inParamOrderMainId, long inParamFolioId, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamCreditNoteFilesList, bool inParamIgnoreCreation, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign, decimal inParamInvoicesSum, bool inParamIsModify, bool inParamIsStartApproval, int inParamAccountingDataTypeId, long inParamOrderAccConceptsID, decimal inParamImportAnticipo, long inParamCreditNoteInvoiceId, int inParamOffsetUtc, bool inParamIsConstruction) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFolioId = inParamFolioId;
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
this.inParamCreditNoteFilesList = inParamCreditNoteFilesList;
this.inParamIgnoreCreation = inParamIgnoreCreation;
this.inParamInvoiceForeign = inParamInvoiceForeign;
this.inParamInvoicesSum = inParamInvoicesSum;
this.inParamIsModify = inParamIsModify;
this.inParamIsStartApproval = inParamIsStartApproval;
this.inParamAccountingDataTypeId = inParamAccountingDataTypeId;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamImportAnticipo = inParamImportAnticipo;
this.inParamCreditNoteInvoiceId = inParamCreditNoteInvoiceId;
this.inParamOffsetUtc = inParamOffsetUtc;
this.inParamIsConstruction = inParamIsConstruction;
}
}
public class lcoUploadInvoiceFiles_WithCN : VarsBag {
public string outParamErrorMsg = "";

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();

public string outParamClaveProdServ = "";

public string outParamTipoComprobante = "";

public bool outParamIsMissingCreditNote = false;

public lcoUploadInvoiceFiles_WithCN() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_WithCN</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_WithCN</code> <p> Description: </p>
/// </summary>
public static async Task<(string,EN_d1d0320db36efbb094ad0082361435a0EntityRecord,EN_f81a3d226103fd013068b8763798067aEntityRecord,string,string,bool)> ActionUploadInvoiceFiles_WithCN(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,long inParamOrderMainId,long inParamFolioId,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamCreditNoteFilesList,bool inParamIgnoreCreation,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign,decimal inParamInvoicesSum,bool inParamIsModify,bool inParamIsStartApproval,int inParamAccountingDataTypeId,long inParamOrderAccConceptsID,decimal inParamImportAnticipo,long inParamCreditNoteInvoiceId,int inParamOffsetUtc,bool inParamIsConstruction,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamo_Invoice = default;
EN_f81a3d226103fd013068b8763798067aEntityRecord outParamo_InvoiceExtended = default;
string outParamClaveProdServ = default;
string outParamTipoComprobante = default;
bool outParamIsMissingCreditNote = default;
lcoUploadInvoiceFiles_WithCN result = new lcoUploadInvoiceFiles_WithCN();
lcvUploadInvoiceFiles_WithCN localVars = new lcvUploadInvoiceFiles_WithCN(inParamInvoiceId, inParamRequisitionId, inParamOrderMainId, inParamFolioId, inParamFilesList, inParamExtraFilesList, inParamCreditNoteFilesList, inParamIgnoreCreation, inParamInvoiceForeign, inParamInvoicesSum, inParamIsModify, inParamIsStartApproval, inParamAccountingDataTypeId, inParamOrderAccConceptsID, inParamImportAnticipo, inParamCreditNoteInvoiceId, inParamOffsetUtc, inParamIsConstruction);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_WithCN", "20dcbc9f-dd5c-4e44-9e98-5c8008a9eb3c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_WithCN", "20dcbc9f-dd5c-4e44-9e98-5c8008a9eb3c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// UploadInvoiceFiles_ExtraCreditNote
(localVars.resUploadInvoiceFiles_ExtraCreditNote.outParamErrorMsg,localVars.resUploadInvoiceFiles_ExtraCreditNote.outParamo_Invoice,localVars.resUploadInvoiceFiles_ExtraCreditNote.outParamo_InvoiceExtended) = await Actions.ActionUploadInvoiceFiles_ExtraCreditNote(requestContext,localVars.inParamCreditNoteInvoiceId,localVars.inParamOrderMainId,localVars.inParamFolioId,localVars.inParamCreditNoteFilesList,localVars.inParamIsModify,localVars.inParamOrderAccConceptsID,localVars.inParamOffsetUtc,localVars.inParamIsConstruction,cancellationToken);

// error?
if(((localVars.resUploadInvoiceFiles_ExtraCreditNote.outParamErrorMsg!=""))) {
// ErrorMsg = UploadInvoiceFiles_ExtraCreditNote.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_ExtraCreditNote.outParamErrorMsg;
} else {
// UploadInvoiceFiles
(localVars.resUploadInvoiceFiles.outParamErrorMsg,localVars.resUploadInvoiceFiles.outParamo_Invoice,localVars.resUploadInvoiceFiles.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles.outParamClaveProdServ,localVars.resUploadInvoiceFiles.outParamTipoComprobante,localVars.resUploadInvoiceFiles.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles(requestContext,localVars.inParamInvoiceId,localVars.inParamRequisitionId,localVars.inParamOrderMainId,localVars.inParamFolioId,localVars.inParamFilesList,localVars.inParamExtraFilesList,localVars.inParamIgnoreCreation,localVars.inParamInvoiceForeign,localVars.inParamInvoicesSum,localVars.inParamIsModify,localVars.inParamIsStartApproval,localVars.inParamAccountingDataTypeId,localVars.inParamOrderAccConceptsID,localVars.inParamImportAnticipo,localVars.resUploadInvoiceFiles_ExtraCreditNote.outParamo_Invoice.ssId,localVars.inParamOffsetUtc,cancellationToken);

// error?
if(((localVars.resUploadInvoiceFiles.outParamErrorMsg!=""))) {
// RaiseError InvalidImport
throw new Ex_InvalidImportUserException (localVars.resUploadInvoiceFiles.outParamErrorMsg);

} else {
// o_Invoice = UploadInvoiceFiles.o_Invoice
result.outParamo_Invoice=localVars.resUploadInvoiceFiles.outParamo_Invoice;

// o_InvoiceExtended = UploadInvoiceFiles.o_InvoiceExtended
result.outParamo_InvoiceExtended=localVars.resUploadInvoiceFiles.outParamo_InvoiceExtended;

// ClaveProdServ = UploadInvoiceFiles.ClaveProdServ
result.outParamClaveProdServ=localVars.resUploadInvoiceFiles.outParamClaveProdServ;

// TipoComprobante = UploadInvoiceFiles.TipoComprobante
result.outParamTipoComprobante=localVars.resUploadInvoiceFiles.outParamTipoComprobante;

// IsMissingCreditNote = UploadInvoiceFiles.IsMissingCreditNote
result.outParamIsMissingCreditNote=localVars.resUploadInvoiceFiles.outParamIsMissingCreditNote;
}

}

} //close CreateActionActivity using block
} // try

catch (Ex_InvalidImportUserException ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = InvalidImport.ExceptionMessage
result.outParamErrorMsg=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamo_Invoice = result.outParamo_Invoice;
outParamo_InvoiceExtended = result.outParamo_InvoiceExtended;
outParamClaveProdServ = result.outParamClaveProdServ;
outParamTipoComprobante = result.outParamTipoComprobante;
outParamIsMissingCreditNote = result.outParamIsMissingCreditNote;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamo_Invoice,outParamo_InvoiceExtended,outParamClaveProdServ,outParamTipoComprobante,outParamIsMissingCreditNote);
}

public static class FuncActionUploadInvoiceFiles_WithCN {



}


}
