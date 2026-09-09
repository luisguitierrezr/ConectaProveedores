namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetFileDataFromBase64 : VarsBag {
public string inParami_Base64;
public string inParami_Filename;
public byte[] resBase64ToBinary_outParamBinary = new byte[] {};

public string resBinaryDataToText_outParamText = "";

public lcvGetFileDataFromBase64(string inParami_Base64, string inParami_Filename) {
this.inParami_Base64 = inParami_Base64;
this.inParami_Filename = inParami_Filename;
}
}
public class lcoGetFileDataFromBase64 : VarsBag {
public byte[] outParamo_Binary = new byte[] {};

public string outParamo_xml = "";

public lcoGetFileDataFromBase64() {
}
}
/// <summary>
/// Action <code>GetFileDataFromBase64</code> that represents the Service Studio action
///  <code>GetFileDataFromBase64</code> <p> Description: Action to get Storage File Name, Binary, XM
/// L Text.</p>
/// </summary>
public static async Task<(byte[],string)> ActionGetFileDataFromBase64(IRequestContext requestContext,string inParami_Base64,string inParami_Filename,CancellationToken cancellationToken) {
byte[] outParamo_Binary = default;
string outParamo_xml = default;
lcoGetFileDataFromBase64 result = new lcoGetFileDataFromBase64();
lcvGetFileDataFromBase64 localVars = new lcvGetFileDataFromBase64(inParami_Base64, inParami_Filename);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetFileDataFromBase64", "470a0bc9-161f-4219-90dd-a8b32f82e19e"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetFileDataFromBase64", "470a0bc9-161f-4219-90dd-a8b32f82e19e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Base64ToBinary
localVars.resBase64ToBinary_outParamBinary = await Actions.ActionBase64ToBinary(requestContext,localVars.inParami_Base64,cancellationToken);

// If_XML
if(((BuiltInFunction.IndexSC (BuiltInFunction.ToLower (localVars.inParami_Filename), ".xml", 0, false, false)!=(-1)))) {
// BinaryDataToText
localVars.resBinaryDataToText_outParamText = await Actions.ActionBinaryDataToText(requestContext,localVars.resBase64ToBinary_outParamBinary,"",cancellationToken);

// Set XML_Text
// o_xml = BinaryDataToText.Text
result.outParamo_xml=localVars.resBinaryDataToText_outParamText;
} else {
// Assign Locals
// o_Binary = Base64ToBinary.Binary
result.outParamo_Binary=localVars.resBase64ToBinary_outParamBinary;
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_Binary = result.outParamo_Binary;
outParamo_xml = result.outParamo_xml;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Binary,outParamo_xml);
}

public static class FuncActionGetFileDataFromBase64 {



}


}
