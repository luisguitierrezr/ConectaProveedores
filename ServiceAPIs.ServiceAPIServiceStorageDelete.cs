namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceStorageDelete</code> that represents a client request call
///  <code>ServiceStorageDelete</code> <p> Description: Encapsulates the Delete entity action, enablin
/// g logic to run consistently before and after a record is deleted.</p>
/// </summary>
public static async Task ServiceAPIServiceStorageDelete(IRequestContext requestContext,long inParamId,CancellationToken cancellationToken) {
await RsseSpaceTelcelStorage.ServiceStorageDelete(requestContext,inParamId,cancellationToken);
return;
}

}
