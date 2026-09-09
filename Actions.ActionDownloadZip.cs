namespace ssConectaProveedores;

public partial class Actions {
public class lcvDownloadZip : VarsBag {
public RL_a1f410d0f62252476f2a43f62445ebc5 inParamFilesList;
public object resCreateZIP_outParamZIPHandle = null;

public byte[] resGetZIPBinary_outParamZIPBinary = new byte[] {};

public lcvDownloadZip(RL_a1f410d0f62252476f2a43f62445ebc5 inParamFilesList) {
this.inParamFilesList = inParamFilesList;
}
}
public class lcoDownloadZip : VarsBag {
public byte[] outParamBinaryZIP = new byte[] {};

public string outParamErrorMsg = "";

public lcoDownloadZip() {
}
}
/// <summary>
/// Action <code>DownloadZip</code> that represents the Service Studio action <code>DownloadZip</code>
///  <p> Description: </p>
/// </summary>
public static async Task<(byte[],string)> ActionDownloadZip(IRequestContext requestContext,RL_a1f410d0f62252476f2a43f62445ebc5 inParamFilesList,CancellationToken cancellationToken) {
byte[] outParamBinaryZIP = default;
string outParamErrorMsg = default;
lcoDownloadZip result = new lcoDownloadZip();
lcvDownloadZip localVars = new lcvDownloadZip(inParamFilesList);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DownloadZip", "7c5c0408-b056-49d5-93ba-f9033ee51483"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DownloadZip", "7c5c0408-b056-49d5-93ba-f9033ee51483", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// empty?
if((localVars.inParamFilesList.Empty)) {
// ErrorMsg = "List is empty"
result.outParamErrorMsg=AppUtils.GetStringResource("kMX4zWuWmUWjSm_sgMwedA#Value.-1367748615.1", "List is empty");
} else {
// CreateZIP
localVars.resCreateZIP_outParamZIPHandle = await Actions.ActionCreateZIP(requestContext,5,cancellationToken);

// Foreach FilesList
localVars.inParamFilesList.StartIteration();
try {while (!((localVars.inParamFilesList.Eof))) {
// AddFile
await Actions.ActionAddFile(requestContext,localVars.resCreateZIP_outParamZIPHandle,localVars.inParamFilesList.CurrentRec.ssName,BuiltInFunction.CurrDateTime (),localVars.inParamFilesList.CurrentRec.ssBinaryData,cancellationToken);

localVars.inParamFilesList.Advance();
}

} finally {
localVars.inParamFilesList.EndIteration();
}

// CommitChanges
await Actions.ActionCommitChanges(requestContext,localVars.resCreateZIP_outParamZIPHandle,cancellationToken);

// GetZIPBinary
localVars.resGetZIPBinary_outParamZIPBinary = await Actions.ActionGetZIPBinary(requestContext,localVars.resCreateZIP_outParamZIPHandle,cancellationToken);

// BinaryZIP = GetZIPBinary.ZIPBinary
result.outParamBinaryZIP=localVars.resGetZIPBinary_outParamZIPBinary;
}

} //close CreateActionActivity using block
} // try

finally {
outParamBinaryZIP = result.outParamBinaryZIP;
outParamErrorMsg = result.outParamErrorMsg;
} // inner-finally
RETURN_STATEMENT:
return (outParamBinaryZIP,outParamErrorMsg);
}

public static class FuncActionDownloadZip {



}


}
