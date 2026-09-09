namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetZIPBinary</code> that represents the Service Studio reference action
///  <code>GetZIPBinary</code> <p> Description: Returns the binary data value of a ZIP loaded i
/// n memory.</p>
/// </summary>
public static async Task<byte[]> ActionGetZIPBinary(IRequestContext requestContext,object inParamZIPHandle,CancellationToken cancellationToken) {
byte[] outParamZIPBinary = default;
outParamZIPBinary = await RssExtensionZip.MssGetZIPBinary(requestContext,inParamZIPHandle,cancellationToken);
return outParamZIPBinary;
}

}
