namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPICheckOldPassword</code> that represents a client request call
///  <code>CheckOldPassword</code> <p> Description: Check and save the old password</p>
/// </summary>
public static async Task<bool> ServiceAPICheckOldPassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_IsOld = default;
outParamo_IsOld = await RsseSpaceSecurityAuth.CheckOldPassword(requestContext,inParami_Password,inParami_Email,cancellationToken);
return outParamo_IsOld;
}

}
