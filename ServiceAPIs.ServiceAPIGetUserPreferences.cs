namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIGetUserPreferences</code> that represents a client request call
///  <code>GetUserPreferences</code> <p> Description: Get user preferences like table max records.</p>
/// </summary>
public static async Task<int> ServiceAPIGetUserPreferences(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
int outParamo_TableLinesCount = default;
outParamo_TableLinesCount = await RsseSpaceOrganization.GetUserPreferences(requestContext,inParami_UserId,cancellationToken);
return outParamo_TableLinesCount;
}

}
