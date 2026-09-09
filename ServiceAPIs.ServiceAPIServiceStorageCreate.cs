namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceStorageCreate</code> that represents a client request call
///  <code>ServiceStorageCreate</code> <p> Description: Encapsulates the Create entity action, enablin
/// g logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceStorageCreate(IRequestContext requestContext,EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord inParamSource,bool inParamDirectSave,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceTelcelStorage.ServiceStorageCreate(requestContext,inParamSource,inParamDirectSave,cancellationToken);
return outParamId;
}

}
