namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGrantFolios</code> that represents a client request call
///  <code>ServiceGrantFolios</code> <p> Description: Grant Folios</p>
/// </summary>
public static async Task ServiceAPIServiceGrantFolios(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
await RsseSpaceSecurityAuth.ServiceGrantFolios(requestContext,inParamUserid,cancellationToken);
return;
}

}
