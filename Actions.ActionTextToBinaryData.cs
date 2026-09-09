namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionTextToBinaryData</code> that represents the Service Studio reference action
///  <code>TextToBinaryData</code> <p> Description: Converts a text to binary data.</p>
/// </summary>
public static async Task<byte[]> ActionTextToBinaryData(IRequestContext requestContext,string inParamText,string inParamEncoding,CancellationToken cancellationToken) {
byte[] outParamBinaryData = default;
outParamBinaryData = await RssExtensionBinaryData.MssTextToBinaryData(requestContext,inParamText,inParamEncoding,cancellationToken);
return outParamBinaryData;
}

}
