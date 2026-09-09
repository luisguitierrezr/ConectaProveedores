namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetSettings2</code> that represents the Service Studio reference action
///  <code>GetSettings2</code> <p> Description: Get settings values</p>
/// </summary>
public static async Task<bool> ActionGetSettings2(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamEnableNotifications = default;
outParamEnableNotifications = await RsseSpaceTelcel_Theme.MssGetSettings2(requestContext,cancellationToken);
return outParamEnableNotifications;
}

}
