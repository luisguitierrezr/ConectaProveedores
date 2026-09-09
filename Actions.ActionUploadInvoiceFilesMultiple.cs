namespace ssConectaProveedores;

public partial class Actions {
public class lcvUploadInvoiceFilesMultiple : VarsBag {
public long inParamInvoiceId;
public long inParamRequisitionId;
public long inParamOrderMainId;
public long inParamFolioId;
public RL_2e76d5be11218f97ffd872b5a7213337 inParamMultiUploadInvoiceFileStructList;
public bool inParamIsStartApproval;
public int inParamOffsetUtc;
/// <summary>
/// Variable <code>FilesList</code> that represents the Service Studio InvoiceFileStructList
///  <code>FilesList</code> <p>Description: </p>
/// </summary>
public RL_7b4ceb84b6a1255d3a42c8932279bc3c varLcFilesList = new RL_7b4ceb84b6a1255d3a42c8932279bc3c();

public Actions.lcoUploadInvoiceFiles resUploadInvoiceFiles =  new Actions.lcoUploadInvoiceFiles();
public lcvUploadInvoiceFilesMultiple(long inParamInvoiceId, long inParamRequisitionId, long inParamOrderMainId, long inParamFolioId, RL_2e76d5be11218f97ffd872b5a7213337 inParamMultiUploadInvoiceFileStructList, bool inParamIsStartApproval, int inParamOffsetUtc) {
this.inParamInvoiceId = inParamInvoiceId;
this.inParamRequisitionId = inParamRequisitionId;
this.inParamOrderMainId = inParamOrderMainId;
this.inParamFolioId = inParamFolioId;
this.inParamMultiUploadInvoiceFileStructList = inParamMultiUploadInvoiceFileStructList;
this.inParamIsStartApproval = inParamIsStartApproval;
this.inParamOffsetUtc = inParamOffsetUtc;
}
}
public class lcoUploadInvoiceFilesMultiple : VarsBag {
public RL_2e76d5be11218f97ffd872b5a7213337 outParamError_MultiUploadInvoiceFileStructList = new RL_2e76d5be11218f97ffd872b5a7213337();

public lcoUploadInvoiceFilesMultiple() {
}
}
/// <summary>
/// Action <code>UploadInvoiceFilesMultiple</code> that represents the Service Studio action
///  <code>UploadInvoiceFilesMultiple</code> <p> Description: </p>
/// </summary>
public static async Task<RL_2e76d5be11218f97ffd872b5a7213337> ActionUploadInvoiceFilesMultiple(IRequestContext requestContext,long inParamInvoiceId,long inParamRequisitionId,long inParamOrderMainId,long inParamFolioId,RL_2e76d5be11218f97ffd872b5a7213337 inParamMultiUploadInvoiceFileStructList,bool inParamIsStartApproval,int inParamOffsetUtc,CancellationToken cancellationToken) {
RL_2e76d5be11218f97ffd872b5a7213337 outParamError_MultiUploadInvoiceFileStructList = default;
lcoUploadInvoiceFilesMultiple result = new lcoUploadInvoiceFilesMultiple();
lcvUploadInvoiceFilesMultiple localVars = new lcvUploadInvoiceFilesMultiple(inParamInvoiceId, inParamRequisitionId, inParamOrderMainId, inParamFolioId, inParamMultiUploadInvoiceFileStructList, inParamIsStartApproval, inParamOffsetUtc);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("UploadInvoiceFilesMultiple", "467437e1-f00f-4935-a538-f49797781f09"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("UploadInvoiceFilesMultiple", "467437e1-f00f-4935-a538-f49797781f09", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach MultiUploadInvoiceFileStructList
localVars.inParamMultiUploadInvoiceFileStructList.StartIteration();
try {while (!((localVars.inParamMultiUploadInvoiceFileStructList.Eof))) {
// ListClear
await ExtendedActions.ListClear(requestContext,localVars.varLcFilesList,cancellationToken);

// ListAppendXML
await ExtendedActions.ListAppend(requestContext,localVars.varLcFilesList,(await RecordUtils.ConvertAsync(localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec, new ST_7837994e68174a4794f15e4233b48555Structure(), async (ST_5478c3bb197e3019856d4a634c17d91dStructure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssInvoiceFileId = source.ssInvoiceFileId;
target.ssName = (BuiltInFunction.SubstrSC (source.ssName, 0, BuiltInFunction.IndexSC (source.ssName, ".", 0, false, false))+".xml");
target.ssBinaryData = source.ssBinaryDataXML;
target.ssStorageId = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

// ListAppendPDF
await ExtendedActions.ListAppend(requestContext,localVars.varLcFilesList,(await RecordUtils.ConvertAsync(localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec, new ST_7837994e68174a4794f15e4233b48555Structure(), async (ST_5478c3bb197e3019856d4a634c17d91dStructure source, ST_7837994e68174a4794f15e4233b48555Structure target, CancellationToken cancellationToken) => {
target.ssInvoiceFileId = source.ssInvoiceFileId;
target.ssName = (BuiltInFunction.SubstrSC (source.ssName, 0, BuiltInFunction.IndexSC (source.ssName, ".", 0, false, false))+".pdf");
target.ssBinaryData = source.ssBinaryDataPDF;
target.ssStorageId = source.ssStorageId;
return target;
}, cancellationToken)),cancellationToken);

// UploadInvoiceFiles
(localVars.resUploadInvoiceFiles.outParamErrorMsg,localVars.resUploadInvoiceFiles.outParamo_Invoice,localVars.resUploadInvoiceFiles.outParamo_InvoiceExtended,localVars.resUploadInvoiceFiles.outParamClaveProdServ,localVars.resUploadInvoiceFiles.outParamTipoComprobante,localVars.resUploadInvoiceFiles.outParamIsMissingCreditNote) = await Actions.ActionUploadInvoiceFiles(requestContext,localVars.inParamInvoiceId,localVars.inParamRequisitionId,localVars.inParamOrderMainId,localVars.inParamFolioId,localVars.varLcFilesList,new RL_7b4ceb84b6a1255d3a42c8932279bc3c(),false,new ST_6f620840109ac6f721328b723ec0152cStructure(),(((decimal)0)),false,localVars.inParamIsStartApproval,0,0L,0.0M,0L,localVars.inParamOffsetUtc,cancellationToken);

// error?
if(((localVars.resUploadInvoiceFiles.outParamErrorMsg!=""))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamError_MultiUploadInvoiceFileStructList,new ST_5478c3bb197e3019856d4a634c17d91dStructure(){ ssInvoiceFileId = localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec.ssInvoiceFileId, ssName = localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec.ssName, ssBinaryDataZIP = localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec.ssBinaryDataZIP, ssBinaryDataXML = localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec.ssBinaryDataXML, ssBinaryDataPDF = localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec.ssBinaryDataPDF, ssStorageId = localVars.inParamMultiUploadInvoiceFileStructList.CurrentRec.ssStorageId, ssErrorMsg = localVars.resUploadInvoiceFiles.outParamErrorMsg },cancellationToken);

}

localVars.inParamMultiUploadInvoiceFileStructList.Advance();
}

} finally {
localVars.inParamMultiUploadInvoiceFileStructList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
outParamError_MultiUploadInvoiceFileStructList = result.outParamError_MultiUploadInvoiceFileStructList;
} // inner-finally
RETURN_STATEMENT:
return outParamError_MultiUploadInvoiceFileStructList;
}

public static class FuncActionUploadInvoiceFilesMultiple {



}


}
