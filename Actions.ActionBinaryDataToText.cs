namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionBinaryDataToText</code> that represents the Service Studio reference action
///  <code>BinaryDataToText</code> <p> Description: Converts the given binary data to text using th
/// e given encoding.</p>
/// </summary>
public static async Task<string> ActionBinaryDataToText(IRequestContext requestContext,byte[] inParamBinaryData,string inParamEncoding,CancellationToken cancellationToken) {
string outParamText = default;
outParamText = await RssExtensionBinaryData.MssBinaryDataToText(requestContext,inParamBinaryData,inParamEncoding,cancellationToken);
return outParamText;
}

}
