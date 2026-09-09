namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionCreateZIP</code> that represents the Service Studio reference action
///  <code>CreateZIP</code> <p> Description: Creates a memory representation of a ZIP file and returns 
/// a handle that must be passed to the other actions.</p>
/// </summary>
public static async Task<object> ActionCreateZIP(IRequestContext requestContext,int inParamCompressionLevel,CancellationToken cancellationToken) {
object outParamZIPHandle = default;
outParamZIPHandle = await RssExtensionZip.MssCreateZIP(requestContext,inParamCompressionLevel,cancellationToken);
return outParamZIPHandle;
}

}
