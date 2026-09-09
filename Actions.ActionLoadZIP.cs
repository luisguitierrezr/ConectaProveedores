namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionLoadZIP</code> that represents the Service Studio reference action
///  <code>LoadZIP</code> <p> Description: Loads a ZIP file into memory and returns a handle that mus
/// t be passed to the other actions.</p>
/// </summary>
public static async Task<object> ActionLoadZIP(IRequestContext requestContext,byte[] inParamZIPBinary,string inParamPassword,CancellationToken cancellationToken) {
object outParamZIPHandle = default;
outParamZIPHandle = await RssExtensionZip.MssLoadZIP(requestContext,inParamZIPBinary,inParamPassword,cancellationToken);
return outParamZIPHandle;
}

}
