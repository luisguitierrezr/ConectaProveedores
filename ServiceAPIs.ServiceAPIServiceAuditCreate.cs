namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceAuditCreate</code> that represents a client request call
///  <code>ServiceAuditCreate</code> <p> Description: Encapsulates the Create entity action, enablin
/// g logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ServiceAPIServiceAuditCreate(IRequestContext requestContext,ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure inParamSource,string inParamIP,CancellationToken cancellationToken) {
long outParamId = default;
outParamId = await RsseSpaceAuditEngine.ServiceAuditCreate(requestContext,inParamSource,inParamIP,cancellationToken);
return outParamId;
}

}
