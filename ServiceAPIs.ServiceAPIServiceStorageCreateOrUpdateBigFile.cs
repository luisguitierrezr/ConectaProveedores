namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceStorageCreateOrUpdateBigFile</code> that represents a client
///  request call <code>ServiceStorageCreateOrUpdateBigFile</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceStorageCreateOrUpdateBigFile(IRequestContext requestContext,EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource,bool inParamDirectSave,long inParamFileId,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceTelcelStorage.ServiceStorageCreateOrUpdateBigFile(requestContext,inParamSource,inParamDirectSave,inParamFileId,cancellationToken);
return outParamId;
}

}
