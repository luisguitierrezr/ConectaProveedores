namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFileData : VarsBag {
public long inParami_StorageId;
public string resBinaryDataToText_outParamText = "";

public byte[] resServiceStorageGetFile_outParamo_File = new byte[] {};
public string resServiceStorageGetFile_outParamo_filename = "";

public lcvGetFileData(long inParami_StorageId) {
this.inParami_StorageId = inParami_StorageId;
}
}
public class lcoGetFileData : VarsBag {
public byte[] outParamo_Binary = new byte[] {};

public string outParamo_Filename = "";

public string outParamo_xml = "";

public lcoGetFileData() {
}
}
/// <summary>
/// Action <code>GetFileData</code> that represents the Service Studio action <code>GetFileData</code>
///  <p> Description: Action to get Storage File Name, Binary, XML Text.</p>
/// </summary>
public static async Task<(byte[],string,string)> ActionGetFileData(IRequestContext requestContext,long inParami_StorageId,CancellationToken cancellationToken) {
byte[] outParamo_Binary = default;
string outParamo_Filename = default;
string outParamo_xml = default;
lcoGetFileData result = new lcoGetFileData();
lcvGetFileData localVars = new lcvGetFileData(inParami_StorageId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFileData", "648e672d-15d9-41fb-bc67-e05f073cba15"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFileData", "648e672d-15d9-41fb-bc67-e05f073cba15", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ServiceStorageGetFile
(localVars.resServiceStorageGetFile_outParamo_File,localVars.resServiceStorageGetFile_outParamo_filename) = await ServiceAPIs.ServiceAPIServiceStorageGetFile(requestContext,localVars.inParami_StorageId,cancellationToken);

// If_XML
if(((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.resServiceStorageGetFile_outParamo_filename), ".xml", 0, false, false)!=(-1)))) {
// BinaryDataToText
localVars.resBinaryDataToText_outParamText = await Actions.ActionBinaryDataToText(requestContext,localVars.resServiceStorageGetFile_outParamo_File,"",cancellationToken);

// Set XML_Text
// o_xml = BinaryDataToText.Text
result.outParamo_xml=localVars.resBinaryDataToText_outParamText;
} else {
// Assign Locals
// o_Filename = ServiceStorageGetFile.o_filename
result.outParamo_Filename=localVars.resServiceStorageGetFile_outParamo_filename;

// o_Binary = ServiceStorageGetFile.o_File
result.outParamo_Binary=localVars.resServiceStorageGetFile_outParamo_File;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Binary = result.outParamo_Binary;
outParamo_Filename = result.outParamo_Filename;
outParamo_xml = result.outParamo_xml;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Binary,outParamo_Filename,outParamo_xml);
}

public static class FuncActionGetFileData {



}


}
