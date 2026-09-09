namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetTimeZone</code> that represents the Service Studio reference action
///  <code>GetTimeZone</code> <p> Description: </p>
/// </summary>
public static async Task<ST_98371f99cd7bfeee4fab07e43606a1b5Structure> ActionGetTimeZone(IRequestContext requestContext,string inParamIdentifier,CancellationToken cancellationToken) {
ST_98371f99cd7bfeee4fab07e43606a1b5Structure outParamTimeZone = default;
OutSystems.Application.Extensibility.DataTypes.IRecord proxy_TimeZone;
proxy_TimeZone = await RssExternalLibraryTimeZone.MssGetTimeZone<ST_98371f99cd7bfeee4fab07e43606a1b5Structure>(requestContext,inParamIdentifier,cancellationToken);
outParamTimeZone = (ST_98371f99cd7bfeee4fab07e43606a1b5Structure) proxy_TimeZone;
return outParamTimeZone;
}

}
