namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceUserApplicationRoleTempRevoke</code> that represents a client
///  request call <code>ServiceUserApplicationRoleTempRevoke</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<(long,ST_346a76e47f982dbf41625f8a893affccStructure)> ServiceAPIServiceUserApplicationRoleTempRevoke(IRequestContext requestContext,EN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
ST_346a76e47f982dbf41625f8a893affccStructure outParamOutput = default;
IRecord proxy_Output;
(outParamId,proxy_Output) = await RsseSpaceSecurityAuth.ServiceUserApplicationRoleTempRevoke<ST_346a76e47f982dbf41625f8a893affccStructure>(requestContext,inParamSource,cancellationToken);
outParamOutput = (ST_346a76e47f982dbf41625f8a893affccStructure) proxy_Output;
return (outParamId,outParamOutput);
}

}
