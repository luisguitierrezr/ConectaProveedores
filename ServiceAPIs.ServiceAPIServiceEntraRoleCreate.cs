namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceEntraRoleCreate</code> that represents a client request call
///  <code>ServiceEntraRoleCreate</code> <p> Description: Encapsulates the Create entity action
/// , enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<(ST_346a76e47f982dbf41625f8a893affccStructure,bool,long)> ServiceAPIServiceEntraRoleCreate(IRequestContext requestContext,string inParami_RoleName,CancellationToken cancellationToken) {
ST_346a76e47f982dbf41625f8a893affccStructure outParamo_output = default;
bool outParamHasBeenCreated = default;
long outParamEntraRoleId = default;
IRecord proxy_o_output;
(proxy_o_output,outParamHasBeenCreated,outParamEntraRoleId) = await RsseSpaceSecurityAuth.ServiceEntraRoleCreate<ST_346a76e47f982dbf41625f8a893affccStructure>(requestContext,inParami_RoleName,cancellationToken);
outParamo_output = (ST_346a76e47f982dbf41625f8a893affccStructure) proxy_o_output;
return (outParamo_output,outParamHasBeenCreated,outParamEntraRoleId);
}

}
