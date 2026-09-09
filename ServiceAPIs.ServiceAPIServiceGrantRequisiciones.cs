namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceGrantRequisiciones</code> that represents a client request call
///  <code>ServiceGrantRequisiciones</code> <p> Description: Grant Requisiciones</p>
/// </summary>
public static async Task ServiceAPIServiceGrantRequisiciones(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
await RsseSpaceSecurityAuth.ServiceGrantRequisiciones(requestContext,inParamUserid,cancellationToken);
return;
}

}
