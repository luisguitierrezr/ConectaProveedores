namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGrantProveedores</code> that represents a client request call
///  <code>ServiceGrantProveedores</code> <p> Description: Grant Proveedores</p>
/// </summary>
public static async Task ServiceAPIServiceGrantProveedores(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
await RsseSpaceSecurityAuth.ServiceGrantProveedores(requestContext,inParamUserid,cancellationToken);
return;
}

}
