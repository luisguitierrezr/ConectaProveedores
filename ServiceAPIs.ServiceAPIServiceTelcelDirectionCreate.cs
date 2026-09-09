namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceTelcelDirectionCreate</code> that represents a client request
///  call <code>ServiceTelcelDirectionCreate</code> <p> Description: Encapsulates the Create entit
/// y action, enabling logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceTelcelDirectionCreate(IRequestContext requestContext,EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceOrganization.ServiceTelcelDirectionCreate(requestContext,inParamSource,cancellationToken);
return outParamId;
}

}
