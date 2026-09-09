namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceCompanyCreateOrUpdate</code> that represents a client request
///  call <code>ServiceCompanyCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceCompanyCreateOrUpdate(IRequestContext requestContext,EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceOrganization.ServiceCompanyCreateOrUpdate(requestContext,inParamSource,cancellationToken);
return outParamId;
}

}
