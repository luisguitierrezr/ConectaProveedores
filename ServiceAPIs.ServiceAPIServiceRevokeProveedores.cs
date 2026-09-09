namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceRevokeProveedores</code> that represents a client request call
///  <code>ServiceRevokeProveedores</code> <p> Description: Grant Proveedores</p>
/// </summary>
public static async Task ServiceAPIServiceRevokeProveedores(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
await RsseSpaceSecurityAuth.ServiceRevokeProveedores(requestContext,inParamUserid,cancellationToken);
return;
}

}
