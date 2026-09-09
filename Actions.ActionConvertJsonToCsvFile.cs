namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionConvertJsonToCsvFile</code> that represents the Service Studio reference action
///  <code>ConvertJsonToCsvFile</code> <p> Description: Converts a JSON string to a CSV file and return
/// s it as a byte array.</p>
/// </summary>
public static async Task<byte[]> ActionConvertJsonToCsvFile(IRequestContext requestContext,string inParamjsonString,CancellationToken cancellationToken) {
byte[] outParamConvertJsonToCsvFile = default;
outParamConvertJsonToCsvFile = await RssExternalLibraryDataExportUtilities.MssConvertJsonToCsvFile(requestContext,inParamjsonString,cancellationToken);
return outParamConvertJsonToCsvFile;
}

}
