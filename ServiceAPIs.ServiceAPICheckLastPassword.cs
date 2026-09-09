namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICheckLastPassword</code> that represents a client request call
///  <code>CheckLastPassword</code> <p> Description: Check last password saved</p>
/// </summary>
public static async Task<bool> ServiceAPICheckLastPassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_IsCorrect = default;
outParamo_IsCorrect = await RsseSpaceSecurityAuth.CheckLastPassword(requestContext,inParami_Password,inParami_Email,cancellationToken);
return outParamo_IsCorrect;
}

}
