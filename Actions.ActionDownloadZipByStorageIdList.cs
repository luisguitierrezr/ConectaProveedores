namespace ssConectaProveedores;

public partial class Actions {
public class lcvDownloadZipByStorageIdList : VarsBag {
public BasicTypeList<long> inParamStorageIdList;
public Actions.lcoGetFilesByStorageIdList resGetFilesByStorageIdList =  new Actions.lcoGetFilesByStorageIdList();
public Actions.lcoDownloadZip resDownloadZip =  new Actions.lcoDownloadZip();
public lcvDownloadZipByStorageIdList(BasicTypeList<long> inParamStorageIdList) {
this.inParamStorageIdList = inParamStorageIdList;
}
}
public class lcoDownloadZipByStorageIdList : VarsBag {
public byte[] outParamBinaryZIP = new byte[] {};

public string outParamErrorMsg = "";

public lcoDownloadZipByStorageIdList() {
}
}
/// <summary>
/// Action <code>DownloadZipByStorageIdList</code> that represents the Service Studio action
///  <code>DownloadZipByStorageIdList</code> <p> Description: </p>
/// </summary>
public static async Task<(byte[],string)> ActionDownloadZipByStorageIdList(IRequestContext requestContext,BasicTypeList<long> inParamStorageIdList,CancellationToken cancellationToken) {
byte[] outParamBinaryZIP = default;
string outParamErrorMsg = default;
lcoDownloadZipByStorageIdList result = new lcoDownloadZipByStorageIdList();
lcvDownloadZipByStorageIdList localVars = new lcvDownloadZipByStorageIdList(inParamStorageIdList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DownloadZipByStorageIdList", "96d47c1a-4794-40f8-9e8b-f86c907531f6"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DownloadZipByStorageIdList", "96d47c1a-4794-40f8-9e8b-f86c907531f6", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetFilesByStorageIdList
localVars.resGetFilesByStorageIdList.outParamFilesList = await Actions.ActionGetFilesByStorageIdList(requestContext,localVars.inParamStorageIdList,cancellationToken);

// DownloadZip
(localVars.resDownloadZip.outParamBinaryZIP,localVars.resDownloadZip.outParamErrorMsg) = await Actions.ActionDownloadZip(requestContext,localVars.resGetFilesByStorageIdList.outParamFilesList,cancellationToken);

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

public static class FuncActionDownloadZipByStorageIdList {



}


}
