namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPISavePassword</code> that represents a client request call
///  <code>SavePassword</code> <p> Description: Save user password to the list of the old ones</p>
/// </summary>
public static async Task ServiceAPISavePassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
await RsseSpaceSecurityAuth.SavePassword(requestContext,inParami_Password,inParami_Email,cancellationToken);
return;
}

}
