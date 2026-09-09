namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceUserApplicationRoleTempAssign</code> that represents a client
///  request call <code>ServiceUserApplicationRoleTempAssign</code> <p> Description: Encapsulates th
/// e CreateOrUpdate entity action, enabling logic to run consistently before and after a record is
///  created or modified.</p>
/// </summary>
public static async Task<(long,ST_346a76e47f982dbf41625f8a893affccStructure)> ServiceAPIServiceUserApplicationRoleTempAssign(IRequestContext requestContext,EN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource,string inParamUserId,CancellationToken cancellationToken) {
long outParamId = default;
ST_346a76e47f982dbf41625f8a893affccStructure outParamOutput = default;
IRecord proxy_Output;
(outParamId,proxy_Output) = await RsseSpaceSecurityAuth.ServiceUserApplicationRoleTempAssign<ST_346a76e47f982dbf41625f8a893affccStructure>(requestContext,inParamSource,inParamUserId,cancellationToken);
outParamOutput = (ST_346a76e47f982dbf41625f8a893affccStructure) proxy_Output;
return (outParamId,outParamOutput);
}

}
