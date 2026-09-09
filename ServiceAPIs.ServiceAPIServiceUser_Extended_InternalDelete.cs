namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceUser_Extended_InternalDelete</code> that represents a client
///  request call <code>ServiceUser_Extended_InternalDelete</code> <p> Description: Encapsulates th
/// e Delete entity action, enabling logic to run consistently before and after a record is
///  deleted.</p>
/// </summary>
public static async Task ServiceAPIServiceUser_Extended_InternalDelete(IRequestContext requestContext,string inParamId,CancellationToken cancellationToken) {
await RsseSpaceOrganization.ServiceUser_Extended_InternalDelete(requestContext,inParamId,cancellationToken);
return;
}

}
