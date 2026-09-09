namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceSetUserData</code> that represents a client request call
///  <code>ServiceSetUserData</code> <p> Description: Service Set User Data</p>
/// </summary>
public static async Task<(ST_b1b6df219277397c7c2be747d587880aStructure,bool)> ServiceAPIServiceSetUserData(IRequestContext requestContext,string inParami_Email,string inParami_RegionToBeassigned,CancellationToken cancellationToken) {
ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return = default;
bool outParamo_HasChangedJobTitle = default;
IRecord proxy_o_Return;
(proxy_o_Return,outParamo_HasChangedJobTitle) = await RsseSpaceOrganization.ServiceSetUserData<ST_b1b6df219277397c7c2be747d587880aStructure>(requestContext,inParami_Email,inParami_RegionToBeassigned,cancellationToken);
outParamo_Return = (ST_b1b6df219277397c7c2be747d587880aStructure) proxy_o_Return;
return (outParamo_Return,outParamo_HasChangedJobTitle);
}

}
