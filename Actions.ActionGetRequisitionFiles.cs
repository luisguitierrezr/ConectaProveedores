namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetRequisitionFiles : VarsBag {
public long inParamRequisitionId;
public Actions.lcoDownloadZip resDownloadZip =  new Actions.lcoDownloadZip();
public Actions.lcoGetRequisitionFilesById resGetRequisitionFilesById =  new Actions.lcoGetRequisitionFilesById();
public lcvGetRequisitionFiles(long inParamRequisitionId) {
this.inParamRequisitionId = inParamRequisitionId;
}
}
public class lcoGetRequisitionFiles : VarsBag {
public byte[] outParamBinaryZIP = new byte[] {};

public string outParamErrorMsg = "";

public lcoGetRequisitionFiles() {
}
}
/// <summary>
/// Action <code>GetRequisitionFiles</code> that represents the Service Studio action
///  <code>GetRequisitionFiles</code> <p> Description: </p>
/// </summary>
public static async Task<(byte[],string)> ActionGetRequisitionFiles(IRequestContext requestContext,long inParamRequisitionId,CancellationToken cancellationToken) {
byte[] outParamBinaryZIP = default;
string outParamErrorMsg = default;
lcoGetRequisitionFiles result = new lcoGetRequisitionFiles();
lcvGetRequisitionFiles localVars = new lcvGetRequisitionFiles(inParamRequisitionId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetRequisitionFiles", "d60f7a09-43de-429d-9f77-63baeecb87bb"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetRequisitionFiles", "d60f7a09-43de-429d-9f77-63baeecb87bb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetRequisitionFilesById
localVars.resGetRequisitionFilesById.outParamFiles = await Actions.ActionGetRequisitionFilesById(requestContext,localVars.inParamRequisitionId,cancellationToken);

// DownloadZip
(localVars.resDownloadZip.outParamBinaryZIP,localVars.resDownloadZip.outParamErrorMsg) = await Actions.ActionDownloadZip(requestContext,localVars.resGetRequisitionFilesById.outParamFiles,cancellationToken);

// BinaryZIP = DownloadZip.BinaryZIP
result.outParamBinaryZIP=localVars.resDownloadZip.outParamBinaryZIP;

// ErrorMsg = DownloadZip.ErrorMsg
result.outParamErrorMsg=localVars.resDownloadZip.outParamErrorMsg;
} //close CreateActionActivity using block
} // try

finally {
outParamBinaryZIP = result.outParamBinaryZIP;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamBinaryZIP,outParamErrorMsg);
}

public static class FuncActionGetRequisitionFiles {



}


}
