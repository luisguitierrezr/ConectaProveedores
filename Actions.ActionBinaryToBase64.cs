namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionBinaryToBase64</code> that represents the Service Studio reference action
///  <code>BinaryToBase64</code> <p> Description: Converts binary data to Base64 text.</p>
/// </summary>
public static async Task<string> ActionBinaryToBase64(IRequestContext requestContext,byte[] inParamBinaryData,CancellationToken cancellationToken) {
string outParamBase64 = default;
outParamBase64 = await RssExtensionBinaryData.MssBinaryToBase64(requestContext,inParamBinaryData,cancellationToken);
return outParamBase64;
}

}
