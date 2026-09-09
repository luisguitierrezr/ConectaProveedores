namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceAccountingAccounts_ServiceTypeCreateOrUpdat</code> that
///  represents a client request call <code>ServiceAccountingAccounts_ServiceTypeCreateOrUpdat</code
/// > <p> Description: Encapsulates the CreateOrUpdate entity action, enabling logic to run
///  consistently before and after a record is created or modified.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceAccountingAccounts_ServiceTypeCreateOrUpdat(IRequestContext requestContext,EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceOrganization.ServiceAccountingAccounts_ServiceTypeCreateOrUpdat(requestContext,inParamSource,cancellationToken);
return outParamId;
}

}
