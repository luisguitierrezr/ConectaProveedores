namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceCheckSupplierUserEmail</code> that represents a client request
///  call <code>ServiceCheckSupplierUserEmail</code> <p> Description: Check Supplier User Email</p>
/// </summary>
public static async Task<(bool,bool,bool)> ServiceAPIServiceCheckSupplierUserEmail(IRequestContext requestContext,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_NotExists = default;
bool outParamo_NotActive = default;
bool outParamo_IsDeleted = default;
(outParamo_NotExists,outParamo_NotActive,outParamo_IsDeleted) = await RsseSpaceOrganization.ServiceCheckSupplierUserEmail(requestContext,inParami_Email,cancellationToken);
return (outParamo_NotExists,outParamo_NotActive,outParamo_IsDeleted);
}

}
