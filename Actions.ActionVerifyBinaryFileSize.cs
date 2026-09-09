namespace ssConectaProveedores;

public partial class Actions {
public class lcvVerifyBinaryFileSize : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure inParami_File;
public Actions.lcoDownloadZip resDownloadZip =  new Actions.lcoDownloadZip();
public int resBinaryDataSize_outParamSize = 0;

public lcvVerifyBinaryFileSize(ST_a158c76eb93396680623c04244f48b6cStructure inParami_File) {
this.inParami_File = inParami_File;
}
}
public class lcoVerifyBinaryFileSize : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoVerifyBinaryFileSize() {
}
}
/// <summary>
/// Action <code>VerifyBinaryFileSize</code> that represents the Service Studio action
///  <code>VerifyBinaryFileSize</code> <p> Description: Action to Verify Binary File Size.</p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionVerifyBinaryFileSize(IRequestContext requestContext,ST_a158c76eb93396680623c04244f48b6cStructure inParami_File,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
lcoVerifyBinaryFileSize result = new lcoVerifyBinaryFileSize();
lcvVerifyBinaryFileSize localVars = new lcvVerifyBinaryFileSize(inParami_File);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("VerifyBinaryFileSize", "d7e5c9e4-effa-4ddc-96bf-3906cf01111e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("VerifyBinaryFileSize", "d7e5c9e4-effa-4ddc-96bf-3906cf01111e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// BinaryDataSize
localVars.resBinaryDataSize_outParamSize = await Actions.ActionBinaryDataSize(requestContext,localVars.inParami_File.ssBinaryData,cancellationToken);

// Size < 5.5MB
if(((localVars.resBinaryDataSize_outParamSize<=5767168))) {
// File
// o_File = i_File
result.outParamo_File=localVars.inParami_File;
} else {
// DownloadZip
(localVars.resDownloadZip.outParamBinaryZIP,localVars.resDownloadZip.outParamErrorMsg) = await Actions.ActionDownloadZip(requestContext,((RL_a1f410d0f62252476f2a43f62445ebc5)(new ST_a158c76eb93396680623c04244f48b6cStructure[] { localVars.inParami_File })),cancellationToken);

// File
// o_File.Name = i_File.Name
result.outParamo_File.ssName = localVars.inParami_File.ssName;

// o_File.BinaryData = DownloadZip.BinaryZIP
result.outParamo_File.ssBinaryData = localVars.resDownloadZip.outParamBinaryZIP;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_File = result.outParamo_File;
} // inner-finally
RETURN_STATEMENT:
return outParamo_File;
}

public static class FuncActionVerifyBinaryFileSize {



}


}
