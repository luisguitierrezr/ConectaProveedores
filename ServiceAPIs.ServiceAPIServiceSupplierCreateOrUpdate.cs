namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceSupplierCreateOrUpdate</code> that represents a client request
///  call <code>ServiceSupplierCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceSupplierCreateOrUpdate(IRequestContext requestContext,EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceOrganization.ServiceSupplierCreateOrUpdate(requestContext,inParamSource,cancellationToken);
return outParamId;
}

}
