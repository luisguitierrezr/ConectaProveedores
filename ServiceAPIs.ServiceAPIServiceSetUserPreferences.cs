namespace ssConectaProveedores;

public partial class ServiceAPIs {
/// <summary>
/// ServiceAPI <code>ServiceAPIServiceSetUserPreferences</code> that represents a client request call
///  <code>ServiceSetUserPreferences</code> <p> Description: Save user preferences to database.</p>
/// </summary>
public static async Task<ST_b1b6df219277397c7c2be747d587880aStructure> ServiceAPIServiceSetUserPreferences(IRequestContext requestContext,EN_43bc359d08ba76411e7c349a19aa5aa1EntityRecord inParami_Preferences,CancellationToken cancellationToken) {
ST_b1b6df219277397c7c2be747d587880aStructure outParamo_Return = default;
IRecord proxy_o_Return;
proxy_o_Return = await RsseSpaceOrganization.ServiceSetUserPreferences<ST_b1b6df219277397c7c2be747d587880aStructure>(requestContext,inParami_Preferences,cancellationToken);
outParamo_Return = (ST_b1b6df219277397c7c2be747d587880aStructure) proxy_o_Return;
return outParamo_Return;
}

}
