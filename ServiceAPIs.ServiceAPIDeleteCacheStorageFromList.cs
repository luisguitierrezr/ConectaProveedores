namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIDeleteCacheStorageFromList</code> that represents a client request call
///  <code>DeleteCacheStorageFromList</code> <p> Description: Delete a list of Cache files</p>
/// </summary>
public static async Task ServiceAPIDeleteCacheStorageFromList(IRequestContext requestContext,BasicTypeList<long> inParamStorageList,CancellationToken cancellationToken) {
await RsseSpaceTelcelStorage.DeleteCacheStorageFromList(requestContext,inParamStorageList,cancellationToken);
return;
}

}
