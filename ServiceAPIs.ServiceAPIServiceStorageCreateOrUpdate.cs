namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceStorageCreateOrUpdate</code> that represents a client request
///  call <code>ServiceStorageCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceStorageCreateOrUpdate(IRequestContext requestContext,EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource,bool inParamDirectSave,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceTelcelStorage.ServiceStorageCreateOrUpdate(requestContext,inParamSource,inParamDirectSave,cancellationToken);
return outParamId;
}

}
