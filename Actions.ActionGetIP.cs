namespace ssConectaProveedores;

public partial class Actions {
/// <summary>
/// Action <code>ActionGetIP</code> that represents the Service Studio reference action
///  <code>GetIP</code> <p> Description: It allows you to get the client IP</p>
/// </summary>
public static async Task<(string,string)> ActionGetIP(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamClientIP = default;
string outParamAdditionalIP = default;
(outParamClientIP,outParamAdditionalIP) = await RsseSpaceGetIP.MssGetIP(requestContext,cancellationToken);
return (outParamClientIP,outParamAdditionalIP);
}

}
