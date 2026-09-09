namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionCheckUserSessionDONOTUSE</code> that represents the Service Studio reference
///  action <code>CheckUserSessionDONOTUSE</code> <p> Description: CheckUserSession</p>
/// </summary>
public static async Task<bool> ActionCheckUserSessionDONOTUSE(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsValidSession = default;
outParamIsValidSession = await RsseSpaceSecurityAuthLib.MssCheckUserSessionDONOTUSE(requestContext,cancellationToken);
return outParamIsValidSession;
}

}
