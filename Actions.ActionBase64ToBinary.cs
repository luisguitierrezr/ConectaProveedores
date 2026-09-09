namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionBase64ToBinary</code> that represents the Service Studio reference action
///  <code>Base64ToBinary</code> <p> Description: Converts Base64 text into binary data.</p>
/// </summary>
public static async Task<byte[]> ActionBase64ToBinary(IRequestContext requestContext,string inParamBase64,CancellationToken cancellationToken) {
byte[] outParamBinary = default;
outParamBinary = await RssExtensionBinaryData.MssBase64ToBinary(requestContext,inParamBase64,cancellationToken);
return outParamBinary;
}

}
