namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceStorageGetFile</code> that represents a client request call
///  <code>ServiceStorageGetFile</code> <p> Description: Storage Get File By Storage Id</p>
/// </summary>
public static async Task<(byte[],string)> ServiceAPIServiceStorageGetFile(IRequestContext requestContext,long inParami_StorageId,CancellationToken cancellationToken) {
byte[] outParamo_File = default;
string outParamo_filename = default;
(outParamo_File,outParamo_filename) = await RsseSpaceTelcelStorage.ServiceStorageGetFile(requestContext,inParami_StorageId,cancellationToken);
return (outParamo_File,outParamo_filename);
}

}
