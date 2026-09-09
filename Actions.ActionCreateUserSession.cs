namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionCreateUserSession</code> that represents the Service Studio reference action
///  <code>CreateUserSession</code> <p> Description: CreateUserSession</p>
/// </summary>
public static async Task ActionCreateUserSession(IRequestContext requestContext,CancellationToken cancellationToken) {
await RsseSpaceSecurityAuthLib.MssCreateUserSession(requestContext,cancellationToken);
return;
}

}
