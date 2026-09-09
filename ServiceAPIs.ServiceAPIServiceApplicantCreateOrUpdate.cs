namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceApplicantCreateOrUpdate</code> that represents a client request
///  call <code>ServiceApplicantCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceApplicantCreateOrUpdate(IRequestContext requestContext,EN_9230ef74b5c6f311b63c2da5a17c0eb6EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceOrganization.ServiceApplicantCreateOrUpdate(requestContext,inParamSource,cancellationToken);
return outParamId;
}

}
