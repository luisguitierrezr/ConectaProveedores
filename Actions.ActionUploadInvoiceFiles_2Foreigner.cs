namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFiles_2Foreigner : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamFolioId;
public long inParamOrderMainId;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList;
public RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList;
public bool inParamIsStartApproval;
public ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign;
public ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData;
public long inParamOrderAccConceptsID;
public int inParamOffsetUtc;
public Actions.lcoUploadInvoiceFiles_2ForeignerCreate resUploadInvoiceFiles_2ForeignerCreate =  new Actions.lcoUploadInvoiceFiles_2ForeignerCreate();
public Actions.lcoInvoice_OCRValidations resInvoice_OCRValidations =  new Actions.lcoInvoice_OCRValidations();
public RL_7b4ceb84b6a1255d3a42c8932279bc3c resListFilter_outParamFilteredList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public lcvUploadInvoiceFiles_2Foreigner(long inParamInvoiceId, long inParamRequisitionId, long inParamFolioId, long inParamOrderMainId, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList, RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList, bool inParamIsStartApproval, ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign, ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData, long inParamOrderAccConceptsID, int inParamOffsetUtc) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamFolioId = inParamFolioId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFilesList = inParamFilesList;
this.inParamExtraFilesList = inParamExtraFilesList;
this.inParamIsStartApproval = inParamIsStartApproval;
this.inParamInvoiceForeign = inParamInvoiceForeign;
this.inParamUploadValidationData = inParamUploadValidationData;
this.inParamOrderAccConceptsID = inParamOrderAccConceptsID;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoUploadInvoiceFiles_2Foreigner : VarsBag {
public string outParamErrorMsg = "";

public long outParamInvoiceId_Out = 0L;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice_Out = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();

public lcoUploadInvoiceFiles_2Foreigner() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFiles_2Foreigner</code> that represents the Service Studio action
///  <code>UploadInvoiceFiles_2Foreigner</code> <p> Description: </p>
/// </summary>
public static async Task<(string,long,EN_d1d0320db36efbb094ad0082361435a0EntityRecord)> ActionUploadInvoiceFiles_2Foreigner(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,long inParamFolioId,long inParamOrderMainId,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamFilesList,RL_7b4ceb84b6a1255d3a42c8932279bc3c inParamExtraFilesList,bool inParamIsStartApproval,ST_6f620840109ac6f721328b723ec0152cStructure inParamInvoiceForeign,ST_452088c4ad7c6718df20290248661783Structure inParamUploadValidationData,long inParamOrderAccConceptsID,int inParamOffsetUtc,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
long outParamInvoiceId_Out = default;
EN_d1d0320db36efbb094ad0082361435a0EntityRecord outParamInvoice_Out = default;
lcoUploadInvoiceFiles_2Foreigner result = new lcoUploadInvoiceFiles_2Foreigner();
lcvUploadInvoiceFiles_2Foreigner localVars = new lcvUploadInvoiceFiles_2Foreigner(inParamInvoiceId, inParamRequisitionId, inParamFolioId, inParamOrderMainId, inParamFilesList, inParamExtraFilesList, inParamIsStartApproval, inParamInvoiceForeign, inParamUploadValidationData, inParamOrderAccConceptsID, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFiles_2Foreigner", "519d9307-b664-4fbc-a9f9-bf6a1b551ee3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFiles_2Foreigner", "519d9307-b664-4fbc-a9f9-bf6a1b551ee3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_7b4ceb84b6a1255d3a42c8932279bc3c)await  localVars.inParamFilesList.FilterAsync(async (p, cancellationToken) => (BuiltInFunction.IndexSC (p.ssName, ".pdf", 0, false, false)!=(-1)), cancellationToken)));

// no pdf?
if((localVars.resListFilter_outParamFilteredList.Empty)) {
// ErrorMsg = "Main pdf missing"
result.outParamErrorMsg=AppUtils.GetStringResource("p7Cun0bFa06NTXKRFCM_Cg#Value.-614275983.1", "Main pdf missing");
} else {
// Invoice_OCRValidations
localVars.resInvoice_OCRValidations.outParamErrorMsg = await Actions.ActionInvoice_OCRValidations(requestContext,localVars.inParamInvoiceForeign,localVars.inParamUploadValidationData.ssCurrency,BuiltInFunction.TextToDecimal (localVars.inParamUploadValidationData.ssTotalAmount),localVars.inParamOffsetUtc,cancellationToken);

// error?
if(((localVars.resInvoice_OCRValidations.outParamErrorMsg!=""))) {
// ErrorMsg = Invoice_OCRValidations.ErrorMsg
result.outParamErrorMsg=localVars.resInvoice_OCRValidations.outParamErrorMsg;
} else {
// UploadInvoiceFiles_2ForeignerCreate
(localVars.resUploadInvoiceFiles_2ForeignerCreate.outParamErrorMsg,localVars.resUploadInvoiceFiles_2ForeignerCreate.outParamInvoiceId_Out,localVars.resUploadInvoiceFiles_2ForeignerCreate.outParamInvoice_Out) = await Actions.ActionUploadInvoiceFiles_2ForeignerCreate(requestContext,localVars.inParamInvoiceId,localVars.inParamRequisitionId,localVars.inParamFolioId,localVars.inParamOrderMainId,localVars.inParamFilesList,localVars.inParamExtraFilesList,localVars.inParamIsStartApproval,localVars.inParamInvoiceForeign,localVars.inParamUploadValidationData,localVars.inParamOrderAccConceptsID,cancellationToken);

// ErrorMsg = UploadInvoiceFiles_2ForeignerCreate.ErrorMsg
result.outParamErrorMsg=localVars.resUploadInvoiceFiles_2ForeignerCreate.outParamErrorMsg;

// Invoice_Out = UploadInvoiceFiles_2ForeignerCreate.Invoice_Out
result.outParamInvoice_Out=localVars.resUploadInvoiceFiles_2ForeignerCreate.outParamInvoice_Out;

// InvoiceId_Out = UploadInvoiceFiles_2ForeignerCreate.InvoiceId_Out
result.outParamInvoiceId_Out=localVars.resUploadInvoiceFiles_2ForeignerCreate.outParamInvoiceId_Out;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamErrorMsg = result.outParamErrorMsg;
outParamInvoiceId_Out = result.outParamInvoiceId_Out;
outParamInvoice_Out = result.outParamInvoice_Out;
} // inner-finally
RETURN_STATEMENT:
return (outParamErrorMsg,outParamInvoiceId_Out,outParamInvoice_Out);
}

public static class FuncActionUploadInvoiceFiles_2Foreigner {



}


}
