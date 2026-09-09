namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceUserProviderSetLastLoginDate</code> that represents a client
///  request call <code>ServiceUserProviderSetLastLoginDate</code> <p> Description: Service Set use
/// r Provider login date</p>
/// </summary>
public static async Task<ST_b1b6df219277397c7c2be747d587880aStructure> ServiceAPIServiceUserProviderSetLastLoginDate(IRequestContext requestContext,string inParami_userId,CancellationToken cancellationToken) {
ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return = default;
IRecord proxy_o_Return;
proxy_o_Return = await RsseSpaceOrganization.ServiceUserProviderSetLastLoginDate<ST_b1b6df219277397c7c2be747d587880aStructure>(requestContext,inParami_userId,cancellationToken);
outParamo_Return = (ST_b1b6df219277397c7c2be747d587880aStructure) proxy_o_Return;
return outParamo_Return;
}

}
