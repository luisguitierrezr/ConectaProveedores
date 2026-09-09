namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGrantPedidos</code> that represents a client request call
///  <code>ServiceGrantPedidos</code> <p> Description: Grant Requisiciones</p>
/// </summary>
public static async Task ServiceAPIServiceGrantPedidos(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
await RsseSpaceSecurityAuth.ServiceGrantPedidos(requestContext,inParamUserid,cancellationToken);
return;
}

}
