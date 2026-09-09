namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceProject_Asset_ServiceDelete</code> that represents a client
///  request call <code>ServiceProject_Asset_ServiceDelete</code> <p> Description: Encapsulates th
/// e Delete entity action, enabling logic to run consistently before and after a record is
///  deleted.</p>
/// </summary>
public static async Task ServiceAPIServiceProject_Asset_ServiceDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
await RsseSpaceOrganization.ServiceProject_Asset_ServiceDelete(requestContext,inParamId,cancellationToken);
return;
}

}
