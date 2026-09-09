namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionBinaryDataSize</code> that represents the Service Studio reference action
///  <code>BinaryDataSize</code> <p> Description: Returns the size in bytes of binary data content.</p>
/// </summary>
public static async Task<int> ActionBinaryDataSize(IRequestContext requestContext,byte[] inParamBinaryData,CancellationToken cancellationToken) {
int outParamSize = default;
outParamSize = await RssExtensionBinaryData.MssBinaryDataSize(requestContext,inParamBinaryData,cancellationToken);
return outParamSize;
}

}
