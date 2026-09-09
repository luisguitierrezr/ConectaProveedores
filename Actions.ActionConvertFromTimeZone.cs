namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionConvertFromTimeZone</code> that represents the Service Studio reference action
///  <code>ConvertFromTimeZone</code> <p> Description: </p>
/// </summary>
public static async Task<DateTime> ActionConvertFromTimeZone(IRequestContext requestContext,DateTime inParamSourceDateTime,string inParamSourceTimeZone,string inParamDestinationTimeZone,CancellationToken cancellationToken) {
DateTime outParamConvertFromTimeZone = default;
outParamConvertFromTimeZone = await RssExternalLibraryTimeZone.MssConvertFromTimeZone(requestContext,inParamSourceDateTime,inParamSourceTimeZone,inParamDestinationTimeZone,cancellationToken);
return outParamConvertFromTimeZone;
}

}
