namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIGetMaxSavedOldPasswords</code> that represents a client request call
///  <code>GetMaxSavedOldPasswords</code> <p> Description: GetMaxSavedOldPasswords</p>
/// </summary>
public static async Task<int> ServiceAPIGetMaxSavedOldPasswords(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamValue = default;
outParamValue = await RsseSpaceSecurityAuth.GetMaxSavedOldPasswords(requestContext,cancellationToken);
return outParamValue;
}

}
